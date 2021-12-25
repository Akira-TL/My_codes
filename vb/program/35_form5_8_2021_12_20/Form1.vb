Public Class Form1
    Dim a(3, 4) As Integer
    Dim an(-1) As an_dian
    Dim maxnum, cnt, i, j, k, l, y As Integer
    Dim ishave, istrue As Boolean
    Structure an_dian '定义结构（不懂的话就理解为高级点的数组，每次调用在后面加一个“.”去指定这种数组的哪一个东西）
        Dim x, y As Integer
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "找鞍点"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            istrue = True
            k = 0
            y = 0
            maxnum = a(i, 0)
            For j = 0 To 4
                If maxnum < a(i, j) Then
                    maxnum = a(i, j)
                    y = j
                End If
            Next '找一行最大列和值
            Do Until k > 3
                If maxnum > a(k, y) Then
                    istrue = False
                    Exit Do
                End If
                k += 1
            Loop '判断最大值是该列最小值
            If istrue Then
                ishave = True
                ReDim Preserve an(cnt)
                an(cnt).x = i
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
