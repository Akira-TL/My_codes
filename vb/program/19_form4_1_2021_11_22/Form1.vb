Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "计算"
        Button2.Text = "清除"
        Button3.Text = "结束"
        Label1.Text = "请输入三角形的边长："
        Label2.Text = "a:"
        Label3.Text = "b:"
        Label4.Text = "c:"
        Label5.Text = "计算结果为："
        Label6.Text = ""
        TextBox1.TabIndex = 1
    End Sub
End Class
