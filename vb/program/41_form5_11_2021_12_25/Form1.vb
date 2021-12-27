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
        Dim n As Integer
        Dim a As Long(,)
        Dim i As Integer, j As Integer
        If e.KeyValue <> 13 Or Not IsNumeric(TextBox2.Text) Then Exit Sub
        n = Val(TextBox2.Text)
        ReDim a(n, n)
        For i = 1 To n
            a(i, 1) = 1
            a(i, i) = 1
        Next i
        For i = 3 To n
            For j = 2 To i - 1
                a(i, j) = a(i - 1, j - 1) + a(i - 1, j)
            Next j
        Next
        TextBox1.Text = ""
        For i = 1 To n
            TextBox1.Text = TextBox1.Text & Space(3 * (n + 1 - i))
            For j = 1 To i
                TextBox1.Text = TextBox1.Text & a(i, j) & "     "
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        TextBox2.Text = "" '书上的代码，利用的字符ASCII码，也可以看看，后面注释掉的是我自己写的，毕竟书上的终归不一定最好
        '有同学反应没反应，那是因为你输入就触发，但是文本还没输入进去，输入了文本后这个过程已经结束了，解决办法就是在结束之后加一个回车，不改变内容，但是再次触发控件
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------
        'row = Val(TextBox2.Text)
        'layer = row
        'ReDim a(row, layer)
        'TextBox1.Text = ""
        'If row > 26 Then
        '    TextBox1.Text = "最大26行" '只是因为大了的话文本显示不完了，设置一个大小而已
        'Else
        '    For i = 1 To row
        '        For j = 1 To i
        '            If i = 1 Then
        '                a(i, j) = 1
        '                TextBox1.Text = TextBox1.Text & a(i, j) & vbTab '" "
        '            Else
        '                a(i, j) = a(i - 1, j - 1) + a(i - 1, j)
        '                TextBox1.Text = TextBox1.Text & a(i, j) & vbTab '" "
        '            End If
        '        Next
        '        TextBox1.Text = TextBox1.Text & vbCrLf
        '    Next '判断和输出
        'End If '有同学反应没反应，那是因为你输入就触发，但是文本还没输入进去，输入了文本后这个过程已经结束了，解决办法就是在结束之后加一个回车，不改变内容，但是再次触发控件
    End Sub
End Class
