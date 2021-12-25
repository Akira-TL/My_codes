Public Class Form1
    Dim row, layer As Integer, a() As line '本题使用了图（应该，还没仔细看就得写，原理我想应该差不多）看不懂没关系，跳过就好
    Structure line
        Dim num As Integer
        Dim a() As Integer
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "请输入"
        Button2.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        row = Val(InputBox("请输入行数", "输入", "3"))
        ReDim a(row)
        For i = 1 To row
            ReDim a(i).a(a(i).num)
        Next
        For i = 1 To row
            For
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
