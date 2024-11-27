using QLSinhVienThucTap.BLL;
using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using QLSinhVienThucTap.GUI;
using System;
using System.Windows.Forms;

namespace QLSinhVienThucTap
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (TaiKhoanBLL.Login(username, password))
            {
                TaiKhoan loginAccount = TaiKhoanBLL.GetProfile(username);
                frmHome home = new frmHome(loginAccount);
                this.Hide();
                home.ShowDialog();
                this.Show(); 
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
