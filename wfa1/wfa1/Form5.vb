Public Class Form5

    ' main output
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Aa As String = "Tom "
        Dim Bb As String = "likes "
        Dim Cc As String = "to "
        Dim Dd As String = "eat "
        Dim Ee As String = "burger "
        lbl.Text = Aa & Bb & Cc & Dd & Ee
    End Sub

    ' global input
    Dim rnd As New Random()
    Dim R_Red As Integer = rnd.Next(0, 256)
    Dim G_Green As Integer = rnd.Next(0, 256)
    Dim B_Blue As Integer = rnd.Next(0, 256)

    Private Sub btnCommand1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommand1.Click
        Me.BackColor = Color.FromArgb(R_Red, G_Green, B_Blue)
    End Sub

    Private Sub btnCommand2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommand2.Click
        lbl.ForeColor = Color.FromArgb(R_Red, G_Green, B_Blue)
        lbl.Text = "Foreground Color Changed"
    End Sub
End Class