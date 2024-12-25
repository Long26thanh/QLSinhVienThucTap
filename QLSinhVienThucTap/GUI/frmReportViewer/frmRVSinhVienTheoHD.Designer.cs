namespace QLSinhVienThucTap.GUI
{
    partial class frmRVSinhVienTheoHD
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
            this.rvSinhVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvSinhVien
            // 
            this.rvSinhVien.Location = new System.Drawing.Point(12, 12);
            this.rvSinhVien.Name = "rvSinhVien";
            this.rvSinhVien.ServerReport.BearerToken = null;
            this.rvSinhVien.Size = new System.Drawing.Size(1186, 686);
            this.rvSinhVien.TabIndex = 0;
            // 
            // frmRVSinhVienTheoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 710);
            this.Controls.Add(this.rvSinhVien);
            this.Name = "frmRVSinhVienTheoHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In báo cáo";
            this.Load += new System.EventHandler(this.frmRVSinhVienTheoHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvSinhVien;
    }
}