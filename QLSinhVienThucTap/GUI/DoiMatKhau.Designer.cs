namespace QLSinhVienThucTap.GUI
{
    partial class frmDoiMatKhau
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtReNewPassword = new System.Windows.Forms.TextBox();
            this.lblReNewPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 316);
            this.panel1.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(153, 273);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(120, 33);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(132, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 26);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Đổi mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 50);
            this.panel2.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(174, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 13);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 22);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNewPassword);
            this.panel3.Controls.Add(this.lblNewPassword);
            this.panel3.Location = new System.Drawing.Point(3, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 50);
            this.panel3.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(174, 10);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(231, 29);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(6, 13);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(131, 22);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Mật khẩu mới:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtReNewPassword);
            this.panel4.Controls.Add(this.lblReNewPassword);
            this.panel4.Location = new System.Drawing.Point(2, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 50);
            this.panel4.TabIndex = 7;
            // 
            // txtReNewPassword
            // 
            this.txtReNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReNewPassword.Location = new System.Drawing.Point(174, 10);
            this.txtReNewPassword.Name = "txtReNewPassword";
            this.txtReNewPassword.Size = new System.Drawing.Size(231, 29);
            this.txtReNewPassword.TabIndex = 1;
            this.txtReNewPassword.UseSystemPasswordChar = true;
            // 
            // lblReNewPassword
            // 
            this.lblReNewPassword.AutoSize = true;
            this.lblReNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReNewPassword.Location = new System.Drawing.Point(6, 13);
            this.lblReNewPassword.Name = "lblReNewPassword";
            this.lblReNewPassword.Size = new System.Drawing.Size(166, 22);
            this.lblReNewPassword.TabIndex = 0;
            this.lblReNewPassword.Text = "Nhập lại mật khẩu:";
            // 
            // DoiMatKhau
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 325);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReNewPassword;
        private System.Windows.Forms.Label lblReNewPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}