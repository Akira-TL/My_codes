Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Button1.Text = "计算"
        Button2.Text = "结束"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x, y, z, i, a, b, c， cnt, cntend, num As Integer
        Dim rom(2, num) As Integer '要是数据结构学完了就好了
        a = 2 'a为鸡
        b = 4 'b为兔
        i = 1
        z = Val(InputBox("请输入腿数：", "input"))
        c = a * x + b * y
        num = 1
        Do While c <= z
            Do While c <= z
                If c = z Then
                    i = 0
                    If cnt >= num Then
                        num *= 2
                        ReDim Preserve rom(2, num)
                    End If
                    rom(0, cnt) = x
                    rom(1, cnt) = y
                    cnt += 1
                    'Exit Do
                End If
                y += 1
                c = a * x + b * y
            Loop
            If c = z Then
                i = 0
                'Exit Do
            End If
            x += 1
            y = 0
            c = a * x + b * y
        Loop
        If i = 0 Then
            Do Until cntend = cnt
                Label1.Text = Label1.Text & "鸡有" & rom(0, cntend) & "只，兔有" & rom(1, cntend) & "只" & vbCrLf
                cntend += 1
            Loop

        ElseIf i = 1 Then
            Label1.Text = "没有对应解"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
