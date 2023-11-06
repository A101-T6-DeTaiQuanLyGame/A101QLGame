using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.UserControls
{
    public partial class LoginTitleBar : UserControl
    {
        bool mousedown = false;
        public LoginTitleBar()
        {
            InitializeComponent();
        }

        public void LoadSettings()
        {
            BtnClose.BackgroundImage = Properties.Resources.ic_close;
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.BackColor = Color.Transparent;

            BtnMinimize.BackgroundImage = Properties.Resources.ic_minimize;
            BtnMinimize.BackgroundImageLayout = ImageLayout.Center;
            BtnMinimize.BackColor = Color.Transparent;
        }

        private void PanelBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void PanelBar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void PanelBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown) { 
                int x = MousePosition.X - 250;
                int y = MousePosition.Y - 10;
                this.FindForm().SetDesktopLocation(x, y);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void LoginTitleBar_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
