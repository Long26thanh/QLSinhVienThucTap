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
        private string tenGV;
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
        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }
        public ThanhVienHoiDong(string maHoiDong, string maGV, string tenGV)
        {
            this.maHoiDong = maHoiDong;
            this.maGV = maGV;
            this.tenGV = tenGV;
        }
        public ThanhVienHoiDong(DataRow row)
        {
            this.maHoiDong = row["MaHoiDong"].ToString();
            this.maGV = row["MaGV"].ToString();
            this.tenGV = row["HoTenGV"].ToString();
        }
    }
}
