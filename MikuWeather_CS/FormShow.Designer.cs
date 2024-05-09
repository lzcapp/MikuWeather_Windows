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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow));
            this.picToday = new System.Windows.Forms.PictureBox();
            this.picTomorrow = new System.Windows.Forms.PictureBox();
            this.lnkTodayWeather = new System.Windows.Forms.LinkLabel();
            this.lnkTodayTemp = new System.Windows.Forms.LinkLabel();
            this.lnkTomorrowTemp = new System.Windows.Forms.LinkLabel();
            this.lnkTomorrowWeather = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomorrow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picToday
            // 
            this.picToday.BackColor = System.Drawing.Color.Transparent;
            this.picToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picToday.Image = ((System.Drawing.Image)(resources.GetObject("picToday.Image")));
            this.picToday.Location = new System.Drawing.Point(4, 43);
            this.picToday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picToday.Name = "picToday";
            this.picToday.Size = new System.Drawing.Size(322, 221);
            this.picToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToday.TabIndex = 0;
            this.picToday.TabStop = false;
            // 
            // picTomorrow
            // 
            this.picTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.picTomorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTomorrow.Image = ((System.Drawing.Image)(resources.GetObject("picTomorrow.Image")));
            this.picTomorrow.Location = new System.Drawing.Point(334, 43);
            this.picTomorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picTomorrow.Name = "picTomorrow";
            this.picTomorrow.Size = new System.Drawing.Size(322, 221);
            this.picTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTomorrow.TabIndex = 1;
            this.picTomorrow.TabStop = false;
            // 
            // lnkTodayWeather
            // 
            this.lnkTodayWeather.BackColor = System.Drawing.Color.Transparent;
            this.lnkTodayWeather.Font = new System.Drawing.Font("微软雅黑", 12.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkTodayWeather.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lnkTodayWeather.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkTodayWeather.Location = new System.Drawing.Point(0, 267);
            this.lnkTodayWeather.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lnkTodayWeather.Name = "lnkTodayWeather";
            this.lnkTodayWeather.Size = new System.Drawing.Size(330, 43);
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
            this.lnkTodayTemp.Location = new System.Drawing.Point(0, 320);
            this.lnkTodayTemp.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lnkTodayTemp.Name = "lnkTodayTemp";
            this.lnkTodayTemp.Size = new System.Drawing.Size(330, 48);
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
            this.lnkTomorrowTemp.Location = new System.Drawing.Point(330, 320);
            this.lnkTomorrowTemp.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lnkTomorrowTemp.Name = "lnkTomorrowTemp";
            this.lnkTomorrowTemp.Size = new System.Drawing.Size(330, 48);
            this.lnkTomorrowTemp.TabIndex = 6;
            this.lnkTomorrowTemp.Text = "-- °C";
            this.lnkTomorrowTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkTomorrowWeather
            // 
            this.lnkTomorrowWeather.BackColor = System.Drawing.Color.Transparent;
            this.lnkTomorrowWeather.Font = new System.Drawing.Font("微软雅黑", 12.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkTomorrowWeather.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lnkTomorrowWeather.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkTomorrowWeather.Location = new System.Drawing.Point(330, 267);
            this.lnkTomorrowWeather.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lnkTomorrowWeather.Name = "lnkTomorrowWeather";
            this.lnkTomorrowWeather.Size = new System.Drawing.Size(330, 43);
            this.lnkTomorrowWeather.TabIndex = 5;
            this.lnkTomorrowWeather.Text = "无数据";
            this.lnkTomorrowWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lnkTodayTemp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lnkTomorrowTemp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lnkTomorrowWeather, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lnkTodayWeather, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picToday, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picTomorrow, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 384);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MikuWeather.Properties.Resources.bg_wdt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 600);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picToday;
        private PictureBox picTomorrow;
        private LinkLabel lnkTodayWeather;
        private LinkLabel lnkTodayTemp;
        private LinkLabel lnkTomorrowTemp;
        private LinkLabel lnkTomorrowWeather;
        private TableLayoutPanel tableLayoutPanel1;
    }
}