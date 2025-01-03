using QLSinhVienThucTap.BLL;
using QLSinhVienThucTap.GUI.frmReportViewer;
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
    public partial class frmDiaDiemTT : Form
    {
        private string maDotTT, tenDotTT;

        public frmDiaDiemTT(string maDotTT, string tenDotTT)
        {
            InitializeComponent();

            this.maDotTT = maDotTT;
            LoadDiaDiemTT();

            this.tenDotTT = tenDotTT;
            lblHeader.Text = "Danh sách địa điểm thực tập " + tenDotTT;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Chuyển dữ liệu từ DataGridView sang DataTable
            DataTable dt = frmAdmin.ConvertDataGridViewToDataTable(dgvDiaDiemTT);

            // Lấy nội dung của lblHeadrer
            string lblHeader = this.lblHeader.Text;

            // Mở form mới chứa ReportViewer
            frmRV reportForm = new frmRV(dt, "ThucTapDataSet", "rptDiaDiemTT", lblHeader);
            reportForm.ShowDialog();
        }

        // Hàm load danh sách sinh viên
        private void LoadDiaDiemTT()
        {
            try
            {
                dgvDiaDiemTT.DataSource = DiaDiemBLL.GetListDiaDiemTTByDotTT(maDotTT);
                dgvDiaDiemTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDiaDiemTT.AutoGenerateColumns = false;

                // Dọn hết các cột để tránh thừa
                dgvDiaDiemTT.Columns.Clear();

                // Thêm lại các cột cần thiết
                dgvDiaDiemTT.Columns.Add("MaDiaDiem", "Mã địa điểm TT");
                dgvDiaDiemTT.Columns["MaDiaDiem"].DataPropertyName = "MaDiaDiem";

                dgvDiaDiemTT.Columns.Add("TenDiaDiem", "Tên địa điểm TT");
                dgvDiaDiemTT.Columns["TenDiaDiem"].DataPropertyName = "TenDiaDiem";

                dgvDiaDiemTT.Columns.Add("DiaChi", "Địa chỉ");
                dgvDiaDiemTT.Columns["DiaChi"].DataPropertyName = "DiaChi";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
