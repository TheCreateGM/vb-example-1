Public Class Form4

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim username, password As String
        username = "John123"
        password = "qwertyuiop#@"

        If txtName.Text = username And txtPass.Text = password Then
            MsgBox("Sign in sucessful")
        ElseIf txtName.Text <> username Or txtPass.Text <> password Then
            MsgBox("Sign in failed")
        End If
    End Sub
End Class