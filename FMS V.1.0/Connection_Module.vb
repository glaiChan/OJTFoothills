Imports MySql.Data.MySqlClient

Module Connection_Module

    Public conn As MySqlConnection
    Dim user As String
    Dim password As String
    Dim dbname As String
    Dim server As String
    Dim strConnection As String


    Public da As New MySqlDataAdapter
    Public dt As DataTable
    Public sqlReader As MySqlDataReader
    Private read As IDataReader


    Public Sub Load_Connection()
        Try
            user = "messi"
            password = "1234"
            server = "192.168.1.22"
            dbname = "foothills"
            strConnection = "server=" & server & "; user id =" & user & ";password=" & password & ";database=" & dbname & ";"
            conn = New MySqlConnection(strConnection)
            conn.Open()
            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




End Module
