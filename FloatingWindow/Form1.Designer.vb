Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports MikuWeather.My.Resources

<DesignerGenerated()>
Partial Class FrmShow
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
        Me.LinkLabel4 = New LinkLabel()
        Me.LinkLabel3 = New LinkLabel()
        Me.PictureBox2 = New PictureBox()
        Me.PictureBox3 = New PictureBox()
        CType(Me.PictureBox2, ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = Color.Transparent
        Me.LinkLabel1.Font = New Font("造字工房雅圆（非商用）常规体", 13.0!)
        Me.LinkLabel1.ForeColor = Color.LightGreen
        Me.LinkLabel1.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel1.Location = New Point(0, 169)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New Size(174, 24)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.Text = "-- °C"
        Me.LinkLabel1.TextAlign = ContentAlignment.MiddleCenter
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = Color.Transparent
        Me.LinkLabel2.Font = New Font("造字工房雅圆（非商用）常规体", 13.0!)
        Me.LinkLabel2.ForeColor = Color.LightGreen
        Me.LinkLabel2.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel2.Location = New Point(175, 169)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New Size(174, 24)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.Text = "-- °C"
        Me.LinkLabel2.TextAlign = ContentAlignment.MiddleCenter
        '
        'LinkLabel4
        '
        Me.LinkLabel4.BackColor = Color.Transparent
        Me.LinkLabel4.Font = New Font("条幅黑体", 13.5!)
        Me.LinkLabel4.ForeColor = Color.MediumTurquoise
        Me.LinkLabel4.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel4.Location = New Point(175, 150)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New Size(174, 21)
        Me.LinkLabel4.TabIndex = 7
        Me.LinkLabel4.Text = "无数据"
        Me.LinkLabel4.TextAlign = ContentAlignment.TopCenter
        '
        'LinkLabel3
        '
        Me.LinkLabel3.BackColor = Color.Transparent
        Me.LinkLabel3.Font = New Font("条幅黑体", 13.5!)
        Me.LinkLabel3.ForeColor = Color.MediumTurquoise
        Me.LinkLabel3.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel3.Location = New Point(0, 150)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New Size(174, 21)
        Me.LinkLabel3.TabIndex = 6
        Me.LinkLabel3.Text = "无数据"
        Me.LinkLabel3.TextAlign = ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = Color.Transparent
        Me.PictureBox2.Image = N2
        Me.PictureBox2.Location = New Point(18, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Size(144, 143)
        Me.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = Color.Transparent
        Me.PictureBox3.Image = N2
        Me.PictureBox3.Location = New Point(184, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New Size(144, 143)
        Me.PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'frmShow
        '
        Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = bg_wdt
        Me.BackgroundImageLayout = ImageLayout.Zoom
        Me.ClientSize = New Size(349, 196)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.Font = New Font("Microsoft Sans Serif", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Name = "frmShow"
        Me.Opacity = 0.93R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "frmShow"
        Me.TopMost = True
        CType(Me.PictureBox2, ISupportInitialize).EndInit()
        CType(Me.PictureBox3, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
