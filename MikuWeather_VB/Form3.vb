Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json.Linq

Public Class FrmMain
    Inherits Form

    Dim _intScreenY As Integer
    ReadOnly _xmlSetFile As New XmlDocument
    Dim _xmlnSetMain As XmlNode
    Dim _xmlnsSetMain, _xmlnsSetSet As XmlNodeList

    Dim _joLoc As JObject


    Private Sub Form3_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        frmShow.SetBounds(Location.X - 90, Location.Y - 193, 349, 196)
        frmShow.Show()
    End Sub

    Private Sub Form3_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        frmShow.SetBounds(Location.X - 90, Location.Y - 193, 349, 196)
        frmShow.Show()
    End Sub

    Private Sub Form3_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        frmShow.Close()
        frmShow.Dispose()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point
            mousePos = sender.findform().MousePosition
            mousePos.Y = _intScreenY - Size.Height + 16
            If (Location.X > Screen.PrimaryScreen.WorkingArea.Width - 272 Or Location.X < 100) = False Then
                sender.findform().Location = mousePos
            End If

            If Location.X > Screen.PrimaryScreen.WorkingArea.Width - 272 Then
                SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272, _intScreenY - Size.Height + 16, Size.Width,
                          Size.Height)
            End If

            If Location.X < 100 Then
                SetBounds(100, _intScreenY - Size.Height + 16, Size.Width, Size.Height)
            End If
        End If
    End Sub

    Private Shared Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        End
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetWeatherData()
        ' ReSharper disable once LocalizableElement
        NotifyIcon1.Text = "您忙了好久了，歇会吧~ 天气都给您更新好啦！"
    End Sub

    Private Sub 暂时去托盘躲躲啊ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuHide.Click
        Hide()
        ' ReSharper disable once LocalizableElement
        NotifyIcon1.BalloonTipText = "Miku到这了哟~ 要叫我就直接双击"
        NotifyIcon1.ShowBalloonTip(700)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Show()
        ' ReSharper disable once LocalizableElement
        NotifyIcon1.BalloonTipText = "Miku出来啦~~"
        NotifyIcon1.ShowBalloonTip(700)
    End Sub

    Private Shared Sub 给我去更新天气ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuUpdate.Click
        GetWeatherData()
    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuSet.Click
        frmSetting.Show()
        Close()
    End Sub

    Private Shared Sub MikuWeathrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuWebsite.Click
        Process.Start("https://github.com/RainySummerLuo/MikuWeather_Windows")
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmMain1 As FrmMain = Me
        'If My.Computer.Screen.BitsPerPixel >= 32 Then
        frmMain1.BackColor = Color.FloralWhite
        'ElseIf My.Computer.Screen.BitsPerPixel >= 16 And My.Computer.Screen.BitsPerPixel < 32 Then
        'Me.BackColor = Color.White
        'End If
        frmMain1.TransparencyKey = frmMain1.BackColor

        _intScreenY = Screen.PrimaryScreen.WorkingArea.Bottom

        frmMain1.SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272,
                           frmMain1._intScreenY - frmMain1.Size.Height + 16,
                           frmMain1.Size.Width, frmMain1.Size.Height)

        frmMain1.Icon = My.Resources.hi

        FrmShow.PictureBox2.BackColor = Color.Transparent
        FrmShow.PictureBox2.Parent = FrmShow
        FrmShow.PictureBox3.BackColor = Color.Transparent
        FrmShow.PictureBox3.Parent = FrmShow

        Try
            If StrSetAddr = Nothing Then
                If File.Exists(Application.StartupPath + "\set.xml") = True Then
                    _xmlSetFile.Load(Application.StartupPath + "\set.xml")
                    StrSetAddr = Application.StartupPath + "\set.xml"
                Else
                    ' StrMsg = "没能找到设置文件欸！请一定要放在和程序同一个文件夹下。"
                    ' StrMsgTitle = "Miku似乎遇到麻烦了！"
                    ' frmMsg.Show()
                    End
                End If
            Else : _xmlSetFile.Load(StrSetAddr)
            End If

            _xmlnsSetMain = _xmlSetFile.ChildNodes
            _xmlnSetMain = _xmlnsSetMain.ItemOf(1)
            _xmlnsSetSet = _xmlnSetMain.ChildNodes

            StrSetLoc = _xmlnsSetSet.ItemOf(0).InnerText
            IntSetIntv = _xmlnsSetSet.ItemOf(1).InnerText

            LinkLabel2.Text = StrSetLoc
            Timer1.Interval = IntSetIntv

            If _xmlnsSetSet.ItemOf(3).InnerText = "1" Then
                Using iplocWebc As New WebClient
                    iplocWebc.Encoding = Encoding.Default
                    _joLoc =
                        JObject.Parse(
                            iplocWebc.DownloadString("http://api.map.baidu.com/location/ip?ak=edUWu66ddGavrmj9a6vcsa75"))
                End Using
                If _joLoc.SelectToken("status").ToString = "0" Then
                    BlnAutoIpLoc = True
                    BlnIpSer = True
                Else
                    BlnAutoIpLoc = False
                    BlnIpSer = False
                    StrMsgTitle = "IP定位服务错误"
                    StrMsg = "Miku无法获取您的位置信息，自动定位。错误信息：error code = " + _joLoc.SelectToken("status").ToString
                    FrmMsg.Show()
                End If
            End If

            GetWeatherData()

        Catch ex As WebException
            StrMsgTitle = "Miku似乎遇到麻烦了！"
            StrMsg = "您的好像网络坏掉了o(>﹏<)o！frmMain异常：" + ex.Message
            FrmMsg.Show()
        Catch ex As Exception
            StrMsgTitle = "Miku似乎遇到麻烦了！"
            StrMsg = "frmMain异常：" + ex.Message
            FrmMsg.Show()
        End Try
    End Sub

    Private Sub 天气详情ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 天气详情ToolStripMenuItem.Click
        frmDetail.Show()
    End Sub
End Class