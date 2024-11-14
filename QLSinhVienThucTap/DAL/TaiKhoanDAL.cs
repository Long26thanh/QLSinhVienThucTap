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
    internal class TaiKhoanDAL
    {
        private static TaiKhoanDAL instance;
        public static TaiKhoanDAL Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAL(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAL() { }
        public bool Login(string username, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            return DataProvider.Instance.ExecuteQuery("EXEC USP_Login @username, @password", parameters).Rows.Count > 0;
        }
        public bool ChangePassword(string username, string password, string newpassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@newpassword", newpassword)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_ChangePassword @username, @password, @newpassword", parameters) > 0;
        }
        public bool UpdateProfile(string userid, string fullname, DateTime birthday, bool gender, string phone, string address, string email, string facultyid)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userid", userid),
                new SqlParameter("@fullname", fullname),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@gender", gender),
                new SqlParameter("@phone", phone),
                new SqlParameter("@address", address),
                new SqlParameter("@email", email),
                new SqlParameter("@facultyid", facultyid)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateProfile @userid, @fullname, @birthday, @gender, @phone, @address, @email, @facultyid", parameters) > 0;
        }
        public TaiKhoan GetAccountByUserName(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetAccountByUsername @username", parameters);
            if (data.Rows.Count > 0)
            {
                return new TaiKhoan(data.Rows[0]);
            }
            return null;
        }
    }
}
