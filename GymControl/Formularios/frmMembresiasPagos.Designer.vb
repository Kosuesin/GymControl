<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMembresiasPagos
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
        txtCedula = New TextBox()
        btnBuscarTodo = New Button()
        grpMembresia = New GroupBox()
        btnCancelarMembresia = New Button()
        btnSuspenderMembresia = New Button()
        btnRenovarMembresia = New Button()
        btnRegistrarMembresia = New Button()
        cboEstadoMembresia = New ComboBox()
        txtDuracionDias = New TextBox()
        txtPrecioPactado = New TextBox()
        lblPrecio = New Label()
        dtpFechaVencimiento = New DateTimePicker()
        lblDuracion = New Label()
        dtpFechaInicio = New DateTimePicker()
        lblEstado = New Label()
        lblFechaVencimiento = New Label()
        lblFechaInicio = New Label()
        cboTipoMembresia = New ComboBox()
        lblTipoMembresia = New Label()
        dgvMembresias = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        grpRegistrarPago = New GroupBox()
        btnImprimirRecibo = New Button()
        btnAnularPago = New Button()
        btnRegistrarPago = New Button()
        cboMetodoPago = New ComboBox()
        lblMetodo = New Label()
        txtObservacion = New TextBox()
        txtReferencia = New TextBox()
        txtMonto = New TextBox()
        lblObservacion = New Label()
        lblReferencia = New Label()
        lblMonto = New Label()
        pnlVigencia = New Panel()
        lblValorVigencia = New Label()
        lblTituloVigencia = New Label()
        pnlDetallePago = New Panel()
        lblEstadoPago = New Label()
        lblTituloDetallePago = New Label()
        pnlSocioInfo = New Panel()
        lblValorTotal = New Label()
        lblTotalPago = New Label()
        cboMembresia = New ComboBox()
        lblMembresia = New Label()
        dgvPagos = New DataGridView()
        lblSocio = New Label()
        stsEstado = New StatusStrip()
        TableLayoutPanel1 = New TableLayoutPanel()
        tslEstado = New ToolStripStatusLabel()
        tslMembresia = New ToolStripStatusLabel()
        tslSaldoPendiente = New ToolStripStatusLabel()
        tslUltimoPago = New ToolStripStatusLabel()
        tslUsuario = New ToolStripStatusLabel()

        grpMembresia.SuspendLayout()
        CType(dgvMembresias, ComponentModel.ISupportInitialize).BeginInit()
        grpRegistrarPago.SuspendLayout()
        pnlVigencia.SuspendLayout()
        pnlDetallePago.SuspendLayout()
        pnlSocioInfo.SuspendLayout()
        CType(dgvPagos, ComponentModel.ISupportInitialize).BeginInit()
        stsEstado.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(74, 12)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(219, 27)
        txtCedula.TabIndex = 0
        ' 
        ' btnBuscarTodo
        ' 
        btnBuscarTodo.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscarTodo.Location = New Point(309, 8)
        btnBuscarTodo.Name = "btnBuscarTodo"
        btnBuscarTodo.Size = New Size(117, 36)
        btnBuscarTodo.TabIndex = 1
        btnBuscarTodo.Text = "Buscar Todo"
        btnBuscarTodo.UseVisualStyleBackColor = True
        ' 
        ' grpMembresia
        ' 
        grpMembresia.AutoSize = True
        grpMembresia.Controls.Add(btnCancelarMembresia)
        grpMembresia.Controls.Add(btnSuspenderMembresia)
        grpMembresia.Controls.Add(btnRenovarMembresia)
        grpMembresia.Controls.Add(btnRegistrarMembresia)
        grpMembresia.Controls.Add(cboEstadoMembresia)
        grpMembresia.Controls.Add(txtDuracionDias)
        grpMembresia.Controls.Add(txtPrecioPactado)
        grpMembresia.Controls.Add(lblPrecio)
        grpMembresia.Controls.Add(dtpFechaVencimiento)
        grpMembresia.Controls.Add(lblDuracion)
        grpMembresia.Controls.Add(dtpFechaInicio)
        grpMembresia.Controls.Add(lblEstado)
        grpMembresia.Controls.Add(lblFechaVencimiento)
        grpMembresia.Controls.Add(lblFechaInicio)
        grpMembresia.Controls.Add(cboTipoMembresia)
        grpMembresia.Controls.Add(lblTipoMembresia)
        grpMembresia.Dock = DockStyle.Fill
        grpMembresia.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpMembresia.Location = New Point(3, 3)
        grpMembresia.Name = "grpMembresia"
        grpMembresia.Size = New Size(565, 378)
        grpMembresia.TabIndex = 2
        grpMembresia.TabStop = False
        grpMembresia.Text = "Membresia"
        ' 
        ' btnCancelarMembresia
        ' 
        btnCancelarMembresia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancelarMembresia.Location = New Point(418, 308)
        btnCancelarMembresia.Name = "btnCancelarMembresia"
        btnCancelarMembresia.Size = New Size(121, 43)
        btnCancelarMembresia.TabIndex = 15
        btnCancelarMembresia.Text = "Cancelar"
        btnCancelarMembresia.UseVisualStyleBackColor = True
        ' 
        ' btnSuspenderMembresia
        ' 
        btnSuspenderMembresia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSuspenderMembresia.Location = New Point(291, 308)
        btnSuspenderMembresia.Name = "btnSuspenderMembresia"
        btnSuspenderMembresia.Size = New Size(121, 43)
        btnSuspenderMembresia.TabIndex = 14
        btnSuspenderMembresia.Text = "Suspender"
        btnSuspenderMembresia.UseVisualStyleBackColor = True
        ' 
        ' btnRenovarMembresia
        ' 
        btnRenovarMembresia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRenovarMembresia.Location = New Point(164, 308)
        btnRenovarMembresia.Name = "btnRenovarMembresia"
        btnRenovarMembresia.Size = New Size(121, 43)
        btnRenovarMembresia.TabIndex = 13
        btnRenovarMembresia.Text = "Renovar"
        btnRenovarMembresia.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarMembresia
        ' 
        btnRegistrarMembresia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRegistrarMembresia.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegistrarMembresia.Location = New Point(38, 308)
        btnRegistrarMembresia.Name = "btnRegistrarMembresia"
        btnRegistrarMembresia.Size = New Size(121, 43)
        btnRegistrarMembresia.TabIndex = 12
        btnRegistrarMembresia.Text = "Registrar"
        btnRegistrarMembresia.UseVisualStyleBackColor = True
        ' 
        ' cboEstadoMembresia
        ' 
        cboEstadoMembresia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboEstadoMembresia.FormattingEnabled = True
        cboEstadoMembresia.Location = New Point(168, 197)
        cboEstadoMembresia.Name = "cboEstadoMembresia"
        cboEstadoMembresia.Size = New Size(166, 31)
        cboEstadoMembresia.TabIndex = 11
        ' 
        ' txtDuracionDias
        ' 
        txtDuracionDias.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDuracionDias.Location = New Point(418, 139)
        txtDuracionDias.Name = "txtDuracionDias"
        txtDuracionDias.ReadOnly = True
        txtDuracionDias.Size = New Size(141, 30)
        txtDuracionDias.TabIndex = 10
        ' 
        ' txtPrecioPactado
        ' 
        txtPrecioPactado.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrecioPactado.Location = New Point(418, 85)
        txtPrecioPactado.Name = "txtPrecioPactado"
        txtPrecioPactado.ReadOnly = True
        txtPrecioPactado.Size = New Size(141, 30)
        txtPrecioPactado.TabIndex = 9
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(340, 146)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(86, 23)
        lblPrecio.TabIndex = 8
        lblPrecio.Text = "Precio C$:"
        ' 
        ' dtpFechaVencimiento
        ' 
        dtpFechaVencimiento.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaVencimiento.Location = New Point(168, 139)
        dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        dtpFechaVencimiento.Size = New Size(166, 30)
        dtpFechaVencimiento.TabIndex = 7
        ' 
        ' lblDuracion
        ' 
        lblDuracion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDuracion.AutoSize = True
        lblDuracion.Location = New Point(340, 92)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(83, 23)
        lblDuracion.TabIndex = 6
        lblDuracion.Text = "Duracion:"
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaInicio.Location = New Point(168, 85)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(166, 30)
        dtpFechaInicio.TabIndex = 5
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(12, 205)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(65, 23)
        lblEstado.TabIndex = 3
        lblEstado.Text = "Estado:"
        ' 
        ' lblFechaVencimiento
        ' 
        lblFechaVencimiento.AutoSize = True
        lblFechaVencimiento.Location = New Point(12, 146)
        lblFechaVencimiento.Name = "lblFechaVencimiento"
        lblFechaVencimiento.Size = New Size(158, 23)
        lblFechaVencimiento.TabIndex = 2
        lblFechaVencimiento.Text = "Fecha Vencimiento:"
        ' 
        ' lblFechaInicio
        ' 
        lblFechaInicio.AutoSize = True
        lblFechaInicio.Location = New Point(12, 92)
        lblFechaInicio.Name = "lblFechaInicio"
        lblFechaInicio.Size = New Size(103, 23)
        lblFechaInicio.TabIndex = 1
        lblFechaInicio.Text = "Fecha inicio:"
        ' 
        ' cboTipoMembresia
        ' 
        cboTipoMembresia.FormattingEnabled = True
        cboTipoMembresia.Location = New Point(168, 26)
        cboTipoMembresia.Name = "cboTipoMembresia"
        cboTipoMembresia.Size = New Size(391, 31)
        cboTipoMembresia.TabIndex = 4
        ' 
        ' lblTipoMembresia
        ' 
        lblTipoMembresia.AutoSize = True
        lblTipoMembresia.Location = New Point(12, 34)
        lblTipoMembresia.Name = "lblTipoMembresia"
        lblTipoMembresia.Size = New Size(160, 23)
        lblTipoMembresia.TabIndex = 0
        lblTipoMembresia.Text = "Tipo de membresia:"
        ' 
        ' dgvMembresias
        ' 
        dgvMembresias.AllowUserToAddRows = False
        dgvMembresias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembresias.Dock = DockStyle.Fill
        dgvMembresias.Location = New Point(3, 387)
        dgvMembresias.MultiSelect = False
        dgvMembresias.Name = "dgvMembresias"
        dgvMembresias.ReadOnly = True
        dgvMembresias.RowHeadersWidth = 51
        dgvMembresias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembresias.Size = New Size(565, 378)
        dgvMembresias.TabIndex = 3
        ' 
        ' grpRegistrarPago
        ' 
        grpRegistrarPago.AutoSize = True
        grpRegistrarPago.Controls.Add(btnImprimirRecibo)
        grpRegistrarPago.Controls.Add(btnAnularPago)
        grpRegistrarPago.Controls.Add(btnRegistrarPago)
        grpRegistrarPago.Controls.Add(cboMetodoPago)
        grpRegistrarPago.Controls.Add(lblMetodo)
        grpRegistrarPago.Controls.Add(txtObservacion)
        grpRegistrarPago.Controls.Add(txtReferencia)
        grpRegistrarPago.Controls.Add(txtMonto)
        grpRegistrarPago.Controls.Add(lblObservacion)
        grpRegistrarPago.Controls.Add(lblReferencia)
        grpRegistrarPago.Controls.Add(lblMonto)
        grpRegistrarPago.Controls.Add(pnlVigencia)
        grpRegistrarPago.Controls.Add(pnlDetallePago)
        grpRegistrarPago.Controls.Add(pnlSocioInfo)
        grpRegistrarPago.Controls.Add(cboMembresia)
        grpRegistrarPago.Controls.Add(lblMembresia)
        grpRegistrarPago.Dock = DockStyle.Fill
        grpRegistrarPago.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpRegistrarPago.Location = New Point(574, 3)
        grpRegistrarPago.Name = "grpRegistrarPago"
        grpRegistrarPago.Size = New Size(566, 378)
        grpRegistrarPago.TabIndex = 4
        grpRegistrarPago.TabStop = False
        grpRegistrarPago.Text = "Registrar Pago"
        ' 
        ' btnImprimirRecibo
        ' 
        btnImprimirRecibo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnImprimirRecibo.FlatStyle = FlatStyle.Flat
        btnImprimirRecibo.Location = New Point(397, 323)
        btnImprimirRecibo.Name = "btnImprimirRecibo"
        btnImprimirRecibo.Size = New Size(160, 43)
        btnImprimirRecibo.TabIndex = 18
        btnImprimirRecibo.Text = "Imprimir recibo"
        btnImprimirRecibo.UseVisualStyleBackColor = True
        ' 
        ' btnAnularPago
        ' 
        btnAnularPago.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAnularPago.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(51))
        btnAnularPago.ForeColor = SystemColors.ButtonHighlight
        btnAnularPago.Location = New Point(201, 323)
        btnAnularPago.Name = "btnAnularPago"
        btnAnularPago.Size = New Size(160, 43)
        btnAnularPago.TabIndex = 17
        btnAnularPago.Text = "Anular Pago"
        btnAnularPago.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarPago
        ' 
        btnRegistrarPago.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRegistrarPago.BackColor = SystemColors.HotTrack
        btnRegistrarPago.ForeColor = SystemColors.ButtonHighlight
        btnRegistrarPago.Location = New Point(12, 323)
        btnRegistrarPago.Name = "btnRegistrarPago"
        btnRegistrarPago.Size = New Size(160, 43)
        btnRegistrarPago.TabIndex = 16
        btnRegistrarPago.Text = "Registrar Pago"
        btnRegistrarPago.UseVisualStyleBackColor = False
        ' 
        ' cboMetodoPago
        ' 
        cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList
        cboMetodoPago.FormattingEnabled = True
        cboMetodoPago.Location = New Point(381, 159)
        cboMetodoPago.Name = "cboMetodoPago"
        cboMetodoPago.Size = New Size(176, 31)
        cboMetodoPago.TabIndex = 11
        ' 
        ' lblMetodo
        ' 
        lblMetodo.AutoSize = True
        lblMetodo.Location = New Point(305, 164)
        lblMetodo.Name = "lblMetodo"
        lblMetodo.Size = New Size(74, 23)
        lblMetodo.TabIndex = 10
        lblMetodo.Text = "Metodo:"
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(119, 277)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(442, 30)
        txtObservacion.TabIndex = 9
        ' 
        ' txtReferencia
        ' 
        txtReferencia.Location = New Point(119, 217)
        txtReferencia.Name = "txtReferencia"
        txtReferencia.Size = New Size(442, 30)
        txtReferencia.TabIndex = 8
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(119, 160)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(180, 30)
        txtMonto.TabIndex = 7
        ' 
        ' lblObservacion
        ' 
        lblObservacion.AutoSize = True
        lblObservacion.Location = New Point(9, 284)
        lblObservacion.Name = "lblObservacion"
        lblObservacion.Size = New Size(108, 23)
        lblObservacion.TabIndex = 6
        lblObservacion.Text = "Observacion:"
        ' 
        ' lblReferencia
        ' 
        lblReferencia.AutoSize = True
        lblReferencia.Location = New Point(9, 224)
        lblReferencia.Name = "lblReferencia"
        lblReferencia.Size = New Size(93, 23)
        lblReferencia.TabIndex = 5
        lblReferencia.Text = "Referencia:"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(9, 167)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(90, 23)
        lblMonto.TabIndex = 4
        lblMonto.Text = "Monto C$:"
        ' 
        ' pnlVigencia
        ' 
        pnlVigencia.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlVigencia.BorderStyle = BorderStyle.FixedSingle
        pnlVigencia.Controls.Add(lblValorVigencia)
        pnlVigencia.Controls.Add(lblTituloVigencia)
        pnlVigencia.ForeColor = Color.Red
        pnlVigencia.Location = New Point(380, 85)
        pnlVigencia.Margin = New Padding(3, 3, 3, 20)
        pnlVigencia.Name = "pnlVigencia"
        pnlVigencia.Size = New Size(181, 65)
        pnlVigencia.TabIndex = 3
        ' 
        ' lblValorVigencia
        ' 
        lblValorVigencia.AutoSize = True
        lblValorVigencia.Location = New Point(55, 27)
        lblValorVigencia.Name = "lblValorVigencia"
        lblValorVigencia.Size = New Size(107, 23)
        lblValorVigencia.TabIndex = 7
        lblValorVigencia.Text = "Modificable3"
        ' 
        ' lblTituloVigencia
        ' 
        lblTituloVigencia.AutoSize = True
        lblTituloVigencia.Location = New Point(3, 0)
        lblTituloVigencia.Name = "lblTituloVigencia"
        lblTituloVigencia.Size = New Size(52, 23)
        lblTituloVigencia.TabIndex = 6
        lblTituloVigencia.Text = "Saldo"
        ' 
        ' pnlDetallePago
        ' 
        pnlDetallePago.Anchor = AnchorStyles.Top
        pnlDetallePago.BorderStyle = BorderStyle.FixedSingle
        pnlDetallePago.Controls.Add(lblEstadoPago)
        pnlDetallePago.Controls.Add(lblTituloDetallePago)
        pnlDetallePago.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        pnlDetallePago.Location = New Point(194, 85)
        pnlDetallePago.Name = "pnlDetallePago"
        pnlDetallePago.Size = New Size(181, 65)
        pnlDetallePago.TabIndex = 3
        ' 
        ' lblEstadoPago
        ' 
        lblEstadoPago.AutoSize = True
        lblEstadoPago.Location = New Point(59, 24)
        lblEstadoPago.Name = "lblEstadoPago"
        lblEstadoPago.Size = New Size(107, 23)
        lblEstadoPago.TabIndex = 8
        lblEstadoPago.Text = "Modificable2"
        ' 
        ' lblTituloDetallePago
        ' 
        lblTituloDetallePago.AutoSize = True
        lblTituloDetallePago.Location = New Point(3, 0)
        lblTituloDetallePago.Name = "lblTituloDetallePago"
        lblTituloDetallePago.Size = New Size(67, 23)
        lblTituloDetallePago.TabIndex = 5
        lblTituloDetallePago.Text = "Pagado"
        ' 
        ' pnlSocioInfo
        ' 
        pnlSocioInfo.BorderStyle = BorderStyle.FixedSingle
        pnlSocioInfo.Controls.Add(lblValorTotal)
        pnlSocioInfo.Controls.Add(lblTotalPago)
        pnlSocioInfo.Location = New Point(7, 85)
        pnlSocioInfo.Margin = New Padding(20, 3, 3, 3)
        pnlSocioInfo.Name = "pnlSocioInfo"
        pnlSocioInfo.Size = New Size(181, 65)
        pnlSocioInfo.TabIndex = 2
        ' 
        ' lblValorTotal
        ' 
        lblValorTotal.AutoSize = True
        lblValorTotal.Location = New Point(61, 27)
        lblValorTotal.Name = "lblValorTotal"
        lblValorTotal.Size = New Size(103, 23)
        lblValorTotal.TabIndex = 4
        lblValorTotal.Text = "Modifcable1"
        ' 
        ' lblTotalPago
        ' 
        lblTotalPago.AutoSize = True
        lblTotalPago.Location = New Point(3, 0)
        lblTotalPago.Name = "lblTotalPago"
        lblTotalPago.Size = New Size(46, 23)
        lblTotalPago.TabIndex = 4
        lblTotalPago.Text = "Total"
        ' 
        ' cboMembresia
        ' 
        cboMembresia.DropDownStyle = ComboBoxStyle.DropDownList
        cboMembresia.FormattingEnabled = True
        cboMembresia.Location = New Point(131, 26)
        cboMembresia.Name = "cboMembresia"
        cboMembresia.Size = New Size(430, 31)
        cboMembresia.TabIndex = 1
        ' 
        ' lblMembresia
        ' 
        lblMembresia.AutoSize = True
        lblMembresia.Location = New Point(6, 34)
        lblMembresia.Name = "lblMembresia"
        lblMembresia.Size = New Size(94, 23)
        lblMembresia.TabIndex = 0
        lblMembresia.Text = "Membresia"
        ' 
        ' dgvPagos
        ' 
        dgvPagos.AllowUserToAddRows = False
        dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPagos.Dock = DockStyle.Fill
        dgvPagos.Location = New Point(574, 387)
        dgvPagos.MultiSelect = False
        dgvPagos.Name = "dgvPagos"
        dgvPagos.ReadOnly = True
        dgvPagos.RowHeadersWidth = 51
        dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPagos.Size = New Size(566, 378)
        dgvPagos.TabIndex = 5
        ' 
        ' lblSocio
        ' 
        lblSocio.AutoSize = True
        lblSocio.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSocio.Location = New Point(12, 16)
        lblSocio.Name = "lblSocio"
        lblSocio.Size = New Size(55, 23)
        lblSocio.TabIndex = 6
        lblSocio.Text = "Socio:"
        ' 
        ' stsEstado
        ' 
        stsEstado.ImageScalingSize = New Size(20, 20)
        stsEstado.Items.AddRange(New ToolStripItem() {tslEstado, tslMembresia, tslSaldoPendiente, tslUltimoPago, tslUsuario})
        stsEstado.Location = New Point(0, 814)
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(1143, 26)
        stsEstado.TabIndex = 7
        stsEstado.Text = "StatusStrip1"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(grpRegistrarPago, 1, 0)
        TableLayoutPanel1.Controls.Add(dgvPagos, 1, 1)
        TableLayoutPanel1.Controls.Add(dgvMembresias, 0, 1)
        TableLayoutPanel1.Controls.Add(grpMembresia, 0, 0)
        TableLayoutPanel1.Location = New Point(0, 47)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(1143, 768)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' tslEstado
        ' 
        tslEstado.Name = "tslEstado"
        tslEstado.Size = New Size(27, 20)
        tslEstado.Text = "ID:"
        ' 
        ' tslMembresia
        ' 
        tslMembresia.Name = "tslMembresia"
        tslMembresia.Size = New Size(86, 20)
        tslMembresia.Text = "Membresia:"
        ' 
        ' tslSaldoPendiente
        ' 
        tslSaldoPendiente.Name = "tslSaldoPendiente"
        tslSaldoPendiente.Size = New Size(119, 20)
        tslSaldoPendiente.Text = "Saldo Pendiente:"
        ' 
        ' tslUsuario
        ' 
        tslUsuario.Name = "tslUsuario"
        tslUsuario.Size = New Size(62, 20)
        tslUsuario.Text = "Usuario:"
        ' 
        ' frmMembresiasPagos
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 840)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(stsEstado)
        Controls.Add(lblSocio)
        Controls.Add(btnBuscarTodo)
        Controls.Add(txtCedula)
        MinimumSize = New Size(1159, 743)
        Name = "frmMembresiasPagos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMembresiasPagos"
        grpMembresia.ResumeLayout(False)
        grpMembresia.PerformLayout()
        CType(dgvMembresias, ComponentModel.ISupportInitialize).EndInit()
        grpRegistrarPago.ResumeLayout(False)
        grpRegistrarPago.PerformLayout()
        pnlVigencia.ResumeLayout(False)
        pnlVigencia.PerformLayout()
        pnlDetallePago.ResumeLayout(False)
        pnlDetallePago.PerformLayout()
        pnlSocioInfo.ResumeLayout(False)
        pnlSocioInfo.PerformLayout()
        CType(dgvPagos, ComponentModel.ISupportInitialize).EndInit()
        stsEstado.ResumeLayout(False)
        stsEstado.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnBuscarTodo As Button
    Friend WithEvents grpMembresia As GroupBox
    Friend WithEvents dgvMembresias As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents grpRegistrarPago As GroupBox
    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents lblSocio As Label
    Friend WithEvents stsEstado As StatusStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblFechaVencimiento As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblTipoMembresia As Label
    Friend WithEvents dtpFechaVencimiento As DateTimePicker
    Friend WithEvents lblDuracion As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents cboTipoMembresia As ComboBox
    Friend WithEvents txtDuracionDias As TextBox
    Friend WithEvents txtPrecioPactado As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents cboEstadoMembresia As ComboBox
    Friend WithEvents btnCancelarMembresia As Button
    Friend WithEvents btnSuspenderMembresia As Button
    Friend WithEvents btnRenovarMembresia As Button
    Friend WithEvents btnRegistrarMembresia As Button
    Friend WithEvents lblMembresia As Label
    Friend WithEvents pnlVigencia As Panel
    Friend WithEvents pnlDetallePago As Panel
    Friend WithEvents pnlSocioInfo As Panel
    Friend WithEvents cboMembresia As ComboBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblObservacion As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblValorVigencia As Label
    Friend WithEvents lblTituloVigencia As Label
    Friend WithEvents lblEstadoPago As Label
    Friend WithEvents lblFechaPago As Label
    Friend WithEvents lblTituloDetallePago As Label
    Friend WithEvents lblNombreSocio As Label
    Friend WithEvents lblCedulaSocio As Label
    Friend WithEvents lblTotalPago As Label
    Friend WithEvents lblValorTotal As Label
    Friend WithEvents lblPagado As Label
    Friend WithEvents lblMetodo As Label
    Friend WithEvents btnImprimirRecibo As Button
    Friend WithEvents btnAnularPago As Button
    Friend WithEvents btnRegistrarPago As Button
    Friend WithEvents cboMetodoPago As ComboBox
    Friend WithEvents tslEstado As ToolStripStatusLabel
    Friend WithEvents tslMembresia As ToolStripStatusLabel
    Friend WithEvents tslSaldoPendiente As ToolStripStatusLabel
    Friend WithEvents tslUltimoPago As ToolStripStatusLabel
    Friend WithEvents tslUsuario As ToolStripStatusLabel
End Class