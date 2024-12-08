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
    public partial class frmThucTap : Form
    {
        private string maDotTT;
        public string MaDotTT
        {
            get { return maDotTT; }
            set { maDotTT = value; }
        }
        public frmThucTap(string maDotTT)
        {
            InitializeComponent();
            this.MaDotTT = maDotTT;
        }
        #region Event
        private void btnChonSinhVien_Click(object sender, EventArgs e)
        {
            frmChonSinhVien frm = new frmChonSinhVien(MaDotTT);
            frm.ShowDialog();
        }
        #endregion
    }
}
