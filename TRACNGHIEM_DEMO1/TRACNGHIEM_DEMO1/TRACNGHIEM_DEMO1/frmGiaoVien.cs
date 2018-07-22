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
	public partial class frmGiaoVien : Form
	{
		String maChiNhanh = "";
		private String maKhoa = "";
		private int luachon = 0;
		private int vitri = 0;
		private String maGiaoVien = "";
		private String hoGiaoVien = "";
		private String TenGiaoVien = "";
		private String DiaChiGiaoVien = "";
		private SqlDataReader myreader;
		private String  makhoachoose ="";
		int chon;
		private int giatri3;
		private int ret = 0;


		public frmGiaoVien()
		{
			InitializeComponent();
		}

		private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsGiaoVien.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmGiaoVien_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
			
			dS.EnforceConstraints = false;
			this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
			this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
			cbxTenChiNhanhGV.DataSource = Program.bds_dspm;
			cbxTenChiNhanhGV.DisplayMember = "TENCN";
			cbxTenChiNhanhGV.ValueMember = "TENSERVER";
			cbxTenChiNhanhGV.SelectedIndex = Program.mChinhanh;
			maKhoa = ((DataRowView)bdsGiaoVien[0])["MAKH"].ToString();
			//MaKhoa = ((DataRowView)bdsGiaoVien[0])["MAKH"].ToString();
			// Xử lý cbx Khoa / Hiễn thị mã khoa.
			cbxMAKH.DataSource = bdsKhoa;
			SqlDataAdapter da = new SqlDataAdapter("Select MAKH from KHOA ", Program.conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
			DataTable dt = new DataTable();
			da.Fill(dt);
			cbxMAKH.DisplayMember = "MAKH";//Word là tên trường bạn muốn hiển thị trong combobox
			cbxMAKH.ValueMember = "TENKH";
			cbxMAKH.DataSource = dt;
			// Tùy biến nút lệnh  
			//maKhoa = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			cbxMAKH.Enabled = false;
			btnGhi1.Enabled = btnUndo1.Enabled = false;
			txtDiaChiGV.ReadOnly = txtHoGV.ReadOnly = txtMaGV.ReadOnly = txtTenGV.ReadOnly = true;

			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenChiNhanhGV.Enabled = true;
				//gIAOVIENGridControl.Enabled = false;
				btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = false;
				btnGhi1.Enabled = btnUndo1.Enabled = false;
				
				grbGiaoVien.Enabled = false;
				btnTroVe.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else
			{
				cbxTenChiNhanhGV.Enabled = false;
			}

		}

		private void cbxTenChiNhanhGV_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTenChiNhanhGV.SelectedValue.ToString() == "System.Data.DataRowView") return;

			Program.servername = cbxTenChiNhanhGV.SelectedValue.ToString();

			if (cbxTenChiNhanhGV.SelectedIndex != Program.mChinhanh)
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
				this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
				this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
				//maChiNhanh = ((DataRowView)bdsKhoa[0])["MACN"].ToString();
			}
		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		

		private void btnReload_Click(object sender, EventArgs e)
		{
			try
			{
				this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		

		private void grbGiaoVien_Enter(object sender, EventArgs e)
		{

		}

		

		private void mAKHLabel_Click(object sender, EventArgs e)
		{

		}

		private void txtMaKH_EditValueChanged(object sender, EventArgs e)
		{

		}

		


		private void cbxMAKH_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxMAKH.SelectedValue != null)
				Program.maKhoa = cbxMAKH.SelectedValue.ToString();
		}

		private void btnTroVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnReload1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnThem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			grbGiaoVien.Enabled = true;
			bdsGiaoVien.AddNew();
			txtDiaChiGV.ReadOnly = txtHoGV.ReadOnly = txtMaGV.ReadOnly = txtTenGV.ReadOnly = false;
			txtMaGV.Text = "";
			txtHoGV.Text = "";
			txtTenGV.Text = "";
			txtDiaChiGV.Text = "";
			cbxMAKH.SelectedIndex = 0;
			// Cho thao tác trên các nút button 
			btnGhi1.Enabled = true;
			btnUndo1.Enabled = true;
			btnTroVe.Enabled = true;
			cbxMAKH.Enabled = true;
			// Không cho thao tác trên các nút button 
			btnThem1.Enabled = false; // Sau khi Thêm xong . thì trả lại trạng thái abn đầu 
			btnXoa1.Enabled = false;
			btnSua1.Enabled = false;
			btnReload1.Enabled = false;
			btnInDSGV.Enabled = false;
		}

		private void btnSua1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			// Cho thao tác trên các nút lệnh 
			grbGiaoVien.Enabled = true;
			txtDiaChiGV.ReadOnly = txtHoGV.ReadOnly = txtMaGV.ReadOnly = txtTenGV.ReadOnly = false;
			cbxMAKH.Enabled = true;
			txtMaGV.ReadOnly = true;
			btnTroVe.Enabled = btnUndo1.Enabled = btnReload1.Enabled = btnGhi1.Enabled = true;
			// Không cho thao tác trên các nút Button 
			btnThem1.Enabled = btnInDSGV.Enabled = btnSua1.Enabled = btnXoa1.Enabled = false;
		}

		private void btnUndo1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bdsGiaoVien.CancelEdit();
			bdsGiaoVien.Position = vitri;
			gIAOVIENGridControl.Enabled = true;
			grbGiaoVien.Enabled = true;

			//	grbKhoa.Enabled = true;
			txtDiaChiGV.ReadOnly = txtHoGV.ReadOnly = txtMaGV.ReadOnly = txtTenGV.ReadOnly = true;
			btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe.Enabled = true;
			btnGhi1.Enabled = btnUndo1.Enabled = false;
		}

		private void btnXoa1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// cho thao tác trên các nút lệnh 
			gIAOVIENGridControl.Enabled = btnGhi1.Enabled = btnUndo1.Enabled = true;
			grbGiaoVien.Enabled = false;
		   txtDiaChiGV.ReadOnly = txtHoGV.ReadOnly = txtMaGV.ReadOnly = txtTenGV.ReadOnly = true;
			// Không cho thao tác trên các nút lệnh 
			btnReload1.Enabled = btnXoa1.Enabled = btnSua1.Enabled = btnThem1.Enabled = btnInDSGV.Enabled = false;
			MessageBox.Show("Bạn có muốn xóa GIÁO VIÊN này không ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		}

		private void btnGhi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (txtMaGV.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập Mã  Giáo  VIên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtHoGV.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập Họ Giáo Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtTenGV.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập  Tên  Giáo  VIên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtDiaChiGV.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập  Địa Chỉ  Giáo  VIên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (luachon == 1) // Button Thêm Khoa.
				{
					hoGiaoVien = txtHoGV.Text.Trim();
					maGiaoVien = txtMaGV.Text.Trim();
					DiaChiGiaoVien = txtDiaChiGV.Text.Trim();
					TenGiaoVien = txtTenGV.Text.Trim();
					makhoachoose = cbxMAKH.Text;
					String str_Lenh = "EXEC SP_CHECKMAGV '" + maGiaoVien + "', N'" + hoGiaoVien + "',N'" + TenGiaoVien + "', N'" + DiaChiGiaoVien + "','" + makhoachoose + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("Thêm Giáo Viên thất bại ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if (ret == 1)
					{
						MessageBox.Show("Thêm Giáo Viên thành công", "Thông báo", MessageBoxButtons.OK);
						this.kHOATableAdapter.Fill(this.dS.KHOA);
						//kHOAGridControl.Enabled = true;
						gIAOVIENGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe.Enabled = true;
						btnGhi1.Enabled = btnUndo1.Enabled = false;
						grbGiaoVien.Enabled = false;
					}
				}
				if (luachon == 2)
				{
					String hoGiaoVien1 = txtHoGV.Text.Trim();
					String maGiaoVien1= txtMaGV.Text.Trim();
					String DiaChiGiaoVien1 = txtDiaChiGV.Text.Trim();
					String TenGiaoVien1 = txtTenGV.Text.Trim();
					String chonkhoa1 = cbxMAKH.Text;

					String str_Lenh = "EXEC SP_SUAGIAOVIEN '" + maGiaoVien1 + "', '" + hoGiaoVien1+ "','" + TenGiaoVien1 + "', '" + DiaChiGiaoVien1 + "','" + chonkhoa1  + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("Sữa Giáo Viên thất bại ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					if (ret == -2)
					{
						MessageBox.Show("Sữa Giáo Viên thất bại ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if (ret == 1)
					{
						MessageBox.Show("Sữa Giáo Viên thành công", "Thông báo", MessageBoxButtons.OK);
						this.kHOATableAdapter.Fill(this.dS.KHOA);
						//kHOAGridControl.Enabled = true;
						gIAOVIENGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe.Enabled = true;
						btnGhi1.Enabled = btnUndo1.Enabled = false;
						grbGiaoVien.Enabled = false;
					}
					}
				if (luachon == 3)
				{
					// Xóa Giáo viên /
					String magiaovien = txtMaGV.Text.Trim();
					String str_Lenh = "EXEC SP_XOAGV '" + magiaovien + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					giatri3 = myreader.RecordsAffected;
					myreader.Close();
					if (giatri3 == -1)
					{
						MessageBox.Show("GIÁO  VIÊN đang có BỘ ĐỀ  \n  Không thể xóa   ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if (giatri3 == -1)
					{
						MessageBox.Show("GIÁO  VIÊN không tồn tại  \n  Không thể xóa   ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if (giatri3 == 1)
					{
						MessageBox.Show("Xóa GIÁO  VIÊN thành công  ! ", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
						gIAOVIENGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe.Enabled = true;
						btnGhi1.Enabled = btnUndo1.Enabled = false;
						grbGiaoVien.Enabled = false;

					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi Lưu Giảng viên  ! " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
	}
