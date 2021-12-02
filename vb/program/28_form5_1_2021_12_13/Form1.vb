Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "运行"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(9), sum As Integer
        Randomize() '初始化随机数，保证随机数每次都不一样
        TextBox1.Text = "数组为："
        For i = 0 To 9
            a(i) = Rnd() * 100 '赋值数组以随机数
            TextBox1.Text = TextBox1.Text & " " & a(i)
        Next
        TextBox1.Text = TextBox1.Text & vbCrLf & "数组元素均值为："
        For i = 0 To 9
            sum += a(i) '计算和
            If i = 9 Then
                TextBox1.Text = TextBox1.Text & " " & sum / 10 '计算均值并输出
            End If
        Next
        TextBox1.Text = TextBox1.Text & vbCrLf & "大于均值的元素有："
        For i = 0 To 9
            If a(i) > sum / 10 Then
                TextBox1.Text = TextBox1.Text & " " & a(i) '比较大小，比均值大的数值输出
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
