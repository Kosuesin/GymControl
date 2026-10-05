<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSocios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnNuevo = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnCancelar = New Button()
        lblBuscar = New Label()
        txtBuscar = New TextBox()
        cboEstado = New ComboBox()
        btnBuscar = New Button()
        dgvSocios = New DataGridView()
        grpDatos = New GroupBox()
        chkActivo = New CheckBox()
        dtpFechaRegistro = New DateTimePicker()
        lblFechaRegistro = New Label()
        txtDireccion = New TextBox()
        lblDireccion = New Label()
        txtCorreo = New TextBox()
        lblCorreo = New Label()
        txtTelefono = New TextBox()
        lblTelefono = New Label()
        cboGenero = New ComboBox()
        lblGenero = New Label()
        dtpFechaNacimiento = New DateTimePicker()
        lblFechaNacimiento = New Label()
        txtApellidos = New TextBox()
        lblApellidos = New Label()
        txtNombres = New TextBox()
        lblNombres = New Label()
        txtCedula = New TextBox()
        lblCedula = New Label()
        grpCuenta = New GroupBox()
        btnVerMembresias = New Button()
        btnRestablecerContrasena = New Button()
        txtUsuario = New TextBox()
        lblUsuario = New Label()
        chkTieneCuenta = New CheckBox()
        CType(dgvSocios, ComponentModel.ISupportInitialize).BeginInit()
        grpDatos.SuspendLayout()
        grpCuenta.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.White
        btnNuevo.Cursor = Cursors.Hand
        btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(230))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNuevo.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnNuevo.Location = New Point(24, 20)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 34)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.White
        btnEditar.Cursor = Cursors.Hand
        btnEditar.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(230))
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEditar.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnEditar.Location = New Point(116, 20)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 34)
        btnEditar.TabIndex = 1
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(212, 20)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 34)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(198), CByte(40), CByte(40))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(198), CByte(40), CByte(40))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(306, 20)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 34)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.White
        btnCancelar.Cursor = Cursors.Hand
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(230))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        btnCancelar.Location = New Point(400, 20)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(86, 34)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Font = New Font("Segoe UI", 9F)
        lblBuscar.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblBuscar.Location = New Point(550, 29)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(45, 15)
        lblBuscar.TabIndex = 5
        lblBuscar.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.BackColor = Color.White
        txtBuscar.BorderStyle = BorderStyle.FixedSingle
        txtBuscar.Font = New Font("Segoe UI", 9F)
        txtBuscar.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtBuscar.Location = New Point(605, 20)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "cédula, nombre o apellido"
        txtBuscar.Size = New Size(270, 34)
        txtBuscar.TabIndex = 6
        ' 
        ' cboEstado
        ' 
        cboEstado.BackColor = Color.White
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEstado.FlatStyle = FlatStyle.Flat
        cboEstado.Font = New Font("Segoe UI", 9F)
        cboEstado.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(885, 20)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(150, 23)
        cboEstado.TabIndex = 7
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnBuscar.Cursor = Cursors.Hand
        btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBuscar.ForeColor = Color.White
        btnBuscar.Location = New Point(1045, 20)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(131, 34)
        btnBuscar.TabIndex = 8
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvSocios
        ' 
        dgvSocios.AllowUserToAddRows = False
        dgvSocios.AllowUserToDeleteRows = False
        dgvSocios.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(250))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        dgvSocios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSocios.BackgroundColor = Color.White
        dgvSocios.BorderStyle = BorderStyle.None
        dgvSocios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvSocios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvSocios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvSocios.ColumnHeadersHeight = 38
        dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DataGridViewCellStyle6.Padding = New Padding(8, 0, 4, 0)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(221), CByte(233), CByte(244))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvSocios.DefaultCellStyle = DataGridViewCellStyle6
        dgvSocios.EnableHeadersVisualStyles = False
        dgvSocios.GridColor = Color.FromArgb(CByte(217), CByte(224), CByte(230))
        dgvSocios.Location = New Point(24, 84)
        dgvSocios.Margin = New Padding(0, 0, 12, 0)
        dgvSocios.MultiSelect = False
        dgvSocios.Name = "dgvSocios"
        dgvSocios.ReadOnly = True
        dgvSocios.RowHeadersVisible = False
        dgvSocios.RowTemplate.Height = 34
        dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSocios.Size = New Size(440, 556)
        dgvSocios.TabIndex = 9
        ' 
        ' grpDatos
        ' 
        grpDatos.BackColor = Color.White
        grpDatos.Controls.Add(chkActivo)
        grpDatos.Controls.Add(dtpFechaRegistro)
        grpDatos.Controls.Add(lblFechaRegistro)
        grpDatos.Controls.Add(txtDireccion)
        grpDatos.Controls.Add(lblDireccion)
        grpDatos.Controls.Add(txtCorreo)
        grpDatos.Controls.Add(lblCorreo)
        grpDatos.Controls.Add(txtTelefono)
        grpDatos.Controls.Add(lblTelefono)
        grpDatos.Controls.Add(cboGenero)
        grpDatos.Controls.Add(lblGenero)
        grpDatos.Controls.Add(dtpFechaNacimiento)
        grpDatos.Controls.Add(lblFechaNacimiento)
        grpDatos.Controls.Add(txtApellidos)
        grpDatos.Controls.Add(lblApellidos)
        grpDatos.Controls.Add(txtNombres)
        grpDatos.Controls.Add(lblNombres)
        grpDatos.Controls.Add(txtCedula)
        grpDatos.Controls.Add(lblCedula)
        grpDatos.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        grpDatos.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        grpDatos.Location = New Point(488, 80)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New Size(688, 400)
        grpDatos.TabIndex = 10
        grpDatos.TabStop = False
        grpDatos.Text = "Datos del socio"
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.BackColor = Color.White
        chkActivo.Font = New Font("Segoe UI", 9F)
        chkActivo.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        chkActivo.Location = New Point(350, 252)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(60, 19)
        chkActivo.TabIndex = 18
        chkActivo.Text = "Activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' dtpFechaRegistro
        ' 
        dtpFechaRegistro.Font = New Font("Segoe UI", 9F)
        dtpFechaRegistro.Location = New Point(120, 249)
        dtpFechaRegistro.Name = "dtpFechaRegistro"
        dtpFechaRegistro.Size = New Size(200, 23)
        dtpFechaRegistro.TabIndex = 17
        ' 
        ' lblFechaRegistro
        ' 
        lblFechaRegistro.AutoSize = True
        lblFechaRegistro.Font = New Font("Segoe UI", 9F)
        lblFechaRegistro.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblFechaRegistro.Location = New Point(24, 254)
        lblFechaRegistro.Name = "lblFechaRegistro"
        lblFechaRegistro.Size = New Size(81, 15)
        lblFechaRegistro.TabIndex = 16
        lblFechaRegistro.Text = "Fecha registro"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.BackColor = Color.White
        txtDireccion.BorderStyle = BorderStyle.FixedSingle
        txtDireccion.Font = New Font("Segoe UI", 9F)
        txtDireccion.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtDireccion.Location = New Point(475, 199)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(185, 30)
        txtDireccion.TabIndex = 15
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Segoe UI", 9F)
        lblDireccion.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblDireccion.Location = New Point(350, 204)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(57, 15)
        lblDireccion.TabIndex = 14
        lblDireccion.Text = "Dirección"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BackColor = Color.White
        txtCorreo.BorderStyle = BorderStyle.FixedSingle
        txtCorreo.Font = New Font("Segoe UI", 9F)
        txtCorreo.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtCorreo.Location = New Point(120, 199)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(200, 30)
        txtCorreo.TabIndex = 13
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Font = New Font("Segoe UI", 9F)
        lblCorreo.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblCorreo.Location = New Point(24, 204)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(43, 15)
        lblCorreo.TabIndex = 12
        lblCorreo.Text = "Correo"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BackColor = Color.White
        txtTelefono.BorderStyle = BorderStyle.FixedSingle
        txtTelefono.Font = New Font("Segoe UI", 9F)
        txtTelefono.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtTelefono.Location = New Point(475, 149)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(185, 30)
        txtTelefono.TabIndex = 11
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Font = New Font("Segoe UI", 9F)
        lblTelefono.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblTelefono.Location = New Point(350, 154)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(53, 15)
        lblTelefono.TabIndex = 10
        lblTelefono.Text = "Télefono"
        ' 
        ' cboGenero
        ' 
        cboGenero.BackColor = Color.White
        cboGenero.FlatStyle = FlatStyle.Flat
        cboGenero.Font = New Font("Segoe UI", 9F)
        cboGenero.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        cboGenero.FormattingEnabled = True
        cboGenero.Location = New Point(475, 99)
        cboGenero.Name = "cboGenero"
        cboGenero.Size = New Size(185, 23)
        cboGenero.TabIndex = 9
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.Font = New Font("Segoe UI", 9F)
        lblGenero.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblGenero.Location = New Point(350, 104)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(45, 15)
        lblGenero.TabIndex = 8
        lblGenero.Text = "Género"
        ' 
        ' dtpFechaNacimiento
        ' 
        dtpFechaNacimiento.Font = New Font("Segoe UI", 9F)
        dtpFechaNacimiento.Location = New Point(475, 49)
        dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        dtpFechaNacimiento.Size = New Size(185, 23)
        dtpFechaNacimiento.TabIndex = 7
        ' 
        ' lblFechaNacimiento
        ' 
        lblFechaNacimiento.AutoSize = True
        lblFechaNacimiento.Font = New Font("Segoe UI", 9F)
        lblFechaNacimiento.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblFechaNacimiento.Location = New Point(350, 54)
        lblFechaNacimiento.Name = "lblFechaNacimiento"
        lblFechaNacimiento.Size = New Size(103, 15)
        lblFechaNacimiento.TabIndex = 6
        lblFechaNacimiento.Text = "Fecha Nacimiento"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.BackColor = Color.White
        txtApellidos.BorderStyle = BorderStyle.FixedSingle
        txtApellidos.Font = New Font("Segoe UI", 9F)
        txtApellidos.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtApellidos.Location = New Point(120, 149)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New Size(200, 30)
        txtApellidos.TabIndex = 5
        ' 
        ' lblApellidos
        ' 
        lblApellidos.AutoSize = True
        lblApellidos.Font = New Font("Segoe UI", 9F)
        lblApellidos.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblApellidos.Location = New Point(24, 154)
        lblApellidos.Name = "lblApellidos"
        lblApellidos.Size = New Size(64, 15)
        lblApellidos.TabIndex = 4
        lblApellidos.Text = "Apellidos *"
        ' 
        ' txtNombres
        ' 
        txtNombres.BackColor = Color.White
        txtNombres.BorderStyle = BorderStyle.FixedSingle
        txtNombres.Font = New Font("Segoe UI", 9F)
        txtNombres.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtNombres.Location = New Point(120, 99)
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New Size(200, 30)
        txtNombres.TabIndex = 3
        ' 
        ' lblNombres
        ' 
        lblNombres.AutoSize = True
        lblNombres.Font = New Font("Segoe UI", 9F)
        lblNombres.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblNombres.Location = New Point(24, 104)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New Size(64, 15)
        lblNombres.TabIndex = 2
        lblNombres.Text = "Nombres *"
        ' 
        ' txtCedula
        ' 
        txtCedula.BackColor = Color.White
        txtCedula.BorderStyle = BorderStyle.FixedSingle
        txtCedula.Font = New Font("Segoe UI", 9F)
        txtCedula.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtCedula.Location = New Point(120, 49)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(200, 30)
        txtCedula.TabIndex = 1
        ' 
        ' lblCedula
        ' 
        lblCedula.AutoSize = True
        lblCedula.Font = New Font("Segoe UI", 9F)
        lblCedula.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblCedula.Location = New Point(24, 54)
        lblCedula.Name = "lblCedula"
        lblCedula.Size = New Size(52, 15)
        lblCedula.TabIndex = 0
        lblCedula.Text = "Cédula *"
        ' 
        ' grpCuenta
        ' 
        grpCuenta.BackColor = Color.White
        grpCuenta.Controls.Add(btnVerMembresias)
        grpCuenta.Controls.Add(btnRestablecerContrasena)
        grpCuenta.Controls.Add(txtUsuario)
        grpCuenta.Controls.Add(lblUsuario)
        grpCuenta.Controls.Add(chkTieneCuenta)
        grpCuenta.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        grpCuenta.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        grpCuenta.Location = New Point(488, 500)
        grpCuenta.Name = "grpCuenta"
        grpCuenta.Size = New Size(688, 150)
        grpCuenta.TabIndex = 11
        grpCuenta.TabStop = False
        grpCuenta.Text = "Cuenta de acceso al portal"
        ' 
        ' btnVerMembresias
        ' 
        btnVerMembresias.BackColor = Color.White
        btnVerMembresias.Cursor = Cursors.Hand
        btnVerMembresias.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(230))
        btnVerMembresias.FlatStyle = FlatStyle.Flat
        btnVerMembresias.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVerMembresias.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnVerMembresias.Location = New Point(505, 76)
        btnVerMembresias.Name = "btnVerMembresias"
        btnVerMembresias.Size = New Size(170, 34)
        btnVerMembresias.TabIndex = 4
        btnVerMembresias.Text = "Ver membresías del socio"
        btnVerMembresias.UseVisualStyleBackColor = False
        ' 
        ' btnRestablecerContrasena
        ' 
        btnRestablecerContrasena.BackColor = Color.White
        btnRestablecerContrasena.Cursor = Cursors.Hand
        btnRestablecerContrasena.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(230))
        btnRestablecerContrasena.FlatStyle = FlatStyle.Flat
        btnRestablecerContrasena.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnRestablecerContrasena.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnRestablecerContrasena.Location = New Point(320, 76)
        btnRestablecerContrasena.Name = "btnRestablecerContrasena"
        btnRestablecerContrasena.Size = New Size(175, 34)
        btnRestablecerContrasena.TabIndex = 3
        btnRestablecerContrasena.Text = "Restablecer contraseña"
        btnRestablecerContrasena.UseVisualStyleBackColor = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.White
        txtUsuario.BorderStyle = BorderStyle.FixedSingle
        txtUsuario.Font = New Font("Segoe UI", 9F)
        txtUsuario.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtUsuario.Location = New Point(80, 76)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(220, 30)
        txtUsuario.TabIndex = 2
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 9F)
        lblUsuario.ForeColor = Color.FromArgb(CByte(85), CByte(98), CByte(108))
        lblUsuario.Location = New Point(20, 82)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(47, 15)
        lblUsuario.TabIndex = 1
        lblUsuario.Text = "Usuario"
        ' 
        ' chkTieneCuenta
        ' 
        chkTieneCuenta.AutoSize = True
        chkTieneCuenta.BackColor = Color.White
        chkTieneCuenta.Font = New Font("Segoe UI", 9F)
        chkTieneCuenta.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        chkTieneCuenta.Location = New Point(20, 36)
        chkTieneCuenta.Name = "chkTieneCuenta"
        chkTieneCuenta.Size = New Size(189, 19)
        chkTieneCuenta.TabIndex = 0
        chkTieneCuenta.Text = "El socio tiene cuenta de acceso"
        chkTieneCuenta.UseVisualStyleBackColor = True
        ' 
        ' FrmSocios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1200, 710)
        Controls.Add(grpCuenta)
        Controls.Add(grpDatos)
        Controls.Add(dgvSocios)
        Controls.Add(btnBuscar)
        Controls.Add(cboEstado)
        Controls.Add(txtBuscar)
        Controls.Add(lblBuscar)
        Controls.Add(btnCancelar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnEditar)
        Controls.Add(btnNuevo)
        Font = New Font("Segoe UI", 9F)
        ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Name = "FrmSocios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestión de socios"
        CType(dgvSocios, ComponentModel.ISupportInitialize).EndInit()
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        grpCuenta.ResumeLayout(False)
        grpCuenta.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvSocios As DataGridView
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents lblGenero As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents dtpFechaRegistro As DateTimePicker
    Friend WithEvents lblFechaRegistro As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents grpCuenta As GroupBox
    Friend WithEvents btnVerMembresias As Button
    Friend WithEvents btnRestablecerContrasena As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents chkTieneCuenta As CheckBox
End Class
