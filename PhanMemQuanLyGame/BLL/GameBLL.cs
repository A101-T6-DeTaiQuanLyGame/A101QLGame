using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GameBLL
    {
        private GameDAL gameDAL;

        public GameBLL() { 
            gameDAL = new GameDAL();
        }

        public List<GameInfo> LayDSGame()
        {
            return gameDAL.LayDSGame();
        }

        public string KhoiTaoID()
        {
            return gameDAL.KhoiTaoID();
        }

        public void Insert(Game g)
        {
            gameDAL.Insert(g);
        }

        public void Update(Game g)
        {
            gameDAL.Update(g);
        }

        public void Delete(string ma)
        {
            gameDAL.Delete(ma);
        }
    }
}
