<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorldFlags
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorldFlags))
        Me.pixFlag = New System.Windows.Forms.PictureBox()
        Me.gpbCountryFlag = New System.Windows.Forms.GroupBox()
        Me.rdbHonduras = New System.Windows.Forms.RadioButton()
        Me.rdbJapan = New System.Windows.Forms.RadioButton()
        Me.rdbGermany = New System.Windows.Forms.RadioButton()
        Me.rdbUSA = New System.Windows.Forms.RadioButton()
        Me.gpbCountryName = New System.Windows.Forms.GroupBox()
        Me.chkHonduras = New System.Windows.Forms.CheckBox()
        Me.chkJapan = New System.Windows.Forms.CheckBox()
        Me.chkGermany = New System.Windows.Forms.CheckBox()
        Me.chkUSA = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblJason = New System.Windows.Forms.Label()
        Me.lblCountryName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        CType(Me.pixFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbCountryFlag.SuspendLayout()
        Me.gpbCountryName.SuspendLayout()
        Me.SuspendLayout()
        '
        'pixFlag
        '
        Me.pixFlag.InitialImage = Nothing
        Me.pixFlag.Location = New System.Drawing.Point(270, 42)
        Me.pixFlag.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pixFlag.Name = "pixFlag"
        Me.pixFlag.Size = New System.Drawing.Size(254, 195)
        Me.pixFlag.TabIndex = 0
        Me.pixFlag.TabStop = False
        '
        'gpbCountryFlag
        '
        Me.gpbCountryFlag.Controls.Add(Me.rdbHonduras)
        Me.gpbCountryFlag.Controls.Add(Me.rdbJapan)
        Me.gpbCountryFlag.Controls.Add(Me.rdbGermany)
        Me.gpbCountryFlag.Controls.Add(Me.rdbUSA)
        Me.gpbCountryFlag.Location = New System.Drawing.Point(15, 42)
        Me.gpbCountryFlag.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpbCountryFlag.Name = "gpbCountryFlag"
        Me.gpbCountryFlag.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpbCountryFlag.Size = New System.Drawing.Size(234, 147)
        Me.gpbCountryFlag.TabIndex = 1
        Me.gpbCountryFlag.TabStop = False
        Me.gpbCountryFlag.Text = "Select a Country"
        '
        'rdbHonduras
        '
        Me.rdbHonduras.AutoSize = True
        Me.rdbHonduras.Location = New System.Drawing.Point(8, 117)
        Me.rdbHonduras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbHonduras.Name = "rdbHonduras"
        Me.rdbHonduras.Size = New System.Drawing.Size(71, 17)
        Me.rdbHonduras.TabIndex = 4
        Me.rdbHonduras.TabStop = True
        Me.rdbHonduras.Text = "Honduras"
        Me.rdbHonduras.UseVisualStyleBackColor = True
        '
        'rdbJapan
        '
        Me.rdbJapan.AutoSize = True
        Me.rdbJapan.Location = New System.Drawing.Point(8, 90)
        Me.rdbJapan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbJapan.Name = "rdbJapan"
        Me.rdbJapan.Size = New System.Drawing.Size(54, 17)
        Me.rdbJapan.TabIndex = 3
        Me.rdbJapan.TabStop = True
        Me.rdbJapan.Text = "Japan"
        Me.rdbJapan.UseVisualStyleBackColor = True
        '
        'rdbGermany
        '
        Me.rdbGermany.AutoSize = True
        Me.rdbGermany.Location = New System.Drawing.Point(8, 65)
        Me.rdbGermany.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbGermany.Name = "rdbGermany"
        Me.rdbGermany.Size = New System.Drawing.Size(67, 17)
        Me.rdbGermany.TabIndex = 1
        Me.rdbGermany.TabStop = True
        Me.rdbGermany.Text = "Germany"
        Me.rdbGermany.UseVisualStyleBackColor = True
        '
        'rdbUSA
        '
        Me.rdbUSA.AutoSize = True
        Me.rdbUSA.Location = New System.Drawing.Point(8, 38)
        Me.rdbUSA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbUSA.Name = "rdbUSA"
        Me.rdbUSA.Size = New System.Drawing.Size(142, 17)
        Me.rdbUSA.TabIndex = 0
        Me.rdbUSA.TabStop = True
        Me.rdbUSA.Text = "United States of America"
        Me.rdbUSA.UseVisualStyleBackColor = True
        '
        'gpbCountryName
        '
        Me.gpbCountryName.Controls.Add(Me.chkHonduras)
        Me.gpbCountryName.Controls.Add(Me.chkJapan)
        Me.gpbCountryName.Controls.Add(Me.chkGermany)
        Me.gpbCountryName.Controls.Add(Me.chkUSA)
        Me.gpbCountryName.Location = New System.Drawing.Point(15, 195)
        Me.gpbCountryName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpbCountryName.Name = "gpbCountryName"
        Me.gpbCountryName.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpbCountryName.Size = New System.Drawing.Size(234, 131)
        Me.gpbCountryName.TabIndex = 2
        Me.gpbCountryName.TabStop = False
        Me.gpbCountryName.Text = "Select a Country"
        '
        'chkHonduras
        '
        Me.chkHonduras.AutoSize = True
        Me.chkHonduras.Location = New System.Drawing.Point(10, 102)
        Me.chkHonduras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkHonduras.Name = "chkHonduras"
        Me.chkHonduras.Size = New System.Drawing.Size(66, 17)
        Me.chkHonduras.TabIndex = 4
        Me.chkHonduras.Text = "Honuras"
        Me.chkHonduras.UseVisualStyleBackColor = True
        '
        'chkJapan
        '
        Me.chkJapan.AutoSize = True
        Me.chkJapan.Location = New System.Drawing.Point(10, 75)
        Me.chkJapan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkJapan.Name = "chkJapan"
        Me.chkJapan.Size = New System.Drawing.Size(55, 17)
        Me.chkJapan.TabIndex = 3
        Me.chkJapan.Text = "Japan"
        Me.chkJapan.UseVisualStyleBackColor = True
        '
        'chkGermany
        '
        Me.chkGermany.AutoSize = True
        Me.chkGermany.Location = New System.Drawing.Point(10, 50)
        Me.chkGermany.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkGermany.Name = "chkGermany"
        Me.chkGermany.Size = New System.Drawing.Size(68, 17)
        Me.chkGermany.TabIndex = 1
        Me.chkGermany.Text = "Germany"
        Me.chkGermany.UseVisualStyleBackColor = True
        '
        'chkUSA
        '
        Me.chkUSA.AutoSize = True
        Me.chkUSA.Location = New System.Drawing.Point(10, 25)
        Me.chkUSA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkUSA.Name = "chkUSA"
        Me.chkUSA.Size = New System.Drawing.Size(143, 17)
        Me.chkUSA.TabIndex = 0
        Me.chkUSA.Text = "United States of America"
        Me.chkUSA.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(13, 341)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(234, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblJason
        '
        Me.lblJason.AutoSize = True
        Me.lblJason.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJason.Location = New System.Drawing.Point(364, 347)
        Me.lblJason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJason.Name = "lblJason"
        Me.lblJason.Size = New System.Drawing.Size(160, 15)
        Me.lblJason.TabIndex = 4
        Me.lblJason.Text = "Programmed by: Jason Chapell"
        '
        'lblCountryName
        '
        Me.lblCountryName.AutoSize = True
        Me.lblCountryName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryName.Location = New System.Drawing.Point(364, 245)
        Me.lblCountryName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountryName.Name = "lblCountryName"
        Me.lblCountryName.Size = New System.Drawing.Size(0, 18)
        Me.lblCountryName.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(11, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(151, 21)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Flags of the World"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(270, 291)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(254, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmWorldFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(542, 382)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCountryName)
        Me.Controls.Add(Me.lblJason)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gpbCountryName)
        Me.Controls.Add(Me.gpbCountryFlag)
        Me.Controls.Add(Me.pixFlag)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmWorldFlags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "World Flags"
        CType(Me.pixFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbCountryFlag.ResumeLayout(False)
        Me.gpbCountryFlag.PerformLayout()
        Me.gpbCountryName.ResumeLayout(False)
        Me.gpbCountryName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pixFlag As System.Windows.Forms.PictureBox
    Friend WithEvents gpbCountryFlag As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHonduras As System.Windows.Forms.RadioButton
    Friend WithEvents rdbJapan As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGermany As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUSA As System.Windows.Forms.RadioButton
    Friend WithEvents gpbCountryName As System.Windows.Forms.GroupBox
    Friend WithEvents chkHonduras As System.Windows.Forms.CheckBox
    Friend WithEvents chkJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chkGermany As System.Windows.Forms.CheckBox
    Friend WithEvents chkUSA As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblJason As System.Windows.Forms.Label
    Friend WithEvents lblCountryName As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button

End Class
