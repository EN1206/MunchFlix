Public Class frmLoadingScreen

    Dim percentage As Integer = 0
    Dim secondsLeft As Integer = 7


    Private Sub frmLoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PictureBox1.Image = Image.FromFile("C:\Users\moama\Downloads\0316-ezgif.com-optimize.gif")
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        secondsLeft -= 1
        percentage += 20
        If ProgressBar1.Value < 5000 Then
            ProgressBar1.Value += 1000
            lblProgress.Text = percentage & "%"
        End If
        If secondsLeft = 1 Then
            'PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            pbGIFDisplay.ImageLocation = "C:\Users\moama\Downloads\munchbear_logo1.png"
        End If
        If secondsLeft = 0 Then
            Timer1.Stop()
            frmMunchBear.Show()
            Me.Hide()
        End If
    End Sub




End Class