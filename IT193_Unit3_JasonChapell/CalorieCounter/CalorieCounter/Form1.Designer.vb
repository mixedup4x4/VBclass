<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalorieCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalorieCounter))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblJason = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.lblCalorieCounter = New System.Windows.Forms.Label()
        Me.txtCarbs = New System.Windows.Forms.TextBox()
        Me.txtTotalCalories = New System.Windows.Forms.TextBox()
        Me.txtProtien = New System.Windows.Forms.TextBox()
        Me.txtTotalCalculations = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblProtien = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblTotalCalculations = New System.Windows.Forms.Label()
        Me.lblTotalCalories = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(395, 76)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 33)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblJason
        '
        Me.lblJason.AutoSize = True
        Me.lblJason.Location = New System.Drawing.Point(395, 156)
        Me.lblJason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJason.Name = "lblJason"
        Me.lblJason.Size = New System.Drawing.Size(172, 16)
        Me.lblJason.TabIndex = 1
        Me.lblJason.Text = "Programmed by: Jason Chapell"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(395, 209)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(172, 16)
        Me.lblClass.TabIndex = 2
        Me.lblClass.Text = "Kaplan University - IT193-02"
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(226, 86)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(161, 33)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(226, 149)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 33)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearAll.Location = New System.Drawing.Point(226, 202)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(161, 33)
        Me.btnClearAll.TabIndex = 5
        Me.btnClearAll.Text = "ClearEverything"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'lblCalorieCounter
        '
        Me.lblCalorieCounter.AutoSize = True
        Me.lblCalorieCounter.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalorieCounter.Location = New System.Drawing.Point(205, 9)
        Me.lblCalorieCounter.Name = "lblCalorieCounter"
        Me.lblCalorieCounter.Size = New System.Drawing.Size(169, 23)
        Me.lblCalorieCounter.TabIndex = 6
        Me.lblCalorieCounter.Text = "CALORIE COUNTER"
        '
        'txtCarbs
        '
        Me.txtCarbs.Location = New System.Drawing.Point(13, 86)
        Me.txtCarbs.Name = "txtCarbs"
        Me.txtCarbs.Size = New System.Drawing.Size(100, 23)
        Me.txtCarbs.TabIndex = 7
        '
        'txtTotalCalories
        '
        Me.txtTotalCalories.Location = New System.Drawing.Point(119, 202)
        Me.txtTotalCalories.Name = "txtTotalCalories"
        Me.txtTotalCalories.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalCalories.TabIndex = 8
        '
        'txtProtien
        '
        Me.txtProtien.Location = New System.Drawing.Point(13, 202)
        Me.txtProtien.Name = "txtProtien"
        Me.txtProtien.Size = New System.Drawing.Size(100, 23)
        Me.txtProtien.TabIndex = 14
        '
        'txtTotalCalculations
        '
        Me.txtTotalCalculations.Location = New System.Drawing.Point(119, 149)
        Me.txtTotalCalculations.Name = "txtTotalCalculations"
        Me.txtTotalCalculations.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalCalculations.TabIndex = 15
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(13, 144)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 23)
        Me.txtFat.TabIndex = 16
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(119, 86)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 23)
        Me.txtCalories.TabIndex = 17
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Location = New System.Drawing.Point(13, 67)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(38, 16)
        Me.lblCarbs.TabIndex = 18
        Me.lblCarbs.Text = "Carbs"
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Location = New System.Drawing.Point(13, 125)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(26, 16)
        Me.lblFat.TabIndex = 19
        Me.lblFat.Text = "Fat"
        '
        'lblProtien
        '
        Me.lblProtien.AutoSize = True
        Me.lblProtien.Location = New System.Drawing.Point(13, 183)
        Me.lblProtien.Name = "lblProtien"
        Me.lblProtien.Size = New System.Drawing.Size(45, 16)
        Me.lblProtien.TabIndex = 20
        Me.lblProtien.Text = "Protien"
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Location = New System.Drawing.Point(173, 67)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(49, 16)
        Me.lblCalories.TabIndex = 21
        Me.lblCalories.Text = "Calories"
        '
        'lblTotalCalculations
        '
        Me.lblTotalCalculations.AutoSize = True
        Me.lblTotalCalculations.Location = New System.Drawing.Point(116, 130)
        Me.lblTotalCalculations.Name = "lblTotalCalculations"
        Me.lblTotalCalculations.Size = New System.Drawing.Size(103, 16)
        Me.lblTotalCalculations.TabIndex = 22
        Me.lblTotalCalculations.Text = "Total Calculations"
        '
        'lblTotalCalories
        '
        Me.lblTotalCalories.AutoSize = True
        Me.lblTotalCalories.Location = New System.Drawing.Point(137, 183)
        Me.lblTotalCalories.Name = "lblTotalCalories"
        Me.lblTotalCalories.Size = New System.Drawing.Size(82, 16)
        Me.lblTotalCalories.TabIndex = 23
        Me.lblTotalCalories.Text = "Total Calories"
        '
        'frmCalorieCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(575, 241)
        Me.Controls.Add(Me.lblTotalCalories)
        Me.Controls.Add(Me.lblTotalCalculations)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblProtien)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtTotalCalculations)
        Me.Controls.Add(Me.txtProtien)
        Me.Controls.Add(Me.txtTotalCalories)
        Me.Controls.Add(Me.txtCarbs)
        Me.Controls.Add(Me.lblCalorieCounter)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblJason)
        Me.Controls.Add(Me.btnExit)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmCalorieCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalorieCounter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblJason As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents lblCalorieCounter As System.Windows.Forms.Label
    Friend WithEvents txtCarbs As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCalories As System.Windows.Forms.TextBox
    Friend WithEvents txtProtien As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCalculations As System.Windows.Forms.TextBox
    Friend WithEvents txtFat As System.Windows.Forms.TextBox
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents lblCarbs As System.Windows.Forms.Label
    Friend WithEvents lblFat As System.Windows.Forms.Label
    Friend WithEvents lblProtien As System.Windows.Forms.Label
    Friend WithEvents lblCalories As System.Windows.Forms.Label
    Friend WithEvents lblTotalCalculations As System.Windows.Forms.Label
    Friend WithEvents lblTotalCalories As System.Windows.Forms.Label

End Class
