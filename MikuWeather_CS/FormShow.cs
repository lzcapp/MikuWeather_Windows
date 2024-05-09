using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace MikuWeather {
    public partial class FormShow : Form {
        // ReSharper disable once InconsistentNaming
        private static readonly PrivateFontCollection PFCAwe = new PrivateFontCollection();

        private static void AddPrivateFont() {
            var hObject = System.Runtime.InteropServices.GCHandle.Alloc(Properties.Resources.MFYaYuan, System.Runtime.InteropServices.GCHandleType.Pinned);
            var intptr = hObject.AddrOfPinnedObject();
            PFCAwe.AddMemoryFont(intptr, Properties.Resources.MFYaYuan.Length);
        }

        public FormShow() {
            InitializeComponent();
        }

        private void FormShow_Load(object sender, EventArgs e) {
            AddPrivateFont();
            //lnkTodayWeather.Font = new Font(PFCAwe.Families[0], 12, FontStyle.Bold);
            //lnkTodayWeather.UseCompatibleTextRendering = true;
            lnkTodayTemp.Font = new Font(PFCAwe.Families[0], 14, FontStyle.Bold);
            lnkTodayTemp.UseCompatibleTextRendering = true;
            //lnkTomorrowWeather.Font = new Font(PFCAwe.Families[0], 12, FontStyle.Bold);
            //lnkTomorrowWeather.UseCompatibleTextRendering = true;
            lnkTomorrowTemp.Font = new Font(PFCAwe.Families[0], 14, FontStyle.Bold);
            lnkTomorrowTemp.UseCompatibleTextRendering = true;
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