Public Class User
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        BunifuFlatButton4.Enabled = False
        Me.Hide()
        Me.Dispose()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles txt_name.Click
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbltime.Text = Format(Now, "hh:mm:ss tt")
        lbldate.Text = Format(Now, "MM/dd/yyyy")
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click

    End Sub
End Class