using QLSinhVienThucTap.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class SinhVienBLL
    {
        public static DataTable GetListSinhVienHuongDan(string userid, string phaseid, int page)
        {
            return SinhVienDAL.Instance.GetListSinhVienHuongDan(userid, phaseid, page);
        }
        public static int GetNumStudentInteraction(string userid, string phaseid)
        {
            return SinhVienDAL.Instance.GetNumStudentInteraction(userid, phaseid);
        }
    }
}
