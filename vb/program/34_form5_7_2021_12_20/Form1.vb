Public Class Form1
    Dim a(3, 4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "找最大数"
        Button2.Text = "退出"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize() '初始化随机数，保证随机数每次都不一样
        Dim maxnum, i, j, x, y As Integer
        For i = 0 To 3
            For j = 0 To 4
                a(i, j) = Rnd() * 90 + 10 '赋值数组以随机数
                TextBox1.Text = TextBox1.Text & vbTab & a(i, j)
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        maxnum = a(0, 0)
        For i = 0 To 3
            For j = 0 To 4
                If a(i, j) > maxnum Then
                    maxnum = a(i, j)
                    x = i
                    y = j
                End If
            Next
        Next
        TextBox1.Text = TextBox1.Text & vbCrLf & vbTab & $"数组中最大元素为{x}行{y}列的{maxnum}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
