
Imports MySql.Data.MySqlClient
Module Login_Module
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public reader As MySqlDataReader
    Public strQuery = " "

    Public Sub validate_login(ByVal username As String, ByVal password As String)
        Load_Connection()
        conn.Open()
        strQuery = " SELECT * FROM tbl_accounts where uname=@username and pass=@password and status='Active'"
        cmd = New MySqlCommand(strQuery, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        da = New MySqlDataAdapter
        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item(5) = "Admin" Then
                User.txt_name.Text = dt.Rows(0).Item(1).ToString
                Admin.Show()
            ElseIf dt.Rows(0).Item(5) = "User" Then
                User.txt_name.Text = dt.Rows(0).Item(1).ToString
                User.Show()
            End If

        Else
            MessageBox.Show("Wala")
        End If
        conn.Close()
        conn.Dispose()
    End Sub
End Module
