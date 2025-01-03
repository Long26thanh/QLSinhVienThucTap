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
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 480);
            this.panel1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(179, 445);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHoTenSV);
            this.panel2.Controls.Add(this.lblHoTenSV);
            this.panel2.Controls.Add(this.lblMaSV);
            this.panel2.Controls.Add(this.btnSearchSV);
            this.panel2.Controls.Add(this.txtMaSV);
            this.panel2.Location = new System.Drawing.Point(3, 38);
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
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(160, 8);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(94, 20);
            this.txtMaSV.TabIndex = 32;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dgvListHoiDong);
            this.panel17.Location = new System.Drawing.Point(3, 77);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(431, 362);
            this.panel17.TabIndex = 25;
            // 
            // dgvListHoiDong
            // 
            this.dgvListHoiDong.AllowUserToAddRows = false;
            this.dgvListHoiDong.AllowUserToDeleteRows = false;
            this.dgvListHoiDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListHoiDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHoiDong.Location = new System.Drawing.Point(3, 3);
            this.dgvListHoiDong.MultiSelect = false;
            this.dgvListHoiDong.Name = "dgvListHoiDong";
            this.dgvListHoiDong.ReadOnly = true;
            this.dgvListHoiDong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListHoiDong.Size = new System.Drawing.Size(424, 353);
            this.dgvListHoiDong.TabIndex = 0;
            // 
            // frmChonHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 480);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonHoiDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChonHoiDong";
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
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DataGridView dgvListHoiDong;
    }
}