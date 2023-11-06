namespace CustomControls.UserControls
{
    partial class MainTitleBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.MenuViewAccount = new System.Windows.Forms.MenuStrip();
            this.PanelMenuStrip = new System.Windows.Forms.Panel();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            this.MenuTitleBar = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTitleBar.SuspendLayout();
            this.PanelBar.SuspendLayout();
            this.PanelMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.MenuTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.Controls.Add(this.PanelBar);
            this.PanelTitleBar.Controls.Add(this.PanelMenuStrip);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(1280, 30);
            this.PanelTitleBar.TabIndex = 0;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            this.PanelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseMove);
            this.PanelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseUp);
            // 
            // PanelBar
            // 
            this.PanelBar.Controls.Add(this.BtnMinimize);
            this.PanelBar.Controls.Add(this.BtnMaximize);
            this.PanelBar.Controls.Add(this.BtnClose);
            this.PanelBar.Controls.Add(this.MenuViewAccount);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelBar.Location = new System.Drawing.Point(905, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(375, 30);
            this.PanelBar.TabIndex = 1;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(285, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Location = new System.Drawing.Point(315, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(30, 30);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(345, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MenuViewAccount
            // 
            this.MenuViewAccount.AutoSize = false;
            this.MenuViewAccount.BackColor = System.Drawing.Color.Transparent;
            this.MenuViewAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuViewAccount.Location = new System.Drawing.Point(0, 0);
            this.MenuViewAccount.Name = "MenuViewAccount";
            this.MenuViewAccount.Size = new System.Drawing.Size(190, 30);
            this.MenuViewAccount.TabIndex = 3;
            this.MenuViewAccount.Text = "menuStrip1";
            // 
            // PanelMenuStrip
            // 
            this.PanelMenuStrip.Controls.Add(this.PicIcon);
            this.PanelMenuStrip.Controls.Add(this.MenuTitleBar);
            this.PanelMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuStrip.Name = "PanelMenuStrip";
            this.PanelMenuStrip.Size = new System.Drawing.Size(200, 30);
            this.PanelMenuStrip.TabIndex = 0;
            // 
            // PicIcon
            // 
            this.PicIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicIcon.Location = new System.Drawing.Point(0, 0);
            this.PicIcon.Margin = new System.Windows.Forms.Padding(0);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(30, 30);
            this.PicIcon.TabIndex = 0;
            this.PicIcon.TabStop = false;
            // 
            // MenuTitleBar
            // 
            this.MenuTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuTitleBar.AutoSize = false;
            this.MenuTitleBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuTitleBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.MenuTitleBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuTitleBar.Location = new System.Drawing.Point(30, 0);
            this.MenuTitleBar.Name = "MenuTitleBar";
            this.MenuTitleBar.Size = new System.Drawing.Size(170, 30);
            this.MenuTitleBar.TabIndex = 1;
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.settingToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // MainTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTitleBar);
            this.Name = "MainTitleBar";
            this.Size = new System.Drawing.Size(1280, 30);
            this.Load += new System.EventHandler(this.MainTitleBar_Load);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelBar.ResumeLayout(false);
            this.PanelMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.MenuTitleBar.ResumeLayout(false);
            this.MenuTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Panel PanelMenuStrip;
        private System.Windows.Forms.PictureBox PicIcon;
        private System.Windows.Forms.MenuStrip MenuTitleBar;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.MenuStrip MenuViewAccount;
    }
}
