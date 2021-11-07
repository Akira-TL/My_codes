Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox2.Text = ""
        ListBox1.Items.Clear()
        ListBox1.Items.Insert(0, "篮球")
        ListBox1.Items.Insert(1, "足球")
        ListBox1.Items.Insert(2, "排球")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox2.Text = ""
        ListBox1.Items.Clear()
        ListBox1.Items.Insert(0, "游泳")
        ListBox1.Items.Insert(1, "羽毛球")
        ListBox1.Items.Insert(2, "乒乓球")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Visible = False
        ListBox1.Items.Clear()
        GroupBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        GroupBox2.Text = GroupBox2.Text & vbCrLf & ListBox1.GetItemText(ListBox1.SelectedItem)
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Label2.Text = TextBox1.Text & "号运动员参赛项目："
        Label2.Visible = True
        GroupBox2.Text = ""
    End Sub
End Class
