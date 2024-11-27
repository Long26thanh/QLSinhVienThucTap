using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DAL
{
    internal class ThanhVienHoiDongDAL
    {
        private static ThanhVienHoiDongDAL instance;
        public static ThanhVienHoiDongDAL Instance
        {
            get { if (instance == null) instance = new ThanhVienHoiDongDAL(); return ThanhVienHoiDongDAL.instance; }
            private set { ThanhVienHoiDongDAL.instance = value; }
        }
        private ThanhVienHoiDongDAL() { }
        public List<ThanhVienHoiDong> GetListThanhVienByHoiDong(string maHoiDong)
        {
            List<ThanhVienHoiDong> list = new List<ThanhVienHoiDong>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoiDong", maHoiDong)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListThanhVienByHoiDong @MaHoiDong", parameters).Rows)
            {
                list.Add(new ThanhVienHoiDong(item));
            }
            return list;
        }
    }
}
