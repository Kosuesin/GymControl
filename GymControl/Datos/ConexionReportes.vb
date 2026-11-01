Imports MySqlConnector
Imports System.IO

''' <summary>
''' Conexión exclusiva del módulo de reportes. Usa el usuario
''' MariaDB gym_reportes, que solo tiene SELECT sobre las vistas
''' vw_ingresos_detalle, vw_saldos_membresia, vw_estado_cuenta,
''' vw_horario_semanal y las auxiliares de filtros.
'''
''' La contraseña no se guarda en el código ni en Git. Se lee, en
''' este orden, de:
'''   1. GYMCONTROL_REPORTES_CONNECTION (cadena completa, útil en pruebas)
'''   2. GYMCONTROL_REPORTES_PWD (contraseña)
'''   3. %LOCALAPPDATA%\GymControl\reportes.pwd (archivo local)
''' </summary>
Public Module ConexionReportes

    Private Const UsuarioReportes As String = "gym_reportes"
    Private Const BaseDatos As String = "gimnasio_db"

    Public Function ObtenerConexionReportes() As MySqlConnection
        Return New MySqlConnection(ConstruirCadenaConexion())
    End Function

    Public Function ProbarConexionReportes(ByRef mensaje As String) As Boolean

        Try
            Using cn As MySqlConnection = ObtenerConexionReportes()
                cn.Open()
                mensaje = $"Conectado como {UsuarioReportes} · base {BaseDatos}"
                Return True
            End Using

        Catch ex As InvalidOperationException
            mensaje = ex.Message
            Return False

        Catch ex As MySqlException
            mensaje = $"Error {ex.Number}: {ex.Message}"
            Return False

        End Try

    End Function

    Private Function ConstruirCadenaConexion() As String

        Dim cadenaCompleta As String =
            Environment.GetEnvironmentVariable("GYMCONTROL_REPORTES_CONNECTION")

        If Not String.IsNullOrWhiteSpace(cadenaCompleta) Then
            Return cadenaCompleta.Trim()
        End If

        Dim contrasena As String =
            Environment.GetEnvironmentVariable("GYMCONTROL_REPORTES_PWD")

        If String.IsNullOrWhiteSpace(contrasena) Then
            contrasena = LeerContrasenaLocal()
        End If

        If String.IsNullOrWhiteSpace(contrasena) Then

            Throw New InvalidOperationException(
                "No se configuró la contraseña del usuario de reportes gym_reportes." &
                Environment.NewLine &
                "Defina GYMCONTROL_REPORTES_PWD o cree el archivo local:" &
                Environment.NewLine &
                RutaContrasenaLocal())

        End If

        Dim servidor As String =
            Environment.GetEnvironmentVariable("GYMCONTROL_REPORTES_SERVER")

        If String.IsNullOrWhiteSpace(servidor) Then servidor = "localhost"

        Dim puertoTexto As String =
            Environment.GetEnvironmentVariable("GYMCONTROL_REPORTES_PORT")

        Dim puerto As UInteger = 3306UI
        If Not String.IsNullOrWhiteSpace(puertoTexto) Then
            UInteger.TryParse(puertoTexto, puerto)
        End If

        Dim builder As New MySqlConnectionStringBuilder With {
            .Server = servidor.Trim(),
            .Port = puerto,
            .Database = BaseDatos,
            .UserID = UsuarioReportes,
            .Password = contrasena.Trim(),
            .ConnectionTimeout = 10UI
        }

        Return builder.ConnectionString

    End Function

    Private Function LeerContrasenaLocal() As String

        Try
            Dim ruta As String = RutaContrasenaLocal()
            If Not File.Exists(ruta) Then Return String.Empty
            Return File.ReadAllText(ruta).Trim()

        Catch ex As IOException
            Return String.Empty

        Catch ex As UnauthorizedAccessException
            Return String.Empty

        End Try

    End Function

    Private Function RutaContrasenaLocal() As String

        Return Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "GymControl",
            "reportes.pwd")

    End Function

End Module
