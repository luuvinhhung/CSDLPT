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
	public partial class frmSinhVien : Form
	{
		private int luachon = 0;
		private int vitri;
		private String maSV = "";
		private String tenSV = "";
		private String hoSV = "";
		private String DiaChiSV = "";
		private String malopSV = "";
		private String ngaysinhSV = "";
		private SqlDataReader myreader;
		private  int giatri = 0;
		private int giatri3 = 0;
		public frmSinhVien()
		{
			InitializeComponent();
		}






		private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			// Cho thao tác trên các nút lệnh 
			grbSinhVien.Enabled = true;
			cbxMaLop.Enabled = true;
			btnTroVe.Enabled = btnUndo.Enabled = btnReload.Enabled = btnGhi.Enabled = true;
			sINHVIENGridControl.Enabled = true;
			// Không cho thao tác trên các nút Button 
			btnThem.Enabled = btnInDSSV.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
		}

		private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			btnThem.Enabled = false;
			vitri = bdsSinhVien.Position;
			grbSinhVien.Enabled = true;
			txtDiaChi.Text = "";
			txtHoSV.Text = "";
			txtTenSV.Text = "";
			txtNgaySinh.Text = "";
			txtMaSV.Text = "";
			cbxMaLop.SelectedIndex = 0;
			//	cbxMaKhoa.SelectedValue.ToString();



			// Cho thao tác trên các nút button 
			btnGhi.Enabled = true;
			btnUndo.Enabled = true;
			btnTroVe.Enabled = true;
			cbxMaLop.Enabled = true;
			// Không cho thao tác trên các nút button 
			btnThem.Enabled = true; // Sau khi Thêm xong . thì trả lại trạng thái abn đầu 
			btnXoa.Enabled = false;
			btnSua.Enabled = false;

			btnReload.Enabled = false;
			//sINHVIENGridControl.Enabled = false;
			btnInDSSV.Enabled = false;
		}

		private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try {
				if(txtMaSV.Text.Trim() =="")
				{
					MessageBox.Show("Mã Sinh Viên không được Rỗng! \n " , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(txtHoSV.Text.Trim() == "")
				{
					MessageBox.Show("Họ Sinh Viên không được Rỗng! \n ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtTenSV.Text.Trim() == "")
				{
					MessageBox.Show("Tên Sinh Viên không được Rỗng! \n ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtDiaChi.Text.Trim() == "")
				{
					MessageBox.Show("Địa Chỉ Sinh Viên không được Rỗng! \n ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtNgaySinh.Text.Trim() == "")
				{
					MessageBox.Show("Ngày Sinh của  Sinh Viên không được Rỗng! \n ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(luachon == 1)
				{
					
						// chạy EXEC THÊM SINH VIÊN
						maSV = txtMaSV.Text.Trim();
						hoSV = txtHoSV.Text.Trim();
						tenSV = txtTenSV.Text.Trim();
						DiaChiSV = txtDiaChi.Text.Trim();
						ngaysinhSV = txtNgaySinh.Text;
						malopSV = cbxMaLop.Text;

						String str_Lenh = "EXEC SP_CHECKMASV N'" + maSV + "', N'" + hoSV + "', N'" + tenSV + "', N'" + ngaysinhSV + "', N'" + DiaChiSV + "', N'" + malopSV +  "'";
						myreader = Program.ExecSqlDataReader(str_Lenh);

						if (myreader == null) return;
						myreader.Read();
						giatri = myreader.RecordsAffected;
						myreader.Close();
						if(giatri == -1) {
							MessageBox.Show(" Mã Sinh Viên Bị Trùng \n Vui Lòng Kiểm tra " , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						if(giatri ==1)
						{
							MessageBox.Show("Thêm Sinh Viên Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							//gridView1.Focus();
							this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
							//kHOAGridControl.Enabled = true;
							sINHVIENGridControl.Enabled = true;
							btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
							btnGhi.Enabled = btnUndo.Enabled = false;
							grbSinhVien.Enabled = false;
						}
				}
				if(luachon ==2)
				{
					//Sữa Sinh Viên
					try { }catch(Exception ex)
					{
						MessageBox.Show("Lỗi khi Sữa Sinh Viên" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (luachon == 3)
				{
					// Xóa Sinh Viên 
					String masinhvien = txtMaSV.Text.Trim();
					String str_Lenh = "EXEC SP_XOASV '" + masinhvien + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					giatri3 = myreader.RecordsAffected;
					myreader.Close();
					if (giatri3 == -1)
					{
						MessageBox.Show("SINH VIÊN không tồn tại \n SINH VIÊN  đang có Bảng Điểm - Không thể xóa   ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if(giatri3 == 1)
					{
						MessageBox.Show("Xóa SINH VIÊN thành công  ! ", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
						sINHVIENGridControl.Enabled = true;
						btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
						btnGhi.Enabled = btnUndo.Enabled = false;
						return;

					}
				}


			} catch(Exception ex)
			{
				MessageBox.Show("Lỗi Lưu Dữ Liệu \n " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// cho thao tác trên các nút lệnh 
			sINHVIENGridControl.Enabled = btnGhi.Enabled = btnUndo.Enabled = true;
			// Không cho thao tác trên các nút lệnh 
			btnReload.Enabled = grbSinhVien.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnInDSSV.Enabled = false;
			MessageBox.Show("Bạn có muốn xóa SINH VIÊN này không ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		}

		private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			bdsSinhVien.CancelEdit();
			if (btnThem.Enabled == false) bdsSinhVien.Position = vitri;
			sINHVIENGridControl.Enabled = true;

			txtMaSV.Enabled = false;
			txtHoSV.Enabled = false;
			txtTenSV.Enabled = false;
			txtDiaChi.Enabled = false;
			txtNgaySinh.Enabled = false;
			cbxMaLop.Enabled = false;
			btnGhi.Enabled = false;

			btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
			btnGhi.Enabled = btnUndo.Enabled = false;
		}

		private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnInDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void btnTroVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsSinhVien.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			dS.EnforceConstraints = false;
			// TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
			this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
			this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
			// cbx Tên Cơ sở  

			cbxTenCoSo.DataSource = Program.bds_dspm;
			cbxTenCoSo.DisplayMember = "TENCN";
			cbxTenCoSo.ValueMember = "TENSERVER";
			cbxTenCoSo.SelectedIndex = Program.mChinhanh;

			SqlDataAdapter da = new SqlDataAdapter("Select MALOP from LOP ", Program.conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
			DataTable dt = new DataTable();
			da.Fill(dt);
			cbxMaLop.DisplayMember = "MALOP";//Word là tên trường bạn muốn hiển thị trong combobox
			cbxMaLop.ValueMember = "TENLOP";
			cbxMaLop.DataSource = dt;
			//  Tùy biến nút lệnh
			btnGhi.Enabled = btnUndo.Enabled = false;
			cbxMaLop.Enabled = false;

			

			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenCoSo.Enabled = true;
				//sINHVIENGridControl.Enabled = false;
				btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
				btnGhi.Enabled = btnUndo.Enabled = false;

				grbSinhVien.Enabled = false;
				btnTroVe.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else
			{
				cbxTenCoSo.Enabled = false;
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
				this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
				this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
			//	maChiNhanh = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			}
		}

		private void cbxMaLop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxMaLop.SelectedValue != null)
				Program.malop = cbxMaLop.SelectedValue.ToString();
		}

		private void panelTenCS_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
