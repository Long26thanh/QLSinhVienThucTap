using Microsoft.Reporting.WinForms;
using QLSinhVienThucTap.DTO;
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
    public partial class frmRV : Form
    {
        public frmRV(DataTable dt, string dataSet, string fileName, string lblHeader)
        {
            InitializeComponent();

            // Đặt DataSource cho ReportViewer
            ReportDataSource rds = new ReportDataSource(dataSet, dt);
            rvDiaDiemTT.LocalReport.DataSources.Clear();
            rvDiaDiemTT.LocalReport.DataSources.Add(rds);

            // Tải báo cáo RDLC
            rvDiaDiemTT.LocalReport.ReportPath = Application.StartupPath + @"\RP\" + fileName + ".rdlc";

            // Truyền tham số cho ReportViewer
            ReportParameter parameter = new ReportParameter("lblHeader", lblHeader);
            rvDiaDiemTT.LocalReport.SetParameters(new ReportParameter[] { parameter });

            rvDiaDiemTT.RefreshReport();
        }

        private void frmRVDiaDiemTT_Load(object sender, EventArgs e)
        {
            this.rvDiaDiemTT.RefreshReport();
        }
    }
}
