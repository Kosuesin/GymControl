<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentroReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentroReportes))
        pnlEncabezado = New Panel()
        lblSubtituloCentro = New Label()
        lblTituloCentro = New Label()
        tvReportes = New TreeView()
        pnlDetalle = New Panel()
        pnlR01 = New Panel()
        lblNotaRecibo = New Label()
        btnImprimirReciboCentro = New Button()
        btnVistaPreviaRecibo = New Button()
        cboPagos = New ComboBox()
        lblSeleccionRecibo = New Label()
        pnlR02 = New Panel()
        lblNotaConstancia = New Label()
        btnConfigurarPagina = New Button()
        btnImprimirConstancia = New Button()
        btnVistaPreviaConstancia = New Button()
        cboSocios = New ComboBox()
        lblSeleccionSocio = New Label()
        pnlR03 = New Panel()
        btnAbrirListado = New Button()
        lblInfoListado = New Label()
        lblTituloReporte = New Label()
        lblDescripcionReporte = New Label()
        btnCerrar = New Button()
        stsEstado = New StatusStrip()
        lblEstadoCentro = New ToolStripStatusLabel()
        lblUsuarioCentro = New ToolStripStatusLabel()
        pnlEncabezado.SuspendLayout()
        pnlDetalle.SuspendLayout()
        pnlR01.SuspendLayout()
        pnlR02.SuspendLayout()
        pnlR03.SuspendLayout()
        stsEstado.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEncabezado
        ' 
        pnlEncabezado.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlEncabezado.Controls.Add(lblSubtituloCentro)
        pnlEncabezado.Controls.Add(lblTituloCentro)
        pnlEncabezado.Dock = DockStyle.Top
        pnlEncabezado.Location = New Point(0, 0)
        pnlEncabezado.Name = "pnlEncabezado"
        pnlEncabezado.Size = New Size(1140, 88)
        pnlEncabezado.TabIndex = 0
        ' 
        ' lblSubtituloCentro
        ' 
        lblSubtituloCentro.AutoSize = True
        lblSubtituloCentro.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtituloCentro.ForeColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        lblSubtituloCentro.Location = New Point(26, 52)
        lblSubtituloCentro.Name = "lblSubtituloCentro"
        lblSubtituloCentro.Size = New Size(299, 20)
        lblSubtituloCentro.TabIndex = 1
        lblSubtituloCentro.Text = "Gimnasio Titán · Documentos e impresiones"
        ' 
        ' lblTituloCentro
        ' 
        lblTituloCentro.AutoSize = True
        lblTituloCentro.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloCentro.ForeColor = Color.White
        lblTituloCentro.Location = New Point(22, 12)
        lblTituloCentro.Name = "lblTituloCentro"
        lblTituloCentro.Size = New Size(283, 41)
        lblTituloCentro.TabIndex = 0
        lblTituloCentro.Text = "Centro de reportes"
        ' 
        ' tvReportes
        ' 
        tvReportes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tvReportes.BackColor = Color.White
        tvReportes.BorderStyle = BorderStyle.FixedSingle
        tvReportes.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tvReportes.FullRowSelect = True
        tvReportes.HideSelection = False
        tvReportes.ItemHeight = 26
        tvReportes.Location = New Point(24, 108)
        tvReportes.Name = "tvReportes"
        tvReportes.Size = New Size(300, 540)
        tvReportes.TabIndex = 1
        ' 
        ' pnlDetalle
        ' 
        pnlDetalle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDetalle.BackColor = Color.White
        pnlDetalle.BorderStyle = BorderStyle.FixedSingle
        pnlDetalle.Controls.Add(pnlR01)
        pnlDetalle.Controls.Add(pnlR02)
        pnlDetalle.Controls.Add(pnlR03)
        pnlDetalle.Controls.Add(lblTituloReporte)
        pnlDetalle.Controls.Add(lblDescripcionReporte)
        pnlDetalle.Location = New Point(344, 108)
        pnlDetalle.Name = "pnlDetalle"
        pnlDetalle.Size = New Size(760, 540)
        pnlDetalle.TabIndex = 2
        ' 
        ' pnlR01
        ' 
        pnlR01.Controls.Add(lblNotaRecibo)
        pnlR01.Controls.Add(btnImprimirReciboCentro)
        pnlR01.Controls.Add(btnVistaPreviaRecibo)
        pnlR01.Controls.Add(cboPagos)
        pnlR01.Controls.Add(lblSeleccionRecibo)
        pnlR01.Location = New Point(24, 120)
        pnlR01.Name = "pnlR01"
        pnlR01.Size = New Size(700, 260)
        pnlR01.TabIndex = 2
        pnlR01.Visible = False
        ' 
        ' lblNotaRecibo
        ' 
        lblNotaRecibo.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNotaRecibo.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        lblNotaRecibo.Location = New Point(0, 136)
        lblNotaRecibo.Name = "lblNotaRecibo"
        lblNotaRecibo.Size = New Size(680, 70)
        lblNotaRecibo.TabIndex = 4
        lblNotaRecibo.Text = "El recibo se imprime en ticket de 80 mm con el número de comprobante de 6 dígitos, " & vbCrLf & "el monto en letras y la marca de agua ""ANULADO"" cuando el pago fue anulado."
        ' 
        ' btnImprimirReciboCentro
        ' 
        btnImprimirReciboCentro.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnImprimirReciboCentro.Cursor = Cursors.Hand
        btnImprimirReciboCentro.FlatAppearance.BorderSize = 0
        btnImprimirReciboCentro.FlatStyle = FlatStyle.Flat
        btnImprimirReciboCentro.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImprimirReciboCentro.ForeColor = Color.White
        btnImprimirReciboCentro.Location = New Point(222, 76)
        btnImprimirReciboCentro.Name = "btnImprimirReciboCentro"
        btnImprimirReciboCentro.Size = New Size(210, 44)
        btnImprimirReciboCentro.TabIndex = 3
        btnImprimirReciboCentro.Text = "Imprimir"
        btnImprimirReciboCentro.UseVisualStyleBackColor = False
        ' 
        ' btnVistaPreviaRecibo
        ' 
        btnVistaPreviaRecibo.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnVistaPreviaRecibo.Cursor = Cursors.Hand
        btnVistaPreviaRecibo.FlatAppearance.BorderSize = 0
        btnVistaPreviaRecibo.FlatStyle = FlatStyle.Flat
        btnVistaPreviaRecibo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVistaPreviaRecibo.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnVistaPreviaRecibo.Location = New Point(0, 76)
        btnVistaPreviaRecibo.Name = "btnVistaPreviaRecibo"
        btnVistaPreviaRecibo.Size = New Size(210, 44)
        btnVistaPreviaRecibo.TabIndex = 2
        btnVistaPreviaRecibo.Text = "Vista previa"
        btnVistaPreviaRecibo.UseVisualStyleBackColor = False
        ' 
        ' cboPagos
        ' 
        cboPagos.DropDownStyle = ComboBoxStyle.DropDownList
        cboPagos.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboPagos.FormattingEnabled = True
        cboPagos.Location = New Point(0, 26)
        cboPagos.Name = "cboPagos"
        cboPagos.Size = New Size(680, 29)
        cboPagos.TabIndex = 1
        ' 
        ' lblSeleccionRecibo
        ' 
        lblSeleccionRecibo.AutoSize = True
        lblSeleccionRecibo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSeleccionRecibo.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblSeleccionRecibo.Location = New Point(0, 0)
        lblSeleccionRecibo.Name = "lblSeleccionRecibo"
        lblSeleccionRecibo.Size = New Size(138, 20)
        lblSeleccionRecibo.TabIndex = 0
        lblSeleccionRecibo.Text = "Seleccione el pago:"
        ' 
        ' pnlR02
        ' 
        pnlR02.Controls.Add(lblNotaConstancia)
        pnlR02.Controls.Add(btnConfigurarPagina)
        pnlR02.Controls.Add(btnImprimirConstancia)
        pnlR02.Controls.Add(btnVistaPreviaConstancia)
        pnlR02.Controls.Add(cboSocios)
        pnlR02.Controls.Add(lblSeleccionSocio)
        pnlR02.Location = New Point(24, 120)
        pnlR02.Name = "pnlR02"
        pnlR02.Size = New Size(700, 260)
        pnlR02.TabIndex = 3
        pnlR02.Visible = False
        ' 
        ' lblNotaConstancia
        ' 
        lblNotaConstancia.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNotaConstancia.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        lblNotaConstancia.Location = New Point(0, 136)
        lblNotaConstancia.Name = "lblNotaConstancia"
        lblNotaConstancia.Size = New Size(680, 70)
        lblNotaConstancia.TabIndex = 5
        lblNotaConstancia.Text = "Se genera en papel tamaño Carta, orientación vertical. Use ""Configurar página"" para " & vbCrLf & "ajustar márgenes e impresora. Solo aparecen socios con membresía vigente."
        ' 
        ' btnConfigurarPagina
        ' 
        btnConfigurarPagina.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnConfigurarPagina.Cursor = Cursors.Hand
        btnConfigurarPagina.FlatAppearance.BorderSize = 0
        btnConfigurarPagina.FlatStyle = FlatStyle.Flat
        btnConfigurarPagina.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfigurarPagina.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnConfigurarPagina.Location = New Point(444, 76)
        btnConfigurarPagina.Name = "btnConfigurarPagina"
        btnConfigurarPagina.Size = New Size(210, 44)
        btnConfigurarPagina.TabIndex = 4
        btnConfigurarPagina.Text = "Configurar página"
        btnConfigurarPagina.UseVisualStyleBackColor = False
        ' 
        ' btnImprimirConstancia
        ' 
        btnImprimirConstancia.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnImprimirConstancia.Cursor = Cursors.Hand
        btnImprimirConstancia.FlatAppearance.BorderSize = 0
        btnImprimirConstancia.FlatStyle = FlatStyle.Flat
        btnImprimirConstancia.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImprimirConstancia.ForeColor = Color.White
        btnImprimirConstancia.Location = New Point(222, 76)
        btnImprimirConstancia.Name = "btnImprimirConstancia"
        btnImprimirConstancia.Size = New Size(210, 44)
        btnImprimirConstancia.TabIndex = 3
        btnImprimirConstancia.Text = "Imprimir"
        btnImprimirConstancia.UseVisualStyleBackColor = False
        ' 
        ' btnVistaPreviaConstancia
        ' 
        btnVistaPreviaConstancia.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnVistaPreviaConstancia.Cursor = Cursors.Hand
        btnVistaPreviaConstancia.FlatAppearance.BorderSize = 0
        btnVistaPreviaConstancia.FlatStyle = FlatStyle.Flat
        btnVistaPreviaConstancia.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVistaPreviaConstancia.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnVistaPreviaConstancia.Location = New Point(0, 76)
        btnVistaPreviaConstancia.Name = "btnVistaPreviaConstancia"
        btnVistaPreviaConstancia.Size = New Size(210, 44)
        btnVistaPreviaConstancia.TabIndex = 2
        btnVistaPreviaConstancia.Text = "Vista previa"
        btnVistaPreviaConstancia.UseVisualStyleBackColor = False
        ' 
        ' cboSocios
        ' 
        cboSocios.DropDownStyle = ComboBoxStyle.DropDownList
        cboSocios.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboSocios.FormattingEnabled = True
        cboSocios.Location = New Point(0, 26)
        cboSocios.Name = "cboSocios"
        cboSocios.Size = New Size(680, 29)
        cboSocios.TabIndex = 1
        ' 
        ' lblSeleccionSocio
        ' 
        lblSeleccionSocio.AutoSize = True
        lblSeleccionSocio.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSeleccionSocio.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblSeleccionSocio.Location = New Point(0, 0)
        lblSeleccionSocio.Name = "lblSeleccionSocio"
        lblSeleccionSocio.Size = New Size(297, 20)
        lblSeleccionSocio.TabIndex = 0
        lblSeleccionSocio.Text = "Seleccione el socio con membresía vigente:"
        ' 
        ' pnlR03
        ' 
        pnlR03.Controls.Add(btnAbrirListado)
        pnlR03.Controls.Add(lblInfoListado)
        pnlR03.Location = New Point(24, 120)
        pnlR03.Name = "pnlR03"
        pnlR03.Size = New Size(700, 260)
        pnlR03.TabIndex = 4
        pnlR03.Visible = False
        ' 
        ' btnAbrirListado
        ' 
        btnAbrirListado.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnAbrirListado.Cursor = Cursors.Hand
        btnAbrirListado.FlatAppearance.BorderSize = 0
        btnAbrirListado.FlatStyle = FlatStyle.Flat
        btnAbrirListado.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbrirListado.ForeColor = Color.White
        btnAbrirListado.Location = New Point(0, 110)
        btnAbrirListado.Name = "btnAbrirListado"
        btnAbrirListado.Size = New Size(280, 44)
        btnAbrirListado.TabIndex = 1
        btnAbrirListado.Text = "Abrir listado de vencimientos"
        btnAbrirListado.UseVisualStyleBackColor = False
        ' 
        ' lblInfoListado
        ' 
        lblInfoListado.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInfoListado.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblInfoListado.Location = New Point(0, 0)
        lblInfoListado.Name = "lblInfoListado"
        lblInfoListado.Size = New Size(680, 96)
        lblInfoListado.TabIndex = 0
        lblInfoListado.Text = resources.GetString("lblInfoListado.Text")
        ' 
        ' lblTituloReporte
        ' 
        lblTituloReporte.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloReporte.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTituloReporte.Location = New Point(24, 20)
        lblTituloReporte.Name = "lblTituloReporte"
        lblTituloReporte.Size = New Size(700, 30)
        lblTituloReporte.TabIndex = 0
        lblTituloReporte.Text = "Seleccione un reporte"
        ' 
        ' lblDescripcionReporte
        ' 
        lblDescripcionReporte.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescripcionReporte.ForeColor = Color.FromArgb(CByte(95), CByte(95), CByte(95))
        lblDescripcionReporte.Location = New Point(24, 54)
        lblDescripcionReporte.Name = "lblDescripcionReporte"
        lblDescripcionReporte.Size = New Size(700, 52)
        lblDescripcionReporte.TabIndex = 1
        lblDescripcionReporte.Text = "Elija un reporte del árbol de la izquierda."
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrar.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnCerrar.Location = New Point(996, 654)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(120, 38)
        btnCerrar.TabIndex = 3
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' stsEstado
        ' 
        stsEstado.ImageScalingSize = New Size(20, 20)
        stsEstado.Items.AddRange(New ToolStripItem() {lblEstadoCentro, lblUsuarioCentro})
        stsEstado.Location = New Point(0, 694)
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(1140, 26)
        stsEstado.TabIndex = 4
        ' 
        ' lblEstadoCentro
        ' 
        lblEstadoCentro.Name = "lblEstadoCentro"
        lblEstadoCentro.Size = New Size(994, 20)
        lblEstadoCentro.Spring = True
        lblEstadoCentro.Text = "Listo"
        lblEstadoCentro.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUsuarioCentro
        ' 
        lblUsuarioCentro.Name = "lblUsuarioCentro"
        lblUsuarioCentro.Size = New Size(131, 20)
        lblUsuarioCentro.Text = "Usuario: Sin sesión"
        lblUsuarioCentro.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' frmCentroReportes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        ClientSize = New Size(1140, 720)
        Controls.Add(stsEstado)
        Controls.Add(btnCerrar)
        Controls.Add(pnlDetalle)
        Controls.Add(tvReportes)
        Controls.Add(pnlEncabezado)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MinimumSize = New Size(1000, 640)
        Name = "frmCentroReportes"
        StartPosition = FormStartPosition.CenterParent
        Text = "GymControl - Centro de reportes"
        pnlEncabezado.ResumeLayout(False)
        pnlEncabezado.PerformLayout()
        pnlDetalle.ResumeLayout(False)
        pnlR01.ResumeLayout(False)
        pnlR01.PerformLayout()
        pnlR02.ResumeLayout(False)
        pnlR02.PerformLayout()
        pnlR03.ResumeLayout(False)
        stsEstado.ResumeLayout(False)
        stsEstado.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTituloCentro As System.Windows.Forms.Label
    Friend WithEvents lblSubtituloCentro As System.Windows.Forms.Label
    Friend WithEvents tvReportes As System.Windows.Forms.TreeView
    Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
    Friend WithEvents lblTituloReporte As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionReporte As System.Windows.Forms.Label
    Friend WithEvents pnlR01 As System.Windows.Forms.Panel
    Friend WithEvents lblSeleccionRecibo As System.Windows.Forms.Label
    Friend WithEvents cboPagos As System.Windows.Forms.ComboBox
    Friend WithEvents btnVistaPreviaRecibo As System.Windows.Forms.Button
    Friend WithEvents btnImprimirReciboCentro As System.Windows.Forms.Button
    Friend WithEvents lblNotaRecibo As System.Windows.Forms.Label
    Friend WithEvents pnlR02 As System.Windows.Forms.Panel
    Friend WithEvents lblSeleccionSocio As System.Windows.Forms.Label
    Friend WithEvents cboSocios As System.Windows.Forms.ComboBox
    Friend WithEvents btnVistaPreviaConstancia As System.Windows.Forms.Button
    Friend WithEvents btnImprimirConstancia As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarPagina As System.Windows.Forms.Button
    Friend WithEvents lblNotaConstancia As System.Windows.Forms.Label
    Friend WithEvents pnlR03 As System.Windows.Forms.Panel
    Friend WithEvents lblInfoListado As System.Windows.Forms.Label
    Friend WithEvents btnAbrirListado As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents stsEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEstadoCentro As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsuarioCentro As System.Windows.Forms.ToolStripStatusLabel
End Class

