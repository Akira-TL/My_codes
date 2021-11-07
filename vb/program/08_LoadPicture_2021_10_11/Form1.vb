Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        If TextBox1.Text = "" Then
            Label2.Text = "请输入图片地址！"
        Else
            'IsError(PictureBox1.Image = Image.FromFile(TextBox1.Text))
            'If IsError(PictureBox1.Image = Image.FromFile(TextBox1.Text)) = False Then
            'PictureBox1.Image = Image.FromFile(TextBox1.Text)
            'Else
            'Label2.Text = "路径错误！"
            'End If
            PictureBox1.Image = Image.FromFile(TextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
