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
	public partial class txtTrinhDo : Form
	{
		private int vitri;
		private int luachon;
		private String maLop , maMonHoc , maGiaoVien , trinhDo = "";
		private int lan, thoigian,soCauHoi;
		private DateTime ngaythi;
		private SqlDataReader myreader;
		private int giatri;
		public txtTrinhDo()
		{
			InitializeComponent();
		}

		private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsGiaoVien_DangKy.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmGiaoVienDangKy_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
			
			dS.EnforceConstraints = false;
			this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
			this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
			//this.mONHOCTableAdapter.Fill(this.dS.MONHOC);


			//  Xử lý  cbx  CHi Nhánh
			cbxTenCoSo.DataSource = Program.bds_dspm;
			cbxTenCoSo.DisplayMember = "TENCN";
			cbxTenCoSo.ValueMember = "TENSERVER";
			cbxTenCoSo.SelectedIndex = Program.mChinhanh;

			// Tùy biến nút lệnh
			Load_MaLop();
			txtMaGV.Text = Program.username;
			Load_MonHoc();
			txtMaLop.SelectedIndex = -1;
			txtMaMH.SelectedIndex = -1;
			TuyBienNutLenh(true, false);
			btnUndo.Enabled = btnGhi.Enabled = false;

			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenCoSo.Enabled = true;
				btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
				btnGhi.Enabled = btnUndo.Enabled = false;

				grbGiaoVien_DangKy.Enabled = false;
				btnTroVe.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else
			{
				cbxTenCoSo.Enabled = false;
			}



		}
		private void Load_MaLop()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select MALOP from LOP ", Program.conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
			DataTable dt = new DataTable();
			da.Fill(dt);
			txtMaLop.DisplayMember = "MALOP";//Word là tên trường bạn muốn hiển thị trong combobox
			txtMaLop.ValueMember = "TENLOP";
			txtMaLop.DataSource = dt;

		}
		private void Load_MonHoc()
		{
			SqlDataAdapter da1 = new SqlDataAdapter("Select MAMH from MONHOC ", Program.conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
			DataTable dt1 = new DataTable();
			da1.Fill(dt1);
			txtMaMH.DisplayMember = "MAMH";//Word là tên trường bạn muốn hiển thị trong combobox
			txtMaMH.ValueMember = "TENMH";
			txtMaMH.DataSource = dt1;
		}
		private void TuyBienNutLenh(Boolean co, Boolean co1)
		{
			txtLan.ReadOnly = txtMaGV.ReadOnly = txtNgayThi.ReadOnly = co;
			txtSoCH.ReadOnly = txtThoiGian.ReadOnly = co;
			cbxTrinhDo.Enabled = txtMaLop.Enabled = txtMaMH.Enabled = co1;


		}

		private void btnTroVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void cbxTenCoSo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTenCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;

			Program.servername = cbxTenCoSo.SelectedValue.ToString();

			if (cbxTenCoSo.SelectedIndex != Program.mChinhanh)
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
				this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
				this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
				//	maChiNhanh = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			}
		}

		private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bdsGiaoVien_DangKy.CancelEdit();
			if (btnThem.Enabled == false) bdsGiaoVien_DangKy.Position = vitri;
			gIAOVIEN_DANGKYGridControl.Enabled = true;

			TuyBienNutLenh(true, false);
			btnGhi.Enabled = false;

			btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
			btnGhi.Enabled = btnUndo.Enabled = false;
			this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
		}

		private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			
			btnThem.Enabled = false;
			
			grbGiaoVien_DangKy.Enabled = true;
			bdsGiaoVien_DangKy.AddNew();
			TuyBienNutLenh(false, true);
			txtMaGV.ReadOnly = true;
			// Mặc định về trình độ A /
			txtMaGV.Text = Program.username;
			txtLan.Text = txtNgayThi.Text = txtSoCH.Text = txtThoiGian.Text = "";
			cbxTrinhDo.SelectedIndex = 0;
			txtMaLop.SelectedIndex = 0;
			txtMaMH.SelectedIndex = 0;

			//	cbxMaKhoa.SelectedValue.ToString();



			// Cho thao tác trên các nút button 
			btnGhi.Enabled = true;
			btnUndo.Enabled = true;
			btnTroVe.Enabled = true;
			// Không cho thao tác trên các nút button 
			btnXoa.Enabled = false;
			btnSua.Enabled = false;

			btnReload.Enabled = false;
			//sINHVIENGridControl.Enabled = false;
			btnInDSGVDK.Enabled = false;

		}

		private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			// Cho thao tác trên các nút lệnh 
			grbGiaoVien_DangKy.Enabled = true;
			txtMaGV.ReadOnly = true;
			TuyBienNutLenh(false, true);
			btnTroVe.Enabled = btnUndo.Enabled = btnReload.Enabled = btnGhi.Enabled = true;
			gIAOVIEN_DANGKYGridControl.Enabled = true;
			// Không cho thao tác trên các nút Button 
			btnThem.Enabled = btnInDSGVDK.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

		}

		private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// cho thao tác trên các nút lệnh 
			gIAOVIEN_DANGKYGridControl.Enabled = btnGhi.Enabled = btnUndo.Enabled = true;
			// Không cho thao tác trên các nút lệnh 
			btnReload.Enabled = grbGiaoVien_DangKy.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnInDSGVDK.Enabled = false;
			MessageBox.Show("bạn có muốn Xóa Giáo Viên Đăng Ký này  ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		}

		private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			
			try {
				if(txtLan.Text.Trim() == "" ||  Convert.ToInt32 (txtLan.Text.Trim() ) < 0)
				{
					MessageBox.Show("Lần Thi không được trống \n Lần Thi không được bé hơn 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}
				if(Convert.ToInt32(txtSoCH.Text.Trim()) <= 0   )
				{
					MessageBox.Show("Nhập sai câu hỏi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(Convert.ToInt32(txtThoiGian.Text.Trim()) <=0)
				{
					MessageBox.Show("Nhập Sai Thời gian !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(txtMaLop.Text.Trim() == "")
				{
					MessageBox.Show("Mã Lớp không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(txtMaMH.Text.Trim() == "")
				{
					MessageBox.Show("Mã Môn Học không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(txtNgayThi.Text == "")
				{
					MessageBox.Show("Ngày Thi không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(cbxTrinhDo.Text.Trim() == "")
				{
					MessageBox.Show("Vui Lòng chọn trình độ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(luachon ==1)
				{
					if(txtMaGV.Text.Trim() != Program.username)
					{
						MessageBox.Show("Giáo Viên không được quyền Thêm Giáo Viên khác.!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else {
						maLop = txtMaLop.Text.Trim();
						maMonHoc = txtMaMH.Text;
						trinhDo = cbxTrinhDo.Text.Trim();
						lan =Convert.ToInt32( txtLan.Text.Trim());
						thoigian = Convert.ToInt32(txtThoiGian.Text.Trim());
						maGiaoVien = Program.username;
						soCauHoi = Convert.ToInt32(txtSoCH.Text.Trim());
						ngaythi = Convert.ToDateTime(txtNgayThi.Text);
						



						String str_Lenh = "EXEC SP_THEM_DANG_KY_THI N'" + maGiaoVien + "', '" + maMonHoc + "', '" + maLop + "', '" + trinhDo + "', '" + ngaythi + "', " + lan + ", " + soCauHoi + ", " + thoigian +"";
						myreader = Program.ExecSqlDataReader(str_Lenh);

						if (myreader == null) return;
						myreader.Read();
						giatri = myreader.RecordsAffected;
						myreader.Close();
						if (giatri == -1)
						{
							MessageBox.Show(" Thêm Giản  Viên Đăng ký thất bại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						if (giatri == 1)
						{
							MessageBox.Show("Thêm Sinh Viên Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							//gridView1.Focus();
							this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
							//kHOAGridControl.Enabled = true;
							//sINHVIENGridControl.Enabled = true;
							btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
							btnGhi.Enabled = btnUndo.Enabled = false;
							grbGiaoVien_DangKy.Enabled = false;
						}
					}

				}
				if(luachon ==2)
				{
					if (txtMaGV.Text.Trim() != Program.username)
					{
						MessageBox.Show("Giáo Viên không được quyền Thêm Giáo Viên khác.!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						// Sữa Giáo Viên Đăng ký
					}
				}
				if(luachon==3)
				{
					if (txtMaGV.Text.Trim() != Program.username)
					{
						MessageBox.Show("Giáo Viên không được quyền Thêm Giáo Viên khác.!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						// Xóa Đăng ký Giáo Viên 
					}
				}
				

				
					
	

			} catch(Exception ex)
			{
				MessageBox.Show("Lỗi Lưu Dữ Liệu \n " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}
