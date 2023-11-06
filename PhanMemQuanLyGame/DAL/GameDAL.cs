using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
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
    }
}
