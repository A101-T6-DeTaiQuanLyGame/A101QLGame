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
    public partial class GameLogin : UserControl
    {
        QLGAME sql = new QLGAME();
        private static Form frm;
        public static string ID;

        public GameLogin()
        {
            InitializeComponent();
        }

        public void getForm(Form form)
        {
            frm = form;
        }

        public bool KtraLogin(string tk, string mk)
        {
            var kh = sql.ktraLogin(tk, mk);

            if (kh != null)
            {
                ID = kh.MaKH;
                return true;
            }

            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;

            if (KtraLogin(tk, mk))
            {
                frm.Show();
                this.FindForm().Hide();
            } else
            {
                MessageBox.Show("Đăng nhập không thành công","Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
