using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MikuWeather.Properties;

namespace MikuWeather {

    public partial class Form1 : Form {

        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private readonly FormShow _frmShow = new FormShow();

        private string _city;
        private string _coor;
        private DateTime _sunrise;
        private DateTime _sunset;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackColor = Color.Honeydew;
            TransparencyKey = BackColor;
            _frmShow.BackColor = Color.Honeydew;
            _frmShow.TransparencyKey = _frmShow.BackColor;

            var intScreenY = Screen.PrimaryScreen.WorkingArea.Bottom;
            SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272,
                intScreenY - Size.Height + 13,
                Size.Width, Size.Height);
            var dictLocation = DataQuery.GetLocation();
            _city = dictLocation["city"];
            _coor = dictLocation["coor"];
            var dictAstro = DataQuery.GetAstro_Caiyun(_coor);
            var sunrise = dictAstro["sunrise"];
            var sunset = dictAstro["sunset"];
            _sunrise = DateTime.ParseExact(sunrise, "HH:mm", CultureInfo.CurrentCulture);
            _sunset = DateTime.ParseExact(sunset, "HH:mm", CultureInfo.CurrentCulture);
            Update();
        }

        private void Form1_MouseHover(object sender, EventArgs e) {
            _frmShow.SetBounds(Location.X - _frmShow.Width / 2 + Width / 2 - 15,
                Location.Y - _frmShow.Height,
                _frmShow.Width,
                _frmShow.Height);
            _frmShow.Show();
        }

        private void Form1_MouseLeave(object sender, EventArgs e) {
            _frmShow.Hide();
        }

        private void CmWebsite_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/RainySummerLuo/MikuWeather_Windows");
        }

        private void CmExit_Click(object sender, EventArgs e) {
            Close();
            Environment.Exit(0);
        }

        private void CmUpdate_Click(object sender, EventArgs e) {
            Update();
        }

        private new void Update() {
            var provider = ConfigurationManager.AppSettings["provider"];
            Dictionary<string, string> dict;
            Bitmap todayPic;
            Bitmap tomorrowPic;
            string todayPicUrl;
            string tomorrowPicUrl;
            var nowDt = DateTime.Now;
            switch (provider)
            {
                case "baidu":
                    bool isDay;
                    dict = DataQuery.UpdateData_Baidu(_city);
                    if (nowDt >= _sunrise && nowDt < _sunset)
                    {
                        todayPicUrl = dict["today day pic url"];
                        tomorrowPicUrl = dict["tomorrow day pic url"];
                        isDay = true;
                    }
                    else
                    {
                        todayPicUrl = dict["today night pic url"];
                        tomorrowPicUrl = dict["tomorrow night pic url"];
                        isDay = false;
                    }
                    var todayPicUrlSplit = todayPicUrl.Split('/');
                    var todayPicName = todayPicUrlSplit[todayPicUrlSplit.Length - 1];
                    todayPic = SwitchBaiduPic(todayPicName, isDay);
                    var tomorrowPicUrlSplit = tomorrowPicUrl.Split('/');
                    var tomorrowPicName = tomorrowPicUrlSplit[tomorrowPicUrlSplit.Length - 1];
                    tomorrowPic = SwitchBaiduPic(tomorrowPicName, isDay);
                    break;
                case "caiyun":
                    dict = DataQuery.UpdateData_Caiyun(_coor);
                    var todayWeather = dict["today pic"];
                    var tomorrowWeather = dict["tomorrow pic"];
                    break;
                default:
                    return;
            }
            _frmShow.SetTemp(dict["today temp"], dict["tomorrow temp"]);
            _frmShow.SetWeather(dict["today weather"], dict["tomorrow weather"]);
            _frmShow.SetPic(todayPic, tomorrowPic);
            picBox.Image = bitmapPic;
        }

        private string SwitchCaiyun(string weather)
        {
            switch (weather)
            {
                case "CLEAR_DAY":
                case "CLEAR_NIGHT":
                    return "晴";
                case "PARTLY_CLOUDY_DAY":
                case "PARTLY_CLOUDY_NIGHT":
                    return "多云";
                case "CLOUDY":
                    return "阴";
                case "WIND":
                    return "大风";
                case "HAZE":
                    return "雾霾";
                case "RAIN":
                    return "雨";
                case "SNOW":
                    return "雪";
            }
            return null;
        }

        private Bitmap SwitchBaiduPic(string picName, bool isDay) {
            if (isDay) {
                switch (picName) {
                    case "qing.png":
                        return Resources.晴_日;

                    case "duoyun.png":
                        return Resources.多云_日;

                    case "xiaoyu.png":
                    case "zhenyu.png":
                        return Resources.雨_日;

                    case "zhenxue.png":
                    case "xiaoxue.png":
                    case "zhongxue.png":
                        return Resources.雪_日;

                    case "leizhenyu.png":
                    case "leizhenyubanyoubingbao.png":
                        return Resources.雷阵雨_日;
                }
            } else {
                switch (picName) {
                    case "qing.png":
                        return Resources.晴_夜;

                    case "duoyun.png":
                        return Resources.多云_夜;

                    case "xiaoyu.png":
                    case "zhenyu.png":
                        return Resources.雨_夜;

                    case "zhenxue.png":
                    case "xiaoxue.png":
                    case "zhongxue.png":
                        return Resources.雪_夜;

                    case "leizhenyu.png":
                    case "leizhenyubanyoubingbao.png":
                        return Resources.雷阵雨_夜;
                }
            }
            switch (picName) {
                case "yin.png":
                    return Resources.阴;

                case "yinyu.png":
                    return Resources.阴雨;

                case "zhongyu.png":
                    return Resources.中雨;

                case "dayu.png":
                case "baoyu.png":
                case "dabaoyu.png":
                case "tedabaoyu.png":
                    return Resources.大雨;

                case "daxue.png":
                case "baoxue.png":
                    return Resources.暴雪;

                case "qiangshachenbao.png":
                case "shachenbao.png":
                case "wu.png":
                case "mai.png":
                case "fuchen.png":
                case "yangsha.png":
                    return Resources.雾;

                case "dongyu.png":
                case "yujiaxue.png":
                    return Resources.雨夹雪;
            }
            return null;
        }
    }
}