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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
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
        Me.grpDatos.Controls.Add(Me.cboEspecialidad)
        Me.grpDatos.Controls.Add(Me.lblEspecialidad)
        Me.grpDatos.Controls.Add(Me.txtTelefono)
        Me.grpDatos.Controls.Add(Me.lblTelefono)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.lblNombre)
        Me.grpDatos.Controls.Add(Me.txtId)
        Me.grpDatos.Controls.Add(Me.lblId)
        Me.grpDatos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpDatos.Location = New System.Drawing.Point(15, 75)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(280, 260)
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
        ' lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNombre.Location = New System.Drawing.Point(15, 70)
        Me.lblNombre.Text = "Nombre:"
        '
        ' txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.Location = New System.Drawing.Point(100, 67)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 23)
        '
        ' lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTelefono.Location = New System.Drawing.Point(15, 110)
        Me.lblTelefono.Text = "Teléfono:"
        '
        ' txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(100, 107)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 23)
        '
        ' lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEspecialidad.Location = New System.Drawing.Point(15, 150)
        Me.lblEspecialidad.Text = "Especialidad:"
        '
        ' cboEspecialidad
        '
        Me.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Location = New System.Drawing.Point(100, 147)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(160, 23)
        '
        ' chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkActivo.Location = New System.Drawing.Point(100, 190)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(60, 19)
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        ' BOTONES DE ACCIÓN
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(33, 43, 54)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(15, 350)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 35)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        ' btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(165, 350)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 35)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        ' btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(15, 395)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 35)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        ' btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(165, 395)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(130, 35)
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        ' TABLA DE INSTRUCTORES
        '
        Me.dgvInstructores.AllowUserToAddRows = False
        Me.dgvInstructores.AllowUserToDeleteRows = False
        Me.dgvInstructores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInstructores.BackgroundColor = System.Drawing.Color.White
        Me.dgvInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInstructores.Location = New System.Drawing.Point(310, 83)
        Me.dgvInstructores.MultiSelect = False
        Me.dgvInstructores.Name = "dgvInstructores"
        Me.dgvInstructores.ReadOnly = True
        Me.dgvInstructores.RowHeadersVisible = False
        Me.dgvInstructores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstructores.Size = New System.Drawing.Size(490, 347)
        Me.dgvInstructores.TabIndex = 6
        '
        ' PROPIEDADES DEL FORMULARIO
        '
        Me.ClientSize = New System.Drawing.Size(820, 450)
        Me.Controls.Add(Me.dgvInstructores)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
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

    End Sub

    ' DECLARACIÓN DE CONTROLES
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents cboEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgvInstructores As System.Windows.Forms.DataGridView

End Class