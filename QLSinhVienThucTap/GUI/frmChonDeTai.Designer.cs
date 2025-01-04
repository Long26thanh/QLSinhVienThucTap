namespace QLSinhVienThucTap.GUI
{
    partial class frmChonDeTai
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblTenDeTai = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.dgvListDeTai = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviousGV = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDeTai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblMoTa);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.lblTenDeTai);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtTenDeTai);
            this.panel2.Location = new System.Drawing.Point(2, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 36);
            this.panel2.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(590, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(236, 13);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 35;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(272, 9);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(313, 20);
            this.txtMoTa.TabIndex = 34;
            // 
            // lblTenDeTai
            // 
            this.lblTenDeTai.AutoSize = true;
            this.lblTenDeTai.Location = new System.Drawing.Point(84, 12);
            this.lblTenDeTai.Name = "lblTenDeTai";
            this.lblTenDeTai.Size = new System.Drawing.Size(59, 13);
            this.lblTenDeTai.TabIndex = 33;
            this.lblTenDeTai.Text = "Tên đề tài:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(6, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(140, 8);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(94, 20);
            this.txtTenDeTai.TabIndex = 32;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(299, 490);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtPage);
            this.panel17.Controls.Add(this.dgvListDeTai);
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
            // 
            // dgvListDeTai
            // 
            this.dgvListDeTai.AllowUserToAddRows = false;
            this.dgvListDeTai.AllowUserToDeleteRows = false;
            this.dgvListDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDeTai.Location = new System.Drawing.Point(3, 3);
            this.dgvListDeTai.MultiSelect = false;
            this.dgvListDeTai.Name = "dgvListDeTai";
            this.dgvListDeTai.ReadOnly = true;
            this.dgvListDeTai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListDeTai.Size = new System.Drawing.Size(662, 353);
            this.dgvListDeTai.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 524);
            this.panel1.TabIndex = 0;
            // 
            // frmChonDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 524);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonDeTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn Đề tài";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDeTai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTenDeTai;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.DataGridView dgvListDeTai;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviousGV;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnDelete;
    }
}