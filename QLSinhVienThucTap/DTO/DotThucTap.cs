using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class DotThucTap
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
        public DotThucTap(string maDotTT, string tenDot, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.maDotTT = maDotTT;
            this.tenDot = tenDot;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
        public DotThucTap(DataRow row)
        {
            this.maDotTT = row["MaDotTT"].ToString();
            this.tenDot = row["TenDot"].ToString();
            this.ngayBatDau = (DateTime)row["ThoiGianBatDau"];
            this.ngayKetThuc = (DateTime)row["ThoiGianKetThuc"];
        }
    }
}