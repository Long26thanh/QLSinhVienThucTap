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
        public bool ResetPassword(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_ResetPassword @username", parameters) > 0;
        }
        public List<TaiKhoan> GetListAccount(int page)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListAccount @page", parameters).Rows)
            {
                list.Add(new TaiKhoan(item));
            }
            return list;
        }
        public int GetNumAccount()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM TAI_KHOAN");
        }
        public int CheckAccountExist(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_CheckUsernameExist @username", parameters);
        }
        public List<TaiKhoan> TimKiemTaiKhoan(string username, string maGV, string hoten, int page)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", string.IsNullOrEmpty(username) ? (object)DBNull.Value : username),
                new SqlParameter("@maGV", string.IsNullOrEmpty(maGV) ? (object)DBNull.Value : maGV),
                new SqlParameter("@hoten", string.IsNullOrEmpty(hoten) ? (object)DBNull.Value : hoten),
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemAccount @username, @maGV, @hoten, @page", parameters).Rows)
            {
                list.Add(new TaiKhoan(item));
            }
            return list;
        }
        public bool InsertAccount(string username, string password, string maGV, bool vaitro)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@vaitro", vaitro)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertAccount @username, @password, @maGV, @vaitro", parameters) > 0;
        }
        public bool InsertProfile(string username, string userid, bool vaiTro)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@userid", userid),
                new SqlParameter("@vaiTro", vaiTro)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertProfile @username, @userid, @vaiTro", parameters) > 0;
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
        public bool UpdateAccount(string username, string maGV, bool vaitro)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@vaitro", vaitro)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateTaiKhoan @username, @maGV, @vaitro", parameters) > 0;
        }
        public bool DeleteAccount(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteAccount @username", parameters) > 0;
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
