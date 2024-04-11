Public Class frmLoadingScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If panelLoadingBar.InvokeRequired Then
            panelLoadingBar.Invoke(Sub() panelLoadingBar.Width += 2) ' Replace 100 with the desired width
        Else
            panelLoadingBar.Width += 2
        End If
        If panelLoadingBar.Width >= 600 Then
            Timer1.Stop()
        End If
    End Sub
End Class
