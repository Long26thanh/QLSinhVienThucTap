using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class ThanhVienHoiDongBLL
    {
        public static List<ThanhVienHoiDong> GetListThanhVienByHoiDong(string maHoiDong)
        {
            return ThanhVienHoiDongDAL.Instance.GetListThanhVienByHoiDong(maHoiDong);
        }
        public static List<ThanhVienHoiDong> GetListThanhVienByMaHoiDong(string maHoiDong, int page)
        {
            return ThanhVienHoiDongDAL.Instance.GetListThanhVienByMaHoiDong(maHoiDong, page);
        }
        public static int GetNumThanhVienByMaHoiDong(string maHoiDong)
        {
            return ThanhVienHoiDongDAL.Instance.GetNumThanhVienByMaHoiDong(maHoiDong);
        }
        public static List<ThanhVienHoiDong> TimKiemThanhVien(string maHoiDong, string hoTen)
        {
            return ThanhVienHoiDongDAL.Instance.TimKiemThanhVien(maHoiDong, hoTen);
        }
        public static List<ThanhVienHoiDong> TimKiemThanhVien(string maHoiDong, string maGV, string hoTen, int page)
        {
            return ThanhVienHoiDongDAL.Instance.TimKiemThanhVien(maHoiDong, maGV, hoTen, page);
        }
        public static int GetNumTimKiemThanhVien(string maHoiDong, string maGV, string hoTen)
        {
            return ThanhVienHoiDongDAL.Instance.GetNumTimKiemThanhVien(maHoiDong, maGV, hoTen);
        }
        public static void InsertThanhVienHoiDong(string maHoiDong, string maGV)
        {
            ThanhVienHoiDongDAL.Instance.InsertThanhVienHoiDong(maHoiDong, maGV);
        }
        public static void DeleteThanhVienHoiDong(string maHoiDong, string maGV)
        {
            ThanhVienHoiDongDAL.Instance.DeleteThanhVienHoiDong(maHoiDong, maGV);
        }
    }
}
