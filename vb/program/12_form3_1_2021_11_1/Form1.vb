Public Class Form1
    Dim t, tm, ts As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "启动"
        Button2.Text = "复位"
        Button3.Text = "停止"
        Button4.Text = "暂停"
        Label1.Text = "" '啊这，有什么用？注释就是给人看的，大型项目可以有一半的东西都是注释，为的就是能够在下一次使用时可以快速知道当前代码是为什么这么写，有什么用。

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tm = ts = t = 0
        Label1.Text = "00mm:00ss"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Enabled = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t = t + 1
        tm = t / 60
        ts = t Mod 60
        Label1.Text = tm & "mm" & ts & "ss"
    End Sub
End Class
