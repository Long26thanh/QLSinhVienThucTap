namespace QLSinhVienThucTap.GUI
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tpKhoa = new System.Windows.Forms.TabPage();
            this.tpSinhVien = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListSinhVien = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.lblAddHoTen = new System.Windows.Forms.Panel();
            this.txtAddHoTenSV = new System.Windows.Forms.TextBox();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.lblAddHoTenSV = new System.Windows.Forms.Label();
            this.lblAddNgaySinhSV = new System.Windows.Forms.Label();
            this.dtpNgaySinhSV = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinhSV = new System.Windows.Forms.Label();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.lblPhoneSV = new System.Windows.Forms.Label();
            this.txtPhoneSV = new System.Windows.Forms.TextBox();
            this.lblEmailSV = new System.Windows.Forms.Label();
            this.txtDiaChiSV = new System.Windows.Forms.TextBox();
            this.lblDiaChiSV = new System.Windows.Forms.Label();
            this.txtEmailSV = new System.Windows.Forms.TextBox();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.label9 = new System.Windows.Forms.Label();
            this.tpKhoa.SuspendLayout();
            this.tpSinhVien.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.lblAddHoTen.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tpKhoa
            // 
            this.tpKhoa.Controls.Add(this.label9);
            this.tpKhoa.Location = new System.Drawing.Point(4, 22);
            this.tpKhoa.Name = "tpKhoa";
            this.tpKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhoa.Size = new System.Drawing.Size(900, 556);
            this.tpKhoa.TabIndex = 2;
            this.tpKhoa.Text = "Khoa";
            this.tpKhoa.UseVisualStyleBackColor = true;
            // 
            // tpSinhVien
            // 
            this.tpSinhVien.Controls.Add(this.lblAddHoTen);
            this.tpSinhVien.Controls.Add(this.panel1);
            this.tpSinhVien.Controls.Add(this.panel2);
            this.tpSinhVien.Controls.Add(this.panel3);
            this.tpSinhVien.Controls.Add(this.lblTitle);
            this.tpSinhVien.Location = new System.Drawing.Point(4, 22);
            this.tpSinhVien.Name = "tpSinhVien";
            this.tpSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpSinhVien.Size = new System.Drawing.Size(900, 556);
            this.tpSinhVien.TabIndex = 0;
            this.tpSinhVien.Text = "Sinh Viên";
            this.tpSinhVien.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(349, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Danh sách Sinh viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLop);
            this.panel3.Location = new System.Drawing.Point(4, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 36);
            this.panel3.TabIndex = 4;
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(385, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 29);
            this.cbLop.TabIndex = 2;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPage);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.dgvListSinhVien);
            this.panel2.Location = new System.Drawing.Point(4, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 387);
            this.panel2.TabIndex = 5;
            // 
            // dgvListSinhVien
            // 
            this.dgvListSinhVien.AllowUserToAddRows = false;
            this.dgvListSinhVien.AllowUserToDeleteRows = false;
            this.dgvListSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSinhVien.Location = new System.Drawing.Point(4, 3);
            this.dgvListSinhVien.Name = "dgvListSinhVien";
            this.dgvListSinhVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListSinhVien.Size = new System.Drawing.Size(885, 353);
            this.dgvListSinhVien.TabIndex = 0;
            this.dgvListSinhVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListSinhVien_CellFormatting);
            this.dgvListSinhVien.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSinhVien_CellValueChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Location = new System.Drawing.Point(4, 360);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Location = new System.Drawing.Point(812, 362);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Location = new System.Drawing.Point(85, 360);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Trước";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(731, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(397, 362);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 20);
            this.txtPage.TabIndex = 7;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaSV);
            this.panel1.Controls.Add(this.txtHoTenSV);
            this.panel1.Controls.Add(this.lblHoTenSV);
            this.panel1.Controls.Add(this.lblMaSV);
            this.panel1.Controls.Add(this.btnSearchSV);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Location = new System.Drawing.Point(4, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 36);
            this.panel1.TabIndex = 9;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(360, 8);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(94, 20);
            this.txtMaSV.TabIndex = 5;
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSV.Location = new System.Drawing.Point(231, 7);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSV.TabIndex = 4;
            this.btnSearchSV.Text = "Tìm";
            this.btnSearchSV.UseVisualStyleBackColor = false;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(313, 12);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(42, 13);
            this.lblMaSV.TabIndex = 6;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(459, 12);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(42, 13);
            this.lblHoTenSV.TabIndex = 7;
            this.lblHoTenSV.Text = "Họ tên:";
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(506, 8);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(94, 20);
            this.txtHoTenSV.TabIndex = 8;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaSV.Location = new System.Drawing.Point(612, 7);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSV.TabIndex = 9;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = false;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // lblAddHoTen
            // 
            this.lblAddHoTen.Controls.Add(this.txtEmailSV);
            this.lblAddHoTen.Controls.Add(this.lblDiaChiSV);
            this.lblAddHoTen.Controls.Add(this.txtDiaChiSV);
            this.lblAddHoTen.Controls.Add(this.lblEmailSV);
            this.lblAddHoTen.Controls.Add(this.txtPhoneSV);
            this.lblAddHoTen.Controls.Add(this.lblPhoneSV);
            this.lblAddHoTen.Controls.Add(this.chkGioiTinh);
            this.lblAddHoTen.Controls.Add(this.lblGioiTinhSV);
            this.lblAddHoTen.Controls.Add(this.dtpNgaySinhSV);
            this.lblAddHoTen.Controls.Add(this.lblAddNgaySinhSV);
            this.lblAddHoTen.Controls.Add(this.lblAddHoTenSV);
            this.lblAddHoTen.Controls.Add(this.btnAddSV);
            this.lblAddHoTen.Controls.Add(this.txtAddHoTenSV);
            this.lblAddHoTen.Location = new System.Drawing.Point(4, 123);
            this.lblAddHoTen.Name = "lblAddHoTen";
            this.lblAddHoTen.Size = new System.Drawing.Size(892, 36);
            this.lblAddHoTen.TabIndex = 10;
            // 
            // txtAddHoTenSV
            // 
            this.txtAddHoTenSV.Location = new System.Drawing.Point(144, 7);
            this.txtAddHoTenSV.Name = "txtAddHoTenSV";
            this.txtAddHoTenSV.Size = new System.Drawing.Size(94, 20);
            this.txtAddHoTenSV.TabIndex = 5;
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSV.Location = new System.Drawing.Point(19, 6);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(75, 23);
            this.btnAddSV.TabIndex = 4;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // lblAddHoTenSV
            // 
            this.lblAddHoTenSV.AutoSize = true;
            this.lblAddHoTenSV.Location = new System.Drawing.Point(97, 11);
            this.lblAddHoTenSV.Name = "lblAddHoTenSV";
            this.lblAddHoTenSV.Size = new System.Drawing.Size(42, 13);
            this.lblAddHoTenSV.TabIndex = 6;
            this.lblAddHoTenSV.Text = "Họ tên:";
            // 
            // lblAddNgaySinhSV
            // 
            this.lblAddNgaySinhSV.AutoSize = true;
            this.lblAddNgaySinhSV.Location = new System.Drawing.Point(241, 11);
            this.lblAddNgaySinhSV.Name = "lblAddNgaySinhSV";
            this.lblAddNgaySinhSV.Size = new System.Drawing.Size(57, 13);
            this.lblAddNgaySinhSV.TabIndex = 7;
            this.lblAddNgaySinhSV.Text = "Ngày sinh:";
            // 
            // dtpNgaySinhSV
            // 
            this.dtpNgaySinhSV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhSV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhSV.Location = new System.Drawing.Point(304, 7);
            this.dtpNgaySinhSV.Name = "dtpNgaySinhSV";
            this.dtpNgaySinhSV.Size = new System.Drawing.Size(96, 20);
            this.dtpNgaySinhSV.TabIndex = 11;
            // 
            // lblGioiTinhSV
            // 
            this.lblGioiTinhSV.AutoSize = true;
            this.lblGioiTinhSV.Location = new System.Drawing.Point(403, 11);
            this.lblGioiTinhSV.Name = "lblGioiTinhSV";
            this.lblGioiTinhSV.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinhSV.TabIndex = 12;
            this.lblGioiTinhSV.Text = "Giới tính:";
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(456, 10);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(15, 14);
            this.chkGioiTinh.TabIndex = 13;
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // lblPhoneSV
            // 
            this.lblPhoneSV.AutoSize = true;
            this.lblPhoneSV.Location = new System.Drawing.Point(472, 11);
            this.lblPhoneSV.Name = "lblPhoneSV";
            this.lblPhoneSV.Size = new System.Drawing.Size(32, 13);
            this.lblPhoneSV.TabIndex = 14;
            this.lblPhoneSV.Text = "SĐT:";
            // 
            // txtPhoneSV
            // 
            this.txtPhoneSV.Location = new System.Drawing.Point(507, 7);
            this.txtPhoneSV.Name = "txtPhoneSV";
            this.txtPhoneSV.Size = new System.Drawing.Size(94, 20);
            this.txtPhoneSV.TabIndex = 15;
            // 
            // lblEmailSV
            // 
            this.lblEmailSV.AutoSize = true;
            this.lblEmailSV.Location = new System.Drawing.Point(746, 11);
            this.lblEmailSV.Name = "lblEmailSV";
            this.lblEmailSV.Size = new System.Drawing.Size(35, 13);
            this.lblEmailSV.TabIndex = 16;
            this.lblEmailSV.Text = "Email:";
            // 
            // txtDiaChiSV
            // 
            this.txtDiaChiSV.Location = new System.Drawing.Point(650, 7);
            this.txtDiaChiSV.Name = "txtDiaChiSV";
            this.txtDiaChiSV.Size = new System.Drawing.Size(94, 20);
            this.txtDiaChiSV.TabIndex = 17;
            // 
            // lblDiaChiSV
            // 
            this.lblDiaChiSV.AutoSize = true;
            this.lblDiaChiSV.Location = new System.Drawing.Point(604, 11);
            this.lblDiaChiSV.Name = "lblDiaChiSV";
            this.lblDiaChiSV.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChiSV.TabIndex = 18;
            this.lblDiaChiSV.Text = "Địa chỉ:";
            // 
            // txtEmailSV
            // 
            this.txtEmailSV.Location = new System.Drawing.Point(782, 7);
            this.txtEmailSV.Name = "txtEmailSV";
            this.txtEmailSV.Size = new System.Drawing.Size(94, 20);
            this.txtEmailSV.TabIndex = 19;
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpSinhVien);
            this.tcMenu.Controls.Add(this.tpKhoa);
            this.tcMenu.Location = new System.Drawing.Point(-3, 2);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(908, 582);
            this.tcMenu.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 27);
            this.label9.TabIndex = 2;
            this.label9.Text = "Danh sách Khoa";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 582);
            this.Controls.Add(this.tcMenu);
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.tpKhoa.ResumeLayout(false);
            this.tpKhoa.PerformLayout();
            this.tpSinhVien.ResumeLayout(false);
            this.tpSinhVien.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.lblAddHoTen.ResumeLayout(false);
            this.lblAddHoTen.PerformLayout();
            this.tcMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tpKhoa;
        private System.Windows.Forms.TabPage tpSinhVien;
        private System.Windows.Forms.Panel lblAddHoTen;
        private System.Windows.Forms.TextBox txtEmailSV;
        private System.Windows.Forms.Label lblDiaChiSV;
        private System.Windows.Forms.TextBox txtDiaChiSV;
        private System.Windows.Forms.Label lblEmailSV;
        private System.Windows.Forms.TextBox txtPhoneSV;
        private System.Windows.Forms.Label lblPhoneSV;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.Label lblGioiTinhSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhSV;
        private System.Windows.Forms.Label lblAddNgaySinhSV;
        private System.Windows.Forms.Label lblAddHoTenSV;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.TextBox txtAddHoTenSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvListSinhVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.Label label9;
    }
}