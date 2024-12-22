using QLSinhVienThucTap.BLL;
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
            LoadData();

            // Đổi tên lblSV theo hội đồng đã chọn
            this.tenHoiDong = tenHoiDong;
            lblSV.Text = "Danh sách sinh viên thuộc " + tenHoiDong;
            lblSV.Location = new Point(
                (this.ClientSize.Width - lblSV.Width) / 2
            );
        }

        // Hàm load danh sách sinh viên
        private void LoadData()
        {
            try
            {
                dgvSinhVien.DataSource = SinhVienBLL.GetListSinhVienByHoiDong(maHoiDong);
                dgvSinhVien.AutoGenerateColumns = true;
                dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sinh viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
