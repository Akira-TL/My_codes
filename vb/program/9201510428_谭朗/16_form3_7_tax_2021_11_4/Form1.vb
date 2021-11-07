Public Class Form1
    Dim a(3, 7) As Long
    Dim input, amount As Long, y As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = {{1500, 4500, 9000, 35000, 55000, 80000, 999999999999999999}, {3, 10, 20, 25, 30, 35, 45}, {0, 105, 555, 1005, 2755, 5505, 13505}}
        input = Val(InputBox("请输入实际收入"， "收入"))
        y = 0
        Do While input > a(0, y)
            y += 1
        Loop
        Label1.Text = "实际收入：" & Format(input, "$##,#0.00")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        amount = input * a(1, y) / 100 - a(2, y)
        Label1.Text = "应缴费：" & Format(amount, "$##,#0.00")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
