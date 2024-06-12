Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim myPen As Pen
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.CreateGraphics()
        myPen = New System.Drawing.Pen(System.Drawing.Color.Black)
        formGraphics.DrawLine(myPen, 0, 0, 200, 200)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub
End Class
