namespace MikuWeather
{
    partial class FrmMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.lnkTitle = new System.Windows.Forms.LinkLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.lnkDescription = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lnkTitle, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseDown);
            this.tableLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseMove);
            this.tableLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑 Light", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.btnClose.Location = new System.Drawing.Point(740, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 65);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "×";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lnkTitle
            // 
            this.lnkTitle.AutoSize = true;
            this.lnkTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lnkTitle.Location = new System.Drawing.Point(0, 65);
            this.lnkTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lnkTitle.Name = "lnkTitle";
            this.lnkTitle.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lnkTitle.Size = new System.Drawing.Size(800, 83);
            this.lnkTitle.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.lnkDescription);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 148);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 302);
            this.panel.TabIndex = 2;
            // 
            // lnkDescription
            // 
            this.lnkDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lnkDescription.Location = new System.Drawing.Point(0, 0);
            this.lnkDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDescription.Name = "lnkDescription";
            this.lnkDescription.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lnkDescription.Size = new System.Drawing.Size(800, 302);
            this.lnkDescription.TabIndex = 3;
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MikuWeather.Properties.Resources.bg_wdt_nt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessage";
            this.Load += new System.EventHandler(this.FrmMessage_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.LinkLabel btnClose;
        private System.Windows.Forms.LinkLabel lnkTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.LinkLabel lnkDescription;
    }
}