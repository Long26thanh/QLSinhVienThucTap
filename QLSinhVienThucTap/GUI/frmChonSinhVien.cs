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
        #endregion
    }
}
