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
    public partial class frmEditTaiKhoan : Form
    {
        public frmEditTaiKhoan(string username, string maGV, string tenGV, string vaiTro)
        {
            InitializeComponent();
            LoadVaiTro();
            txtUsername.Text = username;
            txtMaGV.Text = maGV;
            txtTenNguoiDung.Text = tenGV;
            cbVaiTro.Text = vaiTro;
        }
        void LoadVaiTro()
        {
            cbVaiTro.Items.Add("Admin");
            cbVaiTro.Items.Add("User");
        }
        private void btnChonGV_Click(object sender, EventArgs e)
        {
            frmChonGiaoVien thucTap = new frmChonGiaoVien(true);
            thucTap.SelectGiaoVien += ThucTap_SelectGiaoVien;
            thucTap.ShowDialog();
        }
        private void ThucTap_SelectGiaoVien(object sender, frmChonGiaoVien.SelectGiaoVienEventArgs e)
        {
            txtMaGV.Text = e.MaGV;
            txtTenNguoiDung.Text = e.TenGV;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string maGV = txtMaGV.Text;
            bool vaiTro = cbVaiTro.Text == "Admin" ? true : false;
            TaiKhoanBLL.UpdateAccount(username, maGV, vaiTro);
            updateAccount?.Invoke(this, new EventArgs());
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn reset mật khẩu? (Mật khẩu mặc định: 12345)", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                TaiKhoanBLL.ResetPassword(txtUsername.Text);
        }
        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }
}
