namespace QLSinhVienThucTap.GUI.frmReportViewer
{
    partial class frmRV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rvDiaDiemTT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvDiaDiemTT
            // 
            this.rvDiaDiemTT.LocalReport.ReportEmbeddedResource = "QLSinhVienThucTap.RP.rptDiaDiemTT.rdlc";
            this.rvDiaDiemTT.Location = new System.Drawing.Point(12, 12);
            this.rvDiaDiemTT.Name = "rvDiaDiemTT";
            this.rvDiaDiemTT.ServerReport.BearerToken = null;
            this.rvDiaDiemTT.Size = new System.Drawing.Size(1186, 686);
            this.rvDiaDiemTT.TabIndex = 2;
            // 
            // frmRVDiaDiemTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 710);
            this.Controls.Add(this.rvDiaDiemTT);
            this.Name = "frmRVDiaDiemTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRVDiaDiemTT";
            this.Load += new System.EventHandler(this.frmRVDiaDiemTT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvDiaDiemTT;
    }
}