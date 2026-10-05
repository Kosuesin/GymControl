<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        pnlAcciones = New Panel()
        btnDesactivar = New Button()
        btnEditar = New Button()
        btnCancelar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        txtBuscar = New TextBox()
        dgvUsuarios = New DataGridView()
        grpDatos = New GroupBox()
        txtContrasena = New TextBox()
        Label7 = New Label()
        chkActivo = New CheckBox()
        cboInstructor = New ComboBox()
        cboSocio = New ComboBox()
        cboRol = New ComboBox()
        txtUltimoAcceso = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtUsuario = New TextBox()
        grpSeguridad = New GroupBox()
        btnRestablecer = New Button()
        btnDesbloquear = New Button()
        pnlAcciones.SuspendLayout()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        grpDatos.SuspendLayout()
        grpSeguridad.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlAcciones
        ' 
        pnlAcciones.Controls.Add(btnDesactivar)
        pnlAcciones.Controls.Add(btnEditar)
        pnlAcciones.Controls.Add(btnCancelar)
        pnlAcciones.Controls.Add(btnGuardar)
        pnlAcciones.Controls.Add(btnNuevo)
        pnlAcciones.Dock = DockStyle.Top
        pnlAcciones.Location = New Point(0, 0)
        pnlAcciones.Name = "pnlAcciones"
        pnlAcciones.Size = New Size(1028, 55)
        pnlAcciones.TabIndex = 0
        ' 
        ' btnDesactivar
        ' 
        btnDesactivar.Location = New Point(412, 12)
        btnDesactivar.Name = "btnDesactivar"
        btnDesactivar.Size = New Size(107, 39)
        btnDesactivar.TabIndex = 4
        btnDesactivar.Text = "Desactivar"
        btnDesactivar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(112, 12)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 39)
        btnEditar.TabIndex = 0
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(312, 12)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 39)
        btnCancelar.TabIndex = 3
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(212, 12)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 39)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(12, 12)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(94, 39)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(12, 57)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Buscar usuario..."
        txtBuscar.Size = New Size(265, 31)
        txtBuscar.TabIndex = 1
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(12, 94)
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.RowHeadersWidth = 62
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.Size = New Size(395, 488)
        dgvUsuarios.TabIndex = 2
        ' 
        ' grpDatos
        ' 
        grpDatos.Controls.Add(txtContrasena)
        grpDatos.Controls.Add(Label7)
        grpDatos.Controls.Add(chkActivo)
        grpDatos.Controls.Add(cboInstructor)
        grpDatos.Controls.Add(cboSocio)
        grpDatos.Controls.Add(cboRol)
        grpDatos.Controls.Add(txtUltimoAcceso)
        grpDatos.Controls.Add(Label6)
        grpDatos.Controls.Add(Label5)
        grpDatos.Controls.Add(Label4)
        grpDatos.Controls.Add(Label3)
        grpDatos.Controls.Add(Label2)
        grpDatos.Controls.Add(Label1)
        grpDatos.Controls.Add(txtUsuario)
        grpDatos.Location = New Point(412, 61)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New Size(604, 381)
        grpDatos.TabIndex = 3
        grpDatos.TabStop = False
        grpDatos.Text = "Datos del usuario"
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(247, 92)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(351, 31)
        txtContrasena.TabIndex = 11
        txtContrasena.UseSystemPasswordChar = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(24, 92)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 25)
        Label7.TabIndex = 10
        Label7.Text = "Contraseña:"
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Location = New Point(247, 285)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(88, 29)
        chkActivo.TabIndex = 9
        chkActivo.Text = "Activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' cboInstructor
        ' 
        cboInstructor.DropDownStyle = ComboBoxStyle.DropDownList
        cboInstructor.FormattingEnabled = True
        cboInstructor.Location = New Point(247, 230)
        cboInstructor.Name = "cboInstructor"
        cboInstructor.Size = New Size(351, 33)
        cboInstructor.TabIndex = 8
        ' 
        ' cboSocio
        ' 
        cboSocio.DropDownStyle = ComboBoxStyle.DropDownList
        cboSocio.FormattingEnabled = True
        cboSocio.Location = New Point(247, 189)
        cboSocio.Name = "cboSocio"
        cboSocio.Size = New Size(351, 33)
        cboSocio.TabIndex = 7
        ' 
        ' cboRol
        ' 
        cboRol.DropDownStyle = ComboBoxStyle.DropDownList
        cboRol.FormattingEnabled = True
        cboRol.Location = New Point(247, 139)
        cboRol.Name = "cboRol"
        cboRol.Size = New Size(351, 33)
        cboRol.TabIndex = 6
        ' 
        ' txtUltimoAcceso
        ' 
        txtUltimoAcceso.Location = New Point(247, 327)
        txtUltimoAcceso.Name = "txtUltimoAcceso"
        txtUltimoAcceso.ReadOnly = True
        txtUltimoAcceso.Size = New Size(351, 31)
        txtUltimoAcceso.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 327)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 25)
        Label6.TabIndex = 4
        Label6.Text = "Ultimo Acceso:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 25)
        Label5.TabIndex = 3
        Label5.Text = "Socio:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 25)
        Label4.TabIndex = 3
        Label4.Text = "Instructor:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 25)
        Label3.TabIndex = 2
        Label3.Text = "Rol:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 285)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 2
        Label2.Text = "Estado:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 25)
        Label1.TabIndex = 1
        Label1.Text = "Usuario:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(247, 47)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(351, 31)
        txtUsuario.TabIndex = 0
        ' 
        ' grpSeguridad
        ' 
        grpSeguridad.Controls.Add(btnRestablecer)
        grpSeguridad.Controls.Add(btnDesbloquear)
        grpSeguridad.Location = New Point(410, 448)
        grpSeguridad.Name = "grpSeguridad"
        grpSeguridad.Size = New Size(606, 134)
        grpSeguridad.TabIndex = 4
        grpSeguridad.TabStop = False
        grpSeguridad.Text = "Seguridad de la cuenta"
        ' 
        ' btnRestablecer
        ' 
        btnRestablecer.Location = New Point(317, 43)
        btnRestablecer.Name = "btnRestablecer"
        btnRestablecer.Size = New Size(283, 77)
        btnRestablecer.TabIndex = 1
        btnRestablecer.Text = "Restablecer contraseña"
        btnRestablecer.UseVisualStyleBackColor = True
        ' 
        ' btnDesbloquear
        ' 
        btnDesbloquear.Location = New Point(6, 43)
        btnDesbloquear.Name = "btnDesbloquear"
        btnDesbloquear.Size = New Size(277, 77)
        btnDesbloquear.TabIndex = 0
        btnDesbloquear.Text = "Desbloquear cuenta"
        btnDesbloquear.UseVisualStyleBackColor = True
        ' 
        ' frmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 594)
        Controls.Add(grpSeguridad)
        Controls.Add(grpDatos)
        Controls.Add(dgvUsuarios)
        Controls.Add(txtBuscar)
        Controls.Add(pnlAcciones)
        MinimumSize = New Size(900, 550)
        Name = "frmUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestión de usuarios — GymControl"
        pnlAcciones.ResumeLayout(False)
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        grpSeguridad.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboInstructor As ComboBox
    Friend WithEvents cboSocio As ComboBox
    Friend WithEvents cboRol As ComboBox
    Friend WithEvents txtUltimoAcceso As TextBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents grpSeguridad As GroupBox
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents btnDesbloquear As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label7 As Label
End Class
