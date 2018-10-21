Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports MikuWeather.My.Resources

<DesignerGenerated()>
Partial Class FrmDetail
    Inherits Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picTitleBack = New PictureBox()
        Me.lnkCopy = New LinkLabel()
        Me.picClose = New PictureBox()
        Me.lnkVer = New LinkLabel()
        Me.picTitle = New PictureBox()
        Me.lnkCity = New LinkLabel()
        Me.lnkCloTitle = New LinkLabel()
        Me.LinkLabel8 = New LinkLabel()
        Me.lnkPM = New LinkLabel()
        Me.lnkClo = New LinkLabel()
        Me.lnkCar = New LinkLabel()
        Me.lnkCarTitle = New LinkLabel()
        Me.lnkSic = New LinkLabel()
        Me.lnkSicTitle = New LinkLabel()
        Me.lnkSpo = New LinkLabel()
        Me.lnkSpoTitle = New LinkLabel()
        Me.lnkUV = New LinkLabel()
        Me.lnkUVTitle = New LinkLabel()
        Me.LinkLabel1 = New LinkLabel()
        Me.lnkWind = New LinkLabel()
        CType(Me.picTitleBack, ISupportInitialize).BeginInit()
        CType(Me.picClose, ISupportInitialize).BeginInit()
        CType(Me.picTitle, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTitleBack
        '
        Me.picTitleBack.Image = bg_btn
        Me.picTitleBack.Location = New Point(-9, -7)
        Me.picTitleBack.Margin = New Padding(0)
        Me.picTitleBack.Name = "picTitleBack"
        Me.picTitleBack.Size = New Size(427, 89)
        Me.picTitleBack.TabIndex = 26
        Me.picTitleBack.TabStop = False
        '
        'lnkCopy
        '
        Me.lnkCopy.BackColor = Color.Transparent
        Me.lnkCopy.Font = New Font("Microsoft Sans Serif", 8.999999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkCopy.ForeColor = Color.WhiteSmoke
        Me.lnkCopy.LinkArea = New LinkArea(0, 0)
        Me.lnkCopy.Location = New Point(89, 55)
        Me.lnkCopy.Margin = New Padding(4, 0, 4, 0)
        Me.lnkCopy.Name = "lnkCopy"
        Me.lnkCopy.Size = New Size(264, 24)
        Me.lnkCopy.TabIndex = 64
        Me.lnkCopy.Text = "Copyright © 2014  Rainy Summer"
        '
        'picClose
        '
        Me.picClose.BackColor = Color.Transparent
        Me.picClose.Cursor = Cursors.Hand
        Me.picClose.ErrorImage = Nothing
        Me.picClose.Image = abc_ic_clear_normal
        Me.picClose.Location = New Point(376, 8)
        Me.picClose.Margin = New Padding(4, 3, 4, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New Size(33, 31)
        Me.picClose.SizeMode = PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 63
        Me.picClose.TabStop = False
        '
        'lnkVer
        '
        Me.lnkVer.AutoSize = True
        Me.lnkVer.BackColor = Color.Transparent
        Me.lnkVer.Font = New Font("造字工房雅圆（非商用）常规体", 12.5!)
        Me.lnkVer.ForeColor = Color.MediumTurquoise
        Me.lnkVer.LinkArea = New LinkArea(0, 0)
        Me.lnkVer.Location = New Point(272, 33)
        Me.lnkVer.Margin = New Padding(4, 0, 4, 0)
        Me.lnkVer.Name = "lnkVer"
        Me.lnkVer.Size = New Size(99, 29)
        Me.lnkVer.TabIndex = 62
        Me.lnkVer.Text = "LinkLabel1"
        '
        'picTitle
        '
        Me.picTitle.BackColor = Color.Transparent
        Me.picTitle.Cursor = Cursors.Hand
        Me.picTitle.ErrorImage = action_title
        Me.picTitle.Image = action_title
        Me.picTitle.Location = New Point(20, 16)
        Me.picTitle.Margin = New Padding(4, 3, 4, 3)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New Size(248, 61)
        Me.picTitle.SizeMode = PictureBoxSizeMode.Zoom
        Me.picTitle.TabIndex = 61
        Me.picTitle.TabStop = False
        '
        'lnkCity
        '
        Me.lnkCity.AutoSize = True
        Me.lnkCity.BackColor = Color.Transparent
        Me.lnkCity.Font = New Font("条幅黑体", 30.0!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkCity.ForeColor = Color.LightSalmon
        Me.lnkCity.LinkArea = New LinkArea(0, 0)
        Me.lnkCity.Location = New Point(9, 93)
        Me.lnkCity.Margin = New Padding(4, 0, 4, 0)
        Me.lnkCity.Name = "lnkCity"
        Me.lnkCity.Size = New Size(125, 57)
        Me.lnkCity.TabIndex = 65
        Me.lnkCity.Text = "城市"
        '
        'lnkCloTitle
        '
        Me.lnkCloTitle.AutoSize = True
        Me.lnkCloTitle.BackColor = Color.Transparent
        Me.lnkCloTitle.Font = New Font("造字工房尚雅体演示版常规体", 12.0!)
        Me.lnkCloTitle.ForeColor = Color.DarkTurquoise
        Me.lnkCloTitle.LinkArea = New LinkArea(0, 0)
        Me.lnkCloTitle.Location = New Point(15, 155)
        Me.lnkCloTitle.Margin = New Padding(4, 0, 4, 0)
        Me.lnkCloTitle.Name = "lnkCloTitle"
        Me.lnkCloTitle.Size = New Size(52, 27)
        Me.lnkCloTitle.TabIndex = 66
        Me.lnkCloTitle.Text = "穿衣"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = Color.Transparent
        Me.LinkLabel8.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.ForeColor = Color.LightSkyBlue
        Me.LinkLabel8.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel8.Location = New Point(149, 92)
        Me.LinkLabel8.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New Size(94, 27)
        Me.LinkLabel8.TabIndex = 69
        Me.LinkLabel8.Text = "PM 2.5  :  "
        '
        'lnkPM
        '
        Me.lnkPM.AutoSize = True
        Me.lnkPM.BackColor = Color.Transparent
        Me.lnkPM.Font = New Font("造字工房尚雅体演示版常规体", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkPM.ForeColor = Color.Cornsilk
        Me.lnkPM.LinkArea = New LinkArea(0, 0)
        Me.lnkPM.Location = New Point(147, 115)
        Me.lnkPM.Margin = New Padding(4, 0, 4, 0)
        Me.lnkPM.Name = "lnkPM"
        Me.lnkPM.Size = New Size(88, 34)
        Me.lnkPM.TabIndex = 73
        Me.lnkPM.Text = "10 · 优"
        '
        'lnkClo
        '
        Me.lnkClo.AutoEllipsis = True
        Me.lnkClo.BackColor = Color.Transparent
        Me.lnkClo.Font = New Font("造字工房尚雅体演示版常规体", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkClo.ForeColor = Color.Turquoise
        Me.lnkClo.LinkArea = New LinkArea(0, 0)
        Me.lnkClo.Location = New Point(16, 177)
        Me.lnkClo.Margin = New Padding(4, 0, 4, 0)
        Me.lnkClo.Name = "lnkClo"
        Me.lnkClo.Size = New Size(369, 47)
        Me.lnkClo.TabIndex = 74
        Me.lnkClo.Text = "天气热，建议着短裙、短裤、短薄外套、T恤等夏季服装。"
        '
        'lnkCar
        '
        Me.lnkCar.AutoEllipsis = True
        Me.lnkCar.BackColor = Color.Transparent
        Me.lnkCar.Font = New Font("造字工房尚雅体演示版常规体", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkCar.ForeColor = Color.Turquoise
        Me.lnkCar.LinkArea = New LinkArea(0, 0)
        Me.lnkCar.Location = New Point(16, 243)
        Me.lnkCar.Margin = New Padding(4, 0, 4, 0)
        Me.lnkCar.Name = "lnkCar"
        Me.lnkCar.Size = New Size(369, 47)
        Me.lnkCar.TabIndex = 76
        Me.lnkCar.Text = "天气热，建议着短裙、短裤、短薄外套、T恤等夏季服装。"
        '
        'lnkCarTitle
        '
        Me.lnkCarTitle.AutoSize = True
        Me.lnkCarTitle.BackColor = Color.Transparent
        Me.lnkCarTitle.Font = New Font("造字工房尚雅体演示版常规体", 12.0!)
        Me.lnkCarTitle.ForeColor = Color.DarkTurquoise
        Me.lnkCarTitle.LinkArea = New LinkArea(0, 0)
        Me.lnkCarTitle.Location = New Point(15, 221)
        Me.lnkCarTitle.Margin = New Padding(4, 0, 4, 0)
        Me.lnkCarTitle.Name = "lnkCarTitle"
        Me.lnkCarTitle.Size = New Size(52, 27)
        Me.lnkCarTitle.TabIndex = 75
        Me.lnkCarTitle.Text = "洗车"
        '
        'lnkSic
        '
        Me.lnkSic.AutoEllipsis = True
        Me.lnkSic.BackColor = Color.Transparent
        Me.lnkSic.Font = New Font("造字工房尚雅体演示版常规体", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkSic.ForeColor = Color.Turquoise
        Me.lnkSic.LinkArea = New LinkArea(0, 0)
        Me.lnkSic.Location = New Point(16, 305)
        Me.lnkSic.Margin = New Padding(4, 0, 4, 0)
        Me.lnkSic.Name = "lnkSic"
        Me.lnkSic.Size = New Size(369, 47)
        Me.lnkSic.TabIndex = 80
        Me.lnkSic.Text = "天气热，建议着短裙、短裤、短薄外套、T恤等夏季服装。"
        '
        'lnkSicTitle
        '
        Me.lnkSicTitle.AutoSize = True
        Me.lnkSicTitle.BackColor = Color.Transparent
        Me.lnkSicTitle.Font = New Font("造字工房尚雅体演示版常规体", 12.0!)
        Me.lnkSicTitle.ForeColor = Color.DarkTurquoise
        Me.lnkSicTitle.LinkArea = New LinkArea(0, 0)
        Me.lnkSicTitle.Location = New Point(15, 284)
        Me.lnkSicTitle.Margin = New Padding(4, 0, 4, 0)
        Me.lnkSicTitle.Name = "lnkSicTitle"
        Me.lnkSicTitle.Size = New Size(52, 27)
        Me.lnkSicTitle.TabIndex = 79
        Me.lnkSicTitle.Text = "感冒"
        '
        'lnkSpo
        '
        Me.lnkSpo.AutoEllipsis = True
        Me.lnkSpo.BackColor = Color.Transparent
        Me.lnkSpo.Font = New Font("造字工房尚雅体演示版常规体", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkSpo.ForeColor = Color.Turquoise
        Me.lnkSpo.LinkArea = New LinkArea(0, 0)
        Me.lnkSpo.Location = New Point(16, 372)
        Me.lnkSpo.Margin = New Padding(4, 0, 4, 0)
        Me.lnkSpo.Name = "lnkSpo"
        Me.lnkSpo.Size = New Size(369, 47)
        Me.lnkSpo.TabIndex = 82
        Me.lnkSpo.Text = "天气热，建议着短裙、短裤、短薄外套、T恤等夏季服装。"
        '
        'lnkSpoTitle
        '
        Me.lnkSpoTitle.AutoSize = True
        Me.lnkSpoTitle.BackColor = Color.Transparent
        Me.lnkSpoTitle.Font = New Font("造字工房尚雅体演示版常规体", 12.0!)
        Me.lnkSpoTitle.ForeColor = Color.DarkTurquoise
        Me.lnkSpoTitle.LinkArea = New LinkArea(0, 0)
        Me.lnkSpoTitle.Location = New Point(15, 351)
        Me.lnkSpoTitle.Margin = New Padding(4, 0, 4, 0)
        Me.lnkSpoTitle.Name = "lnkSpoTitle"
        Me.lnkSpoTitle.Size = New Size(52, 27)
        Me.lnkSpoTitle.TabIndex = 81
        Me.lnkSpoTitle.Text = "运动"
        '
        'lnkUV
        '
        Me.lnkUV.AutoEllipsis = True
        Me.lnkUV.BackColor = Color.Transparent
        Me.lnkUV.Font = New Font("造字工房尚雅体演示版常规体", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkUV.ForeColor = Color.Turquoise
        Me.lnkUV.LinkArea = New LinkArea(0, 0)
        Me.lnkUV.Location = New Point(16, 439)
        Me.lnkUV.Margin = New Padding(4, 0, 4, 0)
        Me.lnkUV.Name = "lnkUV"
        Me.lnkUV.Size = New Size(369, 47)
        Me.lnkUV.TabIndex = 84
        Me.lnkUV.Text = "天气热，建议着短裙、短裤、短薄外套、T恤等夏季服装。"
        '
        'lnkUVTitle
        '
        Me.lnkUVTitle.AutoSize = True
        Me.lnkUVTitle.BackColor = Color.Transparent
        Me.lnkUVTitle.Font = New Font("造字工房尚雅体演示版常规体", 12.0!)
        Me.lnkUVTitle.ForeColor = Color.DarkTurquoise
        Me.lnkUVTitle.LinkArea = New LinkArea(0, 0)
        Me.lnkUVTitle.Location = New Point(15, 417)
        Me.lnkUVTitle.Margin = New Padding(4, 0, 4, 0)
        Me.lnkUVTitle.Name = "lnkUVTitle"
        Me.lnkUVTitle.Size = New Size(72, 27)
        Me.lnkUVTitle.TabIndex = 83
        Me.lnkUVTitle.Text = "紫外线"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = Color.Transparent
        Me.LinkLabel1.Font = New Font("造字工房尚雅体演示版常规体", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = Color.LightSkyBlue
        Me.LinkLabel1.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel1.Location = New Point(250, 93)
        Me.LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New Size(76, 27)
        Me.LinkLabel1.TabIndex = 85
        Me.LinkLabel1.Text = "风力  :  "
        '
        'lnkWind
        '
        Me.lnkWind.AutoSize = True
        Me.lnkWind.BackColor = Color.Transparent
        Me.lnkWind.Font = New Font("造字工房尚雅体演示版常规体", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.lnkWind.ForeColor = Color.Cornsilk
        Me.lnkWind.LinkArea = New LinkArea(0, 0)
        Me.lnkWind.Location = New Point(249, 116)
        Me.lnkWind.Margin = New Padding(4, 0, 4, 0)
        Me.lnkWind.Name = "lnkWind"
        Me.lnkWind.Size = New Size(65, 34)
        Me.lnkWind.TabIndex = 86
        Me.lnkWind.Text = "微风"
        '
        'frmDetail
        '
        Me.AutoScaleDimensions = New SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = bg_wdtb
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(401, 493)
        Me.Controls.Add(Me.lnkVer)
        Me.Controls.Add(Me.lnkPM)
        Me.Controls.Add(Me.lnkWind)
        Me.Controls.Add(Me.LinkLabel8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lnkUV)
        Me.Controls.Add(Me.lnkUVTitle)
        Me.Controls.Add(Me.lnkSpo)
        Me.Controls.Add(Me.lnkSpoTitle)
        Me.Controls.Add(Me.lnkSic)
        Me.Controls.Add(Me.lnkSicTitle)
        Me.Controls.Add(Me.lnkCar)
        Me.Controls.Add(Me.lnkCarTitle)
        Me.Controls.Add(Me.lnkClo)
        Me.Controls.Add(Me.lnkCloTitle)
        Me.Controls.Add(Me.lnkCity)
        Me.Controls.Add(Me.lnkCopy)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.picTitleBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Margin = New Padding(4, 3, 4, 3)
        Me.Name = "frmDetail"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "frmDetail"
        Me.TopMost = True
        CType(Me.picTitleBack, ISupportInitialize).EndInit()
        CType(Me.picClose, ISupportInitialize).EndInit()
        CType(Me.picTitle, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTitleBack As PictureBox
    Friend WithEvents lnkCopy As LinkLabel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents lnkVer As LinkLabel
    Friend WithEvents picTitle As PictureBox
    Friend WithEvents lnkCity As LinkLabel
    Friend WithEvents lnkCloTitle As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents lnkPM As LinkLabel
    Friend WithEvents lnkClo As LinkLabel
    Friend WithEvents lnkCar As LinkLabel
    Friend WithEvents lnkCarTitle As LinkLabel
    Friend WithEvents lnkSic As LinkLabel
    Friend WithEvents lnkSicTitle As LinkLabel
    Friend WithEvents lnkSpo As LinkLabel
    Friend WithEvents lnkSpoTitle As LinkLabel
    Friend WithEvents lnkUV As LinkLabel
    Friend WithEvents lnkUVTitle As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lnkWind As LinkLabel
End Class
