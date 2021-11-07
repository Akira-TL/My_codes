<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblHelloworld = New System.Windows.Forms.Label()
        Me.BtnHelloWorld = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblHelloworld
        '
        Me.LblHelloworld.AutoSize = True
        Me.LblHelloworld.Font = New System.Drawing.Font("黑体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblHelloworld.Location = New System.Drawing.Point(27, 21)
        Me.LblHelloworld.Name = "LblHelloworld"
        Me.LblHelloworld.Size = New System.Drawing.Size(0, 21)
        Me.LblHelloworld.TabIndex = 1
        '
        'BtnHelloWorld
        '
        Me.BtnHelloWorld.Font = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnHelloWorld.Location = New System.Drawing.Point(478, 262)
        Me.BtnHelloWorld.Name = "BtnHelloWorld"
        Me.BtnHelloWorld.Size = New System.Drawing.Size(109, 53)
        Me.BtnHelloWorld.TabIndex = 2
        Me.BtnHelloWorld.Text = "start"
        Me.BtnHelloWorld.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 329)
        Me.Controls.Add(Me.BtnHelloWorld)
        Me.Controls.Add(Me.LblHelloworld)
        Me.Name = "Form1"
        Me.Text = "Hello world!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHelloworld As Label
    Friend WithEvents BtnHelloWorld As Button
End Class
