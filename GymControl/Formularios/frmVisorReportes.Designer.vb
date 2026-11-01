<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorReportes
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento.
    'Se puede modificar usando el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlEncabezado = New Panel()
        Me.lblTituloVisor = New Label()
        Me.lblSubtituloVisor = New Label()
        Me.pnlFiltros = New Panel()
        Me.lblFechaInicio = New Label()
        Me.dtpFechaInicio = New DateTimePicker()
        Me.lblFechaFin = New Label()
        Me.dtpFechaFin = New DateTimePicker()
        Me.lblMetodo = New Label()
        Me.cboMetodo = New ComboBox()
        Me.lblSocio = New Label()
        Me.cboSocios = New ComboBox()
        Me.lblInfoSocio = New Label()
        Me.lblSala = New Label()
        Me.cboSala = New ComboBox()
        Me.lblInstructor = New Label()
        Me.cboInstructor = New ComboBox()
        Me.chkSoloActivos = New CheckBox()
        Me.btnGenerar = New Button()
        Me.btnImprimir = New Button()
        Me.btnCerrar = New Button()
        Me.pnlVisor = New Panel()
        Me.stsEstado = New StatusStrip()
        Me.lblEstadoVisor = New ToolStripStatusLabel()
        Me.lblSesionVisor = New ToolStripStatusLabel()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.stsEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Me.pnlEncabezado.Controls.Add(Me.lblSubtituloVisor)
        Me.pnlEncabezado.Controls.Add(Me.lblTituloVisor)
        Me.pnlEncabezado.Dock = DockStyle.Top
        Me.pnlEncabezado.Location = New Point(0, 0)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New Size(1220, 78)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTituloVisor
        '
        Me.lblTituloVisor.AutoSize = True
        Me.lblTituloVisor.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.lblTituloVisor.ForeColor = Color.White
        Me.lblTituloVisor.Location = New Point(22, 10)
        Me.lblTituloVisor.Name = "lblTituloVisor"
        Me.lblTituloVisor.Size = New Size(325, 41)
        Me.lblTituloVisor.TabIndex = 0
        Me.lblTituloVisor.Text = "Visor de reportes"
        '
        'lblSubtituloVisor
        '
        Me.lblSubtituloVisor.AutoSize = True
        Me.lblSubtituloVisor.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.lblSubtituloVisor.ForeColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        Me.lblSubtituloVisor.Location = New Point(26, 50)
        Me.lblSubtituloVisor.Name = "lblSubtituloVisor"
        Me.lblSubtituloVisor.Size = New Size(345, 20)
        Me.lblSubtituloVisor.TabIndex = 1
        Me.lblSubtituloVisor.Text = "Gimnasio Titán · Reportes R04, R05 y R06"
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = Color.FromArgb(CByte(231), CByte(236), CByte(243))
        Me.pnlFiltros.Controls.Add(Me.btnGenerar)
        Me.pnlFiltros.Controls.Add(Me.btnImprimir)
        Me.pnlFiltros.Controls.Add(Me.btnCerrar)
        Me.pnlFiltros.Controls.Add(Me.lblFechaInicio)
        Me.pnlFiltros.Controls.Add(Me.dtpFechaInicio)
        Me.pnlFiltros.Controls.Add(Me.lblFechaFin)
        Me.pnlFiltros.Controls.Add(Me.dtpFechaFin)
        Me.pnlFiltros.Controls.Add(Me.lblMetodo)
        Me.pnlFiltros.Controls.Add(Me.cboMetodo)
        Me.pnlFiltros.Controls.Add(Me.lblSocio)
        Me.pnlFiltros.Controls.Add(Me.cboSocios)
        Me.pnlFiltros.Controls.Add(Me.lblInfoSocio)
        Me.pnlFiltros.Controls.Add(Me.lblSala)
        Me.pnlFiltros.Controls.Add(Me.cboSala)
        Me.pnlFiltros.Controls.Add(Me.lblInstructor)
        Me.pnlFiltros.Controls.Add(Me.cboInstructor)
        Me.pnlFiltros.Controls.Add(Me.chkSoloActivos)
        Me.pnlFiltros.Dock = DockStyle.Top
        Me.pnlFiltros.Location = New Point(0, 78)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New Size(1220, 104)
        Me.pnlFiltros.TabIndex = 1
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New Point(18, 12)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New Size(82, 20)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha desde:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New Point(18, 38)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New Size(145, 27)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New Point(180, 12)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New Size(74, 20)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha hasta:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = DateTimePickerFormat.Short
        Me.dtpFechaFin.Location = New Point(180, 38)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New Size(145, 27)
        Me.dtpFechaFin.TabIndex = 3
        '
        'lblMetodo
        '
        Me.lblMetodo.AutoSize = True
        Me.lblMetodo.Location = New Point(342, 12)
        Me.lblMetodo.Name = "lblMetodo"
        Me.lblMetodo.Size = New Size(109, 20)
        Me.lblMetodo.TabIndex = 4
        Me.lblMetodo.Text = "Método de pago:"
        '
        'cboMetodo
        '
        Me.cboMetodo.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboMetodo.FormattingEnabled = True
        Me.cboMetodo.Location = New Point(342, 38)
        Me.cboMetodo.Name = "cboMetodo"
        Me.cboMetodo.Size = New Size(180, 28)
        Me.cboMetodo.TabIndex = 5
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Location = New Point(180, 12)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New Size(48, 20)
        Me.lblSocio.TabIndex = 6
        Me.lblSocio.Text = "Socio:"
        Me.lblSocio.Visible = False
        '
        'cboSocios
        '
        Me.cboSocios.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboSocios.FormattingEnabled = True
        Me.cboSocios.Location = New Point(180, 38)
        Me.cboSocios.Name = "cboSocios"
        Me.cboSocios.Size = New Size(470, 28)
        Me.cboSocios.TabIndex = 7
        Me.cboSocios.Visible = False
        '
        'lblInfoSocio
        '
        Me.lblInfoSocio.AutoSize = True
        Me.lblInfoSocio.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        Me.lblInfoSocio.Location = New Point(660, 42)
        Me.lblInfoSocio.Name = "lblInfoSocio"
        Me.lblInfoSocio.Size = New Size(0, 20)
        Me.lblInfoSocio.TabIndex = 8
        Me.lblInfoSocio.Visible = False
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Location = New Point(18, 12)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New Size(40, 20)
        Me.lblSala.TabIndex = 9
        Me.lblSala.Text = "Sala:"
        Me.lblSala.Visible = False
        '
        'cboSala
        '
        Me.cboSala.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboSala.FormattingEnabled = True
        Me.cboSala.Location = New Point(18, 38)
        Me.cboSala.Name = "cboSala"
        Me.cboSala.Size = New Size(220, 28)
        Me.cboSala.TabIndex = 10
        Me.cboSala.Visible = False
        '
        'lblInstructor
        '
        Me.lblInstructor.AutoSize = True
        Me.lblInstructor.Location = New Point(252, 12)
        Me.lblInstructor.Name = "lblInstructor"
        Me.lblInstructor.Size = New Size(74, 20)
        Me.lblInstructor.TabIndex = 11
        Me.lblInstructor.Text = "Instructor:"
        Me.lblInstructor.Visible = False
        '
        'cboInstructor
        '
        Me.cboInstructor.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboInstructor.FormattingEnabled = True
        Me.cboInstructor.Location = New Point(252, 38)
        Me.cboInstructor.Name = "cboInstructor"
        Me.cboInstructor.Size = New Size(280, 28)
        Me.cboInstructor.TabIndex = 12
        Me.cboInstructor.Visible = False
        '
        'chkSoloActivos
        '
        Me.chkSoloActivos.AutoSize = True
        Me.chkSoloActivos.Checked = True
        Me.chkSoloActivos.CheckState = CheckState.Checked
        Me.chkSoloActivos.Location = New Point(548, 42)
        Me.chkSoloActivos.Name = "chkSoloActivos"
        Me.chkSoloActivos.Size = New Size(130, 24)
        Me.chkSoloActivos.TabIndex = 13
        Me.chkSoloActivos.Text = "Solo activos"
        Me.chkSoloActivos.UseVisualStyleBackColor = True
        Me.chkSoloActivos.Visible = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btnGenerar.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        Me.btnGenerar.Cursor = Cursors.Hand
        Me.btnGenerar.FlatAppearance.BorderSize = 0
        Me.btnGenerar.FlatStyle = FlatStyle.Flat
        Me.btnGenerar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnGenerar.ForeColor = Color.White
        Me.btnGenerar.Location = New Point(760, 32)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New Size(140, 38)
        Me.btnGenerar.TabIndex = 14
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btnImprimir.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        Me.btnImprimir.Cursor = Cursors.Hand
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = FlatStyle.Flat
        Me.btnImprimir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnImprimir.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        Me.btnImprimir.Location = New Point(910, 32)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New Size(140, 38)
        Me.btnImprimir.TabIndex = 15
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btnCerrar.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        Me.btnCerrar.Cursor = Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = FlatStyle.Flat
        Me.btnCerrar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnCerrar.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        Me.btnCerrar.Location = New Point(1060, 32)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New Size(140, 38)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'pnlVisor
        '
        Me.pnlVisor.BackColor = Color.White
        Me.pnlVisor.Dock = DockStyle.Fill
        Me.pnlVisor.Location = New Point(0, 182)
        Me.pnlVisor.Name = "pnlVisor"
        Me.pnlVisor.Size = New Size(1220, 552)
        Me.pnlVisor.TabIndex = 2
        '
        'stsEstado
        '
        Me.stsEstado.ImageScalingSize = New Size(20, 20)
        Me.stsEstado.Items.AddRange(New ToolStripItem() {Me.lblEstadoVisor, Me.lblSesionVisor})
        Me.stsEstado.Location = New Point(0, 734)
        Me.stsEstado.Name = "stsEstado"
        Me.stsEstado.Size = New Size(1220, 26)
        Me.stsEstado.TabIndex = 3
        '
        'lblEstadoVisor
        '
        Me.lblEstadoVisor.Name = "lblEstadoVisor"
        Me.lblEstadoVisor.Size = New Size(1070, 20)
        Me.lblEstadoVisor.Spring = True
        Me.lblEstadoVisor.Text = "Listo"
        Me.lblEstadoVisor.TextAlign = ContentAlignment.MiddleLeft
        '
        'lblSesionVisor
        '
        Me.lblSesionVisor.Name = "lblSesionVisor"
        Me.lblSesionVisor.Size = New Size(135, 20)
        Me.lblSesionVisor.Text = "Usuario: Sin sesión"
        Me.lblSesionVisor.TextAlign = ContentAlignment.MiddleRight
        '
        'frmVisorReportes
        '
        Me.AutoScaleDimensions = New SizeF(8F, 20F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        Me.ClientSize = New Size(1220, 760)
        Me.Controls.Add(Me.pnlVisor)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.pnlEncabezado)
        Me.Controls.Add(Me.stsEstado)
        Me.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.MinimumSize = New Size(980, 620)
        Me.Name = "frmVisorReportes"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "GymControl - Visor de reportes"
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.stsEstado.ResumeLayout(False)
        Me.stsEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTituloVisor As System.Windows.Forms.Label
    Friend WithEvents lblSubtituloVisor As System.Windows.Forms.Label
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMetodo As System.Windows.Forms.Label
    Friend WithEvents cboMetodo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSocio As System.Windows.Forms.Label
    Friend WithEvents cboSocios As System.Windows.Forms.ComboBox
    Friend WithEvents lblInfoSocio As System.Windows.Forms.Label
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents cboSala As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstructor As System.Windows.Forms.Label
    Friend WithEvents cboInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents chkSoloActivos As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents pnlVisor As System.Windows.Forms.Panel
    Friend WithEvents stsEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEstadoVisor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSesionVisor As System.Windows.Forms.ToolStripStatusLabel
End Class
