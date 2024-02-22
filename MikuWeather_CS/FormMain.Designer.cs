using System.ComponentModel;
using System.Windows.Forms;

namespace MikuWeather
{
    partial class FormMain
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
            components = new Container();
            picBox = new PictureBox();
            cmMenu = new ContextMenuStrip(components);
            cmWebsite = new ToolStripMenuItem();
            cmRefresh = new ToolStripMenuItem();
            cmExit = new ToolStripMenuItem();
            ((ISupportInitialize)picBox).BeginInit();
            cmMenu.SuspendLayout();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.ContextMenuStrip = cmMenu;
            picBox.InitialImage = null;
            picBox.Location = new System.Drawing.Point(0, 0);
            picBox.Margin = new Padding(4, 5, 4, 5);
            picBox.Name = "picBox";
            picBox.Size = new System.Drawing.Size(303, 327);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            picBox.Visible = false;
            picBox.MouseEnter += FormMain_MouseHover;
            picBox.MouseLeave += FormMain_MouseLeave;
            picBox.MouseHover += FormMain_MouseHover;
            // 
            // cmMenu
            // 
            cmMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            cmMenu.Items.AddRange(new ToolStripItem[] { cmWebsite, cmRefresh, cmExit });
            cmMenu.Name = "cmMenu";
            cmMenu.Size = new System.Drawing.Size(212, 106);
            // 
            // cmWebsite
            // 
            cmWebsite.Name = "cmWebsite";
            cmWebsite.ShortcutKeyDisplayString = "";
            cmWebsite.Size = new System.Drawing.Size(211, 34);
            cmWebsite.Text = "Github Repo";
            cmWebsite.Click += CmWebsite_Click;
            // 
            // cmRefresh
            // 
            cmRefresh.Name = "cmRefresh";
            cmRefresh.Size = new System.Drawing.Size(211, 34);
            cmRefresh.Text = "更新";
            cmRefresh.Click += CmRefresh_Click;
            // 
            // cmExit
            // 
            cmExit.Name = "cmExit";
            cmExit.Size = new System.Drawing.Size(211, 34);
            cmExit.Text = "退出";
            cmExit.Click += CmExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(303, 327);
            ContextMenuStrip = cmMenu;
            Controls.Add(picBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            Load += FormMain_Load;
            MouseLeave += FormMain_MouseLeave;
            MouseHover += FormMain_MouseHover;
            ((ISupportInitialize)picBox).EndInit();
            cmMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBox;
        private ContextMenuStrip cmMenu;
        private ToolStripMenuItem cmWebsite;
        private ToolStripMenuItem cmExit;
        private ToolStripMenuItem cmRefresh;
    }
}