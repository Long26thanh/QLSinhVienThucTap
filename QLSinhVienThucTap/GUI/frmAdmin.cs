using QLSinhVienThucTap.BLL;
using QLSinhVienThucTap.DTO;
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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadLop();
            LoadSinhVien();
            LoadColumnSinhVien();
        }
        void LoadLop()
        {
            cbLop.DataSource = LopBLL.GetListLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbLop.SelectedIndex = 0;
        }
        void LoadSinhVien()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maLop = cbLop.SelectedValue.ToString();
            dgvListSinhVien.DataSource = SinhVienBLL.GetListSinhVienByLop(maLop, page);
        }
        void LoadColumnSinhVien()
        {
            dgvListSinhVien.AutoGenerateColumns = false;
            dgvListSinhVien.Columns["MaLop"].Visible = false;
            dgvListSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";
            dgvListSinhVien.Columns["TenSV"].HeaderText = "Họ và tên";
            dgvListSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvListSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvListSinhVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvListSinhVien.Columns["Email"].HeaderText = "Email";
            dgvListSinhVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvListSinhVien.Columns["MaSV"].Width = 100;
            dgvListSinhVien.Columns["TenSV"].Width = 125;
            dgvListSinhVien.Columns["NgaySinh"].Width = 100;
            dgvListSinhVien.Columns["GioiTinh"].Width = 75;
            dgvListSinhVien.Columns["DiaChi"].Width = 200;
            dgvListSinhVien.Columns["Email"].Width = 150;
            dgvListSinhVien.Columns["SoDienThoai"].Width = 100;
        }
        int GetLastPage()
        {
            int sumRecords = SinhVienBLL.GetNumSinhVienByLop(cbLop.SelectedValue.ToString());
            return (sumRecords + 14) / 15;
        }
        void resetSinhVien()
        {
            txtAddHoTenSV.Text = "";
            chkGioiTinh.Checked = false;
            dtpNgaySinhSV.Value = DateTime.Now;
            txtEmailSV.Text = "";
            txtPhoneSV.Text = "";
            txtDiaChiSV.Text = "";
        }
        #endregion
        #region Event
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (txtPage.Text == "")
            {
                txtPage.Text = "1";
            }
            int lastPage = GetLastPage();
            int currentPage = Math.Min(lastPage, Convert.ToInt32(txtPage.Text));
            LoadSinhVien();
            txtPage.Text = currentPage.ToString();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            txtPage.Text = GetLastPage().ToString();
        }
        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTenSV.Text;
            if(string.IsNullOrEmpty(maSV) && string.IsNullOrEmpty(hoTen))
            {
                LoadSinhVien();
                return;
            }
            dgvListSinhVien.DataSource = SinhVienBLL.TimKiemSV(maSV, hoTen);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if (page > 1)
            {
                page--;
            }
            txtPage.Text = page.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            int lastPage = GetLastPage();
            if (page < lastPage)
            {
                page++;
            }
            txtPage.Text = page.ToString();
        }
        private void dgvListSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListSinhVien.Columns[e.ColumnIndex].Name == "NgaySinh" && e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
            }
        }
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            string hoTen = txtAddHoTenSV.Text;
            DateTime ngaySinh = dtpNgaySinhSV.Value;
            bool gioiTinh = chkGioiTinh.Checked;
            string sdt = txtPhoneSV.Text;
            string diaChi = txtDiaChiSV.Text;
            string email = txtEmailSV.Text;
            string maLop = cbLop.SelectedValue.ToString();
            SinhVienBLL.InsertSinhVien(hoTen, ngaySinh, gioiTinh, sdt, diaChi, email, maLop);
            resetSinhVien();
            LoadSinhVien();
        }
        private void dgvListSinhVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListSinhVien.Rows[e.RowIndex];
                string MaSV = row.Cells["MaSV"].Value.ToString();
                string TenSV = row.Cells["TenSV"].Value.ToString();
                DateTime NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                bool GioiTinh = Convert.ToBoolean(row.Cells["GioiTinh"].Value);
                string SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                string DiaChi = row.Cells["DiaChi"].Value.ToString();
                string Email = row.Cells["Email"].Value.ToString();
                SinhVienBLL.UpdateSinhVien(MaSV, TenSV, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email);
                LoadSinhVien();
            }
        }
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmDelete == DialogResult.Yes)
            {
                int rowIndex = dgvListSinhVien.SelectedCells[0].RowIndex;
                string maSV = dgvListSinhVien.Rows[rowIndex].Cells["MaSV"].Value.ToString();
                SinhVienBLL.DeleteSinhVien(maSV);
                LoadSinhVien();
            }
        }
        #endregion
    }
}
