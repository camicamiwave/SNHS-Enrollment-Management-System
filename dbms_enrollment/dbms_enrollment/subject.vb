Imports MySql.Data.MySqlClient

Public Class subject
    Dim conn As New MySqlConnection("server='localhost';uid='root';pwd='';database='sfnhs_enrollment'")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub seach_bar_TextChanged(sender As Object, e As EventArgs) Handles seach_bar.TextChanged
        dgvSearch.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `subject` WHERE subject_Id LIKE '%" & seach_bar.Text & "%' OR subject_name LIKE '%" & seach_bar.Text & "%' OR meeting_schedule LIKE '%" & seach_bar.Text & "%'", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                dgvSearch.Rows.Add(dr.Item("subject_id"), dr.Item("subject_name"), dr.Item("meeting_schedule"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtsched.Enabled = False
        cbftyId.Enabled = False
        txteval.Enabled = False
        txttimeshed.Enabled = False
        txtstarttech.Enabled = False

        ' Populate the datagridview
        seach_bar_TextChanged(sender, e)
        AddHandler dgvSearch.CellClick, AddressOf dgvSearch_CellClick
        Dim str As String
        str = "Select subject_id from subject order by subject_Id"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'student ID Load
        str = "Select student_Id from student order by student_Id"
        Try
            Readqueary(str)
            With cmdread
                While .Read
                    cb_studentId.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try

        'Faculty ID

        str = "Select faculty_Id from teach_by order by faculty_Id"
        Try
            Readqueary(str)
            With cmdread
                While .Read
                    cbftyId.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvSearch.Rows(e.RowIndex)
            Dim subjectId As String = selectedRow.Cells("subject_id").Value.ToString()
            Dim subjectName As String = selectedRow.Cells("subject_name").Value.ToString()
            Dim subjectschedule As String = selectedRow.Cells("meeting_schedule").Value.ToString()

            txtsubId.Text = subjectId
            txtsubname.Text = subjectName
            txtsched.Text = subjectschedule

        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim selectedRow As DataGridViewRow
        If dgvSearch.SelectedRows.Count > 0 Then
            selectedRow = dgvSearch.SelectedRows(0)

            ' Get the ID of the selected record
            Dim subject_Id As String = selectedRow.Cells("subject_id").Value.ToString()

            ' Delete the record from the database
            Dim cmd As New MySqlCommand("DELETE FROM subject WHERE subject_id = @subject_Id", conn)
            cmd.Parameters.AddWithValue("@subject_Id", subject_Id)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                dgvSearch.Rows.Remove(selectedRow)
                MessageBox.Show("Record deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        Dim str As String
        str = "UPDATE subject set subject_name = '" & txtsubname.Text & "', meeting_schedule = '" & txtsched.Text & "' where subject_Id = '" & txtsubId.Text & "'"
        Try
            Readqueary(str)
            MsgBox("Update Record")
            seach_bar_TextChanged(sender, e) ' Reload the DataGridView
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Retrieve the latest section_Id value from the database
        Dim str As String = "SELECT MAX(subject_Id) FROM subject"
        Dim cmd As New MySqlCommand(str, conn)
        Dim latestId As Integer = 0

        Try
            conn.Open()
            latestId = CInt(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        ' Increment the latest section_Id value by 1 and set it as the value of the txtsecId textbox
        txtsubId.Text = (latestId + 1).ToString()

        ' Add the new record to the database and DataGridView

        str = "INSERT INTO subject (subject_Id, subject_name, meeting_schedule) VALUES ('" & txtsubId.Text & "', '" & txtsubname.Text & "', '" & txtsched.Text & "')"

        Try
            Readqueary(str)
            MsgBox("Record added successfully.")

            ' Refresh the DataGridView to show the new record
            seach_bar_TextChanged(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            ' Update query for student table
            str = "UPDATE teach_by SET  subject_Id = '" & txtsubId.Text & "', evaluation_rating = '" & txteval.Text & "', time_schedule = '" & txttimeshed.Text & "', start_teaching = '" & txtstarttech.Text & "' WHERE faculty_id = '" & cbftyId.Text & "'"

            MsgBox("Record updated successfully.")
        Catch ex As Exception
            ' Display the error message in case of an exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_studentId.SelectedIndexChanged
        Dim str As String
        str = "Select student_Id From student where student_Id"
        Try
            Readqueary(str)
            With cmdread
                While .Read
                    cb_studentId.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbftyId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbftyId.SelectedIndexChanged
        'populate the teach_by
        Dim str As String
        Str = "SELECT evaluation_rating, time_schedule, start_teaching FROM teach_by where faculty_Id = '" & cbftyId.Text & "'"

        Try
            Readqueary(Str)

            With cmdread
                While .Read

                    txteval.Text = .GetValue(0)
                    txttimeshed.Text = .GetValue(1)
                    txtstarttech.Text = .GetValue(2)
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub
Private Sub txtsubname_TextChanged(sender As Object, e As EventArgs) Handles txtsubname.TextChanged
    txtsched.Enabled = True
    Dim input As String = txtsubname.Text.Trim()

    For Each c As Char In input
        If Not Char.IsLetter(c) Then
            MessageBox.Show("Please only input alphabetic characters.", "Invalid Input Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtsubname.Text = String.Empty
            Exit Sub
        End If
    Next
End Sub

Private Sub txtsched_TextChanged(sender As Object, e As EventArgs) Handles txtsched.TextChanged
    cbftyId.Enabled = True
End Sub

Private Sub txteval_TextChanged(sender As Object, e As EventArgs) Handles txteval.TextChanged
    txttimeshed.Enabled = True
End Sub

Private Sub txttimeshed_TextChanged(sender As Object, e As EventArgs) Handles txttimeshed.TextChanged
    txtstarttech.Enabled = True
    End Sub
End Class