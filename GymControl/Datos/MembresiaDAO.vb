Imports MySqlConnector
Imports System.Data

Public Class MembresiaDAO

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
