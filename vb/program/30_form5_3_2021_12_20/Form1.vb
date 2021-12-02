Public Class Form1
    Dim n, a() As Integer, output As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "生成数列"
        Button2.Text = "对折"
        Button3.Text = "退出"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(InputBox("请输入数组大小", "定义数组大小"))
        ReDim a(n - 1) '定义数组大小
        Randomize() '初始化随机数，保证随机数每次都不一样
        TextBox1.Text = "数列为：" & vbCrLf
        For i = 0 To n - 1
            a(i) = Rnd() * 100 '赋值数组以随机数
            TextBox1.Text = TextBox1.Text & " " & a(i)
        Next
        output = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not output Then
            For i = 0 To (n - 1) / 2
                Swap(a(i), a(n - 1 - i))
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf & "数列对折后为" & vbCrLf
            For i = 0 To n - 1
                TextBox1.Text = TextBox1.Text & " " & a(i)
            Next
        Else
            MsgBox("已对折")
        End If
        output = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Function Swap(ByRef a1, ByRef a2)
        a1 = a1 + a2
        a2 = a1 - a2
        a1 = a1 - a2
    End Function
End Class
