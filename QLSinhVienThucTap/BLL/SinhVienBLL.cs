using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static List<SinhVien> GetListSinhVienByLop(string maKhoa, int page)
        {
            return SinhVienDAL.Instance.GetListSinhVienByLop(maKhoa, page);
        }
        public static int GetNumSinhVienByLop(string maKhoa)
        {
            return SinhVienDAL.Instance.GetNumSinhVienByLop(maKhoa);
        }
        public static List<SinhVien> TimKiemSV(string maSV, string hoTen, string maKhoa, int page)
        {
            return SinhVienDAL.Instance.TimKiemSV(maSV, hoTen, maKhoa, page);
        }
        public static int GetNumByTimKiemSV(string maSV, string hoTen, string maKhoa)
        {
            return SinhVienDAL.Instance.GetNumByTimKiemSV(maSV, hoTen, maKhoa);
        }
        public static bool InsertSinhVien(string hoTen, DateTime ngaySinh, bool gioiTinh, string sdt, string diaChi, string email, string maLop)
        {
            if(string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            SinhVienDAL.Instance.InsertSinhVien(hoTen, ngaySinh, gioiTinh, sdt, diaChi, email, maLop);
            return true;
        }
        public static void UpdateSinhVien(string MaSV, string TenSV, DateTime NgaySinh, bool GioiTinh, string SoDienThoai, string DiaChi, string Email)
        {
            if (string.IsNullOrEmpty(TenSV) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(SoDienThoai) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validator.IsValidPhoneNumber(SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validator.IsValidEmail(Email))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SinhVienDAL.Instance.UpdateSinhVien(MaSV, TenSV, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email);
        }
        public static void DeleteSinhVien(string MaSV)
        {
            SinhVienDAL.Instance.DeleteSinhVien(MaSV);
        }
    }
}
