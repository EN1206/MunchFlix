Public Class frmOrder
    'Initalizing the values, as when modified it will be then the actual value.
    Dim quantity As Integer = 0, tp_product As Decimal, counter As Integer
    Dim qty(6) As Integer

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        qty(0) = 1
        qty(1) = 1
        qty(2) = 1
        qty(3) = 1
        qty(4) = 1
        qty(5) = 1
        qty(6) = 1

        lblPrice1.Text = FormatCurrency(lblPrice1.Text)
        lblPrice2.Text = FormatCurrency(lblPrice2.Text)
        lblPrice3.Text = FormatCurrency(lblPrice3.Text)

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'Application of If... Then Else Statement & Msgbox (Return Value & Syntax)
        Dim respond As Integer
        respond = MsgBox("Is that everything?", 32 + 4, "Confirmation")
        If respond = 6 Then
            Me.Hide()
            frmCheckout.Show()
        Else
            Return
        End If
    End Sub

    Private Sub btnAddToCartP1_Click(sender As Object, e As EventArgs) Handles btnAddToCartP1.Click
        quantity = qty(1)
        MsgBox("Added to cart", 64 + 0, "Red Rose(s) [Standard]")
        AddItemToCheckout("Red Rose(s) [Standard]", 20.0, quantity)
        lblCurrentStock1.Text -= quantity
    End Sub

    Private Sub btnAddtoCartP2_Click(sender As Object, e As EventArgs) Handles btnAddtoCartP2.Click
        quantity = qty(2)
        MsgBox("Added to cart", 64 + 0, "Yellow Dandelions [Standard]")
        AddItemToCheckout("Yelow Dandelions [Standard]", 35.0, quantity)
        lblCurrentStock2.Text -= quantity
    End Sub

    Private Sub btnAddToCartP3_Click(sender As Object, e As EventArgs) Handles btnAddToCartP3.Click
        quantity = qty(3)
        MsgBox("Added to cart", 64 + 0, "Blue Cornflower(s) [Standard]")
        AddItemToCheckout("Blue Cornflower(s) [Standard]", 50.0, quantity)
        lblCurrentStock3.Text -= quantity
    End Sub

    Private Sub btnQuantityP1_Click(sender As Object, e As EventArgs) Handles btnQuantityP1.Click
        'Application of Do Until, customer entered number greater than 0
        qty(1) = InputBox("How many would you like to order?", "Quantity", "Ex. 1")
        If qty(1) <= 0 Then
            MsgBox("Invalid number please try again.")
            Do Until qty(1) > 0
                qty(1) = InputBox("How many would you like to order?", "Quantity", "Ex. 1")
            Loop
        End If
    End Sub

    Private Sub btnQuantityP2_Click(sender As Object, e As EventArgs) Handles btnQuantityP2.Click
        'Application of Do Until, customer entered number greater than 0
        qty(2) = InputBox("How many would you like to order?", "Quantity", "Ex. 1")
        If qty(2) <= 0 Then
            MsgBox("Invalid number please try again.")
            Do Until qty(2) > 0
                qty(2) = InputBox("How many would you like to order?", "Quantity", "Ex. 1")
            Loop
        End If
    End Sub

    Private Sub btnQuantityP3_Click(sender As Object, e As EventArgs) Handles btnQuantityP3.Click
        'Application of Do Until, customer entered number greater than 0
        qty(3) = InputBox("How many would you like to order?", "Quantity", "Ex. 1")
        If qty(3) <= 0 Then
            MsgBox("Invalid number please try again.")
            Do Until qty(3) > 0
                qty(3) = InputBox("How many would you like to order?", "Quantity", "Ex. 1")
            Loop
        End If
    End Sub

    Private Sub AddItemToCheckout(product As String, price As Decimal, quantity As Integer)
        Dim tp_product As Decimal
        For counter = 1 To 6
            If frmCheckout.itemdesc(counter).Text = "" Then
                frmCheckout.no(counter).Visible = True
                frmCheckout.itemdesc(counter).Visible = True
                frmCheckout.qty(counter).Visible = True
                frmCheckout.price(counter).Visible = True
                frmCheckout.itemdesc(counter).Text = product
                frmCheckout.qty(counter).Text = quantity
                frmCheckout.price(counter).Text = price * qty(counter)
                Exit For
            ElseIf frmCheckout.itemdesc(counter).Text = product Then
                quantity = frmCheckout.qty(counter).Text
                If qty(counter) > quantity Then
                    quantity = frmCheckout.qty(counter).Text + qty(counter)
                Else
                    quantity += 1
                End If
                tp_product = quantity * price
                    frmCheckout.qty(counter).Text = quantity
                    frmCheckout.price(counter).Text = tp_product
                    Exit For
                Else
                    If frmCheckout.lblItmDesc6.Text <> "" Then
                    MsgBox("You have reached the limits and maximum of your order", 48 + 0, "Limit Reached")
                End If
            End If
        Next
    End Sub

End Class