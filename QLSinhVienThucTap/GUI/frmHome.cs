﻿using QLSinhVienThucTap.BLL;
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
    public partial class frmHome : Form
    {
        private TaiKhoan user;
        public TaiKhoan User
        {
            get { return user; }
            set { user = value; changeAccount(user.VaiTro); }
        }
        public frmHome(TaiKhoan TaiKhoan)
        {
            InitializeComponent();
            this.User = TaiKhoan;
            LoadData();
        }
        #region Method
        void changeAccount(bool VaiTro)
        {
            tsmAdmin.Enabled = VaiTro;
            tsmAccountProfile.Text += " (" + User.TenNguoiDung + ")";
        }
        void LoadData()
        {
            LoadDotTT();
            LoadSinhVien();
        }
        void LoadDotTT()
        {
            cbDotTT.DataSource = DotThucTapBLL.GetListDotThucTap();
            cbDotTT.DisplayMember = "TenDot";
            cbDotTT.ValueMember = "MaDotTT";
            cbDotTT.SelectedIndex = 0;
        }
        void LoadSinhVien()
        {
            int page = Convert.ToInt32(txtPage.Text);
            string maDotTT = cbDotTT.SelectedValue.ToString();
            dgvListSinhVien.DataSource = SinhVienBLL.GetListSinhVienHuongDan(user.MaNguoiDung, maDotTT, page);
        }
        private int GetLastPage()
        {
            int sumRecords = SinhVienBLL.GetNumStudentInteraction(user.MaNguoiDung, cbDotTT.SelectedValue.ToString());
            return (sumRecords + 14) / 15;
        }
        private void UpdatePageText(int page)
        {
            txtPage.Text = page.ToString();
        }
        #endregion
        #region Event
        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(User.TenDangNhap);
            doiMatKhau.ShowDialog();
        }
        private void tsmAccountProfile_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(User);
            thongTinCaNhan.UpdateProfile += ThongTinCaNhan_UpdateProfile;
            thongTinCaNhan.ShowDialog();
        }
        private void ThongTinCaNhan_UpdateProfile(object sender, ThongTinCaNhan.UpdateProfileEventArgs e)
        {
            this.User = e.User;
            tsmAccountProfile.Text = "Thông tin cá nhân (" + User.TenNguoiDung + ")";
        }
        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LoadSinhVien();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            int lastPage = GetLastPage();
            if (page < lastPage)
            {
                page++;
            }
            UpdatePageText(page);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if (page > 1)
            {
                page--;
            }
            UpdatePageText(page);
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int lastPage = GetLastPage();
            UpdatePageText(lastPage);
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }
        private void btnViewSinhVien_Click(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbDotTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPage.Text = "1";
            LoadSinhVien();
        }
        #endregion
    }
}