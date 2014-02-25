
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
66
67
68
69
70
71
72
73
74
75
76
77
78
79
80
81
82
83
84
85
86
87
88
89
90
91
92
93
94
95
96
97
98
99
100
101
102
103
104
105
106
107
108
109
110
111
112
113
114
115
116
117
118
119
120
121
122
123
124
125
126
127
128
129
130
131
132
133
134
135
136
137
138
139
140
141
142
143
144
145
146
147
148
149
150
151
152
153
154
155
156
157
158
159
160
161
162
163
164
165
166
167
168
169
170
171
172
173
174
175
176
177
178
179
180
181
182
183
184
185
186
187
188
189
190
191
192
193
194
195
196
197
198
199
200
201
202
203
204
205
206
207
208
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
			'check if units entered
                if txtUnits <> "" then
				'set units
				Units = CInt(txtUnits.Text)
				'check if school year entered
                If rdbFreshman.Checked Or rdbJunior.Checked Or rdbSenior.Checked Or rdbSophomore.Checked Then
                    'set school year
					If rdbFreshman.Checked Then
                        SchoolYear = "Freshman"
                    ElseIf rdbJunior.Checked Then
                        SchoolYear = "Junior"
                    ElseIf rdbSenior.Checked Then
                        SchoolYear = "Senior"
                    Else : SchoolYear = "Sophomore"
                    End If
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
                            MsgBox("You did not select a school", vbCritical, "OOPS")
                        End If
                    Else
                        MsgBox("You did not select a Major", vbCritical, "OOPS")
                    End If
                Else
                    MsgBox("You did not select a School Year", vbCritical, "OOPS")
                End If

            Catch ex As Exception
				End if
			   MsgBox("You did not type in units", vbCritical, "OOPS")
                txtUnits.Focus()

            End Try
        Else
            MsgBox("You did not enter a name", vbCritical, "OOPS")
            txtName.Focus()
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
