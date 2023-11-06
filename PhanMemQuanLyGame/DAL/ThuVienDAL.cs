using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuVienDAL
    {
        private QLGAMEDataContext dataContext;

        public ThuVienDAL()
        {
            dataContext = new QLGAMEDataContext();
        }

        public List<GAME> getDataThuVien(string id)
        {
            var g = dataContext.GAMEs.Join(dataContext.THUVIENs, game => game.MaGAME, tv => tv.MaGAME, (game, tv) => new { Game = game, Library = tv }).Where(k => k.Library.MaKH == id).Select(k => k.Game);

            return g.ToList();
        }
    }
}
