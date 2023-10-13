namespace CustomControls
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            menuStrip1 = new MenuStrip();
            tsmiSettings = new ToolStripMenuItem();
            tsmiView = new ToolStripMenuItem();
            tsmiFriends = new ToolStripMenuItem();
            tsmiHelp = new ToolStripMenuItem();
            panel2 = new Panel();
            btnStore = new Button();
            btnLibrary = new Button();
            btnProfile = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 30);
            panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1110, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Center;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(1140, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1170, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiSettings, tsmiView, tsmiFriends, tsmiHelp });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(308, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSettings
            // 
            tsmiSettings.AutoSize = false;
            tsmiSettings.ForeColor = Color.FromArgb(80, 80, 80);
            tsmiSettings.Name = "tsmiSettings";
            tsmiSettings.Size = new Size(80, 30);
            tsmiSettings.Text = "Settings";
            // 
            // tsmiView
            // 
            tsmiView.AutoSize = false;
            tsmiView.ForeColor = Color.FromArgb(80, 80, 80);
            tsmiView.Name = "tsmiView";
            tsmiView.Size = new Size(80, 30);
            tsmiView.Text = "View";
            // 
            // tsmiFriends
            // 
            tsmiFriends.AutoSize = false;
            tsmiFriends.ForeColor = Color.FromArgb(80, 80, 80);
            tsmiFriends.Name = "tsmiFriends";
            tsmiFriends.Size = new Size(70, 30);
            tsmiFriends.Text = "Friends";
            // 
            // tsmiHelp
            // 
            tsmiHelp.AutoSize = false;
            tsmiHelp.ForeColor = Color.FromArgb(80, 80, 80);
            tsmiHelp.Name = "tsmiHelp";
            tsmiHelp.Size = new Size(70, 30);
            tsmiHelp.Text = "Help";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnLibrary);
            panel2.Controls.Add(btnStore);
            panel2.Location = new Point(0, 33);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 0, 0, 0);
            panel2.Size = new Size(1200, 50);
            panel2.TabIndex = 1;
            // 
            // btnStore
            // 
            btnStore.Dock = DockStyle.Left;
            btnStore.FlatAppearance.BorderSize = 0;
            btnStore.FlatStyle = FlatStyle.Flat;
            btnStore.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnStore.ForeColor = Color.FromArgb(80, 80, 80);
            btnStore.Location = new Point(50, 0);
            btnStore.Margin = new Padding(0, 0, 30, 0);
            btnStore.Name = "btnStore";
            btnStore.Size = new Size(100, 50);
            btnStore.TabIndex = 0;
            btnStore.Text = "Stores";
            btnStore.UseVisualStyleBackColor = true;
            // 
            // btnLibrary
            // 
            btnLibrary.Dock = DockStyle.Left;
            btnLibrary.FlatAppearance.BorderSize = 0;
            btnLibrary.FlatStyle = FlatStyle.Flat;
            btnLibrary.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibrary.ForeColor = Color.FromArgb(80, 80, 80);
            btnLibrary.Location = new Point(150, 0);
            btnLibrary.Margin = new Padding(0, 0, 30, 0);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(100, 50);
            btnLibrary.TabIndex = 1;
            btnLibrary.Text = "Library";
            btnLibrary.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Left;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.FromArgb(80, 80, 80);
            btnProfile.Location = new Point(250, 0);
            btnProfile.Margin = new Padding(0, 0, 30, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(100, 50);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profiles";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 16);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Size = new Size(1200, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiSettings;
        private ToolStripMenuItem tsmiView;
        private ToolStripMenuItem tsmiFriends;
        private ToolStripMenuItem tsmiHelp;
        private Panel panel2;
        private Button btnProfile;
        private Button btnLibrary;
        private Button btnStore;
    }
}
