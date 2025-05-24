Public Class Form7

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cbApple.Checked = True And cbOrange.Checked = False And cbPear.Checked = False Then
            MsgBox("Apple is selected")
        ElseIf cbApple.Checked = False And cbOrange.Checked = True And cbPear.Checked = False Then
            MsgBox("Orange is selected")
        ElseIf cbApple.Checked = False And cbOrange.Checked = False And cbPear.Checked = True Then
            MsgBox("Pear is selected")
        ElseIf cbApple.Checked = True And cbOrange.Checked = True And cbPear.Checked = False Then
            MsgBox("Apple and Orange is selected")
        ElseIf cbApple.Checked = False And cbOrange.Checked = True And cbPear.Checked = True Then
            MsgBox("Orange and Pear is selected")
        ElseIf cbApple.Checked = True And cbOrange.Checked = False And cbPear.Checked = True Then
            MsgBox("Apple and Pear is selected")
        ElseIf cbApple.Checked = True And cbOrange.Checked = True And cbPear.Checked = True Then
            MsgBox("All are selected")
        Else
            MsgBox("Please select the items...")
        End If
    End Sub
End Class