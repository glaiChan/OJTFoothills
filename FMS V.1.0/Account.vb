Imports MySql.Data.MySqlClient
Module Account
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public reader As MySqlDataReader
    Public strQuery = " "

    Public Sub Add_Account(ByVal fname As String, ByVal uname As String, ByVal pass As String, ByVal cpass As String, ByVal position As String)

        conn.Open()
        cmd = New MySqlCommand("INSERT INTO tbl_accounts (fname, uname, pass, cpass, position)
                                VALUES (@fname, @uname, @pass, @cpass, @position)", conn)

        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.Parameters.AddWithValue("@uname", uname)
        cmd.Parameters.AddWithValue("@pass", pass)
        cmd.Parameters.AddWithValue("@cpass", cpass)
        cmd.Parameters.AddWithValue("@position", position)
        cmd.ExecuteNonQuery()
        conn.Close()
        conn.Dispose()
        MessageBox.Show("Added Successfully")
    End Sub
End Module
