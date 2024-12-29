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
    public partial class frmChonGVHD : Form
    {
        private bool isTimKiemGiaoVien = false;
        public frmChonGVHD()
        {
            InitializeComponent();
        }
        //void LoadGiaoVien()
        //{
        //    int page = Convert.ToInt32(txtPageGV.Text);
        //    int maKhoa = Convert.ToInt32(cbKhoa.SelectedValue);
        //    if (isTimKiemGiaoVien)
        //    {
        //        string maGV = txtMaGV.Text;
        //        string tenGV = txtHoTen.Text;
        //        dgvListGiaoVien.DataSource = GiaoVienBLL.TimKiemGV(maGV, tenGV, maKhoa, user.MaNguoiDung, page);
        //    }
        //    else
        //    {
        //        dgvListGiaoVien.DataSource = GiaoVienBLL.GetListGiaoVienByKhoa(maKhoa, page, user.MaNguoiDung);
        //    }
        //}
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
    }
}
