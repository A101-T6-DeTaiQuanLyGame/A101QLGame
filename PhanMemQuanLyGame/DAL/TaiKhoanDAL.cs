using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private QLGAMEDataContext dataContext;

        public TaiKhoanDAL() { 
            dataContext = new QLGAMEDataContext();
        }

        public bool DangNhap(string tk, string mk)
        {
            var taikhoan = dataContext.TaiKhoans.Where(user => user.TenTK == tk && user.MatKhau == mk).FirstOrDefault();

            if (taikhoan != null)
            {
                return true;
            }

            return false;
        }

        public List<TaiKhoan> LayDSTaiKhoan() {
            var taikhoan = from tk in dataContext.TaiKhoans select tk;

            return taikhoan.ToList();
        }

        public void Delete(string ma)
        {
            TaiKhoan deleteTK = dataContext.TaiKhoans.SingleOrDefault(item => item.MaTK == ma);

            if (deleteTK != null)
            {
                dataContext.TaiKhoans.DeleteOnSubmit(deleteTK);

                dataContext.SubmitChanges();
            }
        }
    }
}
