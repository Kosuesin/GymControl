<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHorarios
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblFiltroInstructor = New Label()
        cboFiltroInstructor = New ComboBox()
        lblFiltroSala = New Label()
        cboFiltroSala = New ComboBox()
        btnFiltrar = New Button()
        btnImprimirSemana = New Button()
        dgvHorario = New DataGridView()
        grpDetalle = New GroupBox()
        btnEliminar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        chkActivo = New CheckBox()
        dtpHoraFin = New DateTimePicker()
        lblHoraFin = New Label()
        dtpHoraInicio = New DateTimePicker()
        lblHoraInicio = New Label()
        cboDia = New ComboBox()
        lblDia = New Label()
        cboSala = New ComboBox()
        lblSala = New Label()
        cboActividad = New ComboBox()
        lblActividad = New Label()
        cboInstructor = New ComboBox()
        lblInstructor = New Label()
        lblLeyendaBoxeo = New Label()
        lblLeyendaCrossFit = New Label()
        lblLeyendaFuncional = New Label()
        lblLeyendaZumba = New Label()
        lblLeyendaYoga = New Label()
        lblLeyendaSpinning = New Label()
        grpLeyenda = New GroupBox()
        CType(dgvHorario, ComponentModel.ISupportInitialize).BeginInit()
        grpDetalle.SuspendLayout()
        grpLeyenda.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFiltroInstructor
        ' 
        lblFiltroInstructor.AutoSize = True
        lblFiltroInstructor.Location = New Point(12, 17)
        lblFiltroInstructor.Name = "lblFiltroInstructor"
        lblFiltroInstructor.Size = New Size(74, 20)
        lblFiltroInstructor.TabIndex = 12
        lblFiltroInstructor.Text = "Instructor:"
        ' 
        ' cboFiltroInstructor
        ' 
        cboFiltroInstructor.FormattingEnabled = True
        cboFiltroInstructor.Location = New Point(92, 13)
        cboFiltroInstructor.Name = "cboFiltroInstructor"
        cboFiltroInstructor.Size = New Size(180, 28)
        cboFiltroInstructor.TabIndex = 11
        cboFiltroInstructor.Text = "Todos"
        ' 
        ' lblFiltroSala
        ' 
        lblFiltroSala.AutoSize = True
        lblFiltroSala.Location = New Point(290, 17)
        lblFiltroSala.Name = "lblFiltroSala"
        lblFiltroSala.Size = New Size(40, 20)
        lblFiltroSala.TabIndex = 10
        lblFiltroSala.Text = "Sala:"
        ' 
        ' cboFiltroSala
        ' 
        cboFiltroSala.FormattingEnabled = True
        cboFiltroSala.Location = New Point(336, 13)
        cboFiltroSala.Name = "cboFiltroSala"
        cboFiltroSala.Size = New Size(150, 28)
        cboFiltroSala.TabIndex = 9
        cboFiltroSala.Text = "Todas"
        ' 
        ' btnFiltrar
        ' 
        btnFiltrar.Location = New Point(500, 12)
        btnFiltrar.Name = "btnFiltrar"
        btnFiltrar.Size = New Size(90, 30)
        btnFiltrar.TabIndex = 8
        btnFiltrar.Text = "Filtrar"
        ' 
        ' btnImprimirSemana
        ' 
        btnImprimirSemana.Location = New Point(600, 12)
        btnImprimirSemana.Name = "btnImprimirSemana"
        btnImprimirSemana.Size = New Size(130, 30)
        btnImprimirSemana.TabIndex = 7
        btnImprimirSemana.Text = "Imprimir semana"
        ' 
        ' dgvHorario
        ' 
        dgvHorario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvHorario.DefaultCellStyle = DataGridViewCellStyle2
        dgvHorario.Location = New Point(12, 58)
        dgvHorario.Name = "dgvHorario"
        dgvHorario.RowHeadersWidth = 51
        dgvHorario.Size = New Size(730, 700)
        dgvHorario.TabIndex = 6
        ' 
        ' grpDetalle
        ' 
        grpDetalle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        grpDetalle.Controls.Add(btnEliminar)
        grpDetalle.Controls.Add(btnGuardar)
        grpDetalle.Controls.Add(btnNuevo)
        grpDetalle.Controls.Add(chkActivo)
        grpDetalle.Controls.Add(dtpHoraFin)
        grpDetalle.Controls.Add(lblHoraFin)
        grpDetalle.Controls.Add(dtpHoraInicio)
        grpDetalle.Controls.Add(lblHoraInicio)
        grpDetalle.Controls.Add(cboDia)
        grpDetalle.Controls.Add(lblDia)
        grpDetalle.Controls.Add(cboSala)
        grpDetalle.Controls.Add(lblSala)
        grpDetalle.Controls.Add(cboActividad)
        grpDetalle.Controls.Add(lblActividad)
        grpDetalle.Controls.Add(cboInstructor)
        grpDetalle.Controls.Add(lblInstructor)
        grpDetalle.Location = New Point(760, 58)
        grpDetalle.Name = "grpDetalle"
        grpDetalle.Size = New Size(370, 390)
        grpDetalle.TabIndex = 2
        grpDetalle.TabStop = False
        grpDetalle.Text = "Detalle del horario"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(51))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(250, 330)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(100, 35)
        btnEliminar.TabIndex = 0
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(130, 330)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(110, 35)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.White
        btnNuevo.Location = New Point(20, 330)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(100, 35)
        btnNuevo.TabIndex = 2
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = CheckState.Checked
        chkActivo.Location = New Point(24, 285)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(73, 24)
        chkActivo.TabIndex = 3
        chkActivo.Text = "Activo"
        ' 
        ' dtpHoraFin
        ' 
        dtpHoraFin.Format = DateTimePickerFormat.Time
        dtpHoraFin.Location = New Point(110, 237)
        dtpHoraFin.Name = "dtpHoraFin"
        dtpHoraFin.ShowUpDown = True
        dtpHoraFin.Size = New Size(240, 27)
        dtpHoraFin.TabIndex = 4
        ' 
        ' lblHoraFin
        ' 
        lblHoraFin.AutoSize = True
        lblHoraFin.Location = New Point(20, 240)
        lblHoraFin.Name = "lblHoraFin"
        lblHoraFin.Size = New Size(66, 20)
        lblHoraFin.TabIndex = 5
        lblHoraFin.Text = "Hora fin:"
        ' 
        ' dtpHoraInicio
        ' 
        dtpHoraInicio.Format = DateTimePickerFormat.Time
        dtpHoraInicio.Location = New Point(110, 197)
        dtpHoraInicio.Name = "dtpHoraInicio"
        dtpHoraInicio.ShowUpDown = True
        dtpHoraInicio.Size = New Size(240, 27)
        dtpHoraInicio.TabIndex = 6
        ' 
        ' lblHoraInicio
        ' 
        lblHoraInicio.AutoSize = True
        lblHoraInicio.Location = New Point(20, 200)
        lblHoraInicio.Name = "lblHoraInicio"
        lblHoraInicio.Size = New Size(85, 20)
        lblHoraInicio.TabIndex = 7
        lblHoraInicio.Text = "Hora inicio:"
        ' 
        ' cboDia
        ' 
        cboDia.Location = New Point(110, 157)
        cboDia.Name = "cboDia"
        cboDia.Size = New Size(240, 28)
        cboDia.TabIndex = 8
        ' 
        ' lblDia
        ' 
        lblDia.AutoSize = True
        lblDia.Location = New Point(20, 160)
        lblDia.Name = "lblDia"
        lblDia.Size = New Size(32, 20)
        lblDia.TabIndex = 9
        lblDia.Text = "Día"
        ' 
        ' cboSala
        ' 
        cboSala.Location = New Point(110, 117)
        cboSala.Name = "cboSala"
        cboSala.Size = New Size(240, 28)
        cboSala.TabIndex = 10
        ' 
        ' lblSala
        ' 
        lblSala.AutoSize = True
        lblSala.Location = New Point(20, 120)
        lblSala.Name = "lblSala"
        lblSala.Size = New Size(40, 20)
        lblSala.TabIndex = 11
        lblSala.Text = "Sala:"
        ' 
        ' cboActividad
        ' 
        cboActividad.Location = New Point(110, 77)
        cboActividad.Name = "cboActividad"
        cboActividad.Size = New Size(240, 28)
        cboActividad.TabIndex = 12
        ' 
        ' lblActividad
        ' 
        lblActividad.AutoSize = True
        lblActividad.Location = New Point(20, 80)
        lblActividad.Name = "lblActividad"
        lblActividad.Size = New Size(75, 20)
        lblActividad.TabIndex = 13
        lblActividad.Text = "Actividad:"
        ' 
        ' cboInstructor
        ' 
        cboInstructor.Location = New Point(110, 37)
        cboInstructor.Name = "cboInstructor"
        cboInstructor.Size = New Size(240, 28)
        cboInstructor.TabIndex = 14
        ' 
        ' lblInstructor
        ' 
        lblInstructor.AutoSize = True
        lblInstructor.Location = New Point(20, 40)
        lblInstructor.Name = "lblInstructor"
        lblInstructor.Size = New Size(74, 20)
        lblInstructor.TabIndex = 15
        lblInstructor.Text = "Instructor:"
        ' 
        ' lblLeyendaBoxeo
        ' 
        lblLeyendaBoxeo.AutoSize = True
        lblLeyendaBoxeo.Location = New Point(200, 120)
        lblLeyendaBoxeo.Name = "lblLeyendaBoxeo"
        lblLeyendaBoxeo.Size = New Size(51, 20)
        lblLeyendaBoxeo.TabIndex = 5
        lblLeyendaBoxeo.Text = "Boxeo"
        ' 
        ' lblLeyendaCrossFit
        ' 
        lblLeyendaCrossFit.AutoSize = True
        lblLeyendaCrossFit.Location = New Point(200, 80)
        lblLeyendaCrossFit.Name = "lblLeyendaCrossFit"
        lblLeyendaCrossFit.Size = New Size(60, 20)
        lblLeyendaCrossFit.TabIndex = 4
        lblLeyendaCrossFit.Text = "CrossFit"
        ' 
        ' lblLeyendaFuncional
        ' 
        lblLeyendaFuncional.AutoSize = True
        lblLeyendaFuncional.Location = New Point(200, 40)
        lblLeyendaFuncional.Name = "lblLeyendaFuncional"
        lblLeyendaFuncional.Size = New Size(72, 20)
        lblLeyendaFuncional.TabIndex = 3
        lblLeyendaFuncional.Text = "Funcional"
        ' 
        ' lblLeyendaZumba
        ' 
        lblLeyendaZumba.AutoSize = True
        lblLeyendaZumba.Location = New Point(40, 120)
        lblLeyendaZumba.Name = "lblLeyendaZumba"
        lblLeyendaZumba.Size = New Size(56, 20)
        lblLeyendaZumba.TabIndex = 2
        lblLeyendaZumba.Text = "Zumba"
        ' 
        ' lblLeyendaYoga
        ' 
        lblLeyendaYoga.AutoSize = True
        lblLeyendaYoga.Location = New Point(40, 80)
        lblLeyendaYoga.Name = "lblLeyendaYoga"
        lblLeyendaYoga.Size = New Size(42, 20)
        lblLeyendaYoga.TabIndex = 1
        lblLeyendaYoga.Text = "Yoga"
        ' 
        ' lblLeyendaSpinning
        ' 
        lblLeyendaSpinning.AutoSize = True
        lblLeyendaSpinning.Location = New Point(40, 40)
        lblLeyendaSpinning.Name = "lblLeyendaSpinning"
        lblLeyendaSpinning.Size = New Size(67, 20)
        lblLeyendaSpinning.TabIndex = 0
        lblLeyendaSpinning.Text = "Spinning"
        ' 
        ' grpLeyenda
        ' 
        grpLeyenda.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        grpLeyenda.Controls.Add(lblLeyendaSpinning)
        grpLeyenda.Controls.Add(lblLeyendaYoga)
        grpLeyenda.Controls.Add(lblLeyendaZumba)
        grpLeyenda.Controls.Add(lblLeyendaFuncional)
        grpLeyenda.Controls.Add(lblLeyendaCrossFit)
        grpLeyenda.Controls.Add(lblLeyendaBoxeo)
        grpLeyenda.FlatStyle = FlatStyle.Flat
        grpLeyenda.Location = New Point(760, 492)
        grpLeyenda.Name = "grpLeyenda"
        grpLeyenda.Size = New Size(370, 188)
        grpLeyenda.TabIndex = 0
        grpLeyenda.TabStop = False
        grpLeyenda.Text = "Actividades"
        ' 
        ' frmHorarios
        ' 
        ClientSize = New Size(1150, 770)
        Controls.Add(grpLeyenda)
        Controls.Add(grpDetalle)
        Controls.Add(dgvHorario)
        Controls.Add(btnImprimirSemana)
        Controls.Add(btnFiltrar)
        Controls.Add(cboFiltroSala)
        Controls.Add(lblFiltroSala)
        Controls.Add(cboFiltroInstructor)
        Controls.Add(lblFiltroInstructor)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1000, 700)
        Name = "frmHorarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Horarios de instructores"
        CType(dgvHorario, ComponentModel.ISupportInitialize).EndInit()
        grpDetalle.ResumeLayout(False)
        grpDetalle.PerformLayout()
        grpLeyenda.ResumeLayout(False)
        grpLeyenda.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Variables globales
    Friend WithEvents lblFiltroInstructor As System.Windows.Forms.Label
    Friend WithEvents cboFiltroInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents lblFiltroSala As System.Windows.Forms.Label
    Friend WithEvents cboFiltroSala As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnImprimirSemana As System.Windows.Forms.Button
    Friend WithEvents dgvHorario As System.Windows.Forms.DataGridView
    Friend WithEvents grpDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents lblInstructor As System.Windows.Forms.Label
    Friend WithEvents cboInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents cboActividad As System.Windows.Forms.ComboBox
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents cboSala As System.Windows.Forms.ComboBox
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents cboDia As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoraInicio As System.Windows.Forms.Label
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoraFin As System.Windows.Forms.Label
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button

    ' Metodo auxiliar opcional para quitar el borde de la leyenda y hacerlo ver limpio como en tu mock.
    Private Sub DisableGroupBoxBorder(sender As Object, e As PaintEventArgs)
        Dim tSize As Size = TextRenderer.MeasureText(DirectCast(sender, GroupBox).Text, DirectCast(sender, GroupBox).Font)
        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y += tSize.Height / 2
        borderRect.Height -= tSize.Height / 2
        ControlPaint.DrawBorder(e.Graphics, borderRect, Me.BackColor, ButtonBorderStyle.Solid)
    End Sub

    Friend WithEvents lblLeyendaBoxeo As Label
    Friend WithEvents lblLeyendaCrossFit As Label
    Friend WithEvents lblLeyendaFuncional As Label
    Friend WithEvents lblLeyendaZumba As Label
    Friend WithEvents lblLeyendaYoga As Label
    Friend WithEvents lblLeyendaSpinning As Label
    Friend WithEvents grpLeyenda As GroupBox

End Class