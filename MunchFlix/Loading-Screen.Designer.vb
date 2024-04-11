<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadingScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadingScreen))
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.panelLoadingBar = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbLoadingScreen = New System.Windows.Forms.PictureBox()
        CType(Me.pbLoadingScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBottom
        '
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 590)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(600, 10)
        Me.panelBottom.TabIndex = 1
        '
        'panelLoadingBar
        '
        Me.panelLoadingBar.BackColor = System.Drawing.Color.White
        Me.panelLoadingBar.Location = New System.Drawing.Point(0, 590)
        Me.panelLoadingBar.Name = "panelLoadingBar"
        Me.panelLoadingBar.Size = New System.Drawing.Size(10, 10)
        Me.panelLoadingBar.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'pbLoadingScreen
        '
        Me.pbLoadingScreen.Image = Global.MunchFlix.My.Resources.Resources.splash_monitor
        Me.pbLoadingScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbLoadingScreen.Name = "pbLoadingScreen"
        Me.pbLoadingScreen.Size = New System.Drawing.Size(600, 600)
        Me.pbLoadingScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLoadingScreen.TabIndex = 0
        Me.pbLoadingScreen.TabStop = False
        '
        'frmLoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelLoadingBar)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.pbLoadingScreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoadingScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MunchBear | Loading Screen"
        CType(Me.pbLoadingScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLoadingScreen As PictureBox
    Friend WithEvents panelBottom As Panel
    Friend WithEvents panelLoadingBar As Panel
    Friend WithEvents Timer1 As Timer
End Class
