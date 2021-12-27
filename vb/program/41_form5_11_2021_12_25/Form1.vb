Public Class Form1
    Dim row, layer, a(row, layer) As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Text = "退出"
        Label1.Text = "请输入"
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    row = Val(InputBox("请输入行数", "输入", "3"))
    '    layer = row
    '    ReDim a(row, layer)
    '    TextBox1.Text = ""
    '    If row > 26 Then
    '        TextBox1.Text = "最大26行"
    '    Else
    '        For i = 1 To row
    '            For j = 1 To i
    '                If i = 1 Then
    '                    a(i, j) = 1
    '                    TextBox1.Text = TextBox1.Text & a(i, j) & vbTab '" "
    '                Else
    '                    a(i, j) = a(i - 1, j - 1) + a(i - 1, j)
    '                    TextBox1.Text = TextBox1.Text & a(i, j) & vbTab '" "
    '                End If
    '            Next
    '            TextBox1.Text = TextBox1.Text & vbCrLf
    '        Next
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        row = Val(TextBox2.Text)
        layer = row
        ReDim a(row, layer)
        TextBox1.Text = ""
        If row > 26 Then
            TextBox1.Text = "最大26行" '只是因为大了的话文本显示不完了，设置一个大小而已
        Else
            For i = 1 To row
                For j = 1 To i
                    If i = 1 Then
                        a(i, j) = 1
                        TextBox1.Text = TextBox1.Text & a(i, j) & vbTab '" "
                    Else
                        a(i, j) = a(i - 1, j - 1) + a(i - 1, j)
                        TextBox1.Text = TextBox1.Text & a(i, j) & vbTab '" "
                    End If
                Next
                TextBox1.Text = TextBox1.Text & vbCrLf
            Next '判断和输出
        End If '有同学反应没反应，那是因为你输入就触发，但是文本还没输入进去，输入了文本后这个过程已经结束了，解决办法就是在结束之后加一个回车，不改变内容，但是再次触发控件
    End Sub
End Class
