Public Class frmMain
    Private Sub btnWelcome_Click(sender As Object, e As EventArgs) Handles btnWelcome.Click
        'Application of hiding and showing a form.
        frmOrder.Show()
        Me.Hide()
    End Sub
End Class
