Public Class Form1
    Dim a(3, 4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "生成数列"
        Button2.Text = "求列合"
        Button3.Text = "求行合"
        Button4.Text = "求总和"
        Button5.Text = "清除"
        Button6.Text = "退出"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize() '初始化随机数，保证随机数每次都不一样
        For i = 0 To 3
            For j = 0 To 4
                a(i, j) = Rnd() * 100 '赋值数组以随机数
                TextBox1.Text = TextBox1.Text & vbTab & a(i, j)
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer
        TextBox3.Text = TextBox3.Text & vbTab
        For j = 0 To 4
            sum = 0
            For i = 0 To 3
                sum += a(i, j)
            Next
            TextBox3.Text = TextBox3.Text & sum & vbTab
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sum As Integer
        For i = 0 To 3
            sum = 0
            For j = 0 To 4
                sum += a(i, j)
            Next
            TextBox2.Text = TextBox2.Text & sum & vbTab
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sum As Integer
        For i = 0 To 3
            For j = 0 To 4
                sum += a(i, j)
            Next
        Next
        TextBox4.Text = TextBox4.Text & sum & vbTab
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
End Class
