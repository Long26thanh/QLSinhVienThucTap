using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class SinhVien
    {
        private string maSV;
        private string tenSV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string diaChi;
        private string email;
        private string maLop;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public SinhVien(string maSV, string tenSV, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string email, string lop)
        {
            this.MaSV = maSV;
            this.TenSV = tenSV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh ? "Nam" : "Nữ";
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
            this.Email = email;
            this.MaLop = lop;
        }
        public SinhVien(DataRow row)
        {
            this.MaSV = row["MaSinhVien"].ToString();
            this.TenSV = row["HoTen"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"] == DBNull.Value ? "" : (bool)row["GioiTinh"] ? "Nam" : "Nữ";
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Email = row["Email"].ToString();
            this.MaLop = row["MaLop"].ToString();
        }
    }
}
