Public Class Form3

    Dim h, r, a, rad, area As Single
    Const Pi As Single = 3.142

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        r = h / 2
        rad = r * 0.001763889
        a = Pi * rad ^ 2
        area = Math.Round(a, 2)
        MsgBox("The Area of the circle is " & area)
    End Sub

    Private Sub btnHeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeight.Click
        h = InputBox("Enter the Value of height")
        osShape.Height = h
        osShape.Width = h
    End Sub
End Class