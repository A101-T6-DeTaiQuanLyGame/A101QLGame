namespace GFL_Application
{
    partial class frmMain
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
            this.gameMainMenu1 = new CustomControls.GameMainMenu();
            this.SuspendLayout();
            // 
            // gameMainMenu1
            // 
            this.gameMainMenu1.BackColor = System.Drawing.Color.Transparent;
            this.gameMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.gameMainMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.gameMainMenu1.Name = "gameMainMenu1";
            this.gameMainMenu1.Size = new System.Drawing.Size(1280, 720);
            this.gameMainMenu1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.gameMainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.GameMainMenu gameMainMenu1;
    }
}