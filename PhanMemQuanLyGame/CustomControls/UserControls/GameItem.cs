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
    public partial class GameItem : UserControl
    {
        public GameItem()
        {
            InitializeComponent();
        }

        public string ID
        {
            get;
            set;
        }

        public string GameName
        {
            get { return lblGame.Text; }
            set { lblGame.Text = value; }
        }

        public string GamePrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        private void GameItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void GameItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}
