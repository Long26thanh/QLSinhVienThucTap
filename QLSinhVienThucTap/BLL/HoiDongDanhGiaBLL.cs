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
            return DAL.HoiDongDanhGiaDAL.Instance.GetMaHoiDongByMaGV(maHoiDong);
        }
    }
}
