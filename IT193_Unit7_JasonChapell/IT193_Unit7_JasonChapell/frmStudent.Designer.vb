<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject))
        Me.lblJason = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.gbxYear = New System.Windows.Forms.GroupBox()
        Me.rdbSenior = New System.Windows.Forms.RadioButton()
        Me.rdbJunior = New System.Windows.Forms.RadioButton()
        Me.rdbSophomore = New System.Windows.Forms.RadioButton()
        Me.rdbFreshman = New System.Windows.Forms.RadioButton()
        Me.lstMajor = New System.Windows.Forms.ListBox()
        Me.cboSchool = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.chkDean = New System.Windows.Forms.CheckBox()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.gbxYear.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJason
        '
        Me.lblJason.AutoSize = True
        Me.lblJason.Location = New System.Drawing.Point(453, 398)
        Me.lblJason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJason.Name = "lblJason"
        Me.lblJason.Size = New System.Drawing.Size(172, 16)
        Me.lblJason.TabIndex = 1
        Me.lblJason.Text = "Programmed by: Jason Chapell"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(466, 419)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(172, 16)
        Me.lblClass.TabIndex = 2
        Me.lblClass.Text = "Kaplan University - IT193-02"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 96)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 16)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(331, 99)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(35, 16)
        Me.lblUnits.TabIndex = 4
        Me.lblUnits.Text = "Units"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(60, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(205, 23)
        Me.txtName.TabIndex = 5
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(372, 99)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(205, 23)
        Me.txtUnits.TabIndex = 6
        '
        'gbxYear
        '
        Me.gbxYear.Controls.Add(Me.rdbSenior)
        Me.gbxYear.Controls.Add(Me.rdbJunior)
        Me.gbxYear.Controls.Add(Me.rdbSophomore)
        Me.gbxYear.Controls.Add(Me.rdbFreshman)
        Me.gbxYear.Location = New System.Drawing.Point(109, 161)
        Me.gbxYear.Name = "gbxYear"
        Me.gbxYear.Size = New System.Drawing.Size(122, 136)
        Me.gbxYear.TabIndex = 7
        Me.gbxYear.TabStop = False
        Me.gbxYear.Text = "Select Year"
        '
        'rdbSenior
        '
        Me.rdbSenior.AutoSize = True
        Me.rdbSenior.Location = New System.Drawing.Point(6, 101)
        Me.rdbSenior.Name = "rdbSenior"
        Me.rdbSenior.Size = New System.Drawing.Size(55, 17)
        Me.rdbSenior.TabIndex = 3
        Me.rdbSenior.TabStop = True
        Me.rdbSenior.Text = "Senior"
        Me.rdbSenior.UseVisualStyleBackColor = True
        '
        'rdbJunior
        '
        Me.rdbJunior.AutoSize = True
        Me.rdbJunior.Location = New System.Drawing.Point(6, 75)
        Me.rdbJunior.Name = "rdbJunior"
        Me.rdbJunior.Size = New System.Drawing.Size(53, 17)
        Me.rdbJunior.TabIndex = 2
        Me.rdbJunior.TabStop = True
        Me.rdbJunior.Text = "Junior"
        Me.rdbJunior.UseVisualStyleBackColor = True
        '
        'rdbSophomore
        '
        Me.rdbSophomore.AutoSize = True
        Me.rdbSophomore.Location = New System.Drawing.Point(7, 49)
        Me.rdbSophomore.Name = "rdbSophomore"
        Me.rdbSophomore.Size = New System.Drawing.Size(79, 17)
        Me.rdbSophomore.TabIndex = 1
        Me.rdbSophomore.TabStop = True
        Me.rdbSophomore.Text = "Sophomore"
        Me.rdbSophomore.UseVisualStyleBackColor = True
        '
        'rdbFreshman
        '
        Me.rdbFreshman.AutoSize = True
        Me.rdbFreshman.Location = New System.Drawing.Point(7, 23)
        Me.rdbFreshman.Name = "rdbFreshman"
        Me.rdbFreshman.Size = New System.Drawing.Size(71, 17)
        Me.rdbFreshman.TabIndex = 0
        Me.rdbFreshman.TabStop = True
        Me.rdbFreshman.Text = "Freshman"
        Me.rdbFreshman.UseVisualStyleBackColor = True
        '
        'lstMajor
        '
        Me.lstMajor.FormattingEnabled = True
        Me.lstMajor.ItemHeight = 16
        Me.lstMajor.Items.AddRange(New Object() {"Accounting", "Business", "Computer Information Systems", "Marketing"})
        Me.lstMajor.Location = New System.Drawing.Point(372, 143)
        Me.lstMajor.Name = "lstMajor"
        Me.lstMajor.Size = New System.Drawing.Size(182, 84)
        Me.lstMajor.TabIndex = 8
        '
        'cboSchool
        '
        Me.cboSchool.FormattingEnabled = True
        Me.cboSchool.Items.AddRange(New Object() {"<None>", "Franklin", "Highland", "Midtown"})
        Me.cboSchool.Location = New System.Drawing.Point(372, 273)
        Me.cboSchool.Name = "cboSchool"
        Me.cboSchool.Size = New System.Drawing.Size(183, 24)
        Me.cboSchool.TabIndex = 9
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(109, 412)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 416)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(654, 24)
        Me.MenuStrip1.TabIndex = 12
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSchoolToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddSchoolToolStripMenuItem
        '
        Me.AddSchoolToolStripMenuItem.Name = "AddSchoolToolStripMenuItem"
        Me.AddSchoolToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddSchoolToolStripMenuItem.Text = "Add School"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
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
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'chkDean
        '
        Me.chkDean.AutoSize = True
        Me.chkDean.Location = New System.Drawing.Point(237, 292)
        Me.chkDean.Name = "chkDean"
        Me.chkDean.Size = New System.Drawing.Size(87, 20)
        Me.chkDean.TabIndex = 13
        Me.chkDean.Text = "Dean's List"
        Me.chkDean.UseVisualStyleBackColor = True
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.Location = New System.Drawing.Point(372, 254)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(43, 16)
        Me.lblSchool.TabIndex = 14
        Me.lblSchool.Text = "School"
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(654, 453)
        Me.Controls.Add(Me.lblSchool)
        Me.Controls.Add(Me.chkDean)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cboSchool)
        Me.Controls.Add(Me.lstMajor)
        Me.Controls.Add(Me.gbxYear)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblJason)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectTitle"
        Me.gbxYear.ResumeLayout(False)
        Me.gbxYear.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJason As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents gbxYear As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbJunior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSophomore As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFreshman As System.Windows.Forms.RadioButton
    Friend WithEvents lstMajor As System.Windows.Forms.ListBox
    Friend WithEvents cboSchool As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents chkDean As System.Windows.Forms.CheckBox
    Friend WithEvents lblSchool As System.Windows.Forms.Label

End Class
