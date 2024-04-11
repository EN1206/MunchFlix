<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNums = New System.Windows.Forms.Label()
        Me.lblItmDesc = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSumPrices = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblPrice6 = New System.Windows.Forms.Label()
        Me.lblQty6 = New System.Windows.Forms.Label()
        Me.lblItmDesc6 = New System.Windows.Forms.Label()
        Me.lblNo6 = New System.Windows.Forms.Label()
        Me.lblPrice5 = New System.Windows.Forms.Label()
        Me.lblQty5 = New System.Windows.Forms.Label()
        Me.lblItmDesc5 = New System.Windows.Forms.Label()
        Me.lblNo5 = New System.Windows.Forms.Label()
        Me.lblPrice3 = New System.Windows.Forms.Label()
        Me.lblQty3 = New System.Windows.Forms.Label()
        Me.lblItmDesc3 = New System.Windows.Forms.Label()
        Me.lblNo3 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.lblPrice4 = New System.Windows.Forms.Label()
        Me.lblQty2 = New System.Windows.Forms.Label()
        Me.lblItmDesc2 = New System.Windows.Forms.Label()
        Me.lblQty4 = New System.Windows.Forms.Label()
        Me.lblNo2 = New System.Windows.Forms.Label()
        Me.lblItmDesc4 = New System.Windows.Forms.Label()
        Me.lblNo4 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.lblQty1 = New System.Windows.Forms.Label()
        Me.lblItmDesc1 = New System.Windows.Forms.Label()
        Me.lblNo1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNums
        '
        Me.lblNums.AutoSize = True
        Me.lblNums.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNums.Location = New System.Drawing.Point(15, 10)
        Me.lblNums.Name = "lblNums"
        Me.lblNums.Size = New System.Drawing.Size(33, 20)
        Me.lblNums.TabIndex = 0
        Me.lblNums.Text = "No."
        '
        'lblItmDesc
        '
        Me.lblItmDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc.Location = New System.Drawing.Point(70, 10)
        Me.lblItmDesc.Name = "lblItmDesc"
        Me.lblItmDesc.Size = New System.Drawing.Size(279, 20)
        Me.lblItmDesc.TabIndex = 1
        Me.lblItmDesc.Text = "Item Description"
        Me.lblItmDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(387, 10)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(68, 20)
        Me.lblQty.TabIndex = 2
        Me.lblQty.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(523, 10)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSumPrices)
        Me.Panel1.Controls.Add(Me.lblColon)
        Me.Panel1.Controls.Add(Me.lblTotalPrice)
        Me.Panel1.Controls.Add(Me.lblPrice6)
        Me.Panel1.Controls.Add(Me.lblQty6)
        Me.Panel1.Controls.Add(Me.lblItmDesc6)
        Me.Panel1.Controls.Add(Me.lblNo6)
        Me.Panel1.Controls.Add(Me.lblPrice5)
        Me.Panel1.Controls.Add(Me.lblQty5)
        Me.Panel1.Controls.Add(Me.lblItmDesc5)
        Me.Panel1.Controls.Add(Me.lblNo5)
        Me.Panel1.Controls.Add(Me.lblPrice3)
        Me.Panel1.Controls.Add(Me.lblQty3)
        Me.Panel1.Controls.Add(Me.lblItmDesc3)
        Me.Panel1.Controls.Add(Me.lblNo3)
        Me.Panel1.Controls.Add(Me.lblPrice2)
        Me.Panel1.Controls.Add(Me.lblPrice4)
        Me.Panel1.Controls.Add(Me.lblQty2)
        Me.Panel1.Controls.Add(Me.lblItmDesc2)
        Me.Panel1.Controls.Add(Me.lblQty4)
        Me.Panel1.Controls.Add(Me.lblNo2)
        Me.Panel1.Controls.Add(Me.lblItmDesc4)
        Me.Panel1.Controls.Add(Me.lblNo4)
        Me.Panel1.Controls.Add(Me.lblPrice1)
        Me.Panel1.Controls.Add(Me.lblQty1)
        Me.Panel1.Controls.Add(Me.lblItmDesc1)
        Me.Panel1.Controls.Add(Me.lblNo1)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.lblItmDesc)
        Me.Panel1.Controls.Add(Me.lblQty)
        Me.Panel1.Controls.Add(Me.lblNums)
        Me.Panel1.Location = New System.Drawing.Point(56, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 359)
        Me.Panel1.TabIndex = 4
        '
        'lblSumPrices
        '
        Me.lblSumPrices.AutoSize = True
        Me.lblSumPrices.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumPrices.ForeColor = System.Drawing.Color.Lime
        Me.lblSumPrices.Location = New System.Drawing.Point(117, 246)
        Me.lblSumPrices.Name = "lblSumPrices"
        Me.lblSumPrices.Size = New System.Drawing.Size(95, 42)
        Me.lblSumPrices.TabIndex = 29
        Me.lblSumPrices.Text = "0.00"
        '
        'lblColon
        '
        Me.lblColon.BackColor = System.Drawing.Color.White
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.Location = New System.Drawing.Point(83, 237)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(28, 58)
        Me.lblColon.TabIndex = 28
        Me.lblColon.Text = ":"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.White
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(19, 237)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(92, 58)
        Me.lblTotalPrice.TabIndex = 27
        Me.lblTotalPrice.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Price"
        '
        'lblPrice6
        '
        Me.lblPrice6.BackColor = System.Drawing.Color.White
        Me.lblPrice6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice6.Location = New System.Drawing.Point(513, 175)
        Me.lblPrice6.Name = "lblPrice6"
        Me.lblPrice6.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice6.TabIndex = 26
        Me.lblPrice6.Text = "0"
        Me.lblPrice6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPrice6.Visible = False
        '
        'lblQty6
        '
        Me.lblQty6.BackColor = System.Drawing.Color.White
        Me.lblQty6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty6.Location = New System.Drawing.Point(391, 175)
        Me.lblQty6.Name = "lblQty6"
        Me.lblQty6.Size = New System.Drawing.Size(64, 18)
        Me.lblQty6.TabIndex = 24
        Me.lblQty6.Text = "Qty"
        Me.lblQty6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQty6.Visible = False
        '
        'lblItmDesc6
        '
        Me.lblItmDesc6.BackColor = System.Drawing.Color.White
        Me.lblItmDesc6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc6.Location = New System.Drawing.Point(74, 175)
        Me.lblItmDesc6.Name = "lblItmDesc6"
        Me.lblItmDesc6.Size = New System.Drawing.Size(275, 18)
        Me.lblItmDesc6.TabIndex = 22
        Me.lblItmDesc6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItmDesc6.Visible = False
        '
        'lblNo6
        '
        Me.lblNo6.BackColor = System.Drawing.Color.White
        Me.lblNo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo6.Location = New System.Drawing.Point(16, 175)
        Me.lblNo6.Name = "lblNo6"
        Me.lblNo6.Size = New System.Drawing.Size(32, 18)
        Me.lblNo6.TabIndex = 20
        Me.lblNo6.Text = "6"
        Me.lblNo6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNo6.Visible = False
        '
        'lblPrice5
        '
        Me.lblPrice5.BackColor = System.Drawing.Color.White
        Me.lblPrice5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice5.Location = New System.Drawing.Point(513, 148)
        Me.lblPrice5.Name = "lblPrice5"
        Me.lblPrice5.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice5.TabIndex = 19
        Me.lblPrice5.Text = "0"
        Me.lblPrice5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPrice5.Visible = False
        '
        'lblQty5
        '
        Me.lblQty5.BackColor = System.Drawing.Color.White
        Me.lblQty5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty5.Location = New System.Drawing.Point(391, 148)
        Me.lblQty5.Name = "lblQty5"
        Me.lblQty5.Size = New System.Drawing.Size(64, 18)
        Me.lblQty5.TabIndex = 18
        Me.lblQty5.Text = "Qty"
        Me.lblQty5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQty5.Visible = False
        '
        'lblItmDesc5
        '
        Me.lblItmDesc5.BackColor = System.Drawing.Color.White
        Me.lblItmDesc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc5.Location = New System.Drawing.Point(74, 148)
        Me.lblItmDesc5.Name = "lblItmDesc5"
        Me.lblItmDesc5.Size = New System.Drawing.Size(275, 18)
        Me.lblItmDesc5.TabIndex = 17
        Me.lblItmDesc5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItmDesc5.Visible = False
        '
        'lblNo5
        '
        Me.lblNo5.BackColor = System.Drawing.Color.White
        Me.lblNo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo5.Location = New System.Drawing.Point(16, 148)
        Me.lblNo5.Name = "lblNo5"
        Me.lblNo5.Size = New System.Drawing.Size(32, 18)
        Me.lblNo5.TabIndex = 16
        Me.lblNo5.Text = "5"
        Me.lblNo5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNo5.Visible = False
        '
        'lblPrice3
        '
        Me.lblPrice3.BackColor = System.Drawing.Color.White
        Me.lblPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice3.Location = New System.Drawing.Point(513, 96)
        Me.lblPrice3.Name = "lblPrice3"
        Me.lblPrice3.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice3.TabIndex = 15
        Me.lblPrice3.Text = "0"
        Me.lblPrice3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPrice3.Visible = False
        '
        'lblQty3
        '
        Me.lblQty3.BackColor = System.Drawing.Color.White
        Me.lblQty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty3.Location = New System.Drawing.Point(391, 96)
        Me.lblQty3.Name = "lblQty3"
        Me.lblQty3.Size = New System.Drawing.Size(64, 18)
        Me.lblQty3.TabIndex = 14
        Me.lblQty3.Text = "Qty"
        Me.lblQty3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQty3.Visible = False
        '
        'lblItmDesc3
        '
        Me.lblItmDesc3.BackColor = System.Drawing.Color.White
        Me.lblItmDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc3.Location = New System.Drawing.Point(74, 96)
        Me.lblItmDesc3.Name = "lblItmDesc3"
        Me.lblItmDesc3.Size = New System.Drawing.Size(275, 18)
        Me.lblItmDesc3.TabIndex = 13
        Me.lblItmDesc3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItmDesc3.Visible = False
        '
        'lblNo3
        '
        Me.lblNo3.BackColor = System.Drawing.Color.White
        Me.lblNo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo3.Location = New System.Drawing.Point(16, 96)
        Me.lblNo3.Name = "lblNo3"
        Me.lblNo3.Size = New System.Drawing.Size(32, 18)
        Me.lblNo3.TabIndex = 12
        Me.lblNo3.Text = "3"
        Me.lblNo3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNo3.Visible = False
        '
        'lblPrice2
        '
        Me.lblPrice2.BackColor = System.Drawing.Color.White
        Me.lblPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice2.Location = New System.Drawing.Point(513, 66)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice2.TabIndex = 11
        Me.lblPrice2.Text = "0"
        Me.lblPrice2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPrice2.Visible = False
        '
        'lblPrice4
        '
        Me.lblPrice4.BackColor = System.Drawing.Color.White
        Me.lblPrice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice4.Location = New System.Drawing.Point(513, 122)
        Me.lblPrice4.Name = "lblPrice4"
        Me.lblPrice4.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice4.TabIndex = 11
        Me.lblPrice4.Text = "0"
        Me.lblPrice4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPrice4.Visible = False
        '
        'lblQty2
        '
        Me.lblQty2.BackColor = System.Drawing.Color.White
        Me.lblQty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty2.Location = New System.Drawing.Point(391, 66)
        Me.lblQty2.Name = "lblQty2"
        Me.lblQty2.Size = New System.Drawing.Size(64, 18)
        Me.lblQty2.TabIndex = 10
        Me.lblQty2.Text = "Qty"
        Me.lblQty2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQty2.Visible = False
        '
        'lblItmDesc2
        '
        Me.lblItmDesc2.BackColor = System.Drawing.Color.White
        Me.lblItmDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc2.Location = New System.Drawing.Point(74, 66)
        Me.lblItmDesc2.Name = "lblItmDesc2"
        Me.lblItmDesc2.Size = New System.Drawing.Size(275, 18)
        Me.lblItmDesc2.TabIndex = 9
        Me.lblItmDesc2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItmDesc2.Visible = False
        '
        'lblQty4
        '
        Me.lblQty4.BackColor = System.Drawing.Color.White
        Me.lblQty4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty4.Location = New System.Drawing.Point(391, 122)
        Me.lblQty4.Name = "lblQty4"
        Me.lblQty4.Size = New System.Drawing.Size(64, 18)
        Me.lblQty4.TabIndex = 10
        Me.lblQty4.Text = "Qty"
        Me.lblQty4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQty4.Visible = False
        '
        'lblNo2
        '
        Me.lblNo2.BackColor = System.Drawing.Color.White
        Me.lblNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo2.Location = New System.Drawing.Point(16, 66)
        Me.lblNo2.Name = "lblNo2"
        Me.lblNo2.Size = New System.Drawing.Size(32, 18)
        Me.lblNo2.TabIndex = 8
        Me.lblNo2.Text = "2"
        Me.lblNo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNo2.Visible = False
        '
        'lblItmDesc4
        '
        Me.lblItmDesc4.BackColor = System.Drawing.Color.White
        Me.lblItmDesc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc4.Location = New System.Drawing.Point(74, 122)
        Me.lblItmDesc4.Name = "lblItmDesc4"
        Me.lblItmDesc4.Size = New System.Drawing.Size(275, 18)
        Me.lblItmDesc4.TabIndex = 9
        Me.lblItmDesc4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItmDesc4.Visible = False
        '
        'lblNo4
        '
        Me.lblNo4.BackColor = System.Drawing.Color.White
        Me.lblNo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo4.Location = New System.Drawing.Point(16, 122)
        Me.lblNo4.Name = "lblNo4"
        Me.lblNo4.Size = New System.Drawing.Size(32, 18)
        Me.lblNo4.TabIndex = 8
        Me.lblNo4.Text = "4"
        Me.lblNo4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNo4.Visible = False
        '
        'lblPrice1
        '
        Me.lblPrice1.BackColor = System.Drawing.Color.White
        Me.lblPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice1.Location = New System.Drawing.Point(513, 39)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice1.TabIndex = 7
        Me.lblPrice1.Text = "0"
        Me.lblPrice1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPrice1.Visible = False
        '
        'lblQty1
        '
        Me.lblQty1.BackColor = System.Drawing.Color.White
        Me.lblQty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty1.Location = New System.Drawing.Point(391, 39)
        Me.lblQty1.Name = "lblQty1"
        Me.lblQty1.Size = New System.Drawing.Size(64, 18)
        Me.lblQty1.TabIndex = 6
        Me.lblQty1.Text = "Qty"
        Me.lblQty1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQty1.Visible = False
        '
        'lblItmDesc1
        '
        Me.lblItmDesc1.BackColor = System.Drawing.Color.White
        Me.lblItmDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItmDesc1.Location = New System.Drawing.Point(74, 41)
        Me.lblItmDesc1.Name = "lblItmDesc1"
        Me.lblItmDesc1.Size = New System.Drawing.Size(275, 16)
        Me.lblItmDesc1.TabIndex = 5
        Me.lblItmDesc1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItmDesc1.Visible = False
        '
        'lblNo1
        '
        Me.lblNo1.BackColor = System.Drawing.Color.White
        Me.lblNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo1.Location = New System.Drawing.Point(16, 39)
        Me.lblNo1.Name = "lblNo1"
        Me.lblNo1.Size = New System.Drawing.Size(32, 18)
        Me.lblNo1.TabIndex = 4
        Me.lblNo1.Text = "1"
        Me.lblNo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNo1.Visible = False
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCheckout"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNums As Label
    Friend WithEvents lblItmDesc As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNo1 As Label
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblQty3 As Label
    Friend WithEvents lblItmDesc3 As Label
    Friend WithEvents lblNo3 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblPrice4 As Label
    Friend WithEvents lblQty2 As Label
    Friend WithEvents lblItmDesc2 As Label
    Friend WithEvents lblQty4 As Label
    Friend WithEvents lblNo2 As Label
    Friend WithEvents lblItmDesc4 As Label
    Friend WithEvents lblNo4 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblQty1 As Label
    Friend WithEvents lblItmDesc1 As Label
    Friend WithEvents lblPrice6 As Label
    Friend WithEvents lblQty6 As Label
    Friend WithEvents lblItmDesc6 As Label
    Friend WithEvents lblNo6 As Label
    Friend WithEvents lblPrice5 As Label
    Friend WithEvents lblQty5 As Label
    Friend WithEvents lblItmDesc5 As Label
    Friend WithEvents lblNo5 As Label
    Friend WithEvents lblSumPrices As Label
    Friend WithEvents lblColon As Label
    Friend WithEvents lblTotalPrice As Label
End Class
