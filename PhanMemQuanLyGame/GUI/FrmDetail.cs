using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FrmDetail : Form
    {
        private GameBLL gameBLL = new GameBLL();
        private NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        private TheLoaiBLL tlBLL = new TheLoaiBLL();
        public FrmDetail()
        {
            InitializeComponent();

            btnConfirm.Text = "Thêm";

            txtMa.Text = gameBLL.KhoiTaoID();

            btnConfirm.Click += btnConfirmAdd_Click;
        }

        public FrmDetail(string ma, string ten, string chitiet, int dongia, string nxb, string tl)
        {
            InitializeComponent();

            txtMa.Text = ma;
            txtTen.Text = ten;
            txtChitiet.Text = chitiet;
            txtDongia.Text = dongia.ToString();

            if (cbNXB.Items.Contains(nxb))
            {
                cbNXB.SelectedItem = nxb;
            } else
            {
                cbNXB.SelectedItem = "None";
            }

            if(cbLoai.Items.Contains(tl)) {
                cbLoai.SelectedItem = tl;
            }
            else
            {
                cbLoai.SelectedItem = "None";
            }

            btnConfirm.Text = "Sửa";
            btnConfirm.BackColor = Color.Orange;

            btnConfirm.Click += btnConfirmUpdate_Click;
        }

        private void FrmDetail_Load(object sender, EventArgs e)
        {
            txtMa.Enabled = false;

            cbNXB.DataSource = nxbBLL.LayDSNhaXuatBan();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";

            cbLoai.DataSource = tlBLL.LayDSTheLoai();
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "MaLoai";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Game game = new Game()
                {
                    MaGame = txtMa.Text,
                    TenGame = txtTen.Text,
                    ChiTiet = txtChitiet.Text,
                    DonGia = int.Parse(txtDongia.Text),
                    MaNXB = cbNXB.SelectedValue.ToString(),
                    MaLoai = cbLoai.SelectedValue.ToString()
                };

                gameBLL.Insert(game);

                this.Close();
            } catch (Exception ex){
                MessageBox.Show($"Lỗi: {ex.Message}", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Game game = new Game()
                {
                    MaGame = txtMa.Text,
                    TenGame = txtTen.Text,
                    ChiTiet = txtChitiet.Text,
                    DonGia = int.Parse(txtDongia.Text),
                    MaNXB = cbNXB.SelectedValue.ToString(),
                    MaLoai = cbLoai.SelectedValue.ToString()
                };

                gameBLL.Update(game);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
