namespace QLSinhVienThucTap.GUI
{
    partial class frmChonSinhVien
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.dgvListSinhVien = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviousGV = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbKhoaSV = new System.Windows.Forms.ComboBox();
            this.cbLopSV = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtPage);
            this.panel17.Controls.Add(this.dgvListSinhVien);
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
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // dgvListSinhVien
            // 
            this.dgvListSinhVien.AllowUserToAddRows = false;
            this.dgvListSinhVien.AllowUserToDeleteRows = false;
            this.dgvListSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSinhVien.Location = new System.Drawing.Point(3, 3);
            this.dgvListSinhVien.MultiSelect = false;
            this.dgvListSinhVien.Name = "dgvListSinhVien";
            this.dgvListSinhVien.ReadOnly = true;
            this.dgvListSinhVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListSinhVien.Size = new System.Drawing.Size(424, 353);
            this.dgvListSinhVien.TabIndex = 0;
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
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnPreviousGV.Click += new System.EventHandler(this.btnPreviousGV_Click);
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
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
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
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbKhoaSV);
            this.panel3.Controls.Add(this.cbLopSV);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 36);
            this.panel3.TabIndex = 14;
            // 
            // cbKhoaSV
            // 
            this.cbKhoaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaSV.FormattingEnabled = true;
            this.cbKhoaSV.Location = new System.Drawing.Point(44, 4);
            this.cbKhoaSV.Name = "cbKhoaSV";
            this.cbKhoaSV.Size = new System.Drawing.Size(209, 29);
            this.cbKhoaSV.TabIndex = 3;
            this.cbKhoaSV.SelectedIndexChanged += new System.EventHandler(this.cbKhoaSV_SelectedIndexChanged);
            // 
            // cbLopSV
            // 
            this.cbLopSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLopSV.FormattingEnabled = true;
            this.cbLopSV.Location = new System.Drawing.Point(259, 4);
            this.cbLopSV.Name = "cbLopSV";
            this.cbLopSV.Size = new System.Drawing.Size(121, 29);
            this.cbLopSV.TabIndex = 2;
            this.cbLopSV.SelectedIndexChanged += new System.EventHandler(this.cbLopSV_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHoTenSV);
            this.panel2.Controls.Add(this.lblHoTenSV);
            this.panel2.Controls.Add(this.lblMaSV);
            this.panel2.Controls.Add(this.btnSearchSV);
            this.panel2.Controls.Add(this.txtMaSV);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 36);
            this.panel2.TabIndex = 26;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(306, 8);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(94, 20);
            this.txtHoTenSV.TabIndex = 35;
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(259, 12);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(42, 13);
            this.lblHoTenSV.TabIndex = 34;
            this.lblHoTenSV.Text = "Họ tên:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(113, 12);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(42, 13);
            this.lblMaSV.TabIndex = 33;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSV.Location = new System.Drawing.Point(31, 7);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSV.TabIndex = 31;
            this.btnSearchSV.Text = "Tìm";
            this.btnSearchSV.UseVisualStyleBackColor = false;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(160, 8);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(94, 20);
            this.txtMaSV.TabIndex = 32;
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
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
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
            this.panel1.TabIndex = 0;
            // 
            // frmChonSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 567);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn Sinh viên";
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.DataGridView dgvListSinhVien;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviousGV;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbKhoaSV;
        private System.Windows.Forms.ComboBox cbLopSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel1;
    }
}