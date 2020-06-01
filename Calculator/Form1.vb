Public Class Form1
    Dim Total As Single = 0
    Dim R As Single = 0
    Dim S As Single = 0
    Dim CH As Char


    Private Sub buttons(ByVal a As Single)
        TextBox1.Text = TextBox1.Text & a
        S = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buttons(Button1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buttons(Button2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        buttons(Button3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        buttons(Button4.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        buttons(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        buttons(Button6.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        buttons(Button7.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        buttons(Button8.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        buttons(Button9.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        buttons(Button10.Text)
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        R = TextBox1.Text
        TextBox1.Text = ""
        CH = "+"
    End Sub

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        Select Case CH
            Case "+"
                Total = R + S
                TextBox1.Text = Total
            Case "-"
                Total = R - S
                TextBox1.Text = Total
            Case "/"
                Total = R / S
                TextBox1.Text = Total
            Case "*"
                Total = R * S
                TextBox1.Text = Total
        End Select
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        R = TextBox1.Text
        TextBox1.Text = ""
        CH = "-"
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        R = TextBox1.Text
        TextBox1.Text = ""
        CH = "/"
    End Sub

    Private Sub product_Click(sender As Object, e As EventArgs) Handles product.Click
        R = TextBox1.Text
        TextBox1.Text = ""
        CH = "*"
    End Sub

    Private Sub ac_Click(sender As Object, e As EventArgs) Handles ac.Click
        TextBox1.Text = ""
        R = S = Total = 0
        CH = ""
    End Sub
End Class
