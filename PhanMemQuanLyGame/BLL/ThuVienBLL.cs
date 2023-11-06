using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuVienBLL
    {
        private ThuVienDAL DAL;

        public ThuVienBLL() { 
            DAL = new ThuVienDAL();
        }

        public List<GAME> layDSThuVien(string id)
        {
            return DAL.getDataThuVien(id);
        }
    }
}
