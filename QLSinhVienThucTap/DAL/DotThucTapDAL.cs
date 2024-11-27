using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DAL
{
    internal class DotThucTapDAL
    {
        private static DotThucTapDAL instance;
        public static DotThucTapDAL Instance
        {
            get { if (instance == null) instance = new DotThucTapDAL(); return instance; }
            private set { instance = value; }
        }
        private DotThucTapDAL() { }
        public List<DotThucTap> GetListDotThucTap()
        {
            List<DotThucTap> list = new List<DotThucTap>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM DOT_THUC_TAP ORDER BY MaDotTT DESC").Rows)
            {
                list.Add(new DotThucTap(item));
            }
            return list;
        }
    }
}
