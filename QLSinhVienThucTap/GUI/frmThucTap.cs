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
    public partial class frmThucTap : Form
    {
        private string maDotTT;
        public string MaDotTT
        {
            get { return maDotTT; }
            set { maDotTT = value; }
        }
        private string maSV;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public frmThucTap(string maDotTT)
        {
            InitializeComponent();
            this.MaDotTT = maDotTT;
        }
        #region Event
        private void btnChonSinhVien_Click(object sender, EventArgs e)
        {
            frmChonSinhVien thucTap = new frmChonSinhVien(MaDotTT);
            thucTap.SelectSinhVien += ThucTap_SelectSinhVien;
            thucTap.ShowDialog();
        }
        private void ThucTap_SelectSinhVien(object sender, frmChonSinhVien.SelectSinhVienEventArgs e)

        {
            MaSV = e.MaSV;
            MessageBox.Show(MaSV);
            txtSinhVien.Text = e.HoTen;
        }
        #endregion
    }
}
