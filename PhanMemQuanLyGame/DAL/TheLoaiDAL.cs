using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiDAL
    {
        private QLGAMEDataContext dataContext;

        public TheLoaiDAL() { 
            dataContext = new QLGAMEDataContext();
        }

        public List<TheLoai> LayDSTheLoai()
        {
            var tl = from theloai in dataContext.TheLoais select theloai;

            return tl.ToList();
        }
    }
}
