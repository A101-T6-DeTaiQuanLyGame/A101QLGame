namespace GUI
{
    partial class FrmMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnStore = new CustomControls.Controls.MainMenuButton();
            this.BtnLibrary = new CustomControls.Controls.MainMenuButton();
            this.BtnProfile = new CustomControls.Controls.MainMenuButton();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.mainTitleBar1 = new CustomControls.UserControls.MainTitleBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnStore);
            this.flowLayoutPanel1.Controls.Add(this.BtnLibrary);
            this.flowLayoutPanel1.Controls.Add(this.BtnProfile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1280, 70);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnStore
            // 
            this.BtnStore.BackColor = System.Drawing.Color.Transparent;
            this.BtnStore.FlatAppearance.BorderSize = 0;
            this.BtnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStore.ForeColor = System.Drawing.Color.LightGray;
            this.BtnStore.Location = new System.Drawing.Point(100, 10);
            this.BtnStore.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Size = new System.Drawing.Size(100, 50);
            this.BtnStore.TabIndex = 0;
            this.BtnStore.Text = "STORE";
            this.BtnStore.UseVisualStyleBackColor = false;
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // BtnLibrary
            // 
            this.BtnLibrary.BackColor = System.Drawing.Color.Transparent;
            this.BtnLibrary.FlatAppearance.BorderSize = 0;
            this.BtnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibrary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLibrary.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLibrary.Location = new System.Drawing.Point(250, 10);
            this.BtnLibrary.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnLibrary.Name = "BtnLibrary";
            this.BtnLibrary.Size = new System.Drawing.Size(100, 50);
            this.BtnLibrary.TabIndex = 1;
            this.BtnLibrary.Text = "LIBRARY";
            this.BtnLibrary.UseVisualStyleBackColor = false;
            this.BtnLibrary.Click += new System.EventHandler(this.BtnLibrary_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.Color.Transparent;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BtnProfile.ForeColor = System.Drawing.Color.LightGray;
            this.BtnProfile.Location = new System.Drawing.Point(400, 10);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(100, 50);
            this.BtnProfile.TabIndex = 2;
            this.BtnProfile.Text = "PROFILE";
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 100);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.PanelMain.Size = new System.Drawing.Size(1280, 620);
            this.PanelMain.TabIndex = 2;
            // 
            // mainTitleBar1
            // 
            this.mainTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.mainTitleBar1.Name = "mainTitleBar1";
            this.mainTitleBar1.Size = new System.Drawing.Size(1280, 30);
            this.mainTitleBar1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.UserControls.MainTitleBar mainTitleBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.Controls.MainMenuButton BtnStore;
        private CustomControls.Controls.MainMenuButton BtnLibrary;
        private CustomControls.Controls.MainMenuButton BtnProfile;
        private System.Windows.Forms.Panel PanelMain;
    }
}