using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.BLL
{
    internal class TaiKhoanBLL
    {
        internal static bool Login(string username, string password)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!TaiKhoanDAL.Instance.Login(username, BuildSHA256Hash(password)))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        internal static bool ChangePassword(string username, string password, string newpassword)
        {
            if (TaiKhoanDAL.Instance.ChangePassword(username, BuildSHA256Hash(password), BuildSHA256Hash(newpassword)))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public static void InsertProfile(string username, string tenGV, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string email, string maKhoa, bool vaiTro)
        {
            if (string.IsNullOrEmpty(tenGV) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maGV = GiaoVienDAL.Instance.InsertGiaoVien(tenGV, ngaySinh, gioiTinh, soDienThoai, diaChi, email, maKhoa);
            if(TaiKhoanDAL.Instance.InsertProfile(username, maGV, vaiTro))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        internal static bool UpdateProfile(string userid, string fullname, DateTime birthday, bool gender, string phone, string address, string email, string facultyid)
        {
            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(facultyid))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (TaiKhoanDAL.Instance.UpdateProfile(userid, fullname, birthday, gender, phone, address, email, facultyid))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        internal static TaiKhoan GetProfile(string username)
        {
            return TaiKhoanDAL.Instance.GetAccountByUserName(username);
        }
        internal static string BuildSHA256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sBuilder.Append(bytes[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
