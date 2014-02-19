'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 02

' Unit 5 Project 

' Program Description: PieceWork Calculator

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmProject

    'Declare global variabls
    Dim TotalPieces As Integer
    Dim TotalEmployees As Integer
    Dim TotalPay As Decimal

    'Declare constants
    Const P_1_199 As Decimal = 0.5
    Const P_200_399 As Decimal = 0.55
    Const P_400_599 As Decimal = 0.6
    Const P_600_Plus As Decimal = 0.65

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Display Project Information
        MsgBox("This program calculates piecework.  Made by Jason Chapell", vbInformation, "About")

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear name
        txtName.Clear()

        'Clear pieces
        txtPieces.Clear()

        'Clear output
        txtOutput.Clear()

    End Sub

    Private Sub FontToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem1.Click
        'Determing current font
        FontDialog1.Font = txtOutput.Font

        'Display font picker
        FontDialog1.ShowDialog()

        'Set text to new font
        txtOutput.Font = FontDialog1.Font

    End Sub

    Private Sub ColorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        'Determing current color
        ColorDialog1.Color = txtOutput.ForeColor

        'Display color picker
        ColorDialog1.ShowDialog()

        'Set text to new color
        txtOutput.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub CalculatePayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculatePayToolStripMenuItem.Click
        'Declare variables
        Dim Pieces As Integer
        Dim Name As String
        Dim Pay As Decimal

        'Check for name
        If txtName.Text <> "" Then
            'Get Name
            Name = txtName.Text


            Try
                'Get pieces
                Pieces = CInt(txtPieces.Text)

                'Calculate pay - call function
                Pay = GetPay(Pieces)

                'Display name and pay
                txtOutput.Text = Name & " earned " & FormatCurrency(Pay)

                'Add pay to total pay
                TotalPay += Pay

                'Add 1 to total employees
                TotalEmployees += 1

                'Add pieces to total pieces
                TotalPieces += Pieces

            Catch ex As Exception
                'Display error if not a valid number 

                MsgBox("You did not enter valid pieces", vbOKOnly, "OOPS")
                txtPieces.Focus()

            End Try



        Else
            'Display error if no name
            MsgBox("You did not enter a name", vbOKOnly, "OOPS...TRY AGAIN")
            txtName.Focus()

        End If



    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        'Declare variables
        Dim AveragePIeces As Decimal
        Dim AveragePay As Decimal
        Dim OutputString As String

        'Determine average pieces
        AveragePIeces = TotalPieces / TotalEmployees

        'Determine average pay
        AveragePay = TotalPay / TotalEmployees

        'Set output string
        OutputString = "Total Employees: " & TotalEmployees.ToString & Environment.NewLine & _
                        "Total Pay: " & FormatCurrency(TotalPay) & Environment.NewLine & _
                        "Total Pieces: " & TotalPieces.ToString & Environment.NewLine & _
                        "Average Pay: " & FormatCurrency(AveragePay) & Environment.NewLine & _
                        "Average Pieces: " & AveragePIeces.ToString & Environment.NewLine

        'Display output string
        MsgBox(OutputString, vbInformation, "Your Summary")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the program
        Me.Close()

    End Sub

    Function GetPay(ByVal P As Integer) As Decimal

        'Use select case to determine pay range
        Select Case P
            Case Is < 200
                Return P * P_1_199
            Case Is < 400
                Return P * P_200_399
            Case Is < 600
                Return P * P_400_599
                'Random comment to say HelloWorld
            Case Is > 599
                Return P * P_600_Plus
            Case Else
                Return 0

        End Select

        'Return pay range*pieces

    End Function

End Class
