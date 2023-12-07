using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TheLoaiBLL
    {
        private TheLoaiDAL tlDAL;

        public TheLoaiBLL() { 
            tlDAL = new TheLoaiDAL();
        }

        public List<TheLoai> LayDSTheLoai()
        {
            return tlDAL.LayDSTheLoai();
        }
    }
}
