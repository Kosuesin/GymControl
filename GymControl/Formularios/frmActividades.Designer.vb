<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividades
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
        lblDescripcion = New Label()
        txtDescripcion = New TextBox()
        lblDuracion = New Label()
        nudDuracion = New NumericUpDown()
        lblCupoMaximo = New Label()
        chkActivo = New CheckBox()
        nudCupoMaximo = New NumericUpDown()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnDesactivar = New Button()
        btnSalas = New Button()
        dgvActividades = New DataGridView()
        CType(nudDuracion, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudCupoMaximo, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvActividades, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(298, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(190, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Gestión de actividades"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 83)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(82, 25)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(125, 83)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(440, 31)
        txtNombre.TabIndex = 2
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(12, 137)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(108, 25)
        lblDescripcion.TabIndex = 3
        lblDescripcion.Text = "Descripcion:"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(125, 134)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(440, 31)
        txtDescripcion.TabIndex = 4
        ' 
        ' lblDuracion
        ' 
        lblDuracion.AutoSize = True
        lblDuracion.Location = New Point(12, 196)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(132, 25)
        lblDuracion.TabIndex = 5
        lblDuracion.Text = "Duración (min):"
        ' 
        ' nudDuracion
        ' 
        nudDuracion.Location = New Point(150, 196)
        nudDuracion.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        nudDuracion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudDuracion.Name = "nudDuracion"
        nudDuracion.Size = New Size(90, 31)
        nudDuracion.TabIndex = 6
        nudDuracion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblCupoMaximo
        ' 
        lblCupoMaximo.AutoSize = True
        lblCupoMaximo.Location = New Point(342, 196)
        lblCupoMaximo.Name = "lblCupoMaximo"
        lblCupoMaximo.Size = New Size(128, 25)
        lblCupoMaximo.TabIndex = 7
        lblCupoMaximo.Text = "Cupo máximo:"
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = CheckState.Checked
        chkActivo.Location = New Point(12, 233)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(86, 29)
        chkActivo.TabIndex = 8
        chkActivo.Text = "Activa"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' nudCupoMaximo
        ' 
        nudCupoMaximo.Location = New Point(476, 194)
        nudCupoMaximo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudCupoMaximo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudCupoMaximo.Name = "nudCupoMaximo"
        nudCupoMaximo.Size = New Size(90, 31)
        nudCupoMaximo.TabIndex = 9
        nudCupoMaximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(12, 287)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(184, 48)
        btnNuevo.TabIndex = 10
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(211, 287)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(184, 48)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnDesactivar
        ' 
        btnDesactivar.Location = New Point(416, 287)
        btnDesactivar.Name = "btnDesactivar"
        btnDesactivar.Size = New Size(184, 48)
        btnDesactivar.TabIndex = 12
        btnDesactivar.Text = "Desactivar"
        btnDesactivar.UseVisualStyleBackColor = True
        ' 
        ' btnSalas
        ' 
        btnSalas.Location = New Point(632, 287)
        btnSalas.Name = "btnSalas"
        btnSalas.Size = New Size(184, 48)
        btnSalas.TabIndex = 13
        btnSalas.Text = "Gestionar salas"
        btnSalas.UseVisualStyleBackColor = True
        ' 
        ' dgvActividades
        ' 
        dgvActividades.AllowUserToAddRows = False
        dgvActividades.AllowUserToDeleteRows = False
        dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvActividades.Location = New Point(12, 341)
        dgvActividades.MultiSelect = False
        dgvActividades.Name = "dgvActividades"
        dgvActividades.ReadOnly = True
        dgvActividades.RowHeadersWidth = 62
        dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvActividades.Size = New Size(804, 191)
        dgvActividades.TabIndex = 14
        ' 
        ' frmActividades
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 544)
        Controls.Add(dgvActividades)
        Controls.Add(btnSalas)
        Controls.Add(btnDesactivar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(nudCupoMaximo)
        Controls.Add(chkActivo)
        Controls.Add(lblCupoMaximo)
        Controls.Add(nudDuracion)
        Controls.Add(lblDuracion)
        Controls.Add(txtDescripcion)
        Controls.Add(lblDescripcion)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(lblTitulo)
        Name = "frmActividades"
        Text = "frmActividades"
        CType(nudDuracion, ComponentModel.ISupportInitialize).EndInit()
        CType(nudCupoMaximo, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvActividades, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents nudDuracion As NumericUpDown
    Friend WithEvents lblCupoMaximo As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents nudCupoMaximo As NumericUpDown
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnSalas As Button
    Friend WithEvents dgvActividades As DataGridView
End Class
