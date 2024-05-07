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
            lnkTomorrowWeather = new LinkLabel();
            lnkTodayTemp = new LinkLabel();
            lnkTodayWeather = new LinkLabel();
            lnkTomorrowTemp = new LinkLabel();
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
            tableLayoutPanel.Controls.Add(lnkTomorrowWeather, 1, 2);
            tableLayoutPanel.Controls.Add(lnkTodayTemp, 0, 3);
            tableLayoutPanel.Controls.Add(lnkTodayWeather, 0, 2);
            tableLayoutPanel.Controls.Add(lnkTomorrowTemp, 1, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel.Size = new System.Drawing.Size(492, 283);
            tableLayoutPanel.TabIndex = 0;
            // 
            // picToday
            // 
            picToday.BackColor = System.Drawing.Color.Transparent;
            picToday.BackgroundImage = Properties.Resources.晴_日;
            picToday.BackgroundImageLayout = ImageLayout.Zoom;
            picToday.Dock = DockStyle.Fill;
            picToday.Location = new System.Drawing.Point(2, 45);
            picToday.Margin = new Padding(2);
            picToday.Name = "picToday";
            picToday.Size = new System.Drawing.Size(242, 144);
            picToday.TabIndex = 0;
            picToday.TabStop = false;
            // 
            // picTomorrow
            // 
            picTomorrow.BackColor = System.Drawing.Color.Transparent;
            picTomorrow.BackgroundImageLayout = ImageLayout.Zoom;
            picTomorrow.Dock = DockStyle.Fill;
            picTomorrow.Location = new System.Drawing.Point(248, 45);
            picTomorrow.Margin = new Padding(2);
            picTomorrow.Name = "picTomorrow";
            picTomorrow.Size = new System.Drawing.Size(242, 144);
            picTomorrow.TabIndex = 1;
            picTomorrow.TabStop = false;
            // 
            // lnkTomorrowWeather
            // 
            lnkTomorrowWeather.AutoSize = true;
            lnkTomorrowWeather.BackColor = System.Drawing.Color.Transparent;
            lnkTomorrowWeather.Dock = DockStyle.Fill;
            lnkTomorrowWeather.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            lnkTomorrowWeather.ForeColor = System.Drawing.Color.WhiteSmoke;
            lnkTomorrowWeather.LinkArea = new LinkArea(0, 0);
            lnkTomorrowWeather.Location = new System.Drawing.Point(246, 204);
            lnkTomorrowWeather.Margin = new Padding(0, 13, 0, 0);
            lnkTomorrowWeather.Name = "lnkTomorrowWeather";
            lnkTomorrowWeather.Size = new System.Drawing.Size(246, 27);
            lnkTomorrowWeather.TabIndex = 5;
            lnkTomorrowWeather.Text = "晴";
            lnkTomorrowWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTodayTemp
            // 
            lnkTodayTemp.AutoSize = true;
            lnkTodayTemp.BackColor = System.Drawing.Color.Transparent;
            lnkTodayTemp.Dock = DockStyle.Fill;
            lnkTodayTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.1428576F);
            lnkTodayTemp.ForeColor = System.Drawing.Color.WhiteSmoke;
            lnkTodayTemp.Location = new System.Drawing.Point(2, 231);
            lnkTodayTemp.Margin = new Padding(2, 0, 2, 0);
            lnkTodayTemp.Name = "lnkTodayTemp";
            lnkTodayTemp.Size = new System.Drawing.Size(242, 39);
            lnkTodayTemp.TabIndex = 2;
            lnkTodayTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTodayWeather
            // 
            lnkTodayWeather.AutoSize = true;
            lnkTodayWeather.BackColor = System.Drawing.Color.Transparent;
            lnkTodayWeather.Dock = DockStyle.Fill;
            lnkTodayWeather.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            lnkTodayWeather.ForeColor = System.Drawing.Color.WhiteSmoke;
            lnkTodayWeather.LinkArea = new LinkArea(0, 0);
            lnkTodayWeather.Location = new System.Drawing.Point(0, 204);
            lnkTodayWeather.Margin = new Padding(0, 13, 0, 0);
            lnkTodayWeather.Name = "lnkTodayWeather";
            lnkTodayWeather.Size = new System.Drawing.Size(246, 27);
            lnkTodayWeather.TabIndex = 4;
            lnkTodayWeather.Text = "晴";
            lnkTodayWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTomorrowTemp
            // 
            lnkTomorrowTemp.AutoSize = true;
            lnkTomorrowTemp.BackColor = System.Drawing.Color.Transparent;
            lnkTomorrowTemp.Dock = DockStyle.Fill;
            lnkTomorrowTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.1428576F);
            lnkTomorrowTemp.ForeColor = System.Drawing.Color.WhiteSmoke;
            lnkTomorrowTemp.Location = new System.Drawing.Point(248, 231);
            lnkTomorrowTemp.Margin = new Padding(2, 0, 2, 0);
            lnkTomorrowTemp.Name = "lnkTomorrowTemp";
            lnkTomorrowTemp.Size = new System.Drawing.Size(242, 39);
            lnkTomorrowTemp.TabIndex = 3;
            lnkTomorrowTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormShow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(492, 283);
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Location = new System.Drawing.Point(1000, 600);
            Margin = new Padding(3, 4, 3, 4);
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