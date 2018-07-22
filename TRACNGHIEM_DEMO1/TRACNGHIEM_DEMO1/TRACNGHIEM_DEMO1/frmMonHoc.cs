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
	public partial class frmMonHoc : Form
	{
		private int vitri = 0;
		private int luachon= 0;
		private String maMonHoc = "";
		private String tenMonHoc = "";
		private String mamonhocSua;
		private String tenmonhocSua;
		private int giatri;
		private int giatri3;
		private SqlDataReader myreader;
		public frmMonHoc()
		{
			InitializeComponent();
		}

		private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsMonHoc.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmMonHoc_Load(object sender, EventArgs e)
		{
			dS.EnforceConstraints = false;
			this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
			this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

			// cbx Tên Cở Sở.
			cbxTenCS.DataSource = Program.bds_dspm;
			cbxTenCS.DisplayMember = "TENCN";
			cbxTenCS.ValueMember = "TENSERVER";
			cbxTenCS.SelectedIndex = Program.mChinhanh;
			//tùy biến nút lệnh
			btnGhi.Enabled = btnUndo.Enabled = false;
			txtmaMH.ReadOnly = true;
			txtTenMH.ReadOnly = true;


			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenCS.Enabled = true;
				//sINHVIENGridControl.Enabled = false;
				btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
				btnGhi.Enabled = btnUndo.Enabled = false;

				txtmaMH.ReadOnly = true;
				txtTenMH.ReadOnly = true;
				btnTroVe.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else
			{
				cbxTenCS.Enabled = false;
			}

		}

		

		private void cbxTenCS_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTenCS.SelectedValue.ToString() == "System.Data.DataRowView") return;

			Program.servername = cbxTenCS.SelectedValue.ToString();

			if (cbxTenCS.SelectedIndex != Program.mChinhanh)
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
				this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
				this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
				//	maChiNhanh = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			}

		}
		private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			// Cho thao tác trên các nút button và text Box
			bdsMonHoc.AddNew();
			txtTenMH.ReadOnly = txtmaMH.ReadOnly = false;
			txtmaMH.Text = "";
			txtTenMH.Text = "";
			txtmaMH.Focus();
			btnGhi.Enabled = true;
			btnUndo.Enabled = true;
			btnTroVe.Enabled = true;
			// Không cho thao tác trên các nút button 
			btnThem.Enabled = false; // Sau khi Thêm xong . thì trả lại trạng thái abn đầu 
			btnXoa.Enabled = false;
			btnSua.Enabled = false;

			btnReload.Enabled = false;
			//sINHVIENGridControl.Enabled = false;
			btnInDSMH.Enabled = false;
		}

		private void btnTroVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bdsMonHoc.CancelEdit();
			if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
			mONHOCGridControl.Enabled = true;

			txtmaMH.Enabled = false;
			txtTenMH.Enabled = false;

			btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
			btnGhi.Enabled = btnUndo.Enabled = false;
		}

		private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			// Cho thao tác trên các nút lệnh 
			txtTenMH.ReadOnly= txtmaMH.ReadOnly = false;
			grbMonHoc.Enabled = true;
			btnTroVe.Enabled = btnUndo.Enabled = btnReload.Enabled = btnGhi.Enabled = true;
			mONHOCGridControl.Enabled = true;
			// Không cho thao tác trên các nút Button 
			btnThem.Enabled = btnInDSMH.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
		}

		private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// cho thao tác trên các nút lệnh 
			mONHOCGridControl.Enabled = btnGhi.Enabled = btnUndo.Enabled = true;
			// Không cho thao tác trên các nút lệnh 
			btnReload.Enabled  = btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnInDSMH.Enabled = false;
			MessageBox.Show("Bạn có muốn xóa MÔN HỌC này không ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		}

		private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			// Kiễm tra Rỗng 
			try
			{
				if (txtmaMH.Text.Trim() == "")
			{
				MessageBox.Show("Mã MÔN HỌC không được rỗng!  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				return;
			}
			if (txtTenMH.Text.Trim() == "")
			{
				MessageBox.Show("Tên MÔN HỌC không được rỗng!  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				return;
			}

			
				if(luachon == 1)
				{
					// Thêm Môn Học
					maMonHoc = txtmaMH.Text.Trim();
					tenMonHoc = txtTenMH.Text.Trim();

					String str_Lenh = "EXEC SP_THEMMH '" + maMonHoc + "', '" + tenMonHoc  + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					giatri = myreader.RecordsAffected;
					myreader.Close();
					if (giatri == -1)
					{
						MessageBox.Show(" Mã MÔN HỌC không tồn tại \n Vui Lòng Kiểm tra ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else if(giatri == 1)
					{
						MessageBox.Show("Thêm MÔN HỌC thành công  \n Vui Lòng Kiểm tra ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
						//kHOAGridControl.Enabled = true;
						mONHOCGridControl.Enabled = true;
						btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
						btnGhi.Enabled = btnUndo.Enabled = false;
						txtTenMH.ReadOnly = txtmaMH.ReadOnly = true;
					}

				}
				if (luachon == 2)
				{
					//Sữa 1 môn học
					 mamonhocSua = txtmaMH.Text.Trim();
					 tenmonhocSua = txtTenMH.Text;

					String str_Lenh = "EXEC SP_SUAMH '" + mamonhocSua + "', '" + tenmonhocSua + "'";
					myreader = Program.ExecSqlDataReader(str_Lenh);

					if (myreader == null) return;
					myreader.Read();
					giatri = myreader.RecordsAffected;
					myreader.Close();
					if (giatri3 == -1)
					{
						MessageBox.Show(" Sữa MÔN HOC  thất bại  \n Vui Lòng Kiểm tra ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else 
					{
						MessageBox.Show("Sữa MÔN HỌC thành công  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						//gridView1.Focus();
						this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
						//kHOAGridControl.Enabled = true;
						mONHOCGridControl.Enabled = true;
						btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
						btnGhi.Enabled = btnUndo.Enabled = false;
						txtTenMH.ReadOnly = txtmaMH.ReadOnly = false;
						//	grbMonHoc.Enabled = false;


					}
				}
				if(luachon == 3)
				{
					// Xóa 1 môn học 

				}
			} catch(Exception ex)
			{
				MessageBox.Show("Lỗi Lưu Dữ Liệu" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
