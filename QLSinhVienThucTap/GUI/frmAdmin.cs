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
        private TaiKhoan user;
        public TaiKhoan User
        {
            get { return user; }
            set { user = value; }
        }
        private bool isTimKiemSinhVien = false;
        private bool isTimKiemGiaoVien = false;
        private bool isSinhVienLoaded = false;
        private bool isKhoaLoaded = false;
        private bool isGiaoVienLoaded = false;
        private bool isHoiDongLoaded = false;
        public frmAdmin(TaiKhoan User)
        {
            InitializeComponent();
            this.User = User;
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadKhoa(cbKhoaSV);
            LoadLop();
            LoadSinhVien();
            LoadColumnSinhVien();
            isSinhVienLoaded = true;
        }
        void LoadKhoa(ComboBox Khoa)
        {
            Khoa.DataSource = KhoaBLL.GetListKhoa();
            Khoa.DisplayMember = "TenKhoa";
            Khoa.ValueMember = "MaKhoa";
            Khoa.SelectedIndex = 0;
        }
        void LoadLop()
        {
            string maKhoa = cbKhoaSV.SelectedValue.ToString();
            cbLopSV.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
            cbLopSV.DisplayMember = "TenLop";
            cbLopSV.ValueMember = "MaLop";
            cbLopSV.SelectedIndex = 0;
        }
        void LoadSinhVien()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maLop = cbLopSV.SelectedValue.ToString();
            if(isTimKiemSinhVien)
            {
                string maSV = txtMaSV.Text;
                string hoTen = txtHoTenSV.Text;
                dgvListSinhVien.DataSource = SinhVienBLL.TimKiemSV(maSV, hoTen, maLop, page);
            }
            else
            {
                dgvListSinhVien.DataSource = SinhVienBLL.GetListSinhVienByLop(maLop, page);
            }
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
        void LoadDataKhoa()
        {
            dgvKhoa.DataSource = KhoaBLL.GetListKhoa();
            LoadColumnKhoaVaLop();
            isKhoaLoaded = true;
        }
        void LoadColumnKhoaVaLop()
        {
            dgvKhoa.AutoGenerateColumns = false;
            dgvKhoa.Columns["MaKhoa"].Visible = false;
            dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";
            dgvKhoa.Columns["TenKhoa"].Width = 200;
            dgvLop.AutoGenerateColumns = false;
            dgvLop.Columns["MaLop"].Visible = false;
            dgvLop.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvLop.Columns["MaKhoa"].Visible = false;
            dgvLop.Columns["TenLop"].Width = 200;
        }
        void LoadDataGV()
        {
            LoadKhoa(cbKhoaGV);
            LoadGiaoVien();
            LoadColumnGiaoVien();
            isGiaoVienLoaded = true;
        }
        void LoadGiaoVien()
        {
            int page = Convert.ToInt32(txtPageGV.Text);
            string maKhoa = cbKhoaGV.SelectedValue.ToString();
            if (isTimKiemGiaoVien)
            {
                string maGV = txtMaGV.Text;
                string tenGV = txtTenGV.Text;
                dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGV(maGV, tenGV, maKhoa, user.MaNguoiDung, page);
            }
            else
            {
                dgvListGiaoVien.DataSource = GiaoVienBLL.GetListGiaoVienByKhoa(maKhoa, page, user.MaNguoiDung);
            }
        }
        void LoadColumnGiaoVien()
        {
            dgvListGiaoVien.AutoGenerateColumns = false;
            dgvListGiaoVien.Columns["MaGV"].HeaderText = "Mã giáo viên";
            dgvListGiaoVien.Columns["TenGV"].HeaderText = "Họ và tên";
            dgvListGiaoVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvListGiaoVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvListGiaoVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvListGiaoVien.Columns["Email"].HeaderText = "Email";
            dgvListGiaoVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvListGiaoVien.Columns["MaKhoa"].Visible = false;
            dgvListGiaoVien.Columns["MaGV"].Width = 100;
            dgvListGiaoVien.Columns["TenGV"].Width = 125;
            dgvListGiaoVien.Columns["NgaySinh"].Width = 100;
            dgvListGiaoVien.Columns["GioiTinh"].Width = 75;
            dgvListGiaoVien.Columns["DiaChi"].Width = 200;
            dgvListGiaoVien.Columns["Email"].Width = 150;
            dgvListGiaoVien.Columns["SoDienThoai"].Width = 100;
        }
        void LoadDataHoiDong()
        {
            LoadHoiDong();
            LoadColumnHoiDong();
            isHoiDongLoaded = true;
        }
        void LoadHoiDong()
        {
            dgvHoiDong.DataSource = HoiDongDanhGiaBLL.GetListHoiDong();
        }
        void LoadColumnHoiDong()
        {
            dgvHoiDong.AutoGenerateColumns = false;
            dgvHoiDong.Columns["MaHoiDong"].Visible = false;
            dgvHoiDong.Columns["TenHoiDong"].HeaderText = "Tên hội đồng";
        }
        int GetLastPage()
        {
            int sumRecords = 1;
            if(isTimKiemSinhVien)
            {
                string maSV = txtMaSV.Text;
                string hoTen = txtHoTenSV.Text;
                string maLop = cbLopSV.SelectedValue.ToString();
                sumRecords = SinhVienBLL.GetNumByTimKiemSV(maSV, hoTen, maLop);
            }
            else
            {
                string maLop = cbLopSV.SelectedValue.ToString();
                sumRecords = SinhVienBLL.GetNumSinhVienByLop(maLop);
            }
            int lastPage = (sumRecords + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
        }
        int GetLastPageGV()
        {
            int sumRecords = 1;
            if (isTimKiemGiaoVien)
            {
                string maGV = txtMaGV.Text;
                string tenGV = txtTenGV.Text;
                string maKhoa = cbKhoaGV.SelectedValue.ToString();
                sumRecords = GiaoVienBLL.GetNumTimKiemGiaoVien(maGV, tenGV, maKhoa, user.MaNguoiDung);
            }
            else
            {
                string maKhoa = cbKhoaGV.SelectedValue.ToString();
                sumRecords = GiaoVienBLL.GetNumGiaoVienByKhoa(maKhoa, user.MaNguoiDung);
            }
            int lastPage = (sumRecords + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
        }
        #endregion
        #region Event
        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tcMenu.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    if (!isSinhVienLoaded)
                    {
                        LoadSinhVien();
                    }
                    break;
                case 1:
                    if (!isKhoaLoaded)
                    {
                        LoadDataKhoa();
                    }
                    break;
                case 2:
                    if (!isGiaoVienLoaded)
                    {
                        LoadDataGV();
                    }
                    break;
                case 3:
                    if (!isHoiDongLoaded)
                    {
                        LoadDataHoiDong();
                    }
                    break;
            }
        }
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimKiemSinhVien = false;
            txtPage.Text = "1";
            LoadSinhVien();
        }
        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPage.Text))
            {
                txtPage.Text = "1";
            }
            int page = Convert.ToInt32(txtPage.Text);
            if(page < 1)
            {
                txtPage.Text = "1";
            }
            int lastPage = GetLastPage();
            int currentPage = Math.Min(lastPage, page);
            txtPage.Text = currentPage.ToString();
            LoadSinhVien();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            txtPage.Text = GetLastPage().ToString();
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
        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTenSV.Text;
            string maLop = cbLopSV.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maSV) && string.IsNullOrEmpty(hoTen))
            {
                LoadSinhVien();
                isTimKiemSinhVien = false;
                return;
            }
            txtPage.Text = "1";
            dgvListSinhVien.DataSource = SinhVienBLL.TimKiemSV(maSV, hoTen, maLop, 1);
            isTimKiemSinhVien = true;
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
            string maLop = cbLopSV.SelectedValue.ToString();
            if(SinhVienBLL.InsertSinhVien(hoTen, ngaySinh, gioiTinh, sdt, diaChi, email, maLop))
            {
                txtAddHoTenSV.Text = "";
                chkGioiTinh.Checked = false;
                dtpNgaySinhSV.Value = DateTime.Now;
                txtEmailSV.Text = "";
                txtPhoneSV.Text = "";
                txtDiaChiSV.Text = "";
            }
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
            if(dgvListSinhVien.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    List<string> danhSachMaSV = new List<string>();
                    foreach (DataGridViewCell cell in dgvListSinhVien.SelectedCells)
                    {
                        string maSV = cell.OwningRow.Cells["MaSV"].Value.ToString();
                        if (!danhSachMaSV.Contains(maSV))
                        {
                            danhSachMaSV.Add(maSV);
                            SinhVienBLL.DeleteSinhVien(maSV);
                        }
                    }
                    LoadSinhVien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedCells.Count > 0)
            {
                string maKhoa = dgvKhoa.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value.ToString();
                dgvKhoa.SelectedCells[0].OwningRow.Selected = true;
                dgvLop.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
                if (dgvLop.Rows.Count > 0)
                {
                    dgvLop.Rows[0].Selected = true;
                }
            }
            else
            {
                dgvLop.DataSource = null;
            }
        }
        private void btnSearchKhoa_Click(object sender, EventArgs e)
        {
            string tenKhoa = txtTenKhoa.Text;
            if (string.IsNullOrEmpty(tenKhoa))
            {
                dgvKhoa.DataSource = KhoaBLL.GetListKhoa();
                return;
            }
            dgvKhoa.DataSource = KhoaBLL.TimKiemKhoa(tenKhoa);
        }
        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            string tenKhoa = txtTenKhoa.Text;
            if (!string.IsNullOrEmpty(tenKhoa))
            {
                KhoaBLL.InsertKhoa(tenKhoa);
                dgvKhoa.DataSource = KhoaBLL.GetListKhoa();
                LoadKhoa(cbKhoaSV);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khoa cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteKhoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không (Bao gồm cả các lớp và sinh viên trong khoa)?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    string maKhoa = dgvKhoa.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value.ToString();
                    KhoaBLL.DeleteKhoa(maKhoa);
                    dgvKhoa.DataSource = KhoaBLL.GetListKhoa();
                    LoadKhoa(cbKhoaSV);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Khoa cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSearchLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text;
            if (string.IsNullOrEmpty(tenLop))
            {
                if(dgvKhoa.SelectedCells.Count > 0)
                {
                    string maKhoa = dgvKhoa.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value.ToString();
                    dgvLop.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
                }
                else
                {
                    dgvLop.DataSource = null;
                }
                return;
            }
            dgvKhoa.ClearSelection();
            dgvLop.DataSource = LopBLL.TimKiemLop(tenLop);
        }
        private void btnAddLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text;
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvKhoa.SelectedCells.Count > 0)
            {
                string maKhoa = dgvKhoa.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value.ToString();
                LopBLL.InsertLop(tenLop, maKhoa);
                txtTenLop.Text = "";
                dgvLop.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
                LoadLop();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa trước khi thêm lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            if (dgvLop.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không (Bao gồm cả các sinh viên trong lớp)?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    string maLop = dgvLop.SelectedCells[0].OwningRow.Cells["MaLop"].Value.ToString();
                    LopBLL.DeleteLop(maLop);
                    string maKhoa = dgvKhoa.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value.ToString();
                    dgvLop.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
                    LoadLop();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Lớp cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLop();
        }
        private void dgvKhoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                string MaKhoa = row.Cells["MaKhoa"].Value.ToString();
                string TenKhoa = row.Cells["TenKhoa"].Value.ToString();
                KhoaBLL.UpdateKhoa(MaKhoa, TenKhoa);
                dgvKhoa.DataSource = KhoaBLL.GetListKhoa();
                LoadKhoa(cbKhoaSV);
            }
        }
        private void dgvLop_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                string MaLop = row.Cells["MaLop"].Value.ToString();
                string TenLop = row.Cells["TenLop"].Value.ToString();
                LopBLL.UpdateLop(MaLop, TenLop);
                string maKhoa = dgvKhoa.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value.ToString();
                dgvLop.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
                LoadLop();
            }
        }
        private void dgvListGiaoVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListGiaoVien.Columns[e.ColumnIndex].Name == "NgaySinh" && e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
            }
        }
        private void cbKhoaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimKiemGiaoVien = false;
            txtPageGV.Text = "1";
            LoadGiaoVien();
        }
        private void btnSearchGV_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtTenGV.Text;
            string maKhoa = cbKhoaGV.SelectedValue.ToString();
            if (string.IsNullOrEmpty(tenGV) && string.IsNullOrEmpty(maGV))
            {
                LoadGiaoVien();
                isTimKiemGiaoVien = false;
                return;
            }
            dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGV(maGV, tenGV, maKhoa, user.MaNguoiDung, Convert.ToInt32(txtPageGV.Text));
            isTimKiemGiaoVien = true;
        }
        private void btnAddGV_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtAddTenGV.Text;
            DateTime ngaySinh = dtpNgaySinhGV.Value;
            bool gioiTinh = chkGioiTinhGV.Checked;
            string soDienThoai = txtPhoneGV.Text;
            string diaChi = txtDiaChiGV.Text;
            string email = txtEmailGV.Text;
            string maKhoa = cbKhoaGV.SelectedValue.ToString();
            if(GiaoVienBLL.InsertGiaoVien(tenGV, ngaySinh, gioiTinh, soDienThoai, diaChi, email, maKhoa))
            {
                txtMaGV.Text = "";
                txtTenGV.Text = "";
                chkGioiTinhGV.Checked = false;
                dtpNgaySinhGV.Value = DateTime.Now;
                txtEmailGV.Text = "";
                txtPhoneGV.Text = "";
                txtDiaChiGV.Text = "";
            }
            LoadGiaoVien();
        }
        private void btnDeleteGV_Click(object sender, EventArgs e)
        {
            if (dgvListGiaoVien.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    if (dgvListGiaoVien.SelectedCells.Count > 0)
                    {
                        List<string> danhSachMaGV = new List<string>();
                        foreach (DataGridViewCell cell in dgvListGiaoVien.SelectedCells)
                        {
                            string maGV = cell.OwningRow.Cells["MaGV"].Value.ToString();
                            if (!danhSachMaGV.Contains(maGV))
                            {
                                danhSachMaGV.Add(maGV);
                                GiaoVienBLL.DeleteGiaoVien(maGV);
                            }
                        }
                    }
                    LoadGiaoVien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvListGiaoVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListGiaoVien.Rows[e.RowIndex];
                string MaGV = row.Cells["MaGV"].Value.ToString();
                string TenGV = row.Cells["TenGV"].Value.ToString();
                DateTime NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                bool GioiTinh = Convert.ToBoolean(row.Cells["GioiTinh"].Value);
                string SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                string DiaChi = row.Cells["DiaChi"].Value.ToString();
                string Email = row.Cells["Email"].Value.ToString();
                string MaKhoa = cbKhoaGV.SelectedValue.ToString();
                GiaoVienBLL.UpdateGiaoVien(MaGV, TenGV, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email, MaKhoa);
                LoadGiaoVien();
            }
        }
        private void dgvHoiDong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoiDong.Rows[e.RowIndex];
                string MaHoiDong = row.Cells["MaHoiDong"].Value.ToString();
                string TenHoiDong = row.Cells["TenHoiDong"].Value.ToString();
                HoiDongDanhGiaBLL.UpdateHoiDong(MaHoiDong, TenHoiDong);
                LoadHoiDong();
            }
        }
        private void btnSearchHoiDong_Click(object sender, EventArgs e)
        {
            string tenHoiDong = txtTenHoiDong.Text;
            if (string.IsNullOrEmpty(tenHoiDong))
            {
                LoadHoiDong();
                return;
            }
            dgvHoiDong.DataSource = HoiDongDanhGiaBLL.TimKiemHoiDong(tenHoiDong);
        }
        private void btnAddHoiDong_Click(object sender, EventArgs e)
        {
            string tenHoiDong = txtTenHoiDong.Text;
            if (!string.IsNullOrEmpty(tenHoiDong))
            {
                HoiDongDanhGiaBLL.InsertHoiDong(tenHoiDong);
                dgvHoiDong.DataSource = HoiDongDanhGiaBLL.GetListHoiDong();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên hội đồng cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteHoiDong_Click(object sender, EventArgs e)
        {
            if (dgvHoiDong.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa hội đồng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    string maHoiDong = dgvHoiDong.SelectedCells[0].OwningRow.Cells["MaHoiDong"].Value.ToString();
                    HoiDongDanhGiaBLL.DeleteHoiDong(maHoiDong);
                    dgvHoiDong.DataSource = HoiDongDanhGiaBLL.GetListHoiDong();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hội đồng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtPageGV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPageGV.Text))
            {
                txtPageGV.Text = "1";
            }
            int page = Convert.ToInt32(txtPageGV.Text);
            if (page < 1)
            {
                txtPageGV.Text = "1";
            }
            int lastPage = GetLastPageGV();
            int currentPage = Math.Min(lastPage, page);
            txtPageGV.Text = currentPage.ToString();
            LoadGiaoVien();
        }
        private void btnFirstGV_Click(object sender, EventArgs e)
        {
            txtPageGV.Text = "1";
        }
        private void btnLastGV_Click(object sender, EventArgs e)
        {
            txtPageGV.Text = GetLastPageGV().ToString();
        }
        private void btnPreviousGiaoVien_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageGV.Text);
            if (page > 1)
            {
                page--;
            }
            txtPageGV.Text = page.ToString();
            LoadGiaoVien();
        }
        private void btnNextGiaoVien_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageGV.Text);
            int lastPage = GetLastPageGV();
            if (page < lastPage)
            {
                page++;
            }
            txtPageGV.Text = page.ToString();
            LoadGiaoVien();
        }
        #endregion

        private void dgvHoiDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoiDong.SelectedCells.Count > 0)
            {
                string maHoiDong = dgvHoiDong.SelectedCells[0].OwningRow.Cells["MaHoiDong"].Value.ToString();
                dgvHoiDong.SelectedCells[0].OwningRow.Selected = true;
                dgvThanhVien.DataSource = ThanhVienHoiDongBLL.GetListThanhVienByHoiDong(maHoiDong);
            }
            else
            {
                dgvThanhVien.DataSource = null;
            }
        }
    }
}
