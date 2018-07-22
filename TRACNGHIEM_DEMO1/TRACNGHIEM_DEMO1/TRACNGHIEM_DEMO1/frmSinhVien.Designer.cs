namespace TRACNGHIEM_DEMO1
{
	partial class frmSinhVien
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
			System.Windows.Forms.Label mASVLabel;
			System.Windows.Forms.Label hOLabel;
			System.Windows.Forms.Label tENLabel;
			System.Windows.Forms.Label nGAYSINHLabel;
			System.Windows.Forms.Label dIACHILabel;
			System.Windows.Forms.Label mALOPLabel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.btnThem = new DevExpress.XtraBars.BarButtonItem();
			this.btnSua = new DevExpress.XtraBars.BarButtonItem();
			this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
			this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
			this.btnReload = new DevExpress.XtraBars.BarButtonItem();
			this.btnInDSSV = new DevExpress.XtraBars.BarButtonItem();
			this.btnTroVe = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.panelTenCS = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxTenCoSo = new System.Windows.Forms.ComboBox();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
			this.sINHVIENTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.SINHVIENTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grbSinhVien = new System.Windows.Forms.GroupBox();
			this.cbxMaLop = new System.Windows.Forms.ComboBox();
			this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
			this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
			this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
			this.txtHoSV = new DevExpress.XtraEditors.TextEdit();
			this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
			mASVLabel = new System.Windows.Forms.Label();
			hOLabel = new System.Windows.Forms.Label();
			tENLabel = new System.Windows.Forms.Label();
			nGAYSINHLabel = new System.Windows.Forms.Label();
			dIACHILabel = new System.Windows.Forms.Label();
			mALOPLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.panelTenCS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.grbSinhVien.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// mASVLabel
			// 
			mASVLabel.AutoSize = true;
			mASVLabel.Location = new System.Drawing.Point(70, 37);
			mASVLabel.Name = "mASVLabel";
			mASVLabel.Size = new System.Drawing.Size(56, 19);
			mASVLabel.TabIndex = 0;
			mASVLabel.Text = "MASV:";
			// 
			// hOLabel
			// 
			hOLabel.AutoSize = true;
			hOLabel.Location = new System.Drawing.Point(91, 78);
			hOLabel.Name = "hOLabel";
			hOLabel.Size = new System.Drawing.Size(35, 19);
			hOLabel.TabIndex = 2;
			hOLabel.Text = "HO:";
			// 
			// tENLabel
			// 
			tENLabel.AutoSize = true;
			tENLabel.Location = new System.Drawing.Point(84, 122);
			tENLabel.Name = "tENLabel";
			tENLabel.Size = new System.Drawing.Size(42, 19);
			tENLabel.TabIndex = 4;
			tENLabel.Text = "TEN:";
			// 
			// nGAYSINHLabel
			// 
			nGAYSINHLabel.AutoSize = true;
			nGAYSINHLabel.Location = new System.Drawing.Point(448, 41);
			nGAYSINHLabel.Name = "nGAYSINHLabel";
			nGAYSINHLabel.Size = new System.Drawing.Size(93, 19);
			nGAYSINHLabel.TabIndex = 6;
			nGAYSINHLabel.Text = "NGAYSINH:";
			// 
			// dIACHILabel
			// 
			dIACHILabel.AutoSize = true;
			dIACHILabel.Location = new System.Drawing.Point(475, 90);
			dIACHILabel.Name = "dIACHILabel";
			dIACHILabel.Size = new System.Drawing.Size(66, 19);
			dIACHILabel.TabIndex = 8;
			dIACHILabel.Text = "DIACHI:";
			// 
			// mALOPLabel1
			// 
			mALOPLabel1.AutoSize = true;
			mALOPLabel1.Location = new System.Drawing.Point(474, 125);
			mALOPLabel1.Name = "mALOPLabel1";
			mALOPLabel1.Size = new System.Drawing.Size(67, 19);
			mALOPLabel1.TabIndex = 11;
			mALOPLabel1.Text = "MALOP:";
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
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.btnInDSSV,
            this.btnTroVe});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 8;
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTroVe, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// btnThem
			// 
			this.btnThem.Caption = "Thêm";
			this.btnThem.Id = 0;
			this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
			this.btnThem.Name = "btnThem";
			this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
			// 
			// btnSua
			// 
			this.btnSua.Caption = "Sữa";
			this.btnSua.Id = 1;
			this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
			this.btnSua.Name = "btnSua";
			this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
			// 
			// btnGhi
			// 
			this.btnGhi.Caption = "Ghi";
			this.btnGhi.Id = 2;
			this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
			// 
			// btnXoa
			// 
			this.btnXoa.Caption = "Xóa";
			this.btnXoa.Id = 3;
			this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
			// 
			// btnUndo
			// 
			this.btnUndo.Caption = "Undo";
			this.btnUndo.Id = 4;
			this.btnUndo.ImageOptions.Image = global::TRACNGHIEM_DEMO1.Properties.Resources.Undo_icon_24;
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
			// 
			// btnReload
			// 
			this.btnReload.Caption = "Reload";
			this.btnReload.Id = 5;
			this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
			this.btnReload.Name = "btnReload";
			this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
			// 
			// btnInDSSV
			// 
			this.btnInDSSV.Caption = "Danh Sách Sinh Viên";
			this.btnInDSSV.Id = 6;
			this.btnInDSSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSSV.ImageOptions.Image")));
			this.btnInDSSV.Name = "btnInDSSV";
			this.btnInDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSSV_ItemClick);
			// 
			// btnTroVe
			// 
			this.btnTroVe.Caption = "Trở Về";
			this.btnTroVe.Id = 7;
			this.btnTroVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.ImageOptions.Image")));
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroVe_ItemClick);
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(896, 40);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 420);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(896, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 380);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(896, 40);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 380);
			// 
			// panelTenCS
			// 
			this.panelTenCS.Controls.Add(this.label1);
			this.panelTenCS.Controls.Add(this.cbxTenCoSo);
			this.panelTenCS.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTenCS.Location = new System.Drawing.Point(0, 40);
			this.panelTenCS.Name = "panelTenCS";
			this.panelTenCS.Size = new System.Drawing.Size(896, 59);
			this.panelTenCS.TabIndex = 4;
			this.panelTenCS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTenCS_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(221, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên Cơ Sở";
			// 
			// cbxTenCoSo
			// 
			this.cbxTenCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenCoSo.FormattingEnabled = true;
			this.cbxTenCoSo.Location = new System.Drawing.Point(321, 21);
			this.cbxTenCoSo.Name = "cbxTenCoSo";
			this.cbxTenCoSo.Size = new System.Drawing.Size(403, 27);
			this.cbxTenCoSo.TabIndex = 0;
			this.cbxTenCoSo.SelectedIndexChanged += new System.EventHandler(this.cbxTenCoSo_SelectedIndexChanged);
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsSinhVien
			// 
			this.bdsSinhVien.DataMember = "SINHVIEN";
			this.bdsSinhVien.DataSource = this.dS;
			// 
			// sINHVIENTableAdapter
			// 
			this.sINHVIENTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BANGDIEMTableAdapter = null;
			this.tableAdapterManager.BODETableAdapter = null;
			this.tableAdapterManager.COSOTableAdapter = null;
			this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
			this.tableAdapterManager.GIAOVIENTableAdapter = null;
			this.tableAdapterManager.KHOATableAdapter = null;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sINHVIENGridControl
			// 
			this.sINHVIENGridControl.DataSource = this.bdsSinhVien;
			this.sINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			gridLevelNode1.RelationName = "Level1";
			this.sINHVIENGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.sINHVIENGridControl.Location = new System.Drawing.Point(0, 99);
			this.sINHVIENGridControl.MainView = this.gridView1;
			this.sINHVIENGridControl.MenuManager = this.barManager1;
			this.sINHVIENGridControl.Name = "sINHVIENGridControl";
			this.sINHVIENGridControl.Size = new System.Drawing.Size(896, 145);
			this.sINHVIENGridControl.TabIndex = 6;
			this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
			this.gridView1.GridControl = this.sINHVIENGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMASV
			// 
			this.colMASV.Caption = "MÃ SINH VIÊN";
			this.colMASV.FieldName = "MASV";
			this.colMASV.Name = "colMASV";
			this.colMASV.OptionsColumn.ReadOnly = true;
			this.colMASV.Visible = true;
			this.colMASV.VisibleIndex = 0;
			// 
			// colHO
			// 
			this.colHO.Caption = "HỌ SINH VIÊN";
			this.colHO.FieldName = "HO";
			this.colHO.Name = "colHO";
			this.colHO.OptionsColumn.ReadOnly = true;
			this.colHO.Visible = true;
			this.colHO.VisibleIndex = 1;
			// 
			// colTEN
			// 
			this.colTEN.Caption = "TÊN SINH VIÊN";
			this.colTEN.FieldName = "TEN";
			this.colTEN.Name = "colTEN";
			this.colTEN.OptionsColumn.ReadOnly = true;
			this.colTEN.Visible = true;
			this.colTEN.VisibleIndex = 2;
			// 
			// colNGAYSINH
			// 
			this.colNGAYSINH.Caption = "NGÀY SINH";
			this.colNGAYSINH.FieldName = "NGAYSINH";
			this.colNGAYSINH.Name = "colNGAYSINH";
			this.colNGAYSINH.OptionsColumn.ReadOnly = true;
			this.colNGAYSINH.Visible = true;
			this.colNGAYSINH.VisibleIndex = 3;
			// 
			// colDIACHI
			// 
			this.colDIACHI.Caption = "ĐỊA CHỈ";
			this.colDIACHI.FieldName = "DIACHI";
			this.colDIACHI.Name = "colDIACHI";
			this.colDIACHI.OptionsColumn.ReadOnly = true;
			this.colDIACHI.Visible = true;
			this.colDIACHI.VisibleIndex = 4;
			// 
			// colMALOP
			// 
			this.colMALOP.Caption = "MÃ LỚP";
			this.colMALOP.FieldName = "MALOP";
			this.colMALOP.Name = "colMALOP";
			this.colMALOP.OptionsColumn.ReadOnly = true;
			this.colMALOP.Visible = true;
			this.colMALOP.VisibleIndex = 5;
			// 
			// grbSinhVien
			// 
			this.grbSinhVien.Controls.Add(mALOPLabel1);
			this.grbSinhVien.Controls.Add(this.cbxMaLop);
			this.grbSinhVien.Controls.Add(dIACHILabel);
			this.grbSinhVien.Controls.Add(this.txtDiaChi);
			this.grbSinhVien.Controls.Add(nGAYSINHLabel);
			this.grbSinhVien.Controls.Add(this.txtNgaySinh);
			this.grbSinhVien.Controls.Add(tENLabel);
			this.grbSinhVien.Controls.Add(this.txtTenSV);
			this.grbSinhVien.Controls.Add(hOLabel);
			this.grbSinhVien.Controls.Add(this.txtHoSV);
			this.grbSinhVien.Controls.Add(mASVLabel);
			this.grbSinhVien.Controls.Add(this.txtMaSV);
			this.grbSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grbSinhVien.Location = new System.Drawing.Point(0, 244);
			this.grbSinhVien.Name = "grbSinhVien";
			this.grbSinhVien.Size = new System.Drawing.Size(896, 176);
			this.grbSinhVien.TabIndex = 7;
			this.grbSinhVien.TabStop = false;
			this.grbSinhVien.Text = "Thông Tin Sinh Viên";
			// 
			// cbxMaLop
			// 
			this.cbxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MALOP", true));
			this.cbxMaLop.FormattingEnabled = true;
			this.cbxMaLop.Location = new System.Drawing.Point(547, 122);
			this.cbxMaLop.Name = "cbxMaLop";
			this.cbxMaLop.Size = new System.Drawing.Size(287, 27);
			this.cbxMaLop.TabIndex = 12;
			this.cbxMaLop.SelectedIndexChanged += new System.EventHandler(this.cbxMaLop_SelectedIndexChanged);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DIACHI", true));
			this.txtDiaChi.Location = new System.Drawing.Point(547, 87);
			this.txtDiaChi.MenuManager = this.barManager1;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(287, 20);
			this.txtDiaChi.TabIndex = 9;
			// 
			// txtNgaySinh
			// 
			this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NGAYSINH", true));
			this.txtNgaySinh.EditValue = null;
			this.txtNgaySinh.Location = new System.Drawing.Point(547, 38);
			this.txtNgaySinh.MenuManager = this.barManager1;
			this.txtNgaySinh.Name = "txtNgaySinh";
			this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtNgaySinh.Size = new System.Drawing.Size(287, 20);
			this.txtNgaySinh.TabIndex = 7;
			// 
			// txtTenSV
			// 
			this.txtTenSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "TEN", true));
			this.txtTenSV.Location = new System.Drawing.Point(132, 119);
			this.txtTenSV.MenuManager = this.barManager1;
			this.txtTenSV.Name = "txtTenSV";
			this.txtTenSV.Size = new System.Drawing.Size(290, 20);
			this.txtTenSV.TabIndex = 5;
			// 
			// txtHoSV
			// 
			this.txtHoSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "HO", true));
			this.txtHoSV.Location = new System.Drawing.Point(132, 75);
			this.txtHoSV.MenuManager = this.barManager1;
			this.txtHoSV.Name = "txtHoSV";
			this.txtHoSV.Size = new System.Drawing.Size(290, 20);
			this.txtHoSV.TabIndex = 3;
			// 
			// txtMaSV
			// 
			this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MASV", true));
			this.txtMaSV.Location = new System.Drawing.Point(132, 34);
			this.txtMaSV.MenuManager = this.barManager1;
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(290, 20);
			this.txtMaSV.TabIndex = 1;
			// 
			// frmSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 443);
			this.Controls.Add(this.grbSinhVien);
			this.Controls.Add(this.sINHVIENGridControl);
			this.Controls.Add(this.panelTenCS);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmSinhVien";
			this.Text = "frmSinhVien";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSinhVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.panelTenCS.ResumeLayout(false);
			this.panelTenCS.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.grbSinhVien.ResumeLayout(false);
			this.grbSinhVien.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnThem;
		private DevExpress.XtraBars.BarButtonItem btnSua;
		private DevExpress.XtraBars.BarButtonItem btnGhi;
		private DevExpress.XtraBars.BarButtonItem btnXoa;
		private DevExpress.XtraBars.BarButtonItem btnUndo;
		private DevExpress.XtraBars.BarButtonItem btnReload;
		private DevExpress.XtraBars.BarButtonItem btnInDSSV;
		private DevExpress.XtraBars.BarButtonItem btnTroVe;
		private System.Windows.Forms.BindingSource bdsSinhVien;
		private DS dS;
		private System.Windows.Forms.Panel panelTenCS;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxTenCoSo;
		private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colMASV;
		private DevExpress.XtraGrid.Columns.GridColumn colHO;
		private DevExpress.XtraGrid.Columns.GridColumn colTEN;
		private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
		private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
		private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
		private System.Windows.Forms.GroupBox grbSinhVien;
		private System.Windows.Forms.ComboBox cbxMaLop;
		private DevExpress.XtraEditors.TextEdit txtDiaChi;
		private DevExpress.XtraEditors.DateEdit txtNgaySinh;
		private DevExpress.XtraEditors.TextEdit txtTenSV;
		private DevExpress.XtraEditors.TextEdit txtHoSV;
		private DevExpress.XtraEditors.TextEdit txtMaSV;
	}
}