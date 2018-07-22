namespace TRACNGHIEM_DEMO1
{
	partial class frmDangNhap
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
			System.Windows.Forms.Label tENCNLabel;
			this.groupDangNhap = new System.Windows.Forms.GroupBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxTenCN = new System.Windows.Forms.ComboBox();
			this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
			this.tRACNGHIEMDataSet = new TRACNGHIEM_DEMO1.TRACNGHIEMDataSet();
			this.v_DS_PHANMANHTableAdapter = new TRACNGHIEM_DEMO1.TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxPhanQuyen = new System.Windows.Forms.ComboBox();
			tENCNLabel = new System.Windows.Forms.Label();
			this.groupDangNhap.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// tENCNLabel
			// 
			tENCNLabel.AutoSize = true;
			tENCNLabel.Location = new System.Drawing.Point(30, 52);
			tENCNLabel.Name = "tENCNLabel";
			tENCNLabel.Size = new System.Drawing.Size(91, 19);
			tENCNLabel.TabIndex = 0;
			tENCNLabel.Text = "TÊN CƠ SỞ";
			// 
			// groupDangNhap
			// 
			this.groupDangNhap.Controls.Add(this.cbxPhanQuyen);
			this.groupDangNhap.Controls.Add(this.label3);
			this.groupDangNhap.Controls.Add(this.txtPass);
			this.groupDangNhap.Controls.Add(this.txtUser);
			this.groupDangNhap.Controls.Add(this.label2);
			this.groupDangNhap.Controls.Add(this.label1);
			this.groupDangNhap.Controls.Add(tENCNLabel);
			this.groupDangNhap.Controls.Add(this.cbxTenCN);
			this.groupDangNhap.Location = new System.Drawing.Point(32, 22);
			this.groupDangNhap.Name = "groupDangNhap";
			this.groupDangNhap.Size = new System.Drawing.Size(641, 236);
			this.groupDangNhap.TabIndex = 0;
			this.groupDangNhap.TabStop = false;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(372, 183);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(223, 26);
			this.txtPass.TabIndex = 4;
			this.txtPass.Text = "pt";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(144, 183);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(217, 26);
			this.txtUser.TabIndex = 4;
			this.txtUser.Text = "THIEN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(368, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật Khẩu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(140, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tài Khoản";
			// 
			// cbxTenCN
			// 
			this.cbxTenCN.DataSource = this.bdsDSPM;
			this.cbxTenCN.DisplayMember = "TENCN";
			this.cbxTenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenCN.FormattingEnabled = true;
			this.cbxTenCN.Location = new System.Drawing.Point(144, 52);
			this.cbxTenCN.Name = "cbxTenCN";
			this.cbxTenCN.Size = new System.Drawing.Size(451, 27);
			this.cbxTenCN.TabIndex = 1;
			this.cbxTenCN.ValueMember = "TENSERVER";
			this.cbxTenCN.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_SelectedIndexChanged);
			// 
			// bdsDSPM
			// 
			this.bdsDSPM.DataMember = "V_DS_PHANMANH";
			this.bdsDSPM.DataSource = this.tRACNGHIEMDataSet;
			// 
			// tRACNGHIEMDataSet
			// 
			this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
			this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// v_DS_PHANMANHTableAdapter
			// 
			this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// btnOK
			// 
			this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOK.Location = new System.Drawing.Point(176, 264);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(112, 51);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(383, 264);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(112, 51);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Tạo lại";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(561, 264);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(112, 51);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(311, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Phân Quyền ";
			// 
			// cbxPhanQuyen
			// 
			this.cbxPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxPhanQuyen.FormattingEnabled = true;
			this.cbxPhanQuyen.Items.AddRange(new object[] {
            "GIAOVIEN",
            "SINHVIEN"});
			this.cbxPhanQuyen.Location = new System.Drawing.Point(204, 116);
			this.cbxPhanQuyen.Name = "cbxPhanQuyen";
			this.cbxPhanQuyen.Size = new System.Drawing.Size(316, 27);
			this.cbxPhanQuyen.TabIndex = 6;
			this.cbxPhanQuyen.SelectedIndexChanged += new System.EventHandler(this.cbxPhanQuyen_SelectedIndexChanged);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 359);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupDangNhap);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnOK);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDangNhap";
			this.Text = "frmDangNhap";
			this.Load += new System.EventHandler(this.frmDangNhap_Load);
			this.groupDangNhap.ResumeLayout(false);
			this.groupDangNhap.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupDangNhap;
		private TRACNGHIEMDataSet tRACNGHIEMDataSet;
		private System.Windows.Forms.BindingSource bdsDSPM;
		private TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
		private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ComboBox cbxTenCN;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.ComboBox cbxPhanQuyen;
		private System.Windows.Forms.Label label3;
	}
}