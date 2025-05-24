Public Class Form2

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim Num1 As Integer = txtNum1.Text
        Dim Num2 As Integer = txtNum2.Text
        ' calculataion
        Dim Sum As Integer = Num1 + Num2
        ' display
        lblOutput.Text = Sum
    End Sub
End Class