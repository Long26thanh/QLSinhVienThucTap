using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class ThanhVienHoiDong
    {
        private string maHoiDong;
        private string maGV;
        public string MaHoiDong
        {
            get { return maHoiDong; }
            set { maHoiDong = value; }
        }
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        public ThanhVienHoiDong(string maHoiDong, string maGV)
        {
            this.maHoiDong = maHoiDong;
            this.maGV = maGV;
        }
        public ThanhVienHoiDong(DataRow row)
        {
            this.maHoiDong = row["MaHoiDong"].ToString();
            this.maGV = row["MaGV"].ToString();
        }
    }
}
