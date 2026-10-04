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
        pnlLogin = New Panel()
        pnlLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = False
        lblTitulo.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTitulo.Location = New Point(42, 26)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(296, 46)
        lblTitulo.TabIndex = 0
        lblTitulo.TabStop = False
        lblTitulo.Text = "GymControl"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubtitulo
        ' 
        lblSubtitulo.AutoSize = False
        lblSubtitulo.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitulo.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSubtitulo.Location = New Point(42, 74)
        lblSubtitulo.Name = "lblSubtitulo"
        lblSubtitulo.Size = New Size(296, 19)
        lblSubtitulo.TabIndex = 1
        lblSubtitulo.TabStop = False
        lblSubtitulo.Text = "Sistema de gestión de gimnasio"
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = False
        lblUsuario.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        lblUsuario.Location = New Point(42, 114)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(296, 19)
        lblUsuario.TabIndex = 1
        lblUsuario.TabStop = False
        lblUsuario.Text = "Usuario"
        lblUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsuario
        ' 
        txtUsuario.AutoSize = False
        txtUsuario.BackColor = Color.White
        txtUsuario.BorderStyle = BorderStyle.FixedSingle
        txtUsuario.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtUsuario.Location = New Point(42, 136)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(296, 28)
        txtUsuario.TabIndex = 2
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = False
        lblContrasena.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContrasena.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        lblContrasena.Location = New Point(42, 178)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(296, 19)
        lblContrasena.TabIndex = 3
        lblContrasena.TabStop = False
        lblContrasena.Text = "Contraseña"
        lblContrasena.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtContrasena
        ' 
        txtContrasena.AutoSize = False
        txtContrasena.BackColor = Color.White
        txtContrasena.BorderStyle = BorderStyle.FixedSingle
        txtContrasena.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContrasena.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        txtContrasena.Location = New Point(42, 200)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(296, 28)
        txtContrasena.TabIndex = 4
        txtContrasena.UseSystemPasswordChar = True
        ' 
        ' chkMostrar
        ' 
        chkMostrar.AutoSize = True
        chkMostrar.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMostrar.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        chkMostrar.Location = New Point(42, 240)
        chkMostrar.Name = "chkMostrar"
        chkMostrar.Size = New Size(148, 23)
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
        btnIngresar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(42, 303)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(296, 40)
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
        btnSalir.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnSalir.Location = New Point(42, 353)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(296, 40)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoEllipsis = True
        lblMensaje.AutoSize = False
        lblMensaje.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMensaje.ForeColor = Color.FromArgb(CByte(198), CByte(40), CByte(40))
        lblMensaje.Location = New Point(42, 274)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(296, 19)
        lblMensaje.TabIndex = 8
        lblMensaje.TextAlign = ContentAlignment.MiddleLeft
        lblMensaje.Visible = False
        ' 
        ' stsConexion
        ' 
        stsConexion.Location = New Point(0, 439)
        stsConexion.Name = "stsConexion"
        stsConexion.Size = New Size(434, 22)
        stsConexion.TabIndex = 9
        stsConexion.Text = "StatusStrip1"
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
        pnlLogin.Location = New Point(27, 12)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(380, 416)
        pnlLogin.TabIndex = 10
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        ClientSize = New Size(434, 461)
        Controls.Add(pnlLogin)
        Controls.Add(stsConexion)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GymControl - Inicio de sesión"
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

End Class