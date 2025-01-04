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
        private string maSV;
        private string maGV;
        private string maDeTai;
        private string maDiaDiem;
        private string maHoiDong;
        public string MaDotTT
        {
            get { return maDotTT; }
            set { maDotTT = value; }
        }
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        public string MaDeTai
        {
            get { return maDeTai; }
            set { maDeTai = value; }
        }
        public string MaDiaDiem
        {
            get { return maDiaDiem; }
            set { maDiaDiem = value; }
        }
        public string MaHoiDong
        {
            get { return maHoiDong; }
            set { maHoiDong = value; }
        }
        public frmThucTap(string maDotTT, string tenDot)
        {
            InitializeComponent();
            MaDotTT = maDotTT;
            txtDotTT.Text = tenDot;
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
            txtSinhVien.Text = e.HoTen;
        }
        private void btnChonGVHD_Click(object sender, EventArgs e)
        {
            frmChonGVHD thucTap = new frmChonGVHD();
            thucTap.SelectGiaoVien += ThucTap_SelectGiaoVien;
            thucTap.ShowDialog();
        }
        private void ThucTap_SelectGiaoVien(object sender, frmChonGVHD.SelectGiaoVienEventArgs e)
        {
            MaGV = e.MaGV;
            txtGVHD.Text = e.TenGV;
        }
        private void btnChonDotTT_Click(object sender, EventArgs e)
        {
            frmChonDotTT thucTap = new frmChonDotTT(maDotTT, txtDotTT.Text);
            thucTap.SelectDotTT += ThucTap_SelectDotTT;
            thucTap.AddDotTT += ThucTap_AddDotTT;
            thucTap.RemoveDotTT += ThucTap_RemoveDotTT;
            thucTap.ShowDialog();
        }
        private void ThucTap_SelectDotTT(object sender, frmChonDotTT.SelectDotTTEventArgs e)
        {
            MaDotTT = e.MaDotTT;
            txtDotTT.Text = e.TenDot;
        }
        private void ThucTap_AddDotTT(object sender, EventArgs e)
        {
            addDotTT?.Invoke(this, EventArgs.Empty);
        }
        private void ThucTap_RemoveDotTT(object sender, frmChonDotTT.RemoveDotTTEventArgs e)
        {
            MaDotTT = e.MaDotTT;
            txtDotTT.Text = e.TenDot;
            removeDotTT?.Invoke(this, EventArgs.Empty);
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
        private void btnDeTai_Click(object sender, EventArgs e)
        {
            frmChonDeTai deTai = new frmChonDeTai();
            deTai.SelectDeTai += DeTai_SelectDeTai;
            deTai.ShowDialog();
        }
        private void DeTai_SelectDeTai(object sender, frmChonDeTai.SelectDeTaiEventArgs e)
        {
            MaDeTai = e.MaDeTai;
            txtDeTai.Text = e.TenDeTai;
        }
        private void btnDiaDiem_Click(object sender, EventArgs e)
        {
            frmChonDiaDiem diaDiem = new frmChonDiaDiem();
            diaDiem.SelectDiaDiem += DiaDiem_SelectDiaDiem;
            diaDiem.ShowDialog();
        }
        private void DiaDiem_SelectDiaDiem(object sender, frmChonDiaDiem.SelectDiaDiemEventArgs e)
        {
            MaDiaDiem = e.MaDiaDiem;
            txtDiaDiem.Text = e.TenDiaDiem;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaGV) || string.IsNullOrEmpty(MaDeTai) || string.IsNullOrEmpty(MaDiaDiem))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            addThucTap(this, new AddThucTapEventArgs(MaDotTT, MaSV, MaGV, MaDeTai, MaDiaDiem, MaHoiDong));
            this.Close();
        }
        private void btnChonHoiDong_Click(object sender, EventArgs e)
        {
            frmChonHoiDong hoiDong = new frmChonHoiDong();
            hoiDong.SelectHoiDong += HoiDong_SelectHoiDong;
            hoiDong.ShowDialog();
        }
        private void HoiDong_SelectHoiDong(object sender, frmChonHoiDong.SelectHoiDongEventArgs e)
        {
            MaHoiDong = e.MaHoiDong;
            txtHoiDong.Text = e.TenHoiDong;
        }
        private event EventHandler<AddThucTapEventArgs> addThucTap;
        public event EventHandler<AddThucTapEventArgs> AddThucTap
        {
            add { addThucTap += value; }
            remove { addThucTap -= value; }
        }
        public class AddThucTapEventArgs : EventArgs
        {
            private string maDotTT;
            private string maSV;
            private string maGV;
            private string maDeTai;
            private string maDiaDiem;
            private string maHoiDong;
            public string MaDotTT
            {
                get { return maDotTT; }
                set { maDotTT = value; }
            }
            public string MaSV
            {
                get { return maSV; }
                set { maSV = value; }
            }
            public string MaGV
            {
                get { return maGV; }
                set { maGV = value; }
            }
            public string MaDeTai
            {
                get { return maDeTai; }
                set { maDeTai = value; }
            }
            public string MaDiaDiem
            {
                get { return maDiaDiem; }
                set { maDiaDiem = value; }
            }
            public string MaHoiDong
            {
                get { return maHoiDong; }
                set { maHoiDong = value; }
            }
            public AddThucTapEventArgs(string maDotTT, string maSV, string maGV, string maDeTai, string maDiaDiem, string maHoiDong)
            {
                this.MaDotTT = maDotTT;
                this.MaSV = maSV;
                this.MaGV = maGV;
                this.MaDeTai = maDeTai;
                this.MaDiaDiem = maDiaDiem;
                this.MaHoiDong = maHoiDong;
            }
        }
        #endregion
    }
}
