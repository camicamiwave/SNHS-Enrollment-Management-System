Public Class home


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnEnrollForm.Click
        Dim student_info As New studentInfo()
        student_info.Show()
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Dim modify As New studentmodify()
        modify.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim search As New student_search
        search.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Section.Click
        Dim Section As New section
        Section.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Subject.Click
        Dim Subject As New subject
        Subject.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Faculty.Click
        Dim Faculty As New faculty
        Faculty.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Display a confirmation dialog to ensure the user wants to logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close() ' Close the current form
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enrollment_reports As New enrollment_reports
        enrollment_reports.Show()
    End Sub
End Class