using MikuWeather.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MikuWeather {

    public partial class FormShow : Form {

        public FormShow() {
            InitializeComponent();
        }

        public void SetTemp(string todayTemp, string tomorrowTemp) {
            lnkTodayTemp.Text = todayTemp;
            lnkTomorrowTemp.Text = tomorrowTemp;
        }

        public void SetWeather(string todayWeather, string tomorrowWeather) {
            lnkTodayWeather.Text = todayWeather;
            lnkTomorrowWeather.Text = tomorrowWeather;
        }

        public Bitmap SetPic(string todayDayPicUrl, string todayNightPicUrl, string tomorrowDayPicUrl, string tomorrowNightPicUrl) {
            bool isDay;
            var hour = DateTime.Now.Hour;
            string todayPicUrl;
            string tomorrowPicUrl;
            if (hour < 18 && hour >= 6) {
                todayPicUrl = todayDayPicUrl;
                tomorrowPicUrl = tomorrowDayPicUrl;
                isDay = true;
            } else {
                todayPicUrl = todayNightPicUrl;
                tomorrowPicUrl = tomorrowNightPicUrl;
                isDay = false;
            }
            var todayPicUrlSplit = todayPicUrl.Split('/');
            var todayPicName = todayPicUrlSplit[todayPicUrlSplit.Length - 1];
            var tomorrowPicUrlSplit = tomorrowPicUrl.Split('/');
            var tomorrowPicName = tomorrowPicUrlSplit[tomorrowPicUrlSplit.Length - 1];
            var bitmapToday = SwitchPic(todayPicName, isDay);
            picToday.Image = bitmapToday;
            picTomorrow.Image = SwitchPic(tomorrowPicName, isDay);
            return bitmapToday;
        }

        private static Bitmap SwitchPic(string picName, bool isDay) {
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