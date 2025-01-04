using QLSinhVienThucTap.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private string username;
        public frmDoiMatKhau(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = this.username;
            string password = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string reNewPassword = txtReNewPassword.Text;
            if (password == "" || newPassword == "" || reNewPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword != reNewPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TaiKhoanBLL.ChangePassword(username, password, newPassword))
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
