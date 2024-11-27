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
    internal class KhoaDAL
    {
        private static KhoaDAL instance;
        public static KhoaDAL Instance
        {
            get { if (instance == null) instance = new KhoaDAL(); return instance; }
            private set { instance = value; }
        }
        private KhoaDAL() { }
        public List<Khoa> GetListKhoa()
        {
            List<Khoa> list = new List<DTO.Khoa>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Khoa");
            foreach (DataRow item in data.Rows)
            {
                Khoa khoa = new Khoa(item);
                list.Add(khoa);
            }
            return list;
        }
        public List<Khoa> TimKiemKhoa(string tenKhoa)
        {
            List<Khoa> list = new List<DTO.Khoa>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenKhoa", tenKhoa)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemKhoa @tenKhoa", parameters);
            foreach (DataRow item in data.Rows)
            {
                Khoa khoa = new Khoa(item);
                list.Add(khoa);
            }
            return list;
        }
        public string InsertKhoa(string tenKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenKhoa", tenKhoa)
            };
            return DataProvider.Instance.ExecuteScalar("EXEC USP_InsertKhoa @tenKhoa", parameters).ToString();
        }
        public void UpdateKhoa(string maKhoa, string tenKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhoa", maKhoa),
                new SqlParameter("@TenKhoa", tenKhoa)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateKhoa @MaKhoa, @TenKhoa", parameters);
        }
        public void DeleteKhoa(string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhoa", maKhoa)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteKhoa @MaKhoa", parameters);
        }
    }
}
