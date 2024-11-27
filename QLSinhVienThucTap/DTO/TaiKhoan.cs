using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    public class TaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;
        private string maNguoiDung;
        private string tenNguoiDung;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string soDienThoai;
        private string diaChi;
        private string email;
        private string khoa;
        private bool vaiTro;
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        public string MaNguoiDung
        {
            get { return maNguoiDung; }
            set { maNguoiDung = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string TenNguoiDung
        {
            get { return tenNguoiDung; }
            set { tenNguoiDung = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public bool GioiTinh
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
        public string Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }
        public bool VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
        public TaiKhoan(string TenDangNhap, string MaNguoiDung, string TenNguoiDung, DateTime NgaySinh, bool GioiTinh, string SoDienThoai, string DiaChi, string Email, string Khoa, bool VaiTro, string MatKhau = null)
        {
            this.MaNguoiDung = MaNguoiDung;
            this.TenDangNhap = TenDangNhap;
            this.TenNguoiDung = TenNguoiDung;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.Khoa = Khoa;
            this.VaiTro = VaiTro;
            if (MatKhau != null)
            {
                this.MatKhau = MatKhau;
            }
        }
        public TaiKhoan(DataRow row)
        {
            this.MaNguoiDung = row["MaGV"] != DBNull.Value ? row["MaGV"].ToString() : string.Empty;
            this.TenDangNhap = row["TenDangNhap"] != DBNull.Value ? row["TenDangNhap"].ToString() : string.Empty;
            this.TenNguoiDung = row["HoTenGV"] != DBNull.Value ? row["HoTenGV"].ToString() : string.Empty;
            if (row["NgaySinh"] != DBNull.Value)
            {
                this.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
            }
            else
            {
                this.NgaySinh = DateTime.Today;
            }
            this.GioiTinh = row["GioiTinh"] != DBNull.Value ? Convert.ToBoolean(row["GioiTinh"]) : true;
            this.SoDienThoai = row["SoDienThoai"] != DBNull.Value ? row["SoDienThoai"].ToString() : string.Empty;
            this.DiaChi = row["DiaChi"] != DBNull.Value ? row["DiaChi"].ToString() : string.Empty;
            this.Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : string.Empty;
            this.Khoa = row["TenKhoa"] != DBNull.Value ? row["TenKhoa"].ToString() : string.Empty;
            this.VaiTro = row["VaiTro"] != DBNull.Value ? Convert.ToBoolean(row["VaiTro"]) : false;
            if (row.Table.Columns.Contains("MatKhau") && row["MatKhau"] != DBNull.Value)
            {
                this.MatKhau = row["MatKhau"].ToString();
            }
        }
    }
}
