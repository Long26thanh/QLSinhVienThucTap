using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QLSinhVienThucTap.DAL
{
    internal class GiaoVienDAL
    {
        private static GiaoVienDAL instance;
        public static GiaoVienDAL Instance
        {
            get { if (instance == null) instance = new GiaoVienDAL(); return instance; }
            private set { instance = value; }
        }
        private GiaoVienDAL() { }
        public List<GiaoVien> GetListGiaoVien()
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = "SELECT * FROM GiaoVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public List<GiaoVien> GetListGiaoVienByKhoa(string maKhoa, int page, string maGV)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@page", page),
                new SqlParameter("@maGV", maGV)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListGiaoVienByKhoa @maKhoa, @page, @maGV", parameters);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public List<GiaoVien> TimKiemGV(string maGV, string tenGV, string maKhoa, string userid, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@tenGV", string.IsNullOrEmpty(tenGV) ? (object)DBNull.Value : tenGV),
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@userid", string.IsNullOrEmpty(userid) ? (object)DBNull.Value : userid),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemGiaoVien @maGV, @tenGV, @maKhoa, @userid, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public int GetNumTimKiemGiaoVien(string maGV, string tenGV, string maKhoa, string userid)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@tenGV", string.IsNullOrEmpty(tenGV) ? (object)DBNull.Value : tenGV),
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@userid", string.IsNullOrEmpty(userid) ? (object)DBNull.Value : userid)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumTimKiemGiaoVien @maGV, @tenGV, @maKhoa, @userid", parameters);
        }
        public int GetNumGiaoVienByKhoa(string maKhoa, string userid)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@userid", string.IsNullOrEmpty(userid) ? (object)DBNull.Value : userid)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumGiaoVienByKhoa @maKhoa, @userid", parameters);
        }
        public string InsertGiaoVien(string tenGV, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string email, string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenGV", tenGV),
                new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@email", email),
                new SqlParameter("@maKhoa", maKhoa)
            };
            return DataProvider.Instance.ExecuteScalar("EXEC USP_InsertGiaoVien @tenGV, @ngaySinh, @gioiTinh, @soDienThoai, @diaChi, @email, @maKhoa", parameters).ToString();
        }
        public void DeleteGiaoVien(string maGV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", maGV)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteGiaoVien @maGV", parameters);
        }
    }
}
