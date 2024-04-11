Public Class frmAppetizer
    Dim quantity As Integer, totalprice As Integer
    Public blnAcc_Exist As Boolean

    Private Sub btnOrderVegetableSalad_Click(sender As Object, e As EventArgs) Handles btnOrderVegetableSalad.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 180
            Const product As String = "Vegetable Salad"
            MsgBox("Added to Cart", 64 + 0, "Vegetable Salad")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterVSOrder.Text += 1
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

    Private Sub btnAddVegetableSalad_Click(sender As Object, e As EventArgs) Handles btnAddVegetableSalad.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 180
            Const product As String = "Vegetable Salad"
            MsgBox("Added to Cart", 64 + 0, "Vegetable Salad")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterVSOrder.Text += 1
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

    Private Sub btnReduceVegetableSalad_Click(sender As Object, e As EventArgs) Handles btnReduceVegetableSalad.Click
        If blnAcc_Exist = True Then
            If lblCounterVSOrder.Text < 1 Then
                Const price As Integer = 180
                Const product As String = "Vegetable Salad"
                MsgBox("Removed to Cart", 64 + 0, "Vegetable Salad")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblCounterVSOrder.Text -= 1
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
            MsgBox("No Account, No Order", vbExclamation + vbOKOnly, "MunchBear | Account")
        End If
    End Sub

    Private Sub btnOrderMashedPotato_Click(sender As Object, e As EventArgs) Handles btnOrderMashedPotato.Click
        Dim choosed_order As String
        choosed_order = LCase(InputBox("Which mashed potato?", "MunchBear | Lumpiang Shanghai", "Buttered or Garlic"))
        Select Case choosed_order
            Case = "buttered"
                If blnAcc_Exist = True Then
                    Const price As Integer = 170
                    Const product As String = "Mashed Potato Buttered"
                    MsgBox("Added to Cart", 64 + 0, "Mashed Potato Buttered")
                    frmMunchBear.lblCounterOrder.Text += 1
                    lblCounterMPButtered.Text += 1
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
            Case = "garlic"
                If blnAcc_Exist = True Then
                    Const price As Integer = 170
                    Const product As String = "Mashed Potato Garlic"
                    MsgBox("Added to Cart", 64 + 0, "Mashed Potato Garlic")
                    frmMunchBear.lblCounterOrder.Text += 1
                    lblCounterMPGarlic.Text += 1
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
            Case Else
                MsgBox("Option is not on the list.")
        End Select

    End Sub

    Private Sub btnAddMPButtered_Click(sender As Object, e As EventArgs) Handles btnAddMPButtered.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 170
            Const product As String = "Mashed Potato Buttered"
            MsgBox("Added to Cart", 64 + 0, "Mashed Potato Buttered")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterMPButtered.Text += 1
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

    Private Sub btnAddMPGarlic_Click(sender As Object, e As EventArgs) Handles btnAddMPGarlic.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 170
            Const product As String = "Mashed Potato Garlic"
            MsgBox("Added to Cart", 64 + 0, "Mashed Potato Garlic")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterMPGarlic.Text += 1
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

    Private Sub btnReduceMPButtered_Click(sender As Object, e As EventArgs) Handles btnReduceMPButtered.Click
        If blnAcc_Exist = True Then
            If lblCounterMPButtered.Text < 1 Then
                MsgBox("Cannot remove order if order is 0")
            Else
                Const price As Integer = 170
                Const product As String = "Mashed Potato Buttered"
                MsgBox("Removed to Cart", 64 + 0, "Mashed Potato Buttered")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblCounterMPButtered.Text -= 1
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

    Private Sub btnReduceMPGarlic_Click(sender As Object, e As EventArgs) Handles btnReduceMPGarlic.Click
        If blnAcc_Exist = True Then
            If lblCounterMPGarlic.Text < 1 Then
                MsgBox("Cannot remove order if order is 0")
            Else
                Const price As Integer = 170
                Const product As String = "Mashed Potato Garlic"
                MsgBox("Removed to Cart", 64 + 0, "Mashed Potato Garlic")
                frmMunchBear.lblCounterOrder.Text -= 1
                lblCounterMPButtered.Text -= 1
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

    Private Sub btnOrderEmpanada_Click(sender As Object, e As EventArgs) Handles btnOrderEmpanada.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 120
            Const product As String = "Empanada"
            MsgBox("Added to Cart", 64 + 0, "Empanada")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterEmpanadaOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "2"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity -= 2
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "2"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity -= 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "2"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "2"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 2
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "2"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 2
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "2"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 2
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "2"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 2
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "2"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 2
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "2"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 2
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "2"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 2
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "2"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 2
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "2"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 2
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "2"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 2
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If

    End Sub

    Private Sub btnAddEmpanada_Click(sender As Object, e As EventArgs) Handles btnAddEmpanada.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 120
            Const product As String = "Empanada"
            MsgBox("Added to Cart", 64 + 0, "Empanada")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterEmpanadaOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "2"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 2
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "2"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "2"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "2"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 2
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "2"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 2
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "2"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 2
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "2"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 2
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "2"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 2
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "2"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 2
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "2"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 2
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "2"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 2
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "2"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 2
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "2"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 2
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnReduceEmpanada_Click(sender As Object, e As EventArgs) Handles btnReduceEmpanada.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 120
            Const product As String = "Empanada"
            MsgBox("Removed to Cart", 64 + 0, "Empanada")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterEmpanadaOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "2"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 2
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "2"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "2"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 2
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "2"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 2
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "2"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 2
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "2"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 2
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "2"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 2
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "2"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 2
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "2"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 2
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "2"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 2
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "2"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 2
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "2"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 2
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "2"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 2
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnOrderCalamares_Click(sender As Object, e As EventArgs) Handles btnOrderCalamares.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 120
            Const product As String = "Calamares"
            MsgBox("Added to Cart", 64 + 0, "Calamares")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterCalamaresOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "10"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 10
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "10"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "10"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "10"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 10
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "10"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 10
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "10"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 10
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "10"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 10
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "10"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 10
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "10"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 10
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "10"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 10
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "10"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 10
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "10"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 10
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "10"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 10
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnAddCalamares_Click(sender As Object, e As EventArgs) Handles btnAddCalamares.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 120
            Const product As String = "Calamares"
            MsgBox("Added to Cart", 64 + 0, "Calamares")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterCalamaresOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "10"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 10
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "10"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "10"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "10"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 10
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "10"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 10
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "10"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 10
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "10"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 10
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "10"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 10
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "10"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 10
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "10"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 10
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "10"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 10
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "10"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 10
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "10"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 10
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnReduceCalamares_Click(sender As Object, e As EventArgs) Handles btnReduceCalamares.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 120
            Const product As String = "Calamares"
            MsgBox("Remove to Cart", 64 + 0, "Calamares")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterCalamaresOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "10"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity -= 10
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "10"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity -= 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "10"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity -= 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "10"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity -= 10
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "10"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity -= 10
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "10"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity -= 10
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "10"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity -= 10
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "10"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity -= 10
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "10"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity -= 10
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "10"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity -= 10
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "10"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity -= 10
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "10"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity -= 10
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "10"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity -= 10
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnOrderPandesal_Click(sender As Object, e As EventArgs) Handles btnOrderPandesal.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 30
            Const product As String = "Pandesal"
            MsgBox("Added to Cart", 64 + 0, "Pandesal")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterCalamaresOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "10"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 10
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "10"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "10"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "10"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 10
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "10"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 10
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "10"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 10
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "10"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 10
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "10"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 10
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "10"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 10
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "10"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 10
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "10"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 10
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "10"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 10
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "10"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 10
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnAddPandesal_Click(sender As Object, e As EventArgs) Handles btnAddPandesal.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 30
            Const product As String = "Pandesal"
            MsgBox("Added to Cart", 64 + 0, "Pandesal")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterCalamaresOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "10"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity += 10
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "10"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "10"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity += 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "10"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity += 10
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "10"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity += 10
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "10"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity += 10
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "10"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity += 10
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "10"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity += 10
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "10"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity += 10
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "10"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity += 10
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "10"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity += 10
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "10"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity += 10
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "10"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity += 10
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnReducePandesal_Click(sender As Object, e As EventArgs) Handles btnReducePandesal.Click
        If blnAcc_Exist = True Then
            Const price As Integer = 30
            Const product As String = "Pandesal"
            MsgBox("Removed to Cart", 64 + 0, "Pandesal")
            frmMunchBear.lblCounterOrder.Text += 1
            lblCounterCalamaresOrder.Text += 1
            quantity = 0
            totalprice = 0

            If Not frmCheckout.setAssigned1 Then
                frmCheckout.lblQuantity1.Visible = True
                frmCheckout.lblPrice1.Visible = True
                frmCheckout.lblProduct1.Visible = True
                frmCheckout.lblQuantity1.Text = "10"
                frmCheckout.lblProduct1.Text = product
                frmCheckout.lblPrice1.Text = price
                frmCheckout.setAssigned1 = True
            ElseIf frmCheckout.lblProduct1.Text = product Then
                quantity = frmCheckout.lblQuantity2.Text
                quantity -= 10
                frmCheckout.lblQuantity2.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned2 Then
                frmCheckout.lblQuantity2.Visible = True
                frmCheckout.lblProduct2.Visible = True
                frmCheckout.lblPrice2.Visible = True
                frmCheckout.lblQuantity2.Text = "10"
                frmCheckout.lblProduct2.Text = product
                frmCheckout.lblPrice2.Text = price
                frmCheckout.setAssigned2 = True
            ElseIf frmCheckout.lblProduct2.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity -= 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned3 Then
                frmCheckout.lblQuantity3.Visible = True
                frmCheckout.lblPrice3.Visible = True
                frmCheckout.lblProduct3.Visible = True
                frmCheckout.lblQuantity3.Text = "10"
                frmCheckout.lblProduct3.Text = product
                frmCheckout.lblPrice3.Text = price
                frmCheckout.setAssigned3 = True
            ElseIf frmCheckout.lblProduct3.Text = product Then
                quantity = frmCheckout.lblQuantity3.Text
                quantity -= 10
                frmCheckout.lblQuantity3.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned4 Then
                frmCheckout.lblQuantity4.Visible = True
                frmCheckout.lblPrice4.Visible = True
                frmCheckout.lblProduct4.Visible = True
                frmCheckout.lblQuantity4.Text = "10"
                frmCheckout.lblProduct4.Text = product
                frmCheckout.lblPrice4.Text = price
                frmCheckout.setAssigned4 = True
            ElseIf frmCheckout.lblProduct4.Text = product Then
                quantity = frmCheckout.lblQuantity4.Text
                quantity -= 10
                frmCheckout.lblQuantity4.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned5 Then
                frmCheckout.lblQuantity5.Visible = True
                frmCheckout.lblPrice5.Visible = True
                frmCheckout.lblProduct5.Visible = True
                frmCheckout.lblQuantity5.Text = "10"
                frmCheckout.lblProduct5.Text = product
                frmCheckout.lblPrice5.Text = price
                frmCheckout.setAssigned5 = True
            ElseIf frmCheckout.lblProduct5.Text = product Then
                quantity = frmCheckout.lblQuantity5.Text
                quantity -= 10
                frmCheckout.lblQuantity5.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned6 Then
                frmCheckout.lblQuantity6.Visible = True
                frmCheckout.lblPrice6.Visible = True
                frmCheckout.lblProduct6.Visible = True
                frmCheckout.lblQuantity6.Text = "10"
                frmCheckout.lblProduct6.Text = product
                frmCheckout.lblPrice6.Text = price
                frmCheckout.setAssigned6 = True
            ElseIf frmCheckout.lblProduct6.Text = product Then
                quantity = frmCheckout.lblQuantity6.Text
                quantity -= 10
                frmCheckout.lblQuantity6.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned7 Then
                frmCheckout.lblQuantity7.Visible = True
                frmCheckout.lblPrice7.Visible = True
                frmCheckout.lblProduct7.Visible = True
                frmCheckout.lblQuantity7.Text = "10"
                frmCheckout.lblProduct7.Text = product
                frmCheckout.lblPrice7.Text = price
                frmCheckout.setAssigned7 = True
            ElseIf frmCheckout.lblProduct7.Text = product Then
                quantity = frmCheckout.lblQuantity7.Text
                quantity -= 10
                frmCheckout.lblQuantity7.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned8 Then
                frmCheckout.lblQuantity8.Visible = True
                frmCheckout.lblPrice8.Visible = True
                frmCheckout.lblProduct8.Visible = True
                frmCheckout.lblQuantity8.Text = "10"
                frmCheckout.lblProduct8.Text = product
                frmCheckout.lblPrice8.Text = price
                frmCheckout.setAssigned8 = True
            ElseIf frmCheckout.lblProduct8.Text = product Then
                quantity = frmCheckout.lblQuantity8.Text
                quantity -= 10
                frmCheckout.lblQuantity8.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.setAssigned9 Then
                frmCheckout.lblQuantity9.Visible = True
                frmCheckout.lblPrice9.Visible = True
                frmCheckout.lblProduct9.Visible = True
                frmCheckout.lblQuantity9.Text = "10"
                frmCheckout.lblProduct9.Text = product
                frmCheckout.lblPrice9.Text = price
                frmCheckout.setAssigned9 = True
            ElseIf frmCheckout.lblProduct9.Text = product Then
                quantity = frmCheckout.lblQuantity9.Text
                quantity -= 10
                frmCheckout.lblQuantity9.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned10 Then
                frmCheckout.lblQuantity10.Visible = True
                frmCheckout.lblPrice10.Visible = True
                frmCheckout.lblProduct10.Visible = True
                frmCheckout.lblQuantity10.Text = "10"
                frmCheckout.lblProduct10.Text = product
                frmCheckout.lblPrice10.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct10.Text = product Then
                quantity = frmCheckout.lblQuantity10.Text
                quantity -= 10
                frmCheckout.lblQuantity10.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned11 Then
                frmCheckout.lblQuantity11.Visible = True
                frmCheckout.lblPrice11.Visible = True
                frmCheckout.lblProduct11.Visible = True
                frmCheckout.lblQuantity11.Text = "10"
                frmCheckout.lblProduct11.Text = product
                frmCheckout.lblPrice11.Text = price
                frmCheckout.SetAssigned11 = True
            ElseIf frmCheckout.lblProduct11.Text = product Then
                quantity = frmCheckout.lblQuantity11.Text
                quantity -= 10
                frmCheckout.lblQuantity11.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned12 Then
                frmCheckout.lblQuantity12.Visible = True
                frmCheckout.lblPrice12.Visible = True
                frmCheckout.lblProduct12.Visible = True
                frmCheckout.lblQuantity12.Text = "10"
                frmCheckout.lblProduct12.Text = product
                frmCheckout.lblPrice12.Text = price
                frmCheckout.SetAssigned12 = True
            ElseIf frmCheckout.lblProduct12.Text = product Then
                quantity = frmCheckout.lblQuantity12.Text
                quantity -= 10
                frmCheckout.lblQuantity12.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            ElseIf Not frmCheckout.SetAssigned13 Then
                frmCheckout.lblQuantity13.Visible = True
                frmCheckout.lblPrice13.Visible = True
                frmCheckout.lblProduct13.Visible = True
                frmCheckout.lblQuantity13.Text = "10"
                frmCheckout.lblProduct13.Text = product
                frmCheckout.lblPrice13.Text = price
                frmCheckout.SetAssigned13 = True
            ElseIf frmCheckout.lblProduct13.Text = product Then
                quantity = frmCheckout.lblQuantity13.Text
                quantity -= 10
                frmCheckout.lblQuantity13.Text = quantity
                quantity = lblCounterEmpanadaOrder.Text
                totalprice = quantity * price
                frmCheckout.lblPrice1.Text = totalprice
            Else
                MsgBox("Already Assigned")
            End If

        Else
            MsgBox("No Account, No Order")

        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMunchBear.Show()
        Me.Hide()
    End Sub

End Class