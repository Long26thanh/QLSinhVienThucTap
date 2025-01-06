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
    internal class GiaoVienBLL
    {
        public static List<GiaoVien> GetListGiaoVien()
        {
            return GiaoVienDAL.Instance.GetListGiaoVien();
        }
        public static List<GiaoVien> GetListGiaoVienHuongDan(string maKhoa, int page)
        {
            return GiaoVienDAL.Instance.GetListGiaoVienHuongDan(maKhoa, page);
        }
        public static List<GiaoVien> GetListGiaoVienByKhoa(string maKhoa, int page, string maGV)
        {
            return GiaoVienDAL.Instance.GetListGiaoVienByKhoa(maKhoa, page, maGV);
        }
        public static List<GiaoVien> GetListGiaoVienByMaKhoa(string maKhoa, string maGV, string maHoiDong, int page)
        {
            return GiaoVienDAL.Instance.GetListGiaoVienByMaKhoa(maKhoa, maGV, maHoiDong, page);
        }
        public static List<GiaoVien> GetListGiaoVienHasNotAccount(string maKhoa, int page)
        {
            return GiaoVienDAL.Instance.GetListGiaoVienHasNotAccount(maKhoa, page);
        }
        public static List<GiaoVien> TimKiemGV(string maGV, string tenGV, string maKhoa, string userid, int page)
        {
            return GiaoVienDAL.Instance.TimKiemGV(maGV, tenGV, maKhoa, userid, page);
        }
        public static List<GiaoVien> TimKiemGV(string maGV, string tenGV, string maKhoa, string maHoiDong, string userid, int page)
        {
            return GiaoVienDAL.Instance.TimKiemGV(maGV, tenGV, maKhoa, maHoiDong, userid, page);
        }
        public static List<GiaoVien> TimKiemGiaoVien(string maGV, string tenGV, string maKhoa, int page)
        {
            return GiaoVienDAL.Instance.TimKiemGiaoVien(maGV, tenGV, maKhoa, page);
        }
        public static List<GiaoVien> TimKiemGiaoVienHasNotAccount(string maKhoa, string maGV, string hoTen, int page)
        {
            return GiaoVienDAL.Instance.TimKiemGiaoVienHasNotAccount(maKhoa, maGV, hoTen, page);
        }
        public static int GetNumTimKiemGiaoVien(string maGV, string tenGV, string maKhoa, string userid)
        {
            return GiaoVienDAL.Instance.GetNumTimKiemGiaoVien(maGV, tenGV, maKhoa, userid);
        }
        public static int GetNumTimKiemGiaoVien(string maGV, string tenGV, string maKhoa, string maHoiDong, string userid)
        {
            return GiaoVienDAL.Instance.GetNumTimKiemGiaoVien(maGV, tenGV, maKhoa, maHoiDong, userid);
        }
        public static int GetNumGiaoVienByKhoa(string maKhoa, string maGV)
        {
            return GiaoVienDAL.Instance.GetNumGiaoVienByKhoa(maKhoa, maGV);
        }
        public static int GetNumGiaoVienByMaKhoa(string maKhoa, string maGV, string maHoiDong)
        {
            return GiaoVienDAL.Instance.GetNumGiaoVienByMaKhoa(maKhoa, maGV, maHoiDong);
        }
        public static int GetNumGiaoVienHuongDan(string maKhoa)
        {
            return GiaoVienDAL.Instance.GetNumGiaoVienHuongDan(maKhoa);
        }
        public static int GetNumTimKiemGiaoVienHuongDan(string maGV, string hoTen, string maKhoa)
        {
            return GiaoVienDAL.Instance.GetNumTimKiemGiaoVienHuongDan(maGV, hoTen, maKhoa);
        }
        public static int GetNumGiaoVienHasNotAccount(string maKhoa)
        {
            return GiaoVienDAL.Instance.GetNumGiaoVienHasNotAccount(maKhoa);
        }
        public static int GetNumTimKiemGiaoVienHasNotAccount(string maKhoa, string maGV, string hoTen)
        {
            return GiaoVienDAL.Instance.GetNumTimKiemGiaoVienHasNotAccount(maKhoa, maGV, hoTen);
        }
        public static bool InsertGiaoVien(string tenGV, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string email, string maKhoa)
        {
            if (string.IsNullOrEmpty(tenGV) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidPhoneNumber(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            GiaoVienDAL.Instance.InsertGiaoVien(tenGV, ngaySinh, gioiTinh, soDienThoai, diaChi, email, maKhoa);
            return true;
        }
        public static void UpdateGiaoVien(string maGV, string tenGV, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string email, string maKhoa)
        {
            if (string.IsNullOrEmpty(tenGV) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validator.IsValidPhoneNumber(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaiKhoanDAL.Instance.UpdateProfile(maGV, tenGV, ngaySinh, gioiTinh, soDienThoai, diaChi, email, maKhoa);
        }
        public static void DeleteGiaoVien(string maGV)
        {
            GiaoVienDAL.Instance.DeleteGiaoVien(maGV);
        }
    }
}
