<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelloWorld))
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.txtOutPut = New System.Windows.Forms.TextBox()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnFrench = New System.Windows.Forms.Button()
        Me.lblJason = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGerman = New System.Windows.Forms.Button()
        Me.btnArabic = New System.Windows.Forms.Button()
        Me.lblKaplan = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtSchool = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnglish
        '
        Me.btnEnglish.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnglish.Location = New System.Drawing.Point(4, 38)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(74, 46)
        Me.btnEnglish.TabIndex = 0
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'txtOutPut
        '
        Me.txtOutPut.Location = New System.Drawing.Point(4, 12)
        Me.txtOutPut.Name = "txtOutPut"
        Me.txtOutPut.Size = New System.Drawing.Size(394, 20)
        Me.txtOutPut.TabIndex = 1
        Me.txtOutPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnItalian
        '
        Me.btnItalian.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalian.Location = New System.Drawing.Point(164, 40)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(74, 46)
        Me.btnItalian.TabIndex = 2
        Me.btnItalian.Text = "Italian"
        Me.btnItalian.UseVisualStyleBackColor = True
        '
        'btnFrench
        '
        Me.btnFrench.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrench.Location = New System.Drawing.Point(244, 40)
        Me.btnFrench.Name = "btnFrench"
        Me.btnFrench.Size = New System.Drawing.Size(74, 46)
        Me.btnFrench.TabIndex = 3
        Me.btnFrench.Text = "French"
        Me.btnFrench.UseVisualStyleBackColor = True
        '
        'lblJason
        '
        Me.lblJason.AutoSize = True
        Me.lblJason.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJason.Location = New System.Drawing.Point(267, 191)
        Me.lblJason.Name = "lblJason"
        Me.lblJason.Size = New System.Drawing.Size(123, 19)
        Me.lblJason.TabIndex = 4
        Me.lblJason.Text = "By: Jason Chapell"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(4, 92)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGerman
        '
        Me.btnGerman.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerman.Location = New System.Drawing.Point(84, 38)
        Me.btnGerman.Name = "btnGerman"
        Me.btnGerman.Size = New System.Drawing.Size(74, 46)
        Me.btnGerman.TabIndex = 6
        Me.btnGerman.Text = "German"
        Me.btnGerman.UseVisualStyleBackColor = True
        '
        'btnArabic
        '
        Me.btnArabic.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArabic.Location = New System.Drawing.Point(324, 40)
        Me.btnArabic.Name = "btnArabic"
        Me.btnArabic.Size = New System.Drawing.Size(74, 46)
        Me.btnArabic.TabIndex = 7
        Me.btnArabic.Text = "Arabic"
        Me.btnArabic.UseVisualStyleBackColor = True
        '
        'lblKaplan
        '
        Me.lblKaplan.AutoSize = True
        Me.lblKaplan.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaplan.Location = New System.Drawing.Point(12, 191)
        Me.lblKaplan.Name = "lblKaplan"
        Me.lblKaplan.Size = New System.Drawing.Size(188, 19)
        Me.lblKaplan.TabIndex = 8
        Me.lblKaplan.Text = "IT913-02 Kaplan University"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(244, 92)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(154, 46)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtSchool
        '
        Me.txtSchool.Location = New System.Drawing.Point(4, 263)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(394, 20)
        Me.txtSchool.TabIndex = 10
        Me.txtSchool.Text = "Enter Your School Name"
        Me.txtSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(4, 289)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(394, 20)
        Me.txtName.TabIndex = 11
        Me.txtName.Text = "Enter Your Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmHelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 314)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSchool)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblKaplan)
        Me.Controls.Add(Me.btnArabic)
        Me.Controls.Add(Me.btnGerman)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblJason)
        Me.Controls.Add(Me.btnFrench)
        Me.Controls.Add(Me.btnItalian)
        Me.Controls.Add(Me.txtOutPut)
        Me.Controls.Add(Me.btnEnglish)
        Me.Name = "frmHelloWorld"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World by Jason Chapell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnglish As System.Windows.Forms.Button
    Friend WithEvents txtOutPut As System.Windows.Forms.TextBox
    Friend WithEvents btnItalian As System.Windows.Forms.Button
    Friend WithEvents btnFrench As System.Windows.Forms.Button
    Friend WithEvents lblJason As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGerman As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnArabic As System.Windows.Forms.Button
    Friend WithEvents lblKaplan As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox

End Class
