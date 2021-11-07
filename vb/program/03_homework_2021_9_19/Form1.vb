Public Class frmExe1_1
    Private Sub FrmExe1_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplay.Text = "Hello World!"
    End Sub

    Private Sub FrmExe1_1_Click(sender As Object, e As EventArgs) Handles Me.Click
        lblDisplay.Text = "You have clicked the Form1!"
    End Sub

    Private Sub FrmExe1_1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        lblDisplay.Text = "You have double clicked the Form1!"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
