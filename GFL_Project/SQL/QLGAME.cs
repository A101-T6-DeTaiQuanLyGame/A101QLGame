using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class GAMEUI
    {
        public string Tengame { get; set; }
        public int Gia { get; set; }
        public string TenNXB { get; set; }
        public string DSLoai { get; set; }
    }

    public class QLGAME
    {
        QLGAMEDataContext qlgame = new QLGAMEDataContext();
        public QLGAME()
        {

        }

        public KHACHHANG ktraLogin(string tk, string mk)
        {
            var user = qlgame.KHACHHANGs.SingleOrDefault(u => u.TenTK == tk && u.PassTK == mk);

            if (user != null)
            {
                return user;
            }
            return null;
        }

        public List<GAMEUI> getList()
        {
            var gameUI = (from GAME in qlgame.GAMEs
                             join NHAXUATBAN in qlgame.NHAXUATBANs on GAME.MaNXB equals NHAXUATBAN.MaNXB
                             join DSLOAIGAME in qlgame.DSLOAIGAMEs on GAME.MaGAME equals DSLOAIGAME.MaGAME
                             join THELOAI in qlgame.THELOAIs on DSLOAIGAME.MaLoai equals THELOAI.MaLoai
                             group new { GAME, NHAXUATBAN, THELOAI } by new { GAME.Tengame, GAME.Gia, NHAXUATBAN.TenNXB } into grouped
                             select new GAMEUI
                             {
                                 Tengame = grouped.Key.Tengame,
                                 Gia = (int)grouped.Key.Gia,
                                 TenNXB = grouped.Key.TenNXB,
                                 DSLoai = string.Join(", ", grouped.Select(x => x.THELOAI.Ten))
                             }).ToList();

            return gameUI;
        }

        public KHACHHANG getDetailKH(string maKH)
        {
            var kh = qlgame.KHACHHANGs.SingleOrDefault(u => u.MaKH == maKH);

            return kh;
        }
    }
}
