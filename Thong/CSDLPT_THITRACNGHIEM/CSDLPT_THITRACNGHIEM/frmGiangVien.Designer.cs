namespace CSDLPT_THITRACNGHIEM
{
    partial class frmGiangVien
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label mAGIANGVIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.tRACNGHIEMDataSet = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSet();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.kHOATableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.KHOATableAdapter();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGIANGVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tRANGTHAISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAKHOATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAGIANGVIENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btThucThi = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mAGIANGVIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGIANGVIENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(345, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 17;
            label1.Text = "CƠ SỞ:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(794, 76);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 45;
            dIACHILabel.Text = "DIACHI:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(509, 99);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 42;
            tENLabel.Text = "TEN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(42, 99);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 41;
            hOLabel.Text = "HO:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(506, 41);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(54, 13);
            mAKHOALabel.TabIndex = 39;
            mAKHOALabel.Text = "MAKHOA:";
            // 
            // mAGIANGVIENLabel
            // 
            mAGIANGVIENLabel.AutoSize = true;
            mAGIANGVIENLabel.Location = new System.Drawing.Point(42, 39);
            mAGIANGVIENLabel.Name = "mAGIANGVIENLabel";
            mAGIANGVIENLabel.Size = new System.Drawing.Size(81, 13);
            mAGIANGVIENLabel.TabIndex = 37;
            mAGIANGVIENLabel.Text = "MAGIANGVIEN:";
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CAUTRALOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIANGVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.gIANGVIENBindingSource;
            this.gIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(1096, 344);
            this.gIANGVIENGridControl.TabIndex = 1;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterString = "[TRANGTHAI] = 1";
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGIANGVIEN,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKHOA,
            this.colTRANGTHAI});
            this.gridView1.GridControl = this.gIANGVIENGridControl;
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
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 4;
            // 
            // colTRANGTHAI
            // 
            this.colTRANGTHAI.FieldName = "TRANGTHAI";
            this.colTRANGTHAI.Name = "colTRANGTHAI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tRANGTHAISpinEdit);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.dIACHITextEdit);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tENTextEdit);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hOTextEdit);
            this.groupBox1.Controls.Add(mAKHOALabel);
            this.groupBox1.Controls.Add(this.mAKHOATextEdit);
            this.groupBox1.Controls.Add(mAGIANGVIENLabel);
            this.groupBox1.Controls.Add(this.mAGIANGVIENTextEdit);
            this.groupBox1.Controls.Add(this.comboBoxKhoa);
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btThucThi);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tRANGTHAISpinEdit
            // 
            this.tRANGTHAISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "TRANGTHAI", true));
            this.tRANGTHAISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tRANGTHAISpinEdit.Location = new System.Drawing.Point(791, 3);
            this.tRANGTHAISpinEdit.Name = "tRANGTHAISpinEdit";
            this.tRANGTHAISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tRANGTHAISpinEdit.Size = new System.Drawing.Size(100, 20);
            this.tRANGTHAISpinEdit.TabIndex = 47;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(847, 73);
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(198, 20);
            this.dIACHITextEdit.TabIndex = 46;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(566, 96);
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(186, 20);
            this.tENTextEdit.TabIndex = 44;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(132, 96);
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(192, 20);
            this.hOTextEdit.TabIndex = 43;
            // 
            // mAKHOATextEdit
            // 
            this.mAKHOATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "MAKHOA", true));
            this.mAKHOATextEdit.Location = new System.Drawing.Point(566, 36);
            this.mAKHOATextEdit.Name = "mAKHOATextEdit";
            this.mAKHOATextEdit.Size = new System.Drawing.Size(186, 20);
            this.mAKHOATextEdit.TabIndex = 40;
            // 
            // mAGIANGVIENTextEdit
            // 
            this.mAGIANGVIENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "MAGIANGVIEN", true));
            this.mAGIANGVIENTextEdit.Location = new System.Drawing.Point(132, 36);
            this.mAGIANGVIENTextEdit.Name = "mAGIANGVIENTextEdit";
            this.mAGIANGVIENTextEdit.Size = new System.Drawing.Size(192, 20);
            this.mAGIANGVIENTextEdit.TabIndex = 38;
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.DataSource = this.kHOABindingSource;
            this.comboBoxKhoa.DisplayMember = "TENKH";
            this.comboBoxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(566, 36);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(203, 21);
            this.comboBoxKhoa.TabIndex = 36;
            this.comboBoxKhoa.ValueMember = "MAKHOA";
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // btHuy
            // 
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.Location = new System.Drawing.Point(601, 143);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(97, 23);
            this.btHuy.TabIndex = 35;
            this.btHuy.Text = "HỦY THÊM";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(734, 143);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 23);
            this.btXoa.TabIndex = 34;
            this.btXoa.Text = "XÓA GIẢNG VIÊN";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(427, 143);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(112, 23);
            this.btSua.TabIndex = 33;
            this.btSua.Text = "SỬA THÔNG TIN";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThucThi
            // 
            this.btThucThi.Image = ((System.Drawing.Image)(resources.GetObject("btThucThi.Image")));
            this.btThucThi.Location = new System.Drawing.Point(91, 143);
            this.btThucThi.Name = "btThucThi";
            this.btThucThi.Size = new System.Drawing.Size(122, 23);
            this.btThucThi.TabIndex = 32;
            this.btThucThi.Text = "THÊM GIẢNG VIÊN";
            this.btThucThi.Click += new System.EventHandler(this.btThucThi_Click);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(91, 143);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(122, 23);
            this.btThem.TabIndex = 31;
            this.btThem.Text = "THÊM GIẢNG VIÊN";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCoSo);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 43);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(402, 16);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(203, 21);
            this.comboBoxCoSo.TabIndex = 18;
            this.comboBoxCoSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoSo_SelectedIndexChanged);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gIANGVIENGridControl);
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGIANGVIENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private TRACNGHIEMDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGIANGVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private DevExpress.XtraEditors.SpinEdit tRANGTHAISpinEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit mAKHOATextEdit;
        private DevExpress.XtraEditors.TextEdit mAGIANGVIENTextEdit;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btThucThi;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private TRACNGHIEMDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
    }
}