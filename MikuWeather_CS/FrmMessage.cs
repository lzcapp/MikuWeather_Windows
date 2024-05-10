using System.Windows.Forms;
// ReSharper disable PossibleNullReferenceException

namespace MikuWeather {
    public partial class FrmMessage : Form {
        public FrmMessage() {
            InitializeComponent();
        }

        public FrmMessage(string strAlertTitle, string strAlertDescription) {
            lnkTitle.Text = strAlertTitle;
            lnkMessage.Text = strAlertDescription;
        }

        private void BtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Close();
        }
    }
}