Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "x:"
        Label2.Text = "Cos(x):"
        Button1.Text = "计算"
        Button2.Text = "清除"
        Button3.Text = "结束"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, an, maxcal, x, sum As Double
        n = 1
        an = 1
        x = Val(TextBox1.Text)
        maxcal = 10 ^ (-7)
        Do Until maxcal > Abs(an)
            sum += an
            an = (-1) ^ n * x ^ (2 * n) / factorial(2 * n)
            n += 1
        Loop
        TextBox2.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Function Factorial(num As Double) As Integer
        Dim sum, n As Double
        sum = 1
        n = 1
        Do Until num < n
            sum *= n
            n += 1
        Loop
        Factorial = sum
        'n = 1
    End Function
    Private Function Abs(num As Double) As Integer
        If num < 0 Then
            num = -num
        End If
        Abs = num
    End Function
End Class
