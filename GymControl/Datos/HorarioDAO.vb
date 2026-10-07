Imports MySqlConnector
Imports System.Data

Public Class HorarioDAO

    ' =========================================================
    ' LISTAR HORARIOS (CON FILTROS OPCIONALES)
    '
    ' dia_semana: 1=Lunes, 2=Martes, ..., 7=Domingo
    ' =========================================================
    Public Function ListarHorarios(Optional idInstructor As Integer? = Nothing,
                                   Optional idSala As Integer? = Nothing,
                                   Optional soloActivos As Boolean = False) As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT h.id_horario, h.id_instructor, h.id_actividad, h.id_sala, h.dia_semana, " &
            "CASE h.dia_semana WHEN 1 THEN 'Lunes' WHEN 2 THEN 'Martes' WHEN 3 THEN 'Miércoles' " &
            "WHEN 4 THEN 'Jueves' WHEN 5 THEN 'Viernes' WHEN 6 THEN 'Sábado' WHEN 7 THEN 'Domingo' END AS Dia, " &
            "DATE_FORMAT(h.hora_inicio, '%H:%i') AS HoraInicio, " &
            "DATE_FORMAT(h.hora_fin, '%H:%i') AS HoraFin, " &
            "a.nombre AS Actividad, " &
            "CONCAT(i.nombres, ' ', i.apellidos) AS Instructor, " &
            "sa.nombre AS Sala, " &
            "CASE WHEN h.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM horarios h " &
            "INNER JOIN actividades a ON h.id_actividad = a.id_actividad " &
            "INNER JOIN instructores i ON h.id_instructor = i.id_instructor " &
            "INNER JOIN salas sa ON h.id_sala = sa.id_sala " &
            "WHERE (@idInstructor IS NULL OR h.id_instructor = @idInstructor) " &
            "AND (@idSala IS NULL OR h.id_sala = @idSala) " &
            "AND (@soloActivos = 0 OR h.activo = 1) " &
            "ORDER BY h.dia_semana, h.hora_inicio, a.nombre"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idInstructor",
                    If(idInstructor.HasValue, CType(idInstructor.Value, Object), DBNull.Value))
                cmd.Parameters.AddWithValue("@idSala",
                    If(idSala.HasValue, CType(idSala.Value, Object), DBNull.Value))
                cmd.Parameters.AddWithValue("@soloActivos", If(soloActivos, 1, 0))
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        Return tabla
    End Function

    ' =========================================================
    ' OBTENER UN HORARIO POR ID (DATOS COMPLETOS)
    ' =========================================================
    Public Function ObtenerHorarioPorId(idHorario As Integer) As DataRow
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_horario, id_instructor, id_actividad, id_sala, dia_semana, " &
            "hora_inicio, hora_fin, activo " &
            "FROM horarios WHERE id_horario = @idHorario LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idHorario", idHorario)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    ' =========================================================
    ' VERIFICAR CONFLICTOS DE PROGRAMACIÓN
    '
    ' Devuelve "" si no hay conflicto o el mensaje del
    ' conflicto detectado (instructor ocupado / sala ocupada).
    ' =========================================================
    Public Function VerificarConflictos(idInstructor As Integer, idSala As Integer, dia As Integer,
                                        horaInicio As TimeSpan, horaFin As TimeSpan,
                                        Optional excluirId As Integer? = Nothing) As String
        If HayClaseEnRango("id_instructor", idInstructor, dia, horaInicio, horaFin, excluirId) Then
            Return "El instructor ya tiene una clase programada en ese rango de horario."
        End If
        If HayClaseEnRango("id_sala", idSala, dia, horaInicio, horaFin, excluirId) Then
            Return "La sala ya está ocupada en ese rango de horario."
        End If
        Return ""
    End Function

    ' Detecta solapamiento (hora_inicio < fin AND hora_fin > inicio)
    ' sobre horarios activos del mismo día.
    Private Function HayClaseEnRango(columna As String, valor As Integer, dia As Integer,
                                     horaInicio As TimeSpan, horaFin As TimeSpan,
                                     excluirId As Integer?) As Boolean
        Dim sql As String =
            "SELECT COUNT(*) FROM horarios " &
            "WHERE activo = 1 AND dia_semana = @dia " &
            "AND hora_inicio < @horaFin AND hora_fin > @horaInicio " &
            "AND " & columna & " = @valor " &
            "AND (@excluirId IS NULL OR id_horario <> @excluirId)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@dia", dia)
                cmd.Parameters.AddWithValue("@horaInicio", horaInicio)
                cmd.Parameters.AddWithValue("@horaFin", horaFin)
                cmd.Parameters.AddWithValue("@valor", valor)
                cmd.Parameters.AddWithValue("@excluirId",
                    If(excluirId.HasValue, CType(excluirId.Value, Object), DBNull.Value))
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    ' =========================================================
    ' INSERTAR HORARIO
    ' =========================================================
    Public Function InsertarHorario(idInstructor As Integer, idActividad As Integer, idSala As Integer,
                                    dia As Integer, horaInicio As TimeSpan, horaFin As TimeSpan,
                                    activo As Boolean) As Boolean
        Const sql As String =
            "INSERT INTO horarios (id_instructor, id_actividad, id_sala, dia_semana, hora_inicio, hora_fin, activo) " &
            "VALUES (@idInstructor, @idActividad, @idSala, @dia, @horaInicio, @horaFin, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosHorario(cmd, idInstructor, idActividad, idSala, dia, horaInicio, horaFin, activo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' =========================================================
    ' ACTUALIZAR HORARIO
    ' =========================================================
    Public Function ActualizarHorario(idHorario As Integer, idInstructor As Integer, idActividad As Integer,
                                      idSala As Integer, dia As Integer, horaInicio As TimeSpan,
                                      horaFin As TimeSpan, activo As Boolean) As Boolean
        Const sql As String =
            "UPDATE horarios SET id_instructor = @idInstructor, id_actividad = @idActividad, " &
            "id_sala = @idSala, dia_semana = @dia, hora_inicio = @horaInicio, hora_fin = @horaFin, " &
            "activo = @activo WHERE id_horario = @idHorario"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosHorario(cmd, idInstructor, idActividad, idSala, dia, horaInicio, horaFin, activo)
                cmd.Parameters.AddWithValue("@idHorario", idHorario)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' =========================================================
    ' ELIMINAR HORARIO (tabla hoja: borrado físico)
    ' =========================================================
    Public Function EliminarHorario(idHorario As Integer) As Boolean
        Const sql As String = "DELETE FROM horarios WHERE id_horario = @idHorario"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idHorario", idHorario)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub AgregarParametrosHorario(cmd As MySqlCommand, idInstructor As Integer, idActividad As Integer,
                                         idSala As Integer, dia As Integer, horaInicio As TimeSpan,
                                         horaFin As TimeSpan, activo As Boolean)
        cmd.Parameters.AddWithValue("@idInstructor", idInstructor)
        cmd.Parameters.AddWithValue("@idActividad", idActividad)
        cmd.Parameters.AddWithValue("@idSala", idSala)
        cmd.Parameters.AddWithValue("@dia", dia)
        cmd.Parameters.AddWithValue("@horaInicio", horaInicio)
        cmd.Parameters.AddWithValue("@horaFin", horaFin)
        cmd.Parameters.AddWithValue("@activo", If(activo, 1, 0))
    End Sub

    ' =========================================================
    ' LISTAR CLASES DE HOY
    '
    ' Horarios activos programados para el día de
    ' la semana indicado:
    ' 1=Lunes, 2=Martes, ..., 7=Domingo
    ' =========================================================
    Public Function ListarClasesDeHoy(
        diaSemana As Integer
    ) As DataTable

        Dim tabla As New DataTable()

        Dim sql As String =
            "SELECT
                DATE_FORMAT(h.hora_inicio, '%H:%i') AS 'Hora inicio',
                DATE_FORMAT(h.hora_fin, '%H:%i') AS 'Hora fin',
                a.nombre AS Actividad,
                CONCAT(i.nombres, ' ', i.apellidos) AS Instructor,
                sa.nombre AS Sala
             FROM horarios h
             INNER JOIN actividades a
                ON h.id_actividad = a.id_actividad
             INNER JOIN instructores i
                ON h.id_instructor = i.id_instructor
             INNER JOIN salas sa
                ON h.id_sala = sa.id_sala
             WHERE h.activo = @activo
               AND h.dia_semana = @dia
             ORDER BY h.hora_inicio ASC"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@activo",
                    1
                )

                cmd.Parameters.AddWithValue(
                    "@dia",
                    diaSemana
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
