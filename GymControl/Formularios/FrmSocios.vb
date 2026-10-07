Public Class FrmSocios

    Private bnvSocios As New BindingNavigator(True)
    Private ReadOnly socioDAO As New SocioDAO()
    Private ReadOnly sociosBindingSource As New BindingSource()
    Private modoEdicion As Boolean
    Private idSocioSeleccionado As Integer

    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bnvSocios.Dock = DockStyle.None
        bnvSocios.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        bnvSocios.Location = New Point(dgvSocios.Left, dgvSocios.Top - 30)
        bnvSocios.Size = New Size(dgvSocios.Width, 30)
        Me.Controls.Add(bnvSocios)
        bnvSocios.BringToFront()

        AplicarApariencia()
        ConfigurarFormulario()
        CargarSocios()
        ModoConsulta()

    End Sub

    Private Sub ConfigurarFormulario()
        cboEstado.Items.Clear()
        cboEstado.Items.Add("Todos")
        cboEstado.Items.Add("Activos")
        cboEstado.Items.Add("Inactivos")
        cboEstado.SelectedIndex = 0

        cboGenero.Items.Clear()
        cboGenero.Items.Add("F")
        cboGenero.Items.Add("M")
        cboGenero.SelectedIndex = -1

        dgvSocios.ReadOnly = True
        dgvSocios.AllowUserToAddRows = False
        dgvSocios.AllowUserToDeleteRows = False
        dgvSocios.MultiSelect = False
        dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        sociosBindingSource.DataSource = New DataTable()
        bnvSocios.BindingSource = sociosBindingSource
        dgvSocios.DataSource = sociosBindingSource
    End Sub

    Private Function EstadoSeleccionado() As Integer?
        If cboEstado.SelectedIndex = 1 Then Return 1
        If cboEstado.SelectedIndex = 2 Then Return 0
        Return Nothing
    End Function

    Private Sub CargarSocios()
        Try
            sociosBindingSource.DataSource = socioDAO.ListarSocios(txtBuscar.Text, EstadoSeleccionado())
            ConfigurarColumnas()
            dgvSocios.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los socios." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarColumnas()
        If dgvSocios.Columns.Contains("id_socio") Then dgvSocios.Columns("id_socio").Visible = False
        If dgvSocios.Columns.Contains("cedula") Then dgvSocios.Columns("cedula").HeaderText = "Cédula"
        If dgvSocios.Columns.Contains("Nombre") Then dgvSocios.Columns("Nombre").HeaderText = "Socio"
        If dgvSocios.Columns.Contains("Estado") Then dgvSocios.Columns("Estado").HeaderText = "Estado"
    End Sub

    Private Sub ModoConsulta()
        modoEdicion = False
        grpDatos.Enabled = False
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEditar.Enabled = idSocioSeleccionado > 0
        btnEliminar.Enabled = idSocioSeleccionado > 0
        btnNuevo.Enabled = True
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSocioSeleccionado = 0
        LimpiarCampos()
        grpDatos.Enabled = True
        chkActivo.Checked = True
        dtpFechaRegistro.Value = Date.Today
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        dgvSocios.ClearSelection()
        txtCedula.Focus()
    End Sub

    Private Sub ModoEditar()
        If idSocioSeleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un socio.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        modoEdicion = True
        grpDatos.Enabled = True
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        txtCedula.Focus()
    End Sub

    Private Sub LimpiarCampos()
        txtCedula.Clear()
        txtNombres.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()
        cboGenero.SelectedIndex = -1
        dtpFechaNacimiento.Value = Date.Today
        dtpFechaRegistro.Value = Date.Today
        chkActivo.Checked = True
    End Sub

    Private Function ValidarDatos(ByRef cedula As String, ByRef nombres As String, ByRef apellidos As String,
                                  ByRef correo As String) As Boolean
        cedula = txtCedula.Text.Trim()
        nombres = txtNombres.Text.Trim()
        apellidos = txtApellidos.Text.Trim()
        correo = txtCorreo.Text.Trim()

        txtCedula.Text = cedula
        txtNombres.Text = nombres
        txtApellidos.Text = apellidos
        txtCorreo.Text = correo

        If cedula = "" Then
            MessageBox.Show("La cédula es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedula.Focus()
            Return False
        End If
        If nombres = "" Then
            MessageBox.Show("Los nombres son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombres.Focus()
            Return False
        End If
        If apellidos = "" Then
            MessageBox.Show("Los apellidos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellidos.Focus()
            Return False
        End If
        If correo <> "" Then
            Try
                Dim correoValidado As New System.Net.Mail.MailAddress(correo)
                If correoValidado.Address <> correo Then Throw New FormatException()
            Catch ex As FormatException
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCorreo.Focus()
                Return False
            End Try
        End If

        Return True
    End Function

    Private Sub AplicarApariencia()
        Dim fondo As Color = Color.FromArgb(245, 247, 250)
        Dim blanco As Color = Color.White
        Dim azul As Color = Color.FromArgb(79, 124, 172)
        Dim texto As Color = Color.FromArgb(38, 50, 56)
        Dim borde As Color = Color.FromArgb(217, 224, 230)
        Dim grisSuave As Color = Color.FromArgb(246, 248, 250)
        Dim rojo As Color = Color.FromArgb(198, 40, 40)
        Dim fuente As New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.Text = "Gestión de socios"
        Me.ClientSize = New Size(1200, 710)
        Me.BackColor = fondo
        Me.ForeColor = texto
        Me.Font = fuente
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Acciones y búsqueda en la franja superior.
        btnNuevo.SetBounds(24, 20, 86, 34)
        btnEditar.SetBounds(118, 20, 86, 34)
        btnGuardar.SetBounds(212, 20, 86, 34)
        btnEliminar.SetBounds(306, 20, 86, 34)
        btnCancelar.SetBounds(400, 20, 86, 34)
        lblBuscar.Location = New Point(550, 29)
        txtBuscar.SetBounds(605, 20, 270, 34)
        cboEstado.SetBounds(885, 20, 150, 34)
        btnBuscar.SetBounds(1045, 20, 131, 34)

        ' Área de trabajo: listado a la izquierda y datos a la derecha.
        dgvSocios.SetBounds(24, 84, 440, 556)
        grpDatos.SetBounds(488, 80, 688, 400)
        grpCuenta.SetBounds(488, 500, 688, 150)
        bnvSocios.Location = New Point(dgvSocios.Left, dgvSocios.Top - 30)
        bnvSocios.Size = New Size(dgvSocios.Width, 30)
        bnvSocios.Dock = DockStyle.None
        bnvSocios.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        ' Distribución en dos columnas dentro de los datos del socio.
        lblCedula.Location = New Point(24, 54)
        txtCedula.SetBounds(120, 49, 200, 30)
        lblFechaNacimiento.Location = New Point(350, 54)
        dtpFechaNacimiento.SetBounds(475, 49, 185, 30)

        lblNombres.Location = New Point(24, 104)
        txtNombres.SetBounds(120, 99, 200, 30)
        lblGenero.Location = New Point(350, 104)
        cboGenero.SetBounds(475, 99, 185, 30)

        lblApellidos.Location = New Point(24, 154)
        txtApellidos.SetBounds(120, 149, 200, 30)
        lblTelefono.Location = New Point(350, 154)
        txtTelefono.SetBounds(475, 149, 185, 30)

        lblCorreo.Location = New Point(24, 204)
        txtCorreo.SetBounds(120, 199, 200, 30)
        lblDireccion.Location = New Point(350, 204)
        txtDireccion.SetBounds(475, 199, 185, 30)

        lblFechaRegistro.Location = New Point(24, 254)
        dtpFechaRegistro.SetBounds(120, 249, 200, 30)
        chkActivo.Location = New Point(350, 252)

        ' Cuenta de acceso debajo de los datos del socio.
        chkTieneCuenta.Location = New Point(20, 36)
        lblUsuario.Location = New Point(20, 82)
        txtUsuario.SetBounds(80, 76, 220, 30)
        btnRestablecerContrasena.SetBounds(320, 76, 175, 34)
        btnVerMembresias.SetBounds(505, 76, 170, 34)

        For Each control As Control In grpDatos.Controls
            control.Font = fuente
            control.ForeColor = texto
        Next
        For Each control As Control In grpCuenta.Controls
            control.Font = fuente
            control.ForeColor = texto
        Next

        grpDatos.BackColor = blanco
        grpDatos.ForeColor = azul
        grpDatos.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        grpCuenta.BackColor = blanco
        grpCuenta.ForeColor = azul
        grpCuenta.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

        For Each campo As TextBox In New TextBox() {txtBuscar, txtCedula, txtNombres, txtApellidos, txtTelefono, txtCorreo, txtDireccion, txtUsuario}
            campo.Font = fuente
            campo.ForeColor = texto
            campo.BackColor = blanco
            campo.BorderStyle = BorderStyle.FixedSingle
            campo.AutoSize = False
        Next

        For Each lista As ComboBox In New ComboBox() {cboEstado, cboGenero}
            lista.Font = fuente
            lista.ForeColor = texto
            lista.BackColor = blanco
            lista.FlatStyle = FlatStyle.Flat
        Next

        dtpFechaNacimiento.Font = fuente
        dtpFechaNacimiento.CalendarMonthBackground = blanco
        dtpFechaRegistro.Font = fuente
        dtpFechaRegistro.CalendarMonthBackground = blanco

        EstilizarBoton(btnNuevo, blanco, azul, borde)
        EstilizarBoton(btnEditar, blanco, azul, borde)
        EstilizarBoton(btnGuardar, azul, blanco, azul)
        EstilizarBoton(btnEliminar, rojo, blanco, rojo)
        EstilizarBoton(btnCancelar, blanco, texto, borde)
        EstilizarBoton(btnBuscar, azul, blanco, azul)
        EstilizarBoton(btnRestablecerContrasena, blanco, azul, borde)
        EstilizarBoton(btnVerMembresias, blanco, azul, borde)

        lblBuscar.ForeColor = texto
        For Each etiqueta As Label In New Label() {lblCedula, lblNombres, lblApellidos, lblFechaNacimiento, lblGenero, lblTelefono, lblCorreo, lblDireccion, lblFechaRegistro, lblUsuario}
            etiqueta.ForeColor = Color.FromArgb(85, 98, 108)
        Next

        dgvSocios.BackgroundColor = blanco
        dgvSocios.BorderStyle = BorderStyle.None
        dgvSocios.GridColor = borde
        dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSocios.MultiSelect = False
        dgvSocios.EnableHeadersVisualStyles = False
        dgvSocios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvSocios.ColumnHeadersDefaultCellStyle.BackColor = azul
        dgvSocios.ColumnHeadersDefaultCellStyle.ForeColor = blanco
        dgvSocios.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        dgvSocios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvSocios.ColumnHeadersHeight = 38
        dgvSocios.DefaultCellStyle.BackColor = blanco
        dgvSocios.DefaultCellStyle.ForeColor = texto
        dgvSocios.DefaultCellStyle.Font = fuente
        dgvSocios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 233, 244)
        dgvSocios.DefaultCellStyle.SelectionForeColor = texto
        dgvSocios.DefaultCellStyle.Padding = New Padding(8, 0, 4, 0)
        dgvSocios.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dgvSocios.AlternatingRowsDefaultCellStyle.BackColor = grisSuave
        dgvSocios.AlternatingRowsDefaultCellStyle.ForeColor = texto
        dgvSocios.RowTemplate.Height = 34
        dgvSocios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvSocios.RowHeadersVisible = False
        dgvSocios.Margin = New Padding(0, 0, 12, 0)

        bnvSocios.BackColor = blanco
        bnvSocios.ForeColor = texto
        bnvSocios.GripStyle = ToolStripGripStyle.Hidden
        bnvSocios.RenderMode = ToolStripRenderMode.System
        bnvSocios.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        bnvSocios.Font = fuente
        bnvSocios.Padding = New Padding(4, 2, 4, 2)
        For Each elemento As ToolStripItem In bnvSocios.Items
            elemento.ForeColor = texto
            If TypeOf elemento Is ToolStripButton Then
                DirectCast(elemento, ToolStripButton).DisplayStyle = ToolStripItemDisplayStyle.Image
            End If
        Next
    End Sub

    Private Sub EstilizarBoton(boton As Button, fondo As Color, primerPlano As Color, borde As Color)
        boton.FlatStyle = FlatStyle.Flat
        boton.FlatAppearance.BorderColor = borde
        boton.FlatAppearance.BorderSize = 1
        boton.BackColor = fondo
        boton.ForeColor = primerPlano
        boton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        boton.UseVisualStyleBackColor = False
        boton.Cursor = Cursors.Hand
    End Sub

    Private Sub dgvSocios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSocios.SelectionChanged
        If modoEdicion OrElse dgvSocios.CurrentRow Is Nothing Then Return
        If Not dgvSocios.Columns.Contains("id_socio") Then Return
        If dgvSocios.CurrentRow.Cells("id_socio").Value Is Nothing OrElse IsDBNull(dgvSocios.CurrentRow.Cells("id_socio").Value) Then Return

        CargarSocio(Convert.ToInt32(dgvSocios.CurrentRow.Cells("id_socio").Value))
    End Sub

    Private Sub CargarSocio(idSocio As Integer)
        Try
            Dim socio As DataRow = socioDAO.ObtenerSocioPorId(idSocio)
            If socio Is Nothing Then Return

            idSocioSeleccionado = Convert.ToInt32(socio("id_socio"))
            txtCedula.Text = If(socio.IsNull("cedula"), "", socio("cedula").ToString())
            txtNombres.Text = socio("nombres").ToString()
            txtApellidos.Text = socio("apellidos").ToString()
            If socio.IsNull("fecha_nacimiento") Then
                dtpFechaNacimiento.Value = Date.Today
            Else
                dtpFechaNacimiento.Value = Convert.ToDateTime(socio("fecha_nacimiento"))
            End If
            cboGenero.SelectedItem = If(socio.IsNull("genero"), Nothing, socio("genero").ToString())
            txtTelefono.Text = If(socio.IsNull("telefono"), "", socio("telefono").ToString())
            txtCorreo.Text = If(socio.IsNull("correo"), "", socio("correo").ToString())
            txtDireccion.Text = If(socio.IsNull("direccion"), "", socio("direccion").ToString())
            dtpFechaRegistro.Value = Convert.ToDateTime(socio("fecha_registro"))
            chkActivo.Checked = Convert.ToBoolean(socio("activo"))
            ModoConsulta()
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los datos del socio." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarSocios()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ModoEditar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cedula As String = ""
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim correo As String = ""
        If Not ValidarDatos(cedula, nombres, apellidos, correo) Then Return

        Try
            If socioDAO.ExisteCedula(cedula, If(modoEdicion, CType(idSocioSeleccionado, Integer?), Nothing)) Then
                MessageBox.Show("Ya existe un socio con esa cédula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCedula.Focus()
                Return
            End If

            Dim fechaNacimiento As DateTime? = dtpFechaNacimiento.Value.Date
            Dim guardado As Boolean
            If modoEdicion Then
                guardado = socioDAO.ActualizarSocio(idSocioSeleccionado, cedula, nombres, apellidos, fechaNacimiento,
                                                    ObtenerGenero(), txtTelefono.Text.Trim(), correo, txtDireccion.Text.Trim(),
                                                    dtpFechaRegistro.Value.Date, chkActivo.Checked)
            Else
                guardado = socioDAO.InsertarSocio(cedula, nombres, apellidos, fechaNacimiento,
                                                  ObtenerGenero(), txtTelefono.Text.Trim(), correo, txtDireccion.Text.Trim(),
                                                  dtpFechaRegistro.Value.Date, chkActivo.Checked)
            End If

            If guardado Then
                MessageBox.Show(If(modoEdicion, "Socio actualizado correctamente.", "Socio registrado correctamente."),
                                "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarSocios()
                LimpiarCampos()
                idSocioSeleccionado = 0
                ModoConsulta()
            Else
                MessageBox.Show("No se realizaron cambios en el socio.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As MySqlConnector.MySqlException When ex.Number = 1062
            MessageBox.Show("La cédula ya está registrada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el socio." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerGenero() As String
        If cboGenero.SelectedIndex < 0 Then Return ""
        Return cboGenero.SelectedItem.ToString()
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSocioSeleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un socio.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not chkActivo.Checked Then
            MessageBox.Show("El socio ya está inactivo.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("¿Desea dar de baja al socio seleccionado?", "Confirmar baja",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            If socioDAO.DesactivarSocio(idSocioSeleccionado) Then
                MessageBox.Show("Socio dado de baja correctamente.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarSocios()
                LimpiarCampos()
                idSocioSeleccionado = 0
                ModoConsulta()
            Else
                MessageBox.Show("El socio ya estaba inactivo o no existe.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo dar de baja al socio." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarCampos()
        idSocioSeleccionado = 0
        dgvSocios.ClearSelection()
        ModoConsulta()
    End Sub
End Class
