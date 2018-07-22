namespace CSDLPT_THITRACNGHIEM
{
    partial class frmDangKyThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyThi));
            this.tRACNGHIEMDataSet = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSet();
            this.gIANGVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIEN_DANGKYTableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.GIANGVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.gIANGVIENTableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.GIANGVIENTableAdapter();
            this.lOPTableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.MONHOCTableAdapter();
            this.gIANGVIEN_DANGKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGIANGVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMONHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btHuyDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.btDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxThoiGianThi = new System.Windows.Forms.TextBox();
            this.textBoxSoCauThi = new System.Windows.Forms.TextBox();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            this.cbChonLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbGiangvien = new System.Windows.Forms.ComboBox();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbChonMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIEN_DANGKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIEN_DANGKYBindingSource
            // 
            this.gIANGVIEN_DANGKYBindingSource.DataMember = "GIANGVIEN_DANGKY";
            this.gIANGVIEN_DANGKYBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // gIANGVIEN_DANGKYTableAdapter
            // 
            this.gIANGVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CAUTRALOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIANGVIEN_DANGKYTableAdapter = this.gIANGVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIEN_DANGKYGridControl
            // 
            this.gIANGVIEN_DANGKYGridControl.DataSource = this.gIANGVIEN_DANGKYBindingSource;
            this.gIANGVIEN_DANGKYGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIANGVIEN_DANGKYGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIANGVIEN_DANGKYGridControl.MainView = this.gridView1;
            this.gIANGVIEN_DANGKYGridControl.Name = "gIANGVIEN_DANGKYGridControl";
            this.gIANGVIEN_DANGKYGridControl.Size = new System.Drawing.Size(840, 258);
            this.gIANGVIEN_DANGKYGridControl.TabIndex = 1;
            this.gIANGVIEN_DANGKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gIANGVIEN_DANGKYGridControl.Click += new System.EventHandler(this.gIANGVIEN_DANGKYGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGIANGVIEN,
            this.colMAMONHOC,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.gIANGVIEN_DANGKYGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMAGIANGVIEN
            // 
            this.colMAGIANGVIEN.FieldName = "MAGIANGVIEN";
            this.colMAGIANGVIEN.Name = "colMAGIANGVIEN";
            this.colMAGIANGVIEN.Visible = true;
            this.colMAGIANGVIEN.VisibleIndex = 0;
            // 
            // colMAMONHOC
            // 
            this.colMAMONHOC.FieldName = "MAMONHOC";
            this.colMAMONHOC.Name = "colMAMONHOC";
            this.colMAMONHOC.Visible = true;
            this.colMAMONHOC.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btHuyDangKy);
            this.groupBox1.Controls.Add(this.btDangKy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.textBoxThoiGianThi);
            this.groupBox1.Controls.Add(this.textBoxSoCauThi);
            this.groupBox1.Controls.Add(this.cbLanThi);
            this.groupBox1.Controls.Add(this.cbChonLop);
            this.groupBox1.Controls.Add(this.cbGiangvien);
            this.groupBox1.Controls.Add(this.cbTrinhDo);
            this.groupBox1.Controls.Add(this.cbChonMH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btHuyDangKy
            // 
            this.btHuyDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btHuyDangKy.Image")));
            this.btHuyDangKy.Location = new System.Drawing.Point(624, 202);
            this.btHuyDangKy.Name = "btHuyDangKy";
            this.btHuyDangKy.Size = new System.Drawing.Size(115, 23);
            this.btHuyDangKy.TabIndex = 19;
            this.btHuyDangKy.Text = "HỦY ĐĂNG KÝ";
            // 
            // btDangKy
            // 
            this.btDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btDangKy.Image")));
            this.btDangKy.Location = new System.Drawing.Point(292, 202);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(114, 23);
            this.btDangKy.TabIndex = 18;
            this.btDangKy.Text = "ĐĂNG KÝ THI";
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(119, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "NGÀY THI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(119, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "SỐ CÂU THI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(520, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "TÊN LỚP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(520, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "TRÌNH ĐỘ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(520, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "LẦN THI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(520, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "THỜI GIAN THI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(119, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "GIẢNG VIÊN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(119, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "MÃ MÔN HỌC:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(206, 149);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // textBoxThoiGianThi
            // 
            this.textBoxThoiGianThi.Location = new System.Drawing.Point(606, 152);
            this.textBoxThoiGianThi.Name = "textBoxThoiGianThi";
            this.textBoxThoiGianThi.Size = new System.Drawing.Size(200, 21);
            this.textBoxThoiGianThi.TabIndex = 7;
            // 
            // textBoxSoCauThi
            // 
            this.textBoxSoCauThi.Location = new System.Drawing.Point(206, 110);
            this.textBoxSoCauThi.Name = "textBoxSoCauThi";
            this.textBoxSoCauThi.Size = new System.Drawing.Size(200, 21);
            this.textBoxSoCauThi.TabIndex = 6;
            this.textBoxSoCauThi.TextChanged += new System.EventHandler(this.textBoxSoCauThi_TextChanged);
            // 
            // cbLanThi
            // 
            this.cbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(606, 110);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(200, 21);
            this.cbLanThi.TabIndex = 5;
            this.cbLanThi.SelectedIndexChanged += new System.EventHandler(this.cbLanThi_SelectedIndexChanged);
            // 
            // cbChonLop
            // 
            this.cbChonLop.DataSource = this.lOPBindingSource;
            this.cbChonLop.DisplayMember = "TENLOP";
            this.cbChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonLop.FormattingEnabled = true;
            this.cbChonLop.Location = new System.Drawing.Point(606, 12);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(200, 21);
            this.cbChonLop.TabIndex = 4;
            this.cbChonLop.ValueMember = "MALOP";
            this.cbChonLop.SelectedIndexChanged += new System.EventHandler(this.cbChonLop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // cbGiangvien
            // 
            this.cbGiangvien.DataSource = this.gIANGVIENBindingSource;
            this.cbGiangvien.DisplayMember = "MAGIANGVIEN";
            this.cbGiangvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiangvien.FormattingEnabled = true;
            this.cbGiangvien.Location = new System.Drawing.Point(206, 12);
            this.cbGiangvien.Name = "cbGiangvien";
            this.cbGiangvien.Size = new System.Drawing.Size(200, 21);
            this.cbGiangvien.TabIndex = 1;
            this.cbGiangvien.ValueMember = "MAGIANGVIEN";
            this.cbGiangvien.SelectedIndexChanged += new System.EventHandler(this.cbGiangvien_SelectedIndexChanged);
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTrinhDo.Location = new System.Drawing.Point(606, 59);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(200, 21);
            this.cbTrinhDo.TabIndex = 2;
            this.cbTrinhDo.SelectedIndexChanged += new System.EventHandler(this.cbTrinhDo_SelectedIndexChanged);
            // 
            // cbChonMH
            // 
            this.cbChonMH.DataSource = this.mONHOCBindingSource;
            this.cbChonMH.DisplayMember = "TENMONHOC";
            this.cbChonMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonMH.FormattingEnabled = true;
            this.cbChonMH.Location = new System.Drawing.Point(206, 62);
            this.cbChonMH.Name = "cbChonMH";
            this.cbChonMH.Size = new System.Drawing.Size(200, 21);
            this.cbChonMH.TabIndex = 3;
            this.cbChonMH.ValueMember = "MAMONHOC";
            this.cbChonMH.SelectedIndexChanged += new System.EventHandler(this.cbChonMH_SelectedIndexChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxCoSo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 37);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(292, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "CƠ SỞ:";
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(381, 10);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCoSo.TabIndex = 0;
            this.comboBoxCoSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoSo_SelectedIndexChanged);
            // 
            // frmDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gIANGVIEN_DANGKYGridControl);
            this.Name = "frmDangKyThi";
            this.Text = "frmDangKyThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIEN_DANGKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource gIANGVIEN_DANGKYBindingSource;
        private TRACNGHIEMDataSetTableAdapters.GIANGVIEN_DANGKYTableAdapter gIANGVIEN_DANGKYTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANGVIEN_DANGKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGIANGVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMONHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btHuyDangKy;
        private DevExpress.XtraEditors.SimpleButton btDangKy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxThoiGianThi;
        private System.Windows.Forms.TextBox textBoxSoCauThi;
        private System.Windows.Forms.ComboBox cbLanThi;
        private System.Windows.Forms.ComboBox cbChonLop;
        private System.Windows.Forms.ComboBox cbGiangvien;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.ComboBox cbChonMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private TRACNGHIEMDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private TRACNGHIEMDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TRACNGHIEMDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
    }
}