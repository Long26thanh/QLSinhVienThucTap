using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class ThucTapBLL
    {
        public static List<ThucTap> GetListThucTap(string maLop, string maDotTT, int page)
        {
            return ThucTapDAL.Instance.GetListThucTap(maLop, maDotTT, page);
        }
        public static int GetNumThucTap(string maLop, string maDotTT)
        {
            return ThucTapDAL.Instance.GetNumThucTap(maLop, maDotTT);
        }
        public static List<ThucTap> TimKiemThucTap(string maLop, string maDotTT, string hoTen, string maSV, int page)
        {
            return ThucTapDAL.Instance.TimKiemThucTap(maLop, maDotTT, hoTen, maSV, page);
        }
        public static int GetNumTimKiemThucTap(string maLop, string maDotTT, string hoTen, string maSV)
        {
            return ThucTapDAL.Instance.GetNumTimKiemThucTap(maLop, maDotTT, hoTen, maSV);
        }
    }
}
