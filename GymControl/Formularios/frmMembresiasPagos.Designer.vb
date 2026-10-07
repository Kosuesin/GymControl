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
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        dtpFechaVencimiento = New DateTimePicker()
        lblFechaVencimiento = New Label()
        txtDuracion = New TextBox()
        lblDuracion = New Label()
        dptFechaInicio = New DateTimePicker()
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
        txtCedula.Location = New Point(94, 35)
        txtCedula.Margin = New Padding(3, 4, 3, 4)
        txtCedula.Name = "txtCedula"
        txtCedula.PlaceholderText = "Cédula del socio"
        txtCedula.Size = New Size(274, 27)
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
        btnBuscarSocio.Location = New Point(386, 32)
        btnBuscarSocio.Margin = New Padding(3, 4, 3, 4)
        btnBuscarSocio.Name = "btnBuscarSocio"
        btnBuscarSocio.Size = New Size(149, 36)
        btnBuscarSocio.TabIndex = 1
        btnBuscarSocio.Text = "Buscar socio"
        btnBuscarSocio.UseVisualStyleBackColor = False
        ' 
        ' lblSocio
        ' 
        lblSocio.AutoSize = True
        lblSocio.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblSocio.Location = New Point(32, 40)
        lblSocio.Name = "lblSocio"
        lblSocio.Size = New Size(49, 20)
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
        grpMembresia.Controls.Add(dtpFechaVencimiento)
        grpMembresia.Controls.Add(lblFechaVencimiento)
        grpMembresia.Controls.Add(txtDuracion)
        grpMembresia.Controls.Add(lblDuracion)
        grpMembresia.Controls.Add(dptFechaInicio)
        grpMembresia.Controls.Add(lblFechaInicio)
        grpMembresia.Controls.Add(cboTipoMembresia)
        grpMembresia.Controls.Add(lblTipoMembresia)
        grpMembresia.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpMembresia.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        grpMembresia.Location = New Point(27, 96)
        grpMembresia.Margin = New Padding(3, 4, 3, 4)
        grpMembresia.Name = "grpMembresia"
        grpMembresia.Padding = New Padding(3, 4, 3, 4)
        grpMembresia.Size = New Size(586, 405)
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
        btnCacelar.Location = New Point(437, 336)
        btnCacelar.Margin = New Padding(3, 4, 3, 4)
        btnCacelar.Name = "btnCacelar"
        btnCacelar.Size = New Size(126, 48)
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
        btnSuspender.Location = New Point(297, 336)
        btnSuspender.Margin = New Padding(3, 4, 3, 4)
        btnSuspender.Name = "btnSuspender"
        btnSuspender.Size = New Size(126, 48)
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
        btnRenovar.Location = New Point(158, 336)
        btnRenovar.Margin = New Padding(3, 4, 3, 4)
        btnRenovar.Name = "btnRenovar"
        btnRenovar.Size = New Size(126, 48)
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
        btnRegistrar.Location = New Point(18, 336)
        btnRegistrar.Margin = New Padding(3, 4, 3, 4)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(126, 48)
        btnRegistrar.TabIndex = 12
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' cboEstado
        ' 
        cboEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboEstado.Font = New Font("Segoe UI", 9F)
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(434, 187)
        cboEstado.Margin = New Padding(3, 4, 3, 4)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(130, 28)
        cboEstado.TabIndex = 11
        ' 
        ' lblEstado
        ' 
        lblEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 9F)
        lblEstado.Location = New Point(359, 192)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(54, 20)
        lblEstado.TabIndex = 10
        lblEstado.Text = "Estado"
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Font = New Font("Segoe UI", 9F)
        txtPrecio.Location = New Point(434, 125)
        txtPrecio.Margin = New Padding(3, 4, 3, 4)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(130, 27)
        txtPrecio.TabIndex = 9
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPrecio.AutoSize = True
        lblPrecio.Font = New Font("Segoe UI", 9F)
        lblPrecio.Location = New Point(359, 131)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(71, 20)
        lblPrecio.TabIndex = 8
        lblPrecio.Text = "Precio C$"
        ' 
        ' dtpFechaVencimiento
        ' 
        dtpFechaVencimiento.Font = New Font("Segoe UI", 9F)
        dtpFechaVencimiento.Location = New Point(153, 187)
        dtpFechaVencimiento.Margin = New Padding(3, 4, 3, 4)
        dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        dtpFechaVencimiento.Size = New Size(194, 27)
        dtpFechaVencimiento.TabIndex = 7
        ' 
        ' lblFechaVencimiento
        ' 
        lblFechaVencimiento.AutoSize = True
        lblFechaVencimiento.Font = New Font("Segoe UI", 9F)
        lblFechaVencimiento.Location = New Point(18, 192)
        lblFechaVencimiento.Name = "lblFechaVencimiento"
        lblFechaVencimiento.Size = New Size(132, 20)
        lblFechaVencimiento.TabIndex = 6
        lblFechaVencimiento.Text = "Fecha vencimiento"
        ' 
        ' txtDuracion
        ' 
        txtDuracion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDuracion.BorderStyle = BorderStyle.FixedSingle
        txtDuracion.Font = New Font("Segoe UI", 9F)
        txtDuracion.Location = New Point(434, 64)
        txtDuracion.Margin = New Padding(3, 4, 3, 4)
        txtDuracion.Name = "txtDuracion"
        txtDuracion.Size = New Size(130, 27)
        txtDuracion.TabIndex = 5
        ' 
        ' lblDuracion
        ' 
        lblDuracion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDuracion.AutoSize = True
        lblDuracion.Font = New Font("Segoe UI", 9F)
        lblDuracion.Location = New Point(359, 69)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(69, 20)
        lblDuracion.TabIndex = 4
        lblDuracion.Text = "Duración"
        ' 
        ' dptFechaInicio
        ' 
        dptFechaInicio.Font = New Font("Segoe UI", 9F)
        dptFechaInicio.Location = New Point(153, 125)
        dptFechaInicio.Margin = New Padding(3, 4, 3, 4)
        dptFechaInicio.Name = "dptFechaInicio"
        dptFechaInicio.Size = New Size(194, 27)
        dptFechaInicio.TabIndex = 3
        ' 
        ' lblFechaInicio
        ' 
        lblFechaInicio.AutoSize = True
        lblFechaInicio.Font = New Font("Segoe UI", 9F)
        lblFechaInicio.Location = New Point(18, 131)
        lblFechaInicio.Name = "lblFechaInicio"
        lblFechaInicio.Size = New Size(87, 20)
        lblFechaInicio.TabIndex = 2
        lblFechaInicio.Text = "Fecha inicio"
        ' 
        ' cboTipoMembresia
        ' 
        cboTipoMembresia.Font = New Font("Segoe UI", 9F)
        cboTipoMembresia.FormattingEnabled = True
        cboTipoMembresia.Location = New Point(153, 64)
        cboTipoMembresia.Margin = New Padding(3, 4, 3, 4)
        cboTipoMembresia.Name = "cboTipoMembresia"
        cboTipoMembresia.Size = New Size(194, 28)
        cboTipoMembresia.TabIndex = 1
        ' 
        ' lblTipoMembresia
        ' 
        lblTipoMembresia.AutoSize = True
        lblTipoMembresia.Font = New Font("Segoe UI", 9F)
        lblTipoMembresia.Location = New Point(18, 69)
        lblTipoMembresia.Name = "lblTipoMembresia"
        lblTipoMembresia.Size = New Size(138, 20)
        lblTipoMembresia.TabIndex = 0
        lblTipoMembresia.Text = "Tipo de membresía"
        ' 
        ' dgvMembresias
        ' 
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        dgvMembresias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        dgvMembresias.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMembresias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembresias.BackgroundColor = Color.White
        dgvMembresias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        dgvMembresias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        dgvMembresias.DefaultCellStyle = DataGridViewCellStyle11
        dgvMembresias.EnableHeadersVisualStyles = False
        dgvMembresias.GridColor = Color.FromArgb(CByte(224), CByte(228), CByte(231))
        dgvMembresias.Location = New Point(27, 552)
        dgvMembresias.Margin = New Padding(3, 4, 3, 4)
        dgvMembresias.Name = "dgvMembresias"
        dgvMembresias.RowHeadersVisible = False
        dgvMembresias.RowHeadersWidth = 51
        dgvMembresias.Size = New Size(586, 336)
        dgvMembresias.TabIndex = 4
        ' 
        ' lblHistorialMembresias
        ' 
        lblHistorialMembresias.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblHistorialMembresias.AutoSize = True
        lblHistorialMembresias.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHistorialMembresias.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblHistorialMembresias.Location = New Point(27, 523)
        lblHistorialMembresias.Name = "lblHistorialMembresias"
        lblHistorialMembresias.Size = New Size(243, 20)
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
        grpPago.Location = New Point(641, 96)
        grpPago.Margin = New Padding(3, 4, 3, 4)
        grpPago.Name = "grpPago"
        grpPago.Padding = New Padding(3, 4, 3, 4)
        grpPago.Size = New Size(586, 405)
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
        btnImprimirRecibo.Location = New Point(393, 336)
        btnImprimirRecibo.Margin = New Padding(3, 4, 3, 4)
        btnImprimirRecibo.Name = "btnImprimirRecibo"
        btnImprimirRecibo.Size = New Size(171, 48)
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
        btnAnularPago.Location = New Point(206, 336)
        btnAnularPago.Margin = New Padding(3, 4, 3, 4)
        btnAnularPago.Name = "btnAnularPago"
        btnAnularPago.Size = New Size(171, 48)
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
        btnRegistrarPago.Location = New Point(18, 336)
        btnRegistrarPago.Margin = New Padding(3, 4, 3, 4)
        btnRegistrarPago.Name = "btnRegistrarPago"
        btnRegistrarPago.Size = New Size(171, 48)
        btnRegistrarPago.TabIndex = 16
        btnRegistrarPago.Text = "Registrar pago"
        btnRegistrarPago.UseVisualStyleBackColor = False
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtObservacion.BorderStyle = BorderStyle.FixedSingle
        txtObservacion.Font = New Font("Segoe UI", 9F)
        txtObservacion.Location = New Point(153, 285)
        txtObservacion.Margin = New Padding(3, 4, 3, 4)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.PlaceholderText = "Detalle u observación (opcional)"
        txtObservacion.Size = New Size(411, 27)
        txtObservacion.TabIndex = 15
        ' 
        ' lblObservacion
        ' 
        lblObservacion.AutoSize = True
        lblObservacion.Font = New Font("Segoe UI", 9F)
        lblObservacion.Location = New Point(18, 291)
        lblObservacion.Name = "lblObservacion"
        lblObservacion.Size = New Size(95, 20)
        lblObservacion.TabIndex = 14
        lblObservacion.Text = " Observación"
        ' 
        ' txtReferencia
        ' 
        txtReferencia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtReferencia.BorderStyle = BorderStyle.FixedSingle
        txtReferencia.Font = New Font("Segoe UI", 9F)
        txtReferencia.Location = New Point(153, 237)
        txtReferencia.Margin = New Padding(3, 4, 3, 4)
        txtReferencia.Name = "txtReferencia"
        txtReferencia.PlaceholderText = "N° transferencia / voucher (opcional)"
        txtReferencia.Size = New Size(411, 27)
        txtReferencia.TabIndex = 13
        ' 
        ' lblReferencia
        ' 
        lblReferencia.AutoSize = True
        lblReferencia.Font = New Font("Segoe UI", 9F)
        lblReferencia.Location = New Point(18, 243)
        lblReferencia.Name = "lblReferencia"
        lblReferencia.Size = New Size(79, 20)
        lblReferencia.TabIndex = 12
        lblReferencia.Text = "Referencia"
        ' 
        ' lblSaldo
        ' 
        lblSaldo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldo.ForeColor = Color.FromArgb(CByte(169), CByte(68), CByte(66))
        lblSaldo.Location = New Point(382, 125)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(83, 28)
        lblSaldo.TabIndex = 11
        lblSaldo.Text = "C$ 0.00"
        ' 
        ' lblPagado
        ' 
        lblPagado.AutoSize = True
        lblPagado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagado.ForeColor = Color.FromArgb(CByte(46), CByte(125), CByte(50))
        lblPagado.Location = New Point(200, 125)
        lblPagado.Name = "lblPagado"
        lblPagado.Size = New Size(83, 28)
        lblPagado.TabIndex = 10
        lblPagado.Text = "C$ 0.00"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTotal.Location = New Point(18, 125)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(83, 28)
        lblTotal.TabIndex = 9
        lblTotal.Text = "C$ 0.00"
        ' 
        ' cboMetodo
        ' 
        cboMetodo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboMetodo.Font = New Font("Segoe UI", 9F)
        cboMetodo.FormattingEnabled = True
        cboMetodo.Location = New Point(434, 189)
        cboMetodo.Margin = New Padding(3, 4, 3, 4)
        cboMetodo.Name = "cboMetodo"
        cboMetodo.Size = New Size(130, 28)
        cboMetodo.TabIndex = 8
        ' 
        ' lblMetodo
        ' 
        lblMetodo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblMetodo.AutoSize = True
        lblMetodo.Font = New Font("Segoe UI", 9F)
        lblMetodo.Location = New Point(359, 195)
        lblMetodo.Name = "lblMetodo"
        lblMetodo.Size = New Size(72, 20)
        lblMetodo.TabIndex = 7
        lblMetodo.Text = "Método *"
        ' 
        ' txtMonto
        ' 
        txtMonto.BorderStyle = BorderStyle.FixedSingle
        txtMonto.Font = New Font("Segoe UI", 9F)
        txtMonto.Location = New Point(153, 189)
        txtMonto.Margin = New Padding(3, 4, 3, 4)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(194, 27)
        txtMonto.TabIndex = 6
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Font = New Font("Segoe UI", 9F)
        lblMonto.Location = New Point(18, 195)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(84, 20)
        lblMonto.TabIndex = 5
        lblMonto.Text = "Monto C$ *"
        ' 
        ' lblSaldoTitulo
        ' 
        lblSaldoTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSaldoTitulo.AutoSize = True
        lblSaldoTitulo.Font = New Font("Segoe UI", 9F)
        lblSaldoTitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSaldoTitulo.Location = New Point(382, 99)
        lblSaldoTitulo.Name = "lblSaldoTitulo"
        lblSaldoTitulo.Size = New Size(47, 20)
        lblSaldoTitulo.TabIndex = 4
        lblSaldoTitulo.Text = "Saldo"
        ' 
        ' lblPagadoTitulo
        ' 
        lblPagadoTitulo.AutoSize = True
        lblPagadoTitulo.Font = New Font("Segoe UI", 9F)
        lblPagadoTitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblPagadoTitulo.Location = New Point(200, 99)
        lblPagadoTitulo.Name = "lblPagadoTitulo"
        lblPagadoTitulo.Size = New Size(59, 20)
        lblPagadoTitulo.TabIndex = 3
        lblPagadoTitulo.Text = "Pagado"
        ' 
        ' lblTotalTitulo
        ' 
        lblTotalTitulo.AutoSize = True
        lblTotalTitulo.Font = New Font("Segoe UI", 9F)
        lblTotalTitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblTotalTitulo.Location = New Point(18, 99)
        lblTotalTitulo.Name = "lblTotalTitulo"
        lblTotalTitulo.Size = New Size(42, 20)
        lblTotalTitulo.TabIndex = 2
        lblTotalTitulo.Text = "Total"
        ' 
        ' cboMembresiaPago
        ' 
        cboMembresiaPago.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboMembresiaPago.Font = New Font("Segoe UI", 9F)
        cboMembresiaPago.FormattingEnabled = True
        cboMembresiaPago.Location = New Point(153, 53)
        cboMembresiaPago.Margin = New Padding(3, 4, 3, 4)
        cboMembresiaPago.Name = "cboMembresiaPago"
        cboMembresiaPago.Size = New Size(411, 28)
        cboMembresiaPago.TabIndex = 1
        ' 
        ' lblMembresiaPago
        ' 
        lblMembresiaPago.AutoSize = True
        lblMembresiaPago.Font = New Font("Segoe UI", 9F)
        lblMembresiaPago.Location = New Point(18, 59)
        lblMembresiaPago.Name = "lblMembresiaPago"
        lblMembresiaPago.Size = New Size(83, 20)
        lblMembresiaPago.TabIndex = 0
        lblMembresiaPago.Text = "Membresía"
        ' 
        ' lblPagosMembresia
        ' 
        lblPagosMembresia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPagosMembresia.AutoSize = True
        lblPagosMembresia.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagosMembresia.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblPagosMembresia.Location = New Point(641, 523)
        lblPagosMembresia.Name = "lblPagosMembresia"
        lblPagosMembresia.Size = New Size(262, 20)
        lblPagosMembresia.TabIndex = 7
        lblPagosMembresia.Text = "Pagos de la membresía seleccionada"
        ' 
        ' dgvPagos
        ' 
        dgvPagos.AllowUserToAddRows = False
        DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        dgvPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        dgvPagos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPagos.BackgroundColor = Color.White
        dgvPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle13.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        dgvPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPagos.Columns.AddRange(New DataGridViewColumn() {colFechaPago, colMonto, colMetodo, colRegistradoPor, colEstadoPago})
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = Color.White
        DataGridViewCellStyle16.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle16.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        DataGridViewCellStyle16.SelectionForeColor = Color.White
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.False
        dgvPagos.DefaultCellStyle = DataGridViewCellStyle16
        dgvPagos.EnableHeadersVisualStyles = False
        dgvPagos.GridColor = Color.FromArgb(CByte(224), CByte(228), CByte(231))
        dgvPagos.Location = New Point(641, 552)
        dgvPagos.Margin = New Padding(3, 4, 3, 4)
        dgvPagos.Name = "dgvPagos"
        dgvPagos.RowHeadersVisible = False
        dgvPagos.RowHeadersWidth = 51
        dgvPagos.Size = New Size(586, 336)
        dgvPagos.TabIndex = 8
        ' 
        ' colFechaPago
        ' 
        colFechaPago.FillWeight = 110F
        colFechaPago.HeaderText = "Fecha"
        colFechaPago.MinimumWidth = 6
        colFechaPago.Name = "colFechaPago"
        ' 
        ' colMonto
        ' 
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight
        colMonto.DefaultCellStyle = DataGridViewCellStyle14
        colMonto.FillWeight = 90F
        colMonto.HeaderText = "Monto C$"
        colMonto.MinimumWidth = 6
        colMonto.Name = "colMonto"
        ' 
        ' colMetodo
        ' 
        colMetodo.HeaderText = "Método"
        colMetodo.MinimumWidth = 6
        colMetodo.Name = "colMetodo"
        ' 
        ' colRegistradoPor
        ' 
        colRegistradoPor.FillWeight = 125F
        colRegistradoPor.HeaderText = "Registrado"
        colRegistradoPor.MinimumWidth = 6
        colRegistradoPor.Name = "colRegistradoPor"
        ' 
        ' colEstadoPago
        ' 
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter
        colEstadoPago.DefaultCellStyle = DataGridViewCellStyle15
        colEstadoPago.FillWeight = 85F
        colEstadoPago.HeaderText = "Estado"
        colEstadoPago.MinimumWidth = 6
        colEstadoPago.Name = "colEstadoPago"
        ' 
        ' stsEstado
        ' 
        stsEstado.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(244))
        stsEstado.ImageScalingSize = New Size(20, 20)
        stsEstado.Items.AddRange(New ToolStripItem() {lblEstadoSocio, lblMembresiasActiva, lblSaldoPendiente, lblUsuarioActual})
        stsEstado.Location = New Point(0, 911)
        stsEstado.Name = "stsEstado"
        stsEstado.Padding = New Padding(1, 0, 16, 0)
        stsEstado.Size = New Size(1255, 26)
        stsEstado.SizingGrip = False
        stsEstado.TabIndex = 9
        stsEstado.Text = "StatusStrip1"
        ' 
        ' lblEstadoSocio
        ' 
        lblEstadoSocio.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblEstadoSocio.Name = "lblEstadoSocio"
        lblEstadoSocio.Size = New Size(151, 20)
        lblEstadoSocio.Text = "Socio: Sin seleccionar"
        ' 
        ' lblMembresiasActiva
        ' 
        lblMembresiasActiva.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblMembresiasActiva.Name = "lblMembresiasActiva"
        lblMembresiasActiva.Size = New Size(189, 20)
        lblMembresiasActiva.Text = "Membresía activa: Ninguna"
        ' 
        ' lblSaldoPendiente
        ' 
        lblSaldoPendiente.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSaldoPendiente.Name = "lblSaldoPendiente"
        lblSaldoPendiente.Size = New Size(173, 20)
        lblSaldoPendiente.Text = "Saldo pendiente: C$ 0.00"
        ' 
        ' lblUsuarioActual
        ' 
        lblUsuarioActual.AutoSize = False
        lblUsuarioActual.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblUsuarioActual.Name = "lblUsuarioActual"
        lblUsuarioActual.Size = New Size(725, 20)
        lblUsuarioActual.Spring = True
        lblUsuarioActual.Text = "Usuario: Sin seleccionar"
        lblUsuarioActual.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' frmMembresiasPagos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        ClientSize = New Size(1255, 937)
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
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents dptFechaInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents cboTipoMembresia As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents dtpFechaVencimiento As DateTimePicker
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
