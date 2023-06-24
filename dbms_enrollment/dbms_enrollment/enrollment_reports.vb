Imports MySql.Data.MySqlClient

Public Class enrollment_reports

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStu.SelectedIndexChanged
        ' Code to populate the form with the selected student's information
        Dim str As String

        str = "SELECT CONCAT(stu_lname, ', ', stu_fname, ' ', stu_mname) AS full_name FROM student WHERE student_Id ='" & cbStu.Text & "'"
        Try
            Readqueary(str)
            With cmdread
                If .Read() Then
                    txtname.Text = .GetString("full_name")
                End If
            End With
        Catch ex As Exception
            ' Handle the exception
        End Try

        Dim s As String

        s = "SELECT academic_year FROM belong_to"
        Try
            Readqueary(s)
            With cmdread
                If .Read() Then
                    txtschoolyr.Text = .GetString("academic_year")
                End If
            End With
        Catch ex As Exception
            ' Handle the exception
        End Try

        Dim g As String = "SELECT grade_level, section_name FROM section"
        Try
            Readqueary(g)
            With cmdread
                If .Read() Then
                    Dim gradeLevel As String = .GetString("grade_level")
                    Dim sectionName As String = .GetString("section_name")
                    txtyear.Text = gradeLevel & " - " & sectionName
                End If
            End With
        Catch ex As Exception
            ' Handle the exception
        End Try

        'For Adviser
        Dim ad As String = "SELECT CONCAT(fty_lname, ', ', fty_fname, ' ', fty_mname) AS full_name FROM faculty"
        Try
            Readqueary(ad)
            With cmdread
                If .Read() Then
                    Dim fullName As String = .GetString("full_name")
                    txtadviser.Text = fullName
                End If
            End With
        Catch ex As Exception
            ' Handle the exception
        End Try

        'For DataGridView
        dgvSearch.Rows.Clear()
        Dim query As String = "SELECT s.subject_id, s.meeting_schedule, s.subject_name FROM subject s INNER JOIN takes t ON s.subject_id = t.subject_id"

        Try
            Readqueary(query)
            While cmdread.Read()
                dgvSearch.Rows.Add(cmdread("subject_id"), cmdread("meeting_schedule"), cmdread("subject_name"))
            End While
            cmdread.Close()
            cmdread.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub enrollment_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Code to populate the ComboBox with student IDs
        Dim str As String
        str = "SELECT student_id FROM student ORDER BY student_Id"
        Try
            Readqueary(str)
            With cmdread
                While .Read
                    cbStu.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
