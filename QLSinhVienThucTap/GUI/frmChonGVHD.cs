using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class frmChonGVHD : Form
    {
        private bool isTimKiemGiaoVien = false;
        public frmChonGVHD()
        {
            InitializeComponent();
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadKhoa();
            LoadGiaoVien();
            LoadColumnGiaoVien();
        }
        void LoadKhoa()
        {
            cbKhoa.DataSource = KhoaBLL.GetListKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        void LoadGiaoVien()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maKhoa = cbKhoa.SelectedValue.ToString();
            if (isTimKiemGiaoVien)
            {
                string maGV = txtMaGV.Text;
                string tenGV = txtHoTen.Text;
                dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGiaoVien(maGV, tenGV, maKhoa, page);
            }
            else
            {
                dgvListGiaoVien.DataSource = GiaoVienBLL.GetListGiaoVienHuongDan(maKhoa, page);
            }
        }
        void LoadColumnGiaoVien()
        {
            dgvListGiaoVien.AutoGenerateColumns = false;
            dgvListGiaoVien.Columns["MaGV"].HeaderText = "Mã giáo viên";
            dgvListGiaoVien.Columns["TenGV"].HeaderText = "Họ và tên";
            dgvListGiaoVien.Columns["NgaySinh"].Visible = false;
            dgvListGiaoVien.Columns["GioiTinh"].Visible = false;
            dgvListGiaoVien.Columns["DiaChi"].Visible = false;
            dgvListGiaoVien.Columns["Email"].Visible = false;
            dgvListGiaoVien.Columns["SoDienThoai"].Visible = false;
            dgvListGiaoVien.Columns["MaKhoa"].Visible = false;
            dgvListGiaoVien.Columns["MaGV"].Width = 100;
        }
        #endregion
        #region Event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtHoTen.Text;
            string maKhoa = cbKhoa.SelectedValue.ToString();
            if (string.IsNullOrEmpty(tenGV) && string.IsNullOrEmpty(maGV))
            {
                LoadGiaoVien();
                isTimKiemGiaoVien = false;
                return;
            }
            txtPage.Text = "1";
            dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGiaoVien(maGV, tenGV, maKhoa, Convert.ToInt32(txtPage.Text));
            isTimKiemGiaoVien = true;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvListGiaoVien.SelectedCells.Count > 0)
            {
                string maGV = dgvListGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
                string tenGV = dgvListGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString();
                selectGiaoVien(this, new SelectGiaoVienEventArgs(maGV, tenGV));
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private event EventHandler<SelectGiaoVienEventArgs> selectGiaoVien;
        public event EventHandler<SelectGiaoVienEventArgs> SelectGiaoVien
        {
            add { selectGiaoVien += value; }
            remove { selectGiaoVien -= value; }
        }
        public class SelectGiaoVienEventArgs : EventArgs
        {
            private string maGV;
            private string tenGV;
            public string MaGV
            {
                get { return maGV; }
                set { maGV = value; }
            }
            public string TenGV
            {
                get { return tenGV; }
                set { tenGV = value; }
            }
            public SelectGiaoVienEventArgs(string maGV, string tenGV)
            {
                this.MaGV = maGV;
                this.TenGV = tenGV;
            }
        }
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimKiemGiaoVien = false;
            txtPage.Text = "1";
            LoadGiaoVien();
        }
        #endregion
    }
}
