using QLSinhVienThucTap.BLL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.GUI
{
    public partial class ThongTinCaNhan : Form
    {
        private TaiKhoan user;
        public ThongTinCaNhan(TaiKhoan user)
        {
            InitializeComponent();
            this.user = user;
            LoadProfile();
        }
        public void LoadProfile()
        {
            txtUserName.Text = user.TenDangNhap;
            txtFullName.Text = user.TenNguoiDung;
            dtpBirthday.Value = user.NgaySinh;
            if (user.GioiTinh)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            txtPhone.Text = user.SoDienThoai;
            txtAddress.Text = user.DiaChi;
            txtEmail.Text = user.Email;
            cbFaculty.DataSource = KhoaBLL.GetListKhoa();
            cbFaculty.DisplayMember = "TenKhoa";
            cbFaculty.Text = user.Khoa;
            
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string userid = user.MaNguoiDung;
            string fullname = txtFullName.Text;
            DateTime birthday = dtpBirthday.Value;
            bool gender = rbMale.Checked;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string facultyid = ((Khoa)cbFaculty.SelectedItem).MaKhoa;
            TaiKhoanBLL.UpdateProfile(userid, fullname, birthday, gender, phone, address, email, facultyid);
            if (updateProfile != null)
                updateProfile(this, new UpdateProfileEventArgs(TaiKhoanBLL.GetProfile(user.TenDangNhap)));
        }
        private event EventHandler<UpdateProfileEventArgs> updateProfile;
        public event EventHandler<UpdateProfileEventArgs> UpdateProfile
        {
            add { updateProfile += value; }
            remove { updateProfile -= value; }
        }
        public class UpdateProfileEventArgs : EventArgs
        {
            private TaiKhoan user;
            public TaiKhoan User
            {
                get { return user; }
                set { user = value; }
            }
            public UpdateProfileEventArgs(TaiKhoan user)
            {
                this.user = user;
            }
        }
    }
}
