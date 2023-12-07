using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GameInfo
    {
        public string MaGame { get; set; }
        public string TenGame { get; set; }
        public string ChiTiet { get; set; }
        public int DonGia { get; set; }
        public string TenNXB { get; set; }
        public string TenLoai { get; set; }
    }

    public class GameDAL
    {
        private QLGAMEDataContext gameDataContext;

        public GameDAL() { 
            gameDataContext = new QLGAMEDataContext();
        }

        public List<GameInfo> LayDSGame()
        {
            var games = from game in gameDataContext.Games
                        join nxb in gameDataContext.NhaXuatBans on game.MaNXB equals nxb.MaNXB
                        join theloai in gameDataContext.TheLoais on game.MaLoai equals theloai.MaLoai
                        select new GameInfo
                        {
                            MaGame = game.MaGame,
                            TenGame = game.TenGame,
                            ChiTiet = game.ChiTiet,
                            DonGia = (int)game.DonGia,
                            TenNXB = nxb.TenNXB,
                            TenLoai = theloai.TenLoai
                        };

            return games.ToList();
        }

        public string KhoiTaoID()
        {
            string ID = gameDataContext.Games
                    .OrderByDescending(item => item.MaGame)
                    .Select(item => item.MaGame)
                    .FirstOrDefault();

            int newID = int.Parse(ID.Substring(1)) + 1;

            string GeneratedID = $"G{newID:D3}";


            return GeneratedID;
        }

        public void Insert(Game g)
        {
            if(g != null)
            {
                gameDataContext.Games.InsertOnSubmit(g);
                gameDataContext.SubmitChanges();
            }
        }

        public void Update(Game g)
        {
            Game updateGame = gameDataContext.Games.SingleOrDefault(item => item.MaGame == g.MaGame);

            if(updateGame != null)
            {
                updateGame.TenGame = g.TenGame;
                updateGame.ChiTiet = g.ChiTiet;
                updateGame.DonGia = g.DonGia;
                updateGame.MaNXB = g.MaNXB;
                updateGame.MaLoai = g.MaLoai;

                gameDataContext.SubmitChanges();
            }
        }

        public void Delete(string ma)
        {
            Game deleteGame = gameDataContext.Games.SingleOrDefault(item => item.MaGame == ma);

            if(deleteGame != null)
            {
                gameDataContext.Games.DeleteOnSubmit(deleteGame);

                gameDataContext.SubmitChanges();
            }
        }
    }
}
