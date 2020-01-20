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
            var blankArea = new LinkArea(0, 0);
            lnkTodayTemp.Text = todayTemp;
            lnkTodayTemp.LinkArea = blankArea;
            lnkTomorrowTemp.Text = tomorrowTemp;
            lnkTomorrowTemp.LinkArea = blankArea;
        }

        public void SetWeather(string todayWeather, string tomorrowWeather) {
            var blankArea = new LinkArea(0, 0);
            lnkTodayWeather.Text = todayWeather;
            lnkTodayWeather.LinkArea = blankArea;
            lnkTomorrowWeather.Text = tomorrowWeather;
            lnkTomorrowWeather.LinkArea = blankArea;
        }

        public void SetPic(Bitmap todayPic, Bitmap tomorrowPic) {
            picToday.Image = todayPic;
            picTomorrow.Image = tomorrowPic;
        }
    }
}