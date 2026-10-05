Public Class frmPrincipal
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnInstructores.Click

    End Sub

    Private Sub lblTotalSocios_Click(sender As Object, e As EventArgs) Handles lblTotalSocios.Click

    End Sub

    Private Sub lblIngresosMes_Click(sender As Object, e As EventArgs) Handles lblTituloClasesHoy.Click

    End Sub

    Private Sub plnIngresosMes_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblTituloPorVencer_Click(sender As Object, e As EventArgs) Handles lblTituloPorVencer.Click

    End Sub

    Private Sub mnuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuPrincipal.ItemClicked

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConsultarBitacora.Click

    End Sub

    Private Sub btnNuevoSocio_Click(sender As Object, e As EventArgs) Handles btnNuevoSocio.Click

    End Sub
    Private Sub btnUsuarios_Click(sender As Object,
                              e As EventArgs) Handles btnUsuarios.Click

        Using formulario As New frmUsuarios()
            formulario.ShowDialog()
        End Using

    End Sub

    Private Sub btnBitacora_Click(
    sender As Object,
    e As EventArgs
) Handles btnBitacora.Click

        Using formulario As New frmBitacora()
            formulario.ShowDialog()
        End Using

    End Sub
    Private Sub mnuCambiarContrasena_Click(
    sender As Object,
    e As EventArgs
) Handles mnuCambiarContrasena.Click

        Using formulario As New frmCambiarContrasena()
            formulario.ShowDialog(Me)
        End Using

    End Sub
End Class
