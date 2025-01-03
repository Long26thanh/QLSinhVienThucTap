namespace QLSinhVienThucTap.GUI
{
    partial class frmChonDotTT
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
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblTenDot = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenDot = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dgvListDotTT = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDotTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 524);
            this.panel1.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(231, 495);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNgayKetThuc);
            this.panel2.Controls.Add(this.lblNgayKetThuc);
            this.panel2.Controls.Add(this.dtpNgayBatDau);
            this.panel2.Controls.Add(this.lblNgayBatDau);
            this.panel2.Controls.Add(this.lblTenDot);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtTenDot);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 36);
            this.panel2.TabIndex = 26;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(432, 8);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(96, 20);
            this.dtpNgayKetThuc.TabIndex = 37;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(382, 12);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(50, 13);
            this.lblNgayKetThuc.TabIndex = 36;
            this.lblNgayKetThuc.Text = "Kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(284, 8);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(95, 20);
            this.dtpNgayBatDau.TabIndex = 35;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(234, 12);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(48, 13);
            this.lblNgayBatDau.TabIndex = 34;
            this.lblNgayBatDau.Text = "Bắt đầu:";
            // 
            // lblTenDot
            // 
            this.lblTenDot.AutoSize = true;
            this.lblTenDot.Location = new System.Drawing.Point(88, 12);
            this.lblTenDot.Name = "lblTenDot";
            this.lblTenDot.Size = new System.Drawing.Size(48, 13);
            this.lblTenDot.TabIndex = 33;
            this.lblTenDot.Text = "Tên đợt:";
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
            // txtTenDot
            // 
            this.txtTenDot.Location = new System.Drawing.Point(135, 8);
            this.txtTenDot.Name = "txtTenDot";
            this.txtTenDot.Size = new System.Drawing.Size(94, 20);
            this.txtTenDot.TabIndex = 32;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dgvListDotTT);
            this.panel17.Location = new System.Drawing.Point(3, 133);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(532, 361);
            this.panel17.TabIndex = 25;
            // 
            // dgvListDotTT
            // 
            this.dgvListDotTT.AllowUserToAddRows = false;
            this.dgvListDotTT.AllowUserToDeleteRows = false;
            this.dgvListDotTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDotTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDotTT.Location = new System.Drawing.Point(3, 3);
            this.dgvListDotTT.MultiSelect = false;
            this.dgvListDotTT.Name = "dgvListDotTT";
            this.dgvListDotTT.ReadOnly = true;
            this.dgvListDotTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListDotTT.Size = new System.Drawing.Size(525, 353);
            this.dgvListDotTT.TabIndex = 0;
            this.dgvListDotTT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListDotTT_CellFormatting);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(222, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmChonDotTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 524);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonDotTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChonDotTT";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDotTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTenDot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTenDot;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DataGridView dgvListDotTT;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Button btnDelete;
    }
}