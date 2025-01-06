using QLSinhVienThucTap.BLL;
using QLSinhVienThucTap.DTO;
using QLSinhVienThucTap.GUI.frmReportViewer;
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
        private bool isTimKiemThucTap = false;
        private bool isTimKiemAccount = false;
        private bool isSinhVienLoaded = false;
        private bool isKhoaLoaded = false;
        private bool isGiaoVienLoaded = false;
        private bool isHoiDongLoaded = false;
        private bool isThucTapLoaded = false;
        private bool isAccountLoaded = false;
        public frmAdmin(TaiKhoan User)
        {
            InitializeComponent();
            this.User = User;
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadGioiTinh(cbGioiTinh);
            LoadKhoa(cbKhoaSV);
            string maKhoa = cbKhoaSV.SelectedValue.ToString();
            LoadLop(maKhoa, cbLopSV);
            LoadSinhVien();
            LoadColumnSinhVien();
            isSinhVienLoaded = true;
        }
        void LoadGioiTinh(ComboBox GioiTinh)
        {
            GioiTinh.Items.Add("Nam");
            GioiTinh.Items.Add("Nữ");
            GioiTinh.SelectedIndex = 0;
        }
        void LoadKhoa(ComboBox Khoa)
        {
            Khoa.DataSource = KhoaBLL.GetListKhoa();
            Khoa.DisplayMember = "TenKhoa";
            Khoa.ValueMember = "MaKhoa";
            Khoa.SelectedIndex = 0;
        }
        void LoadLop(string maKhoa, ComboBox Lop)
        {
            Lop.DataSource = LopBLL.GetListLopByMaKhoa(maKhoa);
            Lop.DisplayMember = "TenLop";
            Lop.ValueMember = "MaLop";
        }
        void LoadSinhVien()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maLop = cbLopSV.SelectedValue.ToString();
            if (isTimKiemSinhVien)
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
            dgvListSinhVien.Columns["GioiTinh"].Width = 80;
            dgvListSinhVien.Columns["DiaChi"].Width = 200;
            dgvListSinhVien.Columns["Email"].Width = 150;
            dgvListSinhVien.Columns["SoDienThoai"].Width = 100;
            dgvListSinhVien.Columns["MaSV"].ReadOnly = true;
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
            LoadGioiTinh(cbGioiTinhGV);
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
            dgvListGiaoVien.Columns["MaGV"].ReadOnly = true;
        }
        void LoadDataHoiDong()
        {
            LoadHoiDong();
            LoadColumnHoiDong();
            LoadColumnThanhVienHoiDong();
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
        void LoadColumnThanhVienHoiDong()
        {
            dgvThanhVien.AutoGenerateColumns = false;
            dgvThanhVien.Columns["MaHoiDong"].Visible = false;
            dgvThanhVien.Columns["TenGV"].HeaderText = "Họ và tên";
            dgvThanhVien.Columns["MaGV"].Width = 100;
        }
        void LoadDataThucTap()
        {
            LoadKhoa(cbKhoaTT);
            string maKhoa = cbKhoaTT.SelectedValue.ToString();
            LoadLop(maKhoa, cbLopTT);
            LoadDotThucTap();
            LoadSinhVienTT();
            LoadLop(maKhoa, cbLopTT);
            LoadColumnSinhVienTT();
            isThucTapLoaded = true;
        }
        void LoadDotThucTap()
        {
            cbDotThuctap.DataSource = DotThucTapBLL.GetListDotThucTap();
            cbDotThuctap.DisplayMember = "TenDot";
            cbDotThuctap.ValueMember = "MaDotTT";
            cbDotThuctap.SelectedIndex = 0;
        }
        void LoadSinhVienTT()
        {
            int page = int.TryParse(txtPageTT.Text, out int parsedPage) ? parsedPage : 1;
            string maLop = cbLopTT.SelectedValue?.ToString() ?? "temp";
            string maDotTT = cbDotThuctap.SelectedValue?.ToString() ?? "temp";

            if (isTimKiemThucTap)
            {
                string maSV = txtMaSVThucTap.Text;
                string hoTen = txtTenSVThucTap.Text;
                dgvListSinhVienThucTap.DataSource = ThucTapBLL.TimKiemThucTap(maSV, hoTen, maLop, maDotTT, page);
            }
            else
            {
                dgvListSinhVienThucTap.DataSource = ThucTapBLL.GetListThucTap(maLop, maDotTT, page);
            }
        }
        void LoadColumnSinhVienTT()
        {
            dgvListSinhVienThucTap.AutoGenerateColumns = false;
            dgvListSinhVienThucTap.Columns["MaThucTap"].Visible = false;
            dgvListSinhVienThucTap.Columns["MaGiaoVien"].Visible = false;
            dgvListSinhVienThucTap.Columns["MaDeTai"].Visible = false;
            dgvListSinhVienThucTap.Columns["MaDiaDiem"].Visible = false;
            dgvListSinhVienThucTap.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";
            dgvListSinhVienThucTap.Columns["HoTenSV"].HeaderText = "Họ và tên";
            dgvListSinhVienThucTap.Columns["TenDeTai"].HeaderText = "Đề tài";
            dgvListSinhVienThucTap.Columns["TenDiaDiem"].HeaderText = "Địa điểm";
            dgvListSinhVienThucTap.Columns["HoTenGV"].HeaderText = "Giáo viên hướng dẫn";
            dgvListSinhVienThucTap.Columns["DiemSo"].HeaderText = "Điểm";
            dgvListSinhVienThucTap.Columns["MaSinhVien"].Width = 100;
            dgvListSinhVienThucTap.Columns["HoTenSV"].Width = 150;
            dgvListSinhVienThucTap.Columns["HoTenGV"].Width = 150;
            dgvListSinhVienThucTap.Columns["DiemSo"].Width = 75;
        }
        void LoadDataAccount()
        {
            LoadVaiTro(cbVaiTro);
            LoadAccount();
            LoadColumnAccount();
            isAccountLoaded = true;
        }
        void LoadAccount()
        {
            if (isTimKiemAccount)
            {
                string tenDangNhap = txtUserNameTK.Text;
                string maNguoiDung = txtMaGVTK.Text;
                string tenNguoiDung = txtHoTenTK.Text;
                dgvListAccount.DataSource = TaiKhoanBLL.TimKiemTaiKhoan(tenDangNhap, maNguoiDung, tenNguoiDung, Convert.ToInt32(txtPageAccount.Text));
            }
            else
            {
                dgvListAccount.DataSource = TaiKhoanBLL.GetListAccount(Convert.ToInt32(txtPageAccount.Text));
            }
        }
        void LoadVaiTro(ComboBox VaiTro)
        {
            VaiTro.Items.Add("User");
            VaiTro.Items.Add("Admin");
            VaiTro.SelectedIndex = 0;
        }
        void LoadColumnAccount()
        {
            dgvListAccount.AutoGenerateColumns = false;
            dgvListAccount.Columns["MatKhau"].Visible = false;
            dgvListAccount.Columns["GioiTinh"].Visible = false;
            dgvListAccount.Columns["NgaySinh"].Visible = false;
            dgvListAccount.Columns["DiaChi"].Visible = false;
            dgvListAccount.Columns["Email"].Visible = false;
            dgvListAccount.Columns["SoDienThoai"].Visible = false;
            dgvListAccount.Columns["Khoa"].Visible = false;
            dgvListAccount.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvListAccount.Columns["MaNguoiDung"].HeaderText = "Mã giáo viên";
            dgvListAccount.Columns["TenNguoiDung"].HeaderText = "Tên người dùng";
        }
        int GetLastPage()
        {
            int sumRecords = 1;
            if (isTimKiemSinhVien)
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
        int GetLastPageTT()
        {
            int sumRecords = 1;
            if (isTimKiemThucTap)
            {
                string maSV = txtMaSVThucTap.Text;
                string hoTen = txtTenSVThucTap.Text;
                string maLop = cbLopTT.SelectedValue.ToString();
                string maDotTT = cbDotThuctap.SelectedValue.ToString();
                sumRecords = ThucTapBLL.GetNumTimKiemThucTap(maSV, hoTen, maLop, maDotTT);
            }
            else
            {
                string maLop = cbLopTT.SelectedValue.ToString();
                string maDotTT = cbDotThuctap.SelectedValue.ToString();
                sumRecords = ThucTapBLL.GetNumThucTap(maLop, maDotTT);
            }
            int lastPage = (sumRecords + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
        }
        int GetLastPageAccount()
        {
            int sumRecords = TaiKhoanBLL.GetNumAccount();
            int lastPage = (sumRecords + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
        }
        // Hàm chuyển DataGridView sang DataTable
        public static DataTable ConvertDataGridViewToDataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // Thêm cột vào DataTable
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.Name);
            }

            // Thêm dòng vào DataTable
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        // Kiểm tra nếu cột là Ngày sinh thì định dạng lại
                        if (dgv.Columns[i].Name == "NgaySinh" && row.Cells[i].Value != null)
                        {
                            DateTime ngaySinh;
                            if (DateTime.TryParse(row.Cells[i].Value.ToString(), out ngaySinh))
                            {
                                dataRow[i] = ngaySinh.ToString("dd/MM/yyyy");
                            }
                        }
                        else
                        {
                            dataRow[i] = row.Cells[i].Value;
                        }
                    }
                    dt.Rows.Add(dataRow);
                }
            }
            return dt;
        }
        #endregion
        #region Event
        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tcMenu.SelectedIndex;

            // Đổi tên form theo tab hiện tại
            string selectedTabText = tcMenu.SelectedTab?.Text;
            this.Text = $"Quản lý {selectedTabText}";

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
                case 4:
                    if (!isThucTapLoaded)
                    {
                        LoadDataThucTap();
                    }
                    break;
                case 5:
                    if (!isAccountLoaded)
                    {
                        LoadDataAccount();
                    }
                    break;
            }
        }

        // *******************************
        // Tab Sinh viên
        // *******************************
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimKiemSinhVien = false;
            txtPage.Text = "1";
            LoadSinhVien();
        }
        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPage.Text) || txtPage.Text == "0")
            {
                txtPage.Text = "1";
            }
            int page = Convert.ToInt32(txtPage.Text);
            int lastPage = GetLastPage();
            int currentPage = Math.Min(lastPage, page);
            txtPage.Text = currentPage.ToString();
            LoadSinhVien();
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
            if (e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
            }
        }
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            string hoTen = txtAddHoTenSV.Text;
            DateTime ngaySinh = dtpNgaySinhSV.Value;
            bool gioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            string sdt = txtPhoneSV.Text;
            string diaChi = txtDiaChiSV.Text;
            string email = txtEmailSV.Text;
            string maLop = cbLopSV.SelectedValue.ToString();
            if (SinhVienBLL.InsertSinhVien(hoTen, ngaySinh, gioiTinh, sdt, diaChi, email, maLop))
            {
                txtAddHoTenSV.Text = "";
                dtpNgaySinhSV.Value = DateTime.Now;
                cbGioiTinh.SelectedIndex = 0;
                txtEmailSV.Text = "";
                txtPhoneSV.Text = "";
                txtDiaChiSV.Text = "";
                LoadSinhVien();
            }
        }
        private void dgvListSinhVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListSinhVien.Rows[e.RowIndex];
                string MaSV = row.Cells["MaSV"].Value.ToString();
                string TenSV = row.Cells["TenSV"].Value.ToString();
                DateTime NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                bool GioiTinh;
                if(row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    GioiTinh = true;
                }
                else if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    GioiTinh = false;
                }
                else
                {
                    MessageBox.Show("Giới tính không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadSinhVien();
                    return;
                }
                string SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                string DiaChi = row.Cells["DiaChi"].Value.ToString();
                string Email = row.Cells["Email"].Value.ToString();
                SinhVienBLL.UpdateSinhVien(MaSV, TenSV, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email);
                LoadSinhVien();
            }
        }
        private void dgvListSinhVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            e.Cancel = true;
        }
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (dgvListSinhVien.SelectedCells.Count > 0)
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
                            if(Convert.ToInt32(txtPage.Text) > GetLastPage())
                            {
                                txtPage.Text = GetLastPage().ToString();
                            }
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

        // *******************************
        // Tab Khoa và Lớp
        // *******************************
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
                if (dgvKhoa.SelectedCells.Count > 0)
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
                LoadLop(maKhoa, cbLopSV);
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
                    LoadLop(maKhoa, cbLopSV);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Lớp cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cbKhoaSV.SelectedValue.ToString();
            LoadLop(maKhoa, cbLopSV);
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
                LoadLop(maKhoa, cbLopSV);
            }
        }

        // *******************************
        // Tab Giáo viên
        // *******************************
        private void dgvListGiaoVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
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
            txtPageGV.Text = "1";
            dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGV(maGV, tenGV, maKhoa, user.MaNguoiDung, Convert.ToInt32(txtPageGV.Text));
            isTimKiemGiaoVien = true;
        }
        private void btnAddGV_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtAddTenGV.Text;
            DateTime ngaySinh = dtpNgaySinhGV.Value;
            bool gioiTinh = cbGioiTinhGV.Text == "Nam" ? true : false;
            string soDienThoai = txtPhoneGV.Text;
            string diaChi = txtDiaChiGV.Text;
            string email = txtEmailGV.Text;
            string maKhoa = cbKhoaGV.SelectedValue.ToString();
            if (GiaoVienBLL.InsertGiaoVien(tenGV, ngaySinh, gioiTinh, soDienThoai, diaChi, email, maKhoa))
            {
                txtMaGV.Text = "";
                txtTenGV.Text = "";
                cbGioiTinhGV.SelectedIndex = 0;
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
                                if (Convert.ToInt32(txtPageGV.Text) > GetLastPageGV())
                                {
                                    txtPageGV.Text = GetLastPageGV().ToString();
                                }
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
                bool GioiTinh;
                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    GioiTinh = true;
                }
                else if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    GioiTinh = false;
                }
                else
                {
                    MessageBox.Show("Giới tính không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadGiaoVien();
                    return;
                }
                string SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                string DiaChi = row.Cells["DiaChi"].Value.ToString();
                string Email = row.Cells["Email"].Value.ToString();
                string MaKhoa = cbKhoaGV.SelectedValue.ToString();
                GiaoVienBLL.UpdateGiaoVien(MaGV, TenGV, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email, MaKhoa);
                LoadGiaoVien();
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
            int currentPage = Math.Min(lastPage, page);
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

        // *******************************
        // Tab Hội đồng
        // *******************************
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
        private void btnSearchThanhVien_Click(object sender, EventArgs e)
        {
            string tenGV = txtThanhVien.Text;
            if (dgvThanhVien.SelectedCells.Count > 0)
            {
                string maHoiDong = dgvHoiDong.SelectedCells[0].OwningRow.Cells["MaHoiDong"].Value.ToString();
                if (string.IsNullOrEmpty(tenGV))
                {
                    dgvThanhVien.DataSource = ThanhVienHoiDongBLL.GetListThanhVienByHoiDong(maHoiDong);
                }
                else
                    dgvThanhVien.DataSource = ThanhVienHoiDongBLL.TimKiemThanhVien(maHoiDong, tenGV);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hội đồng cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEditThanhVien_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvHoiDong.SelectedCells[0].OwningRow.Index;
            frmThanhVienHoiDong thanhVienHoiDong = new frmThanhVienHoiDong(user, selectedRowIndex);
            thanhVienHoiDong.ShowDialog();
        }
        private void btnXemDSSinhVienTheoHDDG_Click(object sender, EventArgs e)
        {
            if (dgvHoiDong.CurrentRow != null)
            {
                string maHoiDong = dgvHoiDong.CurrentRow.Cells["MaHoiDong"].Value.ToString(); // Lấy mã hội đồng từ dòng được chọn
                string tenHoiDong = dgvHoiDong.CurrentRow.Cells["TenHoiDong"].Value.ToString(); // Lấy mã hội đồng từ dòng được chọn
                frmDanhSachSVtheoHD frm = new frmDanhSachSVtheoHD(maHoiDong, tenHoiDong); // Truyền mã hội đồng vào form mới
                frm.ShowDialog(); // Hiển thị form danh sách sinh viên
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hội đồng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Chuyển dữ liệu từ DataGridView sang DataTable
            DataTable dt = frmAdmin.ConvertDataGridViewToDataTable(dgvHoiDong);

            // Lấy nội dung của lblHeader
            string lblHeader = "temp";

            // Mở form mới chứa ReportViewer
            frmRV reportForm = new frmRV(dt, "HoiDongDataSet", "rptHoiDong", lblHeader);
            reportForm.ShowDialog();
        }

        // *******************************
        // Tab Thực tập
        // *******************************
        private void cbKhoaTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cbKhoaTT.SelectedValue.ToString();
            LoadLop(maKhoa, cbLopTT);
        }
        private void cbLopTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimKiemThucTap = false;
            txtPageTT.Text = "1";
            LoadSinhVienTT();
        }
        private void cbDotThuctap_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimKiemThucTap = false;
            txtPageTT.Text = "1";
            LoadSinhVienTT();
        }
        private void btnFirstTT_Click(object sender, EventArgs e)
        {
            txtPageTT.Text = "1";
        }
        private void btnPreviousTT_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageTT.Text);
            if (page > 1)
            {
                page--;
            }
            txtPageTT.Text = page.ToString();
        }
        private void btnNextTT_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageTT.Text);
            int lastPage = GetLastPageTT();
            if (page < lastPage)
            {
                page++;
            }
            txtPageTT.Text = page.ToString();
        }
        private void btnLastTT_Click(object sender, EventArgs e)
        {
            txtPageTT.Text = GetLastPageTT().ToString();
        }
        private void txtPageTT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPageTT.Text) || txtPageTT.Text == "0")
            {
                txtPageTT.Text = "1";
            }
            int page = Convert.ToInt32(txtPageTT.Text);
            int lastPage = GetLastPageTT();
            int currentPage = Math.Min(lastPage, page);
            txtPageTT.Text = currentPage.ToString();
            LoadSinhVienTT();
        }
        private void txtPageTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnSearchSVTT_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSVThucTap.Text;
            string hoTen = txtTenSVThucTap.Text;
            if (string.IsNullOrEmpty(maSV) && string.IsNullOrEmpty(hoTen))
            {
                LoadSinhVienTT();
                isTimKiemThucTap = false;
                return;
            }
            string maLop = cbLopTT.SelectedValue.ToString();
            string maDotTT = cbDotThuctap.SelectedValue.ToString();
            txtPageTT.Text = "1";
            dgvListSinhVienThucTap.DataSource = ThucTapBLL.TimKiemThucTap(maLop, maDotTT, hoTen, maSV, 1);
            isTimKiemThucTap = true;
        }
        private void btnAddSVTT_Click(object sender, EventArgs e)
        {
            string maDotTT = cbDotThuctap.SelectedValue.ToString();
            frmThucTap thucTap = new frmThucTap(maDotTT, cbDotThuctap.Text, false);
            thucTap.ThucTap += ThucTap_AddThucTap;
            thucTap.AddDotTT += ThucTap_AddDotTT;
            thucTap.RemoveDotTT += ThucTap_RemoveDotTT;
            thucTap.ShowDialog();
        }
        private void btnEditTT_Click(object sender, EventArgs e)
        {
            if(dgvListSinhVienThucTap.SelectedCells.Count > 0)
            {
                string maTT = dgvListSinhVienThucTap.SelectedCells[0].OwningRow.Cells["MaThucTap"].Value.ToString();
                string maDotTT = cbDotThuctap.SelectedValue.ToString();
                frmThucTap thucTap = new frmThucTap(maDotTT, cbDotThuctap.Text, true, maTT);
                thucTap.ThucTap += ThucTap_UpdateTT;
                thucTap.AddDotTT += ThucTap_AddDotTT;
                thucTap.RemoveDotTT += ThucTap_RemoveDotTT;
                thucTap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!");
            }
        }
        private void ThucTap_AddThucTap(object sender, frmThucTap.ThucTapEventArgs e)
        {
            ThucTapBLL.InsertThucTap(e.MaSV, e.MaGV, e.MaDeTai, e.MaDiaDiem, e.MaDotTT, e.MaHoiDong);
            addThucTap?.Invoke(this, EventArgs.Empty);
            LoadSinhVienTT();
        }
        private void ThucTap_UpdateTT(object sender, frmThucTap.ThucTapEventArgs e)
        {
            string maTT = dgvListSinhVienThucTap.SelectedCells[0].OwningRow.Cells["MaThucTap"].Value.ToString();
            ThucTapBLL.UpdateThucTap(maTT, e.MaGV, e.MaDeTai, e.MaDiaDiem, e.MaHoiDong);
            LoadSinhVienTT();
        }
        private void ThucTap_AddDotTT(object sender, EventArgs e)
        {
            addDotTT?.Invoke(this, EventArgs.Empty);
            LoadDotThucTap();
            LoadSinhVienTT();
        }
        private void ThucTap_RemoveDotTT(object sender, EventArgs e)
        {
            removeDotTT?.Invoke(this, EventArgs.Empty);
            LoadDotThucTap();
            LoadSinhVienTT();
        }
        private event EventHandler addThucTap;
        public event EventHandler AddThucTap
        {
            add { addThucTap += value; }
            remove { addThucTap -= value; }
        }
        private event EventHandler removeThucTap;
        public event EventHandler RemoveThucTap
        {
            add { removeThucTap += value; }
            remove { removeThucTap -= value; }
        }
        private event EventHandler addDotTT;
        public event EventHandler AddDotTT
        {
            add { addDotTT += value; }
            remove { addDotTT -= value; }
        }
        private event EventHandler removeDotTT;
        public event EventHandler RemoveDotTT
        {
            add { removeDotTT += value; }
            remove { removeDotTT -= value; }
        }
        private void btnXemDiaDiemTT_Click(object sender, EventArgs e)
        {
            string maDotTT = cbDotThuctap.SelectedValue.ToString();
            string tenDotTT = cbDotThuctap.Text.ToString();
            frmDiaDiemTT diaDiemTT = new frmDiaDiemTT(maDotTT, tenDotTT);
            diaDiemTT.ShowDialog();
        }
        private void btnPrintSinhVien_Click(object sender, EventArgs e)
        {
            // Chuyển dữ liệu từ DataGridView sang DataTable
            DataTable dt = ConvertDataGridViewToDataTable(dgvListSinhVienThucTap);

            string lblHeader = "Khoa " + cbKhoaTT.Text + ", Lớp " + cbLopTT.Text + ", " + cbDotThuctap.Text;

            frmRV reportForm = new frmRV(dt, "SinhVienTTDataSet", "rptSinhVienTheoDotTT", lblHeader);
            reportForm.ShowDialog();
        }

        private void btnDeleteSVTT_Click(object sender, EventArgs e)
        {
            if (dgvListSinhVienThucTap.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    List<string> danhSachMaTT = new List<string>();
                    foreach (DataGridViewCell cell in dgvListSinhVienThucTap.SelectedCells)
                    {
                        string maTT = cell.OwningRow.Cells["MaThucTap"].Value.ToString();
                        if (!danhSachMaTT.Contains(maTT))
                        {
                            danhSachMaTT.Add(maTT);
                            ThucTapBLL.DeleteThucTap(maTT);
                            if (Convert.ToInt32(txtPageTT.Text) > GetLastPageTT())
                            {
                                txtPageTT.Text = GetLastPageTT().ToString();
                            }
                        }
                    }
                    removeThucTap?.Invoke(this, EventArgs.Empty);
                    LoadSinhVienTT();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // *******************************
        // Tab Tài khoản
        // *******************************
        private void btnFirstAccount_Click(object sender, EventArgs e)
        {
            txtPageAccount.Text = "1";
        }
        private void btnLastAccount_Click(object sender, EventArgs e)
        {
            txtPageAccount.Text = GetLastPageAccount().ToString();
        }
        private void btnPreviousAccount_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageAccount.Text);
            if (page > 1)
            {
                page--;
            }
            txtPageAccount.Text = page.ToString();
        }
        private void btnNextAccount_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageAccount.Text);
            int lastPage = GetLastPageAccount();
            if (page < lastPage)
            {
                page++;
            }
            txtPageAccount.Text = page.ToString();
        }
        private void txtPageAccount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPageAccount.Text) || txtPageAccount.Text == "0")
            {
                txtPageAccount.Text = "1";
            }
            int page = Convert.ToInt32(txtPageAccount.Text);
            int lastPage = GetLastPageAccount();
            int currentPage = Math.Min(lastPage, page);
            txtPageAccount.Text = currentPage.ToString();
            LoadDataAccount();
        }
        private void txtPageAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmChonGiaoVien thucTap = new frmChonGiaoVien(true);
            thucTap.SelectGiaoVien += ThucTap_SelectGiaoVien;
            thucTap.ShowDialog();
        }
        private void ThucTap_SelectGiaoVien(object sender, frmChonGiaoVien.SelectGiaoVienEventArgs e)
        {
            txtMaGiaoVien.Text = e.MaGV;
            txtTenNguoiDung.Text = e.TenGV;
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text;
            string maGV = txtMaGiaoVien.Text;
            bool isAdmin = cbVaiTro.Text == "Admin" ? true : false;
            if (!TaiKhoanBLL.CheckAccountExist(tenDangNhap))
            {
                if (TaiKhoanBLL.InsertAccount(tenDangNhap, maGV, isAdmin))
                {
                    txtMaGiaoVien.Text = "";
                    txtTenNguoiDung.Text = "";
                    txtUsername.Text = "";
                    LoadAccount();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListAccount.SelectedCells.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    List<string> danhSachTaiKhoan = new List<string>();
                    foreach (DataGridViewCell cell in dgvListAccount.SelectedCells)
                    {
                        string tenDangNhap = cell.OwningRow.Cells["TenDangNhap"].Value.ToString();
                        if (!danhSachTaiKhoan.Contains(tenDangNhap))
                        {
                            danhSachTaiKhoan.Add(tenDangNhap);
                            if (tenDangNhap != user.TenDangNhap)
                            {
                                TaiKhoanBLL.DeleteAccount(tenDangNhap);
                                if (Convert.ToInt32(txtPageAccount.Text) > GetLastPageAccount())
                                {
                                    txtPageAccount.Text = GetLastPageAccount().ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa chính bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    LoadAccount();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUserNameTK.Text;
            string maGV = txtMaGVTK.Text;
            string hoTen = txtHoTenTK.Text;
            if (string.IsNullOrEmpty(tenDangNhap) && string.IsNullOrEmpty(maGV) && string.IsNullOrEmpty(hoTen))
            {
                LoadAccount();
                isTimKiemAccount = false;
                return;
            }
            txtPageAccount.Text = "1";
            dgvListAccount.DataSource = TaiKhoanBLL.TimKiemTaiKhoan(tenDangNhap, maGV, hoTen, 1);
            isTimKiemAccount = true;
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string tenDangNhap = dgvListAccount.SelectedCells[0].OwningRow.Cells["TenDangNhap"].Value.ToString();
            string maGV = dgvListAccount.SelectedCells[0].OwningRow.Cells["MaNguoiDung"].Value.ToString();
            string hoTen = dgvListAccount.SelectedCells[0].OwningRow.Cells["TenNguoiDung"].Value.ToString();
            string vaitro = dgvListAccount.SelectedCells[0].OwningRow.Cells["VaiTro"].Value.ToString();
            frmEditTaiKhoan editTaiKhoan = new frmEditTaiKhoan(tenDangNhap, maGV, hoTen, vaitro);
            editTaiKhoan.UpdateAccount += EditTaiKhoan_UpdateAccount;
            editTaiKhoan.ShowDialog();
        }
        private void EditTaiKhoan_UpdateAccount(object sender, EventArgs e)
        {
            LoadAccount();
        }
        #endregion

    }
}
