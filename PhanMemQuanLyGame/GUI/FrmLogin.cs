using BLL;
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
    public partial class FrmLogin : Form
    {
        private TaiKhoanBLL tkBLL;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tkBLL = new TaiKhoanBLL();

            this.BackgroundImage = Properties.Resources.Banner;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tkBLL.DangNhap(txtUser.Text, txtPass.Text))
            {
                this.Hide();
                FrmMain main = new FrmMain();
                main.Show();
            } else
            {
                MessageBox.Show("Tài khoản không có quyền hạn đăng nhập hoặc sai dữ liệu. Vui lòng đăng nhập lại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
