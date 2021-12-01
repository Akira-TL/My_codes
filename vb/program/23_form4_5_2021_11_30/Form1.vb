Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "运行"
        Button2.Text = "清除"
        Button3.Text = "结束"
        Label1.Text = "被3整除的数"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = "" '在开始前清空避免因为没点清空而继续向textbox写入字符，不懂的话把这段注释掉然后运行，重复点击运行
        Dim a(9), i, i1, i2, ismod3, cnt As Integer 'a为数组，i，i1，i2为三个循环的计数器，ismod3作为判断依据，详情见下，cnt计数器
        i = 0
        Randomize()
        For i = 0 To 9 '初始化数组，使数组内有值
            'Randomize()
            a(i) = (Rnd() * 90) + 10
        Next i
        Do Until i1 > 9 '将数字写入文本框
            TextBox1.Text = TextBox1.Text & Str(a(i1)) & vbTab 'str()是指将括号内转换为字符串，避免在转换为文本时出错；vbtab是一个tab键，相当于打几个空格  -------  下同 
            i1 += 1 '保证能每次都进行循环，下同
        Loop
        Do Until i2 > 9 '判断是否整除
            ismod3 = a(i2) Mod 3 '这里就是判断是否为整除三，整除三返回0，则进入if
            If ismod3 = 0 Then
                TextBox2.Text = TextBox2.Text & Str(a(i2)) & vbTab
                cnt += 1 '计数，保证第三个文本框能够知道几个整除
            End If
            i2 += 1
        Loop
        TextBox3.Text = "共" & Str(cnt) & "个"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        '这里只是按照需求给了个清空效果
    End Sub
End Class
