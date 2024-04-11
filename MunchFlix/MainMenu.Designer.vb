<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.pbMaximize = New System.Windows.Forms.PictureBox()
        Me.pbMinimize = New System.Windows.Forms.PictureBox()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.panelBackground = New System.Windows.Forms.Panel()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnNotif = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnAcc = New System.Windows.Forms.Button()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.pbAds = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblNotif = New System.Windows.Forms.Label()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSection = New System.Windows.Forms.Label()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnAppetizers = New System.Windows.Forms.Button()
        Me.btnMainMeal = New System.Windows.Forms.Button()
        Me.btnDessert = New System.Windows.Forms.Button()
        Me.panelOrder1 = New System.Windows.Forms.Panel()
        Me.btnOrderPinkLemonade = New System.Windows.Forms.Button()
        Me.lblPinkLemonade = New System.Windows.Forms.Label()
        Me.pbPinkLemonade = New System.Windows.Forms.PictureBox()
        Me.panelOrder2 = New System.Windows.Forms.Panel()
        Me.btnOrderEmpanada = New System.Windows.Forms.Button()
        Me.lblEmpanada = New System.Windows.Forms.Label()
        Me.pbEmpanada = New System.Windows.Forms.PictureBox()
        Me.panelOrder3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOrderSinigang = New System.Windows.Forms.Button()
        Me.pbSinigang = New System.Windows.Forms.PictureBox()
        Me.panelOrder4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOrderHaloHalo = New System.Windows.Forms.Button()
        Me.pbHaloHalo = New System.Windows.Forms.PictureBox()
        Me.pbFire1 = New System.Windows.Forms.PictureBox()
        Me.pbFire2 = New System.Windows.Forms.PictureBox()
        Me.panelTop.SuspendLayout()
        CType(Me.pbMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackground.SuspendLayout()
        CType(Me.pbAds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrder1.SuspendLayout()
        CType(Me.pbPinkLemonade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrder2.SuspendLayout()
        CType(Me.pbEmpanada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrder3.SuspendLayout()
        CType(Me.pbSinigang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrder4.SuspendLayout()
        CType(Me.pbHaloHalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFire1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFire2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelTop.Controls.Add(Me.pbMaximize)
        Me.panelTop.Controls.Add(Me.pbMinimize)
        Me.panelTop.Controls.Add(Me.pbClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1280, 51)
        Me.panelTop.TabIndex = 0
        '
        'pbMaximize
        '
        Me.pbMaximize.Image = Global.MunchFlix.My.Resources.Resources.maximize_button_og
        Me.pbMaximize.Location = New System.Drawing.Point(111, 3)
        Me.pbMaximize.Name = "pbMaximize"
        Me.pbMaximize.Size = New System.Drawing.Size(43, 40)
        Me.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMaximize.TabIndex = 2
        Me.pbMaximize.TabStop = False
        '
        'pbMinimize
        '
        Me.pbMinimize.Image = Global.MunchFlix.My.Resources.Resources.minimize_button_og
        Me.pbMinimize.Location = New System.Drawing.Point(61, 3)
        Me.pbMinimize.Name = "pbMinimize"
        Me.pbMinimize.Size = New System.Drawing.Size(43, 40)
        Me.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMinimize.TabIndex = 1
        Me.pbMinimize.TabStop = False
        '
        'pbClose
        '
        Me.pbClose.Image = Global.MunchFlix.My.Resources.Resources.close_button_og
        Me.pbClose.Location = New System.Drawing.Point(12, 3)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(43, 40)
        Me.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClose.TabIndex = 0
        Me.pbClose.TabStop = False
        '
        'panelBackground
        '
        Me.panelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelBackground.Controls.Add(Me.btnFeedback)
        Me.panelBackground.Controls.Add(Me.btnHelp)
        Me.panelBackground.Controls.Add(Me.btnCart)
        Me.panelBackground.Controls.Add(Me.lblCart)
        Me.panelBackground.Controls.Add(Me.lblHelp)
        Me.panelBackground.Controls.Add(Me.btnNotif)
        Me.panelBackground.Controls.Add(Me.btnInfo)
        Me.panelBackground.Controls.Add(Me.btnAcc)
        Me.panelBackground.Controls.Add(Me.lblTagline)
        Me.panelBackground.Controls.Add(Me.pbAds)
        Me.panelBackground.Controls.Add(Me.pbLogo)
        Me.panelBackground.Controls.Add(Me.lblAcc)
        Me.panelBackground.Controls.Add(Me.lblInfo)
        Me.panelBackground.Controls.Add(Me.lblNotif)
        Me.panelBackground.Controls.Add(Me.lblFeedback)
        Me.panelBackground.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBackground.Location = New System.Drawing.Point(0, 51)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(1280, 200)
        Me.panelBackground.TabIndex = 1
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFeedback.BackgroundImage = Global.MunchFlix.My.Resources.Resources.feedback
        Me.btnFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFeedback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFeedback.Location = New System.Drawing.Point(1192, 6)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(81, 79)
        Me.btnFeedback.TabIndex = 13
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnHelp.BackgroundImage = Global.MunchFlix.My.Resources.Resources.help
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(1192, 105)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(81, 79)
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnCart
        '
        Me.btnCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCart.BackgroundImage = Global.MunchFlix.My.Resources.Resources.cart
        Me.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCart.Location = New System.Drawing.Point(1096, 6)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(81, 79)
        Me.btnCart.TabIndex = 4
        Me.btnCart.UseVisualStyleBackColor = False
        '
        'lblCart
        '
        Me.lblCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblCart.Location = New System.Drawing.Point(1096, 81)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(81, 20)
        Me.lblCart.TabIndex = 8
        Me.lblCart.Text = "Checkout"
        Me.lblCart.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblHelp.Location = New System.Drawing.Point(1214, 180)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(37, 15)
        Me.lblHelp.TabIndex = 12
        Me.lblHelp.Text = "Help"
        '
        'btnNotif
        '
        Me.btnNotif.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNotif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNotif.Image = Global.MunchFlix.My.Resources.Resources.notify
        Me.btnNotif.Location = New System.Drawing.Point(1096, 105)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Size = New System.Drawing.Size(81, 79)
        Me.btnNotif.TabIndex = 9
        Me.btnNotif.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnInfo.BackgroundImage = Global.MunchFlix.My.Resources.Resources.info
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnInfo.Location = New System.Drawing.Point(994, 105)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(81, 79)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnAcc
        '
        Me.btnAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAcc.BackgroundImage = Global.MunchFlix.My.Resources.Resources.profile
        Me.btnAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAcc.Location = New System.Drawing.Point(994, 6)
        Me.btnAcc.Name = "btnAcc"
        Me.btnAcc.Size = New System.Drawing.Size(81, 79)
        Me.btnAcc.TabIndex = 3
        Me.btnAcc.UseVisualStyleBackColor = False
        '
        'lblTagline
        '
        Me.lblTagline.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblTagline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTagline.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblTagline.Location = New System.Drawing.Point(321, 166)
        Me.lblTagline.Name = "lblTagline"
        Me.lblTagline.Size = New System.Drawing.Size(667, 32)
        Me.lblTagline.TabIndex = 2
        Me.lblTagline.Text = "Indulge in the Taste of Tradition, Filipino Cuisine at its Finest!"
        Me.lblTagline.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbAds
        '
        Me.pbAds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAds.Image = Global.MunchFlix.My.Resources.Resources.munchbear_adobo_ad1
        Me.pbAds.Location = New System.Drawing.Point(321, -2)
        Me.pbAds.Name = "pbAds"
        Me.pbAds.Size = New System.Drawing.Size(667, 169)
        Me.pbAds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAds.TabIndex = 1
        Me.pbAds.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogo.Image = Global.MunchFlix.My.Resources.Resources.munchbear_logo_picture
        Me.pbLogo.Location = New System.Drawing.Point(-2, -2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(326, 200)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lblAcc
        '
        Me.lblAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblAcc.Location = New System.Drawing.Point(994, 81)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(81, 27)
        Me.lblAcc.TabIndex = 6
        Me.lblAcc.Text = "Profile"
        Me.lblAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(994, 180)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(81, 15)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "Learn More"
        '
        'lblNotif
        '
        Me.lblNotif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblNotif.Location = New System.Drawing.Point(1096, 180)
        Me.lblNotif.Name = "lblNotif"
        Me.lblNotif.Size = New System.Drawing.Size(81, 20)
        Me.lblNotif.TabIndex = 10
        Me.lblNotif.Text = "Notification"
        Me.lblNotif.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblFeedback.Location = New System.Drawing.Point(1197, 81)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(69, 15)
        Me.lblFeedback.TabIndex = 14
        Me.lblFeedback.Text = "Feedback"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'lblSection
        '
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(509, 343)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(234, 83)
        Me.lblSection.TabIndex = 2
        Me.lblSection.Text = "HOT PICKS"
        '
        'btnDrinks
        '
        Me.btnDrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDrinks.Location = New System.Drawing.Point(25, 266)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(222, 64)
        Me.btnDrinks.TabIndex = 3
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = False
        '
        'btnAppetizers
        '
        Me.btnAppetizers.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAppetizers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppetizers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAppetizers.Location = New System.Drawing.Point(341, 266)
        Me.btnAppetizers.Name = "btnAppetizers"
        Me.btnAppetizers.Size = New System.Drawing.Size(222, 64)
        Me.btnAppetizers.TabIndex = 4
        Me.btnAppetizers.Text = "Appetizers"
        Me.btnAppetizers.UseVisualStyleBackColor = False
        '
        'btnMainMeal
        '
        Me.btnMainMeal.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMainMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMeal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnMainMeal.Location = New System.Drawing.Point(693, 266)
        Me.btnMainMeal.Name = "btnMainMeal"
        Me.btnMainMeal.Size = New System.Drawing.Size(222, 64)
        Me.btnMainMeal.TabIndex = 5
        Me.btnMainMeal.Text = "Main Meal"
        Me.btnMainMeal.UseVisualStyleBackColor = False
        '
        'btnDessert
        '
        Me.btnDessert.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDessert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDessert.Location = New System.Drawing.Point(1033, 266)
        Me.btnDessert.Name = "btnDessert"
        Me.btnDessert.Size = New System.Drawing.Size(222, 64)
        Me.btnDessert.TabIndex = 6
        Me.btnDessert.Text = "Dessert"
        Me.btnDessert.UseVisualStyleBackColor = False
        '
        'panelOrder1
        '
        Me.panelOrder1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panelOrder1.Controls.Add(Me.btnOrderPinkLemonade)
        Me.panelOrder1.Controls.Add(Me.lblPinkLemonade)
        Me.panelOrder1.Controls.Add(Me.pbPinkLemonade)
        Me.panelOrder1.Location = New System.Drawing.Point(25, 429)
        Me.panelOrder1.Name = "panelOrder1"
        Me.panelOrder1.Size = New System.Drawing.Size(222, 279)
        Me.panelOrder1.TabIndex = 7
        '
        'btnOrderPinkLemonade
        '
        Me.btnOrderPinkLemonade.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnOrderPinkLemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderPinkLemonade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnOrderPinkLemonade.Location = New System.Drawing.Point(13, 225)
        Me.btnOrderPinkLemonade.Name = "btnOrderPinkLemonade"
        Me.btnOrderPinkLemonade.Size = New System.Drawing.Size(195, 51)
        Me.btnOrderPinkLemonade.TabIndex = 1
        Me.btnOrderPinkLemonade.Text = "99.00"
        Me.btnOrderPinkLemonade.UseVisualStyleBackColor = False
        '
        'lblPinkLemonade
        '
        Me.lblPinkLemonade.AutoSize = True
        Me.lblPinkLemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPinkLemonade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblPinkLemonade.Location = New System.Drawing.Point(34, 198)
        Me.lblPinkLemonade.Name = "lblPinkLemonade"
        Me.lblPinkLemonade.Size = New System.Drawing.Size(155, 24)
        Me.lblPinkLemonade.TabIndex = 2
        Me.lblPinkLemonade.Text = "Pink Lemonade"
        '
        'pbPinkLemonade
        '
        Me.pbPinkLemonade.Image = Global.MunchFlix.My.Resources.Resources.pink_lemonade
        Me.pbPinkLemonade.Location = New System.Drawing.Point(13, 12)
        Me.pbPinkLemonade.Name = "pbPinkLemonade"
        Me.pbPinkLemonade.Size = New System.Drawing.Size(195, 179)
        Me.pbPinkLemonade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbPinkLemonade.TabIndex = 0
        Me.pbPinkLemonade.TabStop = False
        '
        'panelOrder2
        '
        Me.panelOrder2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panelOrder2.Controls.Add(Me.btnOrderEmpanada)
        Me.panelOrder2.Controls.Add(Me.lblEmpanada)
        Me.panelOrder2.Controls.Add(Me.pbEmpanada)
        Me.panelOrder2.Location = New System.Drawing.Point(341, 429)
        Me.panelOrder2.Name = "panelOrder2"
        Me.panelOrder2.Size = New System.Drawing.Size(222, 279)
        Me.panelOrder2.TabIndex = 8
        '
        'btnOrderEmpanada
        '
        Me.btnOrderEmpanada.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnOrderEmpanada.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderEmpanada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnOrderEmpanada.Location = New System.Drawing.Point(15, 225)
        Me.btnOrderEmpanada.Name = "btnOrderEmpanada"
        Me.btnOrderEmpanada.Size = New System.Drawing.Size(195, 51)
        Me.btnOrderEmpanada.TabIndex = 2
        Me.btnOrderEmpanada.Text = "120.00"
        Me.btnOrderEmpanada.UseVisualStyleBackColor = False
        '
        'lblEmpanada
        '
        Me.lblEmpanada.AutoSize = True
        Me.lblEmpanada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpanada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblEmpanada.Location = New System.Drawing.Point(57, 198)
        Me.lblEmpanada.Name = "lblEmpanada"
        Me.lblEmpanada.Size = New System.Drawing.Size(110, 24)
        Me.lblEmpanada.TabIndex = 3
        Me.lblEmpanada.Text = "Empanada"
        '
        'pbEmpanada
        '
        Me.pbEmpanada.Image = Global.MunchFlix.My.Resources.Resources.empanada
        Me.pbEmpanada.Location = New System.Drawing.Point(15, 12)
        Me.pbEmpanada.Name = "pbEmpanada"
        Me.pbEmpanada.Size = New System.Drawing.Size(195, 179)
        Me.pbEmpanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbEmpanada.TabIndex = 0
        Me.pbEmpanada.TabStop = False
        '
        'panelOrder3
        '
        Me.panelOrder3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panelOrder3.Controls.Add(Me.Label1)
        Me.panelOrder3.Controls.Add(Me.btnOrderSinigang)
        Me.panelOrder3.Controls.Add(Me.pbSinigang)
        Me.panelOrder3.Location = New System.Drawing.Point(693, 429)
        Me.panelOrder3.Name = "panelOrder3"
        Me.panelOrder3.Size = New System.Drawing.Size(222, 279)
        Me.panelOrder3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(66, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sinigang"
        '
        'btnOrderSinigang
        '
        Me.btnOrderSinigang.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnOrderSinigang.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderSinigang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnOrderSinigang.Location = New System.Drawing.Point(15, 225)
        Me.btnOrderSinigang.Name = "btnOrderSinigang"
        Me.btnOrderSinigang.Size = New System.Drawing.Size(195, 51)
        Me.btnOrderSinigang.TabIndex = 3
        Me.btnOrderSinigang.Text = "250.00"
        Me.btnOrderSinigang.UseVisualStyleBackColor = False
        '
        'pbSinigang
        '
        Me.pbSinigang.Image = Global.MunchFlix.My.Resources.Resources.sinigang
        Me.pbSinigang.Location = New System.Drawing.Point(15, 12)
        Me.pbSinigang.Name = "pbSinigang"
        Me.pbSinigang.Size = New System.Drawing.Size(195, 179)
        Me.pbSinigang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSinigang.TabIndex = 0
        Me.pbSinigang.TabStop = False
        '
        'panelOrder4
        '
        Me.panelOrder4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panelOrder4.Controls.Add(Me.Label2)
        Me.panelOrder4.Controls.Add(Me.btnOrderHaloHalo)
        Me.panelOrder4.Controls.Add(Me.pbHaloHalo)
        Me.panelOrder4.Location = New System.Drawing.Point(1031, 429)
        Me.panelOrder4.Name = "panelOrder4"
        Me.panelOrder4.Size = New System.Drawing.Size(222, 279)
        Me.panelOrder4.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(66, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Halo-Halo"
        '
        'btnOrderHaloHalo
        '
        Me.btnOrderHaloHalo.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnOrderHaloHalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderHaloHalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnOrderHaloHalo.Location = New System.Drawing.Point(15, 225)
        Me.btnOrderHaloHalo.Name = "btnOrderHaloHalo"
        Me.btnOrderHaloHalo.Size = New System.Drawing.Size(195, 51)
        Me.btnOrderHaloHalo.TabIndex = 4
        Me.btnOrderHaloHalo.Text = "85.00"
        Me.btnOrderHaloHalo.UseVisualStyleBackColor = False
        '
        'pbHaloHalo
        '
        Me.pbHaloHalo.Image = Global.MunchFlix.My.Resources.Resources.halo_halo
        Me.pbHaloHalo.Location = New System.Drawing.Point(15, 12)
        Me.pbHaloHalo.Name = "pbHaloHalo"
        Me.pbHaloHalo.Size = New System.Drawing.Size(195, 179)
        Me.pbHaloHalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbHaloHalo.TabIndex = 0
        Me.pbHaloHalo.TabStop = False
        '
        'pbFire1
        '
        Me.pbFire1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.pbFire1.Image = CType(resources.GetObject("pbFire1.Image"), System.Drawing.Image)
        Me.pbFire1.Location = New System.Drawing.Point(443, 336)
        Me.pbFire1.Name = "pbFire1"
        Me.pbFire1.Size = New System.Drawing.Size(82, 80)
        Me.pbFire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFire1.TabIndex = 11
        Me.pbFire1.TabStop = False
        '
        'pbFire2
        '
        Me.pbFire2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.pbFire2.Image = CType(resources.GetObject("pbFire2.Image"), System.Drawing.Image)
        Me.pbFire2.Location = New System.Drawing.Point(721, 336)
        Me.pbFire2.Name = "pbFire2"
        Me.pbFire2.Size = New System.Drawing.Size(82, 80)
        Me.pbFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFire2.TabIndex = 12
        Me.pbFire2.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbFire1)
        Me.Controls.Add(Me.pbFire2)
        Me.Controls.Add(Me.panelOrder4)
        Me.Controls.Add(Me.panelOrder3)
        Me.Controls.Add(Me.panelOrder2)
        Me.Controls.Add(Me.panelOrder1)
        Me.Controls.Add(Me.btnDessert)
        Me.Controls.Add(Me.btnMainMeal)
        Me.Controls.Add(Me.btnAppetizers)
        Me.Controls.Add(Me.btnDrinks)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.panelBackground)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MunchBear | MainMenu"
        Me.panelTop.ResumeLayout(False)
        CType(Me.pbMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackground.ResumeLayout(False)
        Me.panelBackground.PerformLayout()
        CType(Me.pbAds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrder1.ResumeLayout(False)
        Me.panelOrder1.PerformLayout()
        CType(Me.pbPinkLemonade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrder2.ResumeLayout(False)
        Me.panelOrder2.PerformLayout()
        CType(Me.pbEmpanada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrder3.ResumeLayout(False)
        Me.panelOrder3.PerformLayout()
        CType(Me.pbSinigang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrder4.ResumeLayout(False)
        Me.panelOrder4.PerformLayout()
        CType(Me.pbHaloHalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFire1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFire2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents pbMinimize As PictureBox
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbMaximize As PictureBox
    Friend WithEvents panelBackground As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbAds As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTagline As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnAcc As Button
    Friend WithEvents lblAcc As Label
    Friend WithEvents lblCart As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnNotif As Button
    Friend WithEvents lblNotif As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblHelp As Label
    Friend WithEvents btnFeedback As Button
    Friend WithEvents lblFeedback As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnAppetizers As Button
    Friend WithEvents btnMainMeal As Button
    Friend WithEvents btnDessert As Button
    Friend WithEvents panelOrder1 As Panel
    Friend WithEvents pbPinkLemonade As PictureBox
    Friend WithEvents panelOrder2 As Panel
    Friend WithEvents pbEmpanada As PictureBox
    Friend WithEvents panelOrder3 As Panel
    Friend WithEvents pbSinigang As PictureBox
    Friend WithEvents panelOrder4 As Panel
    Friend WithEvents pbHaloHalo As PictureBox
    Friend WithEvents btnOrderPinkLemonade As Button
    Friend WithEvents lblPinkLemonade As Label
    Friend WithEvents lblEmpanada As Label
    Friend WithEvents btnOrderEmpanada As Button
    Friend WithEvents btnOrderSinigang As Button
    Friend WithEvents btnOrderHaloHalo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbFire1 As PictureBox
    Friend WithEvents pbFire2 As PictureBox
End Class
