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
    public partial class frmHome : Form
    {
        private TaiKhoan user;
        private float scaleFactor = 1f;
        string font = "Microsoft Sans Serif";

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
            dgvListSinhVien.Font = new Font(font, 8);
        }
        #region Method
        void changeAccount(bool VaiTro)
        {
            tsmAdmin.Enabled = VaiTro;
            if(!string.IsNullOrEmpty(User.TenNguoiDung))
            {
                tsmAccountProfile.Text += " (" + User.TenNguoiDung + ")";
            }
            string maHoiDong = HoiDongDanhGiaBLL.GetMaHoiDongByMaGV(user.MaNguoiDung);
            if(string.IsNullOrEmpty(maHoiDong))
            {
                tsmDiem.Enabled = false;
            }
        }
        void LoadData()
        {
            LoadDotTT();
            LoadSinhVien();
            LoadColumns();
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
        void LoadColumns()
        {
            dgvListSinhVien.AutoGenerateColumns = false;
            dgvListSinhVien.Columns["Mã Sinh Viên"].Width = 90;
            dgvListSinhVien.Columns["Lớp"].Width = 75;
            dgvListSinhVien.Columns["Điểm"].Width = 75;
        }
        private int GetLastPage()
        {
            int sumRecords = SinhVienBLL.GetNumStudentInteraction(user.MaNguoiDung, cbDotTT.SelectedValue.ToString());
            int lastpage = (sumRecords + 14) / 15;
            return lastpage > 0 ? lastpage : 1;
        }
        private void ResizeControls()
        {
            scaleFactor = (float)this.ClientSize.Width / 898f;
            int scaleHeight = (int)(this.ClientSize.Height / 353);
            bool isFullScreen = this.WindowState == FormWindowState.Maximized;
            if (isFullScreen)
                dgvListSinhVien.DefaultCellStyle.Padding = new Padding(0, (int)(3.5 * scaleFactor), 0, (int)(3.5 * scaleFactor));
            else
                dgvListSinhVien.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            // Cập nhật kích thước font
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, 18f * scaleFactor, FontStyle.Regular);
            msMenu.Font = new Font(msMenu.Font.FontFamily, 9f * scaleFactor, FontStyle.Regular);
            cbDotTT.Font = new Font(cbDotTT.Font.FontFamily, 14f * scaleFactor, FontStyle.Regular);
            cbDotTT.Width = 121 * (int)scaleFactor;
            txtPage.Font = new Font(txtPage.Font.FontFamily, 9f * scaleFactor, FontStyle.Regular);
            dgvListSinhVien.Font = new Font(dgvListSinhVien.Font.FontFamily, 8f * scaleFactor, FontStyle.Regular);
            btnFirst.Font = new Font(btnFirst.Font.FontFamily, 10f * scaleFactor, FontStyle.Regular);
            btnLast.Font = new Font(btnLast.Font.FontFamily, 10f * scaleFactor, FontStyle.Regular);
            btnPrevious.Font = new Font(btnPrevious.Font.FontFamily, 10f * scaleFactor, FontStyle.Regular);
            btnNext.Font = new Font(btnNext.Font.FontFamily, 10f * scaleFactor, FontStyle.Regular);

            //// Cập nhật kích thước control
            pnlDotTT.Height = cbDotTT.Height * (int)scaleFactor;
            btnFirst.Width = (int)(75 * scaleFactor);
            btnLast.Width = (int)(75 * scaleFactor);
            btnPrevious.Width = (int)(75 * scaleFactor);
            btnNext.Width = (int)(75 * scaleFactor);
            txtPage.Width = (int)(100 * scaleFactor);

            dgvListSinhVien.Width = (int)(885 * scaleFactor);
            dgvListSinhVien.Height = (int)(353 * scaleHeight);
            dgvListSinhVien.Columns["Mã Sinh Viên"].Width = (int)(90 * scaleFactor);
            dgvListSinhVien.Columns["Lớp"].Width = (int)(75 * scaleFactor);
            dgvListSinhVien.Columns["Điểm"].Width = (int)(75 * scaleFactor);

            //// Cập nhật lại vị trí control
            lblTitle.Location = new Point((this.ClientSize.Width - lblTitle.Width) / 2, msMenu.Height + 10);
            pnlDotTT.Location = new Point(pnlDotTT.Location.X, lblTitle.Location.Y + lblTitle.Height + (40 * (int)scaleFactor));
            cbDotTT.Location = new Point((int)((pnlDotTT.Width - cbDotTT.Width) / 2));
            btnFirst.Height = 23 * (int)scaleFactor;
            btnLast.Height = 23 * (int)scaleFactor;
            btnPrevious.Height = 23 * (int)scaleFactor;
            btnNext.Height = 23 * (int)scaleFactor;
            btnFirst.Location = new Point((int)(4 * scaleFactor), (int)(359 * scaleHeight));
            btnLast.Location = new Point((int)(814 * scaleFactor), (int)(359 * scaleHeight));
            btnPrevious.Location = new Point((int)(85 * scaleFactor), (int)(359 * scaleHeight));
            btnNext.Location = new Point((int)(733 * scaleFactor), (int)(359 * scaleHeight));
            txtPage.Location = new Point((int)(400 * scaleFactor), (int)(361 * scaleHeight));

            pnlListSV.Location = new Point(pnlListSV.Location.X, lblTitle.Location.Y + lblTitle.Height + (78 * (int)scaleFactor));
            dgvListSinhVien.Location = new Point(4 * (int)scaleFactor, (int)(3 * scaleFactor));
        }
        #endregion
        #region Event
        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau(User.TenDangNhap);
            doiMatKhau.ShowDialog();
        }
        private void tsmAccountProfile_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan(User);
            thongTinCaNhan.UpdateProfile += ThongTinCaNhan_UpdateProfile;
            thongTinCaNhan.ShowDialog();
        }
        private void ThongTinCaNhan_UpdateProfile(object sender, frmThongTinCaNhan.UpdateProfileEventArgs e)
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
            if (string.IsNullOrEmpty(txtPage.Text) || txtPage.Text == "0")
            {
                txtPage.Text = "1";
            }
            int page = Convert.ToInt32(txtPage.Text);
            int lastPage = GetLastPage();
            int currentPage = Math.Min(lastPage, Convert.ToInt32(txtPage.Text));
            txtPage.Text = currentPage.ToString();
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
            txtPage.Text = page.ToString();
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
        private void btnLast_Click(object sender, EventArgs e)
        {
            txtPage.Text = GetLastPage().ToString();
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
        private void tsmHoiDong_Click(object sender, EventArgs e)
        {
            string maHoiDong = HoiDongDanhGiaBLL.GetMaHoiDongByMaGV(user.MaNguoiDung);
            frmDanhGiaDiem frm = new frmDanhGiaDiem(maHoiDong);
            frm.ShowDialog();
        }
        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin(user);
            frm.ShowDialog();
        }
        private void frmHome_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized) return;
            ResizeControls();
        }
        #endregion
    }
}
