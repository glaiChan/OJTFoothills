Imports MySql.Data.MySqlClient

Module Product_Module
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public reader As MySqlDataReader
    Public strQuery = " "
    Public Sub displayProducts(ByVal query As String, ByVal dg As DataGridView)

        Load_Connection()
        conn.Open()
        dt = New DataTable
        da = New MySqlDataAdapter(query, conn)

        da.Fill(dt)
        dg.DataSource = dt
        conn.Close()

    End Sub

    Public Function recordCountProduct(ByVal query As String) As Integer
        'dbConn.Open()
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        da.Fill(dt)
        Return dt.Rows.Count + 1

        conn.Close()

    End Function

    Public Sub SQLManagerProduct(ByRef Query As String)
        Try
            conn.Open()
            cmd = New MySqlCommand(Query, conn)

            With cmd
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Module
