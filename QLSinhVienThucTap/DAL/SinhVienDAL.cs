using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DAL
{
    internal class SinhVienDAL
    {
        private static SinhVienDAL instance;
        public static SinhVienDAL Instance
        {
            get { if (instance == null) instance = new SinhVienDAL(); return instance; }
            private set { instance = value; }
        }
        private SinhVienDAL() { }
        public List<SinhVien> GetListSinhVien()
        {
            List<SinhVien> list = new List<SinhVien>();
            string query = "SELECT * FROM SinhVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhVien = new SinhVien(item);
                list.Add(sinhVien);
            }
            return list;
        }
        public DataTable GetListSinhVienHuongDan(string userid, string phaseid, int page)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userid", userid),
                new SqlParameter("@phaseid", phaseid),
                new SqlParameter("@page", page)
            };
            return DataProvider.Instance.ExecuteQuery("USP_GetListStudentInteractionByDateAndPage @userid, @phaseid, @page", parameters);
        }
        public int GetNumStudentInteraction(string userid, string phaseid)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userid", userid),
                new SqlParameter("@phaseid", phaseid)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumStudentInteraction @userid, @phaseid", parameters);
        }
    }
}
