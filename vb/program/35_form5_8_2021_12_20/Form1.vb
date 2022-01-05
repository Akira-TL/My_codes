Public Class Form1
    Structure an_dian '定义结构（不懂的话就理解为高级点的数组，每次调用在后面加一个“.”去指定这种数组的哪一个东西）
        Dim x, y As Integer
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "找鞍点"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(3, 4) As Integer
    Dim an() As an_dian
    Dim maxnum, cnt, i, j, k, l, x, y As Integer
        Dim ishave, istrue As Boolean
        ishave = False
        Randomize()
        TextBox1.Text = ""
        For i = 0 To 3
            For j = 0 To 4
                'a(i, j) = Val(InputBox("d"))
                a(i, j) = Rnd() * 90 + 10 '赋值数组以随机数
                '97	93	69	21	44
                '57  61	49	59	10
                '54  89	85	57	94
                '75  99	31	63	76
                TextBox1.Text = TextBox1.Text & vbTab & a(i, j)
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        For i = 0 To 3
            istrue = True
            x = i
            y = 0
            For j = 1 To 4
                If a(x, y) < a(i, j) Then
                    'maxnum = a(i, j)
                    x = i
                    y = j
                End If
            Next '找一行最大列和值
            For k = 0 To 3
                If a(x, y) > a(k, y) Then
                    istrue = False
                    Exit For
                End If
            Next '判断最大值是该列最小值
            If istrue Then
                ishave = True
                ReDim Preserve an(cnt)
                an(cnt).x = x
                an(cnt).y = y
                cnt += 1
            End If '存储鞍点（鞍点不一定只有一个，因此在这里专门做了存储鞍点的操作
        Next

        If ishave Then
            For l = 0 To cnt - 1
                TextBox1.Text = TextBox1.Text & vbCrLf & vbTab & $"a({an(l).x + 1},{an(l).y + 1})是鞍点" & vbCrLf
            Next
        Else
            TextBox1.Text = TextBox1.Text & vbCrLf & vbTab & "鞍点不存在" & vbCrLf
        End If
        TextBox1.Text = TextBox1.Text & vbCrLf
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
