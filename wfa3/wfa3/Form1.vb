Public Class Form1

    Dim n As Integer = 0 ' Class-level variable to keep track of the count

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        n = 0
        lblDisplay.Text = "0"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        n += 1
        lblDisplay.Text = n.ToString()
    End Sub

End Class
