Public Class frmCheckout

    Public assigned() As Boolean
    Public itemdesc() As Label
    Public no() As Label
    Public qty() As Label
    Public price() As Label

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeArray()
    End Sub

    Sub InitializeArray()
        ' Initialize the array with specific values
        assigned = New Boolean(5) {False, False, False, False, False, False}
        itemdesc = New Label(6) {lblItmDesc, lblItmDesc1, lblItmDesc2, lblItmDesc3, lblItmDesc4, lblItmDesc5, lblItmDesc6}
        no = New Label(6) {lblNums, lblNo1, lblNo2, lblNo3, lblNo4, lblNo5, lblNo6}
        qty = New Label(6) {lblQty, lblQty1, lblQty2, lblQty3, lblQty4, lblQty5, lblQty6}
        price = New Label(6) {lblPrice, lblPrice1, lblPrice2, lblPrice3, lblPrice4, lblPrice5, lblPrice6}

        itemdesc(0).Text = "Item Description"
        itemdesc(1).Text = ""
        itemdesc(2).Text = ""
        itemdesc(3).Text = ""
        itemdesc(4).Text = ""
        itemdesc(5).Text = ""
        itemdesc(6).Text = ""

    End Sub

    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sum As Decimal
        'Dim counter As Integer

        sum += Val(lblPrice1.Text)
        sum += Val(lblPrice2.Text)
        sum += Val(lblPrice3.Text)
        sum += Val(lblPrice4.Text)
        sum += Val(lblPrice5.Text)
        sum += Val(lblPrice6.Text)

        lblPrice1.Text = FormatCurrency(lblPrice1.Text)
        lblPrice2.Text = FormatCurrency(lblPrice2.Text)
        lblPrice3.Text = FormatCurrency(lblPrice3.Text)
        lblPrice4.Text = FormatCurrency(lblPrice4.Text)
        lblPrice5.Text = FormatCurrency(lblPrice5.Text)
        lblPrice6.Text = FormatCurrency(lblPrice6.Text)

        lblSumPrices.Text = FormatCurrency(sum)

    End Sub

End Class
