Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "a:"
        Label2.Text = "a的平方根"
        Button1.Text = "计算"
        Button2.Text = "清除"
        Button3.Text = "结束"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a0, a1, a, out As Double
        a = Val(TextBox1.Text)
        a1 = a
        a0 = 0
        If a > 0 Then '考虑到输入的不确定，考虑会有负数
            Do Until Abs(a1 - a0) < 10 ^ (-7) '三种可能性，中值平方大于a，小于a，等于，大于的话赋值中值给a1（较大的一个）其余同理，如果刚好是中值，直接退出do输出即可
                If ((a1 + a0) / 2) ^ 2 > a Then 'abs也是自己写的函数，可以看前几个代码的注释，原理一样
                    a1 = (a1 + a0) / 2
                ElseIf ((a1 + a0) / 2) ^ 2 < a Then
                    a0 = (a1 + a0) / 2
                ElseIf ((a1 + a0) / 2) ^ 2 = a Then
                    Exit Do
                End If
            Loop
        Else
            TextBox2.Text = "值无效" '其实可以尝试写虚数的，但是我没写，懒，基本原理同上，只是加一个i显示在文本中而已
            Exit Sub '因为值无效，我就直接退出sub，不进行下面的计算
        End If
        out = (a1 + a0) / 2
        TextBox2.Text = out
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Function Abs(num As Double)
        If num < 0 Then
            num = -num
        End If
        Abs = num
    End Function
End Class
