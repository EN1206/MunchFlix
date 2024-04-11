<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenus
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.pbMaximize = New System.Windows.Forms.PictureBox()
        Me.pbMinimize = New System.Windows.Forms.PictureBox()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pbSidebar = New System.Windows.Forms.PictureBox()
        Me.lstOptions = New System.Windows.Forms.ListBox()
        Me.panelTop.SuspendLayout()
        CType(Me.pbMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSidebar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelTop.TabIndex = 1
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
        'pbSidebar
        '
        Me.pbSidebar.Image = Global.MunchFlix.My.Resources.Resources.trial
        Me.pbSidebar.Location = New System.Drawing.Point(-437, -158)
        Me.pbSidebar.Name = "pbSidebar"
        Me.pbSidebar.Size = New System.Drawing.Size(728, 517)
        Me.pbSidebar.TabIndex = 3
        Me.pbSidebar.TabStop = False
        '
        'lstOptions
        '
        Me.lstOptions.BackColor = System.Drawing.Color.Red
        Me.lstOptions.Font = New System.Drawing.Font("Alice", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOptions.ForeColor = System.Drawing.SystemColors.Window
        Me.lstOptions.FormattingEnabled = True
        Me.lstOptions.ItemHeight = 38
        Me.lstOptions.Location = New System.Drawing.Point(0, 161)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(264, 156)
        Me.lstOptions.TabIndex = 4
        '
        'frmMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstOptions)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.pbSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenus"
        Me.Text = "Menus"
        Me.panelTop.ResumeLayout(False)
        CType(Me.pbMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents pbMaximize As PictureBox
    Friend WithEvents pbMinimize As PictureBox
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbSidebar As PictureBox
    Friend WithEvents lstOptions As ListBox
End Class
