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
    internal class DiaDiemBLL
    {
        public static List<DiaDiem> GetListDiaDiemTTByDotTT(string maDotTT)
        {
            return DiaDiemDAL.Instance.GetListDiaDiemTTByDotTT(maDotTT);
        }
        public static List<DiaDiem> GetListDiaDiemTT(int page)
        {
            return DiaDiemDAL.Instance.GetListDiaDiemTT(page);
        }
        public static int GetNumDiaDiem()
        {
            return DiaDiemDAL.Instance.GetNumDiaDiem();
        }
        public static bool InsertDiaDiem(string tenDiaDiem, string diaChi)
        {
            if (string.IsNullOrEmpty(tenDiaDiem) && string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Tên địa điểm và địa chỉ không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DiaDiemDAL.Instance.InsertDiaDiem(tenDiaDiem, diaChi))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Thêm địa điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool DeleteDiaDiem(string maDiaDiem)
        {
            if (DiaDiemDAL.Instance.DeleteDiaDiem(maDiaDiem))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Xóa địa điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
