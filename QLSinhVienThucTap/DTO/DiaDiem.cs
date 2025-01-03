using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class DiaDiem
    {
        private string maDiaDiem;
        private string tenDiaDiem;
        private string diaChi;
        public string MaDiaDiem
        {
            get { return maDiaDiem; }
            set { maDiaDiem = value; }
        }
        public string TenDiaDiem
        {
            get { return tenDiaDiem; }
            set { tenDiaDiem = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public DiaDiem(string maDiaDiem, string tenDiaDiem, string diaChi)
        {
            this.maDiaDiem = maDiaDiem;
            this.tenDiaDiem = tenDiaDiem;
            this.diaChi = diaChi;
        }
        public DiaDiem(DataRow row)
        {
            this.maDiaDiem = row["MaDiaDiem"].ToString();
            this.tenDiaDiem = row["TenDiaDiem"].ToString();
            this.diaChi = row["DiaChi"].ToString();
        }
    }
}
