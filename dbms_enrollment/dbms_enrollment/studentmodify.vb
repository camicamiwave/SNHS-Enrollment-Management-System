Imports MySql.Data.MySqlClient

Public Class studentmodify

    Private Property MySqlCommand As MySqlCommand
    Private Property Command As MySqlCommand
    Private Property READER As MySqlDataReader

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        MySqlCommand = New MySqlCommand
        MySqlCommand.Connection = New MySqlConnection(
            "server=localhost;userid=root;password=;database=sfnhs_enrollment")

        Try
            MySqlCommand.Connection.Open()
            Dim Query As String
            Dim gender As String = ""
            If rbMale.Checked Then
                gender = "Male"
            ElseIf rbFemale.Checked Then
                gender = "Female"
            End If

            ' Update query for student table
            Query = "UPDATE student SET stu_fname = '" & txtstu_fname.Text & "', stu_lname = '" & txtstu_lname.Text & "', stu_mname = '" & txtstu_mname.Text & "', gender = '" & gender & "', date_of_birth = '" & bdate.Value.ToString("yyyy-MM-dd") & "', address = '" & txtaddress.Text & "', cp_number = '" & txtcp_num.Text & "', email_address = '" & txtemail_add.Text & "' WHERE student_id = '" & cbstudent_Id.Text & "'"
            Command = New MySqlCommand(Query, MySqlCommand.Connection)
            Command.ExecuteNonQuery()

            ' Update query for requirements table
            Query = "UPDATE requirements SET birth_certificate = " & IIf(chckbc.Checked, 1, 0) & ", form_137 = " & IIf(chckform137.Checked, 1, 0) & ", goodmoral = " & IIf(chckgmoral.Checked, 1, 0) & " WHERE student_id = '" & cbstudent_Id.Text & "'"
            Command = New MySqlCommand(Query, MySqlCommand.Connection)
            Command.ExecuteNonQuery()


            MsgBox("Record updated successfully.")
        Catch ex As Exception
            ' Display the error message in case of an exception
            MsgBox(ex.Message)
        Finally
            MySqlCommand.Connection.Close()
        End Try

    End Sub

    Private Sub cbstudent_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbstudent_Id.SelectedIndexChanged
        ' Code to populate the form with the selected student's information
        Dim str As String
        Dim gender As String = ""
        If rbMale.Checked Then
            gender = "Male"
        ElseIf rbFemale.Checked Then
            gender = "Female"
        Else
            gender = ""
        End If
        str = "Select student_id, stu_fname, stu_lname, stu_mname, gender, date_of_birth, address, cp_number, email_address from student where student_Id ='" & cbstudent_Id.Text & "'"
        Try
            Readqueary(str)
            With cmdread
                While .Read
                    txtstu_fname.Text = .GetValue(0)
                    txtstu_lname.Text = .GetValue(1)
                    txtstu_mname.Text = .GetValue(2)
                    gender = .GetValue(3)
                    bdate.Text = .GetValue(5)
                    txtaddress.Text = .GetValue(6)
                    txtcp_num.Text = .GetValue(7)
                    txtemail_add.Text = .GetValue(8)

                End While
            End With

            Dim s As String
            'In Able to populate the Requirements
            s = "Select birth_certificate, form_137, goodmoral from requirements"
            Readqueary(s)
            With cmdread
                While .Read
                    chckbc.Checked = .GetValue(0)
                    chckform137.Checked = .GetValue(1)
                    chckgmoral.Checked = .GetValue(2)

                End While
            End With

            'In Able to populate the derived belong_to
            ' Clear the existing items in the comboboxx

        Catch ex As Exception
        End Try
    End Sub

    Private Sub studentmodify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "Select student_id from student order by student_Id"
        Try
            Readqueary(str)
            With cmdread
                While .Read
                    cbstudent_Id.Items.Add(.GetValue(0))
                End While

            End With
        Catch ex As Exception
        End Try

    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        ' Here is to exit the modify system
        Me.Close()
    End Sub

End Class