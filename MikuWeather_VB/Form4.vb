Imports System.Xml

Public Class FrmSetting
    Dim ReadOnly _setxmlform2 As New XmlDocument
    Dim _setxmlnode As XmlNode
    Dim _setxmlnodes1, _setxmlnodes2 As XmlNodeList

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel10.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        lnkVer.Parent = PictureBox1

        lnkVer.Text = "v" + Split(Application.ProductVersion, ".")(0) + "." +
                      Split(Application.ProductVersion, ".")(1) + "." + Split(Application.ProductVersion, ".")(2)

        If BlnIpSer = True Then
            'CheckBox2.Enabled = True
            If BlnAutoIpLoc = True Then
                picLoc.Image = My.Resources.loc
                CheckBox2.CheckState = CheckState.Checked
                CheckBox2.ForeColor = Color.SandyBrown
                TextBox1.Text = Iploc
            Else
                picLoc.Image = My.Resources.noloc
                CheckBox2.CheckState = CheckState.Unchecked
                CheckBox2.ForeColor = Color.DarkGray
                TextBox1.Text = StrSetLoc
            End If
        Else
            'CheckBox2.Enabled = False
            picLoc.Image = My.Resources.noloc
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox2.ForeColor = Color.DarkGray
            TextBox1.Text = StrSetLoc
        End If

        If IntSetIntv = (30*1000*60) Then
            ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
        ElseIf IntSetIntv = (60*1000*60) Then
            ComboBox1.SelectedItem = ComboBox1.Items.Item(1)
        ElseIf IntSetIntv = (90*1000*60) Then
            ComboBox1.SelectedItem = ComboBox1.Items.Item(2)
        ElseIf IntSetIntv = (120*1000*60) Then
            ComboBox1.SelectedItem = ComboBox1.Items.Item(3)
        End If

        TextBox1.BackColor = Color.FromArgb(59, 59, 59)
        ComboBox1.BackColor = Color.FromArgb(59, 59, 59)

        lnkVer.Text = "v" + Split(Application.ProductVersion, ".")(0) + "." + Split(Application.ProductVersion, ".")(1) +
                      "." + Split(Application.ProductVersion, ".")(2)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.CheckState = CheckState.Indeterminate
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckUI(CheckBox2)
        If CheckBox2.Checked = True Then
            IPLocation()
            TextBox1.Text = iploc
            picLoc.Image = My.Resources.loc
            PictureBox6.Enabled = True
            PictureBox6.Cursor = Cursors.Hand
            CheckBox2.CheckState = CheckState.Checked
            CheckBox2.ForeColor = Color.SandyBrown
        Else
            picLoc.Image = My.Resources.noloc
            PictureBox6.Enabled = False
            PictureBox6.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radBaiduapi.CheckedChanged
        CheckUI(radBaiduapi)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radJuhe.CheckedChanged
        CheckUI(radJuhe)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmMain.Close()

        Try
            If TextBox1.Text <> "" And (ComboBox1.SelectedItem = Nothing) = False Then
                StrSetLoc = TextBox1.Text
                intSetIntv = CInt(ComboBox1.SelectedItem)*1000*60
                frmMain.Timer1.Interval = intSetIntv

                _setxmlform2.Load(strSetAddr)

                _setxmlnodes1 = _setxmlform2.ChildNodes
                _setxmlnode = _setxmlnodes1.ItemOf(1)
                _setxmlnodes2 = _setxmlnode.ChildNodes

                _setxmlnodes2.ItemOf(0).InnerText = TextBox1.Text
                _setxmlnodes2.ItemOf(1).InnerText = Str(intSetIntv)

                If CheckBox2.Checked = True Then
                    blnAutoIPLoc = True
                    _setxmlnodes2.ItemOf(3).InnerText = "1"
                Else
                    blnAutoIPLoc = False
                    _setxmlnodes2.ItemOf(3).InnerText = "0"
                End If

                'If radBaiduapi.Checked = True Then
                'intSource = 0
                'setxmlnodes2.ItemOf(4).InnerText = "0"
                'End If

                'If radJuhe.Checked = True Then
                'intSource = 1
                'setxmlnodes2.ItemOf(4).InnerText = "1"
                'End If

                _setxmlform2.Save(strSetAddr)
                frmMain.Show()
                Close()
                Dispose()

            Else
                StrMsgTitle = "设置"
                StrMsg = "请一定要填好城市名,还有更新间隔啊~"
                frmMsg.Show()
                TextBox1.Text = StrSetLoc
                ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
            End If

        Catch ex As Exception
            StrMsgTitle = "Miku遇到麻烦了"
            StrMsg = "frmSetting异常：" + ex.Message
            frmMsg.Show()
        End Try
    End Sub

    Private Sub PictureBox5_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox5.DoubleClick
        frmMain.Show()
        Close()
        Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CheckBox2.Checked = False
        picLoc.Image = My.Resources.noloc
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frmMain.Show()
        Close()
        Dispose()
    End Sub

    Private Sub PictureBox7_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox7.DoubleClick
        frmMain.Show()
        Close()
        Dispose()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("http://www.mikuweather.icoc.cc/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmMain.Show()
        Close()
        Dispose()
    End Sub

    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        ToolTip1.Show("重新定位", PictureBox6)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        ToolTip1.Show("点击访问Miku Weather for Windows官网", PictureBox2)
    End Sub

    Private Sub CheckBox1_MouseHover(sender As Object, e As EventArgs) Handles CheckBox1.MouseHover
        ToolTip1.Show("由于权限限制，请您自行设置。", CheckBox1)
    End Sub

    Private Sub RadioButton2_MouseHover(sender As Object, e As EventArgs) Handles radJuhe.MouseHover
        ToolTip1.Show("功能开发中，敬请期待", radJuhe)
    End Sub
End Class