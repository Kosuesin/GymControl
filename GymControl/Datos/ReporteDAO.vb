Imports MySqlConnector
Imports System.Data

''' <summary>
''' Acceso a datos del módulo de reportes R04, R05 y R06.
'''
''' Todo el SQL vive aquí. El formulario nunca arma consultas.
''' Las consultas usan exclusivamente las vistas del módulo y el
''' usuario MariaDB gym_reportes (solo SELECT).
''' </summary>
Public Class ReporteDAO

    ' =========================================================
    ' R04 - INGRESOS POR PERÍODO
    ' =========================================================

    Public Function ListarIngresos(filtro As FiltroReporte) As DataTable

        ValidarFiltro(filtro)

        Dim sql As String =
            "SELECT id_pago, fecha_pago, fecha, periodo, metodo_pago, referencia, " &
            "estado_pago, monto, monto_vigente, monto_anulado, " &
            "id_membresia, tipo_membresia, id_socio, cedula, socio, registrado_por " &
            "FROM vw_ingresos_detalle " &
            "WHERE fecha_pago >= @fechaInicio " &
            "AND fecha_pago < @fechaFin " &
            "AND (@metodoPago IS NULL OR metodo_pago = @metodoPago) " &
            "ORDER BY metodo_pago, fecha, fecha_pago, id_pago"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@fechaInicio", filtro.FechaInicio.Date)
                cmd.Parameters.AddWithValue("@fechaFin", filtro.FechaFinExclusiva)
                cmd.Parameters.AddWithValue("@metodoPago",
                    If(filtro.EsTodosLosMetodos,
                       CType(DBNull.Value, Object),
                       filtro.MetodoPagoNormalizado()))

                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("Ingresos")
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    Public Function ListarMetodosPago() As DataTable

        Const sql As String =
            "SELECT metodo_pago FROM vw_metodos_pago ORDER BY metodo_pago"

        Return Consultar(sql)

    End Function

    ' =========================================================
    ' R05 - ESTADO DE CUENTA DEL SOCIO
    ' =========================================================

    ''' <summary>
    ''' Catálogo de socios para el combo. Agrupa los saldos por
    ''' socio e incluye socios sin membresías con totales en cero.
    ''' </summary>
    Public Function ListarSocios() As DataTable

        Const sql As String =
            "SELECT id_socio, MAX(cedula) AS cedula, MAX(socio) AS socio, " &
            "MAX(telefono) AS telefono, MAX(correo) AS correo, " &
            "MAX(socio_activo) AS socio_activo, " &
            "CAST(COUNT(id_membresia) AS SIGNED) AS total_membresias, " &
            "COALESCE(SUM(saldo_membresia), 0.00) AS saldo_pendiente " &
            "FROM vw_saldos_membresia " &
            "GROUP BY id_socio " &
            "ORDER BY socio"

        Return Consultar(sql)

    End Function

    ''' <summary>
    ''' Membresías del socio con su saldo unificado.
    ''' </summary>
    Public Function ListarMembresiasEstadoCuenta(idSocio As Integer) As DataTable

        If idSocio <= 0 Then
            Throw New ArgumentException("El socio seleccionado no es válido.", NameOf(idSocio))
        End If

        Const sql As String =
            "SELECT id_socio, cedula, socio, id_membresia, tipo_membresia, " &
            "fecha_inicio, fecha_vencimiento, estado_membresia, precio_pactado, " &
            "total_pagado_membresia, total_anulado_membresia, saldo_membresia " &
            "FROM vw_saldos_membresia " &
            "WHERE id_socio = @idSocio " &
            "AND id_membresia IS NOT NULL " &
            "ORDER BY fecha_inicio DESC, id_membresia DESC"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("Membresias")
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    ''' <summary>
    ''' Pagos del socio desde una fecha. Los pagos anulados se
    ''' incluyen identificados; el saldo de la membresía no los
    ''' descuenta.
    ''' </summary>
    Public Function ListarPagosEstadoCuenta(idSocio As Integer,
                                            fechaDesde As Date?) As DataTable

        If idSocio <= 0 Then
            Throw New ArgumentException("El socio seleccionado no es válido.", NameOf(idSocio))
        End If

        Dim desde As Date = If(fechaDesde.HasValue, fechaDesde.Value.Date, New Date(1900, 1, 1))

        Const sql As String =
            "SELECT id_socio, id_membresia, tipo_membresia, id_pago, fecha_pago, " &
            "monto, metodo_pago, referencia, observacion, anulado, estado_pago, " &
            "registrado_por " &
            "FROM vw_estado_cuenta " &
            "WHERE id_socio = @idSocio " &
            "AND id_pago IS NOT NULL " &
            "AND fecha_pago >= @fechaDesde " &
            "ORDER BY fecha_pago DESC, id_pago DESC"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cmd.Parameters.AddWithValue("@fechaDesde", desde)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("Pagos")
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    ''' <summary>
    ''' Resumen del socio calculado desde la MISMA vista de saldos
    ''' por membresía que usa el detalle.
    ''' </summary>
    Public Function ObtenerResumenEstadoCuenta(idSocio As Integer) As DataRow

        If idSocio <= 0 Then
            Throw New ArgumentException("El socio seleccionado no es válido.", NameOf(idSocio))
        End If

        Const sql As String =
            "SELECT id_socio, MAX(cedula) AS cedula, MAX(socio) AS socio, " &
            "MAX(telefono) AS telefono, MAX(correo) AS correo, " &
            "MAX(socio_activo) AS socio_activo, " &
            "CAST(COUNT(id_membresia) AS SIGNED) AS total_membresias, " &
            "CAST(COALESCE(SUM(CASE WHEN estado_membresia = 'ACTIVA' THEN 1 ELSE 0 END), 0) AS SIGNED) AS membresias_activas, " &
            "CAST(COALESCE(SUM(CASE WHEN estado_membresia = 'VENCIDA' THEN 1 ELSE 0 END), 0) AS SIGNED) AS membresias_vencidas, " &
            "CAST(COALESCE(SUM(CASE WHEN estado_membresia = 'SUSPENDIDA' THEN 1 ELSE 0 END), 0) AS SIGNED) AS membresias_suspendidas, " &
            "CAST(COALESCE(SUM(CASE WHEN estado_membresia = 'CANCELADA' THEN 1 ELSE 0 END), 0) AS SIGNED) AS membresias_canceladas, " &
            "COALESCE(SUM(precio_pactado), 0.00) AS total_pactado, " &
            "COALESCE(SUM(total_pagado_membresia), 0.00) AS total_pagado, " &
            "COALESCE(SUM(total_anulado_membresia), 0.00) AS total_anulado, " &
            "COALESCE(SUM(saldo_membresia), 0.00) AS saldo_pendiente, " &
            "MIN(fecha_inicio) AS primera_membresia, " &
            "MAX(fecha_vencimiento) AS ultima_membresia " &
            "FROM vw_saldos_membresia " &
            "WHERE id_socio = @idSocio " &
            "GROUP BY id_socio"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("ResumenEstadoCuenta")
                    adaptador.Fill(tabla)
                    If tabla.Rows.Count = 0 Then Return Nothing
                    Return tabla.Rows(0)
                End Using
            End Using
        End Using

    End Function

    ' =========================================================
    ' R06 - HORARIO SEMANAL Y OCUPACIÓN ESTIMADA
    ' =========================================================

    Public Function ListarHorario(filtro As FiltroReporte) As DataTable

        ValidarFiltro(filtro)

        Dim sql As String =
            "SELECT id_horario, dia_semana, dia, hora_inicio, hora_fin, horas, " &
            "id_actividad, actividad, duracion_min, cupo_maximo, " &
            "id_instructor, instructor, especialidad, id_sala, sala, capacidad, " &
            "activo, estado, ocupacion_estimada_pct " &
            "FROM vw_horario_semanal " &
            "WHERE (@idSala IS NULL OR id_sala = @idSala) " &
            "AND (@idInstructor IS NULL OR id_instructor = @idInstructor) " &
            "AND (@soloActivos = 0 OR activo = 1) " &
            "ORDER BY dia_semana, hora_inicio, actividad"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosHorario(cmd, filtro)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("Horario")
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    Public Function ObtenerResumenHorarioSala(filtro As FiltroReporte) As DataTable

        ValidarFiltro(filtro)

        Dim sql As String =
            "SELECT id_sala, sala, capacidad, " &
            "CAST(COUNT(*) AS SIGNED) AS clases, " &
            "ROUND(SUM(horas), 2) AS horas, " &
            "ROUND(AVG(ocupacion_estimada_pct), 1) AS ocupacion_estimada_prom_pct " &
            "FROM vw_horario_semanal " &
            "WHERE (@idSala IS NULL OR id_sala = @idSala) " &
            "AND (@idInstructor IS NULL OR id_instructor = @idInstructor) " &
            "AND (@soloActivos = 0 OR activo = 1) " &
            "GROUP BY id_sala, sala, capacidad " &
            "ORDER BY sala"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosHorario(cmd, filtro)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("ResumenSala")
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    Public Function ObtenerResumenHorarioInstructor(filtro As FiltroReporte) As DataTable

        ValidarFiltro(filtro)

        Dim sql As String =
            "SELECT id_instructor, instructor, especialidad, " &
            "CAST(COUNT(*) AS SIGNED) AS clases, " &
            "ROUND(SUM(horas), 2) AS horas, " &
            "CAST(COUNT(DISTINCT id_sala) AS SIGNED) AS salas_distintas, " &
            "CAST(COUNT(DISTINCT id_actividad) AS SIGNED) AS actividades_distintas " &
            "FROM vw_horario_semanal " &
            "WHERE (@idSala IS NULL OR id_sala = @idSala) " &
            "AND (@idInstructor IS NULL OR id_instructor = @idInstructor) " &
            "AND (@soloActivos = 0 OR activo = 1) " &
            "GROUP BY id_instructor, instructor, especialidad " &
            "ORDER BY instructor"

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosHorario(cmd, filtro)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable("ResumenInstructor")
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    Public Function ListarSalas() As DataTable

        Const sql As String =
            "SELECT id_sala, sala, capacidad, activo " &
            "FROM vw_salas ORDER BY sala"

        Return Consultar(sql)

    End Function

    Public Function ListarInstructores() As DataTable

        Const sql As String =
            "SELECT id_instructor, cedula, instructor, especialidad, activo " &
            "FROM vw_instructores ORDER BY instructor"

        Return Consultar(sql)

    End Function


' =========================================================
' R07 - CARTERA DE SALDOS PENDIENTES
' =========================================================

Public Function ListarCarteraSaldos(incluirAlDia As Boolean) As DataTable

    Const sql As String =
        "SELECT id_membresia, cedula, socio, telefono, " &
        "tipo_membresia, fecha_inicio, fecha_vencimiento, " &
        "precio_pactado, total_pagado_membresia, saldo_membresia " &
        "FROM vw_saldos_membresia " &
        "WHERE id_membresia IS NOT NULL " &
        "AND (@incluirAlDia = 1 OR saldo_membresia > 0) " &
        "ORDER BY fecha_vencimiento ASC, socio ASC"

    Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
        Using cmd As New MySqlCommand(sql, cn)

            cmd.Parameters.AddWithValue(
                "@incluirAlDia", If(incluirAlDia, 1, 0))

            cn.Open()

            Using adaptador As New MySqlDataAdapter(cmd)
                Dim tabla As New DataTable("Cartera")
                adaptador.Fill(tabla)
                Return tabla
            End Using

        End Using
    End Using

End Function


    ' =========================================================
    ' UTILIDADES
    ' =========================================================

    Private Shared Function Consultar(sql As String) As DataTable

        Using cn As MySqlConnection = ConexionReportes.ObtenerConexionReportes()
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    Dim tabla As New DataTable()
                    adaptador.Fill(tabla)
                    Return tabla
                End Using
            End Using
        End Using

    End Function

    Private Shared Sub AgregarParametrosHorario(cmd As MySqlCommand, filtro As FiltroReporte)

        cmd.Parameters.AddWithValue("@idSala",
            If(filtro.IdSala.HasValue, CType(filtro.IdSala.Value, Object), DBNull.Value))

        cmd.Parameters.AddWithValue("@idInstructor",
            If(filtro.IdInstructor.HasValue, CType(filtro.IdInstructor.Value, Object), DBNull.Value))

        cmd.Parameters.AddWithValue("@soloActivos", If(filtro.SoloActivos, 1, 0))

    End Sub

    Private Shared Sub ValidarFiltro(filtro As FiltroReporte)

        If filtro Is Nothing Then
            Throw New ArgumentNullException(NameOf(filtro))
        End If

        Dim mensaje As String = filtro.Validar()
        If Not String.IsNullOrWhiteSpace(mensaje) Then
            Throw New ArgumentException(mensaje, NameOf(filtro))
        End If

    End Sub

End Class
