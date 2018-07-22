namespace CSDLPT_THITRACNGHIEM
{
	partial class frmDangNhap
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
			System.Windows.Forms.Label lbTenCN;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Reset = new System.Windows.Forms.Button();
			this.btn_Login = new System.Windows.Forms.Button();
			this.txt_Pass = new System.Windows.Forms.TextBox();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TENCN = new System.Windows.Forms.ComboBox();
			this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
			this.tRACNGHIEMDataSet = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSet();
			this.v_DSPMTableAdapter = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter();
			this.tableAdapterManager = new CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
			this.v_DSPMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.v_DSPMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			lbTenCN = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingNavigator)).BeginInit();
			this.v_DSPMBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTenCN
			// 
			lbTenCN.AutoSize = true;
			lbTenCN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			lbTenCN.Location = new System.Drawing.Point(6, 50);
			lbTenCN.Name = "lbTenCN";
			lbTenCN.Size = new System.Drawing.Size(166, 25);
			lbTenCN.TabIndex = 0;
			lbTenCN.Text = "Tên Chi Nhánh :";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Controls.Add(this.btn_Exit);
			this.groupBox1.Controls.Add(this.btn_Reset);
			this.groupBox1.Controls.Add(this.btn_Login);
			this.groupBox1.Controls.Add(this.txt_Pass);
			this.groupBox1.Controls.Add(this.txt_User);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(lbTenCN);
			this.groupBox1.Controls.Add(this.TENCN);
			this.groupBox1.Location = new System.Drawing.Point(152, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(539, 262);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(418, 208);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(96, 39);
			this.btn_Exit.TabIndex = 7;
			this.btn_Exit.Text = "Thoát";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Reset
			// 
			this.btn_Reset.Location = new System.Drawing.Point(299, 208);
			this.btn_Reset.Name = "btn_Reset";
			this.btn_Reset.Size = new System.Drawing.Size(100, 39);
			this.btn_Reset.TabIndex = 7;
			this.btn_Reset.Text = "Tạo Lại";
			this.btn_Reset.UseVisualStyleBackColor = true;
			this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(175, 208);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(97, 39);
			this.btn_Login.TabIndex = 6;
			this.btn_Login.Text = "OK";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// txt_Pass
			// 
			this.txt_Pass.Location = new System.Drawing.Point(175, 155);
			this.txt_Pass.Name = "txt_Pass";
			this.txt_Pass.PasswordChar = '*';
			this.txt_Pass.Size = new System.Drawing.Size(339, 29);
			this.txt_Pass.TabIndex = 5;
			// 
			// txt_User
			// 
			this.txt_User.Location = new System.Drawing.Point(175, 104);
			this.txt_User.Name = "txt_User";
			this.txt_User.Size = new System.Drawing.Size(339, 29);
			this.txt_User.TabIndex = 4;
			this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(66, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật Khẩu :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(15, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tên Đăng Nhập :";
			// 
			// TENCN
			// 
			this.TENCN.DataSource = this.bdsDSPM;
			this.TENCN.DisplayMember = "TENCN";
			this.TENCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TENCN.FormattingEnabled = true;
			this.TENCN.Location = new System.Drawing.Point(175, 43);
			this.TENCN.Name = "TENCN";
			this.TENCN.Size = new System.Drawing.Size(339, 32);
			this.TENCN.TabIndex = 1;
			this.TENCN.ValueMember = "TENSERVER";
			this.TENCN.SelectedIndexChanged += new System.EventHandler(this.bds_DSPM_SelectedIndexChanged);
			// 
			// bdsDSPM
			// 
			this.bdsDSPM.DataMember = "V_DSPM";
			this.bdsDSPM.DataSource = this.tRACNGHIEMDataSet;
			// 
			// tRACNGHIEMDataSet
			// 
			this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
			this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// v_DSPMTableAdapter
			// 
			this.v_DSPMTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.UpdateOrder = CSDLPT_THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// v_DSPMBindingNavigator
			// 
			this.v_DSPMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.v_DSPMBindingNavigator.BindingSource = this.bdsDSPM;
			this.v_DSPMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.v_DSPMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.v_DSPMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.v_DSPMBindingNavigatorSaveItem});
			this.v_DSPMBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.v_DSPMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.v_DSPMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.v_DSPMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.v_DSPMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.v_DSPMBindingNavigator.Name = "v_DSPMBindingNavigator";
			this.v_DSPMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.v_DSPMBindingNavigator.Size = new System.Drawing.Size(878, 25);
			this.v_DSPMBindingNavigator.TabIndex = 1;
			this.v_DSPMBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// v_DSPMBindingNavigatorSaveItem
			// 
			this.v_DSPMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.v_DSPMBindingNavigatorSaveItem.Enabled = false;
			this.v_DSPMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("v_DSPMBindingNavigatorSaveItem.Image")));
			this.v_DSPMBindingNavigatorSaveItem.Name = "v_DSPMBindingNavigatorSaveItem";
			this.v_DSPMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.v_DSPMBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 373);
			this.Controls.Add(this.v_DSPMBindingNavigator);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmDangNhap";
			this.Text = "frmDangNhap";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.frmDangNhap_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingNavigator)).EndInit();
			this.v_DSPMBindingNavigator.ResumeLayout(false);
			this.v_DSPMBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private TRACNGHIEMDataSet tRACNGHIEMDataSet;
		private System.Windows.Forms.BindingSource bdsDSPM;
		private TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
		private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator v_DSPMBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton v_DSPMBindingNavigatorSaveItem;
		public System.Windows.Forms.ComboBox TENCN;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_Reset;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.TextBox txt_Pass;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}