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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmMain))
        Me.ContextMenuStrip1 = New ContextMenuStrip(Me.components)
        Me.menuWebsite = New ToolStripMenuItem()
        Me.menuUpdate = New ToolStripMenuItem()
        Me.天气详情ToolStripMenuItem = New ToolStripMenuItem()
        Me.menuSet = New ToolStripMenuItem()
        Me.menuHide = New ToolStripMenuItem()
        Me.menuExit = New ToolStripMenuItem()
        Me.NotifyIcon1 = New NotifyIcon(Me.components)
        Me.Timer1 = New Timer(Me.components)
        Me.LinkLabel2 = New LinkLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = SystemColors.Control
        Me.ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New ToolStripItem() {Me.menuWebsite, Me.menuUpdate, Me.天气详情ToolStripMenuItem, Me.menuSet, Me.menuHide, Me.menuExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New Size(215, 176)
        '
        'menuWebsite
        '
        Me.menuWebsite.Name = "menuWebsite"
        Me.menuWebsite.Size = New Size(214, 24)
        Me.menuWebsite.Text = "Miku Weather 官网"
        '
        'menuUpdate
        '
        Me.menuUpdate.Name = "menuUpdate"
        Me.menuUpdate.Size = New Size(214, 24)
        Me.menuUpdate.Text = "更新数据！"
        '
        '天气详情ToolStripMenuItem
        '
        Me.天气详情ToolStripMenuItem.Name = "天气详情ToolStripMenuItem"
        Me.天气详情ToolStripMenuItem.Size = New Size(214, 24)
        Me.天气详情ToolStripMenuItem.Text = "天气详情..."
        '
        'menuSet
        '
        Me.menuSet.Name = "menuSet"
        Me.menuSet.Size = New Size(214, 24)
        Me.menuSet.Text = "设置"
        '
        'menuHide
        '
        Me.menuHide.Name = "menuHide"
        Me.menuHide.Size = New Size(214, 24)
        Me.menuHide.Text = "隐藏到系统托盘"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New Size(214, 24)
        Me.menuExit.Text = "退出"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        Me.NotifyIcon1.Text = "Miku Weather"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1800000
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = Color.Transparent
        Me.LinkLabel2.Font = New Font("条幅黑体", 16.2!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel2.LinkArea = New LinkArea(0, 0)
        Me.LinkLabel2.Location = New Point(60, 20)
        Me.LinkLabel2.Margin = New Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New Size(164, 31)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.Text = "广州"
        Me.LinkLabel2.TextAlign = ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.Snow
        Me.BackgroundImage = My.Resources.Resources.N1
        Me.BackgroundImageLayout = ImageLayout.Zoom
        Me.ClientSize = New Size(223, 211)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.LinkLabel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Margin = New Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "frmMain"
        Me.TopMost = True
        Me.TransparencyKey = Color.Snow
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
