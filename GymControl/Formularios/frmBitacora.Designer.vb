<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacora
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
        lblSubtitulo = New Label()
        lblBuscar = New Label()
        txtBuscarUsuario = New TextBox()
        lblResultado = New Label()
        cboResultado = New ComboBox()
        lblDesde = New Label()
        dtpDesde = New DateTimePicker()
        lblHasta = New Label()
        dtpHasta = New DateTimePicker()
        btnFiltrar = New Button()
        btnLimpiar = New Button()
        btnActualizar = New Button()
        lblTotal = New Label()
        lblExitosos = New Label()
        lblFallidos = New Label()
        lblBloqueados = New Label()
        dgvBitacora = New DataGridView()
        CType(dgvBitacora, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(12, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(166, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Bitácora de accesos"
        ' 
        ' lblSubtitulo
        ' 
        lblSubtitulo.AutoSize = True
        lblSubtitulo.Location = New Point(12, 34)
        lblSubtitulo.Name = "lblSubtitulo"
        lblSubtitulo.Size = New Size(322, 25)
        lblSubtitulo.TabIndex = 1
        lblSubtitulo.Text = "Registro de intentos de inicio de sesión"
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(12, 84)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(76, 25)
        lblBuscar.TabIndex = 2
        lblBuscar.Text = "Usuario:"
        ' 
        ' txtBuscarUsuario
        ' 
        txtBuscarUsuario.Location = New Point(12, 112)
        txtBuscarUsuario.Name = "txtBuscarUsuario"
        txtBuscarUsuario.Size = New Size(301, 31)
        txtBuscarUsuario.TabIndex = 3
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(346, 84)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(94, 25)
        lblResultado.TabIndex = 4
        lblResultado.Text = "Resultado:"
        ' 
        ' cboResultado
        ' 
        cboResultado.FormattingEnabled = True
        cboResultado.Location = New Point(346, 110)
        cboResultado.Name = "cboResultado"
        cboResultado.Size = New Size(314, 33)
        cboResultado.TabIndex = 5
        ' 
        ' lblDesde
        ' 
        lblDesde.AutoSize = True
        lblDesde.Location = New Point(12, 169)
        lblDesde.Name = "lblDesde"
        lblDesde.Size = New Size(66, 25)
        lblDesde.TabIndex = 6
        lblDesde.Text = "Desde:"
        ' 
        ' dtpDesde
        ' 
        dtpDesde.Location = New Point(12, 206)
        dtpDesde.Name = "dtpDesde"
        dtpDesde.Size = New Size(301, 31)
        dtpDesde.TabIndex = 7
        ' 
        ' lblHasta
        ' 
        lblHasta.AutoSize = True
        lblHasta.Location = New Point(346, 169)
        lblHasta.Name = "lblHasta"
        lblHasta.Size = New Size(61, 25)
        lblHasta.TabIndex = 8
        lblHasta.Text = "Hasta:"
        ' 
        ' dtpHasta
        ' 
        dtpHasta.Location = New Point(346, 206)
        dtpHasta.Name = "dtpHasta"
        dtpHasta.Size = New Size(314, 31)
        dtpHasta.TabIndex = 9
        ' 
        ' btnFiltrar
        ' 
        btnFiltrar.Location = New Point(12, 267)
        btnFiltrar.Name = "btnFiltrar"
        btnFiltrar.Size = New Size(154, 34)
        btnFiltrar.TabIndex = 10
        btnFiltrar.Text = "Filtrar"
        btnFiltrar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(180, 267)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(154, 34)
        btnLimpiar.TabIndex = 11
        btnLimpiar.Text = "Limpiar filtros"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(346, 267)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(154, 34)
        btnActualizar.TabIndex = 12
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(12, 323)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(68, 25)
        lblTotal.TabIndex = 13
        lblTotal.Text = "Total: 0"
        ' 
        ' lblExitosos
        ' 
        lblExitosos.AutoSize = True
        lblExitosos.Location = New Point(159, 323)
        lblExitosos.Name = "lblExitosos"
        lblExitosos.Size = New Size(96, 25)
        lblExitosos.TabIndex = 14
        lblExitosos.Text = "Exitosos: 0"
        ' 
        ' lblFallidos
        ' 
        lblFallidos.AutoSize = True
        lblFallidos.Location = New Point(317, 323)
        lblFallidos.Name = "lblFallidos"
        lblFallidos.Size = New Size(90, 25)
        lblFallidos.TabIndex = 15
        lblFallidos.Text = "Fallidos: 0"
        ' 
        ' lblBloqueados
        ' 
        lblBloqueados.AutoSize = True
        lblBloqueados.Location = New Point(459, 323)
        lblBloqueados.Name = "lblBloqueados"
        lblBloqueados.Size = New Size(125, 25)
        lblBloqueados.TabIndex = 16
        lblBloqueados.Text = "Bloqueados: 0"
        ' 
        ' dgvBitacora
        ' 
        dgvBitacora.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBitacora.Location = New Point(12, 362)
        dgvBitacora.Name = "dgvBitacora"
        dgvBitacora.RowHeadersWidth = 62
        dgvBitacora.Size = New Size(954, 220)
        dgvBitacora.TabIndex = 17
        ' 
        ' frmBitacora
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 594)
        Controls.Add(dgvBitacora)
        Controls.Add(lblBloqueados)
        Controls.Add(lblFallidos)
        Controls.Add(lblExitosos)
        Controls.Add(lblTotal)
        Controls.Add(btnActualizar)
        Controls.Add(btnLimpiar)
        Controls.Add(btnFiltrar)
        Controls.Add(dtpHasta)
        Controls.Add(lblHasta)
        Controls.Add(dtpDesde)
        Controls.Add(lblDesde)
        Controls.Add(cboResultado)
        Controls.Add(lblResultado)
        Controls.Add(txtBuscarUsuario)
        Controls.Add(lblBuscar)
        Controls.Add(lblSubtitulo)
        Controls.Add(lblTitulo)
        MinimumSize = New Size(900, 550)
        Name = "frmBitacora"
        StartPosition = FormStartPosition.CenterParent
        Text = "Bitácora de accesos — GymControl"
        CType(dgvBitacora, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarUsuario As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents cboResultado As ComboBox
    Friend WithEvents lblDesde As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents lblHasta As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblExitosos As Label
    Friend WithEvents lblFallidos As Label
    Friend WithEvents lblBloqueados As Label
    Friend WithEvents dgvBitacora As DataGridView
End Class
