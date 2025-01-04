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
    public partial class frmChonHoiDong : Form
    {
        public frmChonHoiDong()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            LoadHoiDong();
            LoadColumnHoiDong();
        }
        void LoadHoiDong()
        {
            dgvListHoiDong.DataSource = HoiDongDanhGiaBLL.GetListHoiDong();
        }
        void LoadColumnHoiDong()
        {
            dgvListHoiDong.AutoGenerateColumns = false;
            dgvListHoiDong.Columns["MaHoiDong"].Visible = false;
            dgvListHoiDong.Columns["TenHoiDong"].HeaderText = "Tên hội đồng";
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvListHoiDong.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvListHoiDong.CurrentRow.Cells[0].OwningRow;
                string maHoiDong = row.Cells["MaHoiDong"].Value.ToString();
                string tenHoiDong = row.Cells["TenHoiDong"].Value.ToString();
                selectHoiDong(this, new SelectHoiDongEventArgs(maHoiDong, tenHoiDong));
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hội đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private event EventHandler<SelectHoiDongEventArgs> selectHoiDong;
        public event EventHandler<SelectHoiDongEventArgs> SelectHoiDong
        {
            add { selectHoiDong += value; }
            remove { selectHoiDong -= value; }
        }
        public class SelectHoiDongEventArgs : EventArgs
        {
            private string maHoiDong;
            private string tenHoiDong;
            public string MaHoiDong
            {
                get { return maHoiDong; }
                set { maHoiDong = value; }
            }
            public string TenHoiDong
            {
                get { return tenHoiDong; }
                set { tenHoiDong = value; }
            }
            public SelectHoiDongEventArgs(string maHoiDong, string tenHoiDong)
            {
                this.MaHoiDong = maHoiDong;
                this.TenHoiDong = tenHoiDong;
            }
        }

        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            string tenHoiDong = txtTenHoiDong.Text;
            if (string.IsNullOrEmpty(tenHoiDong))
            {
                LoadHoiDong();
                return;
            }
            dgvListHoiDong.DataSource = HoiDongDanhGiaBLL.TimKiemHoiDong(tenHoiDong);
        }
    }
}
