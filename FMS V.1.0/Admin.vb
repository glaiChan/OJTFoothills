Public Class Admin
    Private Sub create_account_Click(sender As Object, e As EventArgs) Handles create_account.Click
        create_account_panel.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        create_account_panel.Visible = False
        Panel2.Visible = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Format(Now, "hh:mm tt")
        lbldate.Text = Format(Now, "MM/dd/yyyy")
    End Sub
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cbo_position.selectedIndex = 0
        cbo_status.selectedIndex = 0
    End Sub
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim fullname As String = txt_fname.Text
        Dim username As String = txt_uname.Text
        Dim password As String = txt_password.Text
        Dim confirm_pass As String = txt_confirm_password.Text
        Dim position As String = cbo_position.selectedValue
        Dim status As String = cbo_status.selectedValue

        If fullname <> "" And username <> "" And password <> "" And confirm_pass <> "" And position <> "" And status <> "" Then
            Add_Account(fullname, username, password, confirm_pass, position, status)
            txt_fname.Text = ""
            txt_uname.Text = ""
            txt_password.Text = ""
            txt_confirm_password.Text = ""

        ElseIf fullname = "" Or username = "" Or password = "" Or confirm_pass = "" Or position = "" Or status = "" Then
            MessageBox.Show("Please enter all the necessary information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (password <> confirm_pass) Then
            MessageBox.Show("Password not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_password.Text = ""
            txt_confirm_password.Text = ""
        End If
    End Sub
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        txt_fname.Text = ""
        txt_uname.Text = ""
        txt_password.Text = ""
        txt_confirm_password.Text = ""
    End Sub
End Class