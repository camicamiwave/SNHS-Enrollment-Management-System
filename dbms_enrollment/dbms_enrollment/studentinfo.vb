Public Class studentInfo
    'Student Insert Query
    'Submit Button Click Event
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            ' Insert query for student table
            Dim gender As String = ""
            If rbMale.Checked Then
                gender = "Male"
            ElseIf rbFemale.Checked Then
                gender = "Female"
            End If

            Dim insertStuQuery As String = "INSERT INTO student (student_id, stu_fname, stu_lname, stu_mname, gender, date_of_birth, address, cp_number, email_address) VALUES ('" & txtstuId.Text & "', '" & txtstu_fname.Text & "', '" & txtstu_lname.Text & "', '" & txtstu_mname.Text & "', '" & gender & "', '" & bdate.Value.ToString("yyyy-MM-dd") & "', '" & txtaddress.Text & "', '" & txtcp_num.Text & "', '" & txtemail_add.Text & "')"

            Dim insertReqQuery As String = "INSERT INTO requirements (student_id, birth_certificate, form_137, goodmoral) VALUES ('" & txtstuId.Text & "', " & IIf(chckbc.Checked, 1, 0) & ", " & IIf(chckform137.Checked, 1, 0) & ", " & IIf(chckgmoral.Checked, 1, 0) & ")"

            ' Call the Readqueary function passing all three queries as arguments to execute them together
            Readqueary(insertStuQuery & ";" & insertReqQuery)

            MsgBox("Add New Record")
        Catch ex As Exception
            ' Display the error message in case of an exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim takes As New takes()
        takes.Show()
    End Sub

    Private Sub txtstu_lname_TextChanged(sender As Object, e As EventArgs) Handles txtstu_lname.TextChanged
        txtstu_fname.Enabled = True
        Dim input As String = txtstu_lname.Text.Trim()

        For Each c As Char In input
            If Not Char.IsLetter(c) Then
                MessageBox.Show("Please only input alphabetic characters.", "Invalid Input Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtstu_lname.Text = String.Empty
                Exit Sub
            End If
        Next
    End Sub

    Private Sub txtstu_fname_TextChanged(sender As Object, e As EventArgs) Handles txtstu_fname.TextChanged
        txtstu_mname.Enabled = True
        Dim input As String = txtstu_fname.Text.Trim()

        For Each c As Char In input
            If Not Char.IsLetter(c) Then
                MessageBox.Show("Please only input alphabetic characters.", "Invalid Input Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtstu_fname.Text = String.Empty
                Exit Sub
            End If
        Next

    End Sub

    Private Sub txtstu_mname_TextChanged(sender As Object, e As EventArgs) Handles txtstu_mname.TextChanged
        txtaddress.Enabled = True

    End Sub

    Private Sub txtcp_num_TextChanged(sender As Object, e As EventArgs) Handles txtcp_num.TextChanged
        txtemail_add.Enabled = True
        Dim input As String = txtcp_num.Text.Trim()

        If Not Integer.TryParse(input, Nothing) AndAlso Not String.IsNullOrEmpty(input) Then
            MessageBox.Show("Please only input number characters.", "Invalid Input Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcp_num.Text = String.Empty
        End If
    End Sub


    Private Sub studentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtstu_fname.Enabled = False
        txtstu_mname.Enabled = False
        txtaddress.Enabled = False
        bdate.Enabled = False
        txtcp_num.Enabled = False
        txtemail_add.Enabled = False
    End Sub

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged
        bdate.Enabled = True
    End Sub

    Private Sub bdate_ValueChanged(sender As Object, e As EventArgs) Handles bdate.ValueChanged
        txtcp_num.Enabled = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class