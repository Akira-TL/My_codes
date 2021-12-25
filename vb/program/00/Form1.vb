Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim a(-1) As Integer, i As Integer, j As Integer, count As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "100-300的素数：" & vbCrLf
        For i = 100 To 300
            For j = 2 To Math.Sqrt(i)
                If i Mod j = 0 Then
                    Exit For
                End If
            Next
            If j > Math.Sqrt(i) Then
                count = count + 1
                ReDim Preserve a(count)
                a(count) = i
                TextBox1.Text = TextBox1.Text & Str(a(count))
                If count Mod 5 = 0 Then TextBox1.Text = TextBox1.Text & vbCrLf

            End If
        Next
        i = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nx As Integer, s As String, c As Integer
        TextBox1.Text = TextBox1.Text & vbCrLf & "100-300的逆序素数：" & vbCrLf
        For i = 1 To 5
            's = CStr(a(i))
            nx = StrReverse(a(i)) 'Val(Mid(s, 3, 1) & Mid(s, 2, 1) & Mid(s, 1, 1))
            For j = 2 To Math.Sqrt(nx)
                If nx Mod j = 0 Then Exit For
            Next
            If j > Math.Sqrt(nx) Then
                c = c + 1
                ReDim Preserve a(c)
                a(c) = i
                TextBox1.Text = TextBox1.Text & Str(a(i))
                If c Mod 5 = 0 Then
                    TextBox1.Text = TextBox1.Text & vbCrLf
                End If
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub


End Class
