using System.ComponentModel;
using System.Windows.Forms;

namespace MikuWeather {
    partial class FormShow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel = new TableLayoutPanel();
            picToday = new PictureBox();
            picTomorrow = new PictureBox();
            lnkTodayTemp = new LinkLabel();
            lnkTomorrowTemp = new LinkLabel();
            lnkTodayWeather = new LinkLabel();
            lnkTomorrowWeather = new LinkLabel();
            tableLayoutPanel.SuspendLayout();
            ((ISupportInitialize)picToday).BeginInit();
            ((ISupportInitialize)picTomorrow).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            tableLayoutPanel.BackgroundImage = Properties.Resources.bg_wdt;
            tableLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(picToday, 0, 1);
            tableLayoutPanel.Controls.Add(picTomorrow, 1, 1);
            tableLayoutPanel.Controls.Add(lnkTodayTemp, 0, 2);
            tableLayoutPanel.Controls.Add(lnkTomorrowTemp, 1, 2);
            tableLayoutPanel.Controls.Add(lnkTodayWeather, 0, 3);
            tableLayoutPanel.Controls.Add(lnkTomorrowWeather, 1, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new System.Drawing.Size(710, 396);
            tableLayoutPanel.TabIndex = 0;
            // 
            // picToday
            // 
            picToday.BackColor = System.Drawing.Color.Transparent;
            picToday.BackgroundImage = Properties.Resources.晴_日;
            picToday.BackgroundImageLayout = ImageLayout.Zoom;
            picToday.Dock = DockStyle.Fill;
            picToday.Location = new System.Drawing.Point(3, 63);
            picToday.Name = "picToday";
            picToday.Size = new System.Drawing.Size(349, 194);
            picToday.TabIndex = 0;
            picToday.TabStop = false;
            // 
            // picTomorrow
            // 
            picTomorrow.BackColor = System.Drawing.Color.Transparent;
            picTomorrow.BackgroundImageLayout = ImageLayout.Zoom;
            picTomorrow.Dock = DockStyle.Fill;
            picTomorrow.Location = new System.Drawing.Point(358, 63);
            picTomorrow.Name = "picTomorrow";
            picTomorrow.Size = new System.Drawing.Size(349, 194);
            picTomorrow.TabIndex = 1;
            picTomorrow.TabStop = false;
            // 
            // lnkTodayTemp
            // 
            lnkTodayTemp.AutoSize = true;
            lnkTodayTemp.BackColor = System.Drawing.Color.Transparent;
            lnkTodayTemp.Dock = DockStyle.Fill;
            lnkTodayTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.1428576F);
            lnkTodayTemp.ForeColor = System.Drawing.Color.LightGreen;
            lnkTodayTemp.Location = new System.Drawing.Point(3, 260);
            lnkTodayTemp.Name = "lnkTodayTemp";
            lnkTodayTemp.Size = new System.Drawing.Size(349, 68);
            lnkTodayTemp.TabIndex = 2;
            lnkTodayTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTomorrowTemp
            // 
            lnkTomorrowTemp.AutoSize = true;
            lnkTomorrowTemp.BackColor = System.Drawing.Color.Transparent;
            lnkTomorrowTemp.Dock = DockStyle.Fill;
            lnkTomorrowTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.1428576F);
            lnkTomorrowTemp.ForeColor = System.Drawing.Color.LightGreen;
            lnkTomorrowTemp.Location = new System.Drawing.Point(358, 260);
            lnkTomorrowTemp.Name = "lnkTomorrowTemp";
            lnkTomorrowTemp.Size = new System.Drawing.Size(349, 68);
            lnkTomorrowTemp.TabIndex = 3;
            lnkTomorrowTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTodayWeather
            // 
            lnkTodayWeather.AutoSize = true;
            lnkTodayWeather.BackColor = System.Drawing.Color.Transparent;
            lnkTodayWeather.Dock = DockStyle.Fill;
            lnkTodayWeather.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.1428576F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lnkTodayWeather.ForeColor = System.Drawing.Color.MediumTurquoise;
            lnkTodayWeather.Location = new System.Drawing.Point(3, 328);
            lnkTodayWeather.Name = "lnkTodayWeather";
            lnkTodayWeather.Size = new System.Drawing.Size(349, 68);
            lnkTodayWeather.TabIndex = 4;
            lnkTodayWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTomorrowWeather
            // 
            lnkTomorrowWeather.AutoSize = true;
            lnkTomorrowWeather.BackColor = System.Drawing.Color.Transparent;
            lnkTomorrowWeather.Dock = DockStyle.Fill;
            lnkTomorrowWeather.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.1428576F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lnkTomorrowWeather.ForeColor = System.Drawing.Color.MediumTurquoise;
            lnkTomorrowWeather.Location = new System.Drawing.Point(358, 328);
            lnkTomorrowWeather.Name = "lnkTomorrowWeather";
            lnkTomorrowWeather.Size = new System.Drawing.Size(349, 68);
            lnkTomorrowWeather.TabIndex = 5;
            lnkTomorrowWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormShow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(710, 396);
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Location = new System.Drawing.Point(1000, 600);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormShow";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            Load += FormShow_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((ISupportInitialize)picToday).EndInit();
            ((ISupportInitialize)picTomorrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox picToday;
        private PictureBox picTomorrow;
        private LinkLabel lnkTodayTemp;
        private LinkLabel lnkTomorrowTemp;
        private LinkLabel lnkTodayWeather;
        private LinkLabel lnkTomorrowWeather;
    }
}