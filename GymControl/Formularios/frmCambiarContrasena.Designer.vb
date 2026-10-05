<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContrasena
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
        lblTitulo = New Label()
        lblDescripcion = New Label()
        lblUsuarioTitulo = New Label()
        lblUsuario = New Label()
        lblActual = New Label()
        txtContrasenaActual = New TextBox()
        lblNueva = New Label()
        txtNuevaContrasena = New TextBox()
        lblConfirmar = New Label()
        txtConfirmarContrasena = New TextBox()
        chkMostrarContrasenas = New CheckBox()
        btnCambiar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(12, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(169, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Cambiar contraseña"
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(12, 47)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(296, 25)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Actualice la contraseña de su cuenta"
        ' 
        ' lblUsuarioTitulo
        ' 
        lblUsuarioTitulo.AutoSize = True
        lblUsuarioTitulo.Location = New Point(12, 86)
        lblUsuarioTitulo.Name = "lblUsuarioTitulo"
        lblUsuarioTitulo.Size = New Size(76, 25)
        lblUsuarioTitulo.TabIndex = 2
        lblUsuarioTitulo.Text = "Usuario:"
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Location = New Point(12, 121)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(91, 25)
        lblUsuario.TabIndex = 3
        lblUsuario.Text = "Sin sesión"
        ' 
        ' lblActual
        ' 
        lblActual.AutoSize = True
        lblActual.Location = New Point(12, 194)
        lblActual.Name = "lblActual"
        lblActual.Size = New Size(156, 25)
        lblActual.TabIndex = 4
        lblActual.Text = "Contraseña actual:"
        ' 
        ' txtContrasenaActual
        ' 
        txtContrasenaActual.Location = New Point(12, 248)
        txtContrasenaActual.Name = "txtContrasenaActual"
        txtContrasenaActual.Size = New Size(296, 31)
        txtContrasenaActual.TabIndex = 5
        ' 
        ' lblNueva
        ' 
        lblNueva.AutoSize = True
        lblNueva.Location = New Point(12, 311)
        lblNueva.Name = "lblNueva"
        lblNueva.Size = New Size(157, 25)
        lblNueva.TabIndex = 6
        lblNueva.Text = "Nueva contraseña:"
        ' 
        ' txtNuevaContrasena
        ' 
        txtNuevaContrasena.Location = New Point(12, 364)
        txtNuevaContrasena.Name = "txtNuevaContrasena"
        txtNuevaContrasena.Size = New Size(296, 31)
        txtNuevaContrasena.TabIndex = 7
        ' 
        ' lblConfirmar
        ' 
        lblConfirmar.AutoSize = True
        lblConfirmar.Location = New Point(12, 426)
        lblConfirmar.Name = "lblConfirmar"
        lblConfirmar.Size = New Size(186, 25)
        lblConfirmar.TabIndex = 8
        lblConfirmar.Text = "Confirmar contraseña:"
        ' 
        ' txtConfirmarContrasena
        ' 
        txtConfirmarContrasena.Location = New Point(12, 483)
        txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        txtConfirmarContrasena.Size = New Size(296, 31)
        txtConfirmarContrasena.TabIndex = 9
        ' 
        ' chkMostrarContrasenas
        ' 
        chkMostrarContrasenas.AutoSize = True
        chkMostrarContrasenas.Location = New Point(12, 557)
        chkMostrarContrasenas.Name = "chkMostrarContrasenas"
        chkMostrarContrasenas.Size = New Size(199, 29)
        chkMostrarContrasenas.TabIndex = 10
        chkMostrarContrasenas.Text = "Mostrar contraseñas"
        chkMostrarContrasenas.UseVisualStyleBackColor = True
        ' 
        ' btnCambiar
        ' 
        btnCambiar.Location = New Point(283, 625)
        btnCambiar.Name = "btnCambiar"
        btnCambiar.Size = New Size(203, 47)
        btnCambiar.TabIndex = 11
        btnCambiar.Text = "Cambiar contraseña"
        btnCambiar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(12, 625)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(203, 47)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmCambiarContrasena
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 684)
        Controls.Add(btnCancelar)
        Controls.Add(btnCambiar)
        Controls.Add(chkMostrarContrasenas)
        Controls.Add(txtConfirmarContrasena)
        Controls.Add(lblConfirmar)
        Controls.Add(txtNuevaContrasena)
        Controls.Add(lblNueva)
        Controls.Add(txtContrasenaActual)
        Controls.Add(lblActual)
        Controls.Add(lblUsuario)
        Controls.Add(lblUsuarioTitulo)
        Controls.Add(lblDescripcion)
        Controls.Add(lblTitulo)
        Name = "frmCambiarContrasena"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmCambiarContrasena"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblUsuarioTitulo As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblActual As Label
    Friend WithEvents txtContrasenaActual As TextBox
    Friend WithEvents lblNueva As Label
    Friend WithEvents txtNuevaContrasena As TextBox
    Friend WithEvents lblConfirmar As Label
    Friend WithEvents txtConfirmarContrasena As TextBox
    Friend WithEvents chkMostrarContrasenas As CheckBox
    Friend WithEvents btnCambiar As Button
    Friend WithEvents btnCancelar As Button
End Class
