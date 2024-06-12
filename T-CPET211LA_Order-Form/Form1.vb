Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.FixedSingle
        Dim r As Pen
        r = New Pen(Drawing.Color.IndianRed, 5)
        Me.CreateGraphics.DrawLine(r, 20, 56, 130, 50)

    End Sub

End Class
