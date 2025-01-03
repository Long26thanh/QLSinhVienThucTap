using Microsoft.Reporting.WinForms;
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
    public partial class frmRVSinhVienTheoHD : Form
    {
        public frmRVSinhVienTheoHD(DataTable dt, string lblHeader)
        {
            InitializeComponent();

            // Đặt DataSource cho ReportViewer
            ReportDataSource rds = new ReportDataSource("SinhVienDataSet", dt);
            rvSinhVien.LocalReport.DataSources.Clear();
            rvSinhVien.LocalReport.DataSources.Add(rds);

            // Tải báo cáo RDLC
            rvSinhVien.LocalReport.ReportPath = Application.StartupPath + @"\RP\rptSinhVienTheoHD.rdlc";

            // Truyền tham số cho ReportViewer
            ReportParameter parameter = new ReportParameter("lblHeader", lblHeader);
            rvSinhVien.LocalReport.SetParameters(new ReportParameter[] { parameter });
            
            rvSinhVien.RefreshReport();
        }

        private void frmRVSinhVienTheoHD_Load(object sender, EventArgs e)
        {
            this.rvSinhVien.RefreshReport();
        }
    }
}
