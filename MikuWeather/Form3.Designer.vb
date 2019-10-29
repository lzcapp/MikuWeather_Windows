Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.天气详情ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuWebsite, Me.menuUpdate, Me.天气详情ToolStripMenuItem, Me.menuSet, Me.menuHide, Me.menuExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(187, 136)
        '
        'menuWebsite
        '
        Me.menuWebsite.Name = "menuWebsite"
        Me.menuWebsite.Size = New System.Drawing.Size(186, 22)
        Me.menuWebsite.Text = "Miku Weather 官网"
        '
        'menuUpdate
        '
        Me.menuUpdate.Name = "menuUpdate"
        Me.menuUpdate.Size = New System.Drawing.Size(186, 22)
        Me.menuUpdate.Text = "更新数据！"
        '
        '天气详情ToolStripMenuItem
        '
        Me.天气详情ToolStripMenuItem.Name = "天气详情ToolStripMenuItem"
        Me.天气详情ToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.天气详情ToolStripMenuItem.Text = "天气详情..."
        '
        'menuSet
        '
        Me.menuSet.Name = "menuSet"
        Me.menuSet.Size = New System.Drawing.Size(186, 22)
        Me.menuSet.Text = "设置"
        '
        'menuHide
        '
        Me.menuHide.Name = "menuHide"
        Me.menuHide.Size = New System.Drawing.Size(186, 22)
        Me.menuHide.Text = "隐藏到系统托盘"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(186, 22)
        Me.menuExit.Text = "退出"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Miku Weather"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1800000
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("条幅黑体", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel2.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LinkLabel2.Location = New System.Drawing.Point(45, 15)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(123, 23)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.Text = "广州"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.BackgroundImage = Global.MikuWeather.My.Resources.Resources.N1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(167, 158)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.LinkLabel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMain"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmMain"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Snow
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents menuWebsite As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuHide As ToolStripMenuItem
    Friend WithEvents menuUpdate As ToolStripMenuItem
    Friend WithEvents menuSet As ToolStripMenuItem
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents 天气详情ToolStripMenuItem As ToolStripMenuItem
End Class
