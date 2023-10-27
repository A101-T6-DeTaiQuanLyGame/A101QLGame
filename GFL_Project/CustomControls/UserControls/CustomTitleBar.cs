using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class CustomTitleBar : UserControl
    {
        bool mousedown;
        public CustomTitleBar()
        {
            InitializeComponent();
        }

        private void panelButton_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panelButton_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown= false;
        }

        private void panelButton_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown )
            {
                int x = MousePosition.X - 300;
                int y = MousePosition.Y - 12;
                this.FindForm().SetDesktopLocation(x, y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }
    }
}
