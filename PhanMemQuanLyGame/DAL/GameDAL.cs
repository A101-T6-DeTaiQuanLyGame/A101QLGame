using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetailGame
    {
        public string Tengame { get; set; }
        public int Gia { get; set; }
        public string TenNXB { get; set; }
        public string Chitiet {  get; set; }
        public string DSLoai { get; set; }
    }

    public class GameDAL
    {
        private QLGAMEDataContext dataContext;

        public GameDAL()
        {
            dataContext = new QLGAMEDataContext();
        }

        public List<GAME> getList()
        {
            var game = from g in dataContext.GAMEs select g;

            return game.ToList();
        }

        public DetailGame getDetail(string id)
        {
            var game = (from g in dataContext.GAMEs
                                    join nxb in dataContext.NHAXUATBANs on g.MaNXB equals nxb.MaNXB
                                    join dstheloai in dataContext.DSLOAIGAMEs on g.MaGAME equals dstheloai.MaGAME
                                    join theloai in dataContext.THELOAIs on dstheloai.MaLoai equals theloai.MaLoai
                                    where g.MaGAME == id
                                    group new { g, nxb, theloai } by new { g.TenGame, g.DonGia, g.ChiTiet, nxb.TenNXB } into grouped
                                    select new DetailGame
                                    {
                                        Tengame = grouped.Key.TenGame,
                                        Gia = (int)grouped.Key.DonGia,
                                        TenNXB = grouped.Key.TenNXB,
                                        Chitiet = grouped.Key.ChiTiet,
                                        DSLoai = string.Join(", ", grouped.Select(x => x.theloai.TenLoai))
                                    }).FirstOrDefault();

            return game;
        }
    }
}
