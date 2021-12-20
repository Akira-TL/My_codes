Public Class Form1
    Dim a(9, 4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "生成数组"
        Button2.Text = "求积分"
        Button3.Text = "统计"
        Button4.Text = "清除"
        Button5.Text = "退出"
        Label1.Text = "学生成绩"
        Label2.Text = "每门课平均曾经"
        Label3.Text = "每门课不及格人数"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 9
            For j = 0 To 4
                a(i, j) = Rnd() * 90 + 10 '赋值数组以随机数
                TextBox1.Text = TextBox1.Text & vbTab & a(i, j)
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer
        TextBox2.Text = TextBox2.Text & vbTab
        For j = 0 To 4
            sum = 0
            For i = 0 To 9
                sum += a(i, j)
            Next
            TextBox2.Text = TextBox2.Text & sum / 10 & vbTab
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cnt As Integer
        TextBox3.Text = TextBox3.Text & vbTab
        For j = 0 To 4
            cnt = 0
            For i = 0 To 9
                If a(i, j) < 60 Then
                    cnt += 1
                End If
            Next
            TextBox3.Text = TextBox3.Text & cnt & vbTab
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class
