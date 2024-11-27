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
    internal class LopDAL
    {
        private static LopDAL instance;
        public static LopDAL Instance
        {
            get { if (instance == null) instance = new LopDAL(); return LopDAL.instance; }
            private set { LopDAL.instance = value; }
        }
        private LopDAL() { }
        public List<Lop> GetListLop()
        {
            List<Lop> list = new List<Lop>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop");
            foreach (DataRow item in data.Rows)
            {
                Lop lop = new Lop(item);
                list.Add(lop);
            }
            return list;
        }
        public List<Lop> GetListLopByMaKhoa(string makhoa) 
        {
            List<Lop> list = new List<Lop>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhoa", makhoa)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListLopByMaKhoa @MaKhoa", parameters);
            foreach (DataRow item in data.Rows)
            {
                Lop lop = new Lop(item);
                list.Add(lop);
            }
            return list;
        }
        public void InsertLop(string tenLop, string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenLop", tenLop),
                new SqlParameter("@maKhoa", maKhoa)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertLop @tenLop, @maKhoa", parameters);
        }
        public void UpdateLop(string maLop, string tenLop)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@TenLop", tenLop),
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateLop @MaLop, @TenLop", parameters);
        }
        public void DeleteLop(string maLop) 
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maLop)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteLop @MaLop", parameters);
        }
        public List<Lop> TimKiemLop(string tenLop)
        {
            List<Lop> list = new List<Lop>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenLop", tenLop)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemLop @TenLop", parameters);
            foreach (DataRow item in data.Rows)
            {
                Lop lop = new Lop(item);
                list.Add(lop);
            }
            return list;
        }
    }
}
