'========================================================= 

' <Jason Chapell>

' EMAIL: <jasonchapell@student.kaplan.edu>

' Operating System Version Windows XP Pro 64-Bit in a VM on a MAC

' Your Compiler (Visual Studio 2010 Ultimate) 

' Course IT193 Section 02 

' Unit 7 Project 

' Program Description: Student Information

' Academic Honesty: 

' I attest that this is my original work. 

' I have not used unauthorized source code, either modified or unmodified. 

' I have not given other fellow student(s) access to my program. 

'=========================================================== 
Public Class frmProject

    'declare globals
    Dim StudentName As String
    Dim Units As Integer
    Dim SchoolYear As String
    Dim School As String
    Dim Major As String
    Dim DeansList As String

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'close program
        Me.Close()

    End Sub

    Private Sub AddSchoolToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddSchoolToolStripMenuItem.Click
        'check if a name is entered
        If cboSchool.Text <> "" Then
            'add name to collection
            cboSchool.Items.Add(cboSchool.Text)
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'show about box
        AboutBox1.ShowDialog()

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'check if name is entered
        If txtName.Text <> "" Then
            'set name
            StudentName = txtName.Text
            Try
                Units = CInt(txtUnits.Text)

                If rdbFreshman.Checked Or rdbJunior.Checked Or rdbSenior.Checked Or rdbSophomore.Checked Then
                    If rdbFreshman.Checked Then
                        SchoolYear = "Freshman"
                    ElseIf rdbJunior.Checked Then
                        SchoolYear = "Junior"
                    ElseIf rdbSenior.Checked Then
                        SchoolYear = "Senior"
                    Else : SchoolYear = "Sophomore"
                    End If

                    If lstMajor.SelectedIndex <> -1 Then
                        Major = lstMajor.SelectedItem
                        If cboSchool.SelectedIndex <> -1 Then
                            School = cboSchool.SelectedItem
                            If chkDean.Checked Then
                                DeansList = "Dean's List"
                            Else
                                DeansList = "No"
                            End If
                            PrintPreviewDialog1.Document = PrintDocument1
                            PrintPreviewDialog1.ShowDialog()

                        Else
                            MsgBox("You did not select a school", vbCritical, "OOPS")
                        End If
                    Else
                        MsgBox("You did not select a Major", vbCritical, "OOPS")
                    End If
                Else
                    MsgBox("You did not select a School Year", vbCritical, "OOPS")
                End If

            Catch ex As Exception
                MsgBox("You did not type in units", vbCritical, "OOPS")
                txtUnits.Focus()

            End Try
        Else
            MsgBox("You did not enter a name", vbCritical, "OOPS")
            txtName.Focus()
        End If


        'check if units entered

        'set units

        'check if school year entered

        'set school year

        'check if school entered

        'set school

        'check if major entered

        'set major

        'check if deans list

        'set if deans list or not

        'All complete = make and print document


    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'close program
        Me.Close()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'set up variables
        'set up printer output
        Dim PrintFont As New Font("Arial", 12)
        Dim HeaderFont As New Font("Times New Roman", 24)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HeaderFontHeightSingle As Single = HeaderFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        'print header
        PrintLineString = " Student Information Form "
        e.Graphics.DrawString(PrintLineString, HeaderFont, Brushes.Blue, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += HeaderFontHeightSingle

        'print your name
        PrintLineString = " By Jason Chapell "
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += LineHeightSingle

        'print student name
        PrintLineString = " Student Name " & StudentName

        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += LineHeightSingle

        'print units
        PrintLineString = " Units " & Units.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += LineHeightSingle

        'print major
        PrintLineString = " Major " & Major.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += LineHeightSingle

        'print school
        PrintLineString = " School " & School.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += LineHeightSingle

        'print school year
        PrintLineString = " School Year " & SchoolYear.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        HorizontalPrintLocationSingle += LineHeightSingle

        'print deans list
        PrintLineString = " Deans List " & DeansList.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down


    End Sub
End Class
