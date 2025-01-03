using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.BLL
{
    internal class DotThucTapBLL
    {
        public static List<DotThucTap> GetListDotThucTap()
        {
            return DotThucTapDAL.Instance.GetListDotThucTap();
        }
        public static bool InsertDotThucTap(string tenDot, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (string.IsNullOrEmpty(tenDot))
            {
                MessageBox.Show("Chưa nhập tên đợt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DotThucTapDAL.Instance.InsertDotThucTap(tenDot, ngayBatDau, ngayKetThuc))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Thêm đợt thực tập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool DeleteDotThucTap(string maDotTT)
        {
            if (DotThucTapDAL.Instance.DeleteDotThucTap(maDotTT))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Xóa đợt thực tập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
