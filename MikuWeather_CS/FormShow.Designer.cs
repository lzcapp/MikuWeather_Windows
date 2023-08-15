﻿using System.ComponentModel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow));
            this.picToday = new System.Windows.Forms.PictureBox();
            this.picTomorrow = new System.Windows.Forms.PictureBox();
            this.lnkTodayWeather = new System.Windows.Forms.LinkLabel();
            this.lnkTodayTemp = new System.Windows.Forms.LinkLabel();
            this.lnkTomorrowTemp = new System.Windows.Forms.LinkLabel();
            this.lnkTomorrowWeather = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // picToday
            // 
            this.picToday.BackColor = System.Drawing.Color.Transparent;
            this.picToday.Image = ((System.Drawing.Image)(resources.GetObject("picToday.Image")));
            this.picToday.Location = new System.Drawing.Point(27, 16);
            this.picToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picToday.Name = "picToday";
            this.picToday.Size = new System.Drawing.Size(202, 202);
            this.picToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToday.TabIndex = 0;
            this.picToday.TabStop = false;
            // 
            // picTomorrow
            // 
            this.picTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.picTomorrow.Image = ((System.Drawing.Image)(resources.GetObject("picTomorrow.Image")));
            this.picTomorrow.Location = new System.Drawing.Point(267, 16);
            this.picTomorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTomorrow.Name = "picTomorrow";
            this.picTomorrow.Size = new System.Drawing.Size(202, 202);
            this.picTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTomorrow.TabIndex = 1;
            this.picTomorrow.TabStop = false;
            // 
            // lnkTodayWeather
            // 
            this.lnkTodayWeather.BackColor = System.Drawing.Color.Transparent;
            this.lnkTodayWeather.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkTodayWeather.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lnkTodayWeather.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkTodayWeather.Location = new System.Drawing.Point(-1, 205);
            this.lnkTodayWeather.Name = "lnkTodayWeather";
            this.lnkTodayWeather.Size = new System.Drawing.Size(261, 32);
            this.lnkTodayWeather.TabIndex = 2;
            this.lnkTodayWeather.Text = "无数据";
            this.lnkTodayWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTodayTemp
            // 
            this.lnkTodayTemp.BackColor = System.Drawing.Color.Transparent;
            this.lnkTodayTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lnkTodayTemp.ForeColor = System.Drawing.Color.LightGreen;
            this.lnkTodayTemp.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkTodayTemp.Location = new System.Drawing.Point(-1, 234);
            this.lnkTodayTemp.Name = "lnkTodayTemp";
            this.lnkTodayTemp.Size = new System.Drawing.Size(261, 36);
            this.lnkTodayTemp.TabIndex = 4;
            this.lnkTodayTemp.Text = "-- °C";
            this.lnkTodayTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTomorrowTemp
            // 
            this.lnkTomorrowTemp.BackColor = System.Drawing.Color.Transparent;
            this.lnkTomorrowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lnkTomorrowTemp.ForeColor = System.Drawing.Color.LightGreen;
            this.lnkTomorrowTemp.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkTomorrowTemp.Location = new System.Drawing.Point(235, 234);
            this.lnkTomorrowTemp.Name = "lnkTomorrowTemp";
            this.lnkTomorrowTemp.Size = new System.Drawing.Size(261, 36);
            this.lnkTomorrowTemp.TabIndex = 6;
            this.lnkTomorrowTemp.Text = "-- °C";
            this.lnkTomorrowTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTomorrowWeather
            // 
            this.lnkTomorrowWeather.BackColor = System.Drawing.Color.Transparent;
            this.lnkTomorrowWeather.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkTomorrowWeather.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lnkTomorrowWeather.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkTomorrowWeather.Location = new System.Drawing.Point(235, 205);
            this.lnkTomorrowWeather.Name = "lnkTomorrowWeather";
            this.lnkTomorrowWeather.Size = new System.Drawing.Size(261, 32);
            this.lnkTomorrowWeather.TabIndex = 5;
            this.lnkTomorrowWeather.Text = "无数据";
            this.lnkTomorrowWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MikuWeather.Properties.Resources.bg_wdt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 270);
            this.Controls.Add(this.lnkTomorrowTemp);
            this.Controls.Add(this.lnkTomorrowWeather);
            this.Controls.Add(this.lnkTodayTemp);
            this.Controls.Add(this.lnkTodayWeather);
            this.Controls.Add(this.picTomorrow);
            this.Controls.Add(this.picToday);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 600);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picToday;
        private PictureBox picTomorrow;
        private LinkLabel lnkTodayWeather;
        private LinkLabel lnkTodayTemp;
        private LinkLabel lnkTomorrowTemp;
        private LinkLabel lnkTomorrowWeather;
    }
}