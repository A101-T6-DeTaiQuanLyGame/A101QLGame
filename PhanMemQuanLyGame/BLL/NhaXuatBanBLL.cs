using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaXuatBanBLL
    {
        private NhaXuatBanDAL nxbDAL;

        public NhaXuatBanBLL()
        {
            nxbDAL = new NhaXuatBanDAL();
        }

        public List<NhaXuatBan> LayDSNhaXuatBan()
        {
            return nxbDAL.LayDSNhaXuatBan();
        }
    }
}
