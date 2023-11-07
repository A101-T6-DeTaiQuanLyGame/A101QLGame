using BLL;
using CustomControls.Controls;
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
        public event EventHandler<ItemClickEventArgs> ItemClick;

        public StorePanel()
        {
            InitializeComponent();
        }

        private void StorePanel_Load(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = Properties.Resources.ic_search;
            btnSearch.BackgroundImageLayout = ImageLayout.Center;

            loadDS(gameBLL.layDSGame());
        }

        private void loadDS(List<GAME> glist)
        {
            foreach (GAME g in glist)
            {
                string ten = g.TenGame.Trim();
                int price = (int)g.DonGia;
                GameItem item = new GameItem
                {
                    ID = g.MaGAME,
                    GameName = ten,
                    GamePrice = price.ToString("C0").Replace("$", "") + " VND",
                };

                item.Click += Game_ViewDetail;

                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void Game_ViewDetail(object sender, EventArgs e)
        {
            GameItem clickedItem = sender as GameItem;
            if (clickedItem != null)
            {
                string id = clickedItem.ID;
                ItemClick?.Invoke(this, new ItemClickEventArgs(id));
            }
        }
    }
}
