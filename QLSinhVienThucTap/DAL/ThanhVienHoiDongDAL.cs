using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.DAL
{
    internal class ThanhVienHoiDongDAL
    {
        private static ThanhVienHoiDongDAL instance;
        public static ThanhVienHoiDongDAL Instance
        {
            get { if (instance == null) instance = new ThanhVienHoiDongDAL(); return ThanhVienHoiDongDAL.instance; }
            private set { ThanhVienHoiDongDAL.instance = value; }
        }
        private ThanhVienHoiDongDAL() { }
        public List<ThanhVienHoiDong> GetListThanhVienByHoiDong(string maHoiDong)
        {
            List<ThanhVienHoiDong> list = new List<ThanhVienHoiDong>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListThanhVienByHoiDong @MaHoiDong", parameters).Rows)
            {
                list.Add(new ThanhVienHoiDong(item));
            }
            return list;
        }
        public List<ThanhVienHoiDong> GetListThanhVienByMaHoiDong(string maHoiDong, int page)
        {
            List<ThanhVienHoiDong> list = new List<ThanhVienHoiDong>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListThanhVienByMaHoiDong @MaHoiDong, @page", parameters).Rows)
            {
                list.Add(new ThanhVienHoiDong(item));
            }
            return list;
        }
        public int GetNumThanhVienByMaHoiDong(string maHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong)
            };
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumThanhVienByMaHoiDong @MaHoiDong", parameters));
        }
        public List<ThanhVienHoiDong> TimKiemThanhVien(string maHoiDong, string hoTen)
        {
            List<ThanhVienHoiDong> list = new List<ThanhVienHoiDong>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@HoTen", hoTen)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemThanhVien @MaHoiDong, @HoTen", parameters).Rows)
            {
                list.Add(new ThanhVienHoiDong(item));
            }
            return list;
        }
        public List<ThanhVienHoiDong> TimKiemThanhVien(string maHoiDong, string maGV, string hoTen, int page)
        {
            List<ThanhVienHoiDong> list = new List<ThanhVienHoiDong>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemThanhVien2 @MaHoiDong, @MaGV, @HoTen, @page", parameters).Rows)
            {
                list.Add(new ThanhVienHoiDong(item));
            }
            return list;
        }
        public int GetNumTimKiemThanhVien(string maHoiDong, string maGV, string hoTen)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@HoTen", hoTen),
            };
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumTimKiemThanhVien2 @MaHoiDong, @MaGV, @HoTen", parameters));
        }
        public void InsertThanhVienHoiDong(string maHoiDong, string maGV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaGV", maGV)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertThanhVien @MaHoiDong, @MaGV", parameters);
        }
        public void DeleteThanhVienHoiDong(string maHoiDong, string maGV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaGV", maGV)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteThanhVien @MaHoiDong, @MaGV", parameters);
        }
    }
}
