<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembresiasPagos
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
        txtCedula = New TextBox()
        btnBuscarSocio = New Button()
        lblSocio = New Label()
        grpMembresia = New GroupBox()
        lblTipoMembresia = New Label()
        cboTipoMembresia = New ComboBox()
        lblFechaInicio = New Label()
        DateTimePicker1 = New DateTimePicker()
        lblDuracion = New Label()
        txtDuracion = New TextBox()
        lblFechaVencimiento = New Label()
        dtpFechccaVencimiento = New DateTimePicker()
        lblPrecio = New Label()
        txtPrecio = New TextBox()
        lblEstado = New Label()
        cboEstado = New ComboBox()
        btnRegistrar = New Button()
        btnRenovar = New Button()
        btnSuspender = New Button()
        btnCacelar = New Button()
        dgvMembresias = New DataGridView()
        lblHistorialMembresias = New Label()
        grpPago = New GroupBox()
        lblMembresiaPago = New Label()
        cboMembresiaPago = New ComboBox()
        lblTotalTitulo = New Label()
        lblPagadoTitulo = New Label()
        lblSaldoTitulo = New Label()
        lblMonto = New Label()
        txtMonto = New TextBox()
        lblMetodo = New Label()
        cboMetodo = New ComboBox()
        lblTotal = New Label()
        lblPagado = New Label()
        lblSaldo = New Label()
        lblReferencia = New Label()
        txtReferencia = New TextBox()
        lblObservacion = New Label()
        txtObservacion = New TextBox()
        btnRegistrarPago = New Button()
        btnAnularPago = New Button()
        btnImprimirRecibo = New Button()
        lblPagosMembresia = New Label()
        dgvPagos = New DataGridView()
        colFechaPago = New DataGridViewTextBoxColumn()
        colMonto = New DataGridViewTextBoxColumn()
        colMetodo = New DataGridViewTextBoxColumn()
        colRegistradoPor = New DataGridViewTextBoxColumn()
        colEstadoPago = New DataGridViewTextBoxColumn()
        stsEstado = New StatusStrip()
        lblEstadoSocio = New ToolStripStatusLabel()
        lblMembresiasActiva = New ToolStripStatusLabel()
        lblSaldoPendiente = New ToolStripStatusLabel()
        lblUsuarioActual = New ToolStripStatusLabel()
        grpMembresia.SuspendLayout()
        CType(dgvMembresias, ComponentModel.ISupportInitialize).BeginInit()
        grpPago.SuspendLayout()
        CType(dgvPagos, ComponentModel.ISupportInitialize).BeginInit()
        stsEstado.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(76, 31)
        txtCedula.Name = "txtCedula"
        txtCedula.PlaceholderText = "Cédula del socio"
        txtCedula.Size = New Size(180, 23)
        txtCedula.TabIndex = 0
        ' 
        ' btnBuscarSocio
        ' 
        btnBuscarSocio.Location = New Point(262, 31)
        btnBuscarSocio.Name = "btnBuscarSocio"
        btnBuscarSocio.Size = New Size(110, 23)
        btnBuscarSocio.TabIndex = 1
        btnBuscarSocio.Text = "Buscar socio"
        btnBuscarSocio.UseVisualStyleBackColor = True
        ' 
        ' lblSocio
        ' 
        lblSocio.AutoSize = True
        lblSocio.Location = New Point(21, 35)
        lblSocio.Name = "lblSocio"
        lblSocio.Size = New Size(39, 15)
        lblSocio.TabIndex = 2
        lblSocio.Text = "Socio:"
        ' 
        ' grpMembresia
        ' 
        grpMembresia.Controls.Add(btnCacelar)
        grpMembresia.Controls.Add(btnSuspender)
        grpMembresia.Controls.Add(btnRenovar)
        grpMembresia.Controls.Add(btnRegistrar)
        grpMembresia.Controls.Add(cboEstado)
        grpMembresia.Controls.Add(lblEstado)
        grpMembresia.Controls.Add(txtPrecio)
        grpMembresia.Controls.Add(lblPrecio)
        grpMembresia.Controls.Add(dtpFechccaVencimiento)
        grpMembresia.Controls.Add(lblFechaVencimiento)
        grpMembresia.Controls.Add(txtDuracion)
        grpMembresia.Controls.Add(lblDuracion)
        grpMembresia.Controls.Add(DateTimePicker1)
        grpMembresia.Controls.Add(lblFechaInicio)
        grpMembresia.Controls.Add(cboTipoMembresia)
        grpMembresia.Controls.Add(lblTipoMembresia)
        grpMembresia.Location = New Point(21, 77)
        grpMembresia.Name = "grpMembresia"
        grpMembresia.Size = New Size(500, 280)
        grpMembresia.TabIndex = 3
        grpMembresia.TabStop = False
        grpMembresia.Text = "Membresía"
        ' 
        ' lblTipoMembresia
        ' 
        lblTipoMembresia.AutoSize = True
        lblTipoMembresia.Location = New Point(6, 29)
        lblTipoMembresia.Name = "lblTipoMembresia"
        lblTipoMembresia.Size = New Size(109, 15)
        lblTipoMembresia.TabIndex = 0
        lblTipoMembresia.Text = "Tipo de membresía"
        ' 
        ' cboTipoMembresia
        ' 
        cboTipoMembresia.FormattingEnabled = True
        cboTipoMembresia.Location = New Point(121, 26)
        cboTipoMembresia.Name = "cboTipoMembresia"
        cboTipoMembresia.Size = New Size(121, 23)
        cboTipoMembresia.TabIndex = 1
        ' 
        ' lblFechaInicio
        ' 
        lblFechaInicio.AutoSize = True
        lblFechaInicio.Location = New Point(6, 79)
        lblFechaInicio.Name = "lblFechaInicio"
        lblFechaInicio.Size = New Size(70, 15)
        lblFechaInicio.TabIndex = 2
        lblFechaInicio.Text = "Fecha inicio"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(82, 73)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' lblDuracion
        ' 
        lblDuracion.AutoSize = True
        lblDuracion.Location = New Point(310, 29)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(55, 15)
        lblDuracion.TabIndex = 4
        lblDuracion.Text = "Duración"
        ' 
        ' txtDuracion
        ' 
        txtDuracion.Location = New Point(371, 26)
        txtDuracion.Name = "txtDuracion"
        txtDuracion.Size = New Size(100, 23)
        txtDuracion.TabIndex = 5
        ' 
        ' lblFechaVencimiento
        ' 
        lblFechaVencimiento.AutoSize = True
        lblFechaVencimiento.Location = New Point(6, 132)
        lblFechaVencimiento.Name = "lblFechaVencimiento"
        lblFechaVencimiento.Size = New Size(107, 15)
        lblFechaVencimiento.TabIndex = 6
        lblFechaVencimiento.Text = "Fecha vencimiento"
        ' 
        ' dtpFechccaVencimiento
        ' 
        dtpFechccaVencimiento.Location = New Point(119, 126)
        dtpFechccaVencimiento.Name = "dtpFechccaVencimiento"
        dtpFechccaVencimiento.Size = New Size(200, 23)
        dtpFechccaVencimiento.TabIndex = 7
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(310, 79)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(57, 15)
        lblPrecio.TabIndex = 8
        lblPrecio.Text = "Precio C$"
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(373, 76)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 9
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(6, 165)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(42, 15)
        lblEstado.TabIndex = 10
        lblEstado.Text = "Estado"
        ' 
        ' cboEstado
        ' 
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(54, 162)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(121, 23)
        cboEstado.TabIndex = 11
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(6, 206)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(75, 23)
        btnRegistrar.TabIndex = 12
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnRenovar
        ' 
        btnRenovar.Location = New Point(100, 206)
        btnRenovar.Name = "btnRenovar"
        btnRenovar.Size = New Size(75, 23)
        btnRenovar.TabIndex = 13
        btnRenovar.Text = "Renovar"
        btnRenovar.UseVisualStyleBackColor = True
        ' 
        ' btnSuspender
        ' 
        btnSuspender.Location = New Point(207, 206)
        btnSuspender.Name = "btnSuspender"
        btnSuspender.Size = New Size(75, 23)
        btnSuspender.TabIndex = 14
        btnSuspender.Text = "Suspender"
        btnSuspender.UseVisualStyleBackColor = True
        ' 
        ' btnCacelar
        ' 
        btnCacelar.Location = New Point(310, 206)
        btnCacelar.Name = "btnCacelar"
        btnCacelar.Size = New Size(75, 23)
        btnCacelar.TabIndex = 15
        btnCacelar.Text = "Cancelar"
        btnCacelar.UseVisualStyleBackColor = True
        ' 
        ' dgvMembresias
        ' 
        dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembresias.Location = New Point(21, 399)
        dgvMembresias.Name = "dgvMembresias"
        dgvMembresias.Size = New Size(500, 150)
        dgvMembresias.TabIndex = 4
        ' 
        ' lblHistorialMembresias
        ' 
        lblHistorialMembresias.AutoSize = True
        lblHistorialMembresias.Location = New Point(21, 381)
        lblHistorialMembresias.Name = "lblHistorialMembresias"
        lblHistorialMembresias.Size = New Size(184, 15)
        lblHistorialMembresias.TabIndex = 5
        lblHistorialMembresias.Text = "Historial de membresías del socio"
        ' 
        ' grpPago
        ' 
        grpPago.Controls.Add(btnImprimirRecibo)
        grpPago.Controls.Add(btnAnularPago)
        grpPago.Controls.Add(btnRegistrarPago)
        grpPago.Controls.Add(txtObservacion)
        grpPago.Controls.Add(lblObservacion)
        grpPago.Controls.Add(txtReferencia)
        grpPago.Controls.Add(lblReferencia)
        grpPago.Controls.Add(lblSaldo)
        grpPago.Controls.Add(lblPagado)
        grpPago.Controls.Add(lblTotal)
        grpPago.Controls.Add(cboMetodo)
        grpPago.Controls.Add(lblMetodo)
        grpPago.Controls.Add(txtMonto)
        grpPago.Controls.Add(lblMonto)
        grpPago.Controls.Add(lblSaldoTitulo)
        grpPago.Controls.Add(lblPagadoTitulo)
        grpPago.Controls.Add(lblTotalTitulo)
        grpPago.Controls.Add(cboMembresiaPago)
        grpPago.Controls.Add(lblMembresiaPago)
        grpPago.Location = New Point(539, 77)
        grpPago.Name = "grpPago"
        grpPago.Size = New Size(470, 297)
        grpPago.TabIndex = 6
        grpPago.TabStop = False
        grpPago.Text = "Registrar pago"
        ' 
        ' lblMembresiaPago
        ' 
        lblMembresiaPago.AutoSize = True
        lblMembresiaPago.Location = New Point(6, 37)
        lblMembresiaPago.Name = "lblMembresiaPago"
        lblMembresiaPago.Size = New Size(66, 15)
        lblMembresiaPago.TabIndex = 0
        lblMembresiaPago.Text = "Membresía"
        ' 
        ' cboMembresiaPago
        ' 
        cboMembresiaPago.FormattingEnabled = True
        cboMembresiaPago.Location = New Point(78, 34)
        cboMembresiaPago.Name = "cboMembresiaPago"
        cboMembresiaPago.Size = New Size(121, 23)
        cboMembresiaPago.TabIndex = 1
        ' 
        ' lblTotalTitulo
        ' 
        lblTotalTitulo.AutoSize = True
        lblTotalTitulo.Location = New Point(24, 73)
        lblTotalTitulo.Name = "lblTotalTitulo"
        lblTotalTitulo.Size = New Size(33, 15)
        lblTotalTitulo.TabIndex = 2
        lblTotalTitulo.Text = "Total"
        ' 
        ' lblPagadoTitulo
        ' 
        lblPagadoTitulo.AutoSize = True
        lblPagadoTitulo.Location = New Point(125, 73)
        lblPagadoTitulo.Name = "lblPagadoTitulo"
        lblPagadoTitulo.Size = New Size(47, 15)
        lblPagadoTitulo.TabIndex = 3
        lblPagadoTitulo.Text = "Pagado"
        ' 
        ' lblSaldoTitulo
        ' 
        lblSaldoTitulo.AutoSize = True
        lblSaldoTitulo.Location = New Point(248, 73)
        lblSaldoTitulo.Name = "lblSaldoTitulo"
        lblSaldoTitulo.Size = New Size(36, 15)
        lblSaldoTitulo.TabIndex = 4
        lblSaldoTitulo.Text = "Saldo"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(24, 146)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(68, 15)
        lblMonto.TabIndex = 5
        lblMonto.Text = "Monto C$ *"
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(98, 143)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(100, 23)
        txtMonto.TabIndex = 6
        ' 
        ' lblMetodo
        ' 
        lblMetodo.AutoSize = True
        lblMetodo.Location = New Point(204, 146)
        lblMetodo.Name = "lblMetodo"
        lblMetodo.Size = New Size(57, 15)
        lblMetodo.TabIndex = 7
        lblMetodo.Text = "Método *"
        ' 
        ' cboMetodo
        ' 
        cboMetodo.FormattingEnabled = True
        cboMetodo.Location = New Point(267, 143)
        cboMetodo.Name = "cboMetodo"
        cboMetodo.Size = New Size(121, 23)
        cboMetodo.TabIndex = 8
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(24, 93)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(64, 21)
        lblTotal.TabIndex = 9
        lblTotal.Text = "C$ 0.00"
        ' 
        ' lblPagado
        ' 
        lblPagado.AutoSize = True
        lblPagado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagado.Location = New Point(125, 93)
        lblPagado.Name = "lblPagado"
        lblPagado.Size = New Size(64, 21)
        lblPagado.TabIndex = 10
        lblPagado.Text = "C$ 0.00"
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldo.Location = New Point(248, 93)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(64, 21)
        lblSaldo.TabIndex = 11
        lblSaldo.Text = "C$ 0.00"
        ' 
        ' lblReferencia
        ' 
        lblReferencia.AutoSize = True
        lblReferencia.Location = New Point(29, 190)
        lblReferencia.Name = "lblReferencia"
        lblReferencia.Size = New Size(62, 15)
        lblReferencia.TabIndex = 12
        lblReferencia.Text = "Referencia"
        ' 
        ' txtReferencia
        ' 
        txtReferencia.Location = New Point(99, 187)
        txtReferencia.Name = "txtReferencia"
        txtReferencia.PlaceholderText = "N° transferencia / voucher (opcional)"
        txtReferencia.Size = New Size(289, 23)
        txtReferencia.TabIndex = 13
        ' 
        ' lblObservacion
        ' 
        lblObservacion.AutoSize = True
        lblObservacion.Location = New Point(29, 227)
        lblObservacion.Name = "lblObservacion"
        lblObservacion.Size = New Size(76, 15)
        lblObservacion.TabIndex = 14
        lblObservacion.Text = " Observación"
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(111, 219)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.PlaceholderText = "Detalle u observación (opcional)"
        txtObservacion.Size = New Size(277, 23)
        txtObservacion.TabIndex = 15
        ' 
        ' btnRegistrarPago
        ' 
        btnRegistrarPago.Location = New Point(24, 248)
        btnRegistrarPago.Name = "btnRegistrarPago"
        btnRegistrarPago.Size = New Size(120, 35)
        btnRegistrarPago.TabIndex = 16
        btnRegistrarPago.Text = "Registrar pago"
        btnRegistrarPago.UseVisualStyleBackColor = True
        ' 
        ' btnAnularPago
        ' 
        btnAnularPago.Location = New Point(164, 248)
        btnAnularPago.Name = "btnAnularPago"
        btnAnularPago.Size = New Size(120, 35)
        btnAnularPago.TabIndex = 17
        btnAnularPago.Text = "Anular pago"
        btnAnularPago.UseVisualStyleBackColor = True
        ' 
        ' btnImprimirRecibo
        ' 
        btnImprimirRecibo.Location = New Point(299, 248)
        btnImprimirRecibo.Name = "btnImprimirRecibo"
        btnImprimirRecibo.Size = New Size(120, 35)
        btnImprimirRecibo.TabIndex = 18
        btnImprimirRecibo.Text = "Imprimir recibo"
        btnImprimirRecibo.UseVisualStyleBackColor = True
        ' 
        ' lblPagosMembresia
        ' 
        lblPagosMembresia.AutoSize = True
        lblPagosMembresia.Location = New Point(539, 381)
        lblPagosMembresia.Name = "lblPagosMembresia"
        lblPagosMembresia.Size = New Size(200, 15)
        lblPagosMembresia.TabIndex = 7
        lblPagosMembresia.Text = "Pagos de la membresía seleccionada"
        ' 
        ' dgvPagos
        ' 
        dgvPagos.AllowUserToAddRows = False
        dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPagos.Columns.AddRange(New DataGridViewColumn() {colFechaPago, colMonto, colMetodo, colRegistradoPor, colEstadoPago})
        dgvPagos.Location = New Point(539, 399)
        dgvPagos.Name = "dgvPagos"
        dgvPagos.Size = New Size(541, 150)
        dgvPagos.TabIndex = 8
        ' 
        ' colFechaPago
        ' 
        colFechaPago.HeaderText = "Fecha"
        colFechaPago.Name = "colFechaPago"
        ' 
        ' colMonto
        ' 
        colMonto.HeaderText = "Monto C$"
        colMonto.Name = "colMonto"
        ' 
        ' colMetodo
        ' 
        colMetodo.HeaderText = "Método"
        colMetodo.Name = "colMetodo"
        ' 
        ' colRegistradoPor
        ' 
        colRegistradoPor.HeaderText = "Registrado"
        colRegistradoPor.Name = "colRegistradoPor"
        ' 
        ' colEstadoPago
        ' 
        colEstadoPago.HeaderText = "Estado"
        colEstadoPago.Name = "colEstadoPago"
        ' 
        ' stsEstado
        ' 
        stsEstado.Items.AddRange(New ToolStripItem() {lblEstadoSocio, lblMembresiasActiva, lblSaldoPendiente, lblUsuarioActual})
        stsEstado.Location = New Point(0, 681)
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(1098, 22)
        stsEstado.SizingGrip = False
        stsEstado.TabIndex = 9
        stsEstado.Text = "StatusStrip1"
        ' 
        ' lblEstadoSocio
        ' 
        lblEstadoSocio.Name = "lblEstadoSocio"
        lblEstadoSocio.Size = New Size(120, 17)
        lblEstadoSocio.Text = "Socio: Sin seleccionar"
        ' 
        ' lblMembresiasActiva
        ' 
        lblMembresiasActiva.Name = "lblMembresiasActiva"
        lblMembresiasActiva.Size = New Size(152, 17)
        lblMembresiasActiva.Text = "Membresía activa: Ninguna"
        ' 
        ' lblSaldoPendiente
        ' 
        lblSaldoPendiente.Name = "lblSaldoPendiente"
        lblSaldoPendiente.Size = New Size(136, 17)
        lblSaldoPendiente.Text = "Saldo pendiente: C$ 0.00"
        ' 
        ' lblUsuarioActual
        ' 
        lblUsuarioActual.Name = "lblUsuarioActual"
        lblUsuarioActual.Size = New Size(131, 17)
        lblUsuarioActual.Text = "Usuario: Sin seleccionar"
        ' 
        ' frmMembresiasPagos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1098, 703)
        Controls.Add(stsEstado)
        Controls.Add(dgvPagos)
        Controls.Add(lblPagosMembresia)
        Controls.Add(grpPago)
        Controls.Add(lblHistorialMembresias)
        Controls.Add(dgvMembresias)
        Controls.Add(grpMembresia)
        Controls.Add(lblSocio)
        Controls.Add(btnBuscarSocio)
        Controls.Add(txtCedula)
        Name = "frmMembresiasPagos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMembresiasPagos"
        grpMembresia.ResumeLayout(False)
        grpMembresia.PerformLayout()
        CType(dgvMembresias, ComponentModel.ISupportInitialize).EndInit()
        grpPago.ResumeLayout(False)
        grpPago.PerformLayout()
        CType(dgvPagos, ComponentModel.ISupportInitialize).EndInit()
        stsEstado.ResumeLayout(False)
        stsEstado.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnBuscarSocio As Button
    Friend WithEvents lblSocio As Label
    Friend WithEvents grpMembresia As GroupBox
    Friend WithEvents lblTipoMembresia As Label
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents cboTipoMembresia As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents dtpFechccaVencimiento As DateTimePicker
    Friend WithEvents lblFechaVencimiento As Label
    Friend WithEvents btnCacelar As Button
    Friend WithEvents btnSuspender As Button
    Friend WithEvents btnRenovar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents dgvMembresias As DataGridView
    Friend WithEvents lblHistorialMembresias As Label
    Friend WithEvents grpPago As GroupBox
    Friend WithEvents lblTotalTitulo As Label
    Friend WithEvents cboMembresiaPago As ComboBox
    Friend WithEvents lblMembresiaPago As Label
    Friend WithEvents lblSaldoTitulo As Label
    Friend WithEvents lblPagadoTitulo As Label
    Friend WithEvents lblMetodo As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblPagado As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents cboMetodo As ComboBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lblReferencia As Label
    Friend WithEvents btnImprimirRecibo As Button
    Friend WithEvents btnAnularPago As Button
    Friend WithEvents btnRegistrarPago As Button
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents lblObservacion As Label
    Friend WithEvents lblPagosMembresia As Label
    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents colFechaPago As DataGridViewTextBoxColumn
    Friend WithEvents colMonto As DataGridViewTextBoxColumn
    Friend WithEvents colMetodo As DataGridViewTextBoxColumn
    Friend WithEvents colRegistradoPor As DataGridViewTextBoxColumn
    Friend WithEvents colEstadoPago As DataGridViewTextBoxColumn
    Friend WithEvents stsEstado As StatusStrip
    Friend WithEvents lblEstadoSocio As ToolStripStatusLabel
    Friend WithEvents lblMembresiasActiva As ToolStripStatusLabel
    Friend WithEvents lblSaldoPendiente As ToolStripStatusLabel
    Friend WithEvents lblUsuarioActual As ToolStripStatusLabel
End Class
