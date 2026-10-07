<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalas
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
        lblTitulo = New Label()
        lblNombre = New Label()
        txtNombre = New TextBox()
        lblCapacidad = New Label()
        nudCapacidad = New NumericUpDown()
        chkActivo = New CheckBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnDesactivar = New Button()
        dgvSalas = New DataGridView()
        CType(nudCapacidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSalas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(310, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(140, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Gestión de salas"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 64)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(82, 25)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(144, 58)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(224, 31)
        txtNombre.TabIndex = 2
        ' 
        ' lblCapacidad
        ' 
        lblCapacidad.AutoSize = True
        lblCapacidad.Location = New Point(12, 112)
        lblCapacidad.Name = "lblCapacidad"
        lblCapacidad.Size = New Size(99, 25)
        lblCapacidad.TabIndex = 3
        lblCapacidad.Text = "Capacidad:"
        ' 
        ' nudCapacidad
        ' 
        nudCapacidad.Location = New Point(144, 112)
        nudCapacidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudCapacidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudCapacidad.Name = "nudCapacidad"
        nudCapacidad.Size = New Size(224, 31)
        nudCapacidad.TabIndex = 4
        nudCapacidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = CheckState.Checked
        chkActivo.Location = New Point(12, 153)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(86, 29)
        chkActivo.TabIndex = 5
        chkActivo.Text = "Activa"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(12, 219)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(155, 41)
        btnNuevo.TabIndex = 6
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(310, 219)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(155, 41)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnDesactivar
        ' 
        btnDesactivar.Location = New Point(611, 219)
        btnDesactivar.Name = "btnDesactivar"
        btnDesactivar.Size = New Size(155, 41)
        btnDesactivar.TabIndex = 8
        btnDesactivar.Text = "Desactivar"
        btnDesactivar.UseVisualStyleBackColor = True
        ' 
        ' dgvSalas
        ' 
        dgvSalas.AllowUserToAddRows = False
        dgvSalas.AllowUserToDeleteRows = False
        dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSalas.Location = New Point(12, 292)
        dgvSalas.MultiSelect = False
        dgvSalas.Name = "dgvSalas"
        dgvSalas.ReadOnly = True
        dgvSalas.RowHeadersVisible = False
        dgvSalas.RowHeadersWidth = 62
        dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSalas.Size = New Size(754, 190)
        dgvSalas.TabIndex = 9
        ' 
        ' frmSalas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(778, 494)
        Controls.Add(dgvSalas)
        Controls.Add(btnDesactivar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(chkActivo)
        Controls.Add(nudCapacidad)
        Controls.Add(lblCapacidad)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(lblTitulo)
        Name = "frmSalas"
        StartPosition = FormStartPosition.CenterParent
        Text = "Gestión de salas"
        CType(nudCapacidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSalas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents nudCapacidad As NumericUpDown
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents dgvSalas As DataGridView
End Class
