

Public Class frmMainMenu

    Dim isMaximized As Boolean = False
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private images As List(Of Image) = New List(Of Image)()
    Private imageIndex As Integer
    Dim intCounter As Integer = 0
    Public blnDrinks As Boolean
    Public blnAppetizers As Boolean
    Public blnMainMeal As Boolean
    Public blnDessert As Boolean
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

    Private Sub pbMaximize_MouseLeave(sender As Object, e As EventArgs) Handles pbMaximize.MouseLeave
        pbClose.Image = My.Resources.close_button_og
        pbMinimize.Image = My.Resources.minimize_button_og
        pbMaximize.Image = My.Resources.maximize_button_og
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        imageIndex += 1
        If imageIndex >= images.Count Then
            imageIndex = 0
        End If
        pbAds.Image = images(imageIndex)
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images.Add(My.Resources.munchbear_adobo_ad1)
        images.Add(My.Resources.munchbear_lumpiang_shanghai_ad2)
        images.Add(My.Resources.munchbear_margarita_ad3)
        images.Add(My.Resources.munchbear_lech_flan_ad4)
        images.Add(My.Resources.munchbear_mashed_potato_ad5)
        pbAds.Image = images(0)

        btnOrderPinkLemonade.Text = FormatCurrency(btnOrderPinkLemonade.Text)
        btnOrderEmpanada.Text = FormatCurrency(btnOrderEmpanada.Text)
        btnOrderSinigang.Text = FormatCurrency(btnOrderSinigang.Text)
        btnOrderHaloHalo.Text = FormatCurrency(btnOrderHaloHalo.Text)

    End Sub

    ' The code begins here, April 10, 2024.

    Dim strUsername As String = "", strPassword As String = "", strEmail As String = "",
        strGender As String = "", strBday As String = "", strAddress As String = "",
        intMobile_no As Integer = +64, strFirstName As String = "", strLastName As String = "",
        intAge As Integer = 16, blnAccount As Boolean = False

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        Me.Hide()
        frmMenus.Show()
        blnDrinks = True
    End Sub

    Private Sub btnAppetizers_Click(sender As Object, e As EventArgs) Handles btnAppetizers.Click
        Me.Hide()
        frmMenus.Show()
        blnAppetizers = True
    End Sub

    Private Sub btnMainMeal_Click(sender As Object, e As EventArgs) Handles btnMainMeal.Click
        Me.Hide()
        frmMenus.Show()
        blnMainMeal = True
    End Sub

    Private Sub btnDessert_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        Me.Hide()
        frmMenus.Show()
        blnDessert = True
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Me.Hide()
        frmCheckout.Show()
    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        Dim intRespond As Integer, blnRequirements As Boolean = False
        Dim invalidChars As String = "!@#$%^&*()-+=[]{};:'\"".,<>/|\\"
        Me.Hide()
        MsgBox("Welcome to MunchBear!", 0, "Account")
        intRespond = MsgBox("Sign Up?", 32 + 3, "Account")
        If intRespond = 6 Then
            MsgBox("By Signing Up, you are agreeing To the Terms Of Use including the arbitration clause And you are acknowledging the Privacy Policy", 64 + 0, "Sign Up")
            strFirstName = InputBox("Enter your first name", "Your first name", "Ex. Juan")
            strLastName = InputBox("Enter your last name", "Your last name", "Dela Cruz")
            Do
                strUsername = InputBox("Your username must: " & vbNewLine &
                           "• Be at least 5 characters long and start with a letter." & vbNewLine &
                           "• Not contain special characters, spaces, symbols, or your real name." & vbNewLine &
                           "• Not be your real name.", "Enter your username", "Ex. Nick12")
                If strUsername = "" Then
                    MsgBox("Username Invalid, you entered blank/nothing.", 48 + 0, "Invalid Username")
                ElseIf strUsername = vbCancel Then
                    MsgBox("Thank you for choosing MunchBear!", 64 + 0, "MunchBear")
                    Exit Do
                    Return
                ElseIf Not strUsername.Length >= 5 OrElse Not Char.IsLetter(strUsername, 0) OrElse
           strUsername.Any(Function(c) invalidChars.Contains(c)) OrElse
           strUsername.Any(Function(c) strLastName.Contains(c)) OrElse
           strUsername.Any(Function(c) strFirstName.Contains(c)) Then
                    MsgBox("Username invalid, please check the requirements.", 48 + 0, "Invalid Username")
                Else
                    Exit Do
                End If
            Loop
            'MsgBox("MunchBear is strict with password requirements. Because we value your privacy and security.", 64 + 0, "STRICT PASSWORD REQUIREMENTS!")
            Do While blnRequirements = False
                strPassword = InputBox("The following are observed in making your password: " & vbNewLine & "•At least 12 characters long but 14 or more is better." & vbNewLine & "•A combination of uppercase letters, lowercase letters, numbers, and symbols.", "Enter your password", "Ex: TL&_!s_T^&-B&$T5")
                If strPassword = "" Then
                    MsgBox("Password invalid, you entered blank/nothing.", 48 + 0, "Invalid Password")
                ElseIf strPassword = vbCancel Then
                    MsgBox("Thank you for choosing MunchBear!", 64 + 0, "MunchBear")
                    Exit Do
                    Return
                ElseIf Not strPassword >= 12 Then
                    MsgBox("Password invalid, make your password 12 characters or 14 long.", 48 + 0, "Invalid Password")
                    If strPassword >= 12 Then
                        MsgBox("Password is good, remember it carefully", 64 + 0, "Password is Good")
                    ElseIf strPassword >= 14 Then
                        MsgBox("Password is better!, with 14 characters or more.", 64 + 0, "Password is BRILLIANT")
                    End If
                ElseIf Not strPassword.Any(Function(c) Char.IsUpper(c)) Then
                    MsgBox("Password invalid, include upppercase letter(s) in your password.", 48 + 0, "Invalid Password")
                ElseIf Not strPassword.Any(Function(c) Char.IsLower(c)) Then
                    MsgBox("Password invalid, include lowercase letter(s) in your password.", 48 + 0, "Invalid Password")
                ElseIf Not strPassword.Any(Function(c) Char.IsDigit(c)) Then
                    MsgBox("Password invalid, include digits in your password.", 48 + 0, "Invalid Password")
                ElseIf Not strPassword.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
                    MsgBox("Password invalid, include symbols in your password.", 48 + 0, "Invalid Password")
                Else
                    blnRequirements = True
                End If
            Loop
            blnRequirements = False
            Do
                strBday = InputBox("Enter your birthdate" & vbNewLine & "Format: dd/mm/yy", "Birthdate", "Ex. 29/11/07")
                If strBday = "" Then
                    MsgBox("Birthdate Invalid, you entered nothing/blank.", 48 + 0, "Invalid Birthdate")
                ElseIf strBday = vbCancel Then
                    MsgBox("Thank you for choosing MunchBear!", 64 + 0, "MunchBear")
                    Exit Do
                    Return
                ElseIf strBday.Any(Function(c) Char.IsLetter(c)) Then
                    MsgBox("Birthdate Invalid, your birthdate includes characters.", 48 + 0, "Invalid Birthdate")
                Else
                    blnRequirements = True
                End If
            Loop While blnRequirements = False

            strGender = InputBox("Enter your gender." & vbNewLine & "[M] Male" & vbNewLine & "[F] Female", "Your gender", "[M] Male or [F] Female")
            strAddress = InputBox("Enter your address." & vbNewLine & "Format: Bldg Num & Street Name, Barangay, City or Municipality, Province(optional), Postal Code, PHILIPPINES", "Your Address", "Ex. B5 L52 San Agustin III")

        ElseIf intRespond = 7 Then
            intRespond = MsgBox("Log In?", 32 + 4, "Account")
            If intRespond = 6 Then
                'frmAccount.Show()
                Me.Hide()
            Else
                MsgBox("Thank you for choosing MunchBear!", 64 + 0, "MunchBear")
                Return
            End If
        Else
            MsgBox("Thank you for choosing MunchBear!", 64 + 0, "MunchBear")
        End If
        Me.Show()
    End Sub

    Private Sub AddItemToCheckout(product As String, price As Decimal, quantity As Integer)
        Dim tp_product As Decimal
        For counter = 1 To 13
            If frmCheckout.productdetail(counter).Text = "" Then
                frmCheckout.no(counter).Visible = True
                frmCheckout.productdetail(counter).Visible = True
                frmCheckout.qty(counter).Visible = True
                frmCheckout.price(counter).Visible = True
                frmCheckout.productdetail(counter).Text = product
                frmCheckout.qty(counter).Text = quantity
                frmCheckout.price(counter).Text = price * quantity
                Exit For
            ElseIf frmCheckout.productdetail(counter).Text = product Then
                quantity = frmCheckout.qty(counter).Text
                quantity += 1
                tp_product = quantity * price
                frmCheckout.qty(counter).Text = quantity
                frmCheckout.price(counter).Text = tp_product
                Exit For
            Else
                If frmCheckout.lblProduct13.Text <> "" Then
                    MsgBox("You have reached the limits and maximum of your order", 48 + 0, "Limit Reached")
                End If
            End If
        Next
    End Sub

    Private Sub btnOrderPinkLemonade_Click(sender As Object, e As EventArgs) Handles btnOrderPinkLemonade.Click
        Dim qty As Integer = 1
        MsgBox("Added to cart", 64 + 0, "Pink Lemonade")
        AddItemToCheckout("Pink Lemonade", 99.0, qty)
    End Sub

    Private Sub btnOrderEmpanada_Click(sender As Object, e As EventArgs) Handles btnOrderEmpanada.Click
        Dim qty As Integer = 1
        MsgBox("Added to cart", 64 + 0, "Empanada")
        AddItemToCheckout("Empanada", 120.0, qty)
    End Sub

    Private Sub btnOrderSinigang_Click(sender As Object, e As EventArgs) Handles btnOrderSinigang.Click
        Dim qty As Integer = 1
        MsgBox("Added to cart", 64 + 0, "Sinigang")
        AddItemToCheckout("Sinigang", 250.0, qty)
    End Sub

    Private Sub btnOrderHaloHalo_Click(sender As Object, e As EventArgs) Handles btnOrderHaloHalo.Click
        Dim qty As Integer = 1
        MsgBox("Added to cart", 64 + 0, "Halo-Halo")
        AddItemToCheckout("Halo-Halo", 85.0, qty)
    End Sub

End Class

