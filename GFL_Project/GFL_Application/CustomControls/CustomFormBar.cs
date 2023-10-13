using GFL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class CustomFormBar : UserControl
    {
        bool Mousedown;

        public CustomFormBar()
        {
            InitializeComponent();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void pnCustom_MouseDown(object sender, MouseEventArgs e)
        {
            Mousedown = true;
        }

        private void pnCustom_MouseUp(object sender, MouseEventArgs e)
        {
            Mousedown = false;
        }

        private void pnCustom_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mousedown)
            {
                int x = MousePosition.X - 250;
                int y = MousePosition.Y - 15;
                this.FindForm().SetDesktopLocation(x, y);
            }
        }
    }
}
