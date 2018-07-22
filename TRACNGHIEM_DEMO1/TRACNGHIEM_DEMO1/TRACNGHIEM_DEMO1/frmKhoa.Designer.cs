namespace TRACNGHIEM_DEMO1
{
	partial class frmKhoa
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
			System.Windows.Forms.Label mAKHLabel;
			System.Windows.Forms.Label tENKHLabel;
			System.Windows.Forms.Label mACSLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
			this.panelTenCN = new System.Windows.Forms.Panel();
			this.cbxTenChiNhanh = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
			this.kHOATableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.KHOATableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.grbKhoa = new System.Windows.Forms.GroupBox();
			this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
			this.txtTENKH = new DevExpress.XtraEditors.TextEdit();
			this.txtMAKH = new DevExpress.XtraEditors.TextEdit();
			this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
			this.lOPTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.LOPTableAdapter();
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
			this.btnInDSKhoa1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnTroVe1 = new DevExpress.XtraBars.BarButtonItem();
			mAKHLabel = new System.Windows.Forms.Label();
			tENKHLabel = new System.Windows.Forms.Label();
			mACSLabel = new System.Windows.Forms.Label();
			this.panelTenCN.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
			this.grbKhoa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTENKH.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// mAKHLabel
			// 
			mAKHLabel.AutoSize = true;
			mAKHLabel.Location = new System.Drawing.Point(192, 42);
			mAKHLabel.Name = "mAKHLabel";
			mAKHLabel.Size = new System.Drawing.Size(60, 19);
			mAKHLabel.TabIndex = 0;
			mAKHLabel.Text = "MAKH:";
			mAKHLabel.Click += new System.EventHandler(this.mAKHLabel_Click);
			// 
			// tENKHLabel
			// 
			tENKHLabel.AutoSize = true;
			tENKHLabel.Location = new System.Drawing.Point(190, 90);
			tENKHLabel.Name = "tENKHLabel";
			tENKHLabel.Size = new System.Drawing.Size(65, 19);
			tENKHLabel.TabIndex = 2;
			tENKHLabel.Text = "TENKH:";
			tENKHLabel.Click += new System.EventHandler(this.tENKHLabel_Click);
			// 
			// mACSLabel
			// 
			mACSLabel.AutoSize = true;
			mACSLabel.Location = new System.Drawing.Point(195, 139);
			mACSLabel.Name = "mACSLabel";
			mACSLabel.Size = new System.Drawing.Size(57, 19);
			mACSLabel.TabIndex = 4;
			mACSLabel.Text = "MACS:";
			mACSLabel.Click += new System.EventHandler(this.mACSLabel_Click);
			// 
			// panelTenCN
			// 
			this.panelTenCN.Controls.Add(this.cbxTenChiNhanh);
			this.panelTenCN.Controls.Add(this.label1);
			this.panelTenCN.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTenCN.Location = new System.Drawing.Point(0, 40);
			this.panelTenCN.Name = "panelTenCN";
			this.panelTenCN.Size = new System.Drawing.Size(1107, 68);
			this.panelTenCN.TabIndex = 1;
			this.panelTenCN.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTenCN_Paint);
			// 
			// cbxTenChiNhanh
			// 
			this.cbxTenChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenChiNhanh.FormattingEnabled = true;
			this.cbxTenChiNhanh.Location = new System.Drawing.Point(277, 21);
			this.cbxTenChiNhanh.Name = "cbxTenChiNhanh";
			this.cbxTenChiNhanh.Size = new System.Drawing.Size(400, 27);
			this.cbxTenChiNhanh.TabIndex = 1;
			this.cbxTenChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxTenChiNhanh_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(157, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÊN CƠ SỞ ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.EnforceConstraints = false;
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsKhoa
			// 
			this.bdsKhoa.DataMember = "KHOA";
			this.bdsKhoa.DataSource = this.dS;
			this.bdsKhoa.CurrentChanged += new System.EventHandler(this.bdsKhoa_CurrentChanged);
			// 
			// kHOATableAdapter
			// 
			this.kHOATableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BANGDIEMTableAdapter = null;
			this.tableAdapterManager.BODETableAdapter = null;
			this.tableAdapterManager.COSOTableAdapter = null;
			this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
			this.tableAdapterManager.GIAOVIENTableAdapter = null;
			this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// grbKhoa
			// 
			this.grbKhoa.Controls.Add(mACSLabel);
			this.grbKhoa.Controls.Add(this.txtMaCS);
			this.grbKhoa.Controls.Add(tENKHLabel);
			this.grbKhoa.Controls.Add(this.txtTENKH);
			this.grbKhoa.Controls.Add(mAKHLabel);
			this.grbKhoa.Controls.Add(this.txtMAKH);
			this.grbKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grbKhoa.Location = new System.Drawing.Point(0, 316);
			this.grbKhoa.Name = "grbKhoa";
			this.grbKhoa.Size = new System.Drawing.Size(1107, 195);
			this.grbKhoa.TabIndex = 4;
			this.grbKhoa.TabStop = false;
			this.grbKhoa.Enter += new System.EventHandler(this.grbKhoa_Enter);
			// 
			// txtMaCS
			// 
			this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
			this.txtMaCS.Location = new System.Drawing.Point(277, 136);
			this.txtMaCS.Name = "txtMaCS";
			this.txtMaCS.Size = new System.Drawing.Size(364, 20);
			this.txtMaCS.TabIndex = 5;
			this.txtMaCS.EditValueChanged += new System.EventHandler(this.txtMaCS_EditValueChanged);
			// 
			// txtTENKH
			// 
			this.txtTENKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
			this.txtTENKH.Location = new System.Drawing.Point(277, 87);
			this.txtTENKH.Name = "txtTENKH";
			this.txtTENKH.Size = new System.Drawing.Size(363, 20);
			this.txtTENKH.TabIndex = 3;
			this.txtTENKH.EditValueChanged += new System.EventHandler(this.txtTENKH_EditValueChanged);
			// 
			// txtMAKH
			// 
			this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
			this.txtMAKH.Location = new System.Drawing.Point(277, 43);
			this.txtMAKH.Name = "txtMAKH";
			this.txtMAKH.Size = new System.Drawing.Size(363, 20);
			this.txtMAKH.TabIndex = 1;
			this.txtMAKH.EditValueChanged += new System.EventHandler(this.txtMAKH_EditValueChanged);
			// 
			// kHOAGridControl
			// 
			this.kHOAGridControl.DataSource = this.bdsKhoa;
			this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.kHOAGridControl.Location = new System.Drawing.Point(0, 108);
			this.kHOAGridControl.MainView = this.gridView1;
			this.kHOAGridControl.Name = "kHOAGridControl";
			this.kHOAGridControl.Size = new System.Drawing.Size(1107, 202);
			this.kHOAGridControl.TabIndex = 4;
			this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.kHOAGridControl.Click += new System.EventHandler(this.kHOAGridControl_Click);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
			this.gridView1.GridControl = this.kHOAGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMAKH
			// 
			this.colMAKH.Caption = "MÃ KHOA";
			this.colMAKH.FieldName = "MAKH";
			this.colMAKH.Name = "colMAKH";
			this.colMAKH.OptionsColumn.ReadOnly = true;
			this.colMAKH.Visible = true;
			this.colMAKH.VisibleIndex = 0;
			// 
			// colTENKH
			// 
			this.colTENKH.Caption = "TÊN KHOA";
			this.colTENKH.FieldName = "TENKH";
			this.colTENKH.Name = "colTENKH";
			this.colTENKH.OptionsColumn.ReadOnly = true;
			this.colTENKH.Visible = true;
			this.colTENKH.VisibleIndex = 1;
			// 
			// colMACS
			// 
			this.colMACS.Caption = "MÃ CƠ SỞ";
			this.colMACS.FieldName = "MACS";
			this.colMACS.Name = "colMACS";
			this.colMACS.OptionsColumn.ReadOnly = true;
			this.colMACS.Visible = true;
			this.colMACS.VisibleIndex = 2;
			// 
			// bdsLop
			// 
			this.bdsLop.DataMember = "LOP";
			this.bdsLop.DataSource = this.dS;
			this.bdsLop.CurrentChanged += new System.EventHandler(this.bdsLop_CurrentChanged);
			// 
			// lOPTableAdapter
			// 
			this.lOPTableAdapter.ClearBeforeFill = true;
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
            this.btnInDSKhoa1,
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
			this.barDockControlTop.Size = new System.Drawing.Size(1107, 40);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1107, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 471);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1107, 40);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 471);
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSKhoa1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
			// btnInDSKhoa1
			// 
			this.btnInDSKhoa1.Caption = "In Danh Sách Khoa";
			this.btnInDSKhoa1.Id = 6;
			this.btnInDSKhoa1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
			this.btnInDSKhoa1.Name = "btnInDSKhoa1";
			// 
			// btnTroVe1
			// 
			this.btnTroVe1.Caption = "Trở Về";
			this.btnTroVe1.Id = 7;
			this.btnTroVe1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
			this.btnTroVe1.Name = "btnTroVe1";
			this.btnTroVe1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroVe1_ItemClick);
			// 
			// frmKhoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1107, 534);
			this.Controls.Add(this.kHOAGridControl);
			this.Controls.Add(this.grbKhoa);
			this.Controls.Add(this.panelTenCN);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmKhoa";
			this.Text = "frmKhoa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmKhoa_Load);
			this.panelTenCN.ResumeLayout(false);
			this.panelTenCN.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
			this.grbKhoa.ResumeLayout(false);
			this.grbKhoa.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTENKH.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelTenCN;
		private System.Windows.Forms.ComboBox cbxTenChiNhanh;
		private System.Windows.Forms.Label label1;
		private DS dS;
		private System.Windows.Forms.BindingSource bdsKhoa;
		private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.GroupBox grbKhoa;
		private DevExpress.XtraEditors.TextEdit txtMaCS;
		private DevExpress.XtraEditors.TextEdit txtTENKH;
		private DevExpress.XtraEditors.TextEdit txtMAKH;
		private DevExpress.XtraGrid.GridControl kHOAGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
		private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
		private DevExpress.XtraGrid.Columns.GridColumn colMACS;
		private System.Windows.Forms.BindingSource bdsLop;
		private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnThem1;
		private DevExpress.XtraBars.BarButtonItem btnSua1;
		private DevExpress.XtraBars.BarButtonItem btnGhi1;
		private DevExpress.XtraBars.BarButtonItem btnXoa1;
		private DevExpress.XtraBars.BarButtonItem btnUndo1;
		private DevExpress.XtraBars.BarButtonItem btnReload1;
		private DevExpress.XtraBars.BarButtonItem btnInDSKhoa1;
		private DevExpress.XtraBars.BarButtonItem btnTroVe1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}