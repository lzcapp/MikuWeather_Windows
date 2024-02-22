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
            cmMenu = new ContextMenuStrip(components);
            cmWebsite = new ToolStripMenuItem();
            cmRefresh = new ToolStripMenuItem();
            cmExit = new ToolStripMenuItem();
            cmMenu.SuspendLayout();
            SuspendLayout();
            // 
            // cmMenu
            // 
            cmMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            cmMenu.Items.AddRange(new ToolStripItem[] { cmWebsite, cmRefresh, cmExit });
            cmMenu.Name = "cmMenu";
            cmMenu.Size = new System.Drawing.Size(234, 118);
            // 
            // cmWebsite
            // 
            cmWebsite.Name = "cmWebsite";
            cmWebsite.ShortcutKeyDisplayString = "";
            cmWebsite.Size = new System.Drawing.Size(233, 38);
            cmWebsite.Text = "Github Repo";
            cmWebsite.Click += CmWebsite_Click;
            // 
            // cmRefresh
            // 
            cmRefresh.Name = "cmRefresh";
            cmRefresh.Size = new System.Drawing.Size(233, 38);
            cmRefresh.Text = "更新";
            cmRefresh.Click += CmRefresh_Click;
            // 
            // cmExit
            // 
            cmExit.Name = "cmExit";
            cmExit.Size = new System.Drawing.Size(233, 38);
            cmExit.Text = "退出";
            cmExit.Click += CmExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            BackgroundImage = Properties.Resources.晴_日;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(200, 179);
            ContextMenuStrip = cmMenu;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
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
            cmMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip cmMenu;
        private ToolStripMenuItem cmWebsite;
        private ToolStripMenuItem cmExit;
        private ToolStripMenuItem cmRefresh;
    }
}