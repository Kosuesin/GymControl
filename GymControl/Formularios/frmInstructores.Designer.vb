<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstructores
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblContratacion = New System.Windows.Forms.Label()
        Me.dtpFechaContratacion = New System.Windows.Forms.DateTimePicker()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvInstructores = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        CType(Me.dgvInstructores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' ENCABEZADO
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 43, 54)
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(820, 60)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(15, 15)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(220, 25)
        Me.lblTitulo.Text = "Gestión de Instructores"
        '
        ' FORMULARIO DE DATOS
        '
        Me.grpDatos.Controls.Add(Me.chkActivo)
        Me.grpDatos.Controls.Add(Me.dtpFechaContratacion)
        Me.grpDatos.Controls.Add(Me.lblContratacion)
        Me.grpDatos.Controls.Add(Me.cboEspecialidad)
        Me.grpDatos.Controls.Add(Me.lblEspecialidad)
        Me.grpDatos.Controls.Add(Me.txtCorreo)
        Me.grpDatos.Controls.Add(Me.lblCorreo)
        Me.grpDatos.Controls.Add(Me.txtTelefono)
        Me.grpDatos.Controls.Add(Me.lblTelefono)
        Me.grpDatos.Controls.Add(Me.txtApellidos)
        Me.grpDatos.Controls.Add(Me.lblApellidos)
        Me.grpDatos.Controls.Add(Me.txtNombres)
        Me.grpDatos.Controls.Add(Me.lblNombres)
        Me.grpDatos.Controls.Add(Me.txtCedula)
        Me.grpDatos.Controls.Add(Me.lblCedula)
        Me.grpDatos.Controls.Add(Me.txtId)
        Me.grpDatos.Controls.Add(Me.lblId)
        Me.grpDatos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpDatos.Location = New System.Drawing.Point(15, 68)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(280, 350)
        Me.grpDatos.TabIndex = 1
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos del Instructor"
        '
        ' lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblId.Location = New System.Drawing.Point(15, 30)
        Me.lblId.Text = "ID:"
        '
        ' txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtId.Location = New System.Drawing.Point(100, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(160, 23)
        '
        ' lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCedula.Location = New System.Drawing.Point(15, 65)
        Me.lblCedula.Text = "Cédula:"
        '
        ' txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCedula.Location = New System.Drawing.Point(100, 62)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(160, 23)
        '
        ' lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNombres.Location = New System.Drawing.Point(15, 100)
        Me.lblNombres.Text = "Nombres:"
        '
        ' txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombres.Location = New System.Drawing.Point(100, 97)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(160, 23)
        '
        ' lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblApellidos.Location = New System.Drawing.Point(15, 135)
        Me.lblApellidos.Text = "Apellidos:"
        '
        ' txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApellidos.Location = New System.Drawing.Point(100, 132)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(160, 23)
        '
        ' lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTelefono.Location = New System.Drawing.Point(15, 170)
        Me.lblTelefono.Text = "Teléfono:"
        '
        ' txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(100, 167)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 23)
        '
        ' lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCorreo.Location = New System.Drawing.Point(15, 205)
        Me.lblCorreo.Text = "Correo:"
        '
        ' txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCorreo.Location = New System.Drawing.Point(100, 202)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(160, 23)
        '
        ' lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEspecialidad.Location = New System.Drawing.Point(15, 240)
        Me.lblEspecialidad.Text = "Especialidad:"
        '
        ' cboEspecialidad
        '
        Me.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboEspecialidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Location = New System.Drawing.Point(100, 237)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(160, 23)
        '
        ' lblContratacion
        '
        Me.lblContratacion.AutoSize = True
        Me.lblContratacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblContratacion.Location = New System.Drawing.Point(15, 275)
        Me.lblContratacion.Text = "Contratación:"
        '
        ' dtpFechaContratacion
        '
        Me.dtpFechaContratacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFechaContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaContratacion.Location = New System.Drawing.Point(100, 272)
        Me.dtpFechaContratacion.Name = "dtpFechaContratacion"
        Me.dtpFechaContratacion.ShowCheckBox = True
        Me.dtpFechaContratacion.Size = New System.Drawing.Size(160, 23)
        '
        ' chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkActivo.Location = New System.Drawing.Point(100, 315)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(60, 19)
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        ' BOTONES DE ACCIÓN
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(33, 43, 54)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(15, 430)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(130, 35)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        ' btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(165, 430)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 35)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        ' btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(15, 472)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 35)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        ' btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(165, 472)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 35)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        ' btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(15, 514)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(280, 35)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        ' BÚSQUEDA
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBuscar.Location = New System.Drawing.Point(310, 72)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Text = "Buscar:"
        '
        ' txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(375, 69)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PlaceholderText = "Cédula, nombre o especialidad"
        Me.txtBuscar.Size = New System.Drawing.Size(425, 23)
        '
        ' TABLA DE INSTRUCTORES
        '
        Me.dgvInstructores.AllowUserToAddRows = False
        Me.dgvInstructores.AllowUserToDeleteRows = False
        Me.dgvInstructores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInstructores.BackgroundColor = System.Drawing.Color.White
        Me.dgvInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInstructores.Location = New System.Drawing.Point(310, 100)
        Me.dgvInstructores.MultiSelect = False
        Me.dgvInstructores.Name = "dgvInstructores"
        Me.dgvInstructores.ReadOnly = True
        Me.dgvInstructores.RowHeadersVisible = False
        Me.dgvInstructores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstructores.Size = New System.Drawing.Size(490, 449)
        Me.dgvInstructores.TabIndex = 6
        '
        ' PROPIEDADES DEL FORMULARIO
        '
        Me.ClientSize = New System.Drawing.Size(820, 570)
        Me.Controls.Add(Me.dgvInstructores)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInstructores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Instructores"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.dgvInstructores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' DECLARACIÓN DE CONTROLES
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents cboEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblContratacion As System.Windows.Forms.Label
    Friend WithEvents dtpFechaContratacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvInstructores As System.Windows.Forms.DataGridView

End Class
