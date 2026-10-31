<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVencimientos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.btnCerrarListado = New System.Windows.Forms.Button()
        Me.btnImprimirListado = New System.Windows.Forms.Button()
        Me.btnVistaPreviaListado = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.chkHorizontal = New System.Windows.Forms.CheckBox()
        Me.nudDiasAdelante = New System.Windows.Forms.NumericUpDown()
        Me.lblDiasAdelante = New System.Windows.Forms.Label()
        Me.nudDiasAtras = New System.Windows.Forms.NumericUpDown()
        Me.lblDiasAtras = New System.Windows.Forms.Label()
        Me.lblTituloListado = New System.Windows.Forms.Label()
        Me.dgvVencimientos = New System.Windows.Forms.DataGridView()
        Me.colCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSocio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stsEstadoListado = New System.Windows.Forms.StatusStrip()
        Me.lblResumenListado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlFiltros.SuspendLayout()
        CType(Me.nudDiasAdelante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiasAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVencimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsEstadoListado.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(CType(245, Byte), CType(247, Byte), CType(250, Byte))
        Me.pnlFiltros.Controls.Add(Me.btnCerrarListado)
        Me.pnlFiltros.Controls.Add(Me.btnImprimirListado)
        Me.pnlFiltros.Controls.Add(Me.btnVistaPreviaListado)
        Me.pnlFiltros.Controls.Add(Me.btnActualizar)
        Me.pnlFiltros.Controls.Add(Me.chkHorizontal)
        Me.pnlFiltros.Controls.Add(Me.nudDiasAdelante)
        Me.pnlFiltros.Controls.Add(Me.lblDiasAdelante)
        Me.pnlFiltros.Controls.Add(Me.nudDiasAtras)
        Me.pnlFiltros.Controls.Add(Me.lblDiasAtras)
        Me.pnlFiltros.Controls.Add(Me.lblTituloListado)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(1160, 124)
        Me.pnlFiltros.TabIndex = 0
        '
        'btnCerrarListado
        '
        Me.btnCerrarListado.BackColor = System.Drawing.Color.FromArgb(CType(232, Byte), CType(237, Byte), CType(240, Byte))
        Me.btnCerrarListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarListado.FlatAppearance.BorderSize = 0
        Me.btnCerrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarListado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarListado.ForeColor = System.Drawing.Color.FromArgb(CType(55, Byte), CType(71, Byte), CType(79, Byte))
        Me.btnCerrarListado.Location = New System.Drawing.Point(1030, 52)
        Me.btnCerrarListado.Name = "btnCerrarListado"
        Me.btnCerrarListado.Size = New System.Drawing.Size(110, 38)
        Me.btnCerrarListado.TabIndex = 9
        Me.btnCerrarListado.Text = "Cerrar"
        Me.btnCerrarListado.UseVisualStyleBackColor = False
        '
        'btnImprimirListado
        '
        Me.btnImprimirListado.BackColor = System.Drawing.Color.FromArgb(CType(79, Byte), CType(124, Byte), CType(172, Byte))
        Me.btnImprimirListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimirListado.FlatAppearance.BorderSize = 0
        Me.btnImprimirListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirListado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirListado.ForeColor = System.Drawing.Color.White
        Me.btnImprimirListado.Location = New System.Drawing.Point(920, 52)
        Me.btnImprimirListado.Name = "btnImprimirListado"
        Me.btnImprimirListado.Size = New System.Drawing.Size(100, 38)
        Me.btnImprimirListado.TabIndex = 8
        Me.btnImprimirListado.Text = "Imprimir"
        Me.btnImprimirListado.UseVisualStyleBackColor = False
        '
        'btnVistaPreviaListado
        '
        Me.btnVistaPreviaListado.BackColor = System.Drawing.Color.FromArgb(CType(232, Byte), CType(237, Byte), CType(240, Byte))
        Me.btnVistaPreviaListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVistaPreviaListado.FlatAppearance.BorderSize = 0
        Me.btnVistaPreviaListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVistaPreviaListado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVistaPreviaListado.ForeColor = System.Drawing.Color.FromArgb(CType(55, Byte), CType(71, Byte), CType(79, Byte))
        Me.btnVistaPreviaListado.Location = New System.Drawing.Point(800, 52)
        Me.btnVistaPreviaListado.Name = "btnVistaPreviaListado"
        Me.btnVistaPreviaListado.Size = New System.Drawing.Size(110, 38)
        Me.btnVistaPreviaListado.TabIndex = 7
        Me.btnVistaPreviaListado.Text = "Vista previa"
        Me.btnVistaPreviaListado.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(232, Byte), CType(237, Byte), CType(240, Byte))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(55, Byte), CType(71, Byte), CType(79, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(690, 52)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(100, 38)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHorizontal.ForeColor = System.Drawing.Color.FromArgb(CType(38, Byte), CType(50, Byte), CType(56, Byte))
        Me.chkHorizontal.Location = New System.Drawing.Point(470, 60)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(184, 24)
        Me.chkHorizontal.TabIndex = 5
        Me.chkHorizontal.Text = "Orientación horizontal"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'nudDiasAdelante
        '
        Me.nudDiasAdelante.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDiasAdelante.Location = New System.Drawing.Point(365, 58)
        Me.nudDiasAdelante.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudDiasAdelante.Name = "nudDiasAdelante"
        Me.nudDiasAdelante.Size = New System.Drawing.Size(70, 29)
        Me.nudDiasAdelante.TabIndex = 4
        Me.nudDiasAdelante.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblDiasAdelante
        '
        Me.lblDiasAdelante.AutoSize = True
        Me.lblDiasAdelante.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasAdelante.ForeColor = System.Drawing.Color.FromArgb(CType(38, Byte), CType(50, Byte), CType(56, Byte))
        Me.lblDiasAdelante.Location = New System.Drawing.Point(230, 62)
        Me.lblDiasAdelante.Name = "lblDiasAdelante"
        Me.lblDiasAdelante.Size = New System.Drawing.Size(131, 20)
        Me.lblDiasAdelante.TabIndex = 3
        Me.lblDiasAdelante.Text = "Días hacia adelante:"
        '
        'nudDiasAtras
        '
        Me.nudDiasAtras.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDiasAtras.Location = New System.Drawing.Point(140, 58)
        Me.nudDiasAtras.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudDiasAtras.Name = "nudDiasAtras"
        Me.nudDiasAtras.Size = New System.Drawing.Size(70, 29)
        Me.nudDiasAtras.TabIndex = 2
        '
        'lblDiasAtras
        '
        Me.lblDiasAtras.AutoSize = True
        Me.lblDiasAtras.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasAtras.ForeColor = System.Drawing.Color.FromArgb(CType(38, Byte), CType(50, Byte), CType(56, Byte))
        Me.lblDiasAtras.Location = New System.Drawing.Point(24, 62)
        Me.lblDiasAtras.Name = "lblDiasAtras"
        Me.lblDiasAtras.Size = New System.Drawing.Size(108, 20)
        Me.lblDiasAtras.TabIndex = 1
        Me.lblDiasAtras.Text = "Días hacia atrás:"
        '
        'lblTituloListado
        '
        Me.lblTituloListado.AutoSize = True
        Me.lblTituloListado.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloListado.ForeColor = System.Drawing.Color.FromArgb(CType(38, Byte), CType(50, Byte), CType(56, Byte))
        Me.lblTituloListado.Location = New System.Drawing.Point(20, 12)
        Me.lblTituloListado.Name = "lblTituloListado"
        Me.lblTituloListado.Size = New System.Drawing.Size(297, 37)
        Me.lblTituloListado.TabIndex = 0
        Me.lblTituloListado.Text = "Listado de vencimientos"
        '
        'dgvVencimientos
        '
        Me.dgvVencimientos.AllowUserToAddRows = False
        Me.dgvVencimientos.AllowUserToDeleteRows = False
        Me.dgvVencimientos.AllowUserToResizeRows = False
        Me.dgvVencimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVencimientos.AutoGenerateColumns = False
        Me.dgvVencimientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvVencimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvVencimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(44, Byte), CType(62, Byte), CType(80, Byte))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(44, Byte), CType(62, Byte), CType(80, Byte))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True
        Me.dgvVencimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVencimientos.ColumnHeadersHeight = 36
        Me.dgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVencimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCedula, Me.colSocio, Me.colTelefono, Me.colTipo, Me.colVencimiento, Me.colDias, Me.colEstado})
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(38, Byte), CType(50, Byte), CType(56, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(226, Byte), CType(238, Byte))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(38, Byte), CType(50, Byte), CType(56, Byte))
        Me.dgvVencimientos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVencimientos.EnableHeadersVisualStyles = False
        Me.dgvVencimientos.GridColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(230, Byte), CType(234, Byte))
        Me.dgvVencimientos.Location = New System.Drawing.Point(24, 140)
        Me.dgvVencimientos.MultiSelect = False
        Me.dgvVencimientos.Name = "dgvVencimientos"
        Me.dgvVencimientos.ReadOnly = True
        Me.dgvVencimientos.RowHeadersVisible = False
        Me.dgvVencimientos.RowTemplate.Height = 28
        Me.dgvVencimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVencimientos.Size = New System.Drawing.Size(1112, 500)
        Me.dgvVencimientos.TabIndex = 1
        '
        'colCedula
        '
        Me.colCedula.DataPropertyName = "cedula"
        Me.colCedula.HeaderText = "Cédula"
        Me.colCedula.Name = "colCedula"
        Me.colCedula.ReadOnly = True
        Me.colCedula.Width = 120
        '
        'colSocio
        '
        Me.colSocio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSocio.DataPropertyName = "Socio"
        Me.colSocio.HeaderText = "Socio"
        Me.colSocio.Name = "colSocio"
        Me.colSocio.ReadOnly = True
        '
        'colTelefono
        '
        Me.colTelefono.DataPropertyName = "Telefono"
        Me.colTelefono.HeaderText = "Teléfono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.ReadOnly = True
        Me.colTelefono.Width = 110
        '
        'colTipo
        '
        Me.colTipo.DataPropertyName = "Tipo"
        Me.colTipo.HeaderText = "Membresía"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.ReadOnly = True
        Me.colTipo.Width = 170
        '
        'colVencimiento
        '
        Me.colVencimiento.DataPropertyName = "Vencimiento"
        Me.colVencimiento.HeaderText = "Vence"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.ReadOnly = True
        Me.colVencimiento.Width = 100
        '
        'colDias
        '
        Me.colDias.DataPropertyName = "Dias"
        Me.colDias.HeaderText = "Días"
        Me.colDias.Name = "colDias"
        Me.colDias.ReadOnly = True
        Me.colDias.Width = 70
        '
        'colEstado
        '
        Me.colEstado.DataPropertyName = "Estado"
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.Width = 100
        '
        'stsEstadoListado
        '
        Me.stsEstadoListado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblResumenListado})
        Me.stsEstadoListado.Location = New System.Drawing.Point(0, 678)
        Me.stsEstadoListado.Name = "stsEstadoListado"
        Me.stsEstadoListado.Size = New System.Drawing.Size(1160, 22)
        Me.stsEstadoListado.TabIndex = 2
        '
        'lblResumenListado
        '
        Me.lblResumenListado.Name = "lblResumenListado"
        Me.lblResumenListado.Size = New System.Drawing.Size(1145, 17)
        Me.lblResumenListado.Spring = True
        Me.lblResumenListado.Text = "Listo"
        Me.lblResumenListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmListadoVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(244, Byte), CType(246, Byte), CType(248, Byte))
        Me.ClientSize = New System.Drawing.Size(1160, 700)
        Me.Controls.Add(Me.stsEstadoListado)
        Me.Controls.Add(Me.dgvVencimientos)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frmListadoVencimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GymControl - Listado de vencimientos"
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        CType(Me.nudDiasAdelante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiasAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVencimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsEstadoListado.ResumeLayout(False)
        Me.stsEstadoListado.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblTituloListado As System.Windows.Forms.Label
    Friend WithEvents lblDiasAtras As System.Windows.Forms.Label
    Friend WithEvents nudDiasAtras As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDiasAdelante As System.Windows.Forms.Label
    Friend WithEvents nudDiasAdelante As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkHorizontal As System.Windows.Forms.CheckBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnVistaPreviaListado As System.Windows.Forms.Button
    Friend WithEvents btnImprimirListado As System.Windows.Forms.Button
    Friend WithEvents btnCerrarListado As System.Windows.Forms.Button
    Friend WithEvents dgvVencimientos As System.Windows.Forms.DataGridView
    Friend WithEvents colCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSocio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stsEstadoListado As System.Windows.Forms.StatusStrip
    Friend WithEvents lblResumenListado As System.Windows.Forms.ToolStripStatusLabel
End Class
