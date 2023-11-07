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
        private GameDAL DAL;

        public GameBLL()
        {
            DAL = new GameDAL();
        }

        public List<GAME> layDSGame()
        {
            return DAL.getList();
        }

        public DetailGame layThongTinGame(string id)
        {
            return DAL.getDetail(id);
        }
    }
}
