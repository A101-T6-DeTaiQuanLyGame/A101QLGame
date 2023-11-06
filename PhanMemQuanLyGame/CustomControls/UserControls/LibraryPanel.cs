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
    public partial class LibraryPanel : UserControl
    {
        private TreeView categoryTreeView;
        private string ID;

        ThuVienBLL tvBLL = new ThuVienBLL();

        public LibraryPanel()
        {
            InitializeComponent();
        }

        public void getID(string id)
        {
            ID = id;
        }

        private void LibraryPanel_Load(object sender, EventArgs e)
        {
            List<GAME> tvGame = tvBLL.layDSThuVien(ID);

            TreeNode allNode = new TreeNode("All");
            TreeNode favoriteNode = new TreeNode("Favorite");

            treeView1.Nodes.Add(allNode);
            treeView1.Nodes.Add(favoriteNode);
            treeView1.ForeColor = Color.White;
            treeView1.Font = new Font("Times New Roman", 10, FontStyle.Bold);

            foreach (GAME item in tvGame)
            {
                allNode.Nodes.Add(new TreeNode(item.TenGame));
            }
        }
    }
}
