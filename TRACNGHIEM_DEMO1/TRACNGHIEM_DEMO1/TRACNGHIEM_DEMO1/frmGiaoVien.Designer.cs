namespace TRACNGHIEM_DEMO1
{
	partial class frmGiaoVien
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
			System.Windows.Forms.Label mAGVLabel;
			System.Windows.Forms.Label hOLabel;
			System.Windows.Forms.Label tENLabel;
			System.Windows.Forms.Label dIACHILabel;
			System.Windows.Forms.Label mAKHLabel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
			this.panelTenCS = new System.Windows.Forms.Panel();
			this.cbxTenChiNhanhGV = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
			this.gIAOVIENTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.GIAOVIENTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.kHOATableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.KHOATableAdapter();
			this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grbGiaoVien = new System.Windows.Forms.GroupBox();
			this.cbxMAKH = new System.Windows.Forms.ComboBox();
			this.txtDiaChiGV = new DevExpress.XtraEditors.TextEdit();
			this.txtTenGV = new DevExpress.XtraEditors.TextEdit();
			this.txtHoGV = new DevExpress.XtraEditors.TextEdit();
			this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
			this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.btnThem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnSua1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnGhi1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoa1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnUndo1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnReload1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnInDSGV = new DevExpress.XtraBars.BarButtonItem();
			this.btnTroVe = new DevExpress.XtraBars.BarButtonItem();
			mAGVLabel = new System.Windows.Forms.Label();
			hOLabel = new System.Windows.Forms.Label();
			tENLabel = new System.Windows.Forms.Label();
			dIACHILabel = new System.Windows.Forms.Label();
			mAKHLabel1 = new System.Windows.Forms.Label();
			this.panelTenCS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.grbGiaoVien.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDiaChiGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// mAGVLabel
			// 
			mAGVLabel.AutoSize = true;
			mAGVLabel.Location = new System.Drawing.Point(73, 76);
			mAGVLabel.Name = "mAGVLabel";
			mAGVLabel.Size = new System.Drawing.Size(58, 19);
			mAGVLabel.TabIndex = 0;
			mAGVLabel.Text = "MAGV:";
			// 
			// hOLabel
			// 
			hOLabel.AutoSize = true;
			hOLabel.Location = new System.Drawing.Point(358, 76);
			hOLabel.Name = "hOLabel";
			hOLabel.Size = new System.Drawing.Size(35, 19);
			hOLabel.TabIndex = 2;
			hOLabel.Text = "HO:";
			// 
			// tENLabel
			// 
			tENLabel.AutoSize = true;
			tENLabel.Location = new System.Drawing.Point(573, 76);
			tENLabel.Name = "tENLabel";
			tENLabel.Size = new System.Drawing.Size(42, 19);
			tENLabel.TabIndex = 4;
			tENLabel.Text = "TEN:";
			// 
			// dIACHILabel
			// 
			dIACHILabel.AutoSize = true;
			dIACHILabel.Location = new System.Drawing.Point(65, 142);
			dIACHILabel.Name = "dIACHILabel";
			dIACHILabel.Size = new System.Drawing.Size(66, 19);
			dIACHILabel.TabIndex = 6;
			dIACHILabel.Text = "DIACHI:";
			// 
			// mAKHLabel1
			// 
			mAKHLabel1.AutoSize = true;
			mAKHLabel1.Location = new System.Drawing.Point(620, 152);
			mAKHLabel1.Name = "mAKHLabel1";
			mAKHLabel1.Size = new System.Drawing.Size(60, 19);
			mAKHLabel1.TabIndex = 10;
			mAKHLabel1.Text = "MAKH:";
			// 
			// panelTenCS
			// 
			this.panelTenCS.Controls.Add(this.cbxTenChiNhanhGV);
			this.panelTenCS.Controls.Add(this.label1);
			this.panelTenCS.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTenCS.Location = new System.Drawing.Point(0, 40);
			this.panelTenCS.Name = "panelTenCS";
			this.panelTenCS.Size = new System.Drawing.Size(1181, 57);
			this.panelTenCS.TabIndex = 1;
			// 
			// cbxTenChiNhanhGV
			// 
			this.cbxTenChiNhanhGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenChiNhanhGV.FormattingEnabled = true;
			this.cbxTenChiNhanhGV.Location = new System.Drawing.Point(229, 16);
			this.cbxTenChiNhanhGV.Name = "cbxTenChiNhanhGV";
			this.cbxTenChiNhanhGV.Size = new System.Drawing.Size(528, 27);
			this.cbxTenChiNhanhGV.TabIndex = 1;
			this.cbxTenChiNhanhGV.SelectedIndexChanged += new System.EventHandler(this.cbxTenChiNhanhGV_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÊN CƠ SỞ ";
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsGiaoVien
			// 
			this.bdsGiaoVien.DataMember = "GIAOVIEN";
			this.bdsGiaoVien.DataSource = this.dS;
			// 
			// gIAOVIENTableAdapter
			// 
			this.gIAOVIENTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BANGDIEMTableAdapter = null;
			this.tableAdapterManager.BODETableAdapter = null;
			this.tableAdapterManager.COSOTableAdapter = null;
			this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
			this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
			this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// kHOATableAdapter
			// 
			this.kHOATableAdapter.ClearBeforeFill = true;
			// 
			// gIAOVIENGridControl
			// 
			this.gIAOVIENGridControl.DataSource = this.bdsGiaoVien;
			this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.gIAOVIENGridControl.Location = new System.Drawing.Point(0, 97);
			this.gIAOVIENGridControl.MainView = this.gridView1;
			this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
			this.gIAOVIENGridControl.Size = new System.Drawing.Size(1181, 126);
			this.gIAOVIENGridControl.TabIndex = 3;
			this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH});
			this.gridView1.GridControl = this.gIAOVIENGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMAGV
			// 
			this.colMAGV.Caption = "MÃ GIÁO VIÊN";
			this.colMAGV.FieldName = "MAGV";
			this.colMAGV.Name = "colMAGV";
			this.colMAGV.OptionsColumn.ReadOnly = true;
			this.colMAGV.Visible = true;
			this.colMAGV.VisibleIndex = 0;
			// 
			// colHO
			// 
			this.colHO.Caption = "HỌ GIÁO VIÊN";
			this.colHO.FieldName = "HO";
			this.colHO.Name = "colHO";
			this.colHO.OptionsColumn.ReadOnly = true;
			this.colHO.Visible = true;
			this.colHO.VisibleIndex = 1;
			// 
			// colTEN
			// 
			this.colTEN.Caption = "TÊN GIÁO VIÊN";
			this.colTEN.FieldName = "TEN";
			this.colTEN.Name = "colTEN";
			this.colTEN.OptionsColumn.ReadOnly = true;
			this.colTEN.Visible = true;
			this.colTEN.VisibleIndex = 2;
			// 
			// colDIACHI
			// 
			this.colDIACHI.Caption = "ĐỊA CHỈ GIÁO VIÊN";
			this.colDIACHI.FieldName = "DIACHI";
			this.colDIACHI.Name = "colDIACHI";
			this.colDIACHI.OptionsColumn.ReadOnly = true;
			this.colDIACHI.Visible = true;
			this.colDIACHI.VisibleIndex = 3;
			// 
			// colMAKH
			// 
			this.colMAKH.Caption = "MÃ KHOA";
			this.colMAKH.FieldName = "MAKH";
			this.colMAKH.Name = "colMAKH";
			this.colMAKH.OptionsColumn.ReadOnly = true;
			this.colMAKH.Visible = true;
			this.colMAKH.VisibleIndex = 4;
			// 
			// grbGiaoVien
			// 
			this.grbGiaoVien.Controls.Add(mAKHLabel1);
			this.grbGiaoVien.Controls.Add(this.cbxMAKH);
			this.grbGiaoVien.Controls.Add(dIACHILabel);
			this.grbGiaoVien.Controls.Add(this.txtDiaChiGV);
			this.grbGiaoVien.Controls.Add(tENLabel);
			this.grbGiaoVien.Controls.Add(this.txtTenGV);
			this.grbGiaoVien.Controls.Add(hOLabel);
			this.grbGiaoVien.Controls.Add(this.txtHoGV);
			this.grbGiaoVien.Controls.Add(mAGVLabel);
			this.grbGiaoVien.Controls.Add(this.txtMaGV);
			this.grbGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grbGiaoVien.Location = new System.Drawing.Point(0, 223);
			this.grbGiaoVien.Name = "grbGiaoVien";
			this.grbGiaoVien.Size = new System.Drawing.Size(1181, 280);
			this.grbGiaoVien.TabIndex = 4;
			this.grbGiaoVien.TabStop = false;
			this.grbGiaoVien.Text = "Thông Tin Giáo Viên";
			this.grbGiaoVien.Enter += new System.EventHandler(this.grbGiaoVien_Enter);
			// 
			// cbxMAKH
			// 
			this.cbxMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "MAKH", true));
			this.cbxMAKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxMAKH.FormattingEnabled = true;
			this.cbxMAKH.Location = new System.Drawing.Point(686, 149);
			this.cbxMAKH.Name = "cbxMAKH";
			this.cbxMAKH.Size = new System.Drawing.Size(240, 27);
			this.cbxMAKH.TabIndex = 11;
			this.cbxMAKH.SelectedIndexChanged += new System.EventHandler(this.cbxMAKH_SelectedIndexChanged);
			// 
			// txtDiaChiGV
			// 
			this.txtDiaChiGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "DIACHI", true));
			this.txtDiaChiGV.Location = new System.Drawing.Point(137, 139);
			this.txtDiaChiGV.Name = "txtDiaChiGV";
			this.txtDiaChiGV.Size = new System.Drawing.Size(269, 20);
			this.txtDiaChiGV.TabIndex = 7;
			// 
			// txtTenGV
			// 
			this.txtTenGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "TEN", true));
			this.txtTenGV.Location = new System.Drawing.Point(621, 73);
			this.txtTenGV.Name = "txtTenGV";
			this.txtTenGV.Size = new System.Drawing.Size(209, 20);
			this.txtTenGV.TabIndex = 5;
			// 
			// txtHoGV
			// 
			this.txtHoGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "HO", true));
			this.txtHoGV.Location = new System.Drawing.Point(399, 73);
			this.txtHoGV.Name = "txtHoGV";
			this.txtHoGV.Size = new System.Drawing.Size(163, 20);
			this.txtHoGV.TabIndex = 3;
			// 
			// txtMaGV
			// 
			this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAGV", true));
			this.txtMaGV.Location = new System.Drawing.Point(137, 73);
			this.txtMaGV.Name = "txtMaGV";
			this.txtMaGV.Size = new System.Drawing.Size(181, 20);
			this.txtMaGV.TabIndex = 1;
			// 
			// bdsKhoa
			// 
			this.bdsKhoa.DataMember = "KHOA";
			this.bdsKhoa.DataSource = this.dS;
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem1,
            this.btnSua1,
            this.btnGhi1,
            this.btnXoa1,
            this.btnUndo1,
            this.btnReload1,
            this.btnInDSGV,
            this.btnTroVe});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 8;
			this.barManager1.StatusBar = this.bar3;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1181, 40);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1181, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 463);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1181, 40);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 463);
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSGV, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTroVe, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// btnThem1
			// 
			this.btnThem1.Caption = "Thêm";
			this.btnThem1.Id = 0;
			this.btnThem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
			this.btnThem1.Name = "btnThem1";
			this.btnThem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem1_ItemClick);
			// 
			// btnSua1
			// 
			this.btnSua1.Caption = "Sữa";
			this.btnSua1.Id = 1;
			this.btnSua1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
			this.btnSua1.Name = "btnSua1";
			this.btnSua1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua1_ItemClick);
			// 
			// btnGhi1
			// 
			this.btnGhi1.Caption = "Ghi";
			this.btnGhi1.Id = 2;
			this.btnGhi1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
			this.btnGhi1.Name = "btnGhi1";
			this.btnGhi1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi1_ItemClick);
			// 
			// btnXoa1
			// 
			this.btnXoa1.Caption = "Xóa";
			this.btnXoa1.Id = 3;
			this.btnXoa1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
			this.btnXoa1.Name = "btnXoa1";
			this.btnXoa1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa1_ItemClick);
			// 
			// btnUndo1
			// 
			this.btnUndo1.Caption = "Undo";
			this.btnUndo1.Id = 4;
			this.btnUndo1.ImageOptions.Image = global::TRACNGHIEM_DEMO1.Properties.Resources.Undo_icon_24;
			this.btnUndo1.Name = "btnUndo1";
			this.btnUndo1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo1_ItemClick);
			// 
			// btnReload1
			// 
			this.btnReload1.Caption = "Reload";
			this.btnReload1.Id = 5;
			this.btnReload1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
			this.btnReload1.Name = "btnReload1";
			this.btnReload1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload1_ItemClick);
			// 
			// btnInDSGV
			// 
			this.btnInDSGV.Caption = "In DS Giáo Viên";
			this.btnInDSGV.Id = 6;
			this.btnInDSGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
			this.btnInDSGV.Name = "btnInDSGV";
			// 
			// btnTroVe
			// 
			this.btnTroVe.Caption = "Trở Về";
			this.btnTroVe.Id = 7;
			this.btnTroVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroVe_ItemClick);
			// 
			// frmGiaoVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 526);
			this.Controls.Add(this.grbGiaoVien);
			this.Controls.Add(this.gIAOVIENGridControl);
			this.Controls.Add(this.panelTenCS);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmGiaoVien";
			this.Text = "frmGiaoVien";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmGiaoVien_Load);
			this.panelTenCS.ResumeLayout(false);
			this.panelTenCS.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.grbGiaoVien.ResumeLayout(false);
			this.grbGiaoVien.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDiaChiGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelTenCS;
		private System.Windows.Forms.ComboBox cbxTenChiNhanhGV;
		private System.Windows.Forms.Label label1;
		private DS dS;
		private System.Windows.Forms.BindingSource bdsGiaoVien;
		private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
		private DevExpress.XtraGrid.Columns.GridColumn colHO;
		private DevExpress.XtraGrid.Columns.GridColumn colTEN;
		private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
		private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
		private System.Windows.Forms.GroupBox grbGiaoVien;
		private DevExpress.XtraEditors.TextEdit txtDiaChiGV;
		private DevExpress.XtraEditors.TextEdit txtTenGV;
		private DevExpress.XtraEditors.TextEdit txtHoGV;
		private DevExpress.XtraEditors.TextEdit txtMaGV;
		private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
		private System.Windows.Forms.BindingSource bdsKhoa;
		private System.Windows.Forms.ComboBox cbxMAKH;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnThem1;
		private DevExpress.XtraBars.BarButtonItem btnSua1;
		private DevExpress.XtraBars.BarButtonItem btnGhi1;
		private DevExpress.XtraBars.BarButtonItem btnXoa1;
		private DevExpress.XtraBars.BarButtonItem btnUndo1;
		private DevExpress.XtraBars.BarButtonItem btnReload1;
		private DevExpress.XtraBars.BarButtonItem btnInDSGV;
		private DevExpress.XtraBars.BarButtonItem btnTroVe;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}