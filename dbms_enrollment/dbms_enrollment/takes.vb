Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class takes
    Dim conn As New MySqlConnection("server='localhost';uid='root';pwd='';database='sfnhs_enrollment'")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Public Property SelectedStudentID As String


    Private Sub takes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT s.subject_id, s.meeting_schedule, s.subject_name FROM subject s INNER JOIN takes t ON s.subject_id = t.subject_id", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                dgvSearch.Rows.Add(dr.Item("subject_id"), dr.Item("meeting_schedule"), dr.Item("subject_name"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles stu_search.TextChanged
        dgvSearch.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT s.subject_id, s.meeting_schedule, s.subject_name FROM subject s INNER JOIN takes t ON s.subject_id = t.subject_id WHERE s.subject_id LIKE '%" & stu_search.Text & "%' OR s.meeting_schedule LIKE '%" & stu_search.Text & "%' OR s.subject_name LIKE '%" & stu_search.Text & "%'", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                dgvSearch.Rows.Add(dr.Item("subject_id"), dr.Item("meeting_schedule"), dr.Item("subject_name"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
