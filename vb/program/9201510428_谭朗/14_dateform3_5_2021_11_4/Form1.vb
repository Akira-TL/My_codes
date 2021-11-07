Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Text = ""
        Label2.Text = "年"
        Label3.Text = ""
        Label4.Text = "月"
        Label5.Text = ""
        Label6.Text = "日"
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = "时"
        Label10.Text = ""
        Label11.Text = "分"
        Label12.Text = ""
        Label13.Text = "秒"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now.Year
        Label3.Text = Now.Month
        Label5.Text = Now.Day
        Label8.Text = Now.Hour
        Label10.Text = Now.Minute
        Label12.Text = Now.Second
        Select Case Now.DayOfWeek
            Case 1
                Label7.Text = "星期一"
            Case 2
                Label7.Text = "星期二"
            Case 3
                Label7.Text = "星期三"
            Case 4
                Label7.Text = "星期四"
            Case 5
                Label7.Text = "星期五"
            Case 6
                Label7.Text = "星期六"
            Case 7
                Label7.Text = "星期七"
        End Select
    End Sub
End Class
