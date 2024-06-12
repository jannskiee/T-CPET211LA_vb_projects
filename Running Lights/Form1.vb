Public Class Form1
    Private currentIndex As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OvalShape1.BackColor = Color.Yellow
        OvalShape2.BackColor = Color.Green
        OvalShape3.BackColor = Color.Blue
        OvalShape4.BackColor = Color.Red
        ShowAllOvalShapes()
    End Sub

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles OvalShape1.Click
    End Sub

    Private Sub OvalShape2_Click(sender As Object, e As EventArgs) Handles OvalShape2.Click
    End Sub

    Private Sub OvalShape3_Click(sender As Object, e As EventArgs) Handles OvalShape3.Click
    End Sub

    Private Sub OvalShape4_Click(sender As Object, e As EventArgs) Handles OvalShape4.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowOnlyOvalShape(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowOnlyOvalShape(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowOnlyOvalShape(1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowOnlyOvalShape(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MoveOvalShapeLeft()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MoveOvalShapeRight()
    End Sub

    Private Sub ShowAllOvalShapes()
        OvalShape1.Visible = True
        OvalShape2.Visible = True
        OvalShape3.Visible = True
        OvalShape4.Visible = True
    End Sub

    Private Sub ShowOnlyOvalShape(index As Integer)
        OvalShape1.Visible = (index = 0)
        OvalShape2.Visible = (index = 1)
        OvalShape3.Visible = (index = 2)
        OvalShape4.Visible = (index = 3)
        currentIndex = index
    End Sub

    Private Sub MoveOvalShapeLeft()
        currentIndex = (currentIndex - 1 + 4) Mod 4
        ShowOnlyOvalShape(currentIndex)
    End Sub

    Private Sub MoveOvalShapeRight()
        currentIndex = (currentIndex + 1) Mod 4
        ShowOnlyOvalShape(currentIndex)
    End Sub
End Class
