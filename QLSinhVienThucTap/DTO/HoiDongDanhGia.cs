using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class HoiDongDanhGia
    {
        private string maHoiDong;
        private string tenHoiDong;
        public string MaHoiDong
        {
            get { return maHoiDong; }
            set { maHoiDong = value; }
        }
        public string TenHoiDong
        {
            get { return tenHoiDong; }
            set { tenHoiDong = value; }
        }
        public HoiDongDanhGia(string maHoiDong, string tenHoiDong)
        {
            this.maHoiDong = maHoiDong;
            this.tenHoiDong = tenHoiDong;
        }
        public HoiDongDanhGia(DataRow row)
        {
            this.maHoiDong = row["MaHoiDong"].ToString();
            this.tenHoiDong = row["TenHoiDong"].ToString();
        }
    }
}
