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
    internal class HoiDongDanhGiaDAL
    {
        private static HoiDongDanhGiaDAL instance;
        public static HoiDongDanhGiaDAL Instance
        {
            get { if (instance == null) instance = new HoiDongDanhGiaDAL(); return instance; }
            private set { instance = value; }
        }
        private HoiDongDanhGiaDAL() { }
        public List<HoiDongDanhGia> GetListHoiDong()
        {
            List<HoiDongDanhGia> list = new List<HoiDongDanhGia>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM HOI_DONG_DANH_GIA").Rows)
            {
                list.Add(new HoiDongDanhGia(item));
            }
            return list;
        }
        public string GetMaHoiDongByMaGV(string maGV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", maGV)
            };
            return DataProvider.Instance.ExecuteScalar("EXEC USP_GetMaHoiDongByMaGV @maGV", parameters).ToString();
        }
        public HoiDongDanhGia GetHoiDongByMaHoiDong(string maHoiDong)
        {
            HoiDongDanhGia hoiDong = null;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maHoiDong", maHoiDong)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetHoiDongByMaHoiDong @maHoiDong", parameters).Rows)
            {
                hoiDong = new HoiDongDanhGia(item);
            }
            return hoiDong;
        }
        public List<HoiDongDanhGia> TimKiemHoiDong(string tenHoiDong)
        {
            List<HoiDongDanhGia> list = new List<HoiDongDanhGia>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenHoiDong", tenHoiDong)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemHoiDong @tenHoiDong", parameters).Rows)
            {
                list.Add(new HoiDongDanhGia(item));
            }
            return list;
        }
        public void InsertHoiDong(string tenHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenHoiDong", tenHoiDong),
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertHoiDong @TenHoiDong", parameters);
        }
        public void UpdateHoiDong(string maHoiDong, string tenHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong),
                new SqlParameter("@TenHoiDong", tenHoiDong)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateHoiDong @MaHoiDong, @TenHoiDong", parameters);
        }
        public void DeleteHoiDong(string maHoiDong)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteHoiDong @MaHoiDong", parameters);
        }
    }
}
