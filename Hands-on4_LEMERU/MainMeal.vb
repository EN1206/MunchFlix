Public Class frmMainMeal
    Dim quantity As Integer, totalprice As Integer
    Public blnAcc_Exist As Boolean

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMunchBear.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrderAdobo_Click(sender As Object, e As EventArgs) Handles btnOrderAdobo.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 499
            Const product As String = "Adobo De Los Naturales"
            MsgBox("Added to Cart", 64 + 0, "Adobo De Los Naturales")
            frmMunchBear.lblCounterOrder.Text += 1
            lblAdoboCounterOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnAddAdobo_Click(sender As Object, e As EventArgs) Handles btnAddAdobo.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 499
            Const product As String = "Adobo De Los Naturales"
            MsgBox("Added to Cart", 64 + 0, "Adobo De Los Naturales")
            frmMunchBear.lblCounterOrder.Text += 1
            lblAdoboCounterOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnReduceAdobo_Click(sender As Object, e As EventArgs) Handles btnReduceAdobo.Click
        If blnAcc_Exist = True Then
            If lblAdoboCounterOrder.Text < 1 Then
                MsgBox("Cannot remove order if there is no order")
            Else
                Const price As Integer = 499
                Const product As String = "Adobo De Los Naturales"
                MsgBox("Removed to Cart", 64 + 0, "Adobo De Los Naturales")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblAdoboCounterOrder.Text -= 1
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

            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnOrderLumpia_Click(sender As Object, e As EventArgs) Handles btnOrderLumpia.Click
        Dim choosed_order As String
        choosed_order = LCase(InputBox("Which lumpiang shanghai?", "MunchBear | Lumpiang Shanghai", "Beef or Pork"))
        Select Case choosed_order
            Case = "beef"
                If blnAcc_Exist = True Then
                    Const price As Integer = 299
                    Const product As String = "Lumpiang Shanghai Beef"
                    MsgBox("Added to Cart", 64 + 0, "Lumpiang Shanghai Beef")
                    frmMunchBear.lblCounterOrder.Text += 1
                    lblCounterLSBeef.Text += 1
                    quantity = 0
                    totalprice = 0

                    If Not frmCheckout.setAssigned1 Then
                        frmCheckout.lblQuantity1.Visible = True
                        frmCheckout.lblPrice1.Visible = True
                        frmCheckout.lblProduct1.Visible = True
                        frmCheckout.lblQuantity1.Text = "12"
                        frmCheckout.lblProduct1.Text = product
                        frmCheckout.lblPrice1.Text = price
                        frmCheckout.setAssigned1 = True
                    ElseIf frmCheckout.lblProduct1.Text = product Then
                        quantity = frmCheckout.lblQuantity1.Text
                        quantity += 12
                        frmCheckout.lblQuantity1.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice1.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned2 Then
                        frmCheckout.lblQuantity2.Visible = True
                        frmCheckout.lblProduct2.Visible = True
                        frmCheckout.lblPrice2.Visible = True
                        frmCheckout.lblQuantity2.Text = "12"
                        frmCheckout.lblProduct2.Text = product
                        frmCheckout.lblPrice2.Text = price
                        frmCheckout.setAssigned2 = True
                    ElseIf frmCheckout.lblProduct2.Text = product Then
                        quantity = frmCheckout.lblQuantity2.Text
                        quantity += 12
                        frmCheckout.lblQuantity2.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice2.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned3 Then
                        frmCheckout.lblQuantity3.Visible = True
                        frmCheckout.lblPrice3.Visible = True
                        frmCheckout.lblProduct3.Visible = True
                        frmCheckout.lblQuantity3.Text = "12"
                        frmCheckout.lblProduct3.Text = product
                        frmCheckout.lblPrice3.Text = price
                        frmCheckout.setAssigned3 = True
                    ElseIf frmCheckout.lblProduct3.Text = product Then
                        quantity = frmCheckout.lblQuantity3.Text
                        quantity += 12
                        frmCheckout.lblQuantity3.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice3.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned4 Then
                        frmCheckout.lblQuantity4.Visible = True
                        frmCheckout.lblPrice4.Visible = True
                        frmCheckout.lblProduct4.Visible = True
                        frmCheckout.lblQuantity4.Text = "12"
                        frmCheckout.lblProduct4.Text = product
                        frmCheckout.lblPrice4.Text = price
                        frmCheckout.setAssigned4 = True
                    ElseIf frmCheckout.lblProduct4.Text = product Then
                        quantity = frmCheckout.lblQuantity4.Text
                        quantity += 12
                        frmCheckout.lblQuantity4.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice4.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned5 Then
                        frmCheckout.lblQuantity5.Visible = True
                        frmCheckout.lblPrice5.Visible = True
                        frmCheckout.lblProduct5.Visible = True
                        frmCheckout.lblQuantity5.Text = "12"
                        frmCheckout.lblProduct5.Text = product
                        frmCheckout.lblPrice5.Text = price
                        frmCheckout.setAssigned5 = True
                    ElseIf frmCheckout.lblProduct5.Text = product Then
                        quantity = frmCheckout.lblQuantity5.Text
                        quantity += 12
                        frmCheckout.lblQuantity5.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice5.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned6 Then
                        frmCheckout.lblQuantity6.Visible = True
                        frmCheckout.lblPrice6.Visible = True
                        frmCheckout.lblProduct6.Visible = True
                        frmCheckout.lblQuantity6.Text = "12"
                        frmCheckout.lblProduct6.Text = product
                        frmCheckout.lblPrice6.Text = price
                        frmCheckout.setAssigned6 = True
                    ElseIf frmCheckout.lblProduct6.Text = product Then
                        quantity = frmCheckout.lblQuantity6.Text
                        quantity += 12
                        frmCheckout.lblQuantity6.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice6.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned7 Then
                        frmCheckout.lblQuantity7.Visible = True
                        frmCheckout.lblPrice7.Visible = True
                        frmCheckout.lblProduct7.Visible = True
                        frmCheckout.lblQuantity7.Text = "12"
                        frmCheckout.lblProduct7.Text = product
                        frmCheckout.lblPrice7.Text = price
                        frmCheckout.setAssigned7 = True
                    ElseIf frmCheckout.lblProduct7.Text = product Then
                        quantity = frmCheckout.lblQuantity7.Text
                        quantity += 12
                        frmCheckout.lblQuantity7.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice7.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned8 Then
                        frmCheckout.lblQuantity8.Visible = True
                        frmCheckout.lblPrice8.Visible = True
                        frmCheckout.lblProduct8.Visible = True
                        frmCheckout.lblQuantity8.Text = "12"
                        frmCheckout.lblProduct8.Text = product
                        frmCheckout.lblPrice8.Text = price
                        frmCheckout.setAssigned8 = True
                    ElseIf frmCheckout.lblProduct8.Text = product Then
                        quantity = frmCheckout.lblQuantity8.Text
                        quantity += 12
                        frmCheckout.lblQuantity8.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice8.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned9 Then
                        frmCheckout.lblQuantity9.Visible = True
                        frmCheckout.lblPrice9.Visible = True
                        frmCheckout.lblProduct9.Visible = True
                        frmCheckout.lblQuantity9.Text = "12"
                        frmCheckout.lblProduct9.Text = product
                        frmCheckout.lblPrice9.Text = price
                        frmCheckout.setAssigned9 = True
                    ElseIf frmCheckout.lblProduct9.Text = product Then
                        quantity = frmCheckout.lblQuantity9.Text
                        quantity += 12
                        frmCheckout.lblQuantity9.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice9.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned10 Then
                        frmCheckout.lblQuantity10.Visible = True
                        frmCheckout.lblPrice10.Visible = True
                        frmCheckout.lblProduct10.Visible = True
                        frmCheckout.lblQuantity10.Text = "12"
                        frmCheckout.lblProduct10.Text = product
                        frmCheckout.lblPrice10.Text = price
                        frmCheckout.SetAssigned11 = True
                    ElseIf frmCheckout.lblProduct10.Text = product Then
                        quantity = frmCheckout.lblQuantity10.Text
                        quantity += 12
                        frmCheckout.lblQuantity10.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice10.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned11 Then
                        frmCheckout.lblQuantity11.Visible = True
                        frmCheckout.lblPrice11.Visible = True
                        frmCheckout.lblProduct11.Visible = True
                        frmCheckout.lblQuantity11.Text = "12"
                        frmCheckout.lblProduct11.Text = product
                        frmCheckout.lblPrice11.Text = price
                        frmCheckout.SetAssigned11 = True
                    ElseIf frmCheckout.lblProduct11.Text = product Then
                        quantity = frmCheckout.lblQuantity11.Text
                        quantity += 12
                        frmCheckout.lblQuantity11.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice11.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned12 Then
                        frmCheckout.lblQuantity12.Visible = True
                        frmCheckout.lblPrice12.Visible = True
                        frmCheckout.lblProduct12.Visible = True
                        frmCheckout.lblQuantity12.Text = "12"
                        frmCheckout.lblProduct12.Text = product
                        frmCheckout.lblPrice12.Text = price
                        frmCheckout.SetAssigned12 = True
                    ElseIf frmCheckout.lblProduct12.Text = product Then
                        quantity = frmCheckout.lblQuantity12.Text
                        quantity += 12
                        frmCheckout.lblQuantity12.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice12.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned13 Then
                        frmCheckout.lblQuantity13.Visible = True
                        frmCheckout.lblPrice13.Visible = True
                        frmCheckout.lblProduct13.Visible = True
                        frmCheckout.lblQuantity13.Text = "12"
                        frmCheckout.lblProduct13.Text = product
                        frmCheckout.lblPrice13.Text = price
                        frmCheckout.SetAssigned13 = True
                    ElseIf frmCheckout.lblProduct13.Text = product Then
                        quantity = frmCheckout.lblQuantity13.Text
                        quantity += 12
                        frmCheckout.lblQuantity13.Text = quantity
                        quantity = lblCounterLSBeef.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice13.Text = totalprice
                    Else
                        MsgBox("Maximum Order Reached")
                    End If
                Else
                    MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
                End If
            Case = "pork"
                If blnAcc_Exist = True Then
                    Const price As Integer = 299
                    Const product As String = "Lumpiang Shanghai Pork"
                    MsgBox("Added to Cart", 64 + 0, "Lumpiang Shanghai Pork")
                    frmMunchBear.lblCounterOrder.Text += 1
                    lblCounterLSPork.Text += 1
                    quantity = 0
                    totalprice = 0

                    If Not frmCheckout.setAssigned1 Then
                        frmCheckout.lblQuantity1.Visible = True
                        frmCheckout.lblPrice1.Visible = True
                        frmCheckout.lblProduct1.Visible = True
                        frmCheckout.lblQuantity1.Text = "12"
                        frmCheckout.lblProduct1.Text = product
                        frmCheckout.lblPrice1.Text = price
                        frmCheckout.setAssigned1 = True
                    ElseIf frmCheckout.lblProduct1.Text = product Then
                        quantity = frmCheckout.lblQuantity1.Text
                        quantity += 12
                        frmCheckout.lblQuantity1.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice1.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned2 Then
                        frmCheckout.lblQuantity2.Visible = True
                        frmCheckout.lblProduct2.Visible = True
                        frmCheckout.lblPrice2.Visible = True
                        frmCheckout.lblQuantity2.Text = "12"
                        frmCheckout.lblProduct2.Text = product
                        frmCheckout.lblPrice2.Text = price
                        frmCheckout.setAssigned2 = True
                    ElseIf frmCheckout.lblProduct2.Text = product Then
                        quantity = frmCheckout.lblQuantity2.Text
                        quantity += 12
                        frmCheckout.lblQuantity2.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice2.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned3 Then
                        frmCheckout.lblQuantity3.Visible = True
                        frmCheckout.lblPrice3.Visible = True
                        frmCheckout.lblProduct3.Visible = True
                        frmCheckout.lblQuantity3.Text = "12"
                        frmCheckout.lblProduct3.Text = product
                        frmCheckout.lblPrice3.Text = price
                        frmCheckout.setAssigned3 = True
                    ElseIf frmCheckout.lblProduct3.Text = product Then
                        quantity = frmCheckout.lblQuantity3.Text
                        quantity += 2
                        frmCheckout.lblQuantity3.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice3.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned4 Then
                        frmCheckout.lblQuantity4.Visible = True
                        frmCheckout.lblPrice4.Visible = True
                        frmCheckout.lblProduct4.Visible = True
                        frmCheckout.lblQuantity4.Text = "12"
                        frmCheckout.lblProduct4.Text = product
                        frmCheckout.lblPrice4.Text = price
                        frmCheckout.setAssigned4 = True
                    ElseIf frmCheckout.lblProduct4.Text = product Then
                        quantity = frmCheckout.lblQuantity4.Text
                        quantity += 12
                        frmCheckout.lblQuantity4.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice4.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned5 Then
                        frmCheckout.lblQuantity5.Visible = True
                        frmCheckout.lblPrice5.Visible = True
                        frmCheckout.lblProduct5.Visible = True
                        frmCheckout.lblQuantity5.Text = "12"
                        frmCheckout.lblProduct5.Text = product
                        frmCheckout.lblPrice5.Text = price
                        frmCheckout.setAssigned5 = True
                    ElseIf frmCheckout.lblProduct5.Text = product Then
                        quantity = frmCheckout.lblQuantity5.Text
                        quantity += 12
                        frmCheckout.lblQuantity5.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice5.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned6 Then
                        frmCheckout.lblQuantity6.Visible = True
                        frmCheckout.lblPrice6.Visible = True
                        frmCheckout.lblProduct6.Visible = True
                        frmCheckout.lblQuantity6.Text = "12"
                        frmCheckout.lblProduct6.Text = product
                        frmCheckout.lblPrice6.Text = price
                        frmCheckout.setAssigned6 = True
                    ElseIf frmCheckout.lblProduct6.Text = product Then
                        quantity = frmCheckout.lblQuantity6.Text
                        quantity += 12
                        frmCheckout.lblQuantity6.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice6.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned7 Then
                        frmCheckout.lblQuantity7.Visible = True
                        frmCheckout.lblPrice7.Visible = True
                        frmCheckout.lblProduct7.Visible = True
                        frmCheckout.lblQuantity7.Text = "12"
                        frmCheckout.lblProduct7.Text = product
                        frmCheckout.lblPrice7.Text = price
                        frmCheckout.setAssigned7 = True
                    ElseIf frmCheckout.lblProduct7.Text = product Then
                        quantity = frmCheckout.lblQuantity7.Text
                        quantity += 12
                        frmCheckout.lblQuantity7.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice7.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned8 Then
                        frmCheckout.lblQuantity8.Visible = True
                        frmCheckout.lblPrice8.Visible = True
                        frmCheckout.lblProduct8.Visible = True
                        frmCheckout.lblQuantity8.Text = "12"
                        frmCheckout.lblProduct8.Text = product
                        frmCheckout.lblPrice8.Text = price
                        frmCheckout.setAssigned8 = True
                    ElseIf frmCheckout.lblProduct8.Text = product Then
                        quantity = frmCheckout.lblQuantity8.Text
                        quantity += 12
                        frmCheckout.lblQuantity8.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice8.Text = totalprice
                    ElseIf Not frmCheckout.setAssigned9 Then
                        frmCheckout.lblQuantity9.Visible = True
                        frmCheckout.lblPrice9.Visible = True
                        frmCheckout.lblProduct9.Visible = True
                        frmCheckout.lblQuantity9.Text = "12"
                        frmCheckout.lblProduct9.Text = product
                        frmCheckout.lblPrice9.Text = price
                        frmCheckout.setAssigned9 = True
                    ElseIf frmCheckout.lblProduct9.Text = product Then
                        quantity = frmCheckout.lblQuantity9.Text
                        quantity += 12
                        totalprice = quantity * price
                        frmCheckout.lblQuantity9.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice9.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned10 Then
                        frmCheckout.lblQuantity10.Visible = True
                        frmCheckout.lblPrice10.Visible = True
                        frmCheckout.lblProduct10.Visible = True
                        frmCheckout.lblQuantity10.Text = "12"
                        frmCheckout.lblProduct10.Text = product
                        frmCheckout.lblPrice10.Text = price
                        frmCheckout.SetAssigned11 = True
                    ElseIf frmCheckout.lblProduct10.Text = product Then
                        quantity = frmCheckout.lblQuantity10.Text
                        quantity += 12
                        frmCheckout.lblQuantity10.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice10.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned11 Then
                        frmCheckout.lblQuantity11.Visible = True
                        frmCheckout.lblPrice11.Visible = True
                        frmCheckout.lblProduct11.Visible = True
                        frmCheckout.lblQuantity11.Text = "12"
                        frmCheckout.lblProduct11.Text = product
                        frmCheckout.lblPrice11.Text = price
                        frmCheckout.SetAssigned11 = True
                    ElseIf frmCheckout.lblProduct11.Text = product Then
                        quantity = frmCheckout.lblQuantity11.Text
                        quantity += 12
                        frmCheckout.lblQuantity11.Text = quantity
                        quantity = lblCounterLSPork.Text
                        frmCheckout.lblPrice11.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned12 Then
                        frmCheckout.lblQuantity12.Visible = True
                        frmCheckout.lblPrice12.Visible = True
                        frmCheckout.lblProduct12.Visible = True
                        frmCheckout.lblQuantity12.Text = "12"
                        frmCheckout.lblProduct12.Text = product
                        frmCheckout.lblPrice12.Text = price
                        frmCheckout.SetAssigned12 = True
                    ElseIf frmCheckout.lblProduct12.Text = product Then
                        quantity = frmCheckout.lblQuantity12.Text
                        quantity += 12
                        frmCheckout.lblQuantity12.Text = quantity
                        quantity = lblCounterLSPork.Text
                        frmCheckout.lblPrice12.Text = totalprice
                    ElseIf Not frmCheckout.SetAssigned13 Then
                        frmCheckout.lblQuantity13.Visible = True
                        frmCheckout.lblPrice13.Visible = True
                        frmCheckout.lblProduct13.Visible = True
                        frmCheckout.lblQuantity13.Text = "12"
                        frmCheckout.lblProduct13.Text = product
                        frmCheckout.lblPrice13.Text = price
                        frmCheckout.SetAssigned13 = True
                    ElseIf frmCheckout.lblProduct13.Text = product Then
                        quantity = frmCheckout.lblQuantity13.Text
                        quantity += 12
                        frmCheckout.lblQuantity13.Text = quantity
                        quantity = lblCounterLSPork.Text
                        totalprice = quantity * price
                        frmCheckout.lblPrice13.Text = totalprice
                    Else
                        MsgBox("Maximum Order Reached")
                    End If
                Else
                    MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
                End If
            Case Else
                MsgBox("Option is not on the list.")
        End Select

    End Sub

    Private Sub btnAddLSBeef_Click(sender As Object, e As EventArgs) Handles btnAddLSBeef.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 299
            Const product As String = "Lumpiang Shanghai Beef"
            MsgBox("Added to Cart", 64 + 0, "Lumpiang Shanghai Beef")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterLSBeef.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "12"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity += 12
                frmCheckout.lblQuantity1.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "12"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 12
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "12"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 12
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "12"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 12
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "12"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 12
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "12"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 12
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "12"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 12
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "12"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 12
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "12"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 12
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "12"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 12
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "12"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 12
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "12"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 12
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "12"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 12
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Maximum Order Reached")
            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnReduceLSBeef_Click(sender As Object, e As EventArgs) Handles btnReduceLSBeef.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 299
            Const product As String = "Lumpiang Shanghai Beef"
            MsgBox("Added to Cart", 64 + 0, "Lumpiang Shanghai Beef")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterLSBeef.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "12"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity -= 12
                frmCheckout.lblQuantity1.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "12"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity -= 12
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "12"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity -= 12
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "12"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity -= 12
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "12"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity -= 12
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "12"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity -= 12
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "12"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity -= 12
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "12"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity -= 12
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "12"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity -= 12
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "12"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity -= 12
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "12"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity -= 12
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "12"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity -= 12
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "12"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity -= 12
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterLSBeef.Text
                totalprice = quantity * price
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Maximum Order Reached")
            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnAddLSPork_Click(sender As Object, e As EventArgs) Handles btnAddLSPork.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 299
            Const product As String = "Lumpiang Shanghai Pork"
            MsgBox("Added to Cart", 64 + 0, "Lumpiang Shanghai Pork")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterLSPork.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "12"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity += 12
                frmCheckout.lblQuantity1.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "12"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 12
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "12"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "12"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 12
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "12"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 12
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "12"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 12
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "12"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 12
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "12"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 12
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "12"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 12
                totalprice = quantity * price
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "12"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 12
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "12"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 12
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterLSPork.Text
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "12"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 12
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterLSPork.Text
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "12"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 12
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Maximum Order Reached")
            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnReduceLSPork_Click(sender As Object, e As EventArgs) Handles btnReduceLSPork.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 299
            Const product As String = "Lumpiang Shanghai Pork"
            MsgBox("Added to Cart", 64 + 0, "Lumpiang Shanghai Pork")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterLSPork.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "12"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity1.Text
                quantity -= 12
                frmCheckout.lblQuantity1.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "12"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity -= 12
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice2.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "12"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice3.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "12"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity -= 12
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice4.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "12"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity -= 12
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice5.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "12"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity -= 12
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice6.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "12"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity -= 12
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice7.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "12"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity -= 12
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice8.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "12"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity -= 12
                totalprice = quantity * price
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice9.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "12"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity -= 12
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice10.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "12"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity -= 12
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterLSPork.Text
                frmCheckout.lblPrice11.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "12"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity -= 12
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterLSPork.Text
                frmCheckout.lblPrice12.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "12"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity -= 12
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterLSPork.Text
                totalprice = quantity * price
                frmCheckout.lblPrice13.Text = totalprice
            Else
                MsgBox("Maximum Order Reached")
            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnOrderSinigang_Click(sender As Object, e As EventArgs) Handles btnOrderSinigang.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 250
            Const product As String = "Sinigang"
            MsgBox("Added to Cart", 64 + 0, "Sinigang")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterSinigangOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnAddSinigang_Click(sender As Object, e As EventArgs) Handles btnAddSinigang.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 250
            Const product As String = "Sinigang"
            MsgBox("Added to Cart", 64 + 0, "Sinigang")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterSinigangOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnReduceSinigang_Click(sender As Object, e As EventArgs) Handles btnReduceSinigang.Click
        If blnAcc_Exist = True Then
            If lblCounterSinigangOrder.Text < 1 Then
                MsgBox("Cannot remove order if there is no order")
            Else
                Const price As Integer = 250
                Const product As String = "Sinigang"
                MsgBox("Removed to Cart", 64 + 0, "Sinigang")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblAdoboCounterOrder.Text -= 1
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
                    quantity += 1
                    totalprice = quantity * price
                    frmCheckout.lblQuantity13.Text = quantity
                    frmCheckout.lblPrice13.Text = totalprice
                Else
                    MsgBox("Maximum Order Reached")
                End If

            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnOrderSisig_Click(sender As Object, e As EventArgs) Handles btnOrderSisig.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 260
            Const product As String = "Sizzling Sisig"
            MsgBox("Sizzling Sisig", 64 + 0, "Sizzling Sisig")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterSisigOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnAddSisig_Click(sender As Object, e As EventArgs) Handles btnAddSisig.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 260
            Const product As String = "Sizzling Sisig"
            MsgBox("Sizzling Sisig", 64 + 0, "Sizzling Sisig")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterSisigOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnReduceSisig_Click(sender As Object, e As EventArgs) Handles btnReduceSisig.Click
        If blnAcc_Exist = True Then
            If lblCounterSisigOrder.Text < 1 Then
                MsgBox("Cannot remove order if there is no order")
            Else
                Const price As Integer = 260
                Const product As String = "Sizzling Sisig"
                MsgBox("Removed to Cart", 64 + 0, "Sizzling Sisig")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblCounterSisigOrder.Text -= 1
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

            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnOrderAfritada_Click(sender As Object, e As EventArgs) Handles btnOrderAfritada.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 350
            Const product As String = "Afritada"
            MsgBox("Afritada", 64 + 0, "Afritada")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterAfritadaOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnAddAfritada_Click(sender As Object, e As EventArgs) Handles btnAddAfritada.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 350
            Const product As String = "Afritada"
            MsgBox("Afritada", 64 + 0, "Afritada")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterAfritadaOrder.Text += 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnReduceAfritada_Click(sender As Object, e As EventArgs) Handles btnReduceAfritada.Click
        If blnAcc_Exist = True Then
            If lblCounterAfritadaOrder.Text < 1 Then
                MsgBox("Cannot remove order if there is no order")
            Else
                Const price As Integer = 350
                Const product As String = "Afritada"
                MsgBox("Removed to Cart", 64 + 0, "Afritada")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblCounterAfritadaOrder.Text -= 1
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

            End If
        Else
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

End Class