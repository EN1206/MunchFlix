Public Class frmMunchBear

    Dim totalprice As Integer, crncyTotalPrice As String, quantity As Integer
    Dim username As String, nickname As String, address As String, stGender As String, mobile_no As String, age As String
    Private counter_order As Integer = 0
    Private blnAccount As Boolean = False
    Dim isMaximized As Boolean = False
    Private Sub frmMunchBear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '("Welcome to MunchBear", vbOKOnly, "MunchBearch | Hapag Kainan")
        'MsgBox("Indulge in the Taste of Tradition, Filipino Cuisine at its Finest!", vbExclamation + vbOKOnly, "MunchBear | Hapag Kainina")
    End Sub

    Private Sub btnSize_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        If isMaximized Then
            Me.WindowState = FormWindowState.Normal
            isMaximized = False
        Else
            Me.WindowState = FormWindowState.Maximized
            isMaximized = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        MsgBox("You are currently viewing as an Anonymous.", vbInformation + vbOKOnly, "User Info")
        MsgBox("To order you need to have an existing account.", vbInformation + vbOKOnly, "User Info")

        If vbYes = MsgBox("Do you want to sign up?", vbQuestion + vbYesNo, "Sign Up!") Then
            Dim isValid As Boolean = False

            username = InputBox("Enter a username", "Creating an Account", "@example")
            nickname = InputBox("Enter your nickname", "Creating an Account", "Example Random Jr.")
            For counter As Integer = 1 To 3
                Do While isValid = False
                    mobile_no = InputBox("Enter your mobile no. (0991-740-9390)")
                    If Len(mobile_no) = 11 Then
                        isValid = True
                    Else
                        MsgBox("Invalid phone number. Please enter a valid 11-digit mobile no.", 48 + 0, "Invalid Phone No.")
                    End If
                Loop
            Next



            age = InputBox("Enter your age")
            address = InputBox("Enter your address")
            stGender = UCase(InputBox("Enter your gender", "MunchBear | Gender", "[M] Male/F [Female]"))

            lblGender.Text = stGender

            If stGender = "M" Then

                btnUser.Visible = False
                btnMaleUser.Visible = True
                lblGender.ForeColor = Color.Blue

            ElseIf stGender = "F" Then

                btnUser.Visible = False
                btnFemaleUser.Visible = True
                lblGender.ForeColor = Color.Pink

            Else

                MsgBox("An error has occured please try again later")
                lblGender.Text = ""

            End If

            lblUsername.Text = username
            lblNickname.Text = nickname
            lblAddress.Text = address
            lblMobileNo.Text = mobile_no

            lblUsername.Visible = True
            lblNickname.Visible = False

            blnAccount = True
            frmDrinks.acc_age = age
            frmDessert.blnAcc_Exist = True
            frmAppetizer.blnAcc_Exist = True
            frmDrinks.blnAcc_Exist = True
            frmMainMeal.blnAcc_Exist = True
        Else

            MsgBox("Thank you for choosing Munch Bear!", vbInformation + vbOKOnly, "MunchBear | Account")

        End If
    End Sub

    Private Sub btnFemaleUser_Click(sender As Object, e As EventArgs) Handles btnFemaleUser.Click
        Dim change As String
        username = lblUsername.Text
        nickname = lblNickname.Text
        stGender = lblGender.Text
        age = lblAge.Text
        mobile_no = lblMobileNo.Text
        address = lblAddress.Text
        MsgBox("Username: " & username & vbNewLine & "Nickname: " & nickname & vbNewLine & "Gender: " &
               stGender & vbNewLine & "Age: " & age & vbNewLine & "Mobile No: " &
               mobile_no & vbNewLine & "Address: " & address)
        If vbYes = MsgBox("Do you want to edit your account?", vbQuestion + vbYesNo, "Modify Account") Then
            change = InputBox(LCase("Which part do you want to change"))
            Select Case change
                Case = "username"
                    username = InputBox("Enter a username", "Creating an Account", "@example")
                    lblUsername.Text = username
                Case = "age"
                    age = InputBox("Enter your age")
                    lblAge.Text = age
                Case = "gender"
                    stGender = UCase(InputBox("Enter your gender", "MunchBear | Gender", "[M] Male/F [Female]"))
                    Select Case stGender
                        Case = "M"

                            btnUser.Visible = False
                            btnMaleUser.Visible = True
                            lblGender.ForeColor = Color.Blue

                        Case = "F"

                            btnUser.Visible = False
                            btnFemaleUser.Visible = True
                            lblGender.ForeColor = Color.Pink

                        Case Else

                            MsgBox("An error has occured please try again later")
                            lblGender.Text = ""

                    End Select
                Case = "nickname"
                    age = InputBox("Enter your age")
                    lblAge.Text = age
                    frmDrinks.acc_age = age
                Case = "address"
                    address = InputBox("Enter your address")
                    lblAddress.Text = address
                Case = mobile_no
                    mobile_no = InputBox("Enter your mobile number", "Creating an Account", "+63")

                    Select Case Len(mobile_no)
                        Case > 11

                            MsgBox("This is not a philippine mobile no. due to it having more than  " & Len(mobile_no) - 11 & " digits", vbCritical + vbOK, "Encountered Mobile No. Error")
                            MsgBox("Please Try Again", vbExclamation + vbOK, "Error Encountered")
                            mobile_no = FormatNumber(InputBox("Enter your mobile number", "Entering Mobile No. A1", "+63"))
                            lblMobileNo.Text = mobile_no
                        Case < 11
                            MsgBox("This is not a philippine mobile no. due to it having less  " & 11 - Len(mobile_no) & " digits", "")
                            MsgBox("Please Try Again")
                            mobile_no = FormatNumber(InputBox("Enter your mobile number", "Entering Mobile No. A1", "+63"))
                            lblMobileNo.Text = mobile_no
                        Case Else
                            MsgBox("This is the correct number")
                    End Select

                    lblMobileNo.Text = mobile_no
            End Select

        Else
            MsgBox("Thanks for choosing MunchBear")
        End If
    End Sub

    Private Sub btnMaleUser_Click(sender As Object, e As EventArgs) Handles btnMaleUser.Click
        Dim change As String
        username = lblUsername.Text
        nickname = lblNickname.Text
        stGender = lblGender.Text
        age = lblAge.Text
        mobile_no = lblMobileNo.Text
        address = lblAddress.Text
        MsgBox("Username: " & username & vbNewLine & "Nickname: " & nickname & vbNewLine & "Gender: " &
               stGender & vbNewLine & "Age: " & age & vbNewLine & "Mobile No: " &
               mobile_no & vbNewLine & "Address: " & address)
        If vbYes = MsgBox("Do you want to edit your account?", vbQuestion + vbYesNo, "Modify Account") Then
            change = InputBox(LCase("Which part do you want to change"))
            Select Case change
                Case = "username"
                    username = InputBox("Enter a username", "Creating an Account", "@example")
                    lblUsername.Text = username
                Case = "age"
                    age = InputBox("Enter your age")
                    lblAge.Text = age
                Case = "gender"
                    stGender = UCase(InputBox("Enter your gender", "MunchBear | Gender", "[M] Male/F [Female]"))
                    Select Case stGender
                        Case = "M"

                            btnUser.Visible = False
                            btnMaleUser.Visible = True
                            lblGender.ForeColor = Color.Blue

                        Case = "F"

                            btnUser.Visible = False
                            btnFemaleUser.Visible = True
                            lblGender.ForeColor = Color.Pink

                        Case Else

                            MsgBox("An error has occured please try again later")
                            lblGender.Text = ""

                    End Select
                Case = "nickname"
                    age = InputBox("Enter your age")
                    lblAge.Text = age
                    frmDrinks.acc_age = age
                Case = "address"
                    address = InputBox("Enter your address")
                    lblAddress.Text = address
                Case = mobile_no
                    mobile_no = InputBox("Enter your mobile number", "Creating an Account", "+63")

                    Select Case Len(mobile_no)
                        Case > 11

                            MsgBox("This is not a philippine mobile no. due to it having more than  " & Len(mobile_no) - 11 & " digits", vbCritical + vbOK, "Encountered Mobile No. Error")
                            MsgBox("Please Try Again", vbExclamation + vbOK, "Error Encountered")
                            mobile_no = FormatNumber(InputBox("Enter your mobile number", "Entering Mobile No. A1", "+63"))
                            lblMobileNo.Text = mobile_no
                        Case < 11
                            MsgBox("This is not a philippine mobile no. due to it having less  " & 11 - Len(mobile_no) & " digits", "")
                            MsgBox("Please Try Again")
                            mobile_no = FormatNumber(InputBox("Enter your mobile number", "Entering Mobile No. A1", "+63"))
                            lblMobileNo.Text = mobile_no
                        Case Else
                            MsgBox("This is the correct number")
                    End Select

                    lblMobileNo.Text = mobile_no
            End Select

        Else
            MsgBox("Thanks for choosing MunchBear")
        End If
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        If lblCounterOrder.Text = 0 Or blnAccount = False Then
            If lblCounterOrder.Text = 0 Then
                MsgBox("NO ACCESS" & vbNewLine & "due to having no order yet.")
            End If
            If blnAccount = False Then
                MsgBox("NO ACCESS" & vbNewLine & "due to having no account.")
            End If
        Else
            If vbYes = MsgBox("Is that everything?", vbQuestion + vbYesNo, "MunchBear | Is that everything?") Then
                frmCheckout.Show()
                Me.Hide()
            Else
                MsgBox("Thanks for choosing Munchbear!")
                MsgBox("We hope you enjoy!")
            End If
        End If

    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        frmDrinks.Show()
    End Sub

    Private Sub btnAppetizers_Click(sender As Object, e As EventArgs) Handles btnAppetizers.Click
        frmAppetizer.Show()
    End Sub

    Private Sub btnMainMeal_Click(sender As Object, e As EventArgs) Handles btnMainMeal.Click
        frmMainMeal.Show()
    End Sub

    Private Sub btnDessert_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        frmDessert.Show()
    End Sub

    Private Sub btnOrderPinkLemonade_Click(sender As Object, e As EventArgs) Handles btnOrderPinkLemonade.Click
        If blnAccount = True Then
            Const price As Integer = 99
            Const product As String = "Pink Lemonade"
            MsgBox("Added to Cart", 64 + 0, "Pink Lemonade")
            lblCounterOrder.Text = lblCounterOrder.Text + 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "1"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity1.Text = quantity
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "1"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity2.Text = quantity
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "1"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity3.Text = quantity
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "1"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity4.Text = quantity
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "1"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity5.Text = quantity
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "1"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity6.Text = quantity
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "1"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity7.Text = quantity
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "1"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity8.Text = quantity
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "1"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity9.Text = quantity
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "1"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity10.Text = quantity
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "1"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity11.Text = quantity
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "1"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity12.Text = quantity
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "1"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity13.Text = quantity
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Maximum Order Reached")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnOrderEmpanada_Click(sender As Object, e As EventArgs) Handles btnOrderEmpanada.Click
        If blnAccount = True Then
            Const price As Integer = 120
            Const product As String = "Empanada"
            MsgBox("Added to Cart", 64 + 0, "Empanada")
            lblCounterOrder.Text = lblCounterOrder.Text + 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "1"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity1.Text = quantity
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "1"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity2.Text = quantity
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "1"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity3.Text = quantity
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "1"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity4.Text = quantity
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "1"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity5.Text = quantity
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "1"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity6.Text = quantity
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "1"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity7.Text = quantity
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "1"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity8.Text = quantity
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "1"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity9.Text = quantity
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "1"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity10.Text = quantity
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "1"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity11.Text = quantity
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "1"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity12.Text = quantity
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "1"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity13.Text = quantity
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnOrderSinigang_Click(sender As Object, e As EventArgs) Handles btnOrderSinigang.Click
        If blnAccount = True Then
            Const price As Integer = 250
            Const product As String = "Sinigang"
            MsgBox("Added to Cart", 64 + 0, "Sinigang")
            lblCounterOrder.Text = lblCounterOrder.Text + 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "1"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity1.Text = quantity
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "1"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity2.Text = quantity
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "1"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity3.Text = quantity
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "1"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity4.Text = quantity
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "1"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity5.Text = quantity
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "1"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity6.Text = quantity
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "1"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity7.Text = quantity
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "1"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity8.Text = quantity
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "1"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity9.Text = quantity
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "1"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity10.Text = quantity
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "1"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity11.Text = quantity
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "1"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity12.Text = quantity
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "1"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity13.Text = quantity
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnOrderHaloHalo_Click(sender As Object, e As EventArgs) Handles btnOrderHaloHalo.Click
        If blnAccount = True Then
            Const price As Integer = 85
            Const product As String = "Halo-Halo"
            MsgBox("Added to Cart", 64 + 0, "Halo-Halo")
            lblCounterOrder.Text = lblCounterOrder.Text + 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "1"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity1.Text = quantity
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "1"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity2.Text = quantity
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "1"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity3.Text = quantity
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "1"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity4.Text = quantity
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "1"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity5.Text = quantity
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "1"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity6.Text = quantity
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "1"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity7.Text = quantity
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "1"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity8.Text = quantity
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "1"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity9.Text = quantity
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "1"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity10.Text = quantity
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "1"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity11.Text = quantity
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "1"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity12.Text = quantity
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "1"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 1
                totalprice = quantity * price
                frmCheckout.lblQuantity13.Text = quantity
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")
        End If
    End Sub

End Class