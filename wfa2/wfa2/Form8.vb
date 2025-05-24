Public Class Form8

    Private Sub btnSetColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetColor.Click
        If rbRedBg.Checked = True Then
            Me.BackColor = Color.PaleVioletRed
        ElseIf rbBlueBg.Checked = True Then
            Me.BackColor = Color.BlueViolet
        Else
            Me.BackColor = Color.LawnGreen
        End If
    End Sub
End Class