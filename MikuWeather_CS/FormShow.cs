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

        public void SetPic(Bitmap todayPic, Bitmap tomorrowPic)
        {
            picToday.Image = todayPic;
            picTomorrow.Image = tomorrowPic;
        }
    }
}