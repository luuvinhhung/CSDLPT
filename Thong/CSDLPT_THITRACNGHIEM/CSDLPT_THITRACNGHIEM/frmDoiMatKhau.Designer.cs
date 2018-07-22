namespace CSDLPT_THITRACNGHIEM
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
            this.label1 = new System.Windows.Forms.Label();
            this.btHuyThayDoi = new System.Windows.Forms.Button();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.newpass = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(429, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 18);
            this.label1.TabIndex = 15;
            // 
            // btHuyThayDoi
            // 
            this.btHuyThayDoi.Location = new System.Drawing.Point(542, 279);
            this.btHuyThayDoi.Name = "btHuyThayDoi";
            this.btHuyThayDoi.Size = new System.Drawing.Size(136, 23);
            this.btHuyThayDoi.TabIndex = 14;
            this.btHuyThayDoi.Text = "HỦY THAY ĐỔI";
            this.btHuyThayDoi.UseVisualStyleBackColor = true;
            this.btHuyThayDoi.Click += new System.EventHandler(this.btHuyThayDoi_Click);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(374, 279);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(132, 23);
            this.btThayDoi.TabIndex = 13;
            this.btThayDoi.Text = "THAY ĐỔI MẬT KHẨU";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(432, 198);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(246, 21);
            this.newpass.TabIndex = 12;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(432, 166);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(246, 21);
            this.password.TabIndex = 11;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(318, 203);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(83, 15);
            this.lbMatKhauMoi.TabIndex = 10;
            this.lbMatKhauMoi.Text = "MẬT KHẨU MỚI";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenDangNhap.Location = new System.Drawing.Point(318, 132);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(90, 15);
            this.lbTenDangNhap.TabIndex = 9;
            this.lbTenDangNhap.Text = "TÊN ĐĂNG NHẬP";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHuyThayDoi);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.lbTenDangNhap);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuyThayDoi;
        private System.Windows.Forms.Button btThayDoi;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbTenDangNhap;
    }
}