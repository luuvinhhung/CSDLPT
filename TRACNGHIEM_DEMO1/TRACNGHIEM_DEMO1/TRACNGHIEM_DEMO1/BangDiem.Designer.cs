namespace TRACNGHIEM_DEMO1
{
	partial class BangDiem
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
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxTenCoSo = new System.Windows.Forms.ComboBox();
			this.dS = new TRACNGHIEM_DEMO1.DS();
			this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
			this.bANGDIEMTableAdapter = new TRACNGHIEM_DEMO1.DSTableAdapters.BANGDIEMTableAdapter();
			this.tableAdapterManager = new TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager();
			this.bANGDIEMGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBAITHI = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
			this.barManager1.MaxItemId = 1;
			this.barManager1.StatusBar = this.bar3;
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
			this.barDockControlTop.Size = new System.Drawing.Size(868, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 453);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(868, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(868, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbxTenCoSo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(868, 93);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(213, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên Cơ Sở";
			// 
			// cbxTenCoSo
			// 
			this.cbxTenCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTenCoSo.FormattingEnabled = true;
			this.cbxTenCoSo.Location = new System.Drawing.Point(362, 41);
			this.cbxTenCoSo.Name = "cbxTenCoSo";
			this.cbxTenCoSo.Size = new System.Drawing.Size(369, 27);
			this.cbxTenCoSo.TabIndex = 0;
			this.cbxTenCoSo.SelectedIndexChanged += new System.EventHandler(this.cbxTenCoSo_SelectedIndexChanged);
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsBangDiem
			// 
			this.bdsBangDiem.DataMember = "BANGDIEM";
			this.bdsBangDiem.DataSource = this.dS;
			// 
			// bANGDIEMTableAdapter
			// 
			this.bANGDIEMTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
			this.tableAdapterManager.BODETableAdapter = null;
			this.tableAdapterManager.COSOTableAdapter = null;
			this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
			this.tableAdapterManager.GIAOVIENTableAdapter = null;
			this.tableAdapterManager.KHOATableAdapter = null;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TRACNGHIEM_DEMO1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// bANGDIEMGridControl
			// 
			this.bANGDIEMGridControl.DataSource = this.bdsBangDiem;
			this.bANGDIEMGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.bANGDIEMGridControl.Location = new System.Drawing.Point(0, 93);
			this.bANGDIEMGridControl.MainView = this.gridView1;
			this.bANGDIEMGridControl.MenuManager = this.barManager1;
			this.bANGDIEMGridControl.Name = "bANGDIEMGridControl";
			this.bANGDIEMGridControl.Size = new System.Drawing.Size(868, 220);
			this.bANGDIEMGridControl.TabIndex = 6;
			this.bANGDIEMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colMAMH,
            this.colLAN,
            this.colNGAYTHI,
            this.colDIEM,
            this.colBAITHI});
			this.gridView1.GridControl = this.bANGDIEMGridControl;
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
			// colMAMH
			// 
			this.colMAMH.Caption = "MÃ MÔN HỌC";
			this.colMAMH.FieldName = "MAMH";
			this.colMAMH.Name = "colMAMH";
			this.colMAMH.OptionsColumn.ReadOnly = true;
			this.colMAMH.Visible = true;
			this.colMAMH.VisibleIndex = 1;
			// 
			// colLAN
			// 
			this.colLAN.Caption = "LẦN";
			this.colLAN.FieldName = "LAN";
			this.colLAN.Name = "colLAN";
			this.colLAN.OptionsColumn.ReadOnly = true;
			this.colLAN.Visible = true;
			this.colLAN.VisibleIndex = 2;
			// 
			// colNGAYTHI
			// 
			this.colNGAYTHI.Caption = "NGÀY THI";
			this.colNGAYTHI.FieldName = "NGAYTHI";
			this.colNGAYTHI.Name = "colNGAYTHI";
			this.colNGAYTHI.OptionsColumn.ReadOnly = true;
			this.colNGAYTHI.Visible = true;
			this.colNGAYTHI.VisibleIndex = 3;
			// 
			// colDIEM
			// 
			this.colDIEM.Caption = "ĐIỂM";
			this.colDIEM.FieldName = "DIEM";
			this.colDIEM.Name = "colDIEM";
			this.colDIEM.OptionsColumn.ReadOnly = true;
			this.colDIEM.Visible = true;
			this.colDIEM.VisibleIndex = 4;
			// 
			// colBAITHI
			// 
			this.colBAITHI.Caption = "BÀI THI";
			this.colBAITHI.FieldName = "BAITHI";
			this.colBAITHI.Name = "colBAITHI";
			this.colBAITHI.OptionsColumn.ReadOnly = true;
			this.colBAITHI.Visible = true;
			this.colBAITHI.VisibleIndex = 5;
			// 
			// BangDiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 476);
			this.Controls.Add(this.bANGDIEMGridControl);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BangDiem";
			this.Text = "BangDiem";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BangDiem_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private System.Windows.Forms.BindingSource bdsBangDiem;
		private DS dS;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxTenCoSo;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private DevExpress.XtraGrid.GridControl bANGDIEMGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colMASV;
		private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
		private DevExpress.XtraGrid.Columns.GridColumn colLAN;
		private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
		private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
		private DevExpress.XtraGrid.Columns.GridColumn colBAITHI;
	}
}