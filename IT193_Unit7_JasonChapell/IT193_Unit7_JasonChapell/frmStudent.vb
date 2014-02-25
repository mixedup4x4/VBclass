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
        'check for name
if txtName.text <> "" then
'set name
StudentName = txtName.text
	Try
	'check units
	if txtUnits.text <> "" then
	'set units
	Units = CInt.(txtUnits.text)
		'check if school year entered
        If rdbFreshman.Checked Or rdbJunior.Checked Or rdbSenior.Checked Or rdbSophomore.Checked Then
        'set school year
		If rdbFreshman.Checked Then
        SchoolYear = "Freshman"
        ElseIf rdbJunior.Checked Then
        SchoolYear = "Junior"
        ElseIf rdbSenior.Checked Then
        SchoolYear = "Senior"
        ElseIf rdbSophomore.checket Then
		Schoolyear = "Sophomore"
			'check if major entered
            If lstMajor.SelectedIndex <> -1 Then
			'set major
            Major = lstMajor.SelectedItem
				'check if school entered
                If cboSchool.SelectedIndex <> -1 Then
				'set school
                School = cboSchool.SelectedItem
				'check if deans list
                    If chkDean.Checked Then
					'set deans list
                    DeansList = "Dean's List"
                    Else
                    DeansList = "No"
                    End If
						'All complete = make and print document
						PrintPreviewDialog1.Document = PrintDocument1
						PrintPreviewDialog1.ShowDialog()
				Else
				msgBox("You did not select a school!",vbCritical,"OOPS!")
				End If
			Else
			msgBox("You did not select a major!",vbCritical,"OOPS!")
			End If
		Else
		msgBox("You did not select a school year!",vbCritical,"OOPS!")
		End If
	Catch ex As Exception
	Else
	msgBox("You did not enter units!",vbCritical,"OOPS!")
	txtUnits.focus()
	End If
	End Try
Else
msgBox("You did not enter a name!",vbCritical,"OOPS!")
txtName.text.focus()
End If

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
        VerticalPrintLocationSingle += LineHeightSingle

        'print student name
        PrintLineString = " Student Name " & StudentName

        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        VerticalPrintLocationSingle += LineHeightSingle

        'print units
        PrintLineString = " Units " & Units.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        VerticalPrintLocationSingle += LineHeightSingle

        'print major
        PrintLineString = " Major " & Major.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        VerticalPrintLocationSingle += LineHeightSingle

        'print school
        PrintLineString = " School " & School.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        VerticalPrintLocationSingle += LineHeightSingle

        'print school year
        PrintLineString = " School Year " & SchoolYear.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
        VerticalPrintLocationSingle += LineHeightSingle

        'print deans list
        PrintLineString = " Deans List " & DeansList.ToString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Red, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        'move down
		VerticalPrintLocationSingle += LineHeightSingle

    End Sub
End Class
