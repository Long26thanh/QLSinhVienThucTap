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

namespace QLSinhVienThucTap.GUI.frmReportViewer
{
    public partial class frmRVSinhVienTheoDotTT : Form
    {
        public frmRVSinhVienTheoDotTT(DataTable dt, string lblHeader)
        {
            InitializeComponent();

            // Đặt DataSource cho ReportViewer
            ReportDataSource rds = new ReportDataSource("SinhVienTTDataSet", dt);
            rvSinhVien.LocalReport.DataSources.Clear();
            rvSinhVien.LocalReport.DataSources.Add(rds);

            // Tải báo cáo RDLC
            rvSinhVien.LocalReport.ReportPath = Application.StartupPath + @"\RP\rptSinhVienTheoDotTT.rdlc";

            // Truyền tham số cho ReportViewer
            ReportParameter parameter = new ReportParameter("lblHeader", lblHeader);
            rvSinhVien.LocalReport.SetParameters(new ReportParameter[] { parameter });

            rvSinhVien.RefreshReport();
        }

        private void frmRVSinhVienTheoDotTT_Load(object sender, EventArgs e)
        {
            this.rvSinhVien.RefreshReport();
        }
    }
}
