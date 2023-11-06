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

namespace CustomControls.UserControls
{
    public partial class ProfilePanel : UserControl
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        private KHACHHANG kh = null;
        public ProfilePanel()
        {
            InitializeComponent();
        }

        public void setThongTinKH(KHACHHANG a)
        {
            kh = new KHACHHANG();
            kh = a;
        }

        private void ProfilePanel_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Unknown_person;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTK.Text = kh.TenTK;
            lblQT.Text = kh.QuocTich;
            txtHoten.Text = kh.HoTen.Trim();

            DateTime ngSinh = DateTime.Parse(kh.NgSinh.ToString());
            txtNgSinh.Text = ngSinh.ToString("ddMMyyyy");

            txtCCCD.Text = kh.CCCD;
            txtDC.Text = kh.DiaChi;
            txtEmail.Text = kh.Email.Trim();
            txtSDT.Text = kh.SDT;
            cboCountry.getValue(kh.QuocTich.Trim()) ;

            PanelChangePassword.Visible = false;
            BtnChangePass.Visible = false;
            BtnChangePass.Enabled = false;

            lblTenTK.Text = kh.TenTK;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(BtnEdit.Text == "Sửa")
            {
                BtnEdit.Text = "Xác Nhận";

                BtnChangePass.Visible = true;
                BtnChangePass.Enabled = true;

                txtHoten.Enabled = true;
                txtNgSinh.Enabled = true;
                txtCCCD.Enabled = true;
                txtEmail.Enabled = true;
                txtSDT.Enabled = true;
                txtDC.Enabled = true;
                cboCountry.Enabled = true;
            } else
            {
                BtnEdit.Text = "Sửa";

                txtHoten.Enabled = false;
                txtNgSinh.Enabled = false;
                txtCCCD.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;
                txtDC.Enabled = false;
                cboCountry.Enabled = false;

                khBLL.UpdateKH(kh.MaKH, txtHoten.Text, DateTime.ParseExact(txtNgSinh.Text, "dd/MM/yyyy", null), txtEmail.Text, txtCCCD.Text, txtSDT.Text, txtDC.Text, cboCountry.SelectedItem.ToString());
            }
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            PanelChangePassword.Visible = true;
        }

        private void BtnConfirmChangePass_Click(object sender, EventArgs e)
        {
            if(txtMKCu.Text == kh.PassTK.Trim())
            {
                if(txtMKMoi.Text == txtMKMoi2.Text)
                {
                    khBLL.UpdateMK(kh.MaKH, txtMKMoi.Text);

                    PanelChangePassword.Visible = false;
                    BtnChangePass.Visible = false;
                    BtnChangePass.Enabled = false;

                    MessageBox.Show("Đổi mật khẩu thành công!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PanelChangePassword.Visible = false;
        }
    }
}
