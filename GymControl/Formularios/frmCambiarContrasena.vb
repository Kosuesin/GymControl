Public Class frmCambiarContrasena

    Private ReadOnly usuarioDAO As New UsuarioDAO()

    Private Sub frmCambiarContrasena_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurarFormulario()

    End Sub


    Private Sub ConfigurarFormulario()

        txtContrasenaActual.UseSystemPasswordChar = True
        txtNuevaContrasena.UseSystemPasswordChar = True
        txtConfirmarContrasena.UseSystemPasswordChar = True

        chkMostrarContrasenas.Checked = False

        If Sesion.HaySesion Then
            lblUsuario.Text = Sesion.NombreUsuario
            btnCambiar.Enabled = True
        Else
            lblUsuario.Text = "Sin sesión"
            btnCambiar.Enabled = False
        End If

    End Sub


    Private Sub chkMostrarContrasenas_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkMostrarContrasenas.CheckedChanged

        Dim ocultar As Boolean =
            Not chkMostrarContrasenas.Checked

        txtContrasenaActual.UseSystemPasswordChar = ocultar
        txtNuevaContrasena.UseSystemPasswordChar = ocultar
        txtConfirmarContrasena.UseSystemPasswordChar = ocultar

    End Sub


    Private Sub btnCambiar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCambiar.Click

        If Not Sesion.HaySesion Then

            MessageBox.Show(
                "No hay una sesión de usuario activa.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        If String.IsNullOrWhiteSpace(
            txtContrasenaActual.Text
        ) Then

            MessageBox.Show(
                "Ingrese su contraseña actual.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtContrasenaActual.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(
            txtNuevaContrasena.Text
        ) Then

            MessageBox.Show(
                "Ingrese la nueva contraseña.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNuevaContrasena.Focus()
            Return

        End If


        If txtNuevaContrasena.Text <>
           txtConfirmarContrasena.Text Then

            MessageBox.Show(
                "La nueva contraseña y su confirmación no coinciden.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtConfirmarContrasena.Focus()
            Return

        End If


        If txtNuevaContrasena.Text =
           txtContrasenaActual.Text Then

            MessageBox.Show(
                "La nueva contraseña debe ser diferente " &
                "de la contraseña actual.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNuevaContrasena.Focus()
            Return

        End If


        Try

            Dim credenciales As DataRow =
                usuarioDAO.ObtenerCredenciales(
                    Sesion.IdUsuario
                )


            If credenciales Is Nothing Then

                MessageBox.Show(
                    "No se encontró el usuario de la sesión actual.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                Return

            End If


            If Not Convert.ToBoolean(
                credenciales("activo")
            ) Then

                MessageBox.Show(
                    "La cuenta se encuentra inactiva.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim salActual As String =
                Convert.ToString(
                    credenciales("sal")
                )

            Dim hashActual As String =
                Convert.ToString(
                    credenciales("contrasena_hash")
                )


            Dim contrasenaCorrecta As Boolean =
                Seguridad.Verificar(
                    txtContrasenaActual.Text,
                    salActual,
                    hashActual
                )


            If Not contrasenaCorrecta Then

                MessageBox.Show(
                    "La contraseña actual es incorrecta.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtContrasenaActual.SelectAll()
                txtContrasenaActual.Focus()

                Return

            End If


            Dim nuevaSal As String =
                Seguridad.GenerarSal()

            Dim nuevoHash As String =
                Seguridad.CalcularHash(
                    txtNuevaContrasena.Text,
                    nuevaSal
                )


            Dim actualizado As Boolean =
                usuarioDAO.CambiarContrasena(
                    Sesion.IdUsuario,
                    nuevoHash,
                    nuevaSal
                )


            If actualizado Then

                MessageBox.Show(
                    "La contraseña se cambió correctamente.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                DialogResult = DialogResult.OK
                Close()

            Else

                MessageBox.Show(
                    "No se pudo cambiar la contraseña.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Ocurrió un error al cambiar la contraseña." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub btnCancelar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancelar.Click

        DialogResult = DialogResult.Cancel
        Close()

    End Sub

End Class