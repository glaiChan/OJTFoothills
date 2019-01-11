Imports MySql.Data.MySqlClient
Module Accounts_Module
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public reader As MySqlDataReader
    Public strQuery = " "

    Public Sub Add_Account(ByVal fname As String, ByVal uname As String, ByVal pass As String, ByVal cpass As String, ByVal position As String, ByVal status As String)

        Load_Connection()
        conn.Open()
        cmd = New MySqlCommand("INSERT INTO tbl_accounts (fname, uname, pass, cpass, position, status)
                                VALUES (@fname, @uname, @pass, @cpass, @position, @status)", conn)

        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.Parameters.AddWithValue("@uname", uname)
        cmd.Parameters.AddWithValue("@pass", pass)
        cmd.Parameters.AddWithValue("@cpass", cpass)
        cmd.Parameters.AddWithValue("@position", position)
        cmd.Parameters.AddWithValue("@status", status)
        cmd.ExecuteNonQuery()
        conn.Close()
        conn.Dispose()
        MessageBox.Show("Added Successfully")
    End Sub
End Module
