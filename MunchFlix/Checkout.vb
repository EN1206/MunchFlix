Public Class frmCheckout
    Dim isMaximized As Boolean = False
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public productdetail() As Label
    Public qty() As Label
    Public price() As Label
    Public no() As Label

    'Makes the panel draggable.

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown

        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTop.MouseMove

        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If

    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTop.MouseUp

        draggable = False

    End Sub

    'Buttons are squares, pictureboxes doesn't make it obvious. Therefore picturebox became the button.

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click

        Application.Exit()
    End Sub

    Private Sub pbClose_MouseEnter(sender As Object, e As EventArgs) Handles pbClose.MouseEnter
        pbClose.Image = My.Resources.close_button
        pbMinimize.Image = My.Resources.mini_button
        pbMaximize.Image = My.Resources.max_button
    End Sub

    Private Sub pbClose_MouseLeave(sender As Object, e As EventArgs) Handles pbClose.MouseLeave
        pbClose.Image = My.Resources.close_button_og
        pbMinimize.Image = My.Resources.minimize_button_og
        pbMaximize.Image = My.Resources.maximize_button_og
    End Sub

    Private Sub pbMinimize_Click(sender As Object, e As EventArgs) Handles pbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbMinimize_MouseEnter(sender As Object, e As EventArgs) Handles pbMinimize.MouseEnter
        pbClose.Image = My.Resources.close_button
        pbMinimize.Image = My.Resources.mini_button
        pbMaximize.Image = My.Resources.max_button
    End Sub

    Private Sub pbMinimize_MouseLeave(sender As Object, e As EventArgs) Handles pbMinimize.MouseLeave
        pbClose.Image = My.Resources.close_button_og
        pbMinimize.Image = My.Resources.minimize_button_og
        pbMaximize.Image = My.Resources.maximize_button_og
    End Sub

    Private Sub pbMaximize_Click(sender As Object, e As EventArgs) Handles pbMaximize.Click
        If isMaximized Then
            Me.WindowState = FormWindowState.Normal
            isMaximized = False
        Else
            Me.WindowState = FormWindowState.Maximized
            isMaximized = True
        End If
    End Sub

    Private Sub pbMaximize_MouseEnter(sender As Object, e As EventArgs) Handles pbMaximize.MouseEnter
        pbClose.Image = My.Resources.close_button
        pbMinimize.Image = My.Resources.mini_button
        pbMaximize.Image = My.Resources.max_button
    End Sub

    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim totalSum As Decimal = 0

        totalSum += Val(lblPrice1.Text)
        totalSum += Val(lblPrice2.Text)
        totalSum += Val(lblPrice3.Text)
        totalSum += Val(lblPrice4.Text)
        totalSum += Val(lblPrice5.Text)
        totalSum += Val(lblPrice6.Text)
        totalSum += Val(lblPrice7.Text)
        totalSum += Val(lblPrice8.Text)
        totalSum += Val(lblPrice9.Text)
        totalSum += Val(lblPrice10.Text)
        totalSum += Val(lblPrice11.Text)
        totalSum += Val(lblPrice12.Text)
        totalSum += Val(lblPrice13.Text)

        lblSumTP.Text = FormatCurrency(totalSum)

        lblPrice1.Text = FormatCurrency(Val(lblPrice1.Text))
        lblPrice2.Text = FormatCurrency(Val(lblPrice2.Text))
        lblPrice3.Text = FormatCurrency(Val(lblPrice3.Text))
        lblPrice4.Text = FormatCurrency(Val(lblPrice4.Text))
        lblPrice5.Text = FormatCurrency(Val(lblPrice5.Text))
        lblPrice6.Text = FormatCurrency(Val(lblPrice6.Text))
        lblPrice7.Text = FormatCurrency(Val(lblPrice7.Text))
        lblPrice8.Text = FormatCurrency(Val(lblPrice8.Text))
        lblPrice9.Text = FormatCurrency(Val(lblPrice9.Text))
        lblPrice10.Text = FormatCurrency(Val(lblPrice10.Text))
        lblPrice11.Text = FormatCurrency(Val(lblPrice11.Text))
        lblPrice12.Text = FormatCurrency(Val(lblPrice12.Text))
        lblPrice13.Text = FormatCurrency(Val(lblPrice13.Text))

    End Sub


    Sub InitializeArray()

        productdetail = New Label(13) {lblProductDetails, lblProduct1, lblProduct2, lblProduct3, lblProduct4, lblProduct5, lblProduct6, lblProduct7, lblProduct8, lblProduct9, lblProduct10, lblProduct11, lblProduct12, lblProduct13}
        no = New Label(13) {lblNo, lblNo1, lblNo2, lblNo3, lblNo4, lblNo5, lblNo6, lblNo7, lblNo8, lblNo9, lblNo10, lblNo11, lblNo12, lblNo13}
        qty = New Label(13) {lblQuantity, lblQuantity1, lblQuantity2, lblQuantity3, lblQuantity4, lblQuantity5, lblQuantity6, lblQuantity7, lblQuantity8, lblQuantity9, lblQuantity10, lblQuantity11, lblQuantity12, lblQuantity13}
        price = New Label(13) {lblPrice, lblPrice1, lblPrice2, lblPrice3, lblPrice4, lblPrice5, lblPrice6, lblPrice7, lblPrice8, lblPrice9, lblPrice10, lblPrice11, lblPrice12, lblPrice13}

        productdetail(0).Text = "Product Detial"
        productdetail(1).Text = ""
        productdetail(2).Text = ""
        productdetail(3).Text = ""
        productdetail(4).Text = ""
        productdetail(5).Text = ""
        productdetail(6).Text = ""
        productdetail(7).Text = ""
        productdetail(8).Text = ""
        productdetail(9).Text = ""
        productdetail(10).Text = ""
        productdetail(11).Text = ""
        productdetail(12).Text = ""
        productdetail(13).Text = ""

    End Sub

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeArray()
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim result As String = ""
        Dim i As Integer
        For i = 1 To 13
            Dim lbl As Label = DirectCast(Me.Controls("lblPrice" & i.ToString), Label)
            If lbl.Text <> "₱0.00" Then
                result &= lbl.Text & vbNewLine
            End If
        Next

        MsgBox(result)
    End Sub


End Class