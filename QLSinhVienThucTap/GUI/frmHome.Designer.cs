namespace QLSinhVienThucTap.GUI
{
    partial class frmHome
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKihoanrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvListSinhVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbDotTT = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(111, 26);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKihoanrToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // tàiKihoanrToolStripMenuItem
            // 
            this.tàiKihoanrToolStripMenuItem.Name = "tàiKihoanrToolStripMenuItem";
            this.tàiKihoanrToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tàiKihoanrToolStripMenuItem.Text = "Tài khoản";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 500);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPage);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.dgvListSinhVien);
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 387);
            this.panel2.TabIndex = 3;
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
            this.dgvListSinhVien.ReadOnly = true;
            this.dgvListSinhVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListSinhVien.Size = new System.Drawing.Size(885, 353);
            this.dgvListSinhVien.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbDotTT);
            this.panel3.Location = new System.Drawing.Point(3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 36);
            this.panel3.TabIndex = 2;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(293, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Danh sách sinh viên hướng dẫn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmDiem,
            this.tsmAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            this.tsmAdmin.Click += new System.EventHandler(this.tsmAdmin_Click);
            // 
            // tsmDiem
            // 
            this.tsmDiem.Name = "tsmDiem";
            this.tsmDiem.Size = new System.Drawing.Size(96, 20);
            this.tsmDiem.Text = "Đánh giá điểm";
            this.tsmDiem.Click += new System.EventHandler(this.tsmHoiDong_Click);
            // 
            // tsmAccount
            // 
            this.tsmAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccountProfile,
            this.tsmChangePassword,
            this.tsmLogout});
            this.tsmAccount.Name = "tsmAccount";
            this.tsmAccount.Size = new System.Drawing.Size(70, 20);
            this.tsmAccount.Text = "Tài khoản";
            // 
            // tsmAccountProfile
            // 
            this.tsmAccountProfile.Name = "tsmAccountProfile";
            this.tsmAccountProfile.Size = new System.Drawing.Size(171, 22);
            this.tsmAccountProfile.Text = "Thông tin cá nhân";
            this.tsmAccountProfile.Click += new System.EventHandler(this.tsmAccountProfile_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(171, 22);
            this.tsmChangePassword.Text = "Đổi mật khẩu";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(171, 22);
            this.tsmLogout.Text = "Đăng xuất";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKihoanrToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbDotTT;
        private System.Windows.Forms.ToolStripMenuItem tsmDiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvListSinhVien;
    }
}