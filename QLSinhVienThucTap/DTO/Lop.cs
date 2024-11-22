using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class Lop
    {
        private string maLop;
        private string tenLop;
        private string maKhoa;
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public Lop(string maLop, string tenLop, string khoa)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoa = khoa;
        }
        public Lop(DataRow row)
        {
            this.maLop = row["MaLop"].ToString();
            this.tenLop = row["TenLop"].ToString();
            this.maKhoa = row["MaKhoa"].ToString();
        }
    }
}
