using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DAL
{
    internal class KhoaDAL
    {
        private static KhoaDAL instance;
        public static KhoaDAL Instance
        {
            get { if (instance == null) instance = new KhoaDAL(); return instance; }
            private set { instance = value; }
        }
        private KhoaDAL() { }
        public List<Khoa> GetListKhoa()
        {
            List<Khoa> list = new List<DTO.Khoa>();
            string query = "SELECT * FROM Khoa";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Khoa khoa = new Khoa(item);
                list.Add(khoa);
            }
            return list;
        }
    }
}
