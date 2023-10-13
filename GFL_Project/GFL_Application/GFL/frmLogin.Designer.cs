namespace GFL
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
            login1 = new CustomControls.Login();
            customFormBar1 = new CustomControls.CustomFormBar();
            SuspendLayout();
            // 
            // login1
            // 
            login1.BackColor = Color.Transparent;
            login1.Dock = DockStyle.Bottom;
            login1.Location = new Point(0, 35);
            login1.Margin = new Padding(0);
            login1.Name = "login1";
            login1.Size = new Size(500, 185);
            login1.TabIndex = 0;
            // 
            // customFormBar1
            // 
            customFormBar1.BackColor = Color.Transparent;
            customFormBar1.Dock = DockStyle.Top;
            customFormBar1.Location = new Point(0, 0);
            customFormBar1.Name = "customFormBar1";
            customFormBar1.Size = new Size(500, 35);
            customFormBar1.TabIndex = 1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(500, 220);
            Controls.Add(customFormBar1);
            Controls.Add(login1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.Login login1;
        private CustomControls.CustomFormBar customFormBar1;
    }
}