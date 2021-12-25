Public Class Form1
    Dim n, a() As Integer, output As Boolean '用全局变量控制数组大小，方便修改和调取

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "生成数列"
        Button2.Text = "二分查找"
        Button3.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(InputBox("请输入数组大小", "定义数组大小"))
        ReDim a(n - 1) '定义数组大小
        Randomize() '初始化随机数，保证随机数每次都不一样
        TextBox1.Text = "数列为："
        For i = 0 To n - 1
            a(i) = Rnd() * 100 '赋值数组以随机数
            TextBox1.Text = TextBox1.Text & " " & a(i)
        Next
        output = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim found As Integer, c As Boolean
        If Not output Then '保证不会重复输出
            TextBox1.Text = TextBox1.Text & vbCrLf & "排序后的数列为："
            For i = 0 To n - 1 '重排数组
                For b = i To n - 1
                    If a(i) > a(b) Then
                        swap(a(i), a(b))
                    End If
                Next
            Next
            For i = 0 To n - 1
                TextBox1.Text = TextBox1.Text & " " & a(i)
            Next
        End If
        found = Val(InputBox("请输入要查找的值：", "查找", "例:23")) '输入查找的数
        c = find(found, a)
        If c Then
            TextBox1.Text = TextBox1.Text & vbCrLf & "要查找的值" & found & "存在"
        Else
            TextBox1.Text = TextBox1.Text & vbCrLf & "要查找的值" & found & "不存在"
        End If
        output = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Function find(a0 As Integer, a() As Integer) As Boolean '二分法查找值
        Dim left, right, mid As Integer
        left = 0
        right = n - 1
        mid = (left + right) / 2 '初始化边界
        Do Until a0 = a(mid) Or mid = left '定义退出循环条件
            If a0 > a(mid) Then '判断中值和a（mid）大小，将mid交给边界，再重新调整mid
                left = mid
                mid = (left + right) / 2
            ElseIf a0 < a(mid) Then
                right = mid
                mid = (left + right) / 2
            End If
        Loop
        If a0 = a(mid) Then '看退出循环是那种情况，输出
            find = True
        Else
            find = False
        End If
    End Function
    Private Function swap(ByRef a1, ByRef a2)
        a1 = a1 + a2
        a2 = a1 - a2
        a1 = a1 - a2
        'Dim n As Integer'下面这个是引入变量的方式交换，上面是不引用变量的交换
        'n = a1
        'a1 = a2
        'a2 = n
    End Function
End Class
