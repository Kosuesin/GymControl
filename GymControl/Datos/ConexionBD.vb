Imports MySqlConnector

Public Class ConexionBD

    Private Shared ReadOnly cadenaConexion As String =
        "Server=localhost;" &
        "Port=3306;" &
        "Database=gimnasio_db;" &
        "User ID=root;" &
        "Password=;"

    Public Shared Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(cadenaConexion)
    End Function

End Class