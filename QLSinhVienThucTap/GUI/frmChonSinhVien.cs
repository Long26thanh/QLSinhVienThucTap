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
    public partial class frmChonSinhVien : Form
    {
        private string maDotTT;
        public string MaDotTT
        {
            get { return maDotTT; }
            set { maDotTT = value; }
        }
        bool isTimKiemSinhVien = false;
        public frmChonSinhVien(string maDotTT)
        {
            InitializeComponent();
            this.MaDotTT = maDotTT;
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadKhoa();
            LoadLop();
            LoadSinhVien();
            LoadColumnSinhVien();
        }
        void LoadKhoa()
        {
            cbKhoaSV.DataSource = KhoaBLL.GetListKhoa();
            cbKhoaSV.DisplayMember = "TenKhoa";
            cbKhoaSV.ValueMember = "MaKhoa";
            cbKhoaSV.SelectedIndex = 0;
        }
        void LoadLop()
        {
            string makhoa = cbKhoaSV.SelectedValue.ToString();
            cbLopSV.DataSource = LopBLL.GetListLopByMaKhoa(makhoa);
            cbLopSV.DisplayMember = "TenLop";
            cbLopSV.ValueMember = "MaLop";
            cbLopSV.SelectedIndex = 0;
        }
        void LoadSinhVien()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maLop = cbLopSV.SelectedValue.ToString();
            if (isTimKiemSinhVien)
            {
                string maSV = txtMaSV.Text;
                string hoTen = txtHoTenSV.Text;
                dgvListSinhVien.DataSource = SinhVienBLL.TimKiemChonSV(maSV, hoTen, maLop, MaDotTT, page);
            }
            else
            {
                dgvListSinhVien.DataSource = SinhVienBLL.GetListChonSinhVien(maLop, MaDotTT, page);
            }
        }
        void LoadColumnSinhVien()
        {
            dgvListSinhVien.AutoGenerateColumns = false;
            dgvListSinhVien.Columns["MaLop"].Visible = false;
            dgvListSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";
            dgvListSinhVien.Columns["TenSV"].HeaderText = "Họ và tên";
            dgvListSinhVien.Columns["NgaySinh"].Visible = false;
            dgvListSinhVien.Columns["GioiTinh"].Visible = false;
            dgvListSinhVien.Columns["DiaChi"].Visible = false;
            dgvListSinhVien.Columns["Email"].Visible = false;
            dgvListSinhVien.Columns["SoDienThoai"].Visible = false;
            dgvListSinhVien.Columns["MaSV"].Width = 100;
        }
        #endregion
        #region Event
        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) && string.IsNullOrEmpty(txtHoTenSV.Text))
            {
                isTimKiemSinhVien = false;
                LoadSinhVien();
                return;
            }
            isTimKiemSinhVien = true;
            LoadSinhVien();
        }
        private void cbKhoaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLop();
        }
        private void cbLopSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        #endregion
    }
}
