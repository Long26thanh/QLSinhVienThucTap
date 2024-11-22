namespace QLSinhVienThucTap.GUI
{
    partial class frmDanhGiaDiem
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbDotTT = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvListSinhVien = new System.Windows.Forms.DataGridView();
            this.lblDanhGiaDiem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDanhGiaDiem);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 481);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbDotTT);
            this.panel3.Location = new System.Drawing.Point(4, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 36);
            this.panel3.TabIndex = 11;
            // 
            // cbDotTT
            // 
            this.cbDotTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDotTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDotTT.FormattingEnabled = true;
            this.cbDotTT.Location = new System.Drawing.Point(389, 4);
            this.cbDotTT.Name = "cbDotTT";
            this.cbDotTT.Size = new System.Drawing.Size(121, 29);
            this.cbDotTT.TabIndex = 2;
            this.cbDotTT.SelectedIndexChanged += new System.EventHandler(this.cbDotTT_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPage);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.dgvListSinhVien);
            this.panel2.Location = new System.Drawing.Point(3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 387);
            this.panel2.TabIndex = 10;
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
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
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
            this.dgvListSinhVien.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvListSinhVien_CellBeginEdit);
            this.dgvListSinhVien.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSinhVien_CellValueChanged);
            // 
            // lblDanhGiaDiem
            // 
            this.lblDanhGiaDiem.AutoSize = true;
            this.lblDanhGiaDiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGiaDiem.Location = new System.Drawing.Point(376, 8);
            this.lblDanhGiaDiem.Name = "lblDanhGiaDiem";
            this.lblDanhGiaDiem.Size = new System.Drawing.Size(160, 26);
            this.lblDanhGiaDiem.TabIndex = 9;
            this.lblDanhGiaDiem.Text = "Đánh giá điểm";
            // 
            // frmDanhGiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 486);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmDanhGiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đánh giá điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDanhGiaDiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvListSinhVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbDotTT;
    }
}