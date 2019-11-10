using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MikuWeather {

    public partial class Form1 : Form {

        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private readonly FormShow _frmShow = new FormShow();

        private string _city;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackColor = Color.FloralWhite;
            TransparencyKey = BackColor;

            var intScreenY = Screen.PrimaryScreen.WorkingArea.Bottom;
            SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272,
                intScreenY - Size.Height + 13,
                Size.Width, Size.Height);
            _city = DataQuery.GetLocation();
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
            var dict = DataQuery.UpdateData_Baidu(_city);
            _frmShow.SetTemp(dict["today temp"], dict["tomorrow temp"]);
            _frmShow.SetWeather(dict["today weather"], dict["tomorrow weather"]);
            var bitmapPic = _frmShow.SetPic(dict["today day pic url"], dict["today night pic url"], dict["tomorrow day pic url"], dict["tomorrow night pic url"]);
            picBox.Image = bitmapPic;
        }
    }
}