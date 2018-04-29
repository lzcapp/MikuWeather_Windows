<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.天气详情ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuWebsite, Me.menuUpdate, Me.天气详情ToolStripMenuItem, Me.menuSet, Me.关于ToolStripMenuItem, Me.menuHide, Me.menuExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 172)
        '
        'menuWebsite
        '
        Me.menuWebsite.Name = "menuWebsite"
        Me.menuWebsite.Size = New System.Drawing.Size(210, 24)
        Me.menuWebsite.Text = "Miku Weather官网"
        '
        'menuUpdate
        '
        Me.menuUpdate.Name = "menuUpdate"
        Me.menuUpdate.Size = New System.Drawing.Size(210, 24)
        Me.menuUpdate.Text = "更新数据！"
        '
        '天气详情ToolStripMenuItem
        '
        Me.天气详情ToolStripMenuItem.Name = "天气详情ToolStripMenuItem"
        Me.天气详情ToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.天气详情ToolStripMenuItem.Text = "天气详情..."
        '
        'menuSet
        '
        Me.menuSet.Name = "menuSet"
        Me.menuSet.Size = New System.Drawing.Size(210, 24)
        Me.menuSet.Text = "设置"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'menuHide
        '
        Me.menuHide.Name = "menuHide"
        Me.menuHide.Size = New System.Drawing.Size(210, 24)
        Me.menuHide.Text = "隐藏到系统托盘"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(210, 24)
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
        Me.LinkLabel2.Location = New System.Drawing.Point(60, 20)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(164, 31)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.Text = "广州"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = Global.FloatingWindow.My.Resources.Resources.N1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(223, 211)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.LinkLabel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
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
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuWebsite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents menuHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents 天气详情ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
