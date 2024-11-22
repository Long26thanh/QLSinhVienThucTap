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
        private static DiemBLL instance;
        public static DiemBLL Instance
        {
            get { if (instance == null) instance = new DiemBLL(); return instance; }
            private set { instance = value; }
        }
        private DiemBLL() { }
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
