namespace CustomControls
{
    partial class CustomFormBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomFormBar));
            pnCustom = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            pnCustom.SuspendLayout();
            SuspendLayout();
            // 
            // pnCustom
            // 
            pnCustom.Controls.Add(btnMinimize);
            pnCustom.Controls.Add(btnClose);
            pnCustom.Dock = DockStyle.Fill;
            pnCustom.Location = new Point(0, 0);
            pnCustom.Name = "pnCustom";
            pnCustom.Size = new Size(500, 35);
            pnCustom.TabIndex = 0;
            pnCustom.MouseDown += pnCustom_MouseDown;
            pnCustom.MouseMove += pnCustom_MouseMove;
            pnCustom.MouseUp += pnCustom_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(430, 0);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(465, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // CustomFormBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnCustom);
            Name = "CustomFormBar";
            Size = new Size(500, 35);
            pnCustom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnCustom;
        private Button btnMinimize;
        private Button btnClose;
    }
}
