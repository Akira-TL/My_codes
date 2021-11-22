Public Class Form1
    Dim username, password, extracode As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "确定"
        Button2.Text = "退出"
        Label1.Text = "用户名:"
        Label2.Text = "密码:"
        Label3.Text = "附加码:"
        username = "NJAU"
        password = "NJAU"
        extracode = Int(Rnd(0) * 90 + 10) '初始化密码，文本，等基本界面和数据
        Label4.Text = extracode '让附加码显示在末尾
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer 'abc的作用是存储各个元素是否正确，1表示正确，0表示错误，以便后续的比较
        Dim text As String
        If StrComp(TextBox1.Text, username) Then '判断用户名称是否正确
            a = 0
            text = "请输入用户名！"
        Else
            a = 1
        End If
        If StrComp(TextBox2.Text, password) Then '判断密码是否正确
            b = 0
            text = text & vbCrLf & "请输入密码！"
        Else
            b = 1
        End If
        If StrComp(TextBox3.Text, extracode) Then '判断附加码是否正确
            c = 0
            text = text & vbCrLf & "请输入附加码！"
        Else
            c = 1
        End If
        If a = 0 Or b = 0 Or c = 0 Then '如果判断有一个错误，那就显示文本框提示错误
            MsgBox(text)
            Exit Sub
        Else
            MsgBox("你是合法用户！") '不是全为错就显示合法
        End If
        '---------------------------------------------------------------------------------------------------------
        '还可以做更高级的应用
    End Sub
End Class
