using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DAL
{
    internal class LopDAL
    {
        private static LopDAL instance;
        public static LopDAL Instance
        {
            get { if (instance == null) instance = new LopDAL(); return LopDAL.instance; }
            private set { LopDAL.instance = value; }
        }
        private LopDAL() { }
        public List<Lop> GetListLop()
        {
            List<Lop> list = new List<Lop>();
            string query = "SELECT * FROM Lop";
            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Lop lop = new Lop(item);
                list.Add(lop);
            }
            return list;
        }
        //public DTO.Lop GetLopByMaLop(string maLop)
        //{
        //    string query = "SELECT * FROM Lop WHERE MaLop = N'" + maLop + "'";
        //    System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (System.Data.DataRow item in data.Rows)
        //    {
        //        return new DTO.Lop(item);
        //    }
        //    return null;
        //}
        //public bool InsertLop(string maLop, string tenLop, string khoa)
        //{
        //    string query = string.Format("INSERT INTO Lop (MaLop, TenLop, Khoa) VALUES (N'{0}', N'{1}', N'{2}')", maLop, tenLop, khoa);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        //public bool UpdateLop(string maLop, string tenLop, string khoa)
        //{
        //    string query = string.Format("UPDATE Lop SET TenLop = N'{1}', Khoa = N'{2}' WHERE MaLop = N'{0}'", maLop, tenLop, khoa);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        //public bool DeleteLop(string maLop)
        //{
        //    string query = string.Format("DELETE Lop WHERE MaLop = N'{0}'", maLop);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
    }
}
