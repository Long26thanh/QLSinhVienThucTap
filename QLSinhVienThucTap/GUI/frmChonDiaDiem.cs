﻿using QLSinhVienThucTap.BLL;
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
    public partial class frmChonDiaDiem : Form
    {
        public frmChonDiaDiem()
        {
            InitializeComponent();
            LoadData();
        }
        #region Method
        void LoadData()
        {
            LoadDiaDiem();
            LoadColumnDiaDiem();
        }
        void LoadDiaDiem()
        {
            dgvListDiaDiem.DataSource = DiaDiemBLL.GetListDiaDiemTT(Convert.ToInt32(txtPage.Text));
        }
        void LoadColumnDiaDiem()
        {
            dgvListDiaDiem.AutoGenerateColumns = false;
            dgvListDiaDiem.Columns["MaDiaDiem"].Visible = false;
            dgvListDiaDiem.Columns["TenDiaDiem"].HeaderText = "Tên địa điểm";
            dgvListDiaDiem.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvListDiaDiem.Columns["TenDiaDiem"].Width = 200;
        }
        int GetLastPage()
        {
            int sumRecord = DiaDiemBLL.GetNumDiaDiem();
            int lastPage = (sumRecord + 14) / 15;
            return lastPage > 0 ? lastPage : 1;
        }
        #endregion
        #region Event
        private event EventHandler<SelectDiaDiemEventArgs> selectDiaDiem;
        public event EventHandler<SelectDiaDiemEventArgs> SelectDiaDiem
        {
            add { selectDiaDiem += value; }
            remove { selectDiaDiem -= value; }
        }
        public class SelectDiaDiemEventArgs : EventArgs
        {
            private string maDiaDiem;
            private string tenDiaDiem;
            private string diaChi;
            public string MaDiaDiem
            {
                get { return maDiaDiem; }
                set { maDiaDiem = value; }
            }
            public string TenDiaDiem
            {
                get { return tenDiaDiem; }
                set { tenDiaDiem = value; }
            }
            public string DiaChi
            {
                get { return diaChi; }
                set { diaChi = value; }
            }
            public SelectDiaDiemEventArgs(string maDiaDiem, string tenDiaDiem, string diaChi)
            {
                this.MaDiaDiem = maDiaDiem;
                this.TenDiaDiem = tenDiaDiem;
                this.DiaChi = diaChi;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvListDiaDiem.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvListDiaDiem.CurrentRow.Cells[0].OwningRow;
                string maDiaDiem = row.Cells["MaDiaDiem"].Value.ToString();
                string tenDiaDiem = row.Cells["TenDiaDiem"].Value.ToString();
                string diaChi = row.Cells["DiaChi"].Value.ToString();
                selectDiaDiem(this, new SelectDiaDiemEventArgs(maDiaDiem, tenDiaDiem, diaChi));
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenDiaDiem = txtTenDiaDiem.Text;
            string diaChi = txtDiaChi.Text;
            if(DiaDiemBLL.InsertDiaDiem(tenDiaDiem, diaChi))
            {
                txtDiaChi.Text = "";
                txtTenDiaDiem.Text = "";
                LoadDiaDiem();
            }
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
            LoadDiaDiem();
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListDiaDiem.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa địa điểm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<string> listMaDiaDiem = new List<string>();
                    foreach (DataGridViewCell cell in dgvListDiaDiem.SelectedCells)
                    {
                        string maDiaDiem = cell.OwningRow.Cells["MaDiaDiem"].Value.ToString();
                        if (!listMaDiaDiem.Contains(maDiaDiem))
                        {
                            listMaDiaDiem.Add(maDiaDiem);
                            DiaDiemBLL.DeleteDiaDiem(maDiaDiem);
                        }
                    }
                    LoadDiaDiem();
                }
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
