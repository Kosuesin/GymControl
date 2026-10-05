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

    ' =========================================================
    ' LISTAR BITÁCORA
    ' =========================================================
    Public Function ListarBitacora(
        usuario As String,
        resultado As String,
        fechaDesde As DateTime,
        fechaHasta As DateTime
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
             WHERE
                b.fecha_hora >= @fechaDesde
                AND b.fecha_hora < DATE_ADD(@fechaHasta, INTERVAL 1 DAY)"

        If Not String.IsNullOrWhiteSpace(usuario) Then
            sql &= " AND b.usuario_intento LIKE @usuario"
        End If

        If Not String.IsNullOrWhiteSpace(resultado) Then
            sql &= " AND b.resultado = @resultado"
        End If

        sql &= " ORDER BY b.fecha_hora DESC"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@fechaDesde",
                    fechaDesde.Date
                )

                cmd.Parameters.AddWithValue(
                    "@fechaHasta",
                    fechaHasta.Date
                )

                If Not String.IsNullOrWhiteSpace(usuario) Then
                    cmd.Parameters.AddWithValue(
                        "@usuario",
                        "%" & usuario.Trim() & "%"
                    )
                End If

                If Not String.IsNullOrWhiteSpace(resultado) Then
                    cmd.Parameters.AddWithValue(
                        "@resultado",
                        resultado
                    )
                End If

                cn.Open()

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using
        End Using

        Return tabla

    End Function

End Class