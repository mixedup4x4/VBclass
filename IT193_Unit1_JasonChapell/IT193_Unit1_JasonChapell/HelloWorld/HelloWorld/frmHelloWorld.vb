'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 02 

' Unit 1 Project Hello World

' Program Description: Hello World in multiple languages

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmHelloWorld

    Private Sub btnEnglish_Click(sender As System.Object, e As System.EventArgs) Handles btnEnglish.Click
        'Display Hello World in the English
        txtOutPut.Text = "Hello World"
    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles lblJason.Click

    End Sub
    Private Sub btnItalian_Click(sender As System.Object, e As System.EventArgs) Handles btnItalian.Click
        'Display Hello world in Italian
        txtOutPut.Text = "Ciao Mondo!"
    End Sub
    Private Sub btnFrench_Click(sender As System.Object, e As System.EventArgs) Handles btnFrench.Click
        'Display Hello World In French
        txtOutPut.Text = "Bonjour tout le monde!"
    End Sub
    Private Sub btnGerman_Click(sender As System.Object, e As System.EventArgs) Handles btnGerman.Click
        'Display Hello World in German
        txtOutPut.Text = "Hallo Welt"
    End Sub
    Private Sub btnArabic_Click(sender As System.Object, e As System.EventArgs) Handles btnArabic.Click
        'Display Hello World in Arabic
        txtOutPut.Text = "مرحبا العالم"
    End Sub
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'Print the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class

