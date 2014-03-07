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
        Me.gpbCountry = New System.Windows.Forms.GroupBox()
        Me.txtCountryName = New System.Windows.Forms.TextBox()
        Me.txtAbbreviation = New System.Windows.Forms.TextBox()
        Me.rdoCountryName = New System.Windows.Forms.RadioButton()
        Me.rdoAbbreviation = New System.Windows.Forms.RadioButton()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pixFlag = New System.Windows.Forms.PictureBox()
        Me.gpbCountry.SuspendLayout()
        CType(Me.pixFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJason
        '
        Me.lblJason.AutoSize = True
        Me.lblJason.Location = New System.Drawing.Point(405, 255)
        Me.lblJason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJason.Name = "lblJason"
        Me.lblJason.Size = New System.Drawing.Size(172, 16)
        Me.lblJason.TabIndex = 1
        Me.lblJason.Text = "Programmed by: Jason Chapell"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(418, 276)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(172, 16)
        Me.lblClass.TabIndex = 2
        Me.lblClass.Text = "Kaplan University - IT193-02"
        '
        'gpbCountry
        '
        Me.gpbCountry.Controls.Add(Me.txtCountryName)
        Me.gpbCountry.Controls.Add(Me.txtAbbreviation)
        Me.gpbCountry.Controls.Add(Me.rdoCountryName)
        Me.gpbCountry.Controls.Add(Me.rdoAbbreviation)
        Me.gpbCountry.Location = New System.Drawing.Point(18, 58)
        Me.gpbCountry.Name = "gpbCountry"
        Me.gpbCountry.Size = New System.Drawing.Size(380, 213)
        Me.gpbCountry.TabIndex = 3
        Me.gpbCountry.TabStop = False
        Me.gpbCountry.Text = "Select How You Want To Search"
        Me.gpbCountry.Visible = False
        '
        'txtCountryName
        '
        Me.txtCountryName.Location = New System.Drawing.Point(169, 126)
        Me.txtCountryName.Name = "txtCountryName"
        Me.txtCountryName.Size = New System.Drawing.Size(156, 23)
        Me.txtCountryName.TabIndex = 3
        '
        'txtAbbreviation
        '
        Me.txtAbbreviation.Location = New System.Drawing.Point(169, 59)
        Me.txtAbbreviation.Name = "txtAbbreviation"
        Me.txtAbbreviation.Size = New System.Drawing.Size(156, 23)
        Me.txtAbbreviation.TabIndex = 2
        '
        'rdoCountryName
        '
        Me.rdoCountryName.AutoSize = True
        Me.rdoCountryName.Location = New System.Drawing.Point(26, 127)
        Me.rdoCountryName.Name = "rdoCountryName"
        Me.rdoCountryName.Size = New System.Drawing.Size(102, 20)
        Me.rdoCountryName.TabIndex = 1
        Me.rdoCountryName.TabStop = True
        Me.rdoCountryName.Text = "Country Name"
        Me.rdoCountryName.UseVisualStyleBackColor = True
        '
        'rdoAbbreviation
        '
        Me.rdoAbbreviation.AutoSize = True
        Me.rdoAbbreviation.Location = New System.Drawing.Point(26, 59)
        Me.rdoAbbreviation.Name = "rdoAbbreviation"
        Me.rdoAbbreviation.Size = New System.Drawing.Size(93, 20)
        Me.rdoAbbreviation.TabIndex = 0
        Me.rdoAbbreviation.TabStop = True
        Me.rdoAbbreviation.Text = "Abbreviation"
        Me.rdoAbbreviation.UseVisualStyleBackColor = True
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(18, 277)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(75, 23)
        Me.btnLookup.TabIndex = 4
        Me.btnLookup.Text = "Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        Me.btnLookup.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(99, 277)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(533, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Identify Countries by Name or Abbreviation"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(404, 58)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 8
        Me.btnLoad.Text = "Load Data"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pixFlag
        '
        Me.pixFlag.Location = New System.Drawing.Point(408, 89)
        Me.pixFlag.Name = "pixFlag"
        Me.pixFlag.Size = New System.Drawing.Size(217, 140)
        Me.pixFlag.TabIndex = 9
        Me.pixFlag.TabStop = False
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(637, 322)
        Me.Controls.Add(Me.pixFlag)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLookup)
        Me.Controls.Add(Me.gpbCountry)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblJason)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CountryNameIdentifier"
        Me.gpbCountry.ResumeLayout(False)
        Me.gpbCountry.PerformLayout()
        CType(Me.pixFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJason As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents gpbCountry As System.Windows.Forms.GroupBox
    Friend WithEvents txtCountryName As System.Windows.Forms.TextBox
    Friend WithEvents txtAbbreviation As System.Windows.Forms.TextBox
    Friend WithEvents rdoCountryName As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAbbreviation As System.Windows.Forms.RadioButton
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pixFlag As System.Windows.Forms.PictureBox

End Class
