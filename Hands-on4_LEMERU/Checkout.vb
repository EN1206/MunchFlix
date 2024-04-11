
Imports System.Linq

Public Class frmCheckout
    Public setAssigned1 As Boolean = False
    Public setAssigned2 As Boolean = False
    Public setAssigned3 As Boolean = False
    Public setAssigned4 As Boolean = False
    Public setAssigned5 As Boolean = False
    Public setAssigned6 As Boolean = False
    Public setAssigned7 As Boolean = False
    Public setAssigned8 As Boolean = False
    Public setAssigned9 As Boolean = False
    Public SetAssigned10 As Boolean = False
    Public SetAssigned11 As Boolean = False
    Public SetAssigned12 As Boolean = False
    Public SetAssigned13 As Boolean = False
    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblQuantity1.Text = "1" Then
            lblQuantity1.Text = lblQuantity1.Text & "pc"
        Else
            lblQuantity1.Text = lblQuantity1.Text & "pcs"
        End If

        If lblQuantity2.Text = "1" Then
            lblQuantity2.Text = lblQuantity2.Text & "pc"
        Else
            lblQuantity2.Text = lblQuantity2.Text & "pcs"
        End If

        If lblQuantity3.Text = "1" Then
            lblQuantity3.Text = lblQuantity3.Text & "pc"
        Else
            lblQuantity3.Text = lblQuantity3.Text & "pcs"
        End If

        If lblQuantity4.Text = "1" Then
            lblQuantity4.Text = lblQuantity4.Text & "pc"
        Else
            lblQuantity4.Text = lblQuantity4.Text & "pcs"
        End If

        If lblQuantity5.Text = "1" Then
            lblQuantity5.Text = lblQuantity5.Text & "pc"
        Else
            lblQuantity5.Text = lblQuantity5.Text & "pcs"
        End If

        If lblQuantity6.Text = "1" Then
            lblQuantity6.Text = lblQuantity6.Text & "pc"
        Else
            lblQuantity6.Text = lblQuantity6.Text & "pcs"
        End If


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


        lblFinalTotalPrice.Text = FormatCurrency(totalSum)


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

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        MsgBox("Your order has been reset to 0")
        frmMunchBear.lblCounterOrder.Text = "0"

        frmMunchBear.Show()
        Me.Hide()
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