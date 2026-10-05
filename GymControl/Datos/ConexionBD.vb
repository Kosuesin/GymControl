Imports MySqlConnector

Public Module ConexionBD

    Private Const CadenaConexion As String =
        "Server=localhost;" &
        "Port=3306;" &
        "Database=gimnasio_db;" &
        "Uid=gym_app;" &
        "Pwd=GymControl2026*;"

    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(CadenaConexion)
    End Function

    Public Function ProbarConexion(ByRef mensaje As String) As Boolean

        Try
            Using cn As MySqlConnection = ObtenerConexion()

                cn.Open()

                mensaje =
                    $"Conectado a MariaDB {cn.ServerVersion} · base gimnasio_db"

                Return True

            End Using

        Catch ex As MySqlException

            mensaje =
                $"Error {ex.Number}: {ex.Message}"

            Return False

        End Try

    End Function

End Module