Imports MySql.Data.MySqlClient
Module Module1
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdread As MySqlDataReader
    Public db_server = "'localhost'"
    Public db_uid = "'root'"
    Public db_pwd = "''"
    Public academic_year As String
    Public filteredData As String
    Public grade_level As String
    'Public studentId As String
    Public db_name = "'sfnhs_enrollment'"
    Public strconn As String = "server =" & db_server & "; uid =" & db_uid & "; password =" & db_pwd & "; database = " & db_name & ""


    Public Sub Readqueary(ByVal sql As String)
        '  ppp = System.Text.CodePagesEncodingProvider.Instance;
        ' Encoding.RegisterProvider(ppp);
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()

            End With
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdread = .ExecuteReader()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module
