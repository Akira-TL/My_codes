﻿Public Class Form1
    Dim n, cnt As Integer, a(1000) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "查找素数"
        Button2.Text = "逆序为素数"
        Button3.Text = "清除"
        Button4.Text = "退出"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 300
            a(i) = True
        Next '初始化数组全为true
        TextBox1.Text = "100~300的所有素数：" & vbCrLf
        For i = 2 To 1000
            If a(i) = True Then
                cnt = 2
                Do Until i * cnt > 1000
                    a(i * cnt) = False
                    cnt += 1
                Loop '将n倍的i的值改成false
                If i >= 100 And i <= 300 Then
                    TextBox1.Text = TextBox1.Text & i & vbTab
                End If '输出100~300的素数
            End If '仅将素数（值为true）的进入循环
        Next '倒数会大于300，最大不超过992,1000好写好看而已，保证倒数判断能够确定是否为素数
        TextBox1.Text = TextBox1.Text & vbCrLf
        'For i = 1 To 300
        '    TextBox1.Text = TextBox1.Text & a(i) & vbTab
        'Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "100~300的逆序为素数：" & vbCrLf
        For i = 100 To 300
            If a(i) Then
                n = Val(StrReverse(i))
            End If 'strreverse为倒置文本，n计数
            If a(n) Then
                TextBox1.Text = TextBox1.Text & i & vbTab
            End If '输出
        Next '仅判断100~300的逆序为素数
        TextBox1.Text = TextBox1.Text & vbCrLf '习惯而已，不必在意
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class
