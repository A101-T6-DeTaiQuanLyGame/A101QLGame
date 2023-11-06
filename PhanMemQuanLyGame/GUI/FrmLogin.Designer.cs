namespace GUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelRegister = new System.Windows.Forms.Panel();
            this.LblRegister = new System.Windows.Forms.Label();
            this.LblNewpassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.customBars1 = new CustomControls.UserControls.LoginTitleBar();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PanelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRegister
            // 
            this.PanelRegister.Controls.Add(this.LblRegister);
            this.PanelRegister.Controls.Add(this.LblNewpassword);
            this.PanelRegister.Controls.Add(this.BtnLogin);
            this.PanelRegister.Controls.Add(this.txtMK);
            this.PanelRegister.Controls.Add(this.txtTK);
            this.PanelRegister.Controls.Add(this.label1);
            this.PanelRegister.Controls.Add(this.LblName);
            this.PanelRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRegister.Location = new System.Drawing.Point(170, 30);
            this.PanelRegister.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRegister.Name = "PanelRegister";
            this.PanelRegister.Size = new System.Drawing.Size(330, 170);
            this.PanelRegister.TabIndex = 2;
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(116)))), ((int)(((byte)(220)))));
            this.LblRegister.Location = new System.Drawing.Point(208, 147);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(119, 14);
            this.LblRegister.TabIndex = 6;
            this.LblRegister.Text = "Bạn chưa có tài khoản?";
            this.LblRegister.Click += new System.EventHandler(this.LblRegister_Click);
            // 
            // LblNewpassword
            // 
            this.LblNewpassword.AutoSize = true;
            this.LblNewpassword.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(116)))), ((int)(((byte)(220)))));
            this.LblNewpassword.Location = new System.Drawing.Point(233, 82);
            this.LblNewpassword.Name = "LblNewpassword";
            this.LblNewpassword.Size = new System.Drawing.Size(85, 14);
            this.LblNewpassword.TabIndex = 5;
            this.LblNewpassword.Text = "Quên mật khẩu?";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(108, 111);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Đăng Nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(108, 59);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(210, 20);
            this.txtMK.TabIndex = 3;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(108, 23);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(210, 20);
            this.txtTK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(31, 30);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 14);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Tài khoản:";
            // 
            // customBars1
            // 
            this.customBars1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customBars1.Location = new System.Drawing.Point(0, 0);
            this.customBars1.Margin = new System.Windows.Forms.Padding(0);
            this.customBars1.Name = "customBars1";
            this.customBars1.Size = new System.Drawing.Size(500, 30);
            this.customBars1.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicLogo.Location = new System.Drawing.Point(0, 30);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(170, 170);
            this.PicLogo.TabIndex = 7;
            this.PicLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.PanelRegister);
            this.Controls.Add(this.customBars1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PanelRegister.ResumeLayout(false);
            this.PanelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.UserControls.LoginTitleBar customBars1;
        private System.Windows.Forms.Panel PanelRegister;
        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label LblNewpassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}