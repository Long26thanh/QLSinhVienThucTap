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
    internal class ThucTapDAL
    {
        private static ThucTapDAL instance;
        public static ThucTapDAL Instance
        {
            get { if (instance == null) instance = new ThucTapDAL(); return instance; }
            private set { instance = value; }
        }
        private ThucTapDAL() { }
        public List<ThucTap> GetListThucTap(string maLop, string maDotTT, int page)
        {
            List<ThucTap> list = new List<ThucTap>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@maDotTT", maDotTT),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListSinhVienThucTap @maLop, @maDotTT, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                ThucTap thucTap = new ThucTap(item);
                list.Add(thucTap);
            }
            return list;
        }
        public int GetNumThucTap(string maLop, string maDotTT)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@maDotTT", maDotTT)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumListSinhVienThucTap @maLop, @maDotTT", parameters);
        }
        public List<ThucTap> TimKiemThucTap(string maLop, string maDotTT, string hoTen, string maSV, int page)
        {
            List<ThucTap> list = new List<ThucTap>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@maDotTT", maDotTT),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@maSV", maSV),
                new SqlParameter("@page", page)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemSinhVienThucTap @maLop, @maDotTT, @hoTen, @maSV, @page", parameters);
            foreach (DataRow item in data.Rows)
            {
                ThucTap thucTap = new ThucTap(item);
                list.Add(thucTap);
            }
            return list;
        }
        public DataTable GetSinhVienThucTapByMaTT(string maTT)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTT", maTT)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetSinhVienThucTapByMaTT @maTT", parameters);
            return data;
        }
        public int GetNumTimKiemThucTap(string maLop, string maDotTT, string hoTen, string maSV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@maDotTT", maDotTT),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@maSV", maSV)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumTimKiemSinhVienThucTap @maLop, @maDotTT, @hoTen, @maSV", parameters);
        }
        public void InsertThucTap(string maSV, string maGV, string maDeTai, string maDiaDiem, string maDotTT, string maHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maSV", maSV),
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@maDeTai", maDeTai),
                new SqlParameter("@maDiaDiem", maDiaDiem),
                new SqlParameter("@maDotTT", maDotTT),
                new SqlParameter("@maHoiDong", maHoiDong)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertSinhVienThucTap @maSV, @maGV, @maDeTai, @maDiaDiem, @maDotTT, @maHoiDong", parameters);
        }
        public void UpdateThucTap(string maTT, string maGV, string maDeTai, string maDiaDiem, string maHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTT", maTT),
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@maDeTai", maDeTai),
                new SqlParameter("@maDiaDiem", maDiaDiem),
                new SqlParameter("@maHoiDong", maHoiDong)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateSinhVienThucTap @maTT, @maGV, @maDeTai, @maDiaDiem, @maHoiDong", parameters);
        }
        public void DeleteThucTap(string maTT)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTT", maTT)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteSinhVienThucTap @maTT", parameters);
        }
    }
}
