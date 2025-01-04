namespace QLSinhVienThucTap.GUI
{
    partial class frmThanhVienHoiDong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTitleThanhVien = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.btnAddThanhVien = new System.Windows.Forms.Button();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.btnSearchGV = new System.Windows.Forms.Button();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTV = new System.Windows.Forms.TextBox();
            this.btnDeleteThanhVien = new System.Windows.Forms.Button();
            this.lblThanhVien = new System.Windows.Forms.Label();
            this.btnSearchThanhVien = new System.Windows.Forms.Button();
            this.txtMaTV = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtPageTV = new System.Windows.Forms.TextBox();
            this.btnNextTV = new System.Windows.Forms.Button();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.btnPreviousTV = new System.Windows.Forms.Button();
            this.btnLastTV = new System.Windows.Forms.Button();
            this.btnFirstTV = new System.Windows.Forms.Button();
            this.txtPageGV = new System.Windows.Forms.TextBox();
            this.btnPreviousGV = new System.Windows.Forms.Button();
            this.btnFirstGV = new System.Windows.Forms.Button();
            this.btnLastGV = new System.Windows.Forms.Button();
            this.btnNextGV = new System.Windows.Forms.Button();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbHoiDong = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(786, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Danh sách thành viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(180, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Danh sách giáo viên:";
            // 
            // lblTitleThanhVien
            // 
            this.lblTitleThanhVien.AutoSize = true;
            this.lblTitleThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleThanhVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleThanhVien.Location = new System.Drawing.Point(444, 28);
            this.lblTitleThanhVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleThanhVien.Name = "lblTitleThanhVien";
            this.lblTitleThanhVien.Size = new System.Drawing.Size(291, 32);
            this.lblTitleThanhVien.TabIndex = 27;
            this.lblTitleThanhVien.Text = "Thành viên hội đồng";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label1);
            this.panel16.Controls.Add(this.txtTenGV);
            this.panel16.Controls.Add(this.btnAddThanhVien);
            this.panel16.Controls.Add(this.lblTenGV);
            this.panel16.Controls.Add(this.btnSearchGV);
            this.panel16.Controls.Add(this.txtMaGV);
            this.panel16.Location = new System.Drawing.Point(5, 167);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(575, 36);
            this.panel16.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên GV:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(351, 5);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(112, 22);
            this.txtTenGV.TabIndex = 16;
            // 
            // btnAddThanhVien
            // 
            this.btnAddThanhVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddThanhVien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddThanhVien.Location = new System.Drawing.Point(471, 4);
            this.btnAddThanhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddThanhVien.Name = "btnAddThanhVien";
            this.btnAddThanhVien.Size = new System.Drawing.Size(100, 28);
            this.btnAddThanhVien.TabIndex = 15;
            this.btnAddThanhVien.Text = "Thêm";
            this.btnAddThanhVien.UseVisualStyleBackColor = false;
            this.btnAddThanhVien.Click += new System.EventHandler(this.btnAddThanhVien_Click);
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(109, 10);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(51, 16);
            this.lblTenGV.TabIndex = 13;
            this.lblTenGV.Text = "Mã GV:";
            // 
            // btnSearchGV
            // 
            this.btnSearchGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchGV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchGV.Location = new System.Drawing.Point(5, 4);
            this.btnSearchGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchGV.Name = "btnSearchGV";
            this.btnSearchGV.Size = new System.Drawing.Size(100, 28);
            this.btnSearchGV.TabIndex = 11;
            this.btnSearchGV.Text = "Tìm";
            this.btnSearchGV.UseVisualStyleBackColor = false;
            this.btnSearchGV.Click += new System.EventHandler(this.btnSearchHoiDong_Click);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(168, 5);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(112, 22);
            this.txtMaGV.TabIndex = 12;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label2);
            this.panel12.Controls.Add(this.txtTenTV);
            this.panel12.Controls.Add(this.btnDeleteThanhVien);
            this.panel12.Controls.Add(this.lblThanhVien);
            this.panel12.Controls.Add(this.btnSearchThanhVien);
            this.panel12.Controls.Add(this.txtMaTV);
            this.panel12.Location = new System.Drawing.Point(612, 167);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(575, 36);
            this.panel12.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ tên:";
            // 
            // txtTenTV
            // 
            this.txtTenTV.Location = new System.Drawing.Point(348, 5);
            this.txtTenTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTV.Name = "txtTenTV";
            this.txtTenTV.Size = new System.Drawing.Size(112, 22);
            this.txtTenTV.TabIndex = 16;
            // 
            // btnDeleteThanhVien
            // 
            this.btnDeleteThanhVien.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteThanhVien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteThanhVien.Location = new System.Drawing.Point(471, 4);
            this.btnDeleteThanhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteThanhVien.Name = "btnDeleteThanhVien";
            this.btnDeleteThanhVien.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteThanhVien.TabIndex = 15;
            this.btnDeleteThanhVien.Text = "Xóa";
            this.btnDeleteThanhVien.UseVisualStyleBackColor = false;
            this.btnDeleteThanhVien.Click += new System.EventHandler(this.btnDeleteThanhVien_Click);
            // 
            // lblThanhVien
            // 
            this.lblThanhVien.AutoSize = true;
            this.lblThanhVien.Location = new System.Drawing.Point(108, 10);
            this.lblThanhVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhVien.Name = "lblThanhVien";
            this.lblThanhVien.Size = new System.Drawing.Size(50, 16);
            this.lblThanhVien.TabIndex = 13;
            this.lblThanhVien.Text = "Mã tên:";
            // 
            // btnSearchThanhVien
            // 
            this.btnSearchThanhVien.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchThanhVien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchThanhVien.Location = new System.Drawing.Point(4, 4);
            this.btnSearchThanhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchThanhVien.Name = "btnSearchThanhVien";
            this.btnSearchThanhVien.Size = new System.Drawing.Size(100, 28);
            this.btnSearchThanhVien.TabIndex = 11;
            this.btnSearchThanhVien.Text = "Tìm";
            this.btnSearchThanhVien.UseVisualStyleBackColor = false;
            this.btnSearchThanhVien.Click += new System.EventHandler(this.btnSearchThanhVien_Click);
            // 
            // txtMaTV
            // 
            this.txtMaTV.Location = new System.Drawing.Point(167, 5);
            this.txtMaTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.Size = new System.Drawing.Size(112, 22);
            this.txtMaTV.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtPageTV);
            this.panel14.Controls.Add(this.btnNextTV);
            this.panel14.Controls.Add(this.dgvThanhVien);
            this.panel14.Controls.Add(this.btnPreviousTV);
            this.panel14.Controls.Add(this.btnLastTV);
            this.panel14.Controls.Add(this.btnFirstTV);
            this.panel14.Location = new System.Drawing.Point(612, 212);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(575, 478);
            this.panel14.TabIndex = 23;
            // 
            // txtPageTV
            // 
            this.txtPageTV.Location = new System.Drawing.Point(220, 447);
            this.txtPageTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPageTV.Name = "txtPageTV";
            this.txtPageTV.Size = new System.Drawing.Size(132, 22);
            this.txtPageTV.TabIndex = 30;
            this.txtPageTV.Text = "1";
            this.txtPageTV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageTV.TextChanged += new System.EventHandler(this.txtPageTV_TextChanged);
            // 
            // btnNextTV
            // 
            this.btnNextTV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNextTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNextTV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNextTV.Location = new System.Drawing.Point(361, 444);
            this.btnNextTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextTV.Name = "btnNextTV";
            this.btnNextTV.Size = new System.Drawing.Size(100, 28);
            this.btnNextTV.TabIndex = 15;
            this.btnNextTV.Text = ">";
            this.btnNextTV.UseVisualStyleBackColor = false;
            this.btnNextTV.Click += new System.EventHandler(this.btnNextTV_Click);
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AllowUserToDeleteRows = false;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(4, 4);
            this.dgvThanhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThanhVien.MultiSelect = false;
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.RowHeadersWidth = 51;
            this.dgvThanhVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvThanhVien.Size = new System.Drawing.Size(565, 434);
            this.dgvThanhVien.TabIndex = 0;
            // 
            // btnPreviousTV
            // 
            this.btnPreviousTV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPreviousTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousTV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPreviousTV.Location = new System.Drawing.Point(111, 444);
            this.btnPreviousTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousTV.Name = "btnPreviousTV";
            this.btnPreviousTV.Size = new System.Drawing.Size(100, 28);
            this.btnPreviousTV.TabIndex = 14;
            this.btnPreviousTV.Text = "<";
            this.btnPreviousTV.UseVisualStyleBackColor = false;
            this.btnPreviousTV.Click += new System.EventHandler(this.btnPreviousTV_Click);
            // 
            // btnLastTV
            // 
            this.btnLastTV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLastTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLastTV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLastTV.Location = new System.Drawing.Point(469, 443);
            this.btnLastTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastTV.Name = "btnLastTV";
            this.btnLastTV.Size = new System.Drawing.Size(100, 28);
            this.btnLastTV.TabIndex = 13;
            this.btnLastTV.Text = ">>";
            this.btnLastTV.UseVisualStyleBackColor = false;
            this.btnLastTV.Click += new System.EventHandler(this.btnLastTV_Click);
            // 
            // btnFirstTV
            // 
            this.btnFirstTV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFirstTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirstTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFirstTV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirstTV.Location = new System.Drawing.Point(4, 444);
            this.btnFirstTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstTV.Name = "btnFirstTV";
            this.btnFirstTV.Size = new System.Drawing.Size(100, 28);
            this.btnFirstTV.TabIndex = 12;
            this.btnFirstTV.Text = "<<";
            this.btnFirstTV.UseVisualStyleBackColor = false;
            this.btnFirstTV.Click += new System.EventHandler(this.btnFirstTV_Click);
            // 
            // txtPageGV
            // 
            this.txtPageGV.Location = new System.Drawing.Point(224, 658);
            this.txtPageGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPageGV.Name = "txtPageGV";
            this.txtPageGV.Size = new System.Drawing.Size(132, 22);
            this.txtPageGV.TabIndex = 12;
            this.txtPageGV.Text = "1";
            this.txtPageGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageGV.TextChanged += new System.EventHandler(this.txtPageGV_TextChanged);
            this.txtPageGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageGV_KeyPress);
            // 
            // btnPreviousGV
            // 
            this.btnPreviousGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPreviousGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousGV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPreviousGV.Location = new System.Drawing.Point(111, 444);
            this.btnPreviousGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousGV.Name = "btnPreviousGV";
            this.btnPreviousGV.Size = new System.Drawing.Size(100, 28);
            this.btnPreviousGV.TabIndex = 10;
            this.btnPreviousGV.Text = "<";
            this.btnPreviousGV.UseVisualStyleBackColor = false;
            this.btnPreviousGV.Click += new System.EventHandler(this.btnPreviousGV_Click);
            // 
            // btnFirstGV
            // 
            this.btnFirstGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFirstGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirstGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFirstGV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirstGV.Location = new System.Drawing.Point(4, 444);
            this.btnFirstGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstGV.Name = "btnFirstGV";
            this.btnFirstGV.Size = new System.Drawing.Size(100, 28);
            this.btnFirstGV.TabIndex = 8;
            this.btnFirstGV.Text = "<<";
            this.btnFirstGV.UseVisualStyleBackColor = false;
            this.btnFirstGV.Click += new System.EventHandler(this.btnFirstGV_Click);
            // 
            // btnLastGV
            // 
            this.btnLastGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLastGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLastGV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLastGV.Location = new System.Drawing.Point(469, 444);
            this.btnLastGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastGV.Name = "btnLastGV";
            this.btnLastGV.Size = new System.Drawing.Size(100, 28);
            this.btnLastGV.TabIndex = 9;
            this.btnLastGV.Text = ">>";
            this.btnLastGV.UseVisualStyleBackColor = false;
            this.btnLastGV.Click += new System.EventHandler(this.btnLastGV_Click);
            // 
            // btnNextGV
            // 
            this.btnNextGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNextGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNextGV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNextGV.Location = new System.Drawing.Point(360, 444);
            this.btnNextGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextGV.Name = "btnNextGV";
            this.btnNextGV.Size = new System.Drawing.Size(100, 28);
            this.btnNextGV.TabIndex = 11;
            this.btnNextGV.Text = ">";
            this.btnNextGV.UseVisualStyleBackColor = false;
            this.btnNextGV.Click += new System.EventHandler(this.btnNextGV_Click);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(4, 4);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGiaoVien.MultiSelect = false;
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGiaoVien.Size = new System.Drawing.Size(565, 434);
            this.dgvGiaoVien.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dgvGiaoVien);
            this.panel17.Controls.Add(this.btnNextGV);
            this.panel17.Controls.Add(this.btnPreviousGV);
            this.panel17.Controls.Add(this.btnLastGV);
            this.panel17.Controls.Add(this.btnFirstGV);
            this.panel17.Location = new System.Drawing.Point(5, 212);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(575, 478);
            this.panel17.TabIndex = 24;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cbHoiDong);
            this.panel11.Controls.Add(this.cbKhoa);
            this.panel11.Location = new System.Drawing.Point(5, 121);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1189, 44);
            this.panel11.TabIndex = 30;
            // 
            // cbHoiDong
            // 
            this.cbHoiDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHoiDong.FormattingEnabled = true;
            this.cbHoiDong.Location = new System.Drawing.Point(811, 4);
            this.cbHoiDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHoiDong.Name = "cbHoiDong";
            this.cbHoiDong.Size = new System.Drawing.Size(188, 37);
            this.cbHoiDong.TabIndex = 4;
            this.cbHoiDong.SelectedIndexChanged += new System.EventHandler(this.cbHoiDong_SelectedIndexChanged);
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(159, 4);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(277, 37);
            this.cbKhoa.TabIndex = 3;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // frmThanhVienHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 693);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtPageGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitleThanhVien);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel14);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThanhVienHoiDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm thành viên hội đồng";
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTitleThanhVien;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnAddThanhVien;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Button btnSearchGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDeleteThanhVien;
        private System.Windows.Forms.Label lblThanhVien;
        private System.Windows.Forms.Button btnSearchThanhVien;
        private System.Windows.Forms.TextBox txtMaTV;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.TextBox txtPageGV;
        private System.Windows.Forms.Button btnPreviousGV;
        private System.Windows.Forms.Button btnFirstGV;
        private System.Windows.Forms.Button btnLastGV;
        private System.Windows.Forms.Button btnNextGV;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtPageTV;
        private System.Windows.Forms.Button btnNextTV;
        private System.Windows.Forms.Button btnPreviousTV;
        private System.Windows.Forms.Button btnLastTV;
        private System.Windows.Forms.Button btnFirstTV;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cbHoiDong;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTV;
    }
}