Public Class Form1
    Dim rb As New ArrayList '什么鬼东西，都不教一下arraylist?不教一下add？
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = "中文"
        Label2.Text = ""
        TextBox1.Text = "你好"
        TextBox2.Text = ""
        GroupBox1.Text = "目标语言"
        Button1.Text = "动态添加数组控件"
        Button2.Text = "退出"
        RadioButton1.Text = "英语"
        RadioButton2.Text = "法语"
        RadioButton3.Text = "德语"
        rb.Add(RadioButton1)
        rb.Add(RadioButton2)
        rb.Add(RadioButton3)
    End Sub
    Private Sub rb_checkedchanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        Select Case sender.tabindex
            Case 0
                Label2.Text = "英语"
                TextBox2.Text = "hello"
            Case 1
                Label2.Text = "法语"
                TextBox2.Text = "bonjour"
            Case 2
                Label2.Text = "德语"
                TextBox2.Text = "hallo"
        End Select
    End Sub
    Private Sub rb_checked(sender As Object, e As EventArgs)
        Label2.Text = "瑞典语"
        TextBox2.Text = "hej"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As New RadioButton '实例化一个新单选按钮
        With b
            .Name = "RadioButton " & 4
            .Text = "瑞典语"
            .Location = New Point(26, 150)
            .Dock = DockStyle.None
            .UseVisualStyleBackColor = True
            '委托单选按钮的单击事件
            AddHandler .CheckedChanged, AddressOf rb_checked
            Me.Controls.Add(b） '在窗体上添加单选按钮b. Parent = GroupBoxl
            rb.Add(b)
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
