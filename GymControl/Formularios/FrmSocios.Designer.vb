<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        lblCedula = New Label()
        txtCedula = New TextBox()
        lblNombres = New Label()
        txtNombres = New TextBox()
        lblApellidos = New Label()
        txtApellidos = New TextBox()
        lblFechaNacimiento = New Label()
        dtpFechaNacimiento = New DateTimePicker()
        lblGenero = New Label()
        cboGenero = New ComboBox()
        lblTelefono = New Label()
        txtTelefono = New TextBox()
        lblCorreo = New Label()
        txtCorreo = New TextBox()
        lblDireccion = New Label()
        txtDireccion = New TextBox()
        lblFechaRegistro = New Label()
        dtpFechaRegistro = New DateTimePicker()
        chkActivo = New CheckBox()
        grpCuenta = New GroupBox()
        chkTieneCuenta = New CheckBox()
        lblUsuario = New Label()
        txtUsuario = New TextBox()
        btnRestablecerContrasena = New Button()
        btnVerMembresias = New Button()
        CType(dgvSocios, ComponentModel.ISupportInitialize).BeginInit()
        grpDatos.SuspendLayout()
        grpCuenta.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(12, 12)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(93, 12)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 1
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(174, 12)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(255, 12)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(336, 12)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(429, 16)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(45, 15)
        lblBuscar.TabIndex = 5
        lblBuscar.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(480, 12)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "cédula, nombre o apellido"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 6
        ' 
        ' cboEstado
        ' 
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(586, 12)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(121, 23)
        cboEstado.TabIndex = 7
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(713, 12)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 8
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvSocios
        ' 
        dgvSocios.AllowUserToAddRows = False
        dgvSocios.AllowUserToDeleteRows = False
        dgvSocios.AllowUserToResizeRows = False
        dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocios.Location = New Point(10, 100)
        dgvSocios.MultiSelect = False
        dgvSocios.Name = "dgvSocios"
        dgvSocios.ReadOnly = True
        dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSocios.Size = New Size(359, 364)
        dgvSocios.TabIndex = 9
        ' 
        ' grpDatos
        ' 
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
        grpDatos.Location = New Point(470, 100)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New Size(350, 400)
        grpDatos.TabIndex = 10
        grpDatos.TabStop = False
        grpDatos.Text = "Datos del socio"
        ' 
        ' lblCedula
        ' 
        lblCedula.AutoSize = True
        lblCedula.Location = New Point(22, 46)
        lblCedula.Name = "lblCedula"
        lblCedula.Size = New Size(52, 15)
        lblCedula.TabIndex = 0
        lblCedula.Text = "Cédula *"
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(91, 43)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(100, 23)
        txtCedula.TabIndex = 1
        ' 
        ' lblNombres
        ' 
        lblNombres.AutoSize = True
        lblNombres.Location = New Point(22, 83)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New Size(64, 15)
        lblNombres.TabIndex = 2
        lblNombres.Text = "Nombres *"
        ' 
        ' txtNombres
        ' 
        txtNombres.Location = New Point(92, 75)
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New Size(100, 23)
        txtNombres.TabIndex = 3
        ' 
        ' lblApellidos
        ' 
        lblApellidos.AutoSize = True
        lblApellidos.Location = New Point(22, 113)
        lblApellidos.Name = "lblApellidos"
        lblApellidos.Size = New Size(64, 15)
        lblApellidos.TabIndex = 4
        lblApellidos.Text = "Apellidos *"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(92, 110)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New Size(100, 23)
        txtApellidos.TabIndex = 5
        ' 
        ' lblFechaNacimiento
        ' 
        lblFechaNacimiento.AutoSize = True
        lblFechaNacimiento.Location = New Point(22, 149)
        lblFechaNacimiento.Name = "lblFechaNacimiento"
        lblFechaNacimiento.Size = New Size(103, 15)
        lblFechaNacimiento.TabIndex = 6
        lblFechaNacimiento.Text = "Fecha Nacimiento"
        ' 
        ' dtpFechaNacimiento
        ' 
        dtpFechaNacimiento.Location = New Point(131, 143)
        dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        dtpFechaNacimiento.Size = New Size(200, 23)
        dtpFechaNacimiento.TabIndex = 7
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.Location = New Point(22, 181)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(45, 15)
        lblGenero.TabIndex = 8
        lblGenero.Text = "Género"
        ' 
        ' cboGenero
        ' 
        cboGenero.FormattingEnabled = True
        cboGenero.Location = New Point(92, 178)
        cboGenero.Name = "cboGenero"
        cboGenero.Size = New Size(121, 23)
        cboGenero.TabIndex = 9
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(22, 217)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(53, 15)
        lblTelefono.TabIndex = 10
        lblTelefono.Text = "Télefono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(92, 209)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 11
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(22, 250)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(43, 15)
        lblCorreo.TabIndex = 12
        lblCorreo.Text = "Correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(82, 247)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(100, 23)
        txtCorreo.TabIndex = 13
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(24, 280)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(57, 15)
        lblDireccion.TabIndex = 14
        lblDireccion.Text = "Dirección"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(91, 276)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 15
        ' 
        ' lblFechaRegistro
        ' 
        lblFechaRegistro.AutoSize = True
        lblFechaRegistro.Location = New Point(26, 308)
        lblFechaRegistro.Name = "lblFechaRegistro"
        lblFechaRegistro.Size = New Size(81, 15)
        lblFechaRegistro.TabIndex = 16
        lblFechaRegistro.Text = "Fecha registro"
        ' 
        ' dtpFechaRegistro
        ' 
        dtpFechaRegistro.Location = New Point(113, 305)
        dtpFechaRegistro.Name = "dtpFechaRegistro"
        dtpFechaRegistro.Size = New Size(200, 23)
        dtpFechaRegistro.TabIndex = 17
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Location = New Point(31, 350)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(60, 19)
        chkActivo.TabIndex = 18
        chkActivo.Text = "Activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' grpCuenta
        ' 
        grpCuenta.Controls.Add(btnVerMembresias)
        grpCuenta.Controls.Add(btnRestablecerContrasena)
        grpCuenta.Controls.Add(txtUsuario)
        grpCuenta.Controls.Add(lblUsuario)
        grpCuenta.Controls.Add(chkTieneCuenta)
        grpCuenta.Location = New Point(511, 520)
        grpCuenta.Name = "grpCuenta"
        grpCuenta.Size = New Size(309, 129)
        grpCuenta.TabIndex = 11
        grpCuenta.TabStop = False
        grpCuenta.Text = "Cuenta de acceso al portal"
        ' 
        ' chkTieneCuenta
        ' 
        chkTieneCuenta.AutoSize = True
        chkTieneCuenta.Location = New Point(16, 33)
        chkTieneCuenta.Name = "chkTieneCuenta"
        chkTieneCuenta.Size = New Size(189, 19)
        chkTieneCuenta.TabIndex = 0
        chkTieneCuenta.Text = "El socio tiene cuenta de acceso"
        chkTieneCuenta.UseVisualStyleBackColor = True
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Location = New Point(16, 55)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(47, 15)
        lblUsuario.TabIndex = 1
        lblUsuario.Text = "Usuario"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(69, 52)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(100, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' btnRestablecerContrasena
        ' 
        btnRestablecerContrasena.Location = New Point(6, 81)
        btnRestablecerContrasena.Name = "btnRestablecerContrasena"
        btnRestablecerContrasena.Size = New Size(75, 23)
        btnRestablecerContrasena.TabIndex = 3
        btnRestablecerContrasena.Text = "Restablecer contraseña"
        btnRestablecerContrasena.UseVisualStyleBackColor = True
        ' 
        ' btnVerMembresias
        ' 
        btnVerMembresias.Location = New Point(139, 81)
        btnVerMembresias.Name = "btnVerMembresias"
        btnVerMembresias.Size = New Size(75, 23)
        btnVerMembresias.TabIndex = 4
        btnVerMembresias.Text = "Ver membresías del socio"
        btnVerMembresias.UseVisualStyleBackColor = True
        ' 
        ' FrmSocios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 661)
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
        Name = "FrmSocios"
        Text = "FrmSocios"
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
