Public Class FrmSocios

    Private bnvSocios As New BindingNavigator(True)

    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bnvSocios.Location = New Point(dgvSocios.Left, dgvSocios.Bottom)
        bnvSocios.Width = dgvSocios.Width
        Me.Controls.Add(bnvSocios)

    End Sub

End Class