'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 02 

' Unit 8 Project 

' Program Description: Search by Abbreviation or Name

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmProject
    'declare structure
    Structure Country
        Dim Name As String
        Dim Abbreviation As String
    End Structure

    'declare array
    Dim TableOfCountries(8) As Country



    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs)
        'close program
        Me.Close()

    End Sub

    Private Sub rdoAbbreviation_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoAbbreviation.CheckedChanged, rdoCountryName.CheckedChanged
        Dim RB As RadioButton

        'determine which button was selected
        RB = CType(sender, RadioButton)

        'use case statement to set one to read only
        Select Case RB.Name
            Case "rdoAbbreviation"
                txtAbbreviation.ReadOnly = False
                txtCountryName.ReadOnly = True
                txtAbbreviation.Focus()
            Case "rdoCountryName"
                txtCountryName.ReadOnly = False
                txtAbbreviation.ReadOnly = True
                txtCountryName.Focus()

        End Select

    End Sub

    Private Sub btnLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnLookup.Click
        'declare variable
        Dim counter As Integer
        Dim found As Boolean

        'if abbreviation is checked 
        If rdoAbbreviation.Checked Then
            While (counter <= TableOfCountries.GetUpperBound(0)) And Not found


                'compare the abbreviation text box with element of array
                If txtAbbreviation.Text.ToUpper = TableOfCountries(counter).Abbreviation.toUpper Then
                    'if a match 
                    'set name to corresponding name
                    txtCountryName.Text = TableOfCountries(counter).Name
                    found = True
                Else
                    'if not a match
                    'loop to next item in array
                    counter += 1
                End If
            End While

        Else

        End If



        'if name is checked

        If rdoCountryName.Checked Then
            While (counter <= 8) And Not found


                'compare the abbreviation text box with element of array
                If txtCountryName.Text.ToUpper = TableOfCountries(counter).Name.ToUpper Then
                    'if a match 
                    'set name to corresponding name
                    txtAbbreviation.Text = TableOfCountries(counter).Abbreviation
                    found = True
                Else
                    'if not a match
                    'loop to next item in array
                    counter += 1
                End If
            End While
        End If


        'if item not found
        'display error
        If Not found Then
            MsgBox("TRY AGAIN, THAT COUNTRY IS NOT IN MY DATABASE", vbCritical, "OOPS")

        End If

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'clear both text boxes
        txtAbbreviation.Clear()
        txtCountryName.Clear()

        'set abbreviation to checked
        rdoAbbreviation.Focus()

    End Sub

    Private Sub frmProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TableOfCountries(0).Abbreviation = "AQ"
        TableOfCountries(0).Name = "Antartica"
        TableOfCountries(1).Abbreviation = "BS"
        TableOfCountries(1).Name = "Bahamas"
        TableOfCountries(2).Abbreviation = "CA"
        TableOfCountries(2).Name = "Canada"
        TableOfCountries(3).Abbreviation = "EE"
        TableOfCountries(3).Name = "Estonia"
        TableOfCountries(4).Abbreviation = "FR"
        TableOfCountries(4).Name = "France"
        TableOfCountries(5).Abbreviation = "IE"
        TableOfCountries(5).Name = "Ireland"
        TableOfCountries(6).Abbreviation = "JP"
        TableOfCountries(6).Name = "Japan"
        TableOfCountries(7).Abbreviation = "MX"
        TableOfCountries(7).Name = "Mexico"
        TableOfCountries(8).Abbreviation = "NL"
        TableOfCountries(8).Name = "Netherlands"
    End Sub

    Private Sub btnExit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'close program
        Me.Close()

    End Sub
End Class
