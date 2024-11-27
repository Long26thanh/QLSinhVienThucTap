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
    }
}
