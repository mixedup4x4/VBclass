'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 04

' Unit 4 Project World Flags

' There are only 10 type of people in the world

' Program Description: Hello World in multiple languages

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmWorldFlags

    Private Sub rdbUSA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbUSA.CheckedChanged
        'USA

        'Display Country Flag
        'pixFlag.Image = My.Resources.United_States_of_America

        'Display Country Name
        'lblCountryName.Text = "United States"

    End Sub

    Private Sub rdbGermany_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbGermany.CheckedChanged
        'Germany

        'Display Country Flag
        'pixFlag.Image = My.Resources.Germany

        'Display Country Name
        'lblCountryName.Text = "Germany"

    End Sub

    Private Sub rdbJapan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbJapan.CheckedChanged
        'Japan

        'Display Country Flag
        'pixFlag.Image = My.Resources.Japan

        'Display Country Name
        'lblCountryName.Text = "Japan"

    End Sub

    Private Sub rdbHonduras_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbHonduras.CheckedChanged
        'Honduras

        'Display Country Flag
        'pixFlag.Image = My.Resources.Honduras

        'Display Country Name
        'lblCountryName.Text = "Honduras"

    End Sub

    Private Sub chkUSA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUSA.CheckedChanged
        'Set Country Name
        'lblCountryName.Visible = chkUSA.Checked

        'Display Country Name
        'lblCountryName.Text = "United States"

    End Sub

    Private Sub chkGermany_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGermany.CheckedChanged
        'Set Country Name
        'lblCountryName.Visible = chkGermany.Checked

        'Display Country Name
        'lblCountryName.Text = "Germany"

    End Sub

    Private Sub chkJapan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkJapan.CheckedChanged
        'Set Country Name
        'lblCountryName.Visible = chkJapan.Checked

        'Display Country Name
        'lblCountryName.Text = "Japan"

    End Sub

    Private Sub chkHonduras_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHonduras.CheckedChanged
        'Set Country Name
        'lblCountryName.Visible = chkHonduras.Checked

        'Display Country Name
        'lblCountryName.Text = "Honduras"

    End Sub
    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        'Display the flag and country name based on what is selected
        If rdbUSA.Checked Then
            pixFlag.Image = My.Resources.United_States_of_America
            If chkUSA.Checked Then
                lblCountryName.Text = "USA"
            ElseIf MsgBox("You have selected two countries that do not match", vbCritical, "Oops!") Then
            End If
        ElseIf rdbJapan.Checked Then
            pixFlag.Image = My.Resources.Japan
            If chkJapan.Checked Then
                lblCountryName.Text = "Japan"
            ElseIf MsgBox("You have selected two countries that do not match", vbCritical, "Oops!") Then
            End If
        ElseIf rdbGermany.Checked Then
            pixFlag.Image = My.Resources.Germany
            If chkGermany.Checked Then
                lblCountryName.Text = "Germany"
            ElseIf MsgBox("You have selected two countries that do not match", vbCritical, "Oops!") Then
            End If
        ElseIf rdbHonduras.Checked Then
            pixFlag.Image = My.Resources.Honduras
            If chkHonduras.Checked Then
                lblCountryName.Text = "Honduras"
            ElseIf MsgBox("You have selected two countries that do not match", vbCritical, "Oops!") Then
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Close the Program
        Me.Close()
    End Sub

End Class
