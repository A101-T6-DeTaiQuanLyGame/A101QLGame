using CustomControls.UserControls;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        private KHACHHANG kh;
        public FrmMain(KHACHHANG a)
        {
            InitializeComponent();
            kh = a;
            mainTitleBar1.LayThongTinKH(a);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BtnProfile.Text = kh.TenTK.Trim();

            PanelMain.Controls.Clear();

            StorePanel storePanel = new StorePanel();
            storePanel.Dock = DockStyle.Fill;

            PanelMain.Controls.Add(storePanel);
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            ProfilePanel profilePanel = new ProfilePanel();
            profilePanel.setThongTinKH(kh);
            profilePanel.Dock = DockStyle.Fill;

            PanelMain.Controls.Add(profilePanel);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            StorePanel storePanel = new StorePanel();
            storePanel.Dock = DockStyle.Fill;

            PanelMain.Controls.Add(storePanel);
        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            LibraryPanel libraryPanel = new LibraryPanel();
            libraryPanel.Dock = DockStyle.Fill;
            libraryPanel.getID(kh.MaKH);

            PanelMain.Controls.Add(libraryPanel);
        }
    }
}
