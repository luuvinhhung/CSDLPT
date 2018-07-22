namespace TRACNGHIEM_DEMO1
{
	partial class frmTaoTaiKhoan
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
			this.grbAddLogin = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaSo = new System.Windows.Forms.TextBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnReset1 = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxQuyen = new System.Windows.Forms.ComboBox();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsCoSo = new System.Windows.Forms.BindingSource(this.components);
			this.cOSOTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.COSOTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.gIAOVIENTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.GIAOVIENTableAdapter();
			this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
			this.grbAddLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
			this.SuspendLayout();
			// 
			// grbAddLogin
			// 
			this.grbAddLogin.Controls.Add(this.label5);
			this.grbAddLogin.Controls.Add(this.txtMaSo);
			this.grbAddLogin.Controls.Add(this.btnThoat);
			this.grbAddLogin.Controls.Add(this.btnReset1);
			this.grbAddLogin.Controls.Add(this.btnOK);
			this.grbAddLogin.Controls.Add(this.label4);
			this.grbAddLogin.Controls.Add(this.label3);
			this.grbAddLogin.Controls.Add(this.label2);
			this.grbAddLogin.Controls.Add(this.txtNhapLaiMK);
			this.grbAddLogin.Controls.Add(this.txtPass);
			this.grbAddLogin.Controls.Add(this.txtTenDN);
			this.grbAddLogin.Controls.Add(this.label1);
			this.grbAddLogin.Controls.Add(this.cbxQuyen);
			this.grbAddLogin.Location = new System.Drawing.Point(114, 33);
			this.grbAddLogin.Name = "grbAddLogin";
			this.grbAddLogin.Size = new System.Drawing.Size(482, 363);
			this.grbAddLogin.TabIndex = 0;
			this.grbAddLogin.TabStop = false;
			this.grbAddLogin.Text = "Thêm Tài Khoản";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.CausesValidation = false;
			this.label5.Location = new System.Drawing.Point(21, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tên Đăng Nhập";
			// 
			// txtMaSo
			// 
			this.txtMaSo.Location = new System.Drawing.Point(165, 161);
			this.txtMaSo.Name = "txtMaSo";
			this.txtMaSo.Size = new System.Drawing.Size(295, 26);
			this.txtMaSo.TabIndex = 7;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(347, 307);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(102, 41);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnReset1
			// 
			this.btnReset1.Location = new System.Drawing.Point(191, 307);
			this.btnReset1.Name = "btnReset1";
			this.btnReset1.Size = new System.Drawing.Size(102, 41);
			this.btnReset1.TabIndex = 6;
			this.btnReset1.Text = "Reset";
			this.btnReset1.UseVisualStyleBackColor = true;
			this.btnReset1.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(55, 307);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(102, 41);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "Đồng Ý";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 19);
			this.label4.TabIndex = 5;
			this.label4.Text = "Nhập Lại Mật Khẩu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mật Khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tên Tài Khoản";
			// 
			// txtNhapLaiMK
			// 
			this.txtNhapLaiMK.Location = new System.Drawing.Point(165, 253);
			this.txtNhapLaiMK.Name = "txtNhapLaiMK";
			this.txtNhapLaiMK.Size = new System.Drawing.Size(293, 26);
			this.txtNhapLaiMK.TabIndex = 4;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(165, 209);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(293, 26);
			this.txtPass.TabIndex = 3;
			// 
			// txtTenDN
			// 
			this.txtTenDN.Location = new System.Drawing.Point(167, 107);
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(293, 26);
			this.txtTenDN.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quyền Đăng Nhập";
			// 
			// cbxQuyen
			// 
			this.cbxQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxQuyen.FormattingEnabled = true;
			this.cbxQuyen.Location = new System.Drawing.Point(167, 48);
			this.cbxQuyen.Name = "cbxQuyen";
			this.cbxQuyen.Size = new System.Drawing.Size(293, 27);
			this.cbxQuyen.TabIndex = 0;
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsCoSo
			// 
			this.bdsCoSo.DataMember = "COSO";
			this.bdsCoSo.DataSource = this.dS;
			// 
			// cOSOTableAdapter
			// 
			this.cOSOTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BANGDIEMTableAdapter = null;
			this.tableAdapterManager.BODETableAdapter = null;
			this.tableAdapterManager.COSOTableAdapter = this.cOSOTableAdapter;
			this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
			this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
			this.tableAdapterManager.KHOATableAdapter = null;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gIAOVIENTableAdapter
			// 
			this.gIAOVIENTableAdapter.ClearBeforeFill = true;
			// 
			// bdsGiaoVien
			// 
			this.bdsGiaoVien.DataMember = "GIAOVIEN";
			this.bdsGiaoVien.DataSource = this.dS;
			// 
			// frmTaoTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 578);
			this.Controls.Add(this.grbAddLogin);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmTaoTaiKhoan";
			this.Text = "frmTaoTaiKhoan";
			this.Load += new System.EventHandler(this.btnReset_Load);
			this.grbAddLogin.ResumeLayout(false);
			this.grbAddLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbAddLogin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaSo;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnReset1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNhapLaiMK;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxQuyen;
		private DS dS;
		private System.Windows.Forms.BindingSource bdsCoSo;
		private DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
		private System.Windows.Forms.BindingSource bdsGiaoVien;
	}
}