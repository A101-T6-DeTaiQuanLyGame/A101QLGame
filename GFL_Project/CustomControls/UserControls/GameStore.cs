using CustomControls.UserControls;
using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class GameStore : UserControl
    {
        QLGAME sql = new QLGAME();
        List<GAMEUI> lstGame = new List<GAMEUI>();

        public GameStore()
        {

            InitializeComponent();
            loadListGame();
        }

        public void loadListGame()
        {
            lstGame = sql.getList();

            foreach (GAMEUI game in lstGame)
            {
                GamePanel panel = new GamePanel
                {
                    GameName = game.Tengame.ToString(),
                    GameNXB = game.TenNXB.ToString(),
                    GameTag = game.DSLoai.ToString(),
                    GamePrice = game.Gia.ToString() + "VNĐ",
                };

                flowLayoutPanel1.Controls.Add(panel);
            }
            flowLayoutPanel1.AutoScroll = true;
        }
    }
}
