Public Class Login

    Public user As String
    Public password As String
    Public msg As String

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles brnCancel.Click

        Me.Close()
        Me.Dispose()


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        user = txtUname.Text
        password = txtPass.Text

        If txtUname.Text = "" And txtPass.Text = "" Then
            msg = "All fields are required."
            MsgBox(msg, vbOKOnly + vbCritical, "Error")
        ElseIf txtPass.Text = "" Then
            msg = "Password field is required."
            MsgBox(msg, vbOKOnly + vbCritical, "Error")
        ElseIf txtUname.Text = "" Then
            msg = "Username field is required."
            MsgBox(msg, vbOKOnly + vbCritical, "Error")

        Else

            validate_login(user, password)
            Me.Dispose()
        End If


    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged

    End Sub
End Class