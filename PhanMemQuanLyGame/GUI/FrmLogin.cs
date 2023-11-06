using BLL;
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
    public partial class FrmLogin : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }



        public void LoadSettings()
        {
            PicLogo.BackgroundImage = Properties.Resources.Logo;
            PicLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PicLogo.BackColor = Color.Transparent;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;

            var kh = khBLL.LayDataKH(tk, mk);


            if(kh != null)
            {
                FrmMain main = new FrmMain(kh);
                main.Show();
                this.Hide();
            } else
            {
                if(tk == "" && mk == "")
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không được bỏ trống!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if(tk == "")
                {
                    MessageBox.Show("Tên tài khoản không được bỏ trống!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (mk == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LblRegister_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
        }
    }
}
