Public Class Form2

    Private Sub btnClick_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClick.MouseDown
        If e.Clicks = 2 Then
            btnClick.Text = "You Click Me Twice"
        ElseIf e.Clicks = 1 Then
            btnClick.Text = "You Click Me Once"
        End If
    End Sub
End Class