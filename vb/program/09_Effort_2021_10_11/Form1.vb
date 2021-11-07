Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox11.Text = $"学号为{TextBox1.Text}姓名为{TextBox6.Text}的考试成绩如下：{vbCrLf}英语：{TextBox2.Text}英语写作：{TextBox7.Text}{vbCrLf}高等数学：{TextBox3.Text}线性代数：{TextBox8.Text}{vbCrLf}体育：{TextBox4.Text}经济学：{TextBox9.Text}{vbCrLf}物理学：{TextBox5.Text}C语言：{TextBox10.Text}"
    End Sub
End Class
