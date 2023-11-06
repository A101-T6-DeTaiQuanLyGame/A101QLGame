using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public class MainMenuButton : Button
    {
        private Color hoverColor = Color.Transparent;

        public MainMenuButton() {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.LightGray;
            this.Font = new Font("Tahoma", 12, FontStyle.Bold);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Width = 100;
            this.Height = 50;
            this.Margin = new Padding(50, 0, 0, 0);

            this.MouseEnter += MainMenuButton_MouseEnter;
            this.MouseLeave += MainMenuButton_MouseLeave;
        }

        private void MainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.LightGray;
        }

        private void MainMenuButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(19, 39, 66);
            this.ForeColor = Color.White;
        }
    }
}
