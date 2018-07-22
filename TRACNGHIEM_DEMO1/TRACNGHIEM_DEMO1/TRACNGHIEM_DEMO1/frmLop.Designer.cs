namespace TRACNGHIEM_DEMO1
{
	partial class frmLop
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
			System.Windows.Forms.Label mALOPLabel;
			System.Windows.Forms.Label tENLOPLabel;
			System.Windows.Forms.Label mAKHLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
			this.panelTenCoSo = new System.Windows.Forms.Panel();
			this.cbxTenChiNhanh = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
			this.lOPTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.LOPTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grbLop = new System.Windows.Forms.GroupBox();
			this.cbxMaKhoa = new System.Windows.Forms.ComboBox();
			this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
			this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
			this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
			this.kHOATableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.KHOATableAdapter();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.btnThem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnSua1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoa1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnUndo1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnReload1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnInDSLop1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnTroVe1 = new DevExpress.XtraBars.BarButtonItem();
			mALOPLabel = new System.Windows.Forms.Label();
			tENLOPLabel = new System.Windows.Forms.Label();
			mAKHLabel = new System.Windows.Forms.Label();
			this.panelTenCoSo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.grbLop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// mALOPLabel
			// 
			mALOPLabel.AutoSize = true;
			mALOPLabel.Location = new System.Drawing.Point(370, 56);
			mALOPLabel.Name = "mALOPLabel";
			mALOPLabel.Size = new System.Drawing.Size(67, 19);
			mALOPLabel.TabIndex = 0;
			mALOPLabel.Text = "MALOP:";
			// 
			// tENLOPLabel
			// 
			tENLOPLabel.AutoSize = true;
			tENLOPLabel.Location = new System.Drawing.Point(365, 106);
			tENLOPLabel.Name = "tENLOPLabel";
			tENLOPLabel.Size = new System.Drawing.Size(72, 19);
			tENLOPLabel.TabIndex = 2;
			tENLOPLabel.Text = "TENLOP:";
			// 
			// mAKHLabel
			// 
			mAKHLabel.AutoSize = true;
			mAKHLabel.Location = new System.Drawing.Point(377, 155);
			mAKHLabel.Name = "mAKHLabel";
			mAKHLabel.Size = new System.Drawing.Size(60, 19);
			mAKHLabel.TabIndex = 4;
			mAKHLabel.Text = "MAKH:";
			// 
			// panelTenCoSo
			// 
			this.panelTenCoSo.Controls.Add(this.cbxTenChiNhanh);
			this.panelTenCoSo.Controls.Add(this.label1);
			this.panelTenCoSo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTenCoSo.Location = new System.Drawing.Point(0, 40);
			this.panelTenCoSo.Name = "panelTenCoSo";
			this.panelTenCoSo.Size = new System.Drawing.Size(1278, 68);
			this.panelTenCoSo.TabIndex = 1;
			this.panelTenCoSo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTenCoSo_Paint);
			// 
			// cbxTenChiNhanh
			// 
			this.cbxTenChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenChiNhanh.FormattingEnabled = true;
			this.cbxTenChiNhanh.Location = new System.Drawing.Point(345, 21);
			this.cbxTenChiNhanh.Name = "cbxTenChiNhanh";
			this.cbxTenChiNhanh.Size = new System.Drawing.Size(454, 27);
			this.cbxTenChiNhanh.TabIndex = 1;
			this.cbxTenChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxTenChiNhanh_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(231, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÊN CƠ SỞ";
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsLop
			// 
			this.bdsLop.DataMember = "LOP";
			this.bdsLop.DataSource = this.dS;
			// 
			// lOPTableAdapter
			// 
			this.lOPTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// lOPGridControl
			// 
			this.lOPGridControl.DataSource = this.bdsLop;
			this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.lOPGridControl.Location = new System.Drawing.Point(0, 108);
			this.lOPGridControl.MainView = this.gridView1;
			this.lOPGridControl.Name = "lOPGridControl";
			this.lOPGridControl.Size = new System.Drawing.Size(1278, 148);
			this.lOPGridControl.TabIndex = 3;
			this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
			this.gridView1.GridControl = this.lOPGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMALOP
			// 
			this.colMALOP.Caption = "MÃ LỚP";
			this.colMALOP.FieldName = "MALOP";
			this.colMALOP.Name = "colMALOP";
			this.colMALOP.OptionsColumn.ReadOnly = true;
			this.colMALOP.Visible = true;
			this.colMALOP.VisibleIndex = 0;
			// 
			// colTENLOP
			// 
			this.colTENLOP.Caption = "TÊN LỚP";
			this.colTENLOP.FieldName = "TENLOP";
			this.colTENLOP.Name = "colTENLOP";
			this.colTENLOP.OptionsColumn.ReadOnly = true;
			this.colTENLOP.Visible = true;
			this.colTENLOP.VisibleIndex = 1;
			// 
			// colMAKH
			// 
			this.colMAKH.Caption = "MA KHOA";
			this.colMAKH.FieldName = "MAKH";
			this.colMAKH.Name = "colMAKH";
			this.colMAKH.OptionsColumn.ReadOnly = true;
			this.colMAKH.Visible = true;
			this.colMAKH.VisibleIndex = 2;
			// 
			// grbLop
			// 
			this.grbLop.Controls.Add(mAKHLabel);
			this.grbLop.Controls.Add(this.cbxMaKhoa);
			this.grbLop.Controls.Add(tENLOPLabel);
			this.grbLop.Controls.Add(this.txtTenLop);
			this.grbLop.Controls.Add(mALOPLabel);
			this.grbLop.Controls.Add(this.txtMaLop);
			this.grbLop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grbLop.Location = new System.Drawing.Point(0, 256);
			this.grbLop.Name = "grbLop";
			this.grbLop.Size = new System.Drawing.Size(1278, 198);
			this.grbLop.TabIndex = 4;
			this.grbLop.TabStop = false;
			// 
			// cbxMaKhoa
			// 
			this.cbxMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MAKH", true));
			this.cbxMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxMaKhoa.FormattingEnabled = true;
			this.cbxMaKhoa.Location = new System.Drawing.Point(443, 152);
			this.cbxMaKhoa.Name = "cbxMaKhoa";
			this.cbxMaKhoa.Size = new System.Drawing.Size(368, 27);
			this.cbxMaKhoa.TabIndex = 5;
			this.cbxMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxMaKhoa_SelectedIndexChanged);
			// 
			// txtTenLop
			// 
			this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
			this.txtTenLop.Location = new System.Drawing.Point(443, 103);
			this.txtTenLop.Name = "txtTenLop";
			this.txtTenLop.Size = new System.Drawing.Size(368, 20);
			this.txtTenLop.TabIndex = 3;
			// 
			// txtMaLop
			// 
			this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
			this.txtMaLop.Location = new System.Drawing.Point(443, 53);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.Size = new System.Drawing.Size(368, 20);
			this.txtMaLop.TabIndex = 1;
			// 
			// bdsKhoa
			// 
			this.bdsKhoa.DataMember = "KHOA";
			this.bdsKhoa.DataSource = this.dS;
			// 
			// kHOATableAdapter
			// 
			this.kHOATableAdapter.ClearBeforeFill = true;
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
            this.btnGhi,
            this.btnXoa1,
            this.btnUndo1,
            this.btnReload1,
            this.btnInDSLop1,
            this.btnTroVe1});
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
			this.barDockControlTop.Size = new System.Drawing.Size(1278, 40);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1278, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 414);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1278, 40);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 414);
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSLop1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTroVe1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
			// btnGhi
			// 
			this.btnGhi.Caption = "Ghi";
			this.btnGhi.Id = 2;
			this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
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
			// btnInDSLop1
			// 
			this.btnInDSLop1.Caption = "In Danh Sách Lớp";
			this.btnInDSLop1.Id = 6;
			this.btnInDSLop1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
			this.btnInDSLop1.Name = "btnInDSLop1";
			// 
			// btnTroVe1
			// 
			this.btnTroVe1.Caption = "Trở Về";
			this.btnTroVe1.Id = 7;
			this.btnTroVe1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
			this.btnTroVe1.Name = "btnTroVe1";
			this.btnTroVe1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroVe1_ItemClick);
			// 
			// frmLop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1278, 477);
			this.Controls.Add(this.grbLop);
			this.Controls.Add(this.lOPGridControl);
			this.Controls.Add(this.panelTenCoSo);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmLop";
			this.Text = "frmLop";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmLop_Load);
			this.panelTenCoSo.ResumeLayout(false);
			this.panelTenCoSo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.grbLop.ResumeLayout(false);
			this.grbLop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelTenCoSo;
		private System.Windows.Forms.ComboBox cbxTenChiNhanh;
		private System.Windows.Forms.Label label1;
		private DS dS;
		private System.Windows.Forms.BindingSource bdsLop;
		private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private DevExpress.XtraGrid.GridControl lOPGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
		private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
		private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
		private System.Windows.Forms.GroupBox grbLop;
		private DevExpress.XtraEditors.TextEdit txtTenLop;
		private DevExpress.XtraEditors.TextEdit txtMaLop;
		private System.Windows.Forms.BindingSource bdsKhoa;
		private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
		public System.Windows.Forms.ComboBox cbxMaKhoa;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnThem1;
		private DevExpress.XtraBars.BarButtonItem btnSua1;
		private DevExpress.XtraBars.BarButtonItem btnGhi;
		private DevExpress.XtraBars.BarButtonItem btnXoa1;
		private DevExpress.XtraBars.BarButtonItem btnUndo1;
		private DevExpress.XtraBars.BarButtonItem btnReload1;
		private DevExpress.XtraBars.BarButtonItem btnInDSLop1;
		private DevExpress.XtraBars.BarButtonItem btnTroVe1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}