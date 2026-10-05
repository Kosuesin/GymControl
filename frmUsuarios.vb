Public Class frmUsuarios

    Private ReadOnly usuarioDAO As New UsuarioDAO()

    Private modoEdicion As Boolean = False
    Private idUsuarioSeleccionado As Integer = 0


    ' =========================================================
    ' CARGA DEL FORMULARIO
    ' =========================================================
    Private Sub frmUsuarios_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurarFormulario()
        CargarCombos()
        CargarUsuarios()
        ModoConsulta()

    End Sub


    ' =========================================================
    ' CONFIGURACIÓN GENERAL
    ' =========================================================
    Private Sub ConfigurarFormulario()

        txtUltimoAcceso.ReadOnly = True
        txtContrasena.UseSystemPasswordChar = True

        ' -----------------------------------------------------
        ' DATAGRIDVIEW
        ' -----------------------------------------------------
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.MultiSelect = False

        dgvUsuarios.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.AllowUserToResizeRows = False

        dgvUsuarios.RowHeadersVisible = False

        dgvUsuarios.BackgroundColor =
            SystemColors.Window

        dgvUsuarios.BorderStyle =
            BorderStyle.FixedSingle

        dgvUsuarios.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.AutoSize

        dgvUsuarios.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.None


        ' -----------------------------------------------------
        ' COMBOBOX
        ' -----------------------------------------------------
        cboRol.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboSocio.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboInstructor.DropDownStyle =
            ComboBoxStyle.DropDownList

    End Sub


    ' =========================================================
    ' CARGAR / BUSCAR USUARIOS
    ' =========================================================
    Private Sub CargarUsuarios(
        Optional filtro As String = ""
    )

        Try

            dgvUsuarios.DataSource =
                usuarioDAO.ListarUsuarios(filtro)


            ' =================================================
            ' OCULTAR IDENTIFICADORES INTERNOS
            ' =================================================
            If dgvUsuarios.Columns.Contains(
                "id_usuario"
            ) Then

                dgvUsuarios.Columns(
                    "id_usuario"
                ).Visible = False

            End If


            If dgvUsuarios.Columns.Contains(
                "id_rol"
            ) Then

                dgvUsuarios.Columns(
                    "id_rol"
                ).Visible = False

            End If


            If dgvUsuarios.Columns.Contains(
                "id_socio"
            ) Then

                dgvUsuarios.Columns(
                    "id_socio"
                ).Visible = False

            End If


            If dgvUsuarios.Columns.Contains(
                "id_instructor"
            ) Then

                dgvUsuarios.Columns(
                    "id_instructor"
                ).Visible = False

            End If


            ' =================================================
            ' OCULTAR INFORMACIÓN MOSTRADA EN PANEL DERECHO
            ' =================================================
            If dgvUsuarios.Columns.Contains(
                "Socio"
            ) Then

                dgvUsuarios.Columns(
                    "Socio"
                ).Visible = False

            End If


            If dgvUsuarios.Columns.Contains(
                "Instructor"
            ) Then

                dgvUsuarios.Columns(
                    "Instructor"
                ).Visible = False

            End If


            If dgvUsuarios.Columns.Contains(
                "UltimoAcceso"
            ) Then

                dgvUsuarios.Columns(
                    "UltimoAcceso"
                ).Visible = False

            End If


            ' =================================================
            ' CONFIGURAR COLUMNAS VISIBLES
            ' =================================================

            ' USUARIO
            If dgvUsuarios.Columns.Contains(
                "Usuario"
            ) Then

                dgvUsuarios.Columns(
                    "Usuario"
                ).AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill

                dgvUsuarios.Columns(
                    "Usuario"
                ).FillWeight = 45

            End If


            ' ROL
            If dgvUsuarios.Columns.Contains(
                "Rol"
            ) Then

                dgvUsuarios.Columns(
                    "Rol"
                ).AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill

                dgvUsuarios.Columns(
                    "Rol"
                ).FillWeight = 45

            End If


            ' INTENTOS
            If dgvUsuarios.Columns.Contains(
                "Intentos"
            ) Then

                dgvUsuarios.Columns(
                    "Intentos"
                ).AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.None

                dgvUsuarios.Columns(
                    "Intentos"
                ).Width = 75

                dgvUsuarios.Columns(
                    "Intentos"
                ).HeaderText = "Intentos"

            End If


            ' ACTIVO
            If dgvUsuarios.Columns.Contains(
                "Activo"
            ) Then

                dgvUsuarios.Columns(
                    "Activo"
                ).AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.None

                dgvUsuarios.Columns(
                    "Activo"
                ).Width = 65

                dgvUsuarios.Columns(
                    "Activo"
                ).HeaderText = "Activo"

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron cargar los usuarios." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' CARGAR COMBOBOX
    ' =========================================================
    Private Sub CargarCombos()

        Try

            ' -------------------------------------------------
            ' ROLES
            ' -------------------------------------------------
            cboRol.DataSource =
                usuarioDAO.ListarRoles()

            cboRol.DisplayMember = "nombre"
            cboRol.ValueMember = "id_rol"
            cboRol.SelectedIndex = -1


            ' -------------------------------------------------
            ' SOCIOS
            ' -------------------------------------------------
            cboSocio.DataSource =
                usuarioDAO.ListarSocios()

            cboSocio.DisplayMember = "nombre"
            cboSocio.ValueMember = "id_socio"
            cboSocio.SelectedIndex = -1


            ' -------------------------------------------------
            ' INSTRUCTORES
            ' -------------------------------------------------
            cboInstructor.DataSource =
                usuarioDAO.ListarInstructores()

            cboInstructor.DisplayMember = "nombre"
            cboInstructor.ValueMember = "id_instructor"
            cboInstructor.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron cargar los datos auxiliares." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' MODO CONSULTA
    ' =========================================================
    Private Sub ModoConsulta()

        modoEdicion = False

        txtUsuario.Enabled = False
        txtContrasena.Enabled = False

        cboRol.Enabled = False
        cboSocio.Enabled = False
        cboInstructor.Enabled = False

        chkActivo.Enabled = False

        btnNuevo.Enabled = True

        Dim haySeleccion As Boolean =
            idUsuarioSeleccionado > 0

        btnEditar.Enabled =
            haySeleccion

        btnDesactivar.Enabled =
            haySeleccion

        btnDesbloquear.Enabled =
            haySeleccion

        btnRestablecer.Enabled =
            haySeleccion

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

    End Sub


    ' =========================================================
    ' MODO NUEVO
    ' =========================================================
    Private Sub ModoNuevo()

        modoEdicion = False
        idUsuarioSeleccionado = 0

        LimpiarCampos()

        txtUsuario.Enabled = True
        txtContrasena.Enabled = True

        cboRol.Enabled = True

        cboSocio.Enabled = False
        cboInstructor.Enabled = False

        chkActivo.Enabled = True
        chkActivo.Checked = True

        btnNuevo.Enabled = False
        btnEditar.Enabled = False

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        btnDesactivar.Enabled = False
        btnDesbloquear.Enabled = False
        btnRestablecer.Enabled = False

        txtUsuario.Focus()

    End Sub


    ' =========================================================
    ' MODO EDITAR
    ' =========================================================
    Private Sub ModoEditar()

        If idUsuarioSeleccionado = 0 Then

            MessageBox.Show(
                "Debe seleccionar un usuario.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        modoEdicion = True

        txtUsuario.Enabled = True

        ' La contraseña se administra mediante
        ' el botón Restablecer contraseña.
        txtContrasena.Clear()
        txtContrasena.Enabled = False

        cboRol.Enabled = True
        chkActivo.Enabled = True


        ' -----------------------------------------------------
        ' HABILITAR RELACIÓN SEGÚN EL ROL
        ' -----------------------------------------------------
        Select Case cboRol.Text

            Case "Socio"

                cboSocio.Enabled = True
                cboInstructor.Enabled = False

            Case "Instructor"

                cboSocio.Enabled = False
                cboInstructor.Enabled = True

            Case Else

                cboSocio.Enabled = False
                cboInstructor.Enabled = False

        End Select


        btnNuevo.Enabled = False
        btnEditar.Enabled = False

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        btnDesactivar.Enabled = False
        btnDesbloquear.Enabled = False
        btnRestablecer.Enabled = False

        txtUsuario.Focus()

    End Sub


    ' =========================================================
    ' LIMPIAR CAMPOS
    ' =========================================================
    Private Sub LimpiarCampos()

        txtUsuario.Clear()
        txtContrasena.Clear()
        txtUltimoAcceso.Clear()

        cboRol.SelectedIndex = -1
        cboSocio.SelectedIndex = -1
        cboInstructor.SelectedIndex = -1

        chkActivo.Checked = True

    End Sub


    ' =========================================================
    ' MOSTRAR USUARIO SELECCIONADO
    ' =========================================================
    Private Sub dgvUsuarios_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvUsuarios.SelectionChanged

        ' -----------------------------------------------------
        ' SI ESTAMOS CREANDO O EDITANDO,
        ' NO CAMBIAR EL REGISTRO ACTUAL.
        ' -----------------------------------------------------
        If btnGuardar.Enabled Then
            Return
        End If


        If dgvUsuarios.CurrentRow Is Nothing Then

            idUsuarioSeleccionado = 0

            LimpiarCampos()
            ModoConsulta()

            Return

        End If


        Try

            Dim fila As DataGridViewRow =
                dgvUsuarios.CurrentRow


            ' -------------------------------------------------
            ' ID USUARIO
            ' -------------------------------------------------
            If fila.Cells(
                "id_usuario"
            ).Value Is Nothing OrElse
               IsDBNull(
                   fila.Cells(
                       "id_usuario"
                   ).Value
               ) Then

                Return

            End If


            idUsuarioSeleccionado =
                CInt(
                    fila.Cells(
                        "id_usuario"
                    ).Value
                )


            ' -------------------------------------------------
            ' NOMBRE DE USUARIO
            ' -------------------------------------------------
            txtUsuario.Text =
                Convert.ToString(
                    fila.Cells(
                        "Usuario"
                    ).Value
                )


            ' Nunca mostrar contraseña ni hash
            txtContrasena.Clear()


            ' -------------------------------------------------
            ' ROL
            ' -------------------------------------------------
            If Not IsDBNull(
                fila.Cells(
                    "id_rol"
                ).Value
            ) Then

                cboRol.SelectedValue =
                    CInt(
                        fila.Cells(
                            "id_rol"
                        ).Value
                    )

            Else

                cboRol.SelectedIndex = -1

            End If


            ' -------------------------------------------------
            ' SOCIO
            ' -------------------------------------------------
            If Not IsDBNull(
                fila.Cells(
                    "id_socio"
                ).Value
            ) Then

                cboSocio.SelectedValue =
                    CInt(
                        fila.Cells(
                            "id_socio"
                        ).Value
                    )

            Else

                cboSocio.SelectedIndex = -1

            End If


            ' -------------------------------------------------
            ' INSTRUCTOR
            ' -------------------------------------------------
            If Not IsDBNull(
                fila.Cells(
                    "id_instructor"
                ).Value
            ) Then

                cboInstructor.SelectedValue =
                    CInt(
                        fila.Cells(
                            "id_instructor"
                        ).Value
                    )

            Else

                cboInstructor.SelectedIndex = -1

            End If


            ' -------------------------------------------------
            ' ACTIVO
            ' -------------------------------------------------
            chkActivo.Checked =
                Convert.ToBoolean(
                    fila.Cells(
                        "Activo"
                    ).Value
                )


            ' -------------------------------------------------
            ' ÚLTIMO ACCESO
            ' -------------------------------------------------
            If Not IsDBNull(
                fila.Cells(
                    "UltimoAcceso"
                ).Value
            ) Then

                txtUltimoAcceso.Text =
                    Convert.ToDateTime(
                        fila.Cells(
                            "UltimoAcceso"
                        ).Value
                    ).ToString(
                        "dd/MM/yyyy HH:mm"
                    )

            Else

                txtUltimoAcceso.Clear()

            End If


            ModoConsulta()

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron mostrar los datos del usuario." &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' CAMBIO DE ROL
    ' =========================================================
    Private Sub cboRol_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboRol.SelectedIndexChanged

        ' En modo consulta no habilitar controles.
        If Not cboRol.Enabled Then
            Return
        End If


        cboSocio.Enabled = False
        cboInstructor.Enabled = False


        If cboRol.SelectedIndex = -1 Then
            Return
        End If


        Select Case cboRol.Text

            Case "Socio"

                cboSocio.Enabled = True

                cboInstructor.SelectedIndex =
                    -1


            Case "Instructor"

                cboInstructor.Enabled = True

                cboSocio.SelectedIndex =
                    -1


            Case Else

                cboSocio.SelectedIndex = -1
                cboInstructor.SelectedIndex = -1

        End Select

    End Sub


    ' =========================================================
    ' BUSCAR
    ' =========================================================
    Private Sub txtBuscar_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtBuscar.TextChanged

        CargarUsuarios(
            txtBuscar.Text
        )

    End Sub


    ' =========================================================
    ' NUEVO
    ' =========================================================
    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        ModoNuevo()

    End Sub


    ' =========================================================
    ' EDITAR
    ' =========================================================
    Private Sub btnEditar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditar.Click

        ModoEditar()

    End Sub


    ' =========================================================
    ' CANCELAR
    ' =========================================================
    Private Sub btnCancelar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancelar.Click

        modoEdicion = False

        LimpiarCampos()


        If dgvUsuarios.CurrentRow IsNot Nothing Then

            dgvUsuarios_SelectionChanged(
                dgvUsuarios,
                EventArgs.Empty
            )

        Else

            idUsuarioSeleccionado = 0
            ModoConsulta()

        End If

    End Sub


    ' =========================================================
    ' GUARDAR
    ' =========================================================
    Private Sub btnGuardar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGuardar.Click

        ' -----------------------------------------------------
        ' VALIDAR NOMBRE
        ' -----------------------------------------------------
        If String.IsNullOrWhiteSpace(
            txtUsuario.Text
        ) Then

            MessageBox.Show(
                "Debe ingresar un nombre de usuario.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUsuario.Focus()

            Return

        End If


        ' -----------------------------------------------------
        ' VALIDAR ROL
        ' -----------------------------------------------------
        If cboRol.SelectedIndex = -1 Then

            MessageBox.Show(
                "Debe seleccionar un rol.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cboRol.Focus()

            Return

        End If


        ' -----------------------------------------------------
        ' CONTRASEÑA OBLIGATORIA SOLO AL CREAR
        ' -----------------------------------------------------
        If Not modoEdicion AndAlso
           String.IsNullOrWhiteSpace(
               txtContrasena.Text
           ) Then

            MessageBox.Show(
                "Debe ingresar una contraseña.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtContrasena.Focus()

            Return

        End If


        ' -----------------------------------------------------
        ' VALIDAR SOCIO
        ' -----------------------------------------------------
        If cboRol.Text = "Socio" AndAlso
           cboSocio.SelectedIndex = -1 Then

            MessageBox.Show(
                "Debe seleccionar el socio asociado.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cboSocio.Focus()

            Return

        End If


        ' -----------------------------------------------------
        ' VALIDAR INSTRUCTOR
        ' -----------------------------------------------------
        If cboRol.Text = "Instructor" AndAlso
           cboInstructor.SelectedIndex = -1 Then

            MessageBox.Show(
                "Debe seleccionar el instructor asociado.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cboInstructor.Focus()

            Return

        End If


        Try

            Dim idRol As Integer =
                CInt(
                    cboRol.SelectedValue
                )


            Dim idSocio As Integer? =
                Nothing


            Dim idInstructor As Integer? =
                Nothing


            If cboRol.Text = "Socio" Then

                idSocio =
                    CInt(
                        cboSocio.SelectedValue
                    )

            End If


            If cboRol.Text = "Instructor" Then

                idInstructor =
                    CInt(
                        cboInstructor.SelectedValue
                    )

            End If


            ' =================================================
            ' ACTUALIZAR USUARIO
            ' =================================================
            If modoEdicion Then

                Dim actualizado As Boolean =
                    usuarioDAO.ActualizarUsuario(
                        idUsuarioSeleccionado,
                        txtUsuario.Text.Trim(),
                        idRol,
                        idSocio,
                        idInstructor,
                        chkActivo.Checked
                    )


                If actualizado Then

                    MessageBox.Show(
                        "Usuario actualizado correctamente.",
                        "GymControl",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    modoEdicion = False

                    CargarUsuarios(
                        txtBuscar.Text
                    )

                    ModoConsulta()

                End If


            Else

                ' =================================================
                ' INSERTAR USUARIO
                ' =================================================

                Dim sal As String =
                    Seguridad.GenerarSal()


                Dim hash As String =
                    Seguridad.CalcularHash(
                        txtContrasena.Text,
                        sal
                    )


                Dim guardado As Boolean =
                    usuarioDAO.InsertarUsuario(
                        txtUsuario.Text.Trim(),
                        hash,
                        sal,
                        idRol,
                        idSocio,
                        idInstructor,
                        chkActivo.Checked
                    )


                If guardado Then

                    MessageBox.Show(
                        "Usuario registrado correctamente.",
                        "GymControl",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    CargarUsuarios(
                        txtBuscar.Text
                    )

                    ModoConsulta()

                End If

            End If


        Catch ex As MySqlConnector.MySqlException

            If ex.Number = 1062 Then

                MessageBox.Show(
                    "El nombre de usuario ya existe o " &
                    "el socio/instructor ya tiene una " &
                    "cuenta asociada.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Else

                MessageBox.Show(
                    "Error al guardar el usuario:" &
                    Environment.NewLine &
                    ex.Message,
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Ocurrió un error:" &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' DESACTIVAR USUARIO
    ' =========================================================
    Private Sub btnDesactivar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDesactivar.Click

        If idUsuarioSeleccionado = 0 Then

            MessageBox.Show(
                "Debe seleccionar un usuario.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        If Not chkActivo.Checked Then

            MessageBox.Show(
                "El usuario seleccionado ya está inactivo.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        Dim respuesta As DialogResult =
            MessageBox.Show(
                "¿Desea desactivar al usuario '" &
                txtUsuario.Text &
                "'?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If respuesta <> DialogResult.Yes Then
            Return
        End If


        Try

            If usuarioDAO.DesactivarUsuario(
                idUsuarioSeleccionado
            ) Then

                MessageBox.Show(
                    "Usuario desactivado correctamente.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CargarUsuarios(
                    txtBuscar.Text
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo desactivar el usuario." &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' DESBLOQUEAR CUENTA
    ' =========================================================
    Private Sub btnDesbloquear_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDesbloquear.Click

        If idUsuarioSeleccionado = 0 Then

            MessageBox.Show(
                "Debe seleccionar un usuario.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Dim respuesta As DialogResult =
            MessageBox.Show(
                "¿Desea desbloquear al usuario '" &
                txtUsuario.Text &
                "'?" &
                Environment.NewLine &
                Environment.NewLine &
                "Los intentos fallidos volverán a 0.",
                "Confirmar desbloqueo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If respuesta <> DialogResult.Yes Then
            Return
        End If


        Try

            If usuarioDAO.DesbloquearUsuario(
                idUsuarioSeleccionado
            ) Then

                MessageBox.Show(
                    "Usuario desbloqueado correctamente.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CargarUsuarios(
                    txtBuscar.Text
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo desbloquear el usuario." &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' RESTABLECER CONTRASEÑA
    ' =========================================================
    Private Sub btnRestablecer_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRestablecer.Click

        If idUsuarioSeleccionado = 0 Then

            MessageBox.Show(
                "Debe seleccionar un usuario.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Dim nuevaContrasena As String =
            InputBox(
                "Ingrese la nueva contraseña para '" &
                txtUsuario.Text &
                "':",
                "Restablecer contraseña"
            )


        ' Cancelar o dejar vacío
        If String.IsNullOrWhiteSpace(
            nuevaContrasena
        ) Then

            Return

        End If


        Dim confirmarContrasena As String =
            InputBox(
                "Vuelva a escribir la nueva contraseña:",
                "Confirmar contraseña"
            )


        If nuevaContrasena <>
           confirmarContrasena Then

            MessageBox.Show(
                "Las contraseñas no coinciden.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            Dim nuevaSal As String =
                Seguridad.GenerarSal()


            Dim nuevoHash As String =
                Seguridad.CalcularHash(
                    nuevaContrasena,
                    nuevaSal
                )


            If usuarioDAO.RestablecerContrasena(
                idUsuarioSeleccionado,
                nuevoHash,
                nuevaSal
            ) Then

                MessageBox.Show(
                    "Contraseña restablecida correctamente.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CargarUsuarios(
                    txtBuscar.Text
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo restablecer la contraseña." &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class