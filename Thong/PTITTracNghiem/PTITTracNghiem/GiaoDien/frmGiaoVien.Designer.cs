namespace PTITTracNghiem.GiaoDien
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
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbGiaoVien = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTenGV = new System.Windows.Forms.RadioButton();
            this.rdoMaGV = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODTLL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbGiaoVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(254, 95);
            this.txtHo.MaxLength = 40;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(431, 26);
            this.txtHo.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(254, 160);
            this.txtTen.MaxLength = 40;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(141, 26);
            this.txtTen.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(254, 221);
            this.txtDiaChi.MaxLength = 40;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(431, 26);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(254, 40);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(141, 26);
            this.txtMa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Số Giáo Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Tên Lót :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Giáo Viên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa Chỉ :";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(789, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(789, 87);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 35);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(789, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 35);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(789, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 35);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbGiaoVien
            // 
            this.grbGiaoVien.Controls.Add(this.txtSDT);
            this.grbGiaoVien.Controls.Add(this.btnThoat);
            this.grbGiaoVien.Controls.Add(this.btnXoa);
            this.grbGiaoVien.Controls.Add(this.btnSua);
            this.grbGiaoVien.Controls.Add(this.btnThem);
            this.grbGiaoVien.Controls.Add(this.label5);
            this.grbGiaoVien.Controls.Add(this.label4);
            this.grbGiaoVien.Controls.Add(this.label3);
            this.grbGiaoVien.Controls.Add(this.label2);
            this.grbGiaoVien.Controls.Add(this.label1);
            this.grbGiaoVien.Controls.Add(this.txtMa);
            this.grbGiaoVien.Controls.Add(this.txtDiaChi);
            this.grbGiaoVien.Controls.Add(this.txtTen);
            this.grbGiaoVien.Controls.Add(this.txtHo);
            this.grbGiaoVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbGiaoVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGiaoVien.Location = new System.Drawing.Point(0, 351);
            this.grbGiaoVien.Name = "grbGiaoVien";
            this.grbGiaoVien.Size = new System.Drawing.Size(1018, 285);
            this.grbGiaoVien.TabIndex = 11;
            this.grbGiaoVien.TabStop = false;
            this.grbGiaoVien.Text = "Thông Tin Giáo Viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(542, 160);
            this.txtSDT.MaxLength = 12;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(143, 26);
            this.txtSDT.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Điện Thoại :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1018, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTenGV);
            this.panel1.Controls.Add(this.rdoMaGV);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 76);
            this.panel1.TabIndex = 9;
            // 
            // rdoTenGV
            // 
            this.rdoTenGV.AutoSize = true;
            this.rdoTenGV.Location = new System.Drawing.Point(651, 22);
            this.rdoTenGV.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTenGV.Name = "rdoTenGV";
            this.rdoTenGV.Size = new System.Drawing.Size(112, 23);
            this.rdoTenGV.TabIndex = 11;
            this.rdoTenGV.Text = "Tìm Theo Tên";
            this.rdoTenGV.UseVisualStyleBackColor = true;
            // 
            // rdoMaGV
            // 
            this.rdoMaGV.AutoSize = true;
            this.rdoMaGV.Location = new System.Drawing.Point(437, 22);
            this.rdoMaGV.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMaGV.Name = "rdoMaGV";
            this.rdoMaGV.Size = new System.Drawing.Size(114, 23);
            this.rdoMaGV.TabIndex = 10;
            this.rdoMaGV.Text = "Tìm Theo Mã ";
            this.rdoMaGV.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(95, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.MaxLength = 8;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(254, 26);
            this.txtTimKiem.TabIndex = 9;
            // 
            // giaoVienBindingSource
            // 
            //this.giaoVienBindingSource.DataSource = typeof(PTITTracNghiem.DuLieu.GiaoVien);
            // 
            // grvGiaoVien
            // 
            this.grvGiaoVien.DataSource = this.giaoVienBindingSource;
            this.grvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvGiaoVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grvGiaoVien.Location = new System.Drawing.Point(0, 99);
            this.grvGiaoVien.MainView = this.gridView1;
            this.grvGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.grvGiaoVien.Name = "grvGiaoVien";
            this.grvGiaoVien.Size = new System.Drawing.Size(1018, 252);
            this.grvGiaoVien.TabIndex = 13;
            this.grvGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colSODTLL,
            this.colDIACHI});
            this.gridView1.GridControl = this.grvGiaoVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã Số";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 99;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ Tên Lót";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 245;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên Giáo Viên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // colSODTLL
            // 
            this.colSODTLL.Caption = "Số Điện Thoại";
            this.colSODTLL.FieldName = "SODTLL";
            this.colSODTLL.Name = "colSODTLL";
            this.colSODTLL.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colSODTLL.Visible = true;
            this.colSODTLL.VisibleIndex = 3;
            this.colSODTLL.Width = 124;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 258;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 636);
            this.Controls.Add(this.grvGiaoVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbGiaoVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoVien";
            this.Text = "Giáo Viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.grbGiaoVien.ResumeLayout(false);
            this.grbGiaoVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbGiaoVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoTenGV;
        private System.Windows.Forms.RadioButton rdoMaGV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraGrid.GridControl grvGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODTLL;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
    }
}