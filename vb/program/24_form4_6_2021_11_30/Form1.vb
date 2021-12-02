Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "请输入一个整数"
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Button1.Text = "判断"
        Button2.Text = "清除"
        Button3.Text = "结束"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (Label2.Text = "" And Label3.Text = "" And Label4.Text = "") Then '清除可能没被清除的部分
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
        End If
        Dim num, n, a(10), i, i2, i3, cnt, istrue, sum As Integer
        num = Val(TextBox1.Text)
        n = 10 '防止值溢出用的，但是溢出其实也早就大于整形的范围了，可以无视
        cnt = 1
        a(0) = 1
        If num > 1 Or num < -1 Then '判断是否是可以算完数的部分
            If num > 0 Then '大于1的时候判断的完数
                i = 2
                Do Until i >= num
                    If (num Mod i) = 0 Then
                        a(cnt) = i
                        cnt += 1
                        If cnt > n Then
                            n += 10
                            ReDim a(n)
                        End If
                    End If
                    i += 1
                Loop
            Else '判断负值情况下的因数，负值的因数包含正负（同时正值理论上也有，但不给予考虑）
                Label5.Text = "非标准计算方式"
                i = 2
                Do Until i >= -num '判断正因子
                    If (num Mod i) = 0 Then
                        a(cnt) = i
                        cnt += 1
                        If cnt > n Then
                            n += 10
                            ReDim a(n)
                        End If
                    End If
                    i += 1
                Loop
                i = -2
                Do Until i <= num '判断负因子
                    If (num Mod i) = 0 Then
                        a(cnt) = i
                        cnt += 1
                        If cnt > n Then
                            n += 10
                            ReDim a(n)
                        End If
                    End If
                    i -= 1
                Loop
            End If
            Do Until i2 > cnt '求和因子
                sum += a(i2)
                i2 += 1
            Loop
            If sum = num Then '判断是否为完数
                istrue = 1
            Else istrue = 0
            End If
            Label2.Text = num & "的因子有" '开始输出
            If istrue Then
                Label3.Text = num & "是完数"
            Else
                Label3.Text = num & "不是完数"
            End If
            Do Until i3 >= cnt
                Label4.Text = Label4.Text & Str(a(i3)) & ";"
                i3 += 1
            Loop
        Else
            Label3.Text = "所输入仅一个因子，不予判断。"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
