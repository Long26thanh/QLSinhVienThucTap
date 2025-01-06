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
            LoadKhoa(cbKhoaSV);
            string maKhoa = cbKhoaSV.SelectedValue.ToString();
            LoadLop(maKhoa, cbLopSV);
            LoadSinhVien();
            LoadColumnSinhVien();
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
        int GetLastPage()
        {
            int sumRecord = 1;
            if (isTimKiemSinhVien)
            {
                string maSV = txtMaSV.Text;
                string hoTen = txtHoTenSV.Text;
                string maLop = cbLopSV.SelectedValue.ToString();
                sumRecord = SinhVienBLL.GetNumByTimKiemChonSV(maSV, hoTen, maLop, MaDotTT);
            }
            else
            {
                string maLop = cbLopSV.SelectedValue.ToString();
                sumRecord = SinhVienBLL.GetNumChonSinhVien(maLop, MaDotTT);
            }
            int lastPage = (sumRecord + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
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
            string maKhoa = cbKhoaSV.SelectedValue.ToString();
            LoadLop(maKhoa, cbLopSV);

        }
        private void cbLopSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        private event EventHandler<SelectSinhVienEventArgs> selectSinhVien;
        public event EventHandler<SelectSinhVienEventArgs> SelectSinhVien
        {
            add { selectSinhVien += value; }
            remove { selectSinhVien -= value; }
        }
        public class SelectSinhVienEventArgs : EventArgs
        {
            private string maSV;
            public string MaSV
            {
                get { return maSV; }
                set { maSV = value; }
            }
            private string hoTen;
            public string HoTen
            {
                get { return hoTen; }
                set { hoTen = value; }
            }
            public SelectSinhVienEventArgs(string maSV, string hoTen)
            {
                this.MaSV = maSV;
                this.HoTen = hoTen;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvListSinhVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectSinhVien != null)
            {
                string maSV = dgvListSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();
                string hoTen = dgvListSinhVien.CurrentRow.Cells["TenSV"].Value.ToString();
                selectSinhVien(this, new SelectSinhVienEventArgs(maSV, hoTen));
                this.Close();
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
        #endregion
    }
}
