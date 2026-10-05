<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPortalSocio
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
        pnlHeader = New Panel()
        btnCerrarSesion = New Button()
        btnCambiarContrasena = New Button()
        lblInfoAcceso = New Label()
        lblNombreSocio = New Label()
        lblAvatar = New Label()
        pnlMembresia = New Panel()
        lblNotaRenovacion = New Label()
        pgbDiasRestantes = New ProgressBar()
        lblDiasRestantes = New Label()
        lblValIncluye = New Label()
        lblValVence = New Label()
        lblValInicio = New Label()
        lblValTipo = New Label()
        lblMembresiaIncluye = New Label()
        lblMembresiaVence = New Label()
        lblMembresiaInicio = New Label()
        lblMembresiaTipo = New Label()
        lblEstadoMembresia = New Label()
        lblTituloMembresia = New Label()
        pnlCuenta = New Panel()
        lblValSaldo = New Label()
        lblValPagado = New Label()
        lblValTotal = New Label()
        lblSaldoCuenta = New Label()
        lblPagadoCuenta = New Label()
        lblTotalCuenta = New Label()
        lblTituloCuenta = New Label()
        lblTituloPagos = New Label()
        dgvMisPagos = New DataGridView()
        lblTituloClases = New Label()
        dgvClases = New DataGridView()
        stsSesion = New StatusStrip()
        lblStatusUsuario = New ToolStripStatusLabel()
        lblStatusRol = New ToolStripStatusLabel()
        lblStatusModo = New ToolStripStatusLabel()
        pnlHeader.SuspendLayout()
        pnlMembresia.SuspendLayout()
        pnlCuenta.SuspendLayout()
        CType(dgvMisPagos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvClases, ComponentModel.ISupportInitialize).BeginInit()
        stsSesion.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Black
        pnlHeader.Controls.Add(btnCerrarSesion)
        pnlHeader.Controls.Add(btnCambiarContrasena)
        pnlHeader.Controls.Add(lblInfoAcceso)
        pnlHeader.Controls.Add(lblNombreSocio)
        pnlHeader.Controls.Add(lblAvatar)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1000, 100)
        pnlHeader.TabIndex = 7
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(51))
        btnCerrarSesion.ForeColor = Color.White
        btnCerrarSesion.Location = New Point(820, 35)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(150, 35)
        btnCerrarSesion.TabIndex = 0
        btnCerrarSesion.Text = "Cerrar sesión"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnCambiarContrasena
        ' 
        btnCambiarContrasena.BackColor = Color.White
        btnCambiarContrasena.ForeColor = Color.Black
        btnCambiarContrasena.Location = New Point(650, 35)
        btnCambiarContrasena.Name = "btnCambiarContrasena"
        btnCambiarContrasena.Size = New Size(150, 35)
        btnCambiarContrasena.TabIndex = 1
        btnCambiarContrasena.Text = "Cambiar contraseña"
        btnCambiarContrasena.UseVisualStyleBackColor = False
        ' 
        ' lblInfoAcceso
        ' 
        lblInfoAcceso.AutoSize = True
        lblInfoAcceso.Font = New Font("Segoe UI", 9.0F)
        lblInfoAcceso.ForeColor = Color.LightGray
        lblInfoAcceso.Location = New Point(95, 60)
        lblInfoAcceso.Name = "lblInfoAcceso"
        lblInfoAcceso.Size = New Size(288, 20)
        lblInfoAcceso.TabIndex = 2
        lblInfoAcceso.Text = "Socio N.º 0 - Último acceso: --/--/---- --:--"
        ' 
        ' lblNombreSocio
        ' 
        lblNombreSocio.AutoSize = True
        lblNombreSocio.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblNombreSocio.ForeColor = Color.White
        lblNombreSocio.Location = New Point(90, 25)
        lblNombreSocio.Name = "lblNombreSocio"
        lblNombreSocio.Size = New Size(342, 37)
        lblNombreSocio.TabIndex = 3
        lblNombreSocio.Text = "Hola, [Nombre del Socio]"
        ' 
        ' lblAvatar
        ' 
        lblAvatar.BackColor = Color.FromArgb(CByte(71), CByte(98), CByte(130))
        lblAvatar.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblAvatar.ForeColor = Color.White
        lblAvatar.Location = New Point(20, 20)
        lblAvatar.Name = "lblAvatar"
        lblAvatar.Size = New Size(60, 60)
        lblAvatar.TabIndex = 4
        lblAvatar.Text = "??"
        lblAvatar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlMembresia
        ' 
        pnlMembresia.BackColor = Color.White
        pnlMembresia.BorderStyle = BorderStyle.FixedSingle
        pnlMembresia.Controls.Add(lblNotaRenovacion)
        pnlMembresia.Controls.Add(pgbDiasRestantes)
        pnlMembresia.Controls.Add(lblDiasRestantes)
        pnlMembresia.Controls.Add(lblValIncluye)
        pnlMembresia.Controls.Add(lblValVence)
        pnlMembresia.Controls.Add(lblValInicio)
        pnlMembresia.Controls.Add(lblValTipo)
        pnlMembresia.Controls.Add(lblMembresiaIncluye)
        pnlMembresia.Controls.Add(lblMembresiaVence)
        pnlMembresia.Controls.Add(lblMembresiaInicio)
        pnlMembresia.Controls.Add(lblMembresiaTipo)
        pnlMembresia.Controls.Add(lblEstadoMembresia)
        pnlMembresia.Controls.Add(lblTituloMembresia)
        pnlMembresia.Location = New Point(20, 120)
        pnlMembresia.Name = "pnlMembresia"
        pnlMembresia.Size = New Size(460, 200)
        pnlMembresia.TabIndex = 6
        ' 
        ' lblNotaRenovacion
        ' 
        lblNotaRenovacion.AutoSize = True
        lblNotaRenovacion.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblNotaRenovacion.ForeColor = Color.Gray
        lblNotaRenovacion.Location = New Point(15, 170)
        lblNotaRenovacion.Name = "lblNotaRenovacion"
        lblNotaRenovacion.Size = New Size(444, 19)
        lblNotaRenovacion.TabIndex = 0
        lblNotaRenovacion.Text = "Renueve en recepción antes del vencimiento para no perder el acceso."
        ' 
        ' pgbDiasRestantes
        ' 
        pgbDiasRestantes.Location = New Point(15, 145)
        pgbDiasRestantes.Name = "pgbDiasRestantes"
        pgbDiasRestantes.Size = New Size(425, 10)
        pgbDiasRestantes.Style = ProgressBarStyle.Continuous
        pgbDiasRestantes.TabIndex = 1
        ' 
        ' lblDiasRestantes
        ' 
        lblDiasRestantes.AutoSize = True
        lblDiasRestantes.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblDiasRestantes.ForeColor = Color.DarkOrange
        lblDiasRestantes.Location = New Point(15, 120)
        lblDiasRestantes.Name = "lblDiasRestantes"
        lblDiasRestantes.Size = New Size(153, 20)
        lblDiasRestantes.TabIndex = 2
        lblDiasRestantes.Text = "Días restantes: - de -"
        ' 
        ' lblValIncluye
        ' 
        lblValIncluye.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblValIncluye.Location = New Point(340, 80)
        lblValIncluye.Name = "lblValIncluye"
        lblValIncluye.Size = New Size(100, 23)
        lblValIncluye.TabIndex = 3
        lblValIncluye.Text = "-"
        ' 
        ' lblValVence
        ' 
        lblValVence.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblValVence.Location = New Point(220, 80)
        lblValVence.Name = "lblValVence"
        lblValVence.Size = New Size(100, 23)
        lblValVence.TabIndex = 4
        lblValVence.Text = "--/--/----"
        ' 
        ' lblValInicio
        ' 
        lblValInicio.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblValInicio.Location = New Point(120, 80)
        lblValInicio.Name = "lblValInicio"
        lblValInicio.Size = New Size(100, 23)
        lblValInicio.TabIndex = 5
        lblValInicio.Text = "--/--/----"
        ' 
        ' lblValTipo
        ' 
        lblValTipo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblValTipo.Location = New Point(15, 80)
        lblValTipo.Name = "lblValTipo"
        lblValTipo.Size = New Size(100, 23)
        lblValTipo.TabIndex = 6
        lblValTipo.Text = "-"
        ' 
        ' lblMembresiaIncluye
        ' 
        lblMembresiaIncluye.Location = New Point(340, 60)
        lblMembresiaIncluye.Name = "lblMembresiaIncluye"
        lblMembresiaIncluye.Size = New Size(100, 23)
        lblMembresiaIncluye.TabIndex = 7
        lblMembresiaIncluye.Text = "Incluye clases"
        ' 
        ' lblMembresiaVence
        ' 
        lblMembresiaVence.Location = New Point(220, 60)
        lblMembresiaVence.Name = "lblMembresiaVence"
        lblMembresiaVence.Size = New Size(100, 23)
        lblMembresiaVence.TabIndex = 8
        lblMembresiaVence.Text = "Vence"
        ' 
        ' lblMembresiaInicio
        ' 
        lblMembresiaInicio.Location = New Point(120, 60)
        lblMembresiaInicio.Name = "lblMembresiaInicio"
        lblMembresiaInicio.Size = New Size(100, 23)
        lblMembresiaInicio.TabIndex = 9
        lblMembresiaInicio.Text = "Inicio"
        ' 
        ' lblMembresiaTipo
        ' 
        lblMembresiaTipo.Location = New Point(15, 60)
        lblMembresiaTipo.Name = "lblMembresiaTipo"
        lblMembresiaTipo.Size = New Size(100, 23)
        lblMembresiaTipo.TabIndex = 10
        lblMembresiaTipo.Text = "Tipo"
        ' 
        ' lblEstadoMembresia
        ' 
        lblEstadoMembresia.BackColor = Color.LightGreen
        lblEstadoMembresia.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblEstadoMembresia.ForeColor = Color.DarkGreen
        lblEstadoMembresia.Location = New Point(340, 15)
        lblEstadoMembresia.Name = "lblEstadoMembresia"
        lblEstadoMembresia.Size = New Size(100, 25)
        lblEstadoMembresia.TabIndex = 11
        lblEstadoMembresia.Text = "[ESTADO]"
        lblEstadoMembresia.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTituloMembresia
        ' 
        lblTituloMembresia.AutoSize = True
        lblTituloMembresia.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTituloMembresia.Location = New Point(15, 15)
        lblTituloMembresia.Name = "lblTituloMembresia"
        lblTituloMembresia.Size = New Size(147, 28)
        lblTituloMembresia.TabIndex = 12
        lblTituloMembresia.Text = "Mi membresía"
        ' 
        ' pnlCuenta
        ' 
        pnlCuenta.BackColor = Color.White
        pnlCuenta.BorderStyle = BorderStyle.FixedSingle
        pnlCuenta.Controls.Add(lblValSaldo)
        pnlCuenta.Controls.Add(lblValPagado)
        pnlCuenta.Controls.Add(lblValTotal)
        pnlCuenta.Controls.Add(lblSaldoCuenta)
        pnlCuenta.Controls.Add(lblPagadoCuenta)
        pnlCuenta.Controls.Add(lblTotalCuenta)
        pnlCuenta.Controls.Add(lblTituloCuenta)
        pnlCuenta.Location = New Point(500, 120)
        pnlCuenta.Name = "pnlCuenta"
        pnlCuenta.Size = New Size(470, 200)
        pnlCuenta.TabIndex = 5
        ' 
        ' lblValSaldo
        ' 
        lblValSaldo.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblValSaldo.ForeColor = Color.Red
        lblValSaldo.Location = New Point(320, 140)
        lblValSaldo.Name = "lblValSaldo"
        lblValSaldo.Size = New Size(130, 20)
        lblValSaldo.TabIndex = 0
        lblValSaldo.Text = "C$ 0.00"
        lblValSaldo.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblValPagado
        ' 
        lblValPagado.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblValPagado.ForeColor = Color.Green
        lblValPagado.Location = New Point(320, 100)
        lblValPagado.Name = "lblValPagado"
        lblValPagado.Size = New Size(130, 20)
        lblValPagado.TabIndex = 1
        lblValPagado.Text = "C$ 0.00"
        lblValPagado.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblValTotal
        ' 
        lblValTotal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblValTotal.Location = New Point(320, 60)
        lblValTotal.Name = "lblValTotal"
        lblValTotal.Size = New Size(130, 20)
        lblValTotal.TabIndex = 2
        lblValTotal.Text = "C$ 0.00"
        lblValTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSaldoCuenta
        ' 
        lblSaldoCuenta.Location = New Point(15, 140)
        lblSaldoCuenta.Name = "lblSaldoCuenta"
        lblSaldoCuenta.Size = New Size(100, 23)
        lblSaldoCuenta.TabIndex = 3
        lblSaldoCuenta.Text = "Saldo pendiente"
        ' 
        ' lblPagadoCuenta
        ' 
        lblPagadoCuenta.Location = New Point(15, 100)
        lblPagadoCuenta.Name = "lblPagadoCuenta"
        lblPagadoCuenta.Size = New Size(100, 23)
        lblPagadoCuenta.TabIndex = 4
        lblPagadoCuenta.Text = "Pagado"
        ' 
        ' lblTotalCuenta
        ' 
        lblTotalCuenta.Location = New Point(15, 60)
        lblTotalCuenta.Name = "lblTotalCuenta"
        lblTotalCuenta.Size = New Size(100, 23)
        lblTotalCuenta.TabIndex = 5
        lblTotalCuenta.Text = "Total membresía"
        ' 
        ' lblTituloCuenta
        ' 
        lblTituloCuenta.AutoSize = True
        lblTituloCuenta.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTituloCuenta.Location = New Point(15, 15)
        lblTituloCuenta.Name = "lblTituloCuenta"
        lblTituloCuenta.Size = New Size(174, 28)
        lblTituloCuenta.TabIndex = 6
        lblTituloCuenta.Text = "Estado de cuenta"
        ' 
        ' lblTituloPagos
        ' 
        lblTituloPagos.AutoSize = True
        lblTituloPagos.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTituloPagos.Location = New Point(20, 340)
        lblTituloPagos.Name = "lblTituloPagos"
        lblTituloPagos.Size = New Size(91, 23)
        lblTituloPagos.TabIndex = 4
        lblTituloPagos.Text = "Mis pagos"
        ' 
        ' dgvMisPagos
        ' 
        dgvMisPagos.BackgroundColor = Color.White
        dgvMisPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMisPagos.Location = New Point(20, 370)
        dgvMisPagos.Name = "dgvMisPagos"
        dgvMisPagos.ReadOnly = True
        dgvMisPagos.RowHeadersVisible = False
        dgvMisPagos.RowHeadersWidth = 51
        dgvMisPagos.Size = New Size(460, 200)
        dgvMisPagos.TabIndex = 3
        ' 
        ' lblTituloClases
        ' 
        lblTituloClases.AutoSize = True
        lblTituloClases.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTituloClases.Location = New Point(500, 340)
        lblTituloClases.Name = "lblTituloClases"
        lblTituloClases.Size = New Size(256, 23)
        lblTituloClases.TabIndex = 2
        lblTituloClases.Text = "Clases disponibles esta semana"
        ' 
        ' dgvClases
        ' 
        dgvClases.BackgroundColor = Color.White
        dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClases.Location = New Point(500, 370)
        dgvClases.Name = "dgvClases"
        dgvClases.ReadOnly = True
        dgvClases.RowHeadersVisible = False
        dgvClases.RowHeadersWidth = 51
        dgvClases.Size = New Size(470, 200)
        dgvClases.TabIndex = 1
        ' 
        ' stsSesion
        ' 
        stsSesion.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        stsSesion.ImageScalingSize = New Size(20, 20)
        stsSesion.Items.AddRange(New ToolStripItem() {lblStatusUsuario, lblStatusRol, lblStatusModo})
        stsSesion.Location = New Point(0, 585)
        stsSesion.Name = "stsSesion"
        stsSesion.Size = New Size(1000, 30)
        stsSesion.TabIndex = 0
        ' 
        ' lblStatusUsuario
        ' 
        lblStatusUsuario.Name = "lblStatusUsuario"
        lblStatusUsuario.Size = New Size(72, 24)
        lblStatusUsuario.Text = "Usuario: -"
        ' 
        ' lblStatusRol
        ' 
        lblStatusRol.BorderSides = ToolStripStatusLabelBorderSides.Left
        lblStatusRol.Name = "lblStatusRol"
        lblStatusRol.Size = New Size(79, 24)
        lblStatusRol.Text = "Rol: Socio"
        ' 
        ' lblStatusModo
        ' 
        lblStatusModo.BorderSides = ToolStripStatusLabelBorderSides.Left
        lblStatusModo.Name = "lblStatusModo"
        lblStatusModo.Size = New Size(137, 24)
        lblStatusModo.Text = "Modo: solo lectura"
        ' 
        ' frmPortalSocio
        ' 
        ClientSize = New Size(1000, 615)
        Controls.Add(stsSesion)
        Controls.Add(dgvClases)
        Controls.Add(lblTituloClases)
        Controls.Add(dgvMisPagos)
        Controls.Add(lblTituloPagos)
        Controls.Add(pnlCuenta)
        Controls.Add(pnlMembresia)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        Name = "frmPortalSocio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Portal del socio — Mi membresía"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlMembresia.ResumeLayout(False)
        pnlMembresia.PerformLayout()
        pnlCuenta.ResumeLayout(False)
        pnlCuenta.PerformLayout()
        CType(dgvMisPagos, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvClases, ComponentModel.ISupportInitialize).EndInit()
        stsSesion.ResumeLayout(False)
        stsSesion.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Declaraciones de controles[cite: 9]
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblAvatar As System.Windows.Forms.Label
    Friend WithEvents lblNombreSocio As System.Windows.Forms.Label
    Friend WithEvents lblInfoAcceso As System.Windows.Forms.Label
    Friend WithEvents btnCambiarContrasena As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents pnlMembresia As System.Windows.Forms.Panel
    Friend WithEvents lblTituloMembresia As System.Windows.Forms.Label
    Friend WithEvents lblEstadoMembresia As System.Windows.Forms.Label
    Friend WithEvents lblMembresiaTipo As System.Windows.Forms.Label
    Friend WithEvents lblMembresiaInicio As System.Windows.Forms.Label
    Friend WithEvents lblMembresiaVence As System.Windows.Forms.Label
    Friend WithEvents lblMembresiaIncluye As System.Windows.Forms.Label
    Friend WithEvents lblValTipo As System.Windows.Forms.Label
    Friend WithEvents lblValInicio As System.Windows.Forms.Label
    Friend WithEvents lblValVence As System.Windows.Forms.Label
    Friend WithEvents lblValIncluye As System.Windows.Forms.Label
    Friend WithEvents lblDiasRestantes As System.Windows.Forms.Label
    Friend WithEvents pgbDiasRestantes As System.Windows.Forms.ProgressBar
    Friend WithEvents lblNotaRenovacion As System.Windows.Forms.Label
    Friend WithEvents pnlCuenta As System.Windows.Forms.Panel
    Friend WithEvents lblTituloCuenta As System.Windows.Forms.Label
    Friend WithEvents lblTotalCuenta As System.Windows.Forms.Label
    Friend WithEvents lblPagadoCuenta As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCuenta As System.Windows.Forms.Label
    Friend WithEvents lblValTotal As System.Windows.Forms.Label
    Friend WithEvents lblValPagado As System.Windows.Forms.Label
    Friend WithEvents lblValSaldo As System.Windows.Forms.Label
    Friend WithEvents lblTituloPagos As System.Windows.Forms.Label
    Friend WithEvents dgvMisPagos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTituloClases As System.Windows.Forms.Label
    Friend WithEvents dgvClases As System.Windows.Forms.DataGridView
    Friend WithEvents stsSesion As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatusUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusRol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusModo As System.Windows.Forms.ToolStripStatusLabel

End Class
