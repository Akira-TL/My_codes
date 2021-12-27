Public Class Form1
    Dim row, layer, a(row, layer) As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "请输入"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        row = Val(InputBox("请输入行数", "输入", "3"))
        layer = row
        ReDim a(row, layer)
        TextBox1.Text = ""
        If row > 26 Then
            TextBox1.Text = "最大26行"
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
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
