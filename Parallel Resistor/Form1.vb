Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrEmpty(TextBox1.Text) Then
            Label13.Text = "0 K ohms"
        Else
            Label13.Text = TextBox1.Text & " K ohms"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If String.IsNullOrEmpty(TextBox2.Text) Then
            Label14.Text = "0 K ohms"
        Else
            Label14.Text = TextBox2.Text & " K ohms"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If String.IsNullOrEmpty(TextBox3.Text) Then
            Label15.Text = "0 K ohms"
        Else
            Label15.Text = TextBox3.Text & " K ohms"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r1, r2, r3, totalResistance As Double

        Double.TryParse(TextBox1.Text, r1)
        Double.TryParse(TextBox2.Text, r2)
        Double.TryParse(TextBox3.Text, r3)

        totalResistance = 1 / ((1 / r1) + (1 / r2) + (1 / r3))

        Label16.Text = totalResistance.ToString("0.00") & " K ohms"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label13.Text = "0 K ohms"
        Label14.Text = "0 K ohms"
        Label15.Text = "0 K ohms"
        Label16.Text = "0 K ohms"
    End Sub
End Class
