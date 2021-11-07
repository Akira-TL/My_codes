Public Class Form1
    'Dim hight As Single
    'Dim weight As Single
    'Dim sw, fat

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            Label9.Text = ""
            Dim high As Single, weight As Single, sw!, fat!
            high = Val(TextBox1.Text) / 100
            weight = Val(TextBox2.Text)
            sw = high * high * 22
            fat = (weight - sw) / sw * 100
            TextBox3.Text = sw
            TextBox4.Text = fat
            'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            '    TextBox3.Text = Val(TextBox1.Text)/100 * Val(TextBox2.Text)/100 * 22
            '    TextBox4.Text = (Val(TextBox2.Text) - Val(TextBox3)) / Val(TextBox3) * 100
            'End Sub
            '
            'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            'End
            '
        End If
        If (TextBox1.Text = "" And TextBox2.Text = "") Then
            Label9.Text = "请输入身高体重！"
        End If
        If (TextBox1.Text = "" And TextBox2.Text <> "") Then
            Label9.Text = "请输入身高！"
        End If
        If (TextBox1.Text <> "" And TextBox2.Text = "") Then
            Label9.Text = "请输入体重！"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label9.Text = ""
    End Sub
End Class
