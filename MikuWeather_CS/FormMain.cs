using MikuWeather.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace MikuWeather {
    public partial class FormMain : Form {
        private readonly FormShow _frmShow = new();

        private string coordinate;

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            var locationX = Screen.PrimaryScreen.WorkingArea.Width - 290;
            var locationY = Screen.PrimaryScreen.WorkingArea.Bottom - Size.Height + 20;
            SetBounds(locationX, locationY, Size.Width, Size.Height);

            var dictLocation = DataQuery.GetLocation();
            coordinate = dictLocation["coordinate"];
            cmWebsite.Text = @"Github仓库";
            cmExit.Text = @"退出";
            UpdateData();
            TransparentForm();
        }

        private void FormMain_MouseHover(object sender, EventArgs e) {
            _frmShow.SetBounds(Location.X - _frmShow.Width / 2 + Width / 2 - 50, Location.Y - _frmShow.Height - 20, _frmShow.Width, _frmShow.Height);
            _frmShow.Show();
        }

        private void FormMain_MouseLeave(object sender, EventArgs e) {
            _frmShow.Hide();
        }

        private void CmWebsite_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/lzcapp/MikuWeather_Windows");
        }

        private void CmExit_Click(object sender, EventArgs e) {
            Close();
            Environment.Exit(0);
        }

        private void UpdateData() {
            DateTime nowDt = DateTime.Now;
            var dict = DataQuery.UpdateData_Caiyun(coordinate);
            var todayWeather = SwitchCaiyun(dict["today pic"]);
            var tomorrowWeather = SwitchCaiyun(dict["tomorrow pic"]);
            var todayTemp = dict["today temp"];
            var tomorrowTemp = dict["tomorrow temp"];
            DateTime sunrise = DateTime.ParseExact(dict["sunrise"], "HH:mm", CultureInfo.CurrentCulture);
            DateTime sunset = DateTime.ParseExact(dict["sunset"], "HH:mm", CultureInfo.CurrentCulture);
            bool isDay;
            if (nowDt >= sunrise && nowDt < sunset)
                isDay = true;
            else
                isDay = false;
            Bitmap todayPic = SwitchCaiyunPic(todayWeather, isDay);
            Bitmap tomorrowPic = SwitchCaiyunPic(tomorrowWeather, isDay);

            _frmShow.SetTemp(todayTemp, tomorrowTemp);
            _frmShow.SetWeather(todayWeather, tomorrowWeather);
            _frmShow.SetPic(todayPic, tomorrowPic);
            picBox.Image = todayPic;
            picBox.Size = new Size(210, 210);
            TransparentForm();
        }

        private static string SwitchCaiyun(string weather) {
            return weather switch {
                "CLEAR_DAY" or "CLEAR_NIGHT" => "晴",
                "PARTLY_CLOUDY_DAY" or "PARTLY_CLOUDY_NIGHT" => "多云",
                "CLOUDY" => "阴",
                "LIGHT_HAZE" => "轻度雾霾",
                "MODERATE_HAZE" => "中度雾霾",
                "HEAVY_HAZE" => "重度雾霾",
                "LIGHT_RAIN" => "小雨",
                "MODERATE_RAIN" => "中雨",
                "HEAVY_RAIN" => "大雨",
                "STORM_RAIN" => "暴雨",
                "FOG" => "雾",
                "LIGHT_SNOW" => "小雪",
                "MODERATE_SNOW" => "中雪",
                "HEAVY_SNOW" => "大雪",
                "STORM_SNOW" => "暴雪",
                "DUST" => "浮尘",
                "SAND" => "沙尘",
                "WIND" => "大风",
                _ => null,
            };
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
                }
            else
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
            return weather switch {
                "阴" => Resources.阴,
                "轻度雾霾" or "中度雾霾" or "重度雾霾" or "浮尘" or "沙尘" => Resources.雾,
                "中雨" => Resources.雨,
                "大雨" or "暴雨" => Resources.大雨,
                "中雪" => Resources.雪,
                "大雪" or "暴雪" => Resources.大雪,
                _ => null,
            };
        }

        private void CmRefresh_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private void TransparentForm() {
            var img = new Bitmap((Bitmap)picBox.Image, new Size(200, 176));
            GraphicsPath graph = BitmapUtil.GetNoneTransparentRegion(img, 0);
            Region = new Region(graph);

            BackgroundImage = img;
            BackgroundImageLayout = ImageLayout.None;

            FormBorderStyle = FormBorderStyle.None;
            Width = picBox.Image.Width;
            Height = picBox.Image.Height;
        }
    }
}