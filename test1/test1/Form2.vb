Public Class Form2

    ' input
    Dim num1, num2, total As Integer

    ' calculate logic +
    Private Sub AddCalcFormat()
        Integer.TryParse(txtNum1.Text, num1)
        Integer.TryParse(txtNum2.Text, num2)

        total = num1 + num2

        lblOutput.Text = total.ToString
    End Sub

    ' calculate logic -
    Private Sub SubCalcFormat()
        Integer.TryParse(txtNum1.Text, num1)
        Integer.TryParse(txtNum2.Text, num2)

        total = num1 - num2

        lblOutput.Text = total.ToString
    End Sub

    ' calculate logic *
    Private Sub MulCalcFormat()
        Integer.TryParse(txtNum1.Text, num1)
        Integer.TryParse(txtNum2.Text, num2)

        total = num1 * num2

        lblOutput.Text = total.ToString
    End Sub

    ' reset all
    Private Sub ResetAll()
        txtNum1.Text = ""
        txtNum2.Text = ""
        lblOutput.Text = ""
    End Sub

    ' state operation
    Private Sub StateOperation()
        cbState.Items.Add("+")
        cbState.Items.Add("-")
        cbState.Items.Add("*")
    End Sub

    ' form load
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateOperation()
    End Sub

    ' button calculate
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        ' selected
        If cbState.SelectedItem.ToString = "+" Then
            AddCalcFormat()
        ElseIf cbState.SelectedItem.ToString = "-" Then
            SubCalcFormat()
        ElseIf cbState.SelectedItem.ToString = "*" Then
            MulCalcFormat()
        End If
    End Sub

    ' button reset
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetAll()
    End Sub
End Class