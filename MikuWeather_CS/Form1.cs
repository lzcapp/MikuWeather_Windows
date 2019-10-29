using System;
using System.Drawing;
using System.Windows.Forms;

namespace MikuWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            BackColor = Color.FloralWhite;
            TransparencyKey = BackColor;

            var intScreenY = Screen.PrimaryScreen.WorkingArea.Bottom;

            SetBounds(Screen.PrimaryScreen.WorkingArea.Width - 272,
                intScreenY - Size.Height + 10,
                Size.Width, Size.Height);
        }
    }
}