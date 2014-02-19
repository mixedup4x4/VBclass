<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlags
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlags))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlagsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitedStatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GermanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HondurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GermanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HondurasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pixFlag = New System.Windows.Forms.PictureBox()
        Me.lblCountryName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SplashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pixFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FlagsToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FlagsToolStripMenuItem
        '
        Me.FlagsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitedStatesToolStripMenuItem, Me.GermanyToolStripMenuItem, Me.JapanToolStripMenuItem, Me.HondurasToolStripMenuItem})
        Me.FlagsToolStripMenuItem.Name = "FlagsToolStripMenuItem"
        Me.FlagsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.FlagsToolStripMenuItem.Text = "Flags"
        '
        'UnitedStatesToolStripMenuItem
        '
        Me.UnitedStatesToolStripMenuItem.Name = "UnitedStatesToolStripMenuItem"
        Me.UnitedStatesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UnitedStatesToolStripMenuItem.Text = "United States"
        '
        'GermanyToolStripMenuItem
        '
        Me.GermanyToolStripMenuItem.Name = "GermanyToolStripMenuItem"
        Me.GermanyToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GermanyToolStripMenuItem.Text = "Germany"
        '
        'JapanToolStripMenuItem
        '
        Me.JapanToolStripMenuItem.Name = "JapanToolStripMenuItem"
        Me.JapanToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.JapanToolStripMenuItem.Text = "Japan"
        '
        'HondurasToolStripMenuItem
        '
        Me.HondurasToolStripMenuItem.Name = "HondurasToolStripMenuItem"
        Me.HondurasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.HondurasToolStripMenuItem.Text = "Honduras"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CountryNameToolStripMenuItem, Me.GermanToolStripMenuItem, Me.JapanToolStripMenuItem1, Me.HondurasToolStripMenuItem1})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.DisplayToolStripMenuItem.Text = "Country Name"
        '
        'CountryNameToolStripMenuItem
        '
        Me.CountryNameToolStripMenuItem.Checked = True
        Me.CountryNameToolStripMenuItem.CheckOnClick = True
        Me.CountryNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryNameToolStripMenuItem.Name = "CountryNameToolStripMenuItem"
        Me.CountryNameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CountryNameToolStripMenuItem.Text = "United States"
        '
        'GermanToolStripMenuItem
        '
        Me.GermanToolStripMenuItem.Checked = True
        Me.GermanToolStripMenuItem.CheckOnClick = True
        Me.GermanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GermanToolStripMenuItem.Name = "GermanToolStripMenuItem"
        Me.GermanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GermanToolStripMenuItem.Text = "Germany"
        '
        'JapanToolStripMenuItem1
        '
        Me.JapanToolStripMenuItem1.Checked = True
        Me.JapanToolStripMenuItem1.CheckOnClick = True
        Me.JapanToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.JapanToolStripMenuItem1.Name = "JapanToolStripMenuItem1"
        Me.JapanToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.JapanToolStripMenuItem1.Text = "Japan"
        '
        'HondurasToolStripMenuItem1
        '
        Me.HondurasToolStripMenuItem1.Checked = True
        Me.HondurasToolStripMenuItem1.CheckOnClick = True
        Me.HondurasToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HondurasToolStripMenuItem1.Name = "HondurasToolStripMenuItem1"
        Me.HondurasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HondurasToolStripMenuItem1.Text = "Honduras"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SplashToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'pixFlag
        '
        Me.pixFlag.Location = New System.Drawing.Point(35, 114)
        Me.pixFlag.Name = "pixFlag"
        Me.pixFlag.Size = New System.Drawing.Size(407, 213)
        Me.pixFlag.TabIndex = 4
        Me.pixFlag.TabStop = False
        '
        'lblCountryName
        '
        Me.lblCountryName.AutoSize = True
        Me.lblCountryName.Location = New System.Drawing.Point(35, 334)
        Me.lblCountryName.Name = "lblCountryName"
        Me.lblCountryName.Size = New System.Drawing.Size(0, 16)
        Me.lblCountryName.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(156, 61)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(157, 29)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "FLAG VIEWER"
        '
        'SplashToolStripMenuItem
        '
        Me.SplashToolStripMenuItem.Name = "SplashToolStripMenuItem"
        Me.SplashToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SplashToolStripMenuItem.Text = "Splash"
        '
        'frmFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(475, 392)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCountryName)
        Me.Controls.Add(Me.pixFlag)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmFlags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flag Browser"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pixFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlagsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountryNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitedStatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GermanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JapanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HondurasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pixFlag As System.Windows.Forms.PictureBox
    Friend WithEvents lblCountryName As System.Windows.Forms.Label
    Friend WithEvents GermanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JapanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HondurasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents SplashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
