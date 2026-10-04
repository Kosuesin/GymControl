Public Class FrmSocios

    Private bnvSocios As New BindingNavigator(True)

    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bnvSocios.Dock = DockStyle.None
        bnvSocios.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        bnvSocios.Location = New Point(dgvSocios.Left, dgvSocios.Top - 30)
        bnvSocios.Size = New Size(dgvSocios.Width, 30)
        Me.Controls.Add(bnvSocios)
        bnvSocios.BringToFront()

        AplicarApariencia()

    End Sub

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

End Class
