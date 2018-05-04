Imports System.Drawing.Text

Module Module2
    Public Sub FontLoad()
        Dim fontclTiaofu = New PrivateFontCollection()
        Dim fontclShangya = New PrivateFontCollection()
        Dim fontclYayuan = New PrivateFontCollection()
        fontclTiaofu.AddFontFile(Application.StartupPath + "\fonts\tiaofu.ttf")
        fontclShangya.AddFontFile(Application.StartupPath + "\fonts\shangya.ttf")
        fontclYayuan.AddFontFile(Application.StartupPath + "\fonts\yayuan.otf")

        frmShow.LinkLabel3.Font = New Font(fontclTiaofu.Families(0).Name, 13.5, FontStyle.Regular, GraphicsUnit.Point, 1)
        frmShow.LinkLabel3.Font = New Font(fontclYayuan.Families(0).Name, 13, FontStyle.Regular, GraphicsUnit.Point, 1)
        frmSetting.LinkLabel10.Font = New Font(fontclYayuan.Families(0).Name, 9, FontStyle.Regular, GraphicsUnit.Point,
                                               134)
        frmSetting.LinkLabel1.Font = New Font(fontclYayuan.Families(0).Name, 12.75, FontStyle.Regular,
                                              GraphicsUnit.Point, 134)
        frmSetting.LinkLabel2.Font = New Font(fontclTiaofu.Families(0).Name, 14.25, FontStyle.Regular,
                                              GraphicsUnit.Point, 134)
        frmSetting.LinkLabel3.Font = New Font(fontclTiaofu.Families(0).Name, 14.25, FontStyle.Regular,
                                              GraphicsUnit.Point, 134)
        frmSetting.CheckBox1.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                             134)
        frmSetting.CheckBox2.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                             134)
        frmSetting.TextBox1.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                            134)
        frmSetting.ComboBox1.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                             134)
        frmSetting.LinkLabel5.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmSetting.LinkLabel7.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmSetting.LinkLabel9.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmSetting.radBaiduapi.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                               1)
        frmSetting.radJuhe.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point, 1)
        frmSetting.LinkLabel4.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmSetting.LinkLabel8.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmMsg.LinkLabel1.Font = New Font(fontclTiaofu.Families(0).Name, 14.25, FontStyle.Regular, GraphicsUnit.Point, 1)
        frmMsg.LinkLabel2.Font = New Font(fontclYayuan.Families(0).Name, 14.25, FontStyle.Regular, GraphicsUnit.Point, 1)
        frmMsg.LinkLabel3.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkVer.Font = New Font(fontclYayuan.Families(0).Name, 12.75, FontStyle.Regular, GraphicsUnit.Point,
                                         134)
        frmDetail.lnkCopy.Font = New Font(fontclYayuan.Families(0).Name, 9, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkCity.Font = New Font(fontclTiaofu.Families(0).Name, 29.25, FontStyle.Regular, GraphicsUnit.Point,
                                          134)
        frmDetail.LinkLabel8.Font = New Font(fontclYayuan.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                             134)
        frmDetail.lnkPM.Font = New Font(fontclYayuan.Families(0).Name, 18, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkCarTitle.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmDetail.lnkCloTitle.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmDetail.lnkSicTitle.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmDetail.lnkUVTitle.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                             1)
        'frmDetail.lnkTraTitle.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point, 1)
        frmDetail.lnkSpoTitle.Font = New Font(fontclShangya.Families(0).Name, 12, FontStyle.Regular, GraphicsUnit.Point,
                                              1)
        frmDetail.lnkCar.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkClo.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkSic.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkUV.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
        'frmDetail.lnkTra.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
        frmDetail.lnkSpo.Font = New Font(fontclShangya.Families(0).Name, 10, FontStyle.Regular, GraphicsUnit.Point, 134)
    End Sub

    Public Sub LocalUpdate()
        If toddaypic = "http://api.map.baidu.com/images/weather/day/qing.png" Then
            frmMain.BackgroundImage = My.Resources.晴
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/yin.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/duoyun.png" Then
            frmMain.BackgroundImage = My.Resources.阴
        End If
        If toddaypic = "http://api.map.baidu.com/images/weather/day/yinyu.png" Then
            frmMain.BackgroundImage = My.Resources.阴雨
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/xiaoyu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/zhenyu.png" Then
            frmMain.BackgroundImage = My.Resources.小雨
        End If
        If toddaypic = "http://api.map.baidu.com/images/weather/day/zhongyu.png" Then
            frmMain.BackgroundImage = My.Resources.中雨
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/dayu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/baoyu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/dabaoyu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/tedabaoyu.png" Then
            frmMain.BackgroundImage = My.Resources.大雨
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/zhenxue.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/xiaoxue.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/zhongxue.png" Then
            frmMain.BackgroundImage = My.Resources.雪
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/daxue.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/baoxue.png" Then
            frmMain.BackgroundImage = My.Resources.暴雪
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/qiangshachenbao.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/shachenbao.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/wu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/mai.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/fuchen.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/yangsha.png" Then
            frmMain.BackgroundImage = My.Resources.雾
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/dongyu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/yujiaxue.png" Then
            frmMain.BackgroundImage = My.Resources.雨夹雪
        End If
        If _
            toddaypic = "http://api.map.baidu.com/images/weather/day/leizhenyu.png" Or
            toddaypic = "http://api.map.baidu.com/images/weather/day/leizhenyubanyoubingbao.png" Then
            frmMain.BackgroundImage = My.Resources.雷阵雨
        End If
        If toddaypic = Nothing Then
            frmMain.BackgroundImage = My.Resources.N1
        End If

        If TimeOfDay.Hour <= 18 Then
            If toddaypic = "http://api.map.baidu.com/images/weather/day/qing.png" Then
                frmShow.PictureBox2.Image = My.Resources.晴
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/yin.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/duoyun.png" Then
                frmShow.PictureBox2.Image = My.Resources.日多云
            End If
            If toddaypic = "http://api.map.baidu.com/images/weather/day/yinyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.阴雨
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/xiaoyu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/zhenyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.小雨
            End If
            If toddaypic = "http://api.map.baidu.com/images/weather/day/zhongyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.中雨
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/dayu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/baoyu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/dabaoyu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/tedabaoyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.大雨
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/zhenxue.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/xiaoxue.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/zhongxue.png" Then
                frmShow.PictureBox2.Image = My.Resources.日雪
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/daxue.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/baoxue.png" Then
                frmShow.PictureBox2.Image = My.Resources.暴雪
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/qiangshachenbao.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/shachenbao.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/wu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/mai.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/fuchen.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/yangsha.png" Then
                frmShow.PictureBox2.Image = My.Resources.雾
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/dongyu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/yujiaxue.png" Then
                frmShow.PictureBox2.Image = My.Resources.雨夹雪
            End If
            If _
                toddaypic = "http://api.map.baidu.com/images/weather/day/leizhenyu.png" Or
                toddaypic = "http://api.map.baidu.com/images/weather/day/leizhenyubanyoubingbao.png" Then
                frmShow.PictureBox2.Image = My.Resources.雷阵雨
            End If

            If tomdaypic = "http://api.map.baidu.com/images/weather/day/qing.png" Then
                frmShow.PictureBox3.Image = My.Resources.晴
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/yin.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/duoyun.png" Then
                frmShow.PictureBox3.Image = My.Resources.日多云
            End If
            If tomdaypic = "http://api.map.baidu.com/images/weather/day/yinyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.阴雨
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/xiaoyu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/zhenyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.小雨
            End If
            If tomdaypic = "http://api.map.baidu.com/images/weather/day/zhongyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.中雨
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/dayu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/baoyu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/dabaoyu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/tedabaoyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.大雨
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/zhenxue.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/xiaoxue.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/zhongxue.png" Then
                frmShow.PictureBox3.Image = My.Resources.日雪
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/daxue.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/baoxue.png" Then
                frmShow.PictureBox3.Image = My.Resources.暴雪
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/qiangshachenbao.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/shachenbao.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/wu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/mai.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/fuchen.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/yangsha.png" Then
                frmShow.PictureBox3.Image = My.Resources.雾
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/dongyu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/yujiaxue.png" Then
                frmShow.PictureBox3.Image = My.Resources.雨夹雪
            End If
            If _
                tomdaypic = "http://api.map.baidu.com/images/weather/day/leizhenyu.png" Or
                tomdaypic = "http://api.map.baidu.com/images/weather/day/leizhenyubanyoubingbao.png" Then
                frmShow.PictureBox3.Image = My.Resources.雷阵雨
            End If

        ElseIf TimeOfDay.Hour > 18 Then
            If todevepic = "http://api.map.baidu.com/images/weather/night/qing.png" Then
                frmShow.PictureBox2.Image = My.Resources.夜晴
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/yin.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/duoyun.png" Then
                frmShow.PictureBox2.Image = My.Resources.夜多云
            End If
            If todevepic = "http://api.map.baidu.com/images/weather/night/yinyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.阴雨
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/xiaoyu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/zhenyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.夜雨1
            End If
            If todevepic = "http://api.map.baidu.com/images/weather/night/zhongyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.中雨
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/dayu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/baoyu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/dabaoyu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/tedabaoyu.png" Then
                frmShow.PictureBox2.Image = My.Resources.大雨
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/zhenxue.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/xiaoxue.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/zhongxue.png" Then
                frmShow.PictureBox2.Image = My.Resources.夜雪
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/daxue.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/baoxue.png" Then
                frmShow.PictureBox2.Image = My.Resources.暴雪
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/qiangshachenbao.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/shachenbao.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/wu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/mai.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/fuchen.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/yangsha.png" Then
                frmShow.PictureBox2.Image = My.Resources.雾
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/dongyu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/yujiaxue.png" Then
                frmShow.PictureBox2.Image = My.Resources.雨夹雪
            End If
            If _
                todevepic = "http://api.map.baidu.com/images/weather/night/leizhenyu.png" Or
                todevepic = "http://api.map.baidu.com/images/weather/night/leizhenyubanyoubingbao.png" Then
                frmShow.PictureBox2.Image = My.Resources.夜雷阵雨
            End If

            If tomevepic = "http://api.map.baidu.com/images/weather/night/qing.png" Then
                frmShow.PictureBox3.Image = My.Resources.夜晴
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/yin.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/duoyun.png" Then
                frmShow.PictureBox3.Image = My.Resources.夜多云
            End If
            If tomevepic = "http://api.map.baidu.com/images/weather/night/yinyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.阴雨
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/xiaoyu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/zhenyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.夜雨1
            End If
            If tomevepic = "http://api.map.baidu.com/images/weather/night/zhongyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.中雨
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/dayu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/baoyu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/dabaoyu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/tedabaoyu.png" Then
                frmShow.PictureBox3.Image = My.Resources.大雨
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/zhenxue.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/xiaoxue.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/zhongxue.png" Then
                frmShow.PictureBox3.Image = My.Resources.夜雪
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/daxue.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/baoxue.png" Then
                frmShow.PictureBox3.Image = My.Resources.暴雪
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/qiangshachenbao.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/shachenbao.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/wu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/mai.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/fuchen.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/yangsha.png" Then
                frmShow.PictureBox3.Image = My.Resources.雾
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/dongyu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/yujiaxue.png" Then
                frmShow.PictureBox3.Image = My.Resources.雨夹雪
            End If
            If _
                tomevepic = "http://api.map.baidu.com/images/weather/night/leizhenyu.png" Or
                tomevepic = "http://api.map.baidu.com/images/weather/night/leizhenyubanyoubingbao.png" Then
                frmShow.PictureBox3.Image = My.Resources.夜雷阵雨
            End If
        End If

        If todevepic = Nothing And tomevepic = Nothing Then
            frmShow.PictureBox3.Image = My.Resources.N1
            frmShow.PictureBox2.Image = My.Resources.N1
            frmShow.LinkLabel3.Text = "No Data"
            frmShow.LinkLabel4.Text = "No Data"
        End If

        frmShow.LinkLabel1.Text = nowtemp + "  |  " + todtemp
        frmShow.LinkLabel2.Text = tomtemp
        frmShow.LinkLabel3.Text = todweather
        frmShow.LinkLabel4.Text = tomweather

        frmDetail.lnkCity.Text = strSetLoc

        frmDetail.lnkWind.Text = strWind

        frmDetail.lnkCloTitle.Text = "穿衣 · " + strCloDs
        frmDetail.lnkClo.Text = strClo
        frmDetail.lnkCarTitle.Text = "洗车 · " + strCarDs
        frmDetail.lnkCar.Text = strCar
        'frmDetail.lnkTraTitle.Text = "旅游 · " + strTraDS
        'frmDetail.lnkTra.Text = strTra
        frmDetail.lnkSicTitle.Text = "感冒 · " + strSicDs
        frmDetail.lnkSic.Text = strSic
        frmDetail.lnkSpoTitle.Text = "运动 · " + strSpoDS
        frmDetail.lnkSpo.Text = strSpo
        frmDetail.lnkUVTitle.Text = "紫外线 · " + strUVDs
        frmDetail.lnkUV.Text = strUV

        If intPM < 50 Then
            frmDetail.lnkPM.Text = intPM.ToString + " · 优"
            frmDetail.lnkPM.ForeColor = Color.LightGreen
        ElseIf intPM < 100 Then
            frmDetail.lnkPM.Text = intPM.ToString + " · 良"
            frmDetail.lnkPM.ForeColor = Color.Yellow
        ElseIf intPM < 150 Then
            frmDetail.lnkPM.Text = intPM.ToString + " · 轻度"
            frmDetail.lnkPM.ForeColor = Color.Orange
        ElseIf intPM < 200 Then
            frmDetail.lnkPM.Text = intPM.ToString + " · 中度"
            frmDetail.lnkPM.ForeColor = Color.Red
        ElseIf intPM < 300 Then
            frmDetail.lnkPM.Text = intPM.ToString + " · 重度"
            frmDetail.lnkPM.ForeColor = Color.Purple
        ElseIf intPM > 300 Then
            frmDetail.lnkPM.Text = intPM.ToString + " · 严重污染"
            frmDetail.lnkPM.ForeColor = Color.RosyBrown
        End If
    End Sub

    Public Sub CheckUI(ui As Object)
        If ui.Checked = True Then
            ui.ForeColor = Color.SandyBrown
        Else : ui.ForeColor = Color.DarkGray
        End If
    End Sub
End Module
