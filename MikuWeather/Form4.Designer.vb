Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports MikuWeather.My.Resources

<DesignerGenerated()>
Partial Class FrmSetting
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
        Me.components = New Container()
        Me.PictureBox7 = New PictureBox()
        Me.PictureBox6 = New PictureBox()
        Me.PictureBox5 = New PictureBox()
        Me.PictureBox4 = New PictureBox()
        Me.LinkLabel9 = New LinkLabel()
        Me.LinkLabel8 = New LinkLabel()
        Me.ComboBox1 = New ComboBox()
        Me.LinkLabel7 = New LinkLabel()
        Me.TextBox1 = New TextBox()
        Me.CheckBox2 = New CheckBox()
        Me.LinkLabel5 = New LinkLabel()
        Me.LinkLabel4 = New LinkLabel()
        Me.LinkLabel3 = New LinkLabel()
        Me.LinkLabel2 = New LinkLabel()
        Me.CheckBox1 = New CheckBox()
        Me.lnkVer = New LinkLabel()
        Me.PictureBox2 = New PictureBox()
        Me.PictureBox1 = New PictureBox()
        Me.picLoc = New PictureBox()
        Me.radBaiduapi = New RadioButton()
        Me.radJuhe = New RadioButton()
        Me.LinkLabel10 = New LinkLabel()
        Me.ToolTip1 = New ToolTip(Me.components)
        Me.LinkLabel6 = New LinkLabel()
        CType(Me.PictureBox7, ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        CType(Me.picLoc, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = Color.Transparent
        Me.PictureBox7.Cursor = Cursors.Hand
        Me.PictureBox7.ErrorImage = Nothing
        Me.PictureBox7.Image = abc_ic_clear_normal
        Me.PictureBox7.Location = New Point(367, 1)
        Me.PictureBox7.Margin = New Padding(4, 3, 4, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New Size(33, 31)
        Me.PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 49
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = Color.Transparent
        Me.PictureBox6.Cursor = Cursors.Default
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Image = ic_menu_refresh
        Me.PictureBox6.Location = New Point(227, 168)
        Me.PictureBox6.Margin = New Padding(4, 3, 4, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New Size(26, 36)
        Me.PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 48
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = Color.Transparent
        Me.PictureBox5.Cursor = Cursors.Hand
        Me.PictureBox5.Image = abc_ic_clear_normal
        Me.PictureBox5.Location = New Point(256, 390)
        Me.PictureBox5.Margin = New Padding(4, 3, 4, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New Size(61, 51)
        Me.PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 47
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = Color.Transparent
        Me.PictureBox4.Cursor = Cursors.Hand
        Me.PictureBox4.Image = abc_ic_cab_done_holo_dark
        Me.PictureBox4.Location = New Point(92, 390)
        Me.PictureBox4.Margin = New Padding(4, 3, 4, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New Size(55, 47)
        Me.PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.BackColor = Color.Transparent
        Me.LinkLabel9.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.ForeColor = Color.MediumTurquoise
        Me.LinkLabel9.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel9.Location = New Point(35, 259)
        Me.LinkLabel9.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New Size(172, 27)
        Me.LinkLabel9.TabIndex = 42
        Me.LinkLabel9.Text = "天气数据提供商："
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = Color.Transparent
        Me.LinkLabel8.Font = New Font("Microsoft Sans Serif", 12.0!)
        Me.LinkLabel8.ForeColor = Color.MediumTurquoise
        Me.LinkLabel8.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel8.Location = New Point(276, 339)
        Me.LinkLabel8.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New Size(52, 25)
        Me.LinkLabel8.TabIndex = 41
        Me.LinkLabel8.Text = "分钟"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = SystemColors.MenuHighlight
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = Color.DarkTurquoise
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"30", "60", "90", "120"})
        Me.ComboBox1.Location = New Point(189, 336)
        Me.ComboBox1.Margin = New Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New Size(77, 28)
        Me.ComboBox1.TabIndex = 40
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = Color.Transparent
        Me.LinkLabel7.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.ForeColor = Color.MediumTurquoise
        Me.LinkLabel7.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel7.Location = New Point(297, 214)
        Me.LinkLabel7.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New Size(32, 27)
        Me.LinkLabel7.TabIndex = 39
        Me.LinkLabel7.Text = "市"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = Color.White
        Me.TextBox1.BorderStyle = BorderStyle.FixedSingle
        Me.TextBox1.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = Color.DarkTurquoise
        Me.TextBox1.ImeMode = ImeMode.[On]
        Me.TextBox1.Location = New Point(147, 212)
        Me.TextBox1.Margin = New Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Size(142, 30)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.TextAlign = HorizontalAlignment.Right
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = Color.Transparent
        Me.CheckBox2.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = Color.DarkGray
        Me.CheckBox2.Location = New Point(40, 173)
        Me.CheckBox2.Margin = New Padding(4, 3, 4, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New Size(176, 31)
        Me.CheckBox2.TabIndex = 33
        Me.CheckBox2.Text = "自动进行IP定位"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = Color.Transparent
        Me.LinkLabel5.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.ForeColor = Color.MediumTurquoise
        Me.LinkLabel5.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel5.Location = New Point(35, 215)
        Me.LinkLabel5.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New Size(112, 27)
        Me.LinkLabel5.TabIndex = 32
        Me.LinkLabel5.Text = "所在城市："
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = Color.Transparent
        Me.LinkLabel4.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.ForeColor = Color.MediumTurquoise
        Me.LinkLabel4.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel4.Location = New Point(35, 339)
        Me.LinkLabel4.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New Size(152, 27)
        Me.LinkLabel4.TabIndex = 31
        Me.LinkLabel4.Text = "数据更新间隔："
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = Color.Transparent
        Me.LinkLabel3.Font = New Font("造字工房尚雅体演示版常规体", 13.8!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = Color.MediumTurquoise
        Me.LinkLabel3.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel3.Location = New Point(73, 95)
        Me.LinkLabel3.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New Size(95, 33)
        Me.LinkLabel3.TabIndex = 30
        Me.LinkLabel3.Text = "Settings"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = Color.Transparent
        Me.LinkLabel2.Font = New Font("造字工房尚雅体演示版常规体", 13.8!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = Color.MediumTurquoise
        Me.LinkLabel2.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel2.Location = New Point(5, 95)
        Me.LinkLabel2.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New Size(63, 33)
        Me.LinkLabel2.TabIndex = 29
        Me.LinkLabel2.Text = "设置"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = CheckState.Indeterminate
        Me.CheckBox1.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = Color.DarkGray
        Me.CheckBox1.Location = New Point(40, 133)
        Me.CheckBox1.Margin = New Padding(4, 3, 4, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New Size(134, 31)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "开机自启动"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'lnkVer
        '
        Me.lnkVer.AutoSize = True
        Me.lnkVer.BackColor = Color.Transparent
        Me.lnkVer.Font = New Font("造字工房雅圆（非商用）常规体", 12.5!)
        Me.lnkVer.ForeColor = Color.MediumTurquoise
        Me.lnkVer.LinkArea = New LinkArea(0, 0)
        Me.lnkVer.Location = New Point(270, 32)
        Me.lnkVer.Margin = New Padding(4, 0, 4, 0)
        Me.lnkVer.Name = "lnkVer"
        Me.lnkVer.Size = New Size(73, 29)
        Me.lnkVer.TabIndex = 27
        Me.lnkVer.Text = "v 3.9.8"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = Color.Transparent
        Me.PictureBox2.Cursor = Cursors.Hand
        Me.PictureBox2.ErrorImage = action_title
        Me.PictureBox2.Image = action_title
        Me.PictureBox2.Location = New Point(20, 16)
        Me.PictureBox2.Margin = New Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Size(248, 61)
        Me.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = bg_btn
        Me.PictureBox1.Location = New Point(-9, -7)
        Me.PictureBox1.Margin = New Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(427, 89)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'picLoc
        '
        Me.picLoc.BackColor = Color.Transparent
        Me.picLoc.Image = noloc
        Me.picLoc.Location = New Point(343, 75)
        Me.picLoc.Margin = New Padding(4, 3, 4, 3)
        Me.picLoc.Name = "picLoc"
        Me.picLoc.Size = New Size(52, 61)
        Me.picLoc.SizeMode = PictureBoxSizeMode.Zoom
        Me.picLoc.TabIndex = 45
        Me.picLoc.TabStop = False
        '
        'radBaiduapi
        '
        Me.radBaiduapi.AutoSize = True
        Me.radBaiduapi.BackColor = Color.Transparent
        Me.radBaiduapi.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.radBaiduapi.ForeColor = Color.DarkGray
        Me.radBaiduapi.Location = New Point(40, 289)
        Me.radBaiduapi.Margin = New Padding(4, 3, 4, 3)
        Me.radBaiduapi.Name = "radBaiduapi"
        Me.radBaiduapi.Size = New Size(169, 31)
        Me.radBaiduapi.TabIndex = 50
        Me.radBaiduapi.Text = "百度车联网API"
        Me.radBaiduapi.UseVisualStyleBackColor = False
        '
        'radJuhe
        '
        Me.radJuhe.AutoSize = True
        Me.radJuhe.BackColor = Color.Transparent
        Me.radJuhe.Enabled = False
        Me.radJuhe.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.radJuhe.ForeColor = Color.DarkGray
        Me.radJuhe.Location = New Point(256, 289)
        Me.radJuhe.Margin = New Padding(4, 3, 4, 3)
        Me.radJuhe.Name = "radJuhe"
        Me.radJuhe.Size = New Size(113, 31)
        Me.radJuhe.TabIndex = 51
        Me.radJuhe.Text = "聚合数据"
        Me.radJuhe.UseVisualStyleBackColor = False
        '
        'LinkLabel10
        '
        Me.LinkLabel10.BackColor = Color.Transparent
        Me.LinkLabel10.Font = New Font("Microsoft Sans Serif", 8.999999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel10.ForeColor = Color.WhiteSmoke
        Me.LinkLabel10.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel10.Location = New Point(89, 55)
        Me.LinkLabel10.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New Size(264, 24)
        Me.LinkLabel10.TabIndex = 60
        Me.LinkLabel10.Text = "Copyright © 2016  Rainy Summer"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = Color.DarkSlateGray
        Me.ToolTip1.ForeColor = Color.SandyBrown
        '
        'LinkLabel6
        '
        Me.LinkLabel6.BackColor = Color.Transparent
        Me.LinkLabel6.Font = New Font("造字工房尚雅体演示版常规体", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel6.ForeColor = Color.WhiteSmoke
        Me.LinkLabel6.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel6.Location = New Point(5, 456)
        Me.LinkLabel6.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New Size(393, 24)
        Me.LinkLabel6.TabIndex = 63
        Me.LinkLabel6.Text = "Powered By:  百度车联网API、聚合数据（待开发）"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = bg_wdtb
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(401, 481)
        Me.Controls.Add(Me.LinkLabel6)
        Me.Controls.Add(Me.LinkLabel10)
        Me.Controls.Add(Me.radJuhe)
        Me.Controls.Add(Me.radBaiduapi)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LinkLabel9)
        Me.Controls.Add(Me.LinkLabel8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lnkVer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picLoc)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Margin = New Padding(4, 3, 4, 3)
        Me.Name = "frmSetting"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "frmSetting"
        CType(Me.PictureBox7, ISupportInitialize).EndInit()
        CType(Me.PictureBox6, ISupportInitialize).EndInit()
        CType(Me.PictureBox5, ISupportInitialize).EndInit()
        CType(Me.PictureBox4, ISupportInitialize).EndInit()
        CType(Me.PictureBox2, ISupportInitialize).EndInit()
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        CType(Me.picLoc, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lnkVer As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picLoc As PictureBox
    Friend WithEvents radBaiduapi As RadioButton
    Friend WithEvents radJuhe As RadioButton
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel6 As LinkLabel
End Class
