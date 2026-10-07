<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblSubtitulo = New Label()
        lblUsuario = New Label()
        txtUsuario = New TextBox()
        lblContrasena = New Label()
        txtContrasena = New TextBox()
        chkMostrar = New CheckBox()
        btnIngresar = New Button()
        btnSalir = New Button()
        lblMensaje = New Label()
        stsConexion = New StatusStrip()
        lblConexion = New ToolStripStatusLabel()
        pnlLogin = New Panel()
        stsConexion.SuspendLayout()
        pnlLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTitulo.Location = New Point(48, 35)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(338, 61)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "GymControl"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubtitulo
        ' 
        lblSubtitulo.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSubtitulo.Location = New Point(48, 99)
        lblSubtitulo.Name = "lblSubtitulo"
        lblSubtitulo.Size = New Size(338, 25)
        lblSubtitulo.TabIndex = 1
        lblSubtitulo.Text = "Sistema de gestión de gimnasio"
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsuario
        ' 
        lblUsuario.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        lblUsuario.Location = New Point(48, 152)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(338, 25)
        lblUsuario.TabIndex = 1
        lblUsuario.Text = "Usuario"
        lblUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.White
        txtUsuario.BorderStyle = BorderStyle.FixedSingle
        txtUsuario.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtUsuario.Location = New Point(48, 181)
        txtUsuario.Margin = New Padding(3, 4, 3, 4)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(338, 30)
        txtUsuario.TabIndex = 2
        ' 
        ' lblContrasena
        ' 
        lblContrasena.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContrasena.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        lblContrasena.Location = New Point(48, 237)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(338, 25)
        lblContrasena.TabIndex = 3
        lblContrasena.Text = "Contraseña"
        lblContrasena.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtContrasena
        ' 
        txtContrasena.BackColor = Color.White
        txtContrasena.BorderStyle = BorderStyle.FixedSingle
        txtContrasena.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContrasena.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtContrasena.Location = New Point(48, 267)
        txtContrasena.Margin = New Padding(3, 4, 3, 4)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(338, 30)
        txtContrasena.TabIndex = 4
        txtContrasena.UseSystemPasswordChar = True
        ' 
        ' chkMostrar
        ' 
        chkMostrar.AutoSize = True
        chkMostrar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMostrar.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        chkMostrar.Location = New Point(48, 320)
        chkMostrar.Margin = New Padding(3, 4, 3, 4)
        chkMostrar.Name = "chkMostrar"
        chkMostrar.Size = New Size(180, 27)
        chkMostrar.TabIndex = 5
        chkMostrar.Text = "Mostrar contraseña"
        chkMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnIngresar.Cursor = Cursors.Hand
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(61), CByte(96), CByte(135))
        btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(68), CByte(107), CByte(152))
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(48, 404)
        btnIngresar.Margin = New Padding(3, 4, 3, 4)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(338, 53)
        btnIngresar.TabIndex = 6
        btnIngresar.Text = "Iniciar sesión"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(240))
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(221), CByte(227))
        btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(222), CByte(229), CByte(234))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnSalir.Location = New Point(48, 471)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(338, 53)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoEllipsis = True
        lblMensaje.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMensaje.ForeColor = Color.FromArgb(CByte(198), CByte(40), CByte(40))
        lblMensaje.Location = New Point(48, 365)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(338, 25)
        lblMensaje.TabIndex = 8
        lblMensaje.TextAlign = ContentAlignment.MiddleLeft
        lblMensaje.Visible = False
        ' 
        ' stsConexion
        ' 
        stsConexion.ImageScalingSize = New Size(20, 20)
        stsConexion.Items.AddRange(New ToolStripItem() {lblConexion})
        stsConexion.Location = New Point(0, 589)
        stsConexion.Name = "stsConexion"
        stsConexion.Padding = New Padding(1, 0, 16, 0)
        stsConexion.Size = New Size(496, 26)
        stsConexion.TabIndex = 9
        stsConexion.Text = "StatusStrip1"
        ' 
        ' lblConexion
        ' 
        lblConexion.Name = "lblConexion"
        lblConexion.Size = New Size(479, 20)
        lblConexion.Spring = True
        lblConexion.Text = "Comprobando conexión..."
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.White
        pnlLogin.Controls.Add(lblTitulo)
        pnlLogin.Controls.Add(lblSubtitulo)
        pnlLogin.Controls.Add(lblUsuario)
        pnlLogin.Controls.Add(lblMensaje)
        pnlLogin.Controls.Add(txtUsuario)
        pnlLogin.Controls.Add(btnSalir)
        pnlLogin.Controls.Add(lblContrasena)
        pnlLogin.Controls.Add(btnIngresar)
        pnlLogin.Controls.Add(txtContrasena)
        pnlLogin.Controls.Add(chkMostrar)
        pnlLogin.Location = New Point(31, 16)
        pnlLogin.Margin = New Padding(3, 4, 3, 4)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(434, 555)
        pnlLogin.TabIndex = 10
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnIngresar
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        CancelButton = btnSalir
        ClientSize = New Size(496, 615)
        Controls.Add(pnlLogin)
        Controls.Add(stsConexion)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GymControl - Inicio de sesión"
        stsConexion.ResumeLayout(False)
        stsConexion.PerformLayout()
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents chkMostrar As CheckBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents stsConexion As StatusStrip
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblConexion As ToolStripStatusLabel

End Class