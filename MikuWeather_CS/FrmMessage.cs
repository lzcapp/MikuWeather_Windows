using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
// ReSharper disable PossibleNullReferenceException
// ReSharper disable IdentifierTypo

namespace MikuWeather {
    public partial class FrmMessage : Form {
        private System.Drawing.Point _offset;

        // ReSharper disable once InconsistentNaming
        private static readonly PrivateFontCollection PFCAwe = new PrivateFontCollection();

        private static void AddPrivateFont() {
            var hObject = System.Runtime.InteropServices.GCHandle.Alloc(Properties.Resources.MFYaYuan, System.Runtime.InteropServices.GCHandleType.Pinned);
            var intptr = hObject.AddrOfPinnedObject();
            PFCAwe.AddMemoryFont(intptr, Properties.Resources.MFYaYuan.Length);
        }

        public FrmMessage() {
            InitializeComponent();
        }

        public void SetTitle(string title) {
            lnkTitle.Text = title;
            lnkTitle.LinkArea = new LinkArea(0, 0);
        }

        public void SetDescription(string description) {
            lnkDescription.Text = description;
            lnkDescription.LinkArea = new LinkArea(0, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void FrmMessage_Load(object sender, EventArgs e) {
            AddPrivateFont();
            lnkTitle.Font = new Font(PFCAwe.Families[0], 12, FontStyle.Bold);
            lnkTitle.UseCompatibleTextRendering = true;
            lnkDescription.Font = new Font(PFCAwe.Families[0], 10, FontStyle.Bold);
            lnkDescription.UseCompatibleTextRendering = true;
        }

        private void TableLayoutPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                _offset = new System.Drawing.Point(e.X, e.Y);
            }
        }

        private void TableLayoutPanel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                var newPoint = PointToScreen(new System.Drawing.Point(e.X, e.Y));
                newPoint.Offset(-_offset.X, -_offset.Y);
                Location = newPoint;
            }
        }

        private void TableLayoutPanel_MouseUp(object sender, MouseEventArgs e) {
            _offset = System.Drawing.Point.Empty;
        }
    }
}