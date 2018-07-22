namespace TRACNGHIEM_DEMO1
{
	partial class frmThi
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
			this.grbThongTin = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoCau = new System.Windows.Forms.TextBox();
			this.txtTrinhDo = new System.Windows.Forms.TextBox();
			this.txtLanThi = new System.Windows.Forms.TextBox();
			this.txtMonHoc = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.grbNopBai = new System.Windows.Forms.GroupBox();
			this.lbThoiGian1 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnNopBai = new System.Windows.Forms.Button();
			this.grbTungCau = new System.Windows.Forms.GroupBox();
			this.btnKeTiep = new System.Windows.Forms.Button();
			this.btnCauTruoc = new System.Windows.Forms.Button();
			this.btnD = new System.Windows.Forms.RadioButton();
			this.btnC = new System.Windows.Forms.RadioButton();
			this.btnB = new System.Windows.Forms.RadioButton();
			this.btnA = new System.Windows.Forms.RadioButton();
			this.txtCauD = new System.Windows.Forms.Label();
			this.txtCauC = new System.Windows.Forms.Label();
			this.txtCauB = new System.Windows.Forms.Label();
			this.txtCauA = new System.Windows.Forms.Label();
			this.labelCau = new System.Windows.Forms.Label();
			this.txtCauHoi = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnBatDau = new System.Windows.Forms.Button();
			this.cbxNgay = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxTrinhDo = new System.Windows.Forms.ComboBox();
			this.cbxLanThi = new System.Windows.Forms.ComboBox();
			this.cbxMonHoc = new System.Windows.Forms.ComboBox();
			this.dS1 = new TRACNGHIEM_DEMO1.DS();
			this.bdsGV_DK = new System.Windows.Forms.BindingSource(this.components);
			this.gIAOVIEN_DANGKYTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grbThongTin.SuspendLayout();
			this.grbNopBai.SuspendLayout();
			this.grbTungCau.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsGV_DK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// grbThongTin
			// 
			this.grbThongTin.Controls.Add(this.label5);
			this.grbThongTin.Controls.Add(this.label4);
			this.grbThongTin.Controls.Add(this.label3);
			this.grbThongTin.Controls.Add(this.label2);
			this.grbThongTin.Controls.Add(this.label1);
			this.grbThongTin.Controls.Add(this.txtSoCau);
			this.grbThongTin.Controls.Add(this.txtTrinhDo);
			this.grbThongTin.Controls.Add(this.txtLanThi);
			this.grbThongTin.Controls.Add(this.txtMonHoc);
			this.grbThongTin.Controls.Add(this.txtTen);
			this.grbThongTin.Location = new System.Drawing.Point(815, 13);
			this.grbThongTin.Name = "grbThongTin";
			this.grbThongTin.Size = new System.Drawing.Size(299, 313);
			this.grbThongTin.TabIndex = 0;
			this.grbThongTin.TabStop = false;
			this.grbThongTin.Text = "Thông Tin";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 19);
			this.label5.TabIndex = 1;
			this.label5.Text = "Số Câu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 19);
			this.label4.TabIndex = 1;
			this.label4.Text = "Trình Độ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "Lần Thi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Môn Học";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên";
			// 
			// txtSoCau
			// 
			this.txtSoCau.Location = new System.Drawing.Point(109, 231);
			this.txtSoCau.Name = "txtSoCau";
			this.txtSoCau.Size = new System.Drawing.Size(184, 26);
			this.txtSoCau.TabIndex = 0;
			// 
			// txtTrinhDo
			// 
			this.txtTrinhDo.Location = new System.Drawing.Point(109, 187);
			this.txtTrinhDo.Name = "txtTrinhDo";
			this.txtTrinhDo.Size = new System.Drawing.Size(184, 26);
			this.txtTrinhDo.TabIndex = 0;
			// 
			// txtLanThi
			// 
			this.txtLanThi.Location = new System.Drawing.Point(109, 137);
			this.txtLanThi.Name = "txtLanThi";
			this.txtLanThi.Size = new System.Drawing.Size(184, 26);
			this.txtLanThi.TabIndex = 0;
			// 
			// txtMonHoc
			// 
			this.txtMonHoc.Location = new System.Drawing.Point(109, 86);
			this.txtMonHoc.Name = "txtMonHoc";
			this.txtMonHoc.Size = new System.Drawing.Size(184, 26);
			this.txtMonHoc.TabIndex = 0;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(109, 36);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(184, 26);
			this.txtTen.TabIndex = 0;
			// 
			// grbNopBai
			// 
			this.grbNopBai.Controls.Add(this.lbThoiGian1);
			this.grbNopBai.Controls.Add(this.label12);
			this.grbNopBai.Controls.Add(this.btnNopBai);
			this.grbNopBai.Location = new System.Drawing.Point(821, 326);
			this.grbNopBai.Name = "grbNopBai";
			this.grbNopBai.Size = new System.Drawing.Size(299, 187);
			this.grbNopBai.TabIndex = 1;
			this.grbNopBai.TabStop = false;
			this.grbNopBai.Text = "Kết Thúc";
			// 
			// lbThoiGian1
			// 
			this.lbThoiGian1.AutoSize = true;
			this.lbThoiGian1.Location = new System.Drawing.Point(141, 124);
			this.lbThoiGian1.Name = "lbThoiGian1";
			this.lbThoiGian1.Size = new System.Drawing.Size(17, 19);
			this.lbThoiGian1.TabIndex = 1;
			this.lbThoiGian1.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(27, 124);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(68, 19);
			this.label12.TabIndex = 1;
			this.label12.Text = "Thời Gian";
			// 
			// btnNopBai
			// 
			this.btnNopBai.Location = new System.Drawing.Point(109, 48);
			this.btnNopBai.Name = "btnNopBai";
			this.btnNopBai.Size = new System.Drawing.Size(136, 36);
			this.btnNopBai.TabIndex = 0;
			this.btnNopBai.Text = "Nộp Bài";
			this.btnNopBai.UseVisualStyleBackColor = true;
			this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
			// 
			// grbTungCau
			// 
			this.grbTungCau.Controls.Add(this.btnKeTiep);
			this.grbTungCau.Controls.Add(this.btnCauTruoc);
			this.grbTungCau.Controls.Add(this.btnD);
			this.grbTungCau.Controls.Add(this.btnC);
			this.grbTungCau.Controls.Add(this.btnB);
			this.grbTungCau.Controls.Add(this.btnA);
			this.grbTungCau.Controls.Add(this.txtCauD);
			this.grbTungCau.Controls.Add(this.txtCauC);
			this.grbTungCau.Controls.Add(this.txtCauB);
			this.grbTungCau.Controls.Add(this.txtCauA);
			this.grbTungCau.Controls.Add(this.labelCau);
			this.grbTungCau.Controls.Add(this.txtCauHoi);
			this.grbTungCau.Location = new System.Drawing.Point(274, 25);
			this.grbTungCau.Name = "grbTungCau";
			this.grbTungCau.Size = new System.Drawing.Size(519, 488);
			this.grbTungCau.TabIndex = 3;
			this.grbTungCau.TabStop = false;
			this.grbTungCau.Text = "Câu Hỏi";
			// 
			// btnKeTiep
			// 
			this.btnKeTiep.Location = new System.Drawing.Point(373, 425);
			this.btnKeTiep.Name = "btnKeTiep";
			this.btnKeTiep.Size = new System.Drawing.Size(132, 37);
			this.btnKeTiep.TabIndex = 4;
			this.btnKeTiep.Text = "Kế Tiếp";
			this.btnKeTiep.UseVisualStyleBackColor = true;
			this.btnKeTiep.Click += new System.EventHandler(this.btnKeTiep_Click);
			// 
			// btnCauTruoc
			// 
			this.btnCauTruoc.Location = new System.Drawing.Point(124, 425);
			this.btnCauTruoc.Name = "btnCauTruoc";
			this.btnCauTruoc.Size = new System.Drawing.Size(132, 37);
			this.btnCauTruoc.TabIndex = 4;
			this.btnCauTruoc.Text = "Câu Trước";
			this.btnCauTruoc.UseVisualStyleBackColor = true;
			this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
			// 
			// btnD
			// 
			this.btnD.AutoSize = true;
			this.btnD.Location = new System.Drawing.Point(10, 373);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(38, 23);
			this.btnD.TabIndex = 3;
			this.btnD.TabStop = true;
			this.btnD.Text = "D";
			this.btnD.UseVisualStyleBackColor = true;
			this.btnD.CheckedChanged += new System.EventHandler(this.btnD_CheckedChanged);
			// 
			// btnC
			// 
			this.btnC.AutoSize = true;
			this.btnC.Location = new System.Drawing.Point(10, 312);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(38, 23);
			this.btnC.TabIndex = 3;
			this.btnC.TabStop = true;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.CheckedChanged += new System.EventHandler(this.btnC_CheckedChanged);
			// 
			// btnB
			// 
			this.btnB.AutoSize = true;
			this.btnB.Location = new System.Drawing.Point(10, 258);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(37, 23);
			this.btnB.TabIndex = 3;
			this.btnB.TabStop = true;
			this.btnB.Text = "B";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.CheckedChanged += new System.EventHandler(this.btnB_CheckedChanged);
			// 
			// btnA
			// 
			this.btnA.AutoSize = true;
			this.btnA.Location = new System.Drawing.Point(10, 200);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(38, 23);
			this.btnA.TabIndex = 3;
			this.btnA.TabStop = true;
			this.btnA.Text = "A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.CheckedChanged += new System.EventHandler(this.btnA_CheckedChanged);
			// 
			// txtCauD
			// 
			this.txtCauD.Location = new System.Drawing.Point(76, 375);
			this.txtCauD.Name = "txtCauD";
			this.txtCauD.Size = new System.Drawing.Size(486, 38);
			this.txtCauD.TabIndex = 2;
			this.txtCauD.Text = "label6";
			// 
			// txtCauC
			// 
			this.txtCauC.Location = new System.Drawing.Point(76, 314);
			this.txtCauC.Name = "txtCauC";
			this.txtCauC.Size = new System.Drawing.Size(486, 38);
			this.txtCauC.TabIndex = 2;
			this.txtCauC.Text = "label6";
			// 
			// txtCauB
			// 
			this.txtCauB.Location = new System.Drawing.Point(76, 260);
			this.txtCauB.Name = "txtCauB";
			this.txtCauB.Size = new System.Drawing.Size(486, 38);
			this.txtCauB.TabIndex = 2;
			this.txtCauB.Text = "label6";
			// 
			// txtCauA
			// 
			this.txtCauA.Location = new System.Drawing.Point(76, 202);
			this.txtCauA.Name = "txtCauA";
			this.txtCauA.Size = new System.Drawing.Size(486, 32);
			this.txtCauA.TabIndex = 2;
			this.txtCauA.Text = "label6";
			// 
			// labelCau
			// 
			this.labelCau.AutoSize = true;
			this.labelCau.Location = new System.Drawing.Point(6, 48);
			this.labelCau.Name = "labelCau";
			this.labelCau.Size = new System.Drawing.Size(42, 19);
			this.labelCau.TabIndex = 1;
			this.labelCau.Text = "CÂU";
			// 
			// txtCauHoi
			// 
			this.txtCauHoi.Location = new System.Drawing.Point(76, 39);
			this.txtCauHoi.Name = "txtCauHoi";
			this.txtCauHoi.Size = new System.Drawing.Size(466, 112);
			this.txtCauHoi.TabIndex = 0;
			this.txtCauHoi.Text = "label6";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.btnBatDau);
			this.groupBox1.Controls.Add(this.cbxNgay);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cbxTrinhDo);
			this.groupBox1.Controls.Add(this.cbxLanThi);
			this.groupBox1.Controls.Add(this.cbxMonHoc);
			this.groupBox1.Location = new System.Drawing.Point(70, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(645, 555);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Bắt Buộc";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(20, 349);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(542, 71);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lưu Ý";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(34, 41);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(232, 19);
			this.label11.TabIndex = 1;
			this.label11.Text = "2. Nhấn nút Bắt  đầu để Làm Bài Thi";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(25, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(405, 19);
			this.label10.TabIndex = 0;
			this.label10.Text = "1.Nhập các thông tin ở trên là Bắt Buộc .. Không  được bỏ trống.";
			// 
			// btnBatDau
			// 
			this.btnBatDau.Location = new System.Drawing.Point(294, 288);
			this.btnBatDau.Name = "btnBatDau";
			this.btnBatDau.Size = new System.Drawing.Size(113, 36);
			this.btnBatDau.TabIndex = 3;
			this.btnBatDau.Text = "Bắt Đầu Thi";
			this.btnBatDau.UseVisualStyleBackColor = true;
			this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
			// 
			// cbxNgay
			// 
			this.cbxNgay.Location = new System.Drawing.Point(231, 233);
			this.cbxNgay.Name = "cbxNgay";
			this.cbxNgay.Size = new System.Drawing.Size(248, 26);
			this.cbxNgay.TabIndex = 2;
			this.cbxNgay.ValueChanged += new System.EventHandler(this.cbxNgay_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(76, 235);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 19);
			this.label9.TabIndex = 1;
			this.label9.Text = "Ngày Thi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(76, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 19);
			this.label8.TabIndex = 1;
			this.label8.Text = "Lần Thi";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(76, 163);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 19);
			this.label7.TabIndex = 1;
			this.label7.Text = "Trình Độ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(80, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 19);
			this.label6.TabIndex = 1;
			this.label6.Text = "Môn Học";
			// 
			// cbxTrinhDo
			// 
			this.cbxTrinhDo.FormattingEnabled = true;
			this.cbxTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
			this.cbxTrinhDo.Location = new System.Drawing.Point(231, 163);
			this.cbxTrinhDo.Name = "cbxTrinhDo";
			this.cbxTrinhDo.Size = new System.Drawing.Size(248, 27);
			this.cbxTrinhDo.TabIndex = 0;
			this.cbxTrinhDo.SelectedIndexChanged += new System.EventHandler(this.cbxTrinhDo_SelectedIndexChanged);
			// 
			// cbxLanThi
			// 
			this.cbxLanThi.FormattingEnabled = true;
			this.cbxLanThi.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
			this.cbxLanThi.Location = new System.Drawing.Point(231, 91);
			this.cbxLanThi.Name = "cbxLanThi";
			this.cbxLanThi.Size = new System.Drawing.Size(248, 27);
			this.cbxLanThi.TabIndex = 0;
			this.cbxLanThi.SelectedIndexChanged += new System.EventHandler(this.cbxLanThi_SelectedIndexChanged);
			// 
			// cbxMonHoc
			// 
			this.cbxMonHoc.FormattingEnabled = true;
			this.cbxMonHoc.Location = new System.Drawing.Point(231, 39);
			this.cbxMonHoc.Name = "cbxMonHoc";
			this.cbxMonHoc.Size = new System.Drawing.Size(248, 27);
			this.cbxMonHoc.TabIndex = 0;
			// 
			// dS1
			// 
			this.dS1.DataSetName = "DS";
			this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsGV_DK
			// 
			this.bdsGV_DK.DataMember = "GIAOVIEN_DANGKY";
			this.bdsGV_DK.DataSource = this.dS1;
			// 
			// gIAOVIEN_DANGKYTableAdapter
			// 
			this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BANGDIEMTableAdapter = null;
			this.tableAdapterManager.BODETableAdapter = null;
			this.tableAdapterManager.COSOTableAdapter = null;
			this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
			this.tableAdapterManager.GIAOVIENTableAdapter = null;
			this.tableAdapterManager.KHOATableAdapter = null;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(0, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 505);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "CÂU HỎI";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "ĐÁP ÁN";
			this.Column2.Name = "Column2";
			// 
			// frmThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1126, 567);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbTungCau);
			this.Controls.Add(this.grbNopBai);
			this.Controls.Add(this.grbThongTin);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmThi";
			this.Text = "frmThi";
			this.Load += new System.EventHandler(this.frmThi_Load);
			this.grbThongTin.ResumeLayout(false);
			this.grbThongTin.PerformLayout();
			this.grbNopBai.ResumeLayout(false);
			this.grbNopBai.PerformLayout();
			this.grbTungCau.ResumeLayout(false);
			this.grbTungCau.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsGV_DK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbThongTin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSoCau;
		private System.Windows.Forms.TextBox txtTrinhDo;
		private System.Windows.Forms.TextBox txtLanThi;
		private System.Windows.Forms.TextBox txtMonHoc;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.GroupBox grbNopBai;
		private System.Windows.Forms.Button btnNopBai;
		private System.Windows.Forms.GroupBox grbTungCau;
		private System.Windows.Forms.Button btnKeTiep;
		private System.Windows.Forms.Button btnCauTruoc;
		private System.Windows.Forms.RadioButton btnD;
		private System.Windows.Forms.RadioButton btnC;
		private System.Windows.Forms.RadioButton btnB;
		private System.Windows.Forms.RadioButton btnA;
		private System.Windows.Forms.Label txtCauD;
		private System.Windows.Forms.Label txtCauC;
		private System.Windows.Forms.Label txtCauB;
		private System.Windows.Forms.Label txtCauA;
		private System.Windows.Forms.Label labelCau;
		private System.Windows.Forms.Label txtCauHoi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnBatDau;
		private System.Windows.Forms.DateTimePicker cbxNgay;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxTrinhDo;
		private System.Windows.Forms.ComboBox cbxLanThi;
		private System.Windows.Forms.ComboBox cbxMonHoc;
		private DS dS1;
		private System.Windows.Forms.BindingSource bdsGV_DK;
		private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.Label lbThoiGian1;
		private System.Windows.Forms.Label label12;
	}
}