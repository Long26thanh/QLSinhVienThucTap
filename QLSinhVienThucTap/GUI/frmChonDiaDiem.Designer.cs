namespace QLSinhVienThucTap.GUI
{
    partial class frmChonDiaDiem
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.dgvListDiaDiem = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviousGV = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblTenDot = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenDiaDiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiaDiem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 524);
            this.panel1.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtPage);
            this.panel17.Controls.Add(this.dgvListDiaDiem);
            this.panel17.Controls.Add(this.btnNext);
            this.panel17.Controls.Add(this.btnPreviousGV);
            this.panel17.Controls.Add(this.btnLast);
            this.panel17.Controls.Add(this.btnFirst);
            this.panel17.Location = new System.Drawing.Point(2, 90);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(668, 388);
            this.panel17.TabIndex = 43;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(286, 363);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 20);
            this.txtPage.TabIndex = 13;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // dgvListDiaDiem
            // 
            this.dgvListDiaDiem.AllowUserToAddRows = false;
            this.dgvListDiaDiem.AllowUserToDeleteRows = false;
            this.dgvListDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDiaDiem.Location = new System.Drawing.Point(3, 3);
            this.dgvListDiaDiem.MultiSelect = false;
            this.dgvListDiaDiem.Name = "dgvListDiaDiem";
            this.dgvListDiaDiem.ReadOnly = true;
            this.dgvListDiaDiem.RowHeadersWidth = 51;
            this.dgvListDiaDiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListDiaDiem.Size = new System.Drawing.Size(662, 353);
            this.dgvListDiaDiem.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(508, 361);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviousGV
            // 
            this.btnPreviousGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPreviousGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousGV.ForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.btnLast.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(590, 361);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirst.Location = new System.Drawing.Point(3, 361);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelect.Location = new System.Drawing.Point(299, 490);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblDiaChi);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.lblTenDot);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtTenDiaDiem);
            this.panel2.Location = new System.Drawing.Point(2, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 36);
            this.panel2.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(590, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(262, 12);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 35;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(308, 8);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 20);
            this.txtDiaChi.TabIndex = 34;
            // 
            // lblTenDot
            // 
            this.lblTenDot.AutoSize = true;
            this.lblTenDot.Location = new System.Drawing.Point(88, 12);
            this.lblTenDot.Name = "lblTenDot";
            this.lblTenDot.Size = new System.Drawing.Size(73, 13);
            this.lblTenDot.TabIndex = 33;
            this.lblTenDot.Text = "Tên địa điểm:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Location = new System.Drawing.Point(6, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenDiaDiem
            // 
            this.txtTenDiaDiem.Location = new System.Drawing.Point(166, 8);
            this.txtTenDiaDiem.Name = "txtTenDiaDiem";
            this.txtTenDiaDiem.Size = new System.Drawing.Size(94, 20);
            this.txtTenDiaDiem.TabIndex = 32;
            // 
            // frmChonDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 524);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn địa điểm thực tập";
            this.panel1.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiaDiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.DataGridView dgvListDiaDiem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviousGV;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTenDot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTenDiaDiem;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDelete;
    }
}