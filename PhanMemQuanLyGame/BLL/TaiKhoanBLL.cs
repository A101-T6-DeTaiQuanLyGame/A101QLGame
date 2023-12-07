using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL tkDAL;

        public TaiKhoanBLL()
        {
            tkDAL = new TaiKhoanDAL();
        }

        public bool DangNhap(string tk, string mk)
        {
            return tkDAL.DangNhap(tk, mk);
        }

        public List<TaiKhoan> LayDSTaiKhoan()
        {
            return tkDAL.LayDSTaiKhoan();
        }

        public void Delete(string ma)
        {
            tkDAL.Delete(ma);
        }
    }
}
