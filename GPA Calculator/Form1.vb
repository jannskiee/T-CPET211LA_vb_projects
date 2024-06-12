Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim color1 As Color = ColorTranslator.FromHtml("#08743c")
        Dim color2 As Color = ColorTranslator.FromHtml("#183c24")
        Dim color3 As Color = ColorTranslator.FromHtml("#d1d2d4")

        PictureBox1.BackColor = color1
        PictureBox2.BackColor = color2
        PictureBox3.BackColor = color3

    End Sub

End Class
