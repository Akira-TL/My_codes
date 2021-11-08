Public Class Form1
    Dim feet, num As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Button1.Text = "腿数"
        Button2.Text = "只数"
        Button3.Text = "计算"
        Button4.Text = "结束"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        feet = Val(InputBox("请输入腿数：", "input feet"))
        'Dim x, y, z, i, a, b, c， cnt, cntend, num As Integer
        'Dim rom(2, num) As Integer '要是数据结构学完了就好了
        'a = 2 'a为鸡
        'b = 4 'b为兔
        'i = 1
        'z = Val(InputBox("请输入腿数：", "input"))
        'c = a * x + b * y
        'num = 1
        'Do While c <= z
        '    Do While c <= z
        '        If c = z Then
        '            i = 0
        '            If cnt >= num Then
        '                num *= 2
        '                ReDim Preserve rom(2, num)
        '            End If
        '            rom(0, cnt) = x
        '            rom(1, cnt) = y
        '            cnt += 1
        '            'Exit Do
        '        End If
        '        y += 1
        '        c = a * x + b * y
        '    Loop
        '    If c = z Then
        '        i = 0
        '        'Exit Do
        '    End If
        '    x += 1
        '    y = 0
        '    c = a * x + b * y
        'Loop
        'If i = 0 Then
        '    Do Until cntend = cnt
        '        Label1.Text = Label1.Text & "鸡有" & rom(0, cntend) & "只，兔有" & rom(1, cntend) & "只" & vbCrLf
        '        cntend += 1
        '    Loop

        'ElseIf i = 1 Then
        '    Label1.Text = "没有对应解"
        'End If
        '----------------------------------------------------------------------
        '这前面我直接无视了只数问题，我好呆......
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num = Val(InputBox("请输入只数：", "input num"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x, y, i As Integer
        If feet Mod 2 <> 0 Or feet <= 0 Or num <= 0 Then
            i = 1
        Else
            y = (feet - 2 * num) / 2
            x = num - y
        End If
        '这是按照人类思考方式写的算法
        '----------------------------------------------------------------------------------------------------------------------
        'Dim total, x, y, a, b, i As Integer 'rom是数组，暂时没学，可以当他是个存储数字的东西就行了 其他的部分我会在下面挨个写作用
        'a = 2 'a为鸡
        'b = 4 'b为兔
        'i = 1
        'x = num
        'total = a * x + b * y '总个数，不难理解
        'Do While total <= feet '判断每次计算完是不是满足题目要求，满足了就跳出循环
        '    If total Mod 2.0! = 0 Or total <= 0 Or num <= 0 Then
        '        Exit Do
        '    End If
        '    total = a * x + b * y
        '    If total = feet Then
        '        i = 0 'i为判断是否满足题目要求并决定最后文本是否输出无解
        '    End If
        '    If y = num Or i = 0 Then
        '        Exit Do
        '    End If
        '    y += 1 '每次循环对xy可能的值都进行修改
        '    x -= 1
        'Loop
        '-----------------------------------------------------------------------------------------------------------------------
        If i = 0 Then
            Label1.Text = Label1.Text & "鸡有" & x & "只，兔有" & y & "只"
        Else
            Label1.Text = "没有对应解"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class
