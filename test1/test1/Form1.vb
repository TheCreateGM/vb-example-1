Public Class Form1

    ' input
    Dim Username As String = "AxoGM"
    Dim Password As String = "axogm1234"

    ' button submit
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtUser.Text = Username And txtPass.Text = Password Then
            Form2.Show()
        ElseIf txtUser.Text = "" And txtPass.Text = "" Then
            MsgBox("Please Enter the input...", MsgBoxStyle.Critical, "Skill issues...")
        Else
            MsgBox("Error...", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class
