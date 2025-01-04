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
    internal class DeTaiBLL
    {
        public static List<DeTai> GetListDeTai(int page)
        {
            return DeTaiDAL.Instance.GetListDeTai(page);
        }
        public static int GetNumDeTai()
        {
            return DeTaiDAL.Instance.GetNumDeTai();
        }
        public static bool InsertDeTai(string tenDeTai, string moTa)
        {
            if (string.IsNullOrEmpty(tenDeTai))
            {
                MessageBox.Show("Ten đề tài không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DeTaiDAL.Instance.InsertDeTai(tenDeTai, moTa))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Thêm đề tài thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool DeleteDeTai(string maDeTai)
        {
            if (DeTaiDAL.Instance.DeleteDeTai(maDeTai))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Xóa đề tài thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
