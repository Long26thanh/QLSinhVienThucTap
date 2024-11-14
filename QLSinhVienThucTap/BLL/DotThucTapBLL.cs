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
    }
}
