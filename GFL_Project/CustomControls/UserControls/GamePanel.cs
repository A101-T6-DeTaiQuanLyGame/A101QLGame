using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.UserControls
{
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        public string GameName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string GameTag
        {
            get { return lblTag.Text; }
            set { lblTag.Text = value; }
        }

        public string GameNXB
        {
            get { return lblNXB.Text; }
            set { lblNXB.Text = value; }
        }

        public string GamePrice
        {
            get { return lblPrice.Text; } 
            set { lblPrice.Text = value; }
        }

        private void GamePanel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            
        }

        private void GamePanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCoral;
        }
    }
}
