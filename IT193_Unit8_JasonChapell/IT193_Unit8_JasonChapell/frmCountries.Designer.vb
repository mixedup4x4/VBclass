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
        Me.gpbCountry.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJason
        '
        Me.lblJason.AutoSize = True
        Me.lblJason.Location = New System.Drawing.Point(477, 502)
        Me.lblJason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJason.Name = "lblJason"
        Me.lblJason.Size = New System.Drawing.Size(172, 16)
        Me.lblJason.TabIndex = 1
        Me.lblJason.Text = "Programmed by: Jason Chapell"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(490, 523)
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
        Me.gpbCountry.Location = New System.Drawing.Point(126, 127)
        Me.gpbCountry.Name = "gpbCountry"
        Me.gpbCountry.Size = New System.Drawing.Size(359, 205)
        Me.gpbCountry.TabIndex = 3
        Me.gpbCountry.TabStop = False
        Me.gpbCountry.Text = "Select How You Want To Search"
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
        Me.btnLookup.Location = New System.Drawing.Point(126, 421)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(75, 23)
        Me.btnLookup.TabIndex = 4
        Me.btnLookup.Text = "Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(271, 421)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(533, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Identify Countries by Name or Abbreviation"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(410, 421)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(668, 550)
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

End Class
