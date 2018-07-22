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

	public partial class frmLop : Form
	{
		String maKH = "";
		String maCN = "";
		String tenKhoa = "";
		String malop;
		String tenlop;
		private int luachon = 0;
		int vitri = 0;
		private int ret = -1;
		SqlDataReader myreader;
		private SqlDataReader myReader;
		private String strLenh = "";
		public frmLop()
		{
			InitializeComponent();
		}

		private void panelTenCoSo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsLop.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmLop_Load(object sender, EventArgs e)
		{

			dS.EnforceConstraints = false;

			this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
			this.lOPTableAdapter.Fill(this.dS.LOP);
			//this.kHOATableAdapter.Fill(this.dS.KHOA);


			maKH = ((DataRowView)bdsLop[0])["MAKH"].ToString();

			cbxTenChiNhanh.DataSource = Program.bds_dspm;
			cbxTenChiNhanh.DisplayMember = "TENCN";
			cbxTenChiNhanh.ValueMember = "TENSERVER";
			cbxTenChiNhanh.SelectedIndex = Program.mChinhanh;

			cbxMaKhoa.DataSource = bdsKhoa;
			SqlDataAdapter da = new SqlDataAdapter("Select MAKH from KHOA ", Program.conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
			DataTable dt = new DataTable();
			da.Fill(dt);
			cbxMaKhoa.DisplayMember = "MAKH";//Word là tên trường bạn muốn hiển thị trong combobox
			cbxMaKhoa.ValueMember = "TENKH";
			cbxMaKhoa.DataSource = dt;
			// Tùy biến nút lệnh
			txtMaLop.ReadOnly = txtTenLop.ReadOnly = true;
			cbxMaKhoa.Enabled = false;
			btnGhi.Enabled = btnUndo1.Enabled = false;

			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenChiNhanh.Enabled = true;
				//lOPGridControl.Enabled = false;
				txtMaLop.ReadOnly = txtTenLop.ReadOnly = true;
				btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = false;
				btnGhi.Enabled = btnUndo1.Enabled = false;
				grbLop.Enabled = false;
				btnTroVe1.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else
			{
				cbxTenChiNhanh.Enabled = false;
			}


		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			this.Close();
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
				this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
				this.lOPTableAdapter.Fill(this.dS.LOP);
				//maCN = ((DataRowView)bdsLop[0])["MAKH"].ToString();
			}
		}



		private void cbxMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (cbxMaKhoa.SelectedValue != null)
				Program.maKhoa = cbxMaKhoa.SelectedValue.ToString();
		}

		private void mAKHLabel1_Click(object sender, EventArgs e)
		{

		}

		private void btnThem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			bdsLop.AddNew();
			btnThem1.Enabled = false;
			grbLop.Enabled = true;
			txtMaLop.ReadOnly = txtTenLop.ReadOnly = false;
			txtMaLop.Text = "";
			txtTenLop.Text = "";
			cbxMaKhoa.SelectedIndex = 0;

			// Cho thao tác trên các nút button 
			btnGhi.Enabled = true;
			btnUndo1.Enabled = true;
			btnTroVe1.Enabled = true;
			// Không cho thao tác trên các nút button 
			btnXoa1.Enabled = false;
			btnSua1.Enabled = false;
			btnReload1.Enabled = false;
			//lOPGridControl.Enabled = false;
			btnInDSLop1.Enabled = false;
		}

		private void btnTroVe1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnReload1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.lOPTableAdapter.Fill(this.dS.LOP);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnXoa1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// CHo thao tác trên các nút lệnh
			btnGhi.Enabled = btnUndo1.Enabled = btnTroVe1.Enabled = true;
			txtMaLop.ReadOnly = txtTenLop.ReadOnly = true;
			// Không cho thao tác trên các nút lệnh 
			btnThem1.Enabled = btnSua1.Enabled = btnInDSLop1.Enabled = btnReload1.Enabled = false;
			btnXoa1.Enabled = false;
			MessageBox.Show("Bạn có muốn xóa LỚP  này không ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (bdsLop.Count == 0) btnXoa1.Enabled = false;
		}

		private void btnUndo1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bdsKhoa.CancelEdit();
			bdsKhoa.Position = vitri;
			lOPGridControl.Enabled = true;
			grbLop.Enabled = true;

			cbxMaKhoa.Enabled = false;
			txtMaLop.ReadOnly = txtTenLop.ReadOnly =  true;
			btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
			btnGhi.Enabled = btnUndo1.Enabled = false;
		}

		private void btnSua1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			vitri = bdsLop.Position;
			grbLop.Enabled = true;
			txtMaLop.ReadOnly = txtTenLop.ReadOnly = false;
			btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = false;
			btnInDSLop1.Enabled = btnTroVe1.Enabled = true;
			// Không cho thao tác trên false;
			btnGhi.Enabled = btnUndo1.Enabled = true;
			lOPGridControl.Enabled = true;
			cbxMaKhoa.Enabled = true;
			maKH = cbxMaKhoa.SelectedValue.ToString();
		}

		private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (txtMaLop.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập mã Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (txtTenLop.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập tên Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (luachon == 1)
				{

					malop = txtMaLop.Text.Trim();
					tenlop = txtTenLop.Text.Trim();
					cbxMaKhoa.Text = maKH;
					String str_Lenh = "EXEC SP_KIEMTRAMALOP1 '" + malop + "', '" + tenlop + "','" + maKH + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("Mă Lớp đã tồn tại  ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if (ret == 1)
					{
						MessageBox.Show("Thêm Lớp thành công", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.lOPTableAdapter.Fill(this.dS.LOP);
						lOPGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
						btnGhi.Enabled = btnUndo1.Enabled = false;
						//grbLop.Enabled = false;
					
					}

				}
				else if (luachon == 2)
				{
					malop = txtMaLop.Text.Trim();
					tenlop = txtTenLop.Text.Trim();
					cbxMaKhoa.Text = maKH;

					if (cbxMaKhoa.SelectedIndex != null)
					{
						String str_Lenh = "EXEC SUA_LOP '" + malop + "','" + tenlop + "','" + cbxMaKhoa.Text + "'";
						if (Program.ExecSqlNonQuery(str_Lenh) != 0)
						{
							MessageBox.Show("Sửa LỚP mới thất bại!", "THÔNG BÁO", MessageBoxButtons.OK);
							return;
						}
						MessageBox.Show("Sửa LỚP mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
						this.lOPTableAdapter.Fill(this.dS.LOP);
						lOPGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
						btnGhi.Enabled = btnUndo1.Enabled = false;

					}
				}


				else if (luachon == 3)
				{

					malop = txtMaLop.Text.Trim();
					String loi = "";
					//tenlop = txtTenLop.Text.Trim();
					//	cbxMaKhoa.Text = maKH;
					String str_Lenh = "EXEC XOA_LOP '" + malop + "', '" + loi + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					ret = myreader.RecordsAffected;
					myreader.Close();
					if (ret == -1)
					{
						MessageBox.Show("Lớp  không tồn tại! \n Hoặc có sinh viên - không thể xóa   ! ", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					else if (ret == 1)
					{
						MessageBox.Show("Xóa Lớp thành công ! ", "Thông báo", MessageBoxButtons.OK);
						//gridView1.Focus();
						this.lOPTableAdapter.Fill(this.dS.LOP);
						lOPGridControl.Enabled = true;
						btnThem1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnReload1.Enabled = btnTroVe1.Enabled = true;
						btnGhi.Enabled = btnUndo1.Enabled = false;


					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
			}
		}
	}
}
