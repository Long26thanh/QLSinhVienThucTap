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
    internal class DiemDAL
    {
        private static DiemDAL instance;
        public static DiemDAL Instance
        {
            get {if (instance == null) instance = new DiemDAL(); return instance;}
            private set { instance = value; }
        }
        private DiemDAL() { }
        public List<Diem> GetListDiem(string maHoiDong, string maDotTT, int page)
        {
            List<Diem> list = new List<Diem>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaDotTT", maDotTT),
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDiemSinhVien @MaHoiDong, @MaDotTT, @page", parameters).Rows)
            {
                list.Add(new Diem(item));
            }
            return list;
        }
        public DataTable GetDiemSinhVien(string maHoiDong, string maDotTT, int page)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaDotTT", maDotTT),
                new SqlParameter("@page", page)
            };
            dt = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDiemSinhVien @MaHoiDong, @MaDotTT, @page", parameters);
            return dt;
        }
        public int GetNumDiem(string maHoiDong, string maDotTT)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@MaDotTT", maDotTT)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumDiem @MaHoiDong, @MaDotTT", parameters);
        }
        public int UpdateDiem(string maDiem, float? diemSo = null)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDiem", maDiem),
                new SqlParameter("@DiemSo", (object)diemSo ?? DBNull.Value)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateDiem @MaDiem, @DiemSo", parameters);
        }
    }
}
