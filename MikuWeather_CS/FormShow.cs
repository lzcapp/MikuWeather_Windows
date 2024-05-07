using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace MikuWeather {
    [SupportedOSPlatform("windows")]

    public partial class FormShow : Form {
        private static readonly PrivateFontCollection PfcAwe = new();

        private static void AddPrivateFont() {
            GCHandle hObject = GCHandle.Alloc(Properties.Resources.FZMingMT, GCHandleType.Pinned);
            var intptr = hObject.AddrOfPinnedObject();
            PfcAwe.AddMemoryFont(intptr, Properties.Resources.FZMingMT.Length);
        }

        public FormShow() {
            InitializeComponent();
        }

        private void FormShow_Load(object sender, EventArgs e) {
            AddPrivateFont();

            lnkTodayTemp.Font = new Font(PfcAwe.Families[0], 14, FontStyle.Bold);
            lnkTomorrowTemp.Font = new Font(PfcAwe.Families[0], 14, FontStyle.Bold);
        }

        internal void SetTemp(string todayTemp, string tomorrowTemp) {
            var blankArea = new LinkArea(0, 0);
            lnkTodayTemp.Text = todayTemp;
            lnkTodayTemp.LinkArea = blankArea;
            lnkTomorrowTemp.Text = tomorrowTemp;
            lnkTomorrowTemp.LinkArea = blankArea;
        }

        internal void SetWeather(string todayWeather, string tomorrowWeather) {
            var blankArea = new LinkArea(0, 0);
            lnkTodayWeather.Text = todayWeather;
            lnkTodayWeather.LinkArea = blankArea;
            lnkTomorrowWeather.Text = tomorrowWeather;
            lnkTomorrowWeather.LinkArea = blankArea;
        }

        internal void SetPic(Bitmap todayPic, Bitmap tomorrowPic) {
            picToday.BackgroundImage = todayPic;
            picTomorrow.BackgroundImage = tomorrowPic;
        }
    }
}