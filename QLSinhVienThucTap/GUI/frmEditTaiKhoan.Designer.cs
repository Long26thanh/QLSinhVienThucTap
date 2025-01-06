namespace QLSinhVienThucTap.GUI
{
    partial class frmEditTaiKhoan
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbVaiTro = new System.Windows.Forms.ComboBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.btnChonGV = new System.Windows.Forms.Button();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnUpdate);
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.btnReset);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(670, 411);
            this.panel11.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(275, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 41);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtUsername);
            this.panel16.Controls.Add(this.lblUserName);
            this.panel16.Location = new System.Drawing.Point(34, 37);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(603, 50);
            this.panel16.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(193, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(268, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(6, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(134, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên đăng nhập:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbVaiTro);
            this.panel13.Controls.Add(this.lblVaiTro);
            this.panel13.Location = new System.Drawing.Point(34, 236);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(603, 50);
            this.panel13.TabIndex = 16;
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaiTro.FormattingEnabled = true;
            this.cbVaiTro.ItemHeight = 20;
            this.cbVaiTro.Location = new System.Drawing.Point(193, 10);
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(120, 28);
            this.cbVaiTro.TabIndex = 1;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVaiTro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaiTro.Location = new System.Drawing.Point(6, 13);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(67, 20);
            this.lblVaiTro.TabIndex = 0;
            this.lblVaiTro.Text = "Vai trò:";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(258, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 41);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Đặt lại mật khẩu";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtTenNguoiDung);
            this.panel14.Controls.Add(this.lblTenNguoiDung);
            this.panel14.Controls.Add(this.btnChonGV);
            this.panel14.Controls.Add(this.txtMaGV);
            this.panel14.Controls.Add(this.lblMaGV);
            this.panel14.Location = new System.Drawing.Point(34, 108);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(603, 111);
            this.panel14.TabIndex = 12;
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNguoiDung.Location = new System.Drawing.Point(193, 63);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.ReadOnly = true;
            this.txtTenNguoiDung.Size = new System.Drawing.Size(268, 26);
            this.txtTenNguoiDung.TabIndex = 16;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNguoiDung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(6, 66);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(138, 20);
            this.lblTenNguoiDung.TabIndex = 15;
            this.lblTenNguoiDung.Text = "Tên người dùng:";
            // 
            // btnChonGV
            // 
            this.btnChonGV.AutoSize = true;
            this.btnChonGV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChonGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChonGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonGV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChonGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChonGV.Location = new System.Drawing.Point(477, 37);
            this.btnChonGV.Name = "btnChonGV";
            this.btnChonGV.Size = new System.Drawing.Size(120, 37);
            this.btnChonGV.TabIndex = 14;
            this.btnChonGV.Text = "Chọn";
            this.btnChonGV.UseVisualStyleBackColor = false;
            this.btnChonGV.Click += new System.EventHandler(this.btnChonGV_Click);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaGV.Location = new System.Drawing.Point(193, 10);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(268, 26);
            this.txtMaGV.TabIndex = 1;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaGV.Location = new System.Drawing.Point(6, 13);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(114, 20);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã giáo viên:";
            // 
            // frmEditTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 411);
            this.Controls.Add(this.panel11);
            this.Name = "frmEditTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản";
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnChonGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.ComboBox cbVaiTro;
        private System.Windows.Forms.Button btnUpdate;
    }
}