using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class KhoaBLL
    {
        internal static List<Khoa> GetListKhoa()
        {
            return KhoaDAL.Instance.GetListKhoa();
        }
        internal static List<Khoa> TimKiemKhoa(string tenKhoa)
        {
            return KhoaDAL.Instance.TimKiemKhoa(tenKhoa);
        }
        internal static string InsertKhoa(string tenKhoa)
        {
            return KhoaDAL.Instance.InsertKhoa(tenKhoa);
        }
        internal static void UpdateKhoa(string maKhoa, string tenKhoa)
        {
            KhoaDAL.Instance.UpdateKhoa(maKhoa, tenKhoa);
        }
        internal static void DeleteKhoa(string maKhoa)
        {
            KhoaDAL.Instance.DeleteKhoa(maKhoa);
        }
    }
}
