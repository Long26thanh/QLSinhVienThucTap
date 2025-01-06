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
        public List<GiaoVien> GetListGiaoVienHuongDan(string maKhoa, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListGiaoVienHuongDan @maKhoa, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public List<GiaoVien> GetListGiaoVienByMaKhoa(string maKhoa, string maGV, string maHoiDong, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@maHoiDong", maHoiDong),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListGiaoVienByMaKhoa @maKhoa, @maGV, @maHoiDong, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public List<GiaoVien> GetListGiaoVienHasNotAccount(string maKhoa, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC GetListGiaoVienHasNotAccount @maKhoa, @page", parameters);
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
        public List<GiaoVien> TimKiemGV(string maGV, string tenGV, string maKhoa, string maHoiDong, string userid, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@tenGV", string.IsNullOrEmpty(tenGV) ? (object)DBNull.Value : tenGV),
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@maHoiDong", string.IsNullOrEmpty(maHoiDong) ? (object)DBNull.Value : maHoiDong),
                new SqlParameter("@userid", string.IsNullOrEmpty(userid) ? (object)DBNull.Value : userid),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemGiaoVien2 @maGV, @tenGV, @maKhoa, @maHoiDong, @userid, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public List<GiaoVien> TimKiemGiaoVien(string maGV, string tenGV, string maKhoa, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@tenGV", string.IsNullOrEmpty(tenGV) ? (object)DBNull.Value : tenGV),
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemGiaoVienHuongDan @maGV, @tenGV, @maKhoa, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaoVien = new GiaoVien(item);
                list.Add(giaoVien);
            }
            return list;
        }
        public List<GiaoVien> TimKiemGiaoVienHasNotAccount(string maKhoa, string maGV, string hoTen, int page)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@hoTen", string.IsNullOrEmpty(hoTen) ? (object)DBNull.Value : hoTen),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemGiaoVienHasNotAccount @maKhoa, @maGV, @hoTen,@page", parameters);
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
        public int GetNumTimKiemGiaoVien(string maGV, string tenGV, string maKhoa, string maHoiDong, string userid)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@tenGV", string.IsNullOrEmpty(tenGV) ? (object)DBNull.Value : tenGV),
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@maHoiDong", string.IsNullOrEmpty(maHoiDong) ? (object)DBNull.Value : maHoiDong),
                new SqlParameter("@userid", string.IsNullOrEmpty(userid) ? (object)DBNull.Value : userid)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumTimKiemGiaoVien2 @maGV, @tenGV, @maKhoa, @maHoiDong, @userid", parameters);
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
        public int GetNumGiaoVienByMaKhoa(string maKhoa, string maGV, string maHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@maHoiDong", maHoiDong)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumGiaoVienByMaKhoa @maKhoa, @maGV, @maHoiDong", parameters);
        }
        public int GetNumGiaoVienHuongDan(string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumGiaoVienHuongDan @maKhoa", parameters);
        }
        public int GetNumTimKiemGiaoVienHuongDan(string maGV, string tenGV, string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@tenGV", string.IsNullOrEmpty(tenGV) ? (object)DBNull.Value : tenGV),
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumTimKiemGiaoVienHuongDan @maGV, @tenGV, @maKhoa", parameters);
        }
        public int GetNumGiaoVienHasNotAccount(string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", maKhoa)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumGiaoVienHasNotAccount @maKhoa", parameters);
        }
        public int GetNumTimKiemGiaoVienHasNotAccount(string maKhoa, string maGV, string hoTen)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhoa", string.IsNullOrEmpty(maKhoa) ? (object)DBNull.Value : maKhoa),
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@hoTen", string.IsNullOrEmpty(hoTen) ? (object)DBNull.Value : hoTen)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumTimKiemGiaoVienHasNotAccount @maKhoa, @maGV, @hoTen", parameters);
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
