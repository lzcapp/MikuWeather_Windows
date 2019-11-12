using System.ComponentModel;
using System.Windows.Forms;

namespace MikuWeather
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            _frmShow.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBaidu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCaiyun = new System.Windows.Forms.ToolStripMenuItem();
            this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTextBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.cmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.ContextMenuStrip = this.cmMenu;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Margin = new System.Windows.Forms.Padding(4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(280, 281);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseEnter += new System.EventHandler(this.Form1_MouseHover);
            this.picBox.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.picBox.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // cmMenu
            // 
            this.cmMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmWebsite,
            this.tsSeparator1,
            this.tsTextBox,
            this.cmBaidu,
            this.cmCaiyun,
            this.tsSeparator2,
            this.cmExit});
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(301, 248);
            // 
            // cmWebsite
            // 
            this.cmWebsite.Name = "cmWebsite";
            this.cmWebsite.ShortcutKeyDisplayString = "";
            this.cmWebsite.Size = new System.Drawing.Size(300, 38);
            this.cmWebsite.Text = "🏚 Github Repo";
            this.cmWebsite.Click += new System.EventHandler(this.CmWebsite_Click);
            // 
            // cmBaidu
            // 
            this.cmBaidu.Name = "cmBaidu";
            this.cmBaidu.Size = new System.Drawing.Size(300, 38);
            this.cmBaidu.Text = " · 百度API";
            this.cmBaidu.Click += new System.EventHandler(this.CmBaidu_Click);
            // 
            // cmCaiyun
            // 
            this.cmCaiyun.Name = "cmCaiyun";
            this.cmCaiyun.Size = new System.Drawing.Size(300, 38);
            this.cmCaiyun.Text = " · 彩云API";
            this.cmCaiyun.Click += new System.EventHandler(this.CmCaiyun_Click);
            // 
            // cmExit
            // 
            this.cmExit.Name = "cmExit";
            this.cmExit.Size = new System.Drawing.Size(300, 38);
            this.cmExit.Text = "退出";
            this.cmExit.Click += new System.EventHandler(this.CmExit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(297, 6);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(297, 6);
            // 
            // tsTextBox
            // 
            this.tsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.tsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsTextBox.Enabled = false;
            this.tsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTextBox.Name = "tsTextBox";
            this.tsTextBox.Size = new System.Drawing.Size(100, 32);
            this.tsTextBox.Text = "更新源：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(280, 281);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.cmMenu.ResumeLayout(false);
            this.cmMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBox;
        private ContextMenuStrip cmMenu;
        private ToolStripMenuItem cmWebsite;
        private ToolStripMenuItem cmExit;
        private ToolStripMenuItem cmBaidu;
        private ToolStripMenuItem cmCaiyun;
        private ToolStripSeparator tsSeparator1;
        private ToolStripTextBox tsTextBox;
        private ToolStripSeparator tsSeparator2;
    }
}