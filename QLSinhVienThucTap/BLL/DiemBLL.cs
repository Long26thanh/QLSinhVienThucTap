using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class DiemBLL
    {
        public static List<Diem> GetListDiem(string maHoiDong, string maDotTT, int page)
        {
            return DiemDAL.Instance.GetListDiem(maHoiDong, maDotTT, page);
        }
        public static DataTable GetDiemSinhVien(string maHoiDong, string maDotTT, int page)
        {
            return DiemDAL.Instance.GetDiemSinhVien(maHoiDong, maDotTT, page);
        }
        public static int GetNumDiem(string maHoiDong, string maDotTT)
        {
            return DiemDAL.Instance.GetNumDiem(maHoiDong, maDotTT);
        }
        public static void UpdateDiem(string maDiem, float? diemSo = null)
        {
            DiemDAL.Instance.UpdateDiem(maDiem, diemSo);
        }
    }
}
