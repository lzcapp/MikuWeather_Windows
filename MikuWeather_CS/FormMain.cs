using MikuWeather.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MikuWeather {
    public partial class FormMain : Form {
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private readonly FormShow _frmShow = new FormShow();

        private string _coor;

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            var locationX = Screen.PrimaryScreen.WorkingArea.Width - 272;
            var locationY = Screen.PrimaryScreen.WorkingArea.Bottom - Size.Height - 30;
            SetBounds(
                locationX,
                locationY,
                Size.Width, Size.Height);

            var dictLocation = DataQuery.GetLocation();
            _coor = dictLocation["coor"];
            cmWebsite.Text = @"Github仓库";
            cmExit.Text = @"退出";
            UpdateData();
            TransparentForm();
        }

        private void FormMain_MouseHover(object sender, EventArgs e) {
            _frmShow.SetBounds(Location.X - _frmShow.Width / 2 + Width / 2 - 40,
                Location.Y - _frmShow.Height - 20,
                _frmShow.Width,
                _frmShow.Height);
            _frmShow.Show();
        }

        private void FormMain_MouseLeave(object sender, EventArgs e) {
            _frmShow.Hide();
        }

        private void CmWebsite_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/RainySummerLuo/MikuWeather_Windows");
        }

        private void CmExit_Click(object sender, EventArgs e) {
            Close();
            Environment.Exit(0);
        }

        private void UpdateData() {
            var nowDt = DateTime.Now;
            var dict = DataQuery.UpdateData_Caiyun(_coor);
            var todayWeather = SwitchCaiyun(dict["today pic"]);
            var tomorrowWeather = SwitchCaiyun(dict["tomorrow pic"]);
            var todayTemp = dict["today temp"];
            var tomorrowTemp = dict["tomorrow temp"];
            var sunrise = DateTime.ParseExact(dict["sunrise"], "HH:mm", CultureInfo.CurrentCulture);
            var sunset = DateTime.ParseExact(dict["sunset"], "HH:mm", CultureInfo.CurrentCulture);
            bool isDay;
            if (nowDt >= sunrise && nowDt < sunset)
                isDay = true;
            else
                isDay = false;
            var todayPic = SwitchCaiyunPic(todayWeather, isDay);
            var tomorrowPic = SwitchCaiyunPic(tomorrowWeather, isDay);

            _frmShow.SetTemp(todayTemp, tomorrowTemp);
            _frmShow.SetWeather(todayWeather, tomorrowWeather);
            _frmShow.SetPic(todayPic, tomorrowPic);
            picBox.Image = todayPic;
            picBox.Size = new Size(210, 210);
            TransparentForm();
        }

        private static string SwitchCaiyun(string weather) {
            switch (weather) {
                case "CLEAR_DAY":
                case "CLEAR_NIGHT":
                    return "晴";
                case "PARTLY_CLOUDY_DAY":
                case "PARTLY_CLOUDY_NIGHT":
                    return "多云";
                case "CLOUDY":
                    return "阴";
                case "LIGHT_HAZE":
                    return "轻度雾霾";
                case "MODERATE_HAZE":
                    return "中度雾霾";
                case "HEAVY_HAZE":
                    return "重度雾霾";
                case "LIGHT_RAIN":
                    return "小雨";
                case "MODERATE_RAIN":
                    return "中雨";
                case "HEAVY_RAIN":
                    return "大雨";
                case "STORM_RAIN":
                    return "暴雨";
                case "FOG":
                    return "雾";
                case "LIGHT_SNOW":
                    return "小雪";
                case "MODERATE_SNOW":
                    return "中雪";
                case "HEAVY_SNOW":
                    return "大雪";
                case "STORM_SNOW":
                    return "暴雪";
                case "DUST":
                    return "浮尘";
                case "SAND":
                    return "沙尘";
                case "WIND":
                    return "大风";
                default:
                    return null;
            }
        }

        private static Bitmap SwitchCaiyunPic(string weather, bool isDay) {
            if (isDay)
                switch (weather) {
                    case "晴":
                    case "大风":
                        return Resources.晴_日;
                    case "多云":
                        return Resources.多云_日;
                    case "小雨":
                        return Resources.雨_日;
                    case "中雨":
                        return Resources.中雨_日;
                    case "小雪":
                        return Resources.雪_日;
                } else
                switch (weather) {
                    case "晴":
                    case "大风":
                        return Resources.晴_夜;
                    case "多云":
                        return Resources.多云_夜;
                    case "小雨":
                        return Resources.雨_夜;
                    case "小雪":
                        return Resources.雪_夜;
                }
            switch (weather) {
                case "阴":
                    return Resources.阴;
                case "轻度雾霾":
                case "中度雾霾":
                case "重度雾霾":
                case "浮尘":
                case "沙尘":
                    return Resources.雾;
                case "中雨":
                    return Resources.雨;
                case "大雨":
                case "暴雨":
                    return Resources.大雨;
                case "中雪":
                    return Resources.雪;
                case "大雪":
                case "暴雪":
                    return Resources.大雪;
                default:
                    return null;
            }
        }

        private void CmRefresh_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private void TransparentForm() {
            var img = new Bitmap((Bitmap)picBox.Image, new Size(200, 176));
            var graph = BitmapUtil.GetNoneTransparentRegion(img, 0);
            Region = new Region(graph);

            BackgroundImage = img;
            BackgroundImageLayout = ImageLayout.None;

            FormBorderStyle = FormBorderStyle.None;
            Width = picBox.Image.Width;
            Height = picBox.Image.Height;
        }
    }
}