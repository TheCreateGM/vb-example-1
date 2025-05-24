Public Class Form3

    Private Sub btnShowPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPass.Click
        Dim ShowPass As String = txtShowPass.Text
        MsgBox("Your password is : " & ShowPass)
    End Sub
End Class