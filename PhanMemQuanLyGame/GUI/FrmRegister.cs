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
    public partial class FrmRegister : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtTK.Text == "" || txtMK.Text == "" || txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Dữ liệu không được bỏ trống!", "Hệ Thống",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(txtMK.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                khBLL.RegisterKH(txtTK.Text, txtMK.Text);
                MessageBox.Show("Đăng ký thành công!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.ic_return;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
        }
    }
}
