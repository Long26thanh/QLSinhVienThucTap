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
        //public List<HoiDongDanhGia> GetListHoiDongDanhGia(string maHoiDong)
        //{
        //    List<HoiDongDanhGia> list = new List<HoiDongDanhGia>();
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@maHoiDong", maHoiDong)
        //    };
        //    foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetMaHoiDongByMaGV @maHoiDong", parameters).Rows)
        //    {
        //        list.Add(new HoiDongDanhGia(item));
        //    }
        //    return list;
        //}
        public string GetMaHoiDongByMaGV(string maGV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGV", maGV)
            };
            return DataProvider.Instance.ExecuteScalar("EXEC USP_GetMaHoiDongByMaGV @maGV", parameters).ToString();
        }
    }
}
