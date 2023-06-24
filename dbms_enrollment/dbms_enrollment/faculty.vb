Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class faculty
    Dim conn As New MySqlConnection("server='localhost';uid='root';pwd='';database='sfnhs_enrollment'")
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate the datagridview
        search_bar_TextChanged(sender, e)
        AddHandler dgvSearch.CellClick, AddressOf dgvSearch_CellClick
        Dim str As String
        str = "Select faculty_id from faculty order by faculty_Id"
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

        ' Populate the combobox

        Dim s As String

        s = "Select requirements_Id from requirements order by requirements_Id"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cbReq.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub search_bar_TextChanged(sender As Object, e As EventArgs) Handles search_bar.TextChanged
        dgvSearch.Rows.Clear()
        Try
            conn.Open() ' Open the connection here
            Dim cmd As New MySqlCommand("SELECT * FROM `faculty` WHERE faculty_Id like '%" & search_bar.Text & "%' OR fty_lname like '%" & search_bar.Text & "%' OR fty_fname like '%" & search_bar.Text & "%' OR fty_mname like '%" & search_bar.Text & "%' OR gender like '%" & search_bar.Text & "%' OR date_of_birth like '%" & search_bar.Text & "%' OR address like '%" & search_bar.Text & "%' OR cp_number like '%" & search_bar.Text & "%' OR email_address like '%" & search_bar.Text & "%' OR position like '%" & search_bar.Text & "%'", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                dgvSearch.Rows.Add(dr.Item("faculty_id"), dr.Item("fty_lname"), dr.Item("fty_fname"), dr.Item("fty_mname"), dr.Item("gender"), dr.Item("date_of_birth"), dr.Item("address"), dr.Item("cp_number"), dr.Item("email_address"), dr.Item("position"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close() ' Close the connection here
        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        If e.RowIndex >= 0 Then

        End If
        Dim selectedRow As DataGridViewRow = dgvSearch.Rows(e.RowIndex)
        Dim facultyId As String = selectedRow.Cells("faculty_id").Value.ToString()
        Dim facultyFname As String = selectedRow.Cells("fty_fname").Value.ToString()
        Dim facultyLname As String = selectedRow.Cells("fty_lname").Value.ToString()
        Dim facultyMname As String = selectedRow.Cells("fty_mname").Value.ToString()
        Dim facultyGender As String = selectedRow.Cells("gender").Value.ToString()
        Dim facultyBdate As String = selectedRow.Cells("faculty_bdate").Value.ToString()
        Dim facultyAddress As String = selectedRow.Cells("address").Value.ToString()
        Dim facultyEmailAdd As String = selectedRow.Cells("email").Value.ToString()
        Dim facultyCpnum As String = selectedRow.Cells("cpnum").Value.ToString()
        Dim facultyPosition As String = selectedRow.Cells("position").Value.ToString()

        txtftyId.Text = facultyId
        txtftylname.Text = facultyFname
        txtftyfname.Text = facultyLname
        txtftymname.Text = facultyMname

        If facultyGender = "Male" Then
            rbMale.Checked = True
        Else
            rbFemale.Checked = True
        End If

        Dim bdateValue As Date
        If Date.TryParseExact(facultyBdate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, bdateValue) Then
            bdate.Value = bdateValue
        End If

        txtaddress.Text = facultyAddress
        txtemail.Text = facultyEmailAdd
        txtcp.Text = facultyCpnum
        txtpos.Text = facultyPosition
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        search_bar_TextChanged(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRow As DataGridViewRow
        If dgvSearch.SelectedRows.Count > 0 Then
            selectedRow = dgvSearch.SelectedRows(0)

            ' Get the ID of the selected record
            Dim faculty_Id As String = selectedRow.Cells("faculty_id").Value.ToString()

            ' Delete the record from the database
            Dim cmd As New MySqlCommand("DELETE FROM faculty WHERE faculty_id = @faculty_Id", conn)
            cmd.Parameters.AddWithValue("@faculty_Id", faculty_Id)

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

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim str As String
        Dim gender As String = If(rbMale.Checked, "Male", "Female")
        str = "UPDATE faculty SET fty_lname = '" & txtftylname.Text & "', fty_fname = '" & txtftyfname.Text & "', fty_mname = '" & txtftymname.Text & "', gender = '" & gender & "', date_of_birth = '" & bdate.Value.ToString("yyyy-MM-dd") & "', address = '" & txtaddress.Text & "', cp_number = '" & txtcp.Text & "', email_address = '" & txtemail.Text & "', position = '" & txtpos.Text & "' WHERE faculty_id = '" & txtftyId.Text & "'"
        Try
            Readqueary(str)
            MsgBox("Record updated.")
            search_bar_TextChanged(sender, e) ' Reload the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Retrieve the latest faculty_Id value from the database
        Dim str As String = "SELECT MAX(faculty_Id) FROM faculty"
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

        ' Increment the latest section_Id value by 1 and set it as the value of the txtftyId textbox
        txtftyId.Text = (latestId + 1).ToString()

        ' Add the new record to the database and DataGridView
        ' Insert query for student table
        Dim gender As String = ""
        If rbMale.Checked Then
            gender = "Male"
        ElseIf rbFemale.Checked Then
            gender = "Female"
        End If

        str = "INSERT INTO faculty (faculty_Id, fty_lname, fty_fname, fty_mname, gender, date_of_birth, address, cp_number, email_address, position) VALUES ('" & txtftyId.Text & "', '" & txtftylname.Text & "', '" & txtftyfname.Text & "', '" & txtftymname.Text & "', '" & gender & "', '" & bdate.Value.ToString("yyyy-MM-dd") & "', '" & txtaddress.Text & "', '" & txtcp.Text & "', '" & txtemail.Text & "', '" & txtpos.Text & "')"

        Try
            Readqueary(str)
            MsgBox("Record added successfully.")

            ' Refresh the DataGridView to show the new record
            search_bar_TextChanged(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        str = "INSERT INTO designated_to (requirements_Id, faculty_Id, date_status, no_requirements) VALUES ('" & cbReq.Text & "', '" & txtftyId.Text & "', '" & datestat.Value.ToString("yyyy-MM-dd") & "', '" & txtnumreq.Text & "')"
        Try
            Readqueary(str)
            MsgBox("Record added successfully.")

            ' Refresh the DataGridView to show the new record
            search_bar_TextChanged(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReq.SelectedIndexChanged

        Dim s As String

        s = "Select requirements_Id from requirements where requirements_Id = '" & cbReq.Text & "'"
        Try
            Readqueary(s)
            With cmdread
                While .Read
                    cbReq = .GetValue(0)
                End While

            End With
        Catch ex As Exception

        End Try
    End Sub
End Class