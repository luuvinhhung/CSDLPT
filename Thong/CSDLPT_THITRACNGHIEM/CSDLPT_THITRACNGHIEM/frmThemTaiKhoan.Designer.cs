namespace CSDLPT_THITRACNGHIEM
{
    partial class frmThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.radioButtonSinhVien = new System.Windows.Forms.RadioButton();
            this.radioButtonTruong = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.radioButtonGiangVien = new System.Windows.Forms.RadioButton();
            this.radioButtonCoSo = new System.Windows.Forms.RadioButton();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.comboBoxDSChuaCoTaiKhoan = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.radioButtonSinhVien);
            this.groupBox1.Controls.Add(this.radioButtonTruong);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.radioButtonGiangVien);
            this.groupBox1.Controls.Add(this.radioButtonCoSo);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.comboBoxDSChuaCoTaiKhoan);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 320);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btHuy
            // 
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.Location = new System.Drawing.Point(522, 278);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(87, 23);
            this.btHuy.TabIndex = 17;
            this.btHuy.Text = "HỦY THÊM";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(324, 278);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(123, 23);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "THÊM TÀI KHOẢN";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // radioButtonSinhVien
            // 
            this.radioButtonSinhVien.AutoSize = true;
            this.radioButtonSinhVien.Location = new System.Drawing.Point(522, 51);
            this.radioButtonSinhVien.Name = "radioButtonSinhVien";
            this.radioButtonSinhVien.Size = new System.Drawing.Size(75, 17);
            this.radioButtonSinhVien.TabIndex = 15;
            this.radioButtonSinhVien.TabStop = true;
            this.radioButtonSinhVien.Text = "SINH VIÊN";
            this.radioButtonSinhVien.UseVisualStyleBackColor = true;
            this.radioButtonSinhVien.CheckedChanged += new System.EventHandler(this.radioButtonSinhVien_CheckedChanged);
            // 
            // radioButtonTruong
            // 
            this.radioButtonTruong.AutoSize = true;
            this.radioButtonTruong.Location = new System.Drawing.Point(335, 14);
            this.radioButtonTruong.Name = "radioButtonTruong";
            this.radioButtonTruong.Size = new System.Drawing.Size(68, 17);
            this.radioButtonTruong.TabIndex = 14;
            this.radioButtonTruong.TabStop = true;
            this.radioButtonTruong.Text = "TRƯỜNG";
            this.radioButtonTruong.UseVisualStyleBackColor = true;
            this.radioButtonTruong.CheckedChanged += new System.EventHandler(this.radioButtonTruong_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(324, 219);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(285, 21);
            this.txtPass.TabIndex = 5;
            // 
            // radioButtonGiangVien
            // 
            this.radioButtonGiangVien.AutoSize = true;
            this.radioButtonGiangVien.Location = new System.Drawing.Point(335, 51);
            this.radioButtonGiangVien.Name = "radioButtonGiangVien";
            this.radioButtonGiangVien.Size = new System.Drawing.Size(83, 17);
            this.radioButtonGiangVien.TabIndex = 0;
            this.radioButtonGiangVien.TabStop = true;
            this.radioButtonGiangVien.Text = "GIẢNG VIÊN";
            this.radioButtonGiangVien.UseVisualStyleBackColor = true;
            this.radioButtonGiangVien.CheckedChanged += new System.EventHandler(this.radioButtonGiangVien_CheckedChanged);
            // 
            // radioButtonCoSo
            // 
            this.radioButtonCoSo.AutoSize = true;
            this.radioButtonCoSo.Location = new System.Drawing.Point(522, 14);
            this.radioButtonCoSo.Name = "radioButtonCoSo";
            this.radioButtonCoSo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCoSo.TabIndex = 1;
            this.radioButtonCoSo.TabStop = true;
            this.radioButtonCoSo.Text = "CƠ SỞ";
            this.radioButtonCoSo.UseVisualStyleBackColor = true;
            this.radioButtonCoSo.CheckedChanged += new System.EventHandler(this.radioButtonCoSo_CheckedChanged);
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Location = new System.Drawing.Point(324, 128);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.ReadOnly = true;
            this.txtTenTK.Size = new System.Drawing.Size(285, 21);
            this.txtTenTK.TabIndex = 3;
            // 
            // comboBoxDSChuaCoTaiKhoan
            // 
            this.comboBoxDSChuaCoTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDSChuaCoTaiKhoan.FormattingEnabled = true;
            this.comboBoxDSChuaCoTaiKhoan.Location = new System.Drawing.Point(324, 88);
            this.comboBoxDSChuaCoTaiKhoan.Name = "comboBoxDSChuaCoTaiKhoan";
            this.comboBoxDSChuaCoTaiKhoan.Size = new System.Drawing.Size(285, 21);
            this.comboBoxDSChuaCoTaiKhoan.TabIndex = 13;
            this.comboBoxDSChuaCoTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.comboBoxDSChuaCoTaiKhoan_SelectedIndexChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(324, 170);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(285, 21);
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "MẬT KHẨU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TÊN TÀI KHOẢN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHỌN QUYỀN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DANH SÁCH CHƯA CÓ TÀI KHOẢN";
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 452);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemTaiKhoan";
            this.Text = "frmThemTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThemTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSinhVien;
        private System.Windows.Forms.RadioButton radioButtonTruong;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton radioButtonGiangVien;
        private System.Windows.Forms.RadioButton radioButtonCoSo;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.ComboBox comboBoxDSChuaCoTaiKhoan;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btThem;
    }
}