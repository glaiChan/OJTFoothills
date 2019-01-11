Imports MySql.Data.MySqlClient
Public Class Class_Particular

    Public dbConn As MySqlConnection
    Public sqlCommand As MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As DataTable
    Public sqlReader As MySqlDataReader
    Private read As IDataReader


    Public Sub displayRecords1(ByVal query As String, ByVal dg As DataGridView)
        'dbConn.Open()
        dt = New DataTable
        da = New MySqlDataAdapter(query, dbConn)

        da.Fill(dt)
        dg.DataSource = dt
        dbConn.Close()

    End Sub
End Class
