Public Class Form1
    Dim i, cnt, a(), sum As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "找完数"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "1000以内的完数：" & vbCrLf
        For i = 2 To 1000
            ReDim a(-1)
            cnt = 0
            For j = 1 To i - 2
                sum = 0
                If (i Mod j) = 0 Then
                    ReDim Preserve a(cnt)
                    a(cnt) = j
                    cnt += 1
                End If '判断能不能整除
            Next '从1开始试能不能
            If UBound(a) >= 1 Then
                For k = 0 To cnt - 1
                    sum += a(k)
                Next '求和
            End If '由于a初始化为空集，强行a（0）会出错
            If i = sum Then
                TextBox1.Text = TextBox1.Text & $"{sum}={a(0)}"
                For k = 1 To cnt - 1
                    TextBox1.Text = TextBox1.Text & "+" & a(k)
                Next
                TextBox1.Text = TextBox1.Text & vbCrLf
            End If '满足条件输出
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
