Imports MySqlConnector
Imports System.Data

Public Class BitacoraDAO

    Public Function ListarBitacora(
        usuario As String,
        resultado As String,
        fechaDesde As Date,
        fechaHasta As Date
    ) As DataTable

        Dim tabla As New DataTable()

        Dim sql As String =
            "SELECT
                b.id_bitacora,
                b.id_usuario,
                b.fecha_hora AS FechaHora,
                b.usuario_intento AS Usuario,
                b.resultado AS Resultado,
                b.equipo AS Equipo
             FROM bitacora_accesos b
             WHERE b.fecha_hora >= @desde
               AND b.fecha_hora < @hasta
               AND (
                    @usuario = ''
                    OR b.usuario_intento LIKE CONCAT('%', @usuario, '%')
               )
               AND (
                    @resultado = ''
                    OR b.resultado = @resultado
               )
             ORDER BY b.fecha_hora DESC"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@usuario",
                    usuario.Trim()
                )

                cmd.Parameters.AddWithValue(
                    "@resultado",
                    resultado
                )

                cmd.Parameters.AddWithValue(
                    "@desde",
                    fechaDesde.Date
                )

                ' Usamos el día siguiente como límite.
                ' Así se incluye todo el día seleccionado
                ' en "Hasta", incluso 23:59:59.
                cmd.Parameters.AddWithValue(
                    "@hasta",
                    fechaHasta.Date.AddDays(1)
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