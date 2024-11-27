using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class LopBLL
    {
        public static List<Lop> GetListLop()
        {
            return LopDAL.Instance.GetListLop();
        }
        public static List<Lop> GetListLopByMaKhoa(string makhoa)
        {
            return LopDAL.Instance.GetListLopByMaKhoa(makhoa);
        }
        public static List<Lop> TimKiemLop(string tenLop)
        {
            return LopDAL.Instance.TimKiemLop(tenLop);
        }
        public static void InsertLop(string tenLop, string maKhoa)
        {
            LopDAL.Instance.InsertLop(tenLop, maKhoa);
        }
        public static void UpdateLop(string maLop, string tenLop)
        {
            LopDAL.Instance.UpdateLop(maLop, tenLop);
        }
        public static void DeleteLop(string maLop)
        {
            LopDAL.Instance.DeleteLop(maLop);
        }
    }
}
