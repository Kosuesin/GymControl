Imports MySqlConnector
Imports System.Data

Public Class MembresiaDAO

    Public Function ListarTiposMembresia() As DataTable
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_tipo, nombre, duracion_dias, precio " &
            "FROM tipos_membresia WHERE activo = @activo ORDER BY nombre"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@activo", 1)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Function ListarMembresiasPorSocio(idSocio As Integer) As DataTable
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT m.id_membresia, m.id_tipo, tm.nombre AS Tipo, " &
            "m.fecha_inicio AS FechaInicio, m.fecha_vencimiento AS FechaVencimiento, " &
            "m.precio_pactado AS Precio, m.estado AS Estado, " &
            "CONCAT(tm.nombre, ' | ', DATE_FORMAT(m.fecha_inicio, '%d/%m/%Y'), ' - ', " &
            "DATE_FORMAT(m.fecha_vencimiento, '%d/%m/%Y')) AS Descripcion " &
            "FROM membresias m INNER JOIN tipos_membresia tm ON m.id_tipo = tm.id_tipo " &
            "WHERE m.id_socio = @idSocio ORDER BY m.fecha_inicio DESC, m.id_membresia DESC"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Function ObtenerMembresiaPorId(idMembresia As Integer) As DataRow
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT m.id_membresia, m.id_socio, m.id_tipo, tm.nombre AS Tipo, " &
            "tm.duracion_dias, tm.precio, tm.incluye_clases, m.fecha_inicio, m.fecha_vencimiento, " &
            "m.precio_pactado, m.estado FROM membresias m " &
            "INNER JOIN tipos_membresia tm ON m.id_tipo = tm.id_tipo " &
            "WHERE m.id_membresia = @idMembresia LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idMembresia", idMembresia)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    Public Function InsertarMembresia(idSocio As Integer, idTipo As Integer,
                                      fechaInicio As Date, fechaVencimiento As Date,
                                      precioPactado As Decimal, estado As String) As Boolean
        Const sql As String =
            "INSERT INTO membresias (id_socio, id_tipo, fecha_inicio, fecha_vencimiento, precio_pactado, estado) " &
            "VALUES (@idSocio, @idTipo, @fechaInicio, @fechaVencimiento, @precioPactado, @estado)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cmd.Parameters.AddWithValue("@idTipo", idTipo)
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date)
                cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento.Date)
                cmd.Parameters.AddWithValue("@precioPactado", precioPactado)
                cmd.Parameters.AddWithValue("@estado", estado)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarMembresia(idMembresia As Integer, fechaInicio As Date,
                                        fechaVencimiento As Date, precioPactado As Decimal,
                                        estado As String) As Boolean
        Const sql As String =
            "UPDATE membresias SET fecha_inicio = @fechaInicio, fecha_vencimiento = @fechaVencimiento, " &
            "precio_pactado = @precioPactado, estado = @estado WHERE id_membresia = @idMembresia"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date)
                cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento.Date)
                cmd.Parameters.AddWithValue("@precioPactado", precioPactado)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@idMembresia", idMembresia)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function SuspenderMembresia(idMembresia As Integer) As Boolean
        Return CambiarEstado(idMembresia, "SUSPENDIDA")
    End Function

    Public Function CancelarMembresia(idMembresia As Integer) As Boolean
        Return CambiarEstado(idMembresia, "CANCELADA")
    End Function

    Private Function CambiarEstado(idMembresia As Integer, estado As String) As Boolean
        Const sql As String = "UPDATE membresias SET estado = @estado WHERE id_membresia = @idMembresia"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@idMembresia", idMembresia)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' =========================================================
    ' LISTAR MEMBRESÍAS PRÓXIMAS A VENCER
    '
    ' Membresías en estado ACTIVA cuya fecha de
    ' vencimiento está entre la fecha actual y los
    ' próximos días de anticipación indicados.
    ' =========================================================
    Public Function ListarMembresiasPorVencer(
        fechaActual As Date,
        Optional diasAnticipacion As Integer = 7
    ) As DataTable

        Dim tabla As New DataTable()

        Dim fechaLimite As Date =
            fechaActual.Date.AddDays(diasAnticipacion)

        Dim sql As String =
            "SELECT
                CONCAT(s.nombres, ' ', s.apellidos) AS Socio,
                tm.nombre AS Tipo,
                DATE_FORMAT(m.fecha_vencimiento, '%d/%m/%Y') AS 'Fecha de vencimiento',
                DATEDIFF(m.fecha_vencimiento, @fechaActual) AS 'Días restantes'
             FROM membresias m
             INNER JOIN socios s
                ON m.id_socio = s.id_socio
             INNER JOIN tipos_membresia tm
                ON m.id_tipo = tm.id_tipo
             WHERE m.estado = @estado
               AND m.fecha_vencimiento >= @fechaActual
               AND m.fecha_vencimiento < @fechaLimite
             ORDER BY m.fecha_vencimiento ASC,
                      s.nombres ASC"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@fechaActual",
                    fechaActual.Date
                )

                cmd.Parameters.AddWithValue(
                    "@fechaLimite",
                    fechaLimite
                )

                cmd.Parameters.AddWithValue(
                    "@estado",
                    "ACTIVA"
                )

                cn.Open()

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using

        End Using

        Return tabla

    End Function

End Class
