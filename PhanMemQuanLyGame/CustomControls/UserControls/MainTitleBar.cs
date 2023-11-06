using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CustomControls.UserControls
{
    public partial class MainTitleBar : UserControl
    {
        private KHACHHANG kh = null;
        private string tk = null;
        private int sodu = 0;
        bool mousedown = false;

        public MainTitleBar()
        {
            InitializeComponent();
        }

        public void LayThongTinKH(KHACHHANG a)
        {
            kh = a;
            tk = kh.TenTK.Trim();
            sodu = (int)kh.SoDu;
        }

        public void LoadSettings()
        {
            PicIcon.BackgroundImage = Properties.Resources.Logo;
            PicIcon.BackgroundImageLayout = ImageLayout.Stretch;
            PicIcon.BackColor = Color.Transparent;

            MenuTitleBar.BackColor = Color.Transparent;
            MenuTitleBar.ForeColor = Color.White;

            BtnClose.BackgroundImage = Properties.Resources.ic_close;
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.BackColor = Color.Transparent;

            BtnMaximize.BackgroundImage = Properties.Resources.ic_maximize_open;
            BtnMaximize.BackgroundImageLayout = ImageLayout.Center;
            BtnMaximize.BackColor = Color.Transparent;

            BtnMinimize.BackgroundImage = Properties.Resources.ic_minimize;
            BtnMinimize.BackgroundImageLayout = ImageLayout.Center;
            BtnMinimize.BackColor = Color.Transparent;

            ToolStripMenuItem userMenuItem = new ToolStripMenuItem($"{tk} v   {sodu} VND");
            userMenuItem.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            userMenuItem.BackColor = Color.FromArgb(15, 68, 140);
            userMenuItem.ForeColor = Color.White;
            userMenuItem.Margin = new Padding(2);

            ToolStripMenuItem addFundsMenuItem = new ToolStripMenuItem("Nạp tiền");
            addFundsMenuItem.BackColor = Color.FromArgb(15, 68, 140);
            addFundsMenuItem.ForeColor = Color.White;
            userMenuItem.DropDownItems.Add(addFundsMenuItem);

            MenuViewAccount.Items.Add(userMenuItem);
            MenuViewAccount.LayoutStyle = ToolStripLayoutStyle.Table;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if(this.FindForm().WindowState == FormWindowState.Maximized)
            {
                BtnMaximize.BackgroundImage = Properties.Resources.ic_maximize_open;
                this.FindForm().WindowState = FormWindowState.Normal;
            } else
            {
                BtnMaximize.BackgroundImage = Properties.Resources.ic_maximize_close;
                this.FindForm().WindowState = FormWindowState.Maximized;
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

        private void MainTitleBar_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void PanelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void PanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int x = MousePosition.X - 640;
                int y = MousePosition.Y - 5;
                this.FindForm().SetDesktopLocation(x, y);
            }
        }
    }
}
