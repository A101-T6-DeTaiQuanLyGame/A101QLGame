using BLL;
using CustomControls;
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
        private GameBLL gameBLL = new GameBLL();
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        private PanelGames panelGames;
        private PanelTaiKhoans panelTKs;
        private FrmDetail frmDetail;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            } else
            {
                CloseAllForms();
            }
        }

        private void CloseAllForms()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm != this)
                {
                    formsToClose.Add(openForm);
                }
            }

            foreach (Form formToClose in formsToClose)
            {
                formToClose.Close();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            panelGames = new PanelGames();
            panelGames.Dock = DockStyle.Fill;

            panelMain.Controls.Add(panelGames);

            panelGames.AddButtonClick += Game_AddButtonClick;
            panelGames.EditButtonClick += Game_EditButtonClick;
            panelGames.DeleteButtonClick += Game_DeleteButtonClick;
        }

        private void btnTKs_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            panelTKs = new PanelTaiKhoans();
            panelTKs.Dock = DockStyle.Fill;

            panelMain.Controls.Add(panelTKs);

            panelTKs.DeleteButtonClick += TK_DeleteButtonClick;
        }

        private void Game_AddButtonClick(object sender, EventArgs e)
        {
            int MainX = this.Location.X + this.Width;
            int MainY = this.Location.Y + 62;

            

            if (frmDetail != null && !frmDetail.IsDisposed)
            {
                MessageBox.Show("Bạn vui lòng hủy dịch vụ trước đó trước khi mở một dịch vụ mới.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                frmDetail = new FrmDetail();

                frmDetail.Location = new Point(MainX, MainY);

                frmDetail.Show();
            }
        }

        private void Game_EditButtonClick(object sender, EventArgs e)
        {
            if (frmDetail != null && !frmDetail.IsDisposed)
            {
                MessageBox.Show("Bạn vui lòng hủy dịch vụ trước đó trước khi mở một dịch vụ mới.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                PanelGames.UserControlData data = panelGames.LayData();

                int MainX = this.Location.X + this.Width;
                int MainY = this.Location.Y + 62;

                frmDetail = new FrmDetail(data.MaGame, data.TenGame, data.ChiTiet, data.DonGia, data.TenNXB, data.TenLoai);

                frmDetail.Location = new Point(MainX, MainY);

                frmDetail.Show();
            }
        }

        private void Game_DeleteButtonClick(object sender, EventArgs e)
        {
            PanelGames.UserControlData data = panelGames.LayData();

            gameBLL.Delete(data.MaGame);
        }

        private void TK_DeleteButtonClick(object sender, EventArgs e)
        {
            string ma = panelTKs.LayData();

            tkBLL.Delete(ma);
        }
    }
}
