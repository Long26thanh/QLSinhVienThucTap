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
    public partial class frmThanhVienHoiDong : Form
    {
        private TaiKhoan user;
        public TaiKhoan User
        {
            get { return user; }
            set { user = value; }
        }
        bool isTimKiemGiaoVien = false;
        bool isTimKiemThanhVien = false;
        public frmThanhVienHoiDong(TaiKhoan taiKhoan, int selectIndex)
        {
            InitializeComponent();
            User = taiKhoan;
            LoadData(selectIndex);
        }
        #region Method
        public void LoadData(int selectIndex)
        {
            LoadKhoa();
            LoadHoiDong();
            cbHoiDong.SelectedIndex = selectIndex;
            LoadGiaoVien();
            LoadColumnGiaoVien();
            LoadThanhVien();
            LoadColumnThanhVien();
        }
        public void LoadKhoa()
        {
            cbKhoa.DataSource = KhoaBLL.GetListKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.SelectedIndex = 0;
        }
        public void LoadHoiDong()
        {
            cbHoiDong.DataSource = HoiDongDanhGiaBLL.GetListHoiDong();
            cbHoiDong.DisplayMember = "TenHoiDong";
            cbHoiDong.ValueMember = "MaHoiDong";
            cbHoiDong.SelectedIndex = 0;
        }
        public void LoadGiaoVien()
        {
            int page = Convert.ToInt32(txtPageGV.Text);
            string maKhoa = cbKhoa.SelectedValue.ToString();
            string maHoiDong = cbHoiDong.SelectedValue.ToString();
            if (isTimKiemGiaoVien)
            {
                string maGV = txtMaGV.Text;
                string tenGV = txtTenGV.Text;
                dgvGiaoVien.DataSource = GiaoVienBLL.TimKiemGV(maGV, tenGV, maKhoa, maHoiDong, user.MaNguoiDung, page);
            }
            else
            {
                dgvGiaoVien.DataSource = GiaoVienBLL.GetListGiaoVienByMaKhoa(maKhoa, user.MaNguoiDung, maHoiDong, page);
            }
        }
        public void LoadThanhVien()
        {
            int page = Convert.ToInt32(txtPageTV.Text);
            string maHoiDong = cbHoiDong.SelectedValue.ToString();
            if (isTimKiemThanhVien)
            {
                string maGV = txtMaTV.Text;
                string tenGV = txtTenTV.Text;
                dgvThanhVien.DataSource = ThanhVienHoiDongBLL.TimKiemThanhVien(maHoiDong, maGV, tenGV, page);
            }
            else
            {
                dgvThanhVien.DataSource = ThanhVienHoiDongBLL.GetListThanhVienByMaHoiDong(maHoiDong, page);
            }
        }
        public void LoadColumnGiaoVien()
        {
            dgvGiaoVien.AutoGenerateColumns = false;
            dgvGiaoVien.Columns["MaGV"].HeaderText = "Mã giáo viên";
            dgvGiaoVien.Columns["TenGV"].HeaderText = "Họ và tên";
            dgvGiaoVien.Columns["NgaySinh"].Visible = false;
            dgvGiaoVien.Columns["GioiTinh"].Visible = false;
            dgvGiaoVien.Columns["DiaChi"].Visible = false;
            dgvGiaoVien.Columns["Email"].Visible = false;
            dgvGiaoVien.Columns["SoDienThoai"].Visible = false;
            dgvGiaoVien.Columns["MaKhoa"].Visible = false;
            dgvGiaoVien.Columns["MaGv"].Width = 100;
        }
        public void LoadColumnThanhVien()
        {
            dgvThanhVien.AutoGenerateColumns = false;
            dgvThanhVien.Columns["MaHoiDong"].Visible = false;
            dgvThanhVien.Columns["MaGV"].HeaderText = "Mã giáo viên";
            dgvThanhVien.Columns["TenGV"].HeaderText = "Họ và tên";
            dgvThanhVien.Columns["MaGv"].Width = 100;
        }
        int GetLastPageGV()
        {
            string maKhoa = cbKhoa.SelectedValue.ToString();
            string maHoiDong = cbHoiDong.SelectedValue.ToString();
            if (isTimKiemGiaoVien)
            {
                string maGV = txtMaGV.Text;
                string tenGV = txtTenGV.Text;
                return (GiaoVienBLL.GetNumTimKiemGiaoVien(maGV, tenGV, maKhoa, user.MaNguoiDung) - 1) / 10 + 1;
            }
            else
            {
                return (GiaoVienBLL.GetNumGiaoVienByMaKhoa(maKhoa, user.MaNguoiDung, maHoiDong) - 1) / 10 + 1;
            }
        }
        int GetLastPageTV()
        {
            string maHoiDong = cbHoiDong.SelectedValue.ToString();
            if (isTimKiemThanhVien)
            {
                string maGV = txtMaTV.Text;
                string tenGV = txtTenTV.Text;
                return (ThanhVienHoiDongBLL.GetNumTimKiemThanhVien(maHoiDong, maGV, tenGV) - 1) / 10 + 1;
            }
            else
            {
                return (ThanhVienHoiDongBLL.GetNumThanhVienByMaHoiDong(maHoiDong) - 1) / 10 + 1;
            }
        }
        #endregion
        #region Event
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV.Text = string.Empty;
            txtMaGV.Text = string.Empty;
            LoadGiaoVien();
        }
        private void cbHoiDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenTV.Text = string.Empty;
            txtMaTV.Text = string.Empty;
            LoadThanhVien();
        }
        private void btnAddThanhVien_Click(object sender, EventArgs e)
        {
            string maHoiDong = cbHoiDong.SelectedValue.ToString();
            string maGV = dgvGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
            ThanhVienHoiDongBLL.InsertThanhVienHoiDong(maHoiDong, maGV);
            LoadGiaoVien();
            LoadThanhVien();
        }
        private void btnDeleteThanhVien_Click(object sender, EventArgs e)
        {
            string maHoiDong = cbHoiDong.SelectedValue.ToString();
            string maGV = dgvThanhVien.CurrentRow.Cells["MaGV"].Value.ToString();
            ThanhVienHoiDongBLL.DeleteThanhVienHoiDong(maHoiDong, maGV);
            LoadGiaoVien();
            LoadThanhVien();
        }
        private void btnSearchHoiDong_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaGV.Text) && string.IsNullOrEmpty(txtTenGV.Text))
            {
                isTimKiemGiaoVien = false;
            }
            else
            {
                isTimKiemGiaoVien = true;
            }
            LoadGiaoVien();
        }
        private void btnSearchThanhVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTV.Text) && string.IsNullOrEmpty(txtTenTV.Text))
            {
                isTimKiemThanhVien = false;
            }
            else
            {
                isTimKiemThanhVien = true;
            }
            LoadThanhVien();
        }
        private void btnFirstGV_Click(object sender, EventArgs e)
        {
            txtPageGV.Text = "1";
        }
        private void btnLastGV_Click(object sender, EventArgs e)
        {
            int lastPage = GetLastPageGV();
            txtPageGV.Text = GetLastPageGV().ToString();
        }
        private void btnPreviousGV_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageGV.Text);
            if (page > 1)
            {
                txtPageGV.Text = (page - 1).ToString();
            }
        }
        private void btnNextGV_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageGV.Text);
            if (page < GetLastPageGV())
            {
                txtPageGV.Text = (page + 1).ToString();
            }
        }
        private void txtPageGV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPageGV.Text) || txtPageGV.Text == "0")
            {
                txtPageGV.Text = "1";
            }
            int page = Convert.ToInt32(txtPageGV.Text);
            int lastPage = GetLastPageGV();
            int currentPage = Math.Min(page, lastPage);
            txtPageGV.Text = currentPage.ToString();
            LoadGiaoVien();
        }
        private void txtPageGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnFirstTV_Click(object sender, EventArgs e)
        {
            txtPageTV.Text = "1";
        }
        private void btnLastTV_Click(object sender, EventArgs e)
        {
            txtPageTV.Text = GetLastPageTV().ToString();
        }
        private void btnPreviousTV_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageTV.Text);
            if (page > 1)
            {
                txtPageTV.Text = (page - 1).ToString();
            }
        }
        private void btnNextTV_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageTV.Text);
            if (page < GetLastPageTV())
            {
                txtPageTV.Text = (page + 1).ToString();
            }
        }
        private void txtPageTV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPageTV.Text) || txtPageTV.Text == "0")
            {
                txtPageTV.Text = "1";
            }
            int page = Convert.ToInt32(txtPageTV.Text);
            int lastPage = GetLastPageTV();
            int currentPage = Math.Min(page, lastPage);
            txtPageTV.Text = currentPage.ToString();
            LoadThanhVien();
        }
        #endregion
    }
}
