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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtCedula = New TextBox()
        btnBuscarSocio = New Button()
        lblSocio = New Label()
        grpMembresia = New GroupBox()
        btnCacelar = New Button()
        btnSuspender = New Button()
        btnRenovar = New Button()
        btnRegistrar = New Button()
        cboEstado = New ComboBox()
        lblEstado = New Label()
        txtPrecio = New TextBox()
        lblPrecio = New Label()
        dtpFechccaVencimiento = New DateTimePicker()
        lblFechaVencimiento = New Label()
        txtDuracion = New TextBox()
        lblDuracion = New Label()
        DateTimePicker1 = New DateTimePicker()
        lblFechaInicio = New Label()
        cboTipoMembresia = New ComboBox()
        lblTipoMembresia = New Label()
        dgvMembresias = New DataGridView()
        lblHistorialMembresias = New Label()
        grpPago = New GroupBox()
        btnImprimirRecibo = New Button()
        btnAnularPago = New Button()
        btnRegistrarPago = New Button()
        txtObservacion = New TextBox()
        lblObservacion = New Label()
        txtReferencia = New TextBox()
        lblReferencia = New Label()
        lblSaldo = New Label()
        lblPagado = New Label()
        lblTotal = New Label()
        cboMetodo = New ComboBox()
        lblMetodo = New Label()
        txtMonto = New TextBox()
        lblMonto = New Label()
        lblSaldoTitulo = New Label()
        lblPagadoTitulo = New Label()
        lblTotalTitulo = New Label()
        cboMembresiaPago = New ComboBox()
        lblMembresiaPago = New Label()
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
        txtCedula.BorderStyle = BorderStyle.FixedSingle
        txtCedula.Location = New Point(82, 26)
        txtCedula.Name = "txtCedula"
        txtCedula.PlaceholderText = "Cédula del socio"
        txtCedula.Size = New Size(240, 23)
        txtCedula.TabIndex = 0
        ' 
        ' btnBuscarSocio
        ' 
        btnBuscarSocio.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnBuscarSocio.Cursor = Cursors.Hand
        btnBuscarSocio.FlatAppearance.BorderSize = 0
        btnBuscarSocio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(61), CByte(96), CByte(135))
        btnBuscarSocio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(68), CByte(107), CByte(152))
        btnBuscarSocio.FlatStyle = FlatStyle.Flat
        btnBuscarSocio.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarSocio.ForeColor = Color.White
        btnBuscarSocio.Location = New Point(338, 24)
        btnBuscarSocio.Name = "btnBuscarSocio"
        btnBuscarSocio.Size = New Size(130, 27)
        btnBuscarSocio.TabIndex = 1
        btnBuscarSocio.Text = "Buscar socio"
        btnBuscarSocio.UseVisualStyleBackColor = False
        ' 
        ' lblSocio
        ' 
        lblSocio.AutoSize = True
        lblSocio.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblSocio.Location = New Point(28, 30)
        lblSocio.Name = "lblSocio"
        lblSocio.Size = New Size(39, 15)
        lblSocio.TabIndex = 2
        lblSocio.Text = "Socio:"
        ' 
        ' grpMembresia
        ' 
        grpMembresia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpMembresia.BackColor = Color.White
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
        grpMembresia.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpMembresia.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        grpMembresia.Location = New Point(24, 72)
        grpMembresia.Name = "grpMembresia"
        grpMembresia.Size = New Size(513, 304)
        grpMembresia.TabIndex = 3
        grpMembresia.TabStop = False
        grpMembresia.Text = "Membresía"
        ' 
        ' btnCacelar
        ' 
        btnCacelar.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnCacelar.Cursor = Cursors.Hand
        btnCacelar.FlatAppearance.BorderSize = 0
        btnCacelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(221), CByte(227))
        btnCacelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(222), CByte(229), CByte(234))
        btnCacelar.FlatStyle = FlatStyle.Flat
        btnCacelar.Font = New Font("Segoe UI", 9F)
        btnCacelar.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnCacelar.Location = New Point(382, 252)
        btnCacelar.Name = "btnCacelar"
        btnCacelar.Size = New Size(110, 36)
        btnCacelar.TabIndex = 15
        btnCacelar.Text = "Cancelar"
        btnCacelar.UseVisualStyleBackColor = False
        ' 
        ' btnSuspender
        ' 
        btnSuspender.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnSuspender.Cursor = Cursors.Hand
        btnSuspender.FlatAppearance.BorderSize = 0
        btnSuspender.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(221), CByte(227))
        btnSuspender.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(222), CByte(229), CByte(234))
        btnSuspender.FlatStyle = FlatStyle.Flat
        btnSuspender.Font = New Font("Segoe UI", 9F)
        btnSuspender.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnSuspender.Location = New Point(260, 252)
        btnSuspender.Name = "btnSuspender"
        btnSuspender.Size = New Size(110, 36)
        btnSuspender.TabIndex = 14
        btnSuspender.Text = "Suspender"
        btnSuspender.UseVisualStyleBackColor = False
        ' 
        ' btnRenovar
        ' 
        btnRenovar.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnRenovar.Cursor = Cursors.Hand
        btnRenovar.FlatAppearance.BorderSize = 0
        btnRenovar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(221), CByte(227))
        btnRenovar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(222), CByte(229), CByte(234))
        btnRenovar.FlatStyle = FlatStyle.Flat
        btnRenovar.Font = New Font("Segoe UI", 9F)
        btnRenovar.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnRenovar.Location = New Point(138, 252)
        btnRenovar.Name = "btnRenovar"
        btnRenovar.Size = New Size(110, 36)
        btnRenovar.TabIndex = 13
        btnRenovar.Text = "Renovar"
        btnRenovar.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnRegistrar.Cursor = Cursors.Hand
        btnRegistrar.FlatAppearance.BorderSize = 0
        btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(61), CByte(96), CByte(135))
        btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(68), CByte(107), CByte(152))
        btnRegistrar.FlatStyle = FlatStyle.Flat
        btnRegistrar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(16, 252)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(110, 36)
        btnRegistrar.TabIndex = 12
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' cboEstado
        ' 
        cboEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboEstado.Font = New Font("Segoe UI", 9F)
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(380, 140)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(114, 23)
        cboEstado.TabIndex = 11
        ' 
        ' lblEstado
        ' 
        lblEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 9F)
        lblEstado.Location = New Point(314, 144)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(42, 15)
        lblEstado.TabIndex = 10
        lblEstado.Text = "Estado"
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Font = New Font("Segoe UI", 9F)
        txtPrecio.Location = New Point(380, 94)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(114, 23)
        txtPrecio.TabIndex = 9
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPrecio.AutoSize = True
        lblPrecio.Font = New Font("Segoe UI", 9F)
        lblPrecio.Location = New Point(314, 98)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(57, 15)
        lblPrecio.TabIndex = 8
        lblPrecio.Text = "Precio C$"
        ' 
        ' dtpFechccaVencimiento
        ' 
        dtpFechccaVencimiento.Font = New Font("Segoe UI", 9F)
        dtpFechccaVencimiento.Location = New Point(134, 140)
        dtpFechccaVencimiento.Name = "dtpFechccaVencimiento"
        dtpFechccaVencimiento.Size = New Size(170, 23)
        dtpFechccaVencimiento.TabIndex = 7
        ' 
        ' lblFechaVencimiento
        ' 
        lblFechaVencimiento.AutoSize = True
        lblFechaVencimiento.Font = New Font("Segoe UI", 9F)
        lblFechaVencimiento.Location = New Point(16, 144)
        lblFechaVencimiento.Name = "lblFechaVencimiento"
        lblFechaVencimiento.Size = New Size(107, 15)
        lblFechaVencimiento.TabIndex = 6
        lblFechaVencimiento.Text = "Fecha vencimiento"
        ' 
        ' txtDuracion
        ' 
        txtDuracion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDuracion.BorderStyle = BorderStyle.FixedSingle
        txtDuracion.Font = New Font("Segoe UI", 9F)
        txtDuracion.Location = New Point(380, 48)
        txtDuracion.Name = "txtDuracion"
        txtDuracion.Size = New Size(114, 23)
        txtDuracion.TabIndex = 5
        ' 
        ' lblDuracion
        ' 
        lblDuracion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDuracion.AutoSize = True
        lblDuracion.Font = New Font("Segoe UI", 9F)
        lblDuracion.Location = New Point(314, 52)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(55, 15)
        lblDuracion.TabIndex = 4
        lblDuracion.Text = "Duración"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F)
        DateTimePicker1.Location = New Point(134, 94)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(170, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' lblFechaInicio
        ' 
        lblFechaInicio.AutoSize = True
        lblFechaInicio.Font = New Font("Segoe UI", 9F)
        lblFechaInicio.Location = New Point(16, 98)
        lblFechaInicio.Name = "lblFechaInicio"
        lblFechaInicio.Size = New Size(70, 15)
        lblFechaInicio.TabIndex = 2
        lblFechaInicio.Text = "Fecha inicio"
        ' 
        ' cboTipoMembresia
        ' 
        cboTipoMembresia.Font = New Font("Segoe UI", 9F)
        cboTipoMembresia.FormattingEnabled = True
        cboTipoMembresia.Location = New Point(134, 48)
        cboTipoMembresia.Name = "cboTipoMembresia"
        cboTipoMembresia.Size = New Size(170, 23)
        cboTipoMembresia.TabIndex = 1
        ' 
        ' lblTipoMembresia
        ' 
        lblTipoMembresia.AutoSize = True
        lblTipoMembresia.Font = New Font("Segoe UI", 9F)
        lblTipoMembresia.Location = New Point(16, 52)
        lblTipoMembresia.Name = "lblTipoMembresia"
        lblTipoMembresia.Size = New Size(109, 15)
        lblTipoMembresia.TabIndex = 0
        lblTipoMembresia.Text = "Tipo de membresía"
        ' 
        ' dgvMembresias
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        dgvMembresias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvMembresias.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMembresias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembresias.BackgroundColor = Color.White
        dgvMembresias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvMembresias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvMembresias.DefaultCellStyle = DataGridViewCellStyle3
        dgvMembresias.EnableHeadersVisualStyles = False
        dgvMembresias.GridColor = Color.FromArgb(CByte(224), CByte(228), CByte(231))
        dgvMembresias.Location = New Point(24, 414)
        dgvMembresias.Name = "dgvMembresias"
        dgvMembresias.RowHeadersVisible = False
        dgvMembresias.Size = New Size(513, 252)
        dgvMembresias.TabIndex = 4
        ' 
        ' lblHistorialMembresias
        ' 
        lblHistorialMembresias.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblHistorialMembresias.AutoSize = True
        lblHistorialMembresias.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHistorialMembresias.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblHistorialMembresias.Location = New Point(24, 392)
        lblHistorialMembresias.Name = "lblHistorialMembresias"
        lblHistorialMembresias.Size = New Size(191, 15)
        lblHistorialMembresias.TabIndex = 5
        lblHistorialMembresias.Text = "Historial de membresías del socio"
        ' 
        ' grpPago
        ' 
        grpPago.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpPago.BackColor = Color.White
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
        grpPago.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPago.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        grpPago.Location = New Point(561, 72)
        grpPago.Name = "grpPago"
        grpPago.Size = New Size(513, 304)
        grpPago.TabIndex = 6
        grpPago.TabStop = False
        grpPago.Text = "Registrar pago"
        ' 
        ' btnImprimirRecibo
        ' 
        btnImprimirRecibo.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnImprimirRecibo.Cursor = Cursors.Hand
        btnImprimirRecibo.FlatAppearance.BorderSize = 0
        btnImprimirRecibo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(221), CByte(227))
        btnImprimirRecibo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(222), CByte(229), CByte(234))
        btnImprimirRecibo.FlatStyle = FlatStyle.Flat
        btnImprimirRecibo.Font = New Font("Segoe UI", 9F)
        btnImprimirRecibo.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnImprimirRecibo.Location = New Point(344, 252)
        btnImprimirRecibo.Name = "btnImprimirRecibo"
        btnImprimirRecibo.Size = New Size(150, 36)
        btnImprimirRecibo.TabIndex = 18
        btnImprimirRecibo.Text = "Imprimir recibo"
        btnImprimirRecibo.UseVisualStyleBackColor = False
        ' 
        ' btnAnularPago
        ' 
        btnAnularPago.BackColor = Color.Red
        btnAnularPago.Cursor = Cursors.Hand
        btnAnularPago.FlatAppearance.BorderSize = 0
        btnAnularPago.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(221), CByte(227))
        btnAnularPago.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(222), CByte(229), CByte(234))
        btnAnularPago.FlatStyle = FlatStyle.Flat
        btnAnularPago.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAnularPago.ForeColor = Color.White
        btnAnularPago.Location = New Point(180, 252)
        btnAnularPago.Name = "btnAnularPago"
        btnAnularPago.Size = New Size(150, 36)
        btnAnularPago.TabIndex = 17
        btnAnularPago.Text = "Anular pago"
        btnAnularPago.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarPago
        ' 
        btnRegistrarPago.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnRegistrarPago.Cursor = Cursors.Hand
        btnRegistrarPago.FlatAppearance.BorderSize = 0
        btnRegistrarPago.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(61), CByte(96), CByte(135))
        btnRegistrarPago.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(68), CByte(107), CByte(152))
        btnRegistrarPago.FlatStyle = FlatStyle.Flat
        btnRegistrarPago.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarPago.ForeColor = Color.White
        btnRegistrarPago.Location = New Point(16, 252)
        btnRegistrarPago.Name = "btnRegistrarPago"
        btnRegistrarPago.Size = New Size(150, 36)
        btnRegistrarPago.TabIndex = 16
        btnRegistrarPago.Text = "Registrar pago"
        btnRegistrarPago.UseVisualStyleBackColor = False
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtObservacion.BorderStyle = BorderStyle.FixedSingle
        txtObservacion.Font = New Font("Segoe UI", 9F)
        txtObservacion.Location = New Point(134, 214)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.PlaceholderText = "Detalle u observación (opcional)"
        txtObservacion.Size = New Size(360, 23)
        txtObservacion.TabIndex = 15
        ' 
        ' lblObservacion
        ' 
        lblObservacion.AutoSize = True
        lblObservacion.Font = New Font("Segoe UI", 9F)
        lblObservacion.Location = New Point(16, 218)
        lblObservacion.Name = "lblObservacion"
        lblObservacion.Size = New Size(76, 15)
        lblObservacion.TabIndex = 14
        lblObservacion.Text = " Observación"
        ' 
        ' txtReferencia
        ' 
        txtReferencia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtReferencia.BorderStyle = BorderStyle.FixedSingle
        txtReferencia.Font = New Font("Segoe UI", 9F)
        txtReferencia.Location = New Point(134, 178)
        txtReferencia.Name = "txtReferencia"
        txtReferencia.PlaceholderText = "N° transferencia / voucher (opcional)"
        txtReferencia.Size = New Size(360, 23)
        txtReferencia.TabIndex = 13
        ' 
        ' lblReferencia
        ' 
        lblReferencia.AutoSize = True
        lblReferencia.Font = New Font("Segoe UI", 9F)
        lblReferencia.Location = New Point(16, 182)
        lblReferencia.Name = "lblReferencia"
        lblReferencia.Size = New Size(62, 15)
        lblReferencia.TabIndex = 12
        lblReferencia.Text = "Referencia"
        ' 
        ' lblSaldo
        ' 
        lblSaldo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldo.ForeColor = Color.FromArgb(CByte(169), CByte(68), CByte(66))
        lblSaldo.Location = New Point(334, 94)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(64, 21)
        lblSaldo.TabIndex = 11
        lblSaldo.Text = "C$ 0.00"
        ' 
        ' lblPagado
        ' 
        lblPagado.AutoSize = True
        lblPagado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagado.ForeColor = Color.FromArgb(CByte(46), CByte(125), CByte(50))
        lblPagado.Location = New Point(175, 94)
        lblPagado.Name = "lblPagado"
        lblPagado.Size = New Size(64, 21)
        lblPagado.TabIndex = 10
        lblPagado.Text = "C$ 0.00"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTotal.Location = New Point(16, 94)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(64, 21)
        lblTotal.TabIndex = 9
        lblTotal.Text = "C$ 0.00"
        ' 
        ' cboMetodo
        ' 
        cboMetodo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboMetodo.Font = New Font("Segoe UI", 9F)
        cboMetodo.FormattingEnabled = True
        cboMetodo.Location = New Point(380, 142)
        cboMetodo.Name = "cboMetodo"
        cboMetodo.Size = New Size(114, 23)
        cboMetodo.TabIndex = 8
        ' 
        ' lblMetodo
        ' 
        lblMetodo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblMetodo.AutoSize = True
        lblMetodo.Font = New Font("Segoe UI", 9F)
        lblMetodo.Location = New Point(314, 146)
        lblMetodo.Name = "lblMetodo"
        lblMetodo.Size = New Size(57, 15)
        lblMetodo.TabIndex = 7
        lblMetodo.Text = "Método *"
        ' 
        ' txtMonto
        ' 
        txtMonto.BorderStyle = BorderStyle.FixedSingle
        txtMonto.Font = New Font("Segoe UI", 9F)
        txtMonto.Location = New Point(134, 142)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(170, 23)
        txtMonto.TabIndex = 6
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Font = New Font("Segoe UI", 9F)
        lblMonto.Location = New Point(16, 146)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(68, 15)
        lblMonto.TabIndex = 5
        lblMonto.Text = "Monto C$ *"
        ' 
        ' lblSaldoTitulo
        ' 
        lblSaldoTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSaldoTitulo.AutoSize = True
        lblSaldoTitulo.Font = New Font("Segoe UI", 9F)
        lblSaldoTitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSaldoTitulo.Location = New Point(334, 74)
        lblSaldoTitulo.Name = "lblSaldoTitulo"
        lblSaldoTitulo.Size = New Size(36, 15)
        lblSaldoTitulo.TabIndex = 4
        lblSaldoTitulo.Text = "Saldo"
        ' 
        ' lblPagadoTitulo
        ' 
        lblPagadoTitulo.AutoSize = True
        lblPagadoTitulo.Font = New Font("Segoe UI", 9F)
        lblPagadoTitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblPagadoTitulo.Location = New Point(175, 74)
        lblPagadoTitulo.Name = "lblPagadoTitulo"
        lblPagadoTitulo.Size = New Size(47, 15)
        lblPagadoTitulo.TabIndex = 3
        lblPagadoTitulo.Text = "Pagado"
        ' 
        ' lblTotalTitulo
        ' 
        lblTotalTitulo.AutoSize = True
        lblTotalTitulo.Font = New Font("Segoe UI", 9F)
        lblTotalTitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblTotalTitulo.Location = New Point(16, 74)
        lblTotalTitulo.Name = "lblTotalTitulo"
        lblTotalTitulo.Size = New Size(33, 15)
        lblTotalTitulo.TabIndex = 2
        lblTotalTitulo.Text = "Total"
        ' 
        ' cboMembresiaPago
        ' 
        cboMembresiaPago.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboMembresiaPago.Font = New Font("Segoe UI", 9F)
        cboMembresiaPago.FormattingEnabled = True
        cboMembresiaPago.Location = New Point(134, 40)
        cboMembresiaPago.Name = "cboMembresiaPago"
        cboMembresiaPago.Size = New Size(360, 23)
        cboMembresiaPago.TabIndex = 1
        ' 
        ' lblMembresiaPago
        ' 
        lblMembresiaPago.AutoSize = True
        lblMembresiaPago.Font = New Font("Segoe UI", 9F)
        lblMembresiaPago.Location = New Point(16, 44)
        lblMembresiaPago.Name = "lblMembresiaPago"
        lblMembresiaPago.Size = New Size(66, 15)
        lblMembresiaPago.TabIndex = 0
        lblMembresiaPago.Text = "Membresía"
        ' 
        ' lblPagosMembresia
        ' 
        lblPagosMembresia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPagosMembresia.AutoSize = True
        lblPagosMembresia.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagosMembresia.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblPagosMembresia.Location = New Point(561, 392)
        lblPagosMembresia.Name = "lblPagosMembresia"
        lblPagosMembresia.Size = New Size(206, 15)
        lblPagosMembresia.TabIndex = 7
        lblPagosMembresia.Text = "Pagos de la membresía seleccionada"
        ' 
        ' dgvPagos
        ' 
        dgvPagos.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        dgvPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvPagos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPagos.BackgroundColor = Color.White
        dgvPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPagos.Columns.AddRange(New DataGridViewColumn() {colFechaPago, colMonto, colMetodo, colRegistradoPor, colEstadoPago})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.White
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvPagos.DefaultCellStyle = DataGridViewCellStyle8
        dgvPagos.EnableHeadersVisualStyles = False
        dgvPagos.GridColor = Color.FromArgb(CByte(224), CByte(228), CByte(231))
        dgvPagos.Location = New Point(561, 414)
        dgvPagos.Name = "dgvPagos"
        dgvPagos.RowHeadersVisible = False
        dgvPagos.Size = New Size(513, 252)
        dgvPagos.TabIndex = 8
        ' 
        ' colFechaPago
        ' 
        colFechaPago.FillWeight = 110F
        colFechaPago.HeaderText = "Fecha"
        colFechaPago.Name = "colFechaPago"
        ' 
        ' colMonto
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight
        colMonto.DefaultCellStyle = DataGridViewCellStyle6
        colMonto.FillWeight = 90F
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
        colRegistradoPor.FillWeight = 125F
        colRegistradoPor.HeaderText = "Registrado"
        colRegistradoPor.Name = "colRegistradoPor"
        ' 
        ' colEstadoPago
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        colEstadoPago.DefaultCellStyle = DataGridViewCellStyle7
        colEstadoPago.FillWeight = 85F
        colEstadoPago.HeaderText = "Estado"
        colEstadoPago.Name = "colEstadoPago"
        ' 
        ' stsEstado
        ' 
        stsEstado.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(244))
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
        lblEstadoSocio.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblEstadoSocio.Name = "lblEstadoSocio"
        lblEstadoSocio.Size = New Size(120, 17)
        lblEstadoSocio.Text = "Socio: Sin seleccionar"
        ' 
        ' lblMembresiasActiva
        ' 
        lblMembresiasActiva.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblMembresiasActiva.Name = "lblMembresiasActiva"
        lblMembresiasActiva.Size = New Size(152, 17)
        lblMembresiasActiva.Text = "Membresía activa: Ninguna"
        ' 
        ' lblSaldoPendiente
        ' 
        lblSaldoPendiente.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSaldoPendiente.Name = "lblSaldoPendiente"
        lblSaldoPendiente.Size = New Size(136, 17)
        lblSaldoPendiente.Text = "Saldo pendiente: C$ 0.00"
        ' 
        ' lblUsuarioActual
        ' 
        lblUsuarioActual.AutoSize = False
        lblUsuarioActual.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblUsuarioActual.Name = "lblUsuarioActual"
        lblUsuarioActual.Size = New Size(675, 17)
        lblUsuarioActual.Spring = True
        lblUsuarioActual.Text = "Usuario: Sin seleccionar"
        lblUsuarioActual.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' frmMembresiasPagos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
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
        Font = New Font("Segoe UI", 9F)
        Name = "frmMembresiasPagos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GymControl - Membresías y pagos"
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
