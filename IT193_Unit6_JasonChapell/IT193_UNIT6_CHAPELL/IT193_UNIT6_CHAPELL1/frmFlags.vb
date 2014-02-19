'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 02

' Unit 6 Project 

' Program Description: FLAG VIEWER

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmFlags

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Show about diaglog
        AboutBox1.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the program
        Me.Close()

    End Sub

    Private Sub UnitedStatesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnitedStatesToolStripMenuItem.Click
        'show USA flag
        pixFlag.Image = My.Resources.United_States_of_America
        'set usa checked
        UnitedStatesToolStripMenuItem.Checked = True
        'set country name
        lblCountryName.Text = "USA"
        'set germany not checked
        GermanyToolStripMenuItem.Checked = False
        'set japan not checked
        JapanToolStripMenuItem.Checked = False
        'set honduras not checked
        HondurasToolStripMenuItem.Checked = False

    End Sub

    Private Sub GermanyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GermanyToolStripMenuItem.Click
        'show Germany flag
        pixFlag.Image = My.Resources.Germany
        'set country name
        lblCountryName.Text = "Germany"
        'set usa not checked
        UnitedStatesToolStripMenuItem.Checked = False
        'set germany checked
        GermanyToolStripMenuItem.Checked = True
        'set japan not checked
        JapanToolStripMenuItem.Checked = False
        'set honduras not checked
        HondurasToolStripMenuItem.Checked = False

    End Sub

    Private Sub JapanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JapanToolStripMenuItem.Click
        'show Japan flag
        pixFlag.Image = My.Resources.Japan
        'set country name
        lblCountryName.Text = "Japan"
        'set usa not checked
        UnitedStatesToolStripMenuItem.Checked = False
        'set germany checked
        GermanyToolStripMenuItem.Checked = False
        'set japan checked
        JapanToolStripMenuItem.Checked = True
        'set honduras not checked
        HondurasToolStripMenuItem.Checked = False

    End Sub

    Private Sub HondurasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HondurasToolStripMenuItem.Click
        'show Honduras flag
        pixFlag.Image = My.Resources.Honduras
        'set country name
        lblCountryName.Text = "Honduras"
        'set usa not checked
        UnitedStatesToolStripMenuItem.Checked = False
        'set germany checked
        GermanyToolStripMenuItem.Checked = False
        'set japan checked
        JapanToolStripMenuItem.Checked = False
        'set honduras checked
        HondurasToolStripMenuItem.Checked = True

    End Sub

    Private Sub CountryNameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CountryNameToolStripMenuItem.Click
        'show USA
        lblCountryName.Visible = CountryNameToolStripMenuItem.Checked()

    End Sub

    Private Sub GermanyToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles GermanToolStripMenuItem.Click
        'show Germany
        lblCountryName.Visible = GermanyToolStripMenuItem.Checked

    End Sub

    Private Sub JapanToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles JapanToolStripMenuItem1.Click
        'show Japan
        lblCountryName.Visible = JapanToolStripMenuItem.Checked

    End Sub

    Private Sub HondurasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HondurasToolStripMenuItem1.Click
        'set form title visible to what menuItem.checked property is

        'show Honduras
        lblCountryName.Visible = HondurasToolStripMenuItem.Checked

    End Sub

    Private Sub SplashToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SplashToolStripMenuItem.Click
        'show splash screen
        SplashScreen1.ShowDialog()

    End Sub
End Class
