namespace GFL
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
            main1 = new CustomControls.Main();
            SuspendLayout();
            // 
            // main1
            // 
            main1.BackColor = Color.FromArgb(17, 17, 17);
            main1.Dock = DockStyle.Fill;
            main1.Location = new Point(0, 0);
            main1.Name = "main1";
            main1.Size = new Size(1200, 600);
            main1.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(main1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.Main main1;
    }
}