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
    public partial class frmDanhGiaDiem : Form
    {
        string font = "Times New Roman";

        private string maHoiDong;
        public string MaHoiDong
        {
            get { return maHoiDong; }
            set { maHoiDong = value; }
        }
        public frmDanhGiaDiem(string MaHoiDong)
        {
            InitializeComponent();
            this.MaHoiDong = MaHoiDong;
            LoadData();
            dgvListSinhVien.Font = new Font(font, 10);
        }
        #region Method
        void LoadData()
        {
            LoadDotTT();
            LoadColumn();
            LoadDiem();
        }
        void LoadDotTT()
        {
            cbDotTT.DataSource = DotThucTapBLL.GetListDotThucTap();
            cbDotTT.DisplayMember = "TenDot";
            cbDotTT.ValueMember = "MaDotTT";
            cbDotTT.SelectedIndex = 0;
        }
        void LoadColumn()
        {
            dgvListSinhVien.AutoGenerateColumns = false;
            dgvListSinhVien.Columns["MaDiem"].Visible = false;
            dgvListSinhVien.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";
            dgvListSinhVien.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvListSinhVien.Columns["TenDeTai"].HeaderText = "Đề tài";
            dgvListSinhVien.Columns["DiemSo"].HeaderText = "Điểm";
            dgvListSinhVien.Columns["MaSinhVien"].Width = 100;
            dgvListSinhVien.Columns["MaSinhVien"].ReadOnly = true;
            dgvListSinhVien.Columns["HoTen"].ReadOnly = true;
            dgvListSinhVien.Columns["TenDeTai"].ReadOnly = true;
            dgvListSinhVien.Columns["DiemSo"].Width = 50;
            dgvListSinhVien.Columns["MaSinhVien"].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvListSinhVien.Columns["HoTen"].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvListSinhVien.Columns["TenDeTai"].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvListSinhVien.Columns["DiemSo"].SortMode = DataGridViewColumnSortMode.Automatic;
            
        }
        void LoadDiem()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maDotTT = cbDotTT.SelectedValue.ToString();
            dgvListSinhVien.DataSource = DiemBLL.GetDiemSinhVien(maHoiDong, maDotTT, page);
        }
        private int GetLastPage()
        {
            int sumRecords = DiemBLL.GetNumDiem(maHoiDong, cbDotTT.SelectedValue.ToString());
            return (sumRecords + 14) / 15;
        }
        private void UpdatePageText(int page)
        {
            txtPage.Text = page.ToString();
        }
        #endregion
        #region Event
        private void cbDotTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maDotTT = cbDotTT.SelectedValue.ToString();
            dgvListSinhVien.DataSource = DiemBLL.GetDiemSinhVien(maHoiDong, maDotTT, page);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if (page > 1)
            {
                page--;
                UpdatePageText(page);
                LoadDiem();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            int lastPage = GetLastPage();
            if (page < lastPage)
            {
                page++;
                UpdatePageText(page);
                LoadDiem();
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
        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPage.Text))
            {
                txtPage.Text = "1";
            }
            int lastPage = GetLastPage();
            int currentPage = Math.Min(lastPage, Convert.ToInt32(txtPage.Text));
            UpdatePageText(currentPage);
            LoadDiem();
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgvListSinhVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListSinhVien.Columns[e.ColumnIndex].Name == "DiemSo")
            {
                DataGridViewRow row = dgvListSinhVien.Rows[e.RowIndex];
                string maDiem = row.Cells["MaDiem"].Value.ToString();
                string diemSoText = row.Cells["DiemSo"].Value?.ToString();
                float diemSo;
                if (string.IsNullOrEmpty(diemSoText))
                {
                    row.Cells["DiemSo"].Value = DBNull.Value;
                    DiemBLL.UpdateDiem(maDiem);
                }
                else if (!float.TryParse(diemSoText, out diemSo))
                    row.Cells["DiemSo"].Value = dgvListSinhVien.Tag;
                else if (diemSo < 0 || diemSo > 10)
                {
                    MessageBox.Show("Điểm số phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells["DiemSo"].Value = dgvListSinhVien.Tag;
                }
                else
                {
                    DiemBLL.UpdateDiem(maDiem, diemSo);
                }
            }
        }
        private void dgvListSinhVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception != null)
            {
                MessageBox.Show("Điểm số phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void dgvListSinhVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListSinhVien.Columns[e.ColumnIndex].Name == "DiemSo")
            {
                dgvListSinhVien.Tag = dgvListSinhVien.Rows[e.RowIndex].Cells["DiemSo"].Value;
            }
        }
        #endregion
    }
}
