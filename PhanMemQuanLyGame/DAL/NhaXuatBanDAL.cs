using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaXuatBanDAL
    {
        private QLGAMEDataContext dataContext;

        public NhaXuatBanDAL()
        {
            dataContext = new QLGAMEDataContext();
        }

        public List<NhaXuatBan> LayDSNhaXuatBan()
        {
            var nxb = from nhaxuatban in dataContext.NhaXuatBans select nhaxuatban;

            return nxb.ToList();
        }
    }
}
