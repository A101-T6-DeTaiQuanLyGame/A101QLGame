using SQL;
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
    public partial class GameProfile : UserControl
    {
        private string ID = GameLogin.ID;
        QLGAME sql = new QLGAME();
        public GameProfile()
        {
            InitializeComponent();
            loadDetail();
        }

        public void loadDetail()
        {
            KHACHHANG kh = sql.getDetailKH(ID);

            txtTK.Text = kh.TenTK.ToString();
            txtMK.Text = kh.PassTK.ToString();

            txtHoten.Text = kh.Hoten.ToString();
            txtNgaysinh.Text = kh.NgSinh.Value.ToShortDateString();
            txtCCCD.Text = kh.CCCD.ToString();
            txtSDT.Text = kh.SDT.ToString();
            txtEmail.Text = kh.Email.ToString();
            txtDC.Text = kh.Diachi.ToString();
        }
    }
}
