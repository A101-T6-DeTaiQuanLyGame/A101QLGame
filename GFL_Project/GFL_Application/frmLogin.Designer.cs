namespace GFL_Application
{
    partial class frmLogin
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
            this.customTitleBar1 = new CustomControls.CustomTitleBar();
            this.gameLogin1 = new CustomControls.GameLogin();
            this.SuspendLayout();
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.Transparent;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.Margin = new System.Windows.Forms.Padding(0);
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(600, 25);
            this.customTitleBar1.TabIndex = 0;
            // 
            // gameLogin1
            // 
            this.gameLogin1.BackColor = System.Drawing.Color.Transparent;
            this.gameLogin1.Location = new System.Drawing.Point(0, 25);
            this.gameLogin1.Margin = new System.Windows.Forms.Padding(0);
            this.gameLogin1.Name = "gameLogin1";
            this.gameLogin1.Size = new System.Drawing.Size(600, 250);
            this.gameLogin1.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.gameLogin1);
            this.Controls.Add(this.customTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomTitleBar customTitleBar1;
        private CustomControls.GameLogin gameLogin1;
    }
}

