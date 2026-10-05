Imports MySqlConnector
Imports System.Data

Public Class HorarioDAO

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
