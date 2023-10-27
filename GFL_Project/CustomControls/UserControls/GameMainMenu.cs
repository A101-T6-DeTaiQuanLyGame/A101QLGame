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
    public partial class GameMainMenu : UserControl
    {
        bool mousedown;
        public GameMainMenu()
        {
            InitializeComponent();
            loadSettings();
        }

        public void loadSettings()
        {
            btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.FindForm().WindowState == FormWindowState.Maximized)
            {
                this.FindForm().WindowState = FormWindowState.Normal;
            } else
            {
                this.FindForm().WindowState = FormWindowState.Maximized;
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int x = MousePosition.X - 640;
                int y = MousePosition.Y;
                this.FindForm().SetDesktopLocation(x, y);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            GameProfile profile = new GameProfile();
            panelMain.Controls.Clear();

            panelMain.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            GameLibrary library = new GameLibrary();
            panelMain.Controls.Clear();

            panelMain.Controls.Add(library);
            library.Dock = DockStyle.Fill;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            GameStore store = new GameStore();
            panelMain.Controls.Clear();

            panelMain.Controls.Add(store);
            store.Dock = DockStyle.Fill;
        }
    }
}
