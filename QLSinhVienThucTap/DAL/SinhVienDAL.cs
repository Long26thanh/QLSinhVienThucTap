﻿using QLSinhVienThucTap.DTO;
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
        public List<SinhVien> GetListSinhVienByLop(string maKhoa, int page)
        {
            List<SinhVien> list = new List<SinhVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maKhoa),
                new SqlParameter("@page", page)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_GetListSinhVienByLop @MaLop, @page", parameters).Rows)
            {
                list.Add(new SinhVien(item));
            }
            return list;
        }
        public int GetNumSinhVienByLop(string maKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maKhoa)
            };
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumSinhVienByLop @MaLop", parameters);
        }
        public List<SinhVien> TimKiemSV(string maSV, string hoTen)
        {
            List<SinhVien> list = new List<SinhVien>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSV", string.IsNullOrEmpty(maSV) ? (object)DBNull.Value : maSV),
                new SqlParameter("@HoTen", string.IsNullOrEmpty(hoTen) ? (object)DBNull.Value : hoTen)
            };
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("EXEC USP_TimKiemSinhVien @MaSV, @HoTen", parameters).Rows)
            {
                list.Add(new SinhVien(item));
            }
            return list;
        }
        public void InsertSinhVien(string hoTen, DateTime ngaySinh, bool gioiTinh, string sdt, string diaChi, string email, string maLop)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HoTen", (object)hoTen ?? DBNull.Value),
                new SqlParameter("@NgaySinh", (object)ngaySinh ?? DBNull.Value),
                new SqlParameter("@GioiTinh", (object)gioiTinh ?? DBNull.Value),
                new SqlParameter("@SDT", (object)sdt ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object) diaChi ?? DBNull.Value),
                new SqlParameter("@Email", (object)email ?? DBNull.Value),
                new SqlParameter("@MaLop", (object)maLop)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertSinhVien @HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi, @Email, @MaLop", parameters);
        }
        public void UpdateSinhVien(string MaSV, string TenSV, DateTime NgaySinh, bool GioiTinh, string SoDienThoai, string DiaChi, string Email)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSV", MaSV),
                new SqlParameter("@HoTen", TenSV),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@SDT", SoDienThoai),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateSinhVien @MaSV, @HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi, @Email", parameters);
        }
        public void DeleteSinhVien(string maSV)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSV", maSV)
            };
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteSinhVien @MaSV", parameters);
        }
    }
}
