Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SqlClient

Public Class section
    Dim conn As New MySqlConnection("server='localhost';uid='root';pwd='';database='sfnhs_enrollment'")

    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim connectionString As String




    Private Sub section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the datagridview
        seach_bar_TextChanged(sender, e)
        AddHandler dgvSearch.CellClick, AddressOf dgvSearch_CellClick
        Dim str As String
        str = "Select section_id from section order by section_Id"
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

        Dim s As String

        s = "Select academic_year from belong_to order by section_Id"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cb_acad.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception
        End Try

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

        s = "Select faculty_Id from faculty order by faculty_Id"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cbftyId.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception
        End Try

        'Assigned Subject

        s = "Select assigned_subject from assigned_to order by assigned_subject"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cbassignedsub.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception
        End Try
    End Sub


    Private Sub seach_bar_TextChanged(sender As Object, e As EventArgs) Handles seach_bar.TextChanged
        dgvSearch.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `section` WHERE section_Id like '%" & seach_bar.Text & "%' OR section_name like '%" & seach_bar.Text & "%' OR grade_level like '%" & seach_bar.Text & "%' OR student_capacity like '%" & seach_bar.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvSearch.Rows.Add(dr.Item("section_id"), dr.Item("section_name"), dr.Item("grade_level"), dr.Item("student_capacity"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvSearch.Rows(e.RowIndex)
            Dim sectionId As String = selectedRow.Cells("section_id").Value.ToString()
            Dim sectionName As String = selectedRow.Cells("section_name").Value.ToString()
            Dim gradeLevel As String = selectedRow.Cells("grade_level").Value.ToString()
            Dim studentCapacity As String = selectedRow.Cells("student_capacity").Value.ToString()

            txtsecId.Text = sectionId
            txtsecname.Text = sectionName
            txtgl.Text = gradeLevel
            txtstucap.Text = studentCapacity
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seach_bar_TextChanged(sender, e)
    End Sub


    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim selectedRow As DataGridViewRow
        If dgvSearch.SelectedRows.Count > 0 Then
            selectedRow = dgvSearch.SelectedRows(0)

            ' Get the ID of the selected record
            Dim section_Id As String = selectedRow.Cells("section_id").Value.ToString()

            ' Delete the record from the database
            Dim sectionCmd As New MySqlCommand("DELETE FROM section WHERE section_id = @section_Id", conn)
            sectionCmd.Parameters.AddWithValue("@section_Id", section_Id)

            ' Delete corresponding records from belong_to table
            Dim belongToCmd As New MySqlCommand("DELETE FROM belong_to WHERE section_Id = @section_Id", conn)
            belongToCmd.Parameters.AddWithValue("@section_Id", section_Id)

            Try
                conn.Open()
                sectionCmd.ExecuteNonQuery()
                belongToCmd.ExecuteNonQuery()
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
        str = " UPDATE section set section_name = '" & txtsecname.Text & "', grade_level = '" & txtgl.Text & "', student_capacity = '" & txtstucap.Text & "' where section_Id = '" & txtsecId.Text & "'"
        Try
            Readqueary(str)
            MsgBox("Update Record")
            seach_bar_TextChanged(sender, e) ' Reload the DataGridView
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Retrieve the latest section_Id value from the database
        Dim str As String = "SELECT MAX(section_Id) FROM section"
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
        txtsecId.Text = (latestId + 1).ToString()

        ' Add the new record to the database and DataGridView

        str = "INSERT INTO section (section_Id, section_name, grade_level, student_capacity) VALUES ('" & txtsecId.Text & "', '" & txtsecname.Text & "', '" & txtgl.Text & "', '" & txtstucap.Text & "')"

        Try
            Readqueary(str)
            MsgBox("Record added successfully.")

            ' Refresh the DataGridView to show the new record
            seach_bar_TextChanged(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'For belong_to

        Dim sql As String = "INSERT INTO belong_to (section_Id, student_Id, academic_year) VALUES ('" & txtsecId.Text & "', '" & cb_studentId.Text & "', '" & cb_acad.Text & "')"

        Try

            cmd = New MySqlCommand(sql, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record added successfully.")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'For assigned_to
        sql = "INSERT INTO assigned_to (section_Id, faculty_Id, assigned_subject) VALUES ('" & txtsecId.Text & "', '" & cbftyId.Text & "', '" & cbassignedsub.Text & "')"

        Try

            cmd = New MySqlCommand(sql, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record added successfully.")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cb_acad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_acad.SelectedIndexChanged
        Dim s As String
        s = "Select academic_year from belong_to WHERE academic_year = '" & cb_acad.Text & "'"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cb_acad = .GetValue(0)
                End While

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_studentId.SelectedIndexChanged
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

    Private Sub cbftyname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbftyId.SelectedIndexChanged
        Dim s As String
        s = "Select faculty_Id from faculty WHERE faculty_Id = '" & cbftyId.Text & "'"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cbftyId = .GetValue(0)
                End While

            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbassignedsub_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbassignedsub.SelectedIndexChanged
        Dim s As String
        s = "Select assigned_subject from assigned_to WHERE assigned_subject = '" & cbassignedsub.Text & "'"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cbassignedsub = .GetValue(0)
                End While

            End With
        Catch ex As Exception
        End Try
    End Sub


    Private Sub txtsecname_TextChanged(sender As Object, e As EventArgs) Handles txtsecname.TextChanged
        txtgl.Enabled = True
        Dim input As String = txtsecname.Text.Trim()

        For Each c As Char In input
            If Not Char.IsLetter(c) Then
                MessageBox.Show("Please only input alphabetic characters.", "Invalid Input Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtsecname.Text = String.Empty
                Exit Sub
            End If
        Next
    End Sub

    Private Sub txtstucap_TextChanged(sender As Object, e As EventArgs) Handles txtstucap.TextChanged
        cbftyId.Enabled = True
        Dim input As String = txtstucap.Text.Trim()

        If Not Integer.TryParse(input, Nothing) AndAlso Not String.IsNullOrEmpty(input) Then
            MessageBox.Show("Please only input number characters.", "Invalid Input Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtstucap.Text = String.Empty
        End If
    End Sub

    Private Sub txtgl_TextChanged(sender As Object, e As EventArgs) Handles txtgl.TextChanged
        txtstucap.Enabled = True
    End Sub
End Class
