Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class student_search
    Dim conn As New MySqlConnection("server='localhost';uid='root';pwd='';database='sfnhs_enrollment'")
    Dim i As Integer
    Dim dr As MySqlDataReader



    Public Sub DVG_load()
        dgvSearch.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT student_id, stu_lname, stu_fname, stu_mname, gender, date_of_birth, address, cp_number, email_address FROM `student`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim dob As DateTime
                DateTime.TryParseExact(dr.Item("date_of_birth"), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, dob)
                dgvSearch.Rows.Add(dr.Item("student_id"), dr.Item("stu_lname"), dr.Item("stu_fname"), dr.Item("stu_mname"), dr.Item("gender"), dob, dr.Item("address"), dr.Item("cp_number"), dr.Item("email_address"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        dgvSearch.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `student` WHERE student_Id like '%" & txt_search.Text & "%' OR student_Id like '%" & txt_search.Text & "%' OR stu_lname like '%" & txt_search.Text & "%' OR stu_fname like '%" & txt_search.Text & "%' OR stu_mname like '%" & txt_search.Text & "%' OR gender like '%" & txt_search.Text & "%' OR date_of_birth like '%" & txt_search.Text & "%' OR address like '%" & txt_search.Text & "%' OR cp_number like '%" & txt_search.Text & "%' OR email_address like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvSearch.Rows.Add(dr.Item("student_id"), dr.Item("stu_lname"), dr.Item("stu_fname"), dr.Item("stu_mname"), dr.Item("gender"), dr.Item("date_of_birth"), dr.Item("address"), dr.Item("cp_number"), dr.Item("email_address"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim selectedRow As DataGridViewRow
        If dgvSearch.SelectedRows.Count > 0 Then
            selectedRow = dgvSearch.SelectedRows(0)

            ' Get the ID of the selected record
            Dim student_Id As String = selectedRow.Cells("student_id").Value.ToString()

            ' Delete the record from the database
            Dim cmd As New MySqlCommand("DELETE FROM student WHERE student_id = @student_Id", conn)
            cmd.Parameters.AddWithValue("@student_Id", student_Id)

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


    Private Sub student_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the data in the DataGridView when the form loads
        DVG_load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class
