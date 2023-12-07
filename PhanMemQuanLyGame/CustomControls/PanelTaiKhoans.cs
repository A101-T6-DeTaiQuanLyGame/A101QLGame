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

namespace CustomControls
{
    public partial class PanelTaiKhoans : UserControl
    {
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public event EventHandler DeleteButtonClick;

        public PanelTaiKhoans()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = tkBLL.LayDSTaiKhoan();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public string LayData()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells["MaTK"].Value.ToString();

                return ma;
            }

            return null;
        }

        private void PanelTaiKhoans_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClick();
        }

        protected virtual void OnDeleteButtonClick()
        {
            DeleteButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
