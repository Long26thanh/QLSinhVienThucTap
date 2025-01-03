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
    public partial class frmChonDotTT : Form
    {
        public frmChonDotTT()
        {
            InitializeComponent();
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadDotTT();
            LoadColumnDotTT();
        }
        void LoadDotTT()
        {
            dgvListDotTT.DataSource = DotThucTapBLL.GetListDotThucTap();
        }
        void LoadColumnDotTT()
        {
            dgvListDotTT.AutoGenerateColumns = false;
            dgvListDotTT.Columns["MaDotTT"].Visible = false;
            dgvListDotTT.Columns["TenDot"].HeaderText = "Tên đợt thực tập";
            dgvListDotTT.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dgvListDotTT.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
        }
        #endregion
        #region Event
        private void dgvListDotTT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvListDotTT.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvListDotTT.CurrentRow.Cells[0].OwningRow;
                string maDotTT = row.Cells["MaDotTT"].Value.ToString();
                string tenDot = row.Cells["TenDot"].Value.ToString();
                DateTime ngayBatDau = (DateTime)row.Cells["NgayBatDau"].Value;
                DateTime ngayKetThuc = (DateTime)row.Cells["NgayKetThuc"].Value;
                selectDotTT(this, new SelectDotTTEventArgs(maDotTT, tenDot, ngayBatDau, ngayKetThuc));
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đợt thực tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private event EventHandler<SelectDotTTEventArgs> selectDotTT;
        public event EventHandler<SelectDotTTEventArgs> SelectDotTT
        {
            add { selectDotTT += value; }
            remove { selectDotTT -= value; }
        }
        public class SelectDotTTEventArgs : EventArgs
        {
            private string maDotTT;
            private string tenDot;
            private DateTime ngayBatDau;
            private DateTime ngayKetThuc;
            public string MaDotTT
            {
                get { return maDotTT; }
                set { maDotTT = value; }
            }
            public string TenDot
            {
                get { return tenDot; }
                set { tenDot = value; }
            }
            public DateTime NgayBatDau
            {
                get { return ngayBatDau; }
                set { ngayBatDau = value; }
            }
            public DateTime NgayKetThuc
            {
                get { return ngayKetThuc; }
                set { ngayKetThuc = value; }
            }
            public SelectDotTTEventArgs(string maDotTT, string tenDot, DateTime ngayBatDau, DateTime ngayKetThuc)
            {
                this.maDotTT = maDotTT;
                this.tenDot = tenDot;
                this.ngayBatDau = ngayBatDau;
                this.ngayKetThuc = ngayKetThuc;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenDot = txtTenDot.Text;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            if(DotThucTapBLL.InsertDotThucTap(tenDot, ngayBatDau, ngayKetThuc))
            {
                txtTenDot.Text = "";
                addDotTT?.Invoke(this, EventArgs.Empty);
                LoadDotTT();
            } 
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListDotTT.SelectedCells.Count > 0)
            {
                var confim = MessageBox.Show("Bạn có chắc chắn muốn xóa đợt thực tập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confim == DialogResult.Yes)
                {
                    List<string> listMaDotTT = new List<string>();
                    foreach (DataGridViewCell cell in dgvListDotTT.SelectedCells)
                    {
                        string maDotTT = cell.OwningRow.Cells["MaDotTT"].Value.ToString();
                        if(!listMaDotTT.Contains(maDotTT))
                        {
                            listMaDotTT.Add(maDotTT);
                            DotThucTapBLL.DeleteDotThucTap(maDotTT);
                        }
                    }
                    removeDotTT?.Invoke(this, EventArgs.Empty);
                    LoadDotTT();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đợt thực tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private event EventHandler addDotTT;
        public event EventHandler AddDotTT
        {
            add { addDotTT += value; }
            remove { addDotTT -= value; }
        }
        private event EventHandler removeDotTT;
        public event EventHandler RemoveDotTT
        {
            add { removeDotTT += value; }
            remove { removeDotTT -= value; }
        }
        #endregion

    }
}
