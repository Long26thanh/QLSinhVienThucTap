using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DAL
{
    internal class DiaDiemDAL
    {
        private static DiaDiemDAL instance;
        public static DiaDiemDAL Instance
        {
            get { if (instance == null) instance = new DiaDiemDAL(); return DiaDiemDAL.instance; }
            private set { DiaDiemDAL.instance = value; }
        }
        private DiaDiemDAL() { }
        public List<DiaDiem> GetListDiaDiemTTByDotTT(string maDotTT)
        {
            List<DiaDiem> list = new List<DiaDiem>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maDotTT", maDotTT)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDiaDiemByDotTT @maDotTT", parameters);

            foreach (DataRow item in data.Rows)
            {
                DiaDiem DiaDiem = new DiaDiem(item);
                list.Add(DiaDiem);
            }
            return list;
        }
        public List<DiaDiem> GetListDiaDiemTT(int page)
        {
            List<DiaDiem> list = new List<DiaDiem>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDiaDiemTT @page", parameters).Rows)
            {
                list.Add(new DiaDiem(item));
            }
            return list;
        }
        public bool InsertDiaDiem(string tenDiaDiem, string diaChi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDiaDiem", tenDiaDiem),
                new SqlParameter("@DiaChi", diaChi)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC InsertDiaDiem @TenDiaDiem, @DiaChi", parameters) > 0;
        }
        public bool DeleteDiaDiem(string maDiaDiem)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDiaDiem", maDiaDiem)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC DeleteDiaDiem @MaDiaDiem", parameters) > 0;
        }
    }
}
