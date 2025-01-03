using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    public class ThucTap
    {
        private string maThucTap;
        private string maSinhVien;
        private string maGiaoVien;
        private string maDeTai;
        private string maDiaDiem;
        private string hoTenSV;
        private string tenDeTai;
        private string tenDiaDiem;
        private string hoTenGV;
        public string MaThucTap
        {
            get { return maThucTap; }
            set { maThucTap = value; }
        }
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        public string MaGiaoVien
        {
            get { return maGiaoVien; }
            set { maGiaoVien = value; }
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
        public string HoTenSV
        {
            get { return hoTenSV; }
            set { hoTenSV = value; }
        }
        public string TenDeTai
        {
            get { return tenDeTai; }
            set { tenDeTai = value; }
        }
        public string TenDiaDiem
        {
            get { return tenDiaDiem; }
            set { tenDiaDiem = value; }
        }
        public string HoTenGV
        {
            get { return hoTenGV; }
            set { hoTenGV = value; }
        }
        public ThucTap(string maThucTap, string maSinhVien, string maGiaoVien, string maDeTai, string maDiaDiem, string maDotThucTap, string hoTenSV, string hoTenGV, string tenDeTai, string tenDiaDiem, string tenDotThucTap)
        {
            this.MaThucTap = maThucTap;
            this.MaSinhVien = maSinhVien;
            this.MaGiaoVien = maGiaoVien;
            this.MaDeTai = maDeTai;
            this.MaDiaDiem = maDiaDiem;
            this.HoTenSV = hoTenSV;
            this.TenDeTai = tenDeTai;
            this.TenDiaDiem = tenDiaDiem;
            this.HoTenGV = hoTenGV;
        }
        public ThucTap(DataRow row)
        {
            this.MaThucTap = row["MaTT"].ToString();
            this.MaSinhVien = row["MaSinhVien"].ToString();
            this.MaGiaoVien = row["MaGV"].ToString();
            this.MaDeTai = row["MaDeTai"].ToString();
            this.MaDiaDiem = row["MaDiaDiem"].ToString();
            this.HoTenSV = row["HoTen"].ToString();
            this.TenDeTai = row["TenDeTai"].ToString();
            this.TenDiaDiem = row["TenDiaDiem"].ToString();
            this.HoTenGV = row["HoTenGV"].ToString();
        }
    }
}
