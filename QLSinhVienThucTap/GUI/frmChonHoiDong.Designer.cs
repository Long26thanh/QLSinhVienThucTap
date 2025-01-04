namespace QLSinhVienThucTap.GUI
{
    partial class frmChonHoiDong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenHoiDong = new System.Windows.Forms.TextBox();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.btnSearchHD = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dgvListHoiDong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoiDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 645);
            this.panel1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelect.Location = new System.Drawing.Point(394, 589);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 28);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenHoiDong);
            this.panel2.Controls.Add(this.lblHoTenSV);
            this.panel2.Controls.Add(this.btnSearchHD);
            this.panel2.Location = new System.Drawing.Point(4, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 44);
            this.panel2.TabIndex = 26;
            // 
            // txtTenHoiDong
            // 
            this.txtTenHoiDong.Location = new System.Drawing.Point(403, 13);
            this.txtTenHoiDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHoiDong.Name = "txtTenHoiDong";
            this.txtTenHoiDong.Size = new System.Drawing.Size(236, 22);
            this.txtTenHoiDong.TabIndex = 35;
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(306, 16);
            this.lblHoTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(89, 16);
            this.lblHoTenSV.TabIndex = 34;
            this.lblHoTenSV.Text = "Tên hội đồng:";
            // 
            // btnSearchHD
            // 
            this.btnSearchHD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchHD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchHD.Location = new System.Drawing.Point(198, 10);
            this.btnSearchHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchHD.Name = "btnSearchHD";
            this.btnSearchHD.Size = new System.Drawing.Size(100, 28);
            this.btnSearchHD.TabIndex = 31;
            this.btnSearchHD.Text = "Tìm";
            this.btnSearchHD.UseVisualStyleBackColor = false;
            this.btnSearchHD.Click += new System.EventHandler(this.btnSearchHD_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dgvListHoiDong);
            this.panel17.Location = new System.Drawing.Point(4, 95);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(889, 446);
            this.panel17.TabIndex = 25;
            // 
            // dgvListHoiDong
            // 
            this.dgvListHoiDong.AllowUserToAddRows = false;
            this.dgvListHoiDong.AllowUserToDeleteRows = false;
            this.dgvListHoiDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListHoiDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHoiDong.Location = new System.Drawing.Point(4, 4);
            this.dgvListHoiDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListHoiDong.MultiSelect = false;
            this.dgvListHoiDong.Name = "dgvListHoiDong";
            this.dgvListHoiDong.ReadOnly = true;
            this.dgvListHoiDong.RowHeadersWidth = 51;
            this.dgvListHoiDong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListHoiDong.Size = new System.Drawing.Size(881, 433);
            this.dgvListHoiDong.TabIndex = 0;
            // 
            // frmChonHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 645);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChonHoiDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn hội đồng đánh giá";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoiDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenHoiDong;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Button btnSearchHD;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DataGridView dgvListHoiDong;
    }
}