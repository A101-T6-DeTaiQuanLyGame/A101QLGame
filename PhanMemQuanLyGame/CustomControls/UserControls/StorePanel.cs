using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.UserControls
{
    public partial class StorePanel : UserControl
    {
        GameBLL gameBLL = new GameBLL();
        public StorePanel()
        {
            InitializeComponent();
        }

        private void StorePanel_Load(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = Properties.Resources.ic_search;
            btnSearch.BackgroundImageLayout = ImageLayout.Center;

            List<GAME> glist = gameBLL.layDSGame();

            foreach(GAME g in glist)
            {
                string ten = g.TenGame.Trim();
                int price = (int)g.DonGia;
                GameItem item = new GameItem
                {
                    GameName = ten,
                    
                    GamePrice = price.ToString("C"),
                };

                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
