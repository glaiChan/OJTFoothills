Public Class Form2

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Timer1.Start()
        If Not SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SplitContainer1.Panel1Collapsed = False
        Timer1.Stop()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Timer2.Start()
        If Not SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SplitContainer1.Panel1Collapsed = False
        Timer1.Stop()
    End Sub
End Class