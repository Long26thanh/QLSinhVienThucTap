namespace QLSinhVienThucTap.GUI
{
    partial class frmChonGVHD
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.dgvListGiaoVien = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviousGV = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 567);
            this.panel1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(179, 532);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.lblHoTen);
            this.panel2.Controls.Add(this.lblMa);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtMaGV);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 36);
            this.panel2.TabIndex = 26;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(306, 8);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(94, 20);
            this.txtHoTen.TabIndex = 35;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(259, 12);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(42, 13);
            this.lblHoTen.TabIndex = 34;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(113, 12);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(43, 13);
            this.lblMa.TabIndex = 33;
            this.lblMa.Text = "Mã GV:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(31, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(160, 8);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(94, 20);
            this.txtMaGV.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbKhoa);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 36);
            this.panel3.TabIndex = 14;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(110, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(209, 29);
            this.cbKhoa.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtPage);
            this.panel17.Controls.Add(this.dgvListGiaoVien);
            this.panel17.Controls.Add(this.btnNext);
            this.panel17.Controls.Add(this.btnPreviousGV);
            this.panel17.Controls.Add(this.btnLast);
            this.panel17.Controls.Add(this.btnFirst);
            this.panel17.Location = new System.Drawing.Point(3, 133);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(431, 388);
            this.panel17.TabIndex = 25;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(164, 363);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 20);
            this.txtPage.TabIndex = 13;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvListGiaoVien
            // 
            this.dgvListGiaoVien.AllowUserToAddRows = false;
            this.dgvListGiaoVien.AllowUserToDeleteRows = false;
            this.dgvListGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGiaoVien.Location = new System.Drawing.Point(3, 3);
            this.dgvListGiaoVien.MultiSelect = false;
            this.dgvListGiaoVien.Name = "dgvListGiaoVien";
            this.dgvListGiaoVien.ReadOnly = true;
            this.dgvListGiaoVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListGiaoVien.Size = new System.Drawing.Size(424, 353);
            this.dgvListGiaoVien.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(270, 361);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPreviousGV
            // 
            this.btnPreviousGV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPreviousGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousGV.Location = new System.Drawing.Point(83, 361);
            this.btnPreviousGV.Name = "btnPreviousGV";
            this.btnPreviousGV.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousGV.TabIndex = 10;
            this.btnPreviousGV.Text = "Trước";
            this.btnPreviousGV.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Location = new System.Drawing.Point(352, 361);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Location = new System.Drawing.Point(3, 361);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // frmChonGVHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 567);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonGVHD";
            this.Text = "frmChonGVHD";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.DataGridView dgvListGiaoVien;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviousGV;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
    }
}