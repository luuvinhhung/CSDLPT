namespace PTITTracNghiem.GiaoDien
{
    partial class frmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupRestore));
            this.label1 = new System.Windows.Forms.Label();
            this.gcBaR = new DevExpress.XtraGrid.GridControl();
            this.gvBaR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btBackup = new DevExpress.XtraEditors.SimpleButton();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbNgay = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.cbPhienBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sPSTTBACKUPResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSTTBACKUPResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(623, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Backup và Restore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcBaR
            // 
            this.gcBaR.DataSource = this.sPSTTBACKUPResultBindingSource;
            this.gcBaR.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcBaR.Location = new System.Drawing.Point(0, 0);
            this.gcBaR.MainView = this.gvBaR;
            this.gcBaR.Name = "gcBaR";
            this.gcBaR.Size = new System.Drawing.Size(403, 636);
            this.gcBaR.TabIndex = 9;
            this.gcBaR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBaR});
            this.gcBaR.Click += new System.EventHandler(this.gcBaR_Click);
            // 
            // gvBaR
            // 
            this.gvBaR.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvBaR.GridControl = this.gcBaR;
            this.gvBaR.Name = "gvBaR";
            this.gvBaR.OptionsBehavior.Editable = false;
            this.gvBaR.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Position";
            this.gridColumn1.FieldName = "position";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 169;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày Backup";
            this.gridColumn2.FieldName = "backup_start_date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 216;
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.Location = new System.Drawing.Point(886, 440);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 38);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btRestore
            // 
            this.btRestore.Image = ((System.Drawing.Image)(resources.GetObject("btRestore.Image")));
            this.btRestore.Location = new System.Drawing.Point(740, 440);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(95, 38);
            this.btRestore.TabIndex = 12;
            this.btRestore.Text = "Restore";
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btBackup
            // 
            this.btBackup.Image = ((System.Drawing.Image)(resources.GetObject("btBackup.Image")));
            this.btBackup.Location = new System.Drawing.Point(590, 440);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(99, 38);
            this.btBackup.TabIndex = 11;
            this.btBackup.Text = "Backup";
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // tbMa
            // 
            this.tbMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMa.Location = new System.Drawing.Point(679, 250);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(212, 26);
            this.tbMa.TabIndex = 16;
            // 
            // tbNgay
            // 
            this.tbNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgay.Location = new System.Drawing.Point(679, 355);
            this.tbNgay.Name = "tbNgay";
            this.tbNgay.Size = new System.Drawing.Size(212, 26);
            this.tbNgay.TabIndex = 15;
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(679, 300);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(212, 26);
            this.tbPosition.TabIndex = 14;
            // 
            // cbPhienBan
            // 
            this.cbPhienBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhienBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhienBan.FormattingEnabled = true;
            this.cbPhienBan.Location = new System.Drawing.Point(679, 197);
            this.cbPhienBan.Name = "cbPhienBan";
            this.cbPhienBan.Size = new System.Drawing.Size(212, 27);
            this.cbPhienBan.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chọn phiên bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã bảo vệ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày backup";
            // 
            // sPSTTBACKUPResultBindingSource
            // 
            //this.sPSTTBACKUPResultBindingSource.DataSource = typeof(PTITTracNghiem.DuLieu.SP_STTBACKUP_Result);
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 636);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.tbNgay);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.cbPhienBan);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gcBaR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBackupRestore";
            this.Text = "frmBackupRestore";
            this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSTTBACKUPResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcBaR;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBaR;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private DevExpress.XtraEditors.SimpleButton btRestore;
        private DevExpress.XtraEditors.SimpleButton btBackup;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbNgay;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.ComboBox cbPhienBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sPSTTBACKUPResultBindingSource;
    }
}