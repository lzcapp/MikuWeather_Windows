Imports System.Xml
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class frmMain
    Inherits System.Windows.Forms.Form

    Dim intScreenY As Integer
    Dim xmlSetFile As New XmlDocument
    Dim xmlnSetMain As XmlNode
    Dim xmlnsSetMain, xmlnsSetSet As XmlNodeList

    Private mp As Point

    Dim joLoc, joWeather As JObject


    Private Sub Form3_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        frmShow.SetBounds(Me.Location.X - 90, Me.Location.Y - 193, 349, 196)
        frmShow.Show()
    End Sub

    Private Sub Form3_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        frmShow.SetBounds(Me.Location.X - 90, Me.Location.Y - 193, 349, 196)
        frmShow.Show()
    End Sub

    Private Sub Form3_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        frmShow.Close()
        frmShow.Dispose()
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs)
        frmShow.Hide()
        frmShow.Dispose()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            'If Me.Location.X > Screen.PrimaryScreen.WorkingArea.Width - 272 And Me.Location.X < 100 Then
            Dim mousePos As Point
            mousePos = sender.findform().MousePosition
            'mousePos.Offset(-mp.X, 0)
            mousePos.Y = intScreenY - Me.Size.Height + 16
            If (Me.Location.X > Screen.PrimaryScreen.WorkingArea.Width - 272 Or Me.Location.X < 100) = False Then
                sender.findform().Location = mousePos
            End If

            If Me.Location.X > Screen.PrimaryScreen.WorkingArea.Width - 272 Then
                Me.SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272, intScreenY - Me.Size.Height + 16, Me.Size.Width, Me.Size.Height)
            End If

            If Me.Location.X < 100 Then
                Me.SetBounds(100, intScreenY - Me.Size.Height + 16, Me.Size.Width, Me.Size.Height)
            End If
        End If
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        End
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetWeatherData()
        NotifyIcon1.Text = "您忙了好久了，歇会吧~ 天气都给您更新好啦！"
    End Sub

    Private Sub 暂时去托盘躲躲啊ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuHide.Click
        Me.Hide()
        NotifyIcon1.BalloonTipText = "Miku到这了哟~ 要叫我就直接双击"
        NotifyIcon1.ShowBalloonTip(700)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.BalloonTipText = "Miku出来啦~~"
        NotifyIcon1.ShowBalloonTip(700)
    End Sub

    Private Sub 给我去更新天气ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuUpdate.Click
        GetWeatherData()
    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuSet.Click
        frmSetting.Show()
        Me.Close()
    End Sub

    Private Sub MikuWeatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuWebsite.Click
        System.Diagnostics.Process.Start("http://www.mikuweatherchina.weebly.com/")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmMain1 As frmMain = Me
        'If My.Computer.Screen.BitsPerPixel >= 32 Then
        frmMain1.BackColor = Color.Snow
        'ElseIf My.Computer.Screen.BitsPerPixel >= 16 And My.Computer.Screen.BitsPerPixel < 32 Then
        'Me.BackColor = Color.White
        'End If
        frmMain1.TransparencyKey = frmMain1.BackColor

        intScreenY = Screen.PrimaryScreen.WorkingArea.Bottom

        frmMain1.SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272, frmMain1.intScreenY - frmMain1.Size.Height + 16, frmMain1.Size.Width, frmMain1.Size.Height)

        frmMain1.Icon = My.Resources.hi

        frmShow.PictureBox2.BackColor = Color.Transparent
        frmShow.PictureBox2.Parent = frmShow
        frmShow.PictureBox3.BackColor = Color.Transparent
        frmShow.PictureBox3.Parent = frmShow

        Try
            If strSetAddr = Nothing Then
                If File.Exists(Application.StartupPath + "\set.xml") = True Then
                    xmlSetFile.Load(Application.StartupPath + "\set.xml")
                    strSetAddr = Application.StartupPath + "\set.xml"
                Else
                    StrMsg = "没能找到设置文件欸！请一定要放在和程序同一个文件夹下。"
                    StrMsgTitle = "Miku似乎遇到麻烦了！"
                    frmMsg.Show()
                    End
                End If
            Else : xmlSetFile.Load(strSetAddr)
            End If

            xmlnsSetMain = xmlSetFile.ChildNodes
            xmlnSetMain = xmlnsSetMain.ItemOf(1)
            xmlnsSetSet = xmlnSetMain.ChildNodes

            strSetLoc = xmlnsSetSet.ItemOf(0).InnerText
            intSetIntv = xmlnsSetSet.ItemOf(1).InnerText
            strSetWeather = xmlnsSetSet.ItemOf(2).InnerText
            '            intSource = xmlnsSetSet.ItemOf(4).InnerText

            LinkLabel2.Text = strSetLoc
            Timer1.Interval = intSetIntv

            '            Using weatherWebc As New WebClient
            '                weatherWebc.Encoding = Encoding.UTF8
            '                joWeather = JObject.Parse(weatherWebc.DownloadString("http://api.map.baidu.com/telematics/v3/weather?location=" + strSetLoc + "&output=json&ak=edUWu66ddGavrmj9a6vcsa75"))
            '            End Using
            '
            '            If joWeather.SelectToken("error").ToString = "0" Then
            '                blnWeatherSer = True
            '                frmSetting.CheckBox2.Enabled = True
            '            Else
            '                blnWeatherSer = False
            '                intErrCode = intErrCodeWeather
            '                ErrorCheck()
            '                StrMsgTitle = "天气数据获取失败"
            '                StrMsg = "Miku无法获取天气预报的相关数据，错误信息：error code = " + Str(intErrCode) + " /" + strErrMsg
            '                frmMsg.Show()
            '            End If

            If xmlnsSetSet.ItemOf(3).InnerText = "1" Then
                Using iplocWebc As New WebClient
                    iplocWebc.Encoding = Encoding.Default
                    joLoc = JObject.Parse(iplocWebc.DownloadString("http://api.map.baidu.com/location/ip?ak=edUWu66ddGavrmj9a6vcsa75"))
                End Using
                If joLoc.SelectToken("status").ToString = "0" Then
                    blnAutoIPLoc = True
                    blnIPSer = True
                Else
                    blnAutoIPLoc = False
                    blnIPSer = False
                    StrMsgTitle = "IP定位服务错误"
                    StrMsg = "Miku无法获取您的位置信息，自动定位。错误信息：error code = " + joLoc.SelectToken("status").ToString
                    frmMsg.Show()
                End If
            End If

            GetWeatherData()

        Catch ex As WebException
            'StrMsgTitle = "Miku似乎遇到麻烦了！"
            'StrMsg = "您的好像网络坏掉了o(>﹏<)o！frmMain异常：" + ex.Message
            'frmMsg.Show()
        Catch ex As Exception
            'StrMsgTitle = "Miku似乎遇到麻烦了！"
            'StrMsg = "frmMain异常：" + ex.Message
            'frmMsg.Show()
        End Try
    End Sub

    Private Sub 天气详情ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 天气详情ToolStripMenuItem.Click
        frmDetail.Show()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.mikuweatherchina.weebly.com/")
    End Sub
End Class