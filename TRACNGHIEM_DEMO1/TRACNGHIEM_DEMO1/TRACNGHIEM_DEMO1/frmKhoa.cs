using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace TRACNGHIEM_DEMO1
{
	public partial class frmKhoa : Form
	{
		public String maChiNhanh = "";
		public int vitri = 0;
		private  int luachon = 0;
		private String makhoa = "";
		private String tenkhoa = "";
		public string str_Lenh = "";
		private String maCS = "";
		private SqlDataReader myreader;
		public int ret = 0;
		frmLop fl;



		public frmKhoa()
		{
			InitializeComponent();
		}

		private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsKhoa.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmKhoa_Load(object sender, EventArgs e)
		{
			
			dS.EnforceConstraints = false;
			// TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
			this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
			this.kHOATableAdapter.Fill(this.dS.KHOA);
			// TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
			//this.lOPTableAdapter.Fill(this.dS.LOP);
			Program.bds_dsKhoa = bdsKhoa;


			maChiNhanh = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
			makhoa = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			tenkhoa = ((DataRowView)bdsKhoa[0])["TENKH"].ToString();

		
			

			cbxTenChiNhanh.DataSource = Program.bds_dspm;
			cbxTenChiNhanh.DisplayMember = "TENCN";
			cbxTenChiNhanh.ValueMember = "TENSERVER";
			cbxTenChiNhanh.SelectedIndex = Program.mChinhanh;
			// Tùy biến nút lệnh  
			txtMaCS.ReadOnly = true;
			btnGhi1.Enabled = btnUndo1.Enabled = false;
			txtMAKH.ReadOnly = txtTENKH.ReadOnly = true ;

			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{ 
				//Cho thao tác trên các nút lệnh
				cbxTenChiNhanh.Enabled = true;
				//kHOAGridControl.Enabled = false;
				btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled =  false;
				btnGhi1.Enabled = btnUndo1.Enabled = false;
				txtMAKH.ReadOnly = txtTENKH.ReadOnly = true;
				btnTroVe1.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else
			{
				cbxTenChiNhanh.Enabled = false;
			}
		}

		private void cbxTenChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTenChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return; 

			Program.servername = cbxTenChiNhanh.SelectedValue.ToString();
			
			if (cbxTenChiNhanh.SelectedIndex != Program.mChinhanh)
			{
				Program.mlogin = Program.remotelogin;
				Program.password = Program.remotepassword;  //  Connect đến Server xa.

			}
			else
			{
				Program.mlogin = Program.mloginDN;
				Program.password = Program.passwordDN;  //Connect đến server hiện tại.
			}
			if (Program.KetNoi() == 0)
			{
				MessageBox.Show("Lỗi kết nối Chi Nhánh  mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else
			{
				this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
				this.kHOATableAdapter.Fill(this.dS.KHOA);
				maChiNhanh = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
			}
		}


		private void grbKhoa_Enter(object sender, EventArgs e)
		{

		}

		private void mAKHLabel_Click(object sender, EventArgs e)
		{

		}

		private void tENKHLabel_Click(object sender, EventArgs e)
		{

		}

		private void mACSLabel_Click(object sender, EventArgs e)
		{

		}

		private void btnInKhoa_Click(object sender, EventArgs e)
		{

		}

		private void panelNutLenh_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void bdsKhoa_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void panelTenCN_Paint(object sender, PaintEventArgs e)
		{

		}

		private void txtMaCS_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void txtTENKH_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void txtMAKH_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void kHOAGridControl_Click(object sender, EventArgs e)
		{

		}

		private void bdsLop_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void btnThem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			bdsKhoa.AddNew();
			btnThem1.Enabled = false;
			txtMAKH.ReadOnly = txtTENKH.ReadOnly = false;
			txtMaCS.Text = maChiNhanh;
			grbKhoa.Enabled = true;
			txtMAKH.Text = "";
			txtTENKH.Text = "";
			// Cho thao tác trên các nút button 
			btnGhi1.Enabled = true;
			btnUndo1.Enabled = true;
			btnTroVe1.Enabled = true;
			// Không cho thao tác trên các nút button 
			btnXoa1.Enabled = false;
			btnSua1.Enabled = false;
			btnReload1.Enabled = false;
			kHOAGridControl.Enabled = false;
			btnInDSKhoa1.Enabled = false;
		}

		private void btnSua1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			grbKhoa.Enabled = true;
			txtMAKH.ReadOnly = txtTENKH.ReadOnly = false;
			btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = false;
			btnInDSKhoa1.Enabled = false;
			btnGhi1.Enabled = btnUndo1.Enabled = btnTroVe1.Enabled = true;
			kHOAGridControl.Enabled = true;
		}

		private void btnXoa1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// cho thao tác trên các nút lệnh 
			kHOAGridControl.Enabled = btnGhi1.Enabled = btnUndo1.Enabled = true;
			txtMAKH.ReadOnly = txtTENKH.ReadOnly = true;
			// Không cho thao tác trên các nút lệnh 
			btnReload1.Enabled = grbKhoa.Enabled = btnXoa1.Enabled = btnSua1.Enabled = btnThem1.Enabled = btnInDSKhoa1.Enabled = false;
			MessageBox.Show("Bạn có muốn xóa KHOA này không ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
		}

		private void btnUndo1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bdsKhoa.CancelEdit();
			bdsKhoa.Position = vitri;
			kHOAGridControl.Enabled = true;
			grbKhoa.Enabled = true;

		//	grbKhoa.Enabled = true;
			txtMAKH.ReadOnly = txtTENKH.ReadOnly = txtMaCS.ReadOnly = true;
			btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
			btnGhi1.Enabled = btnUndo1.Enabled = false;
		}

		private void btnReload1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.kHOATableAdapter.Fill(this.dS.KHOA);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnTroVe1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnGhi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (txtMAKH.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập mã Khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtTENKH.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập tên Khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				// Button Thêm Khoa .
				if (luachon == 1)
				{

					makhoa = txtMAKH.Text.Trim();
					tenkhoa = txtTENKH.Text.Trim();
					txtMaCS.Text = maChiNhanh;
					String str_Lenh = "EXEC SP_CHECKMAKHOA '" + makhoa + "', '" + tenkhoa + "','" + maChiNhanh + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);
					
					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("Mă KHOA  đã tồn tại  ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else
					{
						MessageBox.Show("Thêm KHOA thành công", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.kHOATableAdapter.Fill(this.dS.KHOA);
						kHOAGridControl.Enabled = true;
						kHOAGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
						btnGhi1.Enabled = btnUndo1.Enabled = false;
						//grbKhoa.Enabled = false;
					}


				}

				// button sữa Lớp 
				if (luachon == 2)
				{

					//makhoa = txtMAKH.Text.Trim();
					//tenkhoa = txtTENKH.Text.Trim();
					txtMaCS.Text = maChiNhanh;
					String str_Lenh = "EXEC SUA_KHOA '" + txtMAKH.Text.Trim() + "', '" + txtTENKH.Text.Trim() + "','" + maChiNhanh + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("Sửa KHOA THẤT BẠI  ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else
					{
						MessageBox.Show("UPDATE KHOA THÀNH CÔNG ! ", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.kHOATableAdapter.Fill(this.dS.KHOA);
						kHOAGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
						btnGhi1.Enabled = btnUndo1.Enabled = false;
						//grbKhoa.Enabled = false;
					}
				}



				if (luachon == 3)
				{
					String ERROR1 = "";
					makhoa = txtMAKH.Text.Trim();
					//tenkhoa = txtTENKH.Text.Trim();
					//txtMaCS.Text = maChiNhanh;
					//String str_Lenh = "EXEC XOA_KHOA '" + makhoa +"'";
					String str_Lenh = "EXEC XOA_KHOA '" + makhoa + "', '" + ERROR1 + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("KHOA không tồn tại \n KHOA đang chứa Lớp - Không thể xóa   ! " + ERROR1, "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else
					{
						MessageBox.Show("Xóa KHOA thành công  ! ", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.kHOATableAdapter.Fill(this.dS.KHOA);
						kHOAGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
						btnGhi1.Enabled = btnUndo1.Enabled = false;
					//	grbKhoa.Enabled = false;
					}


				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi Lưu Khoa" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}

