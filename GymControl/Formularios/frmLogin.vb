Imports System.Data

Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mensaje As String = ""
        If ConexionBD.ProbarConexion(mensaje) Then
            lblConexion.Text = mensaje
        Else
            lblConexion.Text = mensaje
        End If


    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contrasena As String = txtContrasena.Text

        If usuario = "" Then
            lblMensaje.Text = "Ingrese su nombre de usuario."
            lblMensaje.Visible = True
            txtUsuario.Focus()
            Return
        End If

        If contrasena = "" Then
            lblMensaje.Text = "Ingrese su contraseña."
            lblMensaje.Visible = True
            txtContrasena.Focus()
            Return
        End If

        Try

            Dim dao As New UsuarioDAO()
            Dim bitacora As New BitacoraDAO()

            Dim datos As DataTable =
            dao.ObtenerUsuarioPorNombre(usuario)

            If datos.Rows.Count = 0 Then

                bitacora.RegistrarIntento(
        Nothing,
        usuario,
        "FALLIDO"
    )

                lblMensaje.Text = "Usuario o contraseña incorrectos."
                lblMensaje.Visible = True
                txtContrasena.Clear()
                txtContrasena.Focus()
                Return
            End If

            Dim fila As DataRow = datos.Rows(0)

            Dim idUsuario As Integer =
            Convert.ToInt32(fila("id_usuario"))

            Dim hash As String =
            fila("contrasena_hash").ToString()

            Dim sal As String =
            fila("sal").ToString()

            Dim rol As String =
            fila("rol").ToString()

            Dim activo As Boolean =
            Convert.ToBoolean(fila("activo"))

            If Not activo Then

                lblMensaje.Text =
                "La cuenta está bloqueada o deshabilitada."

                lblMensaje.Visible = True
                Return

            End If

            If Not Seguridad.Verificar(
                contrasena,
                sal,
                 hash
                ) Then

                Dim nuevosIntentos As Integer =
        dao.IncrementarIntentosFallidos(idUsuario)

                If nuevosIntentos >= 3 Then

                    dao.BloquearUsuario(idUsuario)

                    bitacora.RegistrarIntento(
            idUsuario,
            usuario,
            "BLOQUEADO"
        )

                    lblMensaje.Text =
            "Cuenta bloqueada por 3 intentos fallidos."

                Else

                    bitacora.RegistrarIntento(
            idUsuario,
            usuario,
            "FALLIDO"
        )

                    Dim restantes As Integer =
            3 - nuevosIntentos

                    lblMensaje.Text =
            "Usuario o contraseña incorrectos. " &
            "Intentos restantes: " & restantes

                End If

                lblMensaje.Visible = True
                txtContrasena.Clear()
                txtContrasena.Focus()
                Return

            End If

            dao.RegistrarUltimoAcceso(idUsuario)

            bitacora.RegistrarIntento(
                idUsuario,
                usuario,
                "EXITO"
                )

            Sesion.IdUsuario = idUsuario
            Sesion.NombreUsuario =
            fila("nombre_usuario").ToString()

            Sesion.Rol = rol

            If Not IsDBNull(fila("id_socio")) Then
                Sesion.IdSocio =
                Convert.ToInt32(fila("id_socio"))
            Else
                Sesion.IdSocio = Nothing
            End If

            If Not IsDBNull(fila("id_instructor")) Then
                Sesion.IdInstructor =
                Convert.ToInt32(fila("id_instructor"))
            Else
                Sesion.IdInstructor = Nothing
            End If

            Me.Hide()

            If rol = "Socio" Then

                Dim portal As New frmPortalSocio()
                portal.ShowDialog()

            Else

                Dim principal As New frmPrincipal()
                principal.ShowDialog()

            End If

            Me.Close()

        Catch ex As Exception

            lblMensaje.Text =
            "Ocurrió un error al iniciar sesión."

            lblMensaje.Visible = True

            MessageBox.Show(
            ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        If chkMostrar.Checked Then
            txtContrasena.UseSystemPasswordChar = False
        Else
            txtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Application.Exit()
    End Sub
End Class