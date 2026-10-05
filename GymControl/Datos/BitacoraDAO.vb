Imports MySqlConnector

Public Class BitacoraDAO

    Public Sub RegistrarIntento(
        idUsuario As Integer?,
        usuarioIntento As String,
        resultado As String
    )

        Dim sql As String =
            "INSERT INTO bitacora_accesos
             (id_usuario, usuario_intento, resultado, equipo)
             VALUES
             (@idUsuario, @usuarioIntento, @resultado, @equipo)"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                If idUsuario.HasValue Then
                    cmd.Parameters.AddWithValue(
                        "@idUsuario",
                        idUsuario.Value
                    )
                Else
                    cmd.Parameters.AddWithValue(
                        "@idUsuario",
                        DBNull.Value
                    )
                End If

                cmd.Parameters.AddWithValue(
                    "@usuarioIntento",
                    usuarioIntento
                )

                cmd.Parameters.AddWithValue(
                    "@resultado",
                    resultado
                )

                cmd.Parameters.AddWithValue(
                    "@equipo",
                    Environment.MachineName
                )

                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using

    End Sub

End Class