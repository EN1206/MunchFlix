Public Class frmDrinks
    Dim quantity As Integer, totalprice As Integer
    Public acc_age As Integer
    Public blnAcc_Exist As Boolean

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMunchBear.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrderMargarita_Click(sender As Object, e As EventArgs) Handles btnOrderMargarita.Click
        If blnAcc_Exist = True Then
            If acc_age < 18 Then
                MsgBox("You are age is ineligible to buy this product", vbOKOnly + vbExclamation, "MunchBear | Margarita | Age Restriction")
            Else
                Const price As Integer = 399
                Const product As String = "Margarita"
                MsgBox("Added to Cart", 64 + 0, "Margarita")
                lblMargaritaCounter.Text = lblMargaritaCounter.Text + 1
                frmMunchBear.lblCounterOrder.Text = frmMunchBear.lblCounterOrder.Text + 1
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
                Else
                    MsgBox("Already Assigned")
                End If
            End If
        Else
            MsgBox("NO ACCOUNT, NO ORDER")
        End If
    End Sub

    Private Sub btnAddMargarita_Click(sender As Object, e As EventArgs) Handles btnAddMargarita.Click
        If blnAcc_Exist = True Then
            If acc_age < 18 Then
                MsgBox("You are age is ineligible to buy this product", vbOKOnly + vbExclamation, "MunchBear | Margarita | Age Restriction")
            Else
                Const price As Integer = 399
                Const product As String = "Margarita"
                MsgBox("Added to Cart", 64 + 0, "Margarita")
                lblMargaritaCounter.Text = lblMargaritaCounter.Text + 1
                frmMunchBear.lblCounterOrder.Text = frmMunchBear.lblCounterOrder.Text + 1
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
                Else
                    MsgBox("Already Assigned")
                End If
            End If
        Else
            MsgBox("No Account, No Order")
        End If
    End Sub

    Private Sub btnReduceMargarita_Click(sender As Object, e As EventArgs) Handles btnReduceMargarita.Click
        If blnAcc_Exist = True Then
            Dim order As Integer
            order = lblMargaritaCounter.Text
            If acc_age < 18 Then
                MsgBox("You are age is ineligible to buy this product", vbOKOnly + vbExclamation, "MunchBear | Margarita | Age Restriction")
            Else
                Const price As Integer = 399
                Const product As String = "Margarita"
                MsgBox("Removed to Cart", 64 + 0, "Margarita")
                lblMargaritaCounter.Text = lblMargaritaCounter.Text - 1
                frmMunchBear.lblCounterOrder.Text = frmMunchBear.lblCounterOrder.Text - 1
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
                    quantity -= 1
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
                    quantity -= 1
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
                    quantity -= 1
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
                    quantity -= 1
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
                    quantity -= 1
                    totalprice = quantity * price
                    frmCheckout.lblQuantity5.Text = quantity
                    frmCheckout.lblPrice5.Text = totalprice
                Else
                    MsgBox("Already Assigned")
                End If
            End If
        Else
            MsgBox("No order, No Account.")
        End If
    End Sub

    Private Sub btnOrderPinkLemonade_Click(sender As Object, e As EventArgs) Handles btnOrderPinkLemonade.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 99
            Const product As String = "Pink Lemonade"
            MsgBox("Added to Cart", 64 + 0, "Pink Lemonade")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterPinkLemonadeOrder.Text += 1
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

    Private Sub btnAddPinkLemonade_Click(sender As Object, e As EventArgs) Handles btnAddPinkLemonade.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 99
            Const product As String = "Pink Lemonade"
            MsgBox("Added to Cart", 64 + 0, "Pink Lemonade")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterPinkLemonadeOrder.Text += 1
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

    Private Sub btnReducePinkLemonade_Click(sender As Object, e As EventArgs) Handles btnReducePinkLemonade.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 399
            Const product As String = "Margarita"
            MsgBox("Removed to Cart", 64 + 0, "Margarita")
            lblMargaritaCounter.Text = lblMargaritaCounter.Text - 1
            frmMunchBear.lblCounterOrder.Text = frmMunchBear.lblCounterOrder.Text - 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
                totalprice = quantity * price
                frmCheckout.lblQuantity5.Text = quantity
                frmCheckout.lblPrice5.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If
        Else
            MsgBox("No order, No Account.")
        End If
    End Sub

    Private Sub btnOrderMineralWater_Click(sender As Object, e As EventArgs) Handles btnOrderMineralWater.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 30
            Const product As String = "Mineral Water (Nature Spring)"
            MsgBox("Added to Cart", vbInformation + vbOKOnly, "Mineral Water")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterMineralWaterOrder.Text += 1
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
                MsgBox("NO Account, NO Order")
        End If
    End Sub

    Private Sub btnAddMineralWater_Click(sender As Object, e As EventArgs) Handles btnAddMineralWater.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 30
            Const product As String = "Mineral Water (Nature Spring)"
            MsgBox("Added to Cart", vbInformation + vbOKOnly, "Mineral Water")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterMineralWaterOrder.Text += 1
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
            MsgBox("NO Account, NO Order")
        End If
    End Sub

    Private Sub btnReduceMineralWater_Click(sender As Object, e As EventArgs) Handles btnReduceMineralWater.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 85
            Const product As String = "Halo-Halo"
            MsgBox("Removed to Cart", 64 + 0, "Halo-Halo")
            frmMunchBear.lblCounterOrder.Text -= 1
            lblCounterMineralWaterOrder.Text -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
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
                quantity -= 1
                totalprice = quantity * price
                frmCheckout.lblQuantity13.Text = quantity
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Maximum Order Reached")
            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

End Class