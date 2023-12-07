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

namespace CustomControls
{
    public partial class PanelGames : UserControl
    {
        private GameBLL gameBLL = new GameBLL();
        public event EventHandler AddButtonClick, EditButtonClick, DeleteButtonClick;

        public class UserControlData
        {
            public string MaGame { get; set; }
            public string TenGame { get; set; }
            public string ChiTiet { get; set; }
            public int DonGia { get; set; }
            public string TenNXB { get; set; }
            public string TenLoai { get; set; }
        }

        public PanelGames()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = gameBLL.LayDSGame();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public UserControlData LayData()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells["MaGame"].Value.ToString();
                string ten = dataGridView1.SelectedRows[0].Cells["TenGame"].Value.ToString();
                string chitiet = dataGridView1.SelectedRows[0].Cells["ChiTiet"].Value.ToString();
                int dongia = int.Parse(dataGridView1.SelectedRows[0].Cells["DonGia"].Value.ToString());
                string nxb = dataGridView1.SelectedRows[0].Cells["TenNXB"].Value.ToString();
                string theloai = dataGridView1.SelectedRows[0].Cells["TenLoai"].Value.ToString();

                return new UserControlData { MaGame = ma, TenGame = ten, ChiTiet = chitiet, DonGia = dongia, TenNXB = nxb, TenLoai = theloai };
            }

            return null;
        }

        private void PanelGames_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAddButtonClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEditButtonClick();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        protected virtual void OnDeleteButtonClick()
        {
            DeleteButtonClick?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnAddButtonClick()
        {
            AddButtonClick?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnEditButtonClick()
        {
            EditButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
