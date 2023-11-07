using BLL;
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
    public partial class DetailPanel : UserControl
    {
        GameBLL gameBLL = new GameBLL();
        private string gameID;
        public DetailPanel(string ID)
        {
            InitializeComponent();
            gameID = ID;
        }

        private void DetailPanel_Load(object sender, EventArgs e)
        {
            var game = gameBLL.layThongTinGame(gameID);

            lblName.Text = game.Tengame;
            lblDesc.Text = game.Chitiet;
            lblPrice.Text = game.Gia.ToString("C0").Replace("$", "");
            lblNXB.Text = game.TenNXB;
            lblTL.Text = game.DSLoai;
        }
    }
}
