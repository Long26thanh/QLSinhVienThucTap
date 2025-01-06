using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public bool InsertDotThucTap(string tenDot, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDot", tenDot),
                new SqlParameter("@NgayBatDau", ngayBatDau),
                new SqlParameter("@NgayKetThuc", ngayKetThuc)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertDotTT @TenDot, @NgayBatDau, @NgayKetThuc", parameters) > 0;
        }
        public bool DeleteDotThucTap(string maDotTT)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDotTT", maDotTT)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteDotTT @MaDotTT", parameters) > 0;
        }
    }
}
