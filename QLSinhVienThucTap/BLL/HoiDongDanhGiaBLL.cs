using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class HoiDongDanhGiaBLL
    {
        public static string GetMaHoiDongByMaGV(string maHoiDong)
        {
            return HoiDongDanhGiaDAL.Instance.GetMaHoiDongByMaGV(maHoiDong);
        }
        public static List<HoiDongDanhGia> GetListHoiDong()
        {
            return HoiDongDanhGiaDAL.Instance.GetListHoiDong();
        }
        public static List<HoiDongDanhGia> TimKiemHoiDong(string tenHoiDong)
        {
            return HoiDongDanhGiaDAL.Instance.TimKiemHoiDong(tenHoiDong);
        }
        public static void InsertHoiDong(string tenHoiDong)
        {
            HoiDongDanhGiaDAL.Instance.InsertHoiDong(tenHoiDong);
        }
        public static void UpdateHoiDong(string maHoiDong, string tenHoiDong)
        {
            HoiDongDanhGiaDAL.Instance.UpdateHoiDong(maHoiDong, tenHoiDong);
        }
        public static void DeleteHoiDong(string maHoiDong)
        {
            HoiDongDanhGiaDAL.Instance.DeleteHoiDong(maHoiDong);
        }
    }
}
