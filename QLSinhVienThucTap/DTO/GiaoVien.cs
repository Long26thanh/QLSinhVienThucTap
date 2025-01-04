using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class GiaoVien
    {
        private string maGV;
        private string tenGV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string diaChi;
        private string email;
        private string maKhoa;
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
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
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public GiaoVien(string maGV, string tenGV, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string email, string maKhoa)
        {
            this.MaGV = maGV;
            this.TenGV = tenGV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh ? "Nam" : "Nữ";
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
            this.Email = email;
            this.MaKhoa = maKhoa;
        }
        public GiaoVien(DataRow row)
        {
            this.MaGV = row["MaGV"].ToString();
            this.TenGV = row["HoTenGV"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = (bool)row["GioiTinh"] ? "Nam" : "Nữ";
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Email = row["Email"].ToString();
            this.MaKhoa = row["MaKhoa"].ToString();
        }
    }
}
