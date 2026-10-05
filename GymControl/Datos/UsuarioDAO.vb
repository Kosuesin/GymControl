Imports MySqlConnector
Imports System.Data

Public Class UsuarioDAO

    ' =========================================================
    ' LISTAR / BUSCAR USUARIOS
    ' =========================================================
    Public Function ListarUsuarios(
        Optional filtro As String = ""
    ) As DataTable

        Dim tabla As New DataTable()

        Dim sql As String =
            "SELECT
                u.id_usuario,
                u.id_rol,
                u.id_socio,
                u.id_instructor,
                u.nombre_usuario AS Usuario,
                r.nombre AS Rol,
                CONCAT(s.nombres, ' ', s.apellidos) AS Socio,
                CONCAT(i.nombres, ' ', i.apellidos) AS Instructor,
                u.intentos_fallidos AS Intentos,
                u.activo AS Activo,
                u.ultimo_acceso AS UltimoAcceso
             FROM usuarios u
             INNER JOIN roles r
                ON u.id_rol = r.id_rol
             LEFT JOIN socios s
                ON u.id_socio = s.id_socio
             LEFT JOIN instructores i
                ON u.id_instructor = i.id_instructor
             WHERE (
                @filtro = ''
                OR u.nombre_usuario LIKE CONCAT('%', @filtro, '%')
                OR r.nombre LIKE CONCAT('%', @filtro, '%')
             )
             ORDER BY u.nombre_usuario"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@filtro",
                    filtro.Trim()
                )

                cn.Open()

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using

        End Using

        Return tabla

    End Function


    ' =========================================================
    ' LISTAR ROLES
    ' =========================================================
    Public Function ListarRoles() As DataTable

        Dim tabla As New DataTable()

        Dim sql As String =
            "SELECT id_rol, nombre
             FROM roles
             ORDER BY nombre"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cn.Open()

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using

        End Using

        Return tabla

    End Function


    ' =========================================================
    ' LISTAR SOCIOS ACTIVOS
    ' =========================================================
    Public Function ListarSocios() As DataTable

        Dim tabla As New DataTable()

        Dim sql As String =
            "SELECT
                id_socio,
                CONCAT(nombres, ' ', apellidos) AS nombre
             FROM socios
             WHERE activo = 1
             ORDER BY nombres, apellidos"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cn.Open()

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using

        End Using

        Return tabla

    End Function


    ' =========================================================
    ' LISTAR INSTRUCTORES ACTIVOS
    ' =========================================================
    Public Function ListarInstructores() As DataTable

        Dim tabla As New DataTable()

        Dim sql As String =
            "SELECT
                id_instructor,
                CONCAT(nombres, ' ', apellidos) AS nombre
             FROM instructores
             WHERE activo = 1
             ORDER BY nombres, apellidos"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cn.Open()

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using

        End Using

        Return tabla

    End Function


    ' =========================================================
    ' INSERTAR USUARIO
    ' =========================================================
    Public Function InsertarUsuario(
        nombreUsuario As String,
        hash As String,
        sal As String,
        idRol As Integer,
        idSocio As Integer?,
        idInstructor As Integer?,
        activo As Boolean
    ) As Boolean

        Dim sql As String =
            "INSERT INTO usuarios
            (
                nombre_usuario,
                contrasena_hash,
                sal,
                id_rol,
                id_socio,
                id_instructor,
                intentos_fallidos,
                activo
            )
            VALUES
            (
                @usuario,
                @hash,
                @sal,
                @rol,
                @socio,
                @instructor,
                0,
                @activo
            )"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@usuario",
                    nombreUsuario
                )

                cmd.Parameters.AddWithValue(
                    "@hash",
                    hash
                )

                cmd.Parameters.AddWithValue(
                    "@sal",
                    sal
                )

                cmd.Parameters.AddWithValue(
                    "@rol",
                    idRol
                )

                If idSocio.HasValue Then

                    cmd.Parameters.AddWithValue(
                        "@socio",
                        idSocio.Value
                    )

                Else

                    cmd.Parameters.AddWithValue(
                        "@socio",
                        DBNull.Value
                    )

                End If


                If idInstructor.HasValue Then

                    cmd.Parameters.AddWithValue(
                        "@instructor",
                        idInstructor.Value
                    )

                Else

                    cmd.Parameters.AddWithValue(
                        "@instructor",
                        DBNull.Value
                    )

                End If


                cmd.Parameters.AddWithValue(
                    "@activo",
                    If(activo, 1, 0)
                )

                cn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' =========================================================
    ' ACTUALIZAR USUARIO
    ' =========================================================
    Public Function ActualizarUsuario(
        idUsuario As Integer,
        nombreUsuario As String,
        idRol As Integer,
        idSocio As Integer?,
        idInstructor As Integer?,
        activo As Boolean
    ) As Boolean

        Dim sql As String =
            "UPDATE usuarios
             SET
                nombre_usuario = @usuario,
                id_rol = @rol,
                id_socio = @socio,
                id_instructor = @instructor,
                activo = @activo
             WHERE id_usuario = @idUsuario"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@usuario",
                    nombreUsuario
                )

                cmd.Parameters.AddWithValue(
                    "@rol",
                    idRol
                )


                If idSocio.HasValue Then

                    cmd.Parameters.AddWithValue(
                        "@socio",
                        idSocio.Value
                    )

                Else

                    cmd.Parameters.AddWithValue(
                        "@socio",
                        DBNull.Value
                    )

                End If


                If idInstructor.HasValue Then

                    cmd.Parameters.AddWithValue(
                        "@instructor",
                        idInstructor.Value
                    )

                Else

                    cmd.Parameters.AddWithValue(
                        "@instructor",
                        DBNull.Value
                    )

                End If


                cmd.Parameters.AddWithValue(
                    "@activo",
                    If(activo, 1, 0)
                )

                cmd.Parameters.AddWithValue(
                    "@idUsuario",
                    idUsuario
                )

                cn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' =========================================================
    ' DESACTIVAR USUARIO
    ' =========================================================
    Public Function DesactivarUsuario(
        idUsuario As Integer
    ) As Boolean

        Dim sql As String =
            "UPDATE usuarios
             SET activo = 0
             WHERE id_usuario = @idUsuario"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@idUsuario",
                    idUsuario
                )

                cn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' =========================================================
    ' DESBLOQUEAR USUARIO
    '
    ' IMPORTANTE:
    ' Solo reinicia los intentos fallidos.
    ' NO reactiva una cuenta desactivada administrativamente.
    ' =========================================================
    Public Function DesbloquearUsuario(
        idUsuario As Integer
    ) As Boolean

        Dim sql As String =
            "UPDATE usuarios
             SET intentos_fallidos = 0
             WHERE id_usuario = @idUsuario"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@idUsuario",
                    idUsuario
                )

                cn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' =========================================================
    ' RESTABLECER CONTRASEÑA
    ' =========================================================
    Public Function RestablecerContrasena(
        idUsuario As Integer,
        nuevoHash As String,
        nuevaSal As String
    ) As Boolean

        Dim sql As String =
            "UPDATE usuarios
             SET
                contrasena_hash = @hash,
                sal = @sal,
                intentos_fallidos = 0
             WHERE id_usuario = @idUsuario"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@hash",
                    nuevoHash
                )

                cmd.Parameters.AddWithValue(
                    "@sal",
                    nuevaSal
                )

                cmd.Parameters.AddWithValue(
                    "@idUsuario",
                    idUsuario
                )

                cn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function

End Class