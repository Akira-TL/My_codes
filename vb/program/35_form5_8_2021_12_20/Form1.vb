Public Class Form1
    Dim a(3, 4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "找鞍点"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim maxnum, x, y As Integer
        Dim ishave, istrue As Boolean
        ishave = False
        Randomize()
        For i = 0 To 3
            For j = 0 To 4
                a(i, j) = Rnd() * 90 + 10 '赋值数组以随机数
                TextBox1.Text = TextBox1.Text & vbTab & a(i, j)
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        For i = 0 To 3
            maxnum = a(i, 0)
            For j = 0 To 4
                If maxnum < a(i, j) Then
                    maxnum = a(i, j)
                    x = i
                    y = j
                End If
                If j = 4 Then
                    istrue = True
                    For k = 0 To 3
                        If a(k, y) > maxnum Then
                            istrue = False
                            'ishave = True
                            'TextBox1.Text = TextBox1.Text & vbCrLf & vbTab & $"a({x + 1},{y + 1})是鞍点" & vbCrLf
                        End If
                    Next
                    If istrue Then
                        ishave = True
                        TextBox1.Text = TextBox1.Text & vbCrLf & vbTab & $"a({x + 1},{y + 1})是鞍点" & vbCrLf
                    End If
                End If
            Next
        Next
        If Not ishave Then
            TextBox1.Text = TextBox1.Text & vbCrLf & vbTab & "鞍点不存在" & vbCrLf
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
