Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Button1.Text = "第一题"
        Button2.Text = "第二题"
        Button3.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, s, n As Double
        n = 1
        s = 1
        sum = 10000
        Do Until sum < s '这题没啥写的，累加循环罢了
            s *= n
            n += 1
        Loop
        n -= 1
        Label1.Text = n
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum, s, n As Double
        n = 1
        s = 0
        sum = 0.0001
        Do Until sum > factorial(n) '这部分引用了我自己的函数，自己写函数就相当于左边这部分“factorial(n)”和函数内部是一样的（见第38行代码，那个是自己写的函数），只是吧长串代码拿到外面让界面变好看而已
            s += factorial(n) '没啥说的，累加（n += x 相当于n = n + x的简写，其余的同理）
            n += 1
        Loop
        'n -= 2
        Label1.Text = s
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Function factorial(num As Double)
        Dim sum, n As Double
        sum = 1
        n = 1
        Do Until num < n
            sum *= n
            n += 1
        Loop
        factorial = 1 / sum
        n = 1
    End Function
End Class
