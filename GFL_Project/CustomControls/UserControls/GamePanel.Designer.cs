namespace CustomControls.UserControls
{
    partial class GamePanel
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblNXBTitle = new System.Windows.Forms.Label();
            this.lblNXB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblName.Location = new System.Drawing.Point(2, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagTitle.Location = new System.Drawing.Point(-1, 260);
            this.lblTagTitle.Margin = new System.Windows.Forms.Padding(20);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(31, 13);
            this.lblTagTitle.TabIndex = 1;
            this.lblTagTitle.Text = "Tag:";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(173, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 19);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "price";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(35, 260);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(23, 13);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "tag";
            // 
            // lblNXBTitle
            // 
            this.lblNXBTitle.AutoSize = true;
            this.lblNXBTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXBTitle.Location = new System.Drawing.Point(14, 312);
            this.lblNXBTitle.Name = "lblNXBTitle";
            this.lblNXBTitle.Size = new System.Drawing.Size(44, 17);
            this.lblNXBTitle.TabIndex = 4;
            this.lblNXBTitle.Text = "NXB:";
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.Location = new System.Drawing.Point(64, 312);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(32, 17);
            this.lblNXB.TabIndex = 5;
            this.lblNXB.Text = "nxb";
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblNXB);
            this.Controls.Add(this.lblNXBTitle);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTagTitle);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(300, 350);
            this.MouseLeave += new System.EventHandler(this.GamePanel_MouseLeave);
            this.MouseHover += new System.EventHandler(this.GamePanel_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblNXBTitle;
        private System.Windows.Forms.Label lblNXB;
    }
}
