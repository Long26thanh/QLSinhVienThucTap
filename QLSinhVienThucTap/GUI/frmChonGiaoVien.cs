﻿using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class frmChonGiaoVien : Form
    {
        private bool isTimKiemGiaoVien = false;
        private bool isHasAccount = false;
        public frmChonGiaoVien(bool isHasAccount)
        {
            InitializeComponent();
            this.isHasAccount = isHasAccount;
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
            if(isHasAccount)
            {
                if(isTimKiemGiaoVien)
                {
                    string maGV = txtMaGV.Text;
                    string tenGV = txtHoTen.Text;
                    dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGiaoVien(maGV, tenGV, maKhoa, page);
                }
                else
                {
                    dgvListGiaoVien.DataSource = GiaoVienBLL.GetListGiaoVienHasNotAccount(maKhoa, page);
                }
            }
            else
            {
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
        int GetLastPage()
        {
            int sumRecord = 1;
            if (isHasAccount)
            {
                if (isTimKiemGiaoVien)
                {
                    sumRecord = GiaoVienBLL.GetNumTimKiemGiaoVienHasNotAccount(cbKhoa.SelectedValue.ToString(), txtMaGV.Text, txtHoTen.Text);
                }
                else
                {
                    sumRecord = GiaoVienBLL.GetNumGiaoVienHasNotAccount(cbKhoa.SelectedValue.ToString());
                }
            }
            else
            {
                if (isTimKiemGiaoVien)
                {
                    sumRecord = GiaoVienBLL.GetNumTimKiemGiaoVienHuongDan(txtMaGV.Text, txtHoTen.Text, cbKhoa.SelectedValue.ToString());
                }
                else
                {
                    sumRecord = GiaoVienBLL.GetNumGiaoVienHuongDan(cbKhoa.SelectedValue.ToString());
                }
            }
            int lastPage = (sumRecord + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
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
            LoadGiaoVien();
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
