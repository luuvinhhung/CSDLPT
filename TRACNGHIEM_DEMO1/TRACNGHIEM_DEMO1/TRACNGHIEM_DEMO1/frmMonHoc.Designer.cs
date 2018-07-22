namespace TRACNGHIEM_DEMO1
{
	partial class frmMonHoc
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
			System.Windows.Forms.Label mAMHLabel;
			System.Windows.Forms.Label tENMHLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.btnThem = new DevExpress.XtraBars.BarButtonItem();
			this.btnSua = new DevExpress.XtraBars.BarButtonItem();
			this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
			this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
			this.btnReload = new DevExpress.XtraBars.BarButtonItem();
			this.btnInDSMH = new DevExpress.XtraBars.BarButtonItem();
			this.btnTroVe = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxTenCS = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
			this.mONHOCTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.MONHOCTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grbMonHoc = new System.Windows.Forms.GroupBox();
			this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
			this.txtmaMH = new DevExpress.XtraEditors.TextEdit();
			mAMHLabel = new System.Windows.Forms.Label();
			tENMHLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.grbMonHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtmaMH.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// mAMHLabel
			// 
			mAMHLabel.AutoSize = true;
			mAMHLabel.Location = new System.Drawing.Point(248, 41);
			mAMHLabel.Name = "mAMHLabel";
			mAMHLabel.Size = new System.Drawing.Size(114, 19);
			mAMHLabel.TabIndex = 0;
			mAMHLabel.Text = "MÃ MÔN HỌC";
			// 
			// tENMHLabel
			// 
			tENMHLabel.AutoSize = true;
			tENMHLabel.Location = new System.Drawing.Point(243, 87);
			tENMHLabel.Name = "tENMHLabel";
			tENMHLabel.Size = new System.Drawing.Size(119, 19);
			tENMHLabel.TabIndex = 2;
			tENMHLabel.Text = "TÊN MÔN HỌC";
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
            this.btnInDSMH,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
			// btnInDSMH
			// 
			this.btnInDSMH.Caption = "Danh Sách Môn Học";
			this.btnInDSMH.Id = 6;
			this.btnInDSMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSMH.ImageOptions.Image")));
			this.btnInDSMH.Name = "btnInDSMH";
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
			this.barDockControlTop.Size = new System.Drawing.Size(769, 60);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 397);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(769, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(769, 60);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbxTenCS);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(769, 50);
			this.panel1.TabIndex = 4;
			// 
			// cbxTenCS
			// 
			this.cbxTenCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenCS.FormattingEnabled = true;
			this.cbxTenCS.Location = new System.Drawing.Point(259, 17);
			this.cbxTenCS.Name = "cbxTenCS";
			this.cbxTenCS.Size = new System.Drawing.Size(435, 27);
			this.cbxTenCS.TabIndex = 1;
			this.cbxTenCS.SelectedIndexChanged += new System.EventHandler(this.cbxTenCS_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên Cơ Sở";
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsMonHoc
			// 
			this.bdsMonHoc.DataMember = "MONHOC";
			this.bdsMonHoc.DataSource = this.dS;
			// 
			// mONHOCTableAdapter
			// 
			this.mONHOCTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// mONHOCGridControl
			// 
			this.mONHOCGridControl.DataSource = this.bdsMonHoc;
			this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.mONHOCGridControl.Location = new System.Drawing.Point(0, 110);
			this.mONHOCGridControl.MainView = this.gridView1;
			this.mONHOCGridControl.MenuManager = this.barManager1;
			this.mONHOCGridControl.Name = "mONHOCGridControl";
			this.mONHOCGridControl.Size = new System.Drawing.Size(769, 225);
			this.mONHOCGridControl.TabIndex = 6;
			this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
			this.gridView1.GridControl = this.mONHOCGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMAMH
			// 
			this.colMAMH.Caption = "MÃ MÔN HỌC";
			this.colMAMH.FieldName = "MAMH";
			this.colMAMH.Name = "colMAMH";
			this.colMAMH.OptionsColumn.ReadOnly = true;
			this.colMAMH.Visible = true;
			this.colMAMH.VisibleIndex = 0;
			// 
			// colTENMH
			// 
			this.colTENMH.Caption = "TÊN MÔN HỌC";
			this.colTENMH.FieldName = "TENMH";
			this.colTENMH.Name = "colTENMH";
			this.colTENMH.OptionsColumn.ReadOnly = true;
			this.colTENMH.Visible = true;
			this.colTENMH.VisibleIndex = 1;
			// 
			// grbMonHoc
			// 
			this.grbMonHoc.Controls.Add(tENMHLabel);
			this.grbMonHoc.Controls.Add(this.txtTenMH);
			this.grbMonHoc.Controls.Add(mAMHLabel);
			this.grbMonHoc.Controls.Add(this.txtmaMH);
			this.grbMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grbMonHoc.Location = new System.Drawing.Point(0, 335);
			this.grbMonHoc.Name = "grbMonHoc";
			this.grbMonHoc.Size = new System.Drawing.Size(769, 62);
			this.grbMonHoc.TabIndex = 7;
			this.grbMonHoc.TabStop = false;
			this.grbMonHoc.Text = "Thông Tin Môn Học";
			// 
			// txtTenMH
			// 
			this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
			this.txtTenMH.Location = new System.Drawing.Point(384, 84);
			this.txtTenMH.MenuManager = this.barManager1;
			this.txtTenMH.Name = "txtTenMH";
			this.txtTenMH.Size = new System.Drawing.Size(325, 20);
			this.txtTenMH.TabIndex = 3;
			// 
			// txtmaMH
			// 
			this.txtmaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
			this.txtmaMH.Location = new System.Drawing.Point(384, 38);
			this.txtmaMH.MenuManager = this.barManager1;
			this.txtmaMH.Name = "txtmaMH";
			this.txtmaMH.Size = new System.Drawing.Size(325, 20);
			this.txtmaMH.TabIndex = 1;
			// 
			// frmMonHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 420);
			this.Controls.Add(this.grbMonHoc);
			this.Controls.Add(this.mONHOCGridControl);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMonHoc";
			this.Text = "frmMonHoc";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMonHoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.grbMonHoc.ResumeLayout(false);
			this.grbMonHoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtmaMH.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnThem;
		private DevExpress.XtraBars.BarButtonItem btnSua;
		private DevExpress.XtraBars.BarButtonItem btnGhi;
		private DevExpress.XtraBars.BarButtonItem btnXoa;
		private DevExpress.XtraBars.BarButtonItem btnUndo;
		private DevExpress.XtraBars.BarButtonItem btnReload;
		private DevExpress.XtraBars.BarButtonItem btnInDSMH;
		private DevExpress.XtraBars.BarButtonItem btnTroVe;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private System.Windows.Forms.BindingSource bdsMonHoc;
		private DS dS;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxTenCS;
		private System.Windows.Forms.Label label1;
		private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.GroupBox grbMonHoc;
		private DevExpress.XtraEditors.TextEdit txtTenMH;
		private DevExpress.XtraEditors.TextEdit txtmaMH;
		private DevExpress.XtraGrid.GridControl mONHOCGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
		private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
	}
}