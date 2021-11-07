Public Class Form1
    Dim s1, s2, s3, s As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            s1 = CheckBox1.Text
        Else
            s1 = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            s2 = CheckBox2.Text
        Else
            s2 = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            s3 = CheckBox3.Text
        Else
            s3 = ""
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            s = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            s = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            s = RadioButton3.Text
        ElseIf RadioButton4.Checked Then
            s = RadioButton4.Text
        End If
        Label1.Text = s1 & s2 & s3 & s
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""
    End Sub
End Class
