Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports MikuWeather.My.Resources

<DesignerGenerated()>
Partial Class FrmMsg
    Inherits Form

    'Form 重写 Dispose，以清理组件列表。
    <DebuggerNonUserCode()>
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
    Private components As IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LinkLabel1 = New LinkLabel()
        Me.LinkLabel2 = New LinkLabel()
        Me.PictureBox1 = New PictureBox()
        Me.LinkLabel3 = New LinkLabel()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = Color.Transparent
        Me.LinkLabel1.Font = New Font("条幅黑体", 14.25!)
        Me.LinkLabel1.ForeColor = Color.MediumTurquoise
        Me.LinkLabel1.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel1.Location = New Point(84, 11)
        Me.LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New Size(60, 27)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.Text = "通知"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = Color.Transparent
        Me.LinkLabel2.Font = New Font("Microsoft Sans Serif", 14.25!)
        Me.LinkLabel2.ForeColor = Color.MediumTurquoise
        Me.LinkLabel2.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel2.Location = New Point(163, 8)
        Me.LinkLabel2.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New Size(133, 29)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.Text = "Notification"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = Color.Transparent
        Me.PictureBox1.Cursor = Cursors.Hand
        Me.PictureBox1.Image = abc_ic_clear_normal
        Me.PictureBox1.Location = New Point(344, 1)
        Me.PictureBox1.Margin = New Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(33, 31)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.BackColor = Color.Transparent
        Me.LinkLabel3.Font = New Font("造字工房尚雅体演示版常规体", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel3.ForeColor = Color.SandyBrown
        Me.LinkLabel3.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel3.Location = New Point(16, 48)
        Me.LinkLabel3.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New Size(347, 96)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.Text = "通知内容："
        '
        'frmMsg
        '
        Me.AutoScaleDimensions = New SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = bg_wdtb
        Me.ClientSize = New Size(379, 155)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Margin = New Padding(4, 4, 4, 4)
        Me.Name = "frmMsg"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "frmMsg"
        Me.TopMost = True
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel3 As LinkLabel
End Class
