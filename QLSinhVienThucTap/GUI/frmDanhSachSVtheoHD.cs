using QLSinhVienThucTap.BLL;
using QLSinhVienThucTap.GUI.frmReportViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.GUI
{
    public partial class frmDanhSachSVtheoHD : Form
    {
        private string maHoiDong, tenHoiDong;

        public frmDanhSachSVtheoHD(string maHoiDong, string tenHoiDong)
        {
            InitializeComponent();

            this.maHoiDong = maHoiDong;
            LoadDanhSachSVTheoHD();

            // Đổi tên lblSV theo hội đồng đã chọn
            this.tenHoiDong = tenHoiDong;
            lblHeader.Text = "Danh sách sinh viên thuộc " + tenHoiDong;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Chuyển dữ liệu từ DataGridView sang DataTable
            DataTable dt = frmAdmin.ConvertDataGridViewToDataTable(dgvSinhVien);

            // Lấy nội dung của lblSV
            string lblHeader = this.lblHeader.Text;

            // Mở form mới chứa ReportViewer
            frmRV reportForm = new frmRV(dt, "SinhVienDataSet", "rptSinhVienTheoHD", lblHeader); // Truyền DataTable vào form
            reportForm.ShowDialog();
        }

        private void dgvSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột là "GioiTinh" và loại dữ liệu là bool
            if (dgvSinhVien.Columns[e.ColumnIndex].Name == "GioiTinh" && e.Value != null)
            {
                // Chuyển đổi true/false thành Nam/Nữ
                bool isMale = (bool)e.Value;
                e.Value = isMale ? "Nam" : "Nữ"; // Nếu true thì Nam, nếu false thì Nữ
            }
        }

        // Hàm load danh sách sinh viên
        private void LoadDanhSachSVTheoHD()
        {
            try
            {
                dgvSinhVien.DataSource = SinhVienBLL.GetListSinhVienByHoiDong(maHoiDong);
                dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSinhVien.AutoGenerateColumns = false;

                dgvSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";
                dgvSinhVien.Columns["TenSV"].HeaderText = "Họ và tên";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvSinhVien.Columns["Email"].HeaderText = "Email";
                dgvSinhVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgvSinhVien.Columns["MaLop"].HeaderText = "Mã lớp";

                dgvSinhVien.Columns["MaSV"].Width = 100;
                dgvSinhVien.Columns["TenSV"].Width = 125;
                dgvSinhVien.Columns["NgaySinh"].Width = 100;
                dgvSinhVien.Columns["GioiTinh"].Width = 75;
                dgvSinhVien.Columns["DiaChi"].Width = 150;
                dgvSinhVien.Columns["Email"].Width = 150;
                dgvSinhVien.Columns["SoDienThoai"].Width = 100;
                dgvSinhVien.Columns["MaLop"].Width = 75;
                dgvSinhVien.Columns["MaSV"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sinh viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
