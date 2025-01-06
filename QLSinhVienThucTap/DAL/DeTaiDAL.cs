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
    internal class DeTaiDAL
    {
        private static DeTaiDAL instance;
        public static DeTaiDAL Instance
        {
            get { if(instance == null) instance = new DeTaiDAL(); return instance; }
            private set { instance = value; }
        }
        private DeTaiDAL() { }
        public List<DeTai> GetListDeTai(int page)
        {
            List<DeTai> list = new List<DeTai>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDeTaiThucTap @page", parameters).Rows)
            {
                list.Add(new DeTai(item));
            }
            return list;
        }
        public int GetNumDeTai()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM DE_TAI_THUC_TAP");
        }
        public bool InsertDeTai(string tenDeTai, string moTa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDeTai", tenDeTai),
                new SqlParameter("@MoTa", moTa)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertDeTai @TenDeTai, @MoTa", parameters) > 0;
        }
        public bool DeleteDeTai(string maDeTai)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDeTai", maDeTai)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteDeTai @MaDeTai", parameters) > 0;
        }
    }
}
