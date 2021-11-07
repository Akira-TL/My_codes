Public Class Form1

    Dim A1, A2, A3 As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "加"
        Button2.Text = "减"
        Button3.Text = "乘"
        Button4.Text = "除"
        Button5.Text = "整除"
        Button6.Text = "取模"
        Button7.Text = "绝对值"
        Button8.Text = "平方根"
        Button9.Text = "清除"
        Button10.Text = "退出"
        Label1.Text = ""
        Label2.Text = "="
        Label3.Text = ""
        Label4.Text = ""
    End Sub



    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        A1 = Val(TextBox1.Text)
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        A2 = Val(TextBox2.Text)
    End Sub
    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        A3 = Val(TextBox3.Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "+"
        Label2.Text = "="
        A3 = A1 + A2
        TextBox3.Text = A3
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "-"
        Label2.Text = "="
        A3 = A1 - A2
        TextBox3.Text = A3
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "*"
        Label2.Text = "="
        A3 = A1 * A2
        TextBox3.Text = A3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (A2 = 0) Then
            Label4.Text = "被除数不能等于零，请清除并重新输入！"
        Else
            Label1.Text = "/"
            Label2.Text = "="
            A3 = A1 / A2
            TextBox3.Text = A3
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (A2 = 0) Then
            Label4.Text = "被除数不能等于零，请清除并重新输入！"
        Else
            Label1.Text = "\"
            Label2.Text = "="
            A3 = A1 \ A2
            TextBox3.Text = A3
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (A2 = 0) Then
            Label4.Text = "被除数不能等于零，请清除并重新输入！"
        Else
            Label1.Text = "Mod"
            Label2.Text = "="
            A3 = A1 Mod A2
            TextBox3.Text = A3
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Visible = 0
        Label1.Text = "|"
        Label2.Text = "="
        Label3.Text = "|"
        If (A1 < 0) Then
            A1 = -A1
        End If
        A3 = A1
        TextBox3.Text = A3
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Visible = 0
        If (A1 < 0) Then
            Label4.Text = "被开方数不能小于零，请清除并重新输入！"
        Else
            Label1.Text = "sqrt"
            Label2.Text = "="
            A3 = A1 ^ (1 / 2)
            TextBox3.Text = A3
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label1.Text = ""
        Label2.Text = ""
        Label4.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox2.Visible = 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        End
    End Sub
End Class

