'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 02 

' Unit 3 Project 

' Program Description: Calorie Counter

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmCalorieCounter
    'Delcare Global Variables
    Dim TotalCalories As Integer
    Dim TotalCalculations As Integer

    'Delcare Constants
    Const CARBS_VALUE As Integer = 4
    Const FAT_VALUE As Integer = 9
    Const PROTIEN_VALUE As Integer = 4

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        'Declare Variables
        Dim Carbs As Integer
        Dim Fat As Integer
        Dim Protien As Integer
        Dim Calories As Integer

        Try
            'Get Carbs from txt box
            Carbs = CInt(txtCarbs.Text)
            Try
                'Get Fat from txt box
                Fat = CInt(txtFat.Text)
                Try
                    'Get Protien from txt box
                    Protien = CInt(txtProtien.Text)

                    'DO THE REST
                    'Do calculation
                    Calories = (Carbs * CARBS_VALUE) + (Fat * FAT_VALUE) + (Protien * PROTIEN_VALUE)

                    'Display Calories
                    txtCalories.Text = Calories.ToString

                    'Add 1 to total calulations
                    TotalCalculations = TotalCalculations + 1

                    'Display total calculations
                    txtTotalCalculations.Text = TotalCalculations.ToString

                    'Add total calories
                    TotalCalories = Calories + TotalCalories

                    'Display total calories
                    txtTotalCalories.Text = TotalCalories.ToString
                Catch ex As Exception
                    MsgBox("Did not enter Protien", vbCritical, "ERROR")
                    txtProtien.Focus()

                End Try
            Catch ex As Exception
                MsgBox("Did not enter Fat", vbCritical, "ERROR")
                txtFat.Focus()

            End Try
        Catch ex As Exception
            MsgBox("Did not enter Carbs", vbCritical, "ERROR")
            txtCarbs.Focus()

        End Try
        
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        'Clear Entered Data
        txtCarbs.Clear()
        txtFat.Clear()
        txtProtien.Clear()
        txtCalories.Clear()

    End Sub

    Private Sub btnClearAll_Click(sender As System.Object, e As System.EventArgs) Handles btnClearAll.Click

        'Clear Entered Data
        txtCarbs.Clear()
        txtFat.Clear()
        txtProtien.Clear()
        txtCalories.Clear()
        txtTotalCalculations.Clear()
        txtTotalCalories.Clear()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Close The Program
        Me.Close()
    End Sub

End Class
