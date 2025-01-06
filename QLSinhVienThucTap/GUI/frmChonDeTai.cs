using QLSinhVienThucTap.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.GUI
{
    public partial class frmChonDeTai : Form
    {
        public frmChonDeTai()
        {
            InitializeComponent();
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadDeTai();
            LoadColumnDeTai();
        }
        void LoadDeTai()
        {
            dgvListDeTai.DataSource = DeTaiBLL.GetListDeTai(Convert.ToInt32(txtPage.Text));
        }
        void LoadColumnDeTai()
        {
            dgvListDeTai.AutoGenerateColumns = false;
            dgvListDeTai.Columns["MaDeTai"].Visible = false;
            dgvListDeTai.Columns["TenDeTai"].HeaderText = "Tên đề tài";
            dgvListDeTai.Columns["MoTa"].HeaderText = "Mô tả";
            dgvListDeTai.Columns["TenDeTai"].Width = 200;
        }
        int GetLastPage()
        {
            int sumRecord = DeTaiBLL.GetNumDeTai();
            int lastPage = (sumRecord + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
        }
        #endregion
        #region Event
        private event EventHandler<SelectDeTaiEventArgs> selectDeTai;
        public event EventHandler<SelectDeTaiEventArgs> SelectDeTai
        {
            add { selectDeTai += value; }
            remove { selectDeTai -= value; }
        }
        public class SelectDeTaiEventArgs : EventArgs
        {
            private string maDeTai;
            private string tenDeTai;
            private string moTa;
            public string MaDeTai
            {
                get { return maDeTai; }
                set { maDeTai = value; }
            }
            public string TenDeTai
            {
                get { return tenDeTai; }
                set { tenDeTai = value; }
            }
            public string MoTa
            {
                get { return moTa; }
                set { moTa = value; }
            }
            public SelectDeTaiEventArgs(string maDeTai, string tenDeTai, string moTa)
            {
                this.MaDeTai = maDeTai;
                this.TenDeTai = tenDeTai;
                this.MoTa = moTa;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvListDeTai.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvListDeTai.CurrentRow.Cells[0].OwningRow;
                string maDeTai = row.Cells["MaDeTai"].Value.ToString();
                string tenDeTai = row.Cells["TenDeTai"].Value.ToString();
                string moTa = row.Cells["MoTa"].Value.ToString();
                selectDeTai(this, new SelectDeTaiEventArgs(maDeTai, tenDeTai, moTa));
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đề tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenDeTai = txtTenDeTai.Text;
            string moTa = txtMoTa.Text;
            if (DeTaiBLL.InsertDeTai(tenDeTai, moTa))
            {
                txtMoTa.Text = "";
                txtTenDeTai.Text = "";
                LoadDeTai();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListDeTai.SelectedCells.Count > 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đề tài này?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    List<string> listMaDeTai = new List<string>();
                    foreach (DataGridViewCell cell in dgvListDeTai.SelectedCells)
                    {
                        string maDeTai = cell.OwningRow.Cells["MaDeTai"].Value.ToString();
                        if (!listMaDeTai.Contains(maDeTai))
                        {
                            listMaDeTai.Add(maDeTai);
                            DeTaiBLL.DeleteDeTai(maDeTai);
                            if (Convert.ToInt32(txtPage.Text) > GetLastPage())
                            {
                                txtPage.Text = GetLastPage().ToString();
                            }
                        }
                    }
                    LoadDeTai();
                }
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            txtPage.Text = GetLastPage().ToString();
        }
        private void btnPreviousGV_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if (page > 1)
            {
                txtPage.Text = (page - 1).ToString();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if (page < GetLastPage())
            {
                txtPage.Text = (page + 1).ToString();
            }
        }
        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPage.Text) || txtPage.Text == "0")
            {
                txtPage.Text = "1";
            }
            if (Convert.ToInt32(txtPage.Text) > GetLastPage())
            {
                txtPage.Text = GetLastPage().ToString();
            }
            LoadDeTai();
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
