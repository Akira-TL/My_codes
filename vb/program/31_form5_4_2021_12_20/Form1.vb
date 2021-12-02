Public Class Form1
    Dim n, a(,) As Integer, output As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "生成数列"
        Button2.Text = "合并"
        Button3.Text = "退出"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(InputBox("请输入数组大小", "定义数组大小"))
        ReDim a(2, n - 1) '定义数组大小
        Randomize() '初始化随机数，保证随机数每次都不一样
        TextBox1.Text = "数列为：" & vbCrLf
        For j = 0 To 1
            For i = 0 To n - 1
                a(j, i) = Rnd() * 100 '赋值数组以随机数
                TextBox1.Text = TextBox1.Text & vbTab & a(j, i)
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        TextBox1.Text = TextBox1.Text & vbCrLf
        output = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "数列合并后：" & vbCrLf
        If Not output Then
            For i = 0 To n - 1
                a(2, i) = a(0, i) + a(1, i)
                TextBox1.Text = TextBox1.Text & vbTab & a(2, i)
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
