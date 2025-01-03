using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class DeTai
    {
        private string maDeTai;
        private string tenDeTai;
        private string moTa;
        public string MaDeTai
        {
            get { return maDeTai; }
            set { maDeTai = value; }
        }
        public string TenDeTai
        {
            get { return tenDeTai; }
            set { tenDeTai = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public DeTai(string maDeTai, string tenDeTai, string moTa)
        {
            this.MaDeTai = maDeTai;
            this.TenDeTai = tenDeTai;
            this.MoTa = moTa;
        }
        public DeTai(DataRow row)
        {
            this.MaDeTai = row["MaDeTai"].ToString();
            this.TenDeTai = row["TenDeTai"].ToString();
            this.MoTa = row["MoTa"].ToString();
        }
    }
}
