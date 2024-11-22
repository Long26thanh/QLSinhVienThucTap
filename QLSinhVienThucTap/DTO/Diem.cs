using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class Diem
    {
        private string maDiem;
        private string maSinhVien;
        private string sinhVien;
        private string deTai;
        private float? diemSo;
        public string MaDiem
        {
            get { return maDiem; }
            set { maDiem = value; }
        }
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        public string SinhVien
        {
            get { return sinhVien; }
            set { sinhVien = value; }
        }
        public string DeTai
        {
            get { return deTai; }
            set { deTai = value; }
        }
        public float? DiemSo
        {
            get { return diemSo; }
            set { diemSo = value; }
        }
        public Diem(string maDiem, string maThucTap, string maSinhVien,string sinhVien, string deTai, string hoiDong, float diemSo)
        {
            this.maDiem = maDiem;
            this.maSinhVien = maSinhVien;
            this.sinhVien = sinhVien;
            this.deTai = deTai;
            this.diemSo = diemSo;
        }
        public Diem(DataRow row)
        {
            this.maDiem = row["MaDiem"].ToString();
            this.maSinhVien = row["MaSinhVien"].ToString();
            this.sinhVien = row["HoTen"].ToString();
            this.deTai = row["TenDeTai"].ToString();
            this.diemSo = row["DiemSo"] != DBNull.Value ? (float?)Convert.ToDouble(row["DiemSo"]) : null;
        }
    }
}
