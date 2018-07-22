using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace TRACNGHIEM_DEMO1
{
	public partial class frmBoDe : Form
	{
		private int luachon;
		private int soCH;
		private SqlDataReader myreader;
		private int ret;
		private String maMonHoc;
		private String trinhDo;
		private String noiDung;
		private String a;
		private String b;
		private String c;
		private String d;
		private String dapAn;
		private String maGiaoVien;

		public frmBoDe()
		{
			InitializeComponent();
		}

		private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsBoDe.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void frmBoDe_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.

			dS.EnforceConstraints = false;
			this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
			this.bODETableAdapter.Fill(this.dS.BODE);
			//	this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
			// Thông tin cbx Cơ sở

			cbxTenCoSoBD.DataSource = Program.bds_dspm;
			cbxTenCoSoBD.DisplayMember = "TENCN";
			cbxTenCoSoBD.ValueMember = "TENSERVER";
			cbxTenCoSoBD.SelectedIndex = Program.mChinhanh;


			//tùy biến nút lệnh
			cbxTenCoSoBD.Enabled = false;
			btnGhi.Enabled = btnUndo.Enabled = false;
			txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = true;
			txtMaGV.ReadOnly = txtNoiDung.ReadOnly = true;
			txtDapAn.Enabled = txtTrinhDo.Enabled = false;
			txtMaMH.Enabled = false;
			txtCauHoi.Enabled = false;

			soCH = ID_CauHoi();
			MessageBox.Show("," + soCH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenCoSoBD.Enabled = true;
				//sINHVIENGridControl.Enabled = false;
				btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
				btnGhi.Enabled = btnUndo.Enabled = false;

				grbBoDe.Enabled = false;
				btnTroVe.Enabled = true;

			}// chỉ sáng lên ở nhóm TRUONG .
			else if (Program.mGroup == "GIAOVIEN")
			{
				cbxTenCoSoBD.Enabled = true;
				//sINHVIENGridControl.Enabled = false;
				btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
				btnGhi.Enabled = btnUndo.Enabled = true;

				grbBoDe.Enabled = true;
				btnTroVe.Enabled = true;
			}
			else if (Program.mGroup == "COSO")
			{
				cbxTenCoSoBD.Enabled = true;
				//sINHVIENGridControl.Enabled = false;
				btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
				btnGhi.Enabled = btnUndo.Enabled = false;

				grbBoDe.Enabled = false;
				btnTroVe.Enabled = true;
			}

		}
		private void load_MonHoc()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select MAMH from MONHOC ", Program.conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
			DataTable dt = new DataTable();
			da.Fill(dt);
			txtMaMH.DisplayMember = "MAMH";//Word là tên trường bạn muốn hiển thị trong combobox
			txtMaMH.ValueMember = "TENMH";
			txtMaMH.DataSource = dt;

		}
		private int ID_CauHoi()
		{
			int result;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SP_MAXID";
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@MaxID", SqlDbType.Int).Direction = ParameterDirection.Output;
			result = Program.ExecuteReader(cmd);
			int kq = Convert.ToInt16(cmd.Parameters["@MaxID"].Value);
			return kq;
		}

		private void btnTroVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				this.bODETableAdapter.Fill(this.dS.BODE);

			}
			catch (Exception ex)
			{
				MessageBox.Show(" Không thể cập nhật CSDL! :" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void cbxTenCoSoBD_SelectedIndexChanged(object sender, EventArgs e)
		{


			if (cbxTenCoSoBD.SelectedValue.ToString() == "System.Data.DataRowView") return;

			Program.servername = cbxTenCoSoBD.SelectedValue.ToString();

			if (cbxTenCoSoBD.SelectedIndex != Program.mChinhanh)
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
				this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
				this.bODETableAdapter.Fill(this.dS.BODE);
				//	maChiNhanh = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			}
		}

		private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 1;
			load_MonHoc();
			txtMaGV.Text = Program.username;
			btnThem.Enabled = false;
			grbBoDe.Enabled = true;
			bdsBoDe.AddNew();
			txtMaGV.ReadOnly = true;
			txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = false;
			txtNoiDung.ReadOnly = false;
			txtMaMH.Enabled = true;
			txtDapAn.Enabled = txtTrinhDo.Enabled = true;
			txtCauHoi.Enabled = true;

			// Mặc định về trình độ A /
			txtA.Text = txtB.Text = txtC.Text = txtD.Text = txtCauHoi.Text = txtMaMH.Text = txtNoiDung.Text = "";
			txtDapAn.SelectedItem = txtTrinhDo.SelectedItem = 0;
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
			btnInDSBD.Enabled = false;
		}

		private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 2;
			load_MonHoc();
			//	txtMaGV.Text = Program.username;
			// Cho thao tác trên các nút lệnh 
			grbBoDe.Enabled = true;
			btnTroVe.Enabled = btnUndo.Enabled = btnReload.Enabled = btnGhi.Enabled = true;
			bODEGridControl.Enabled = true;
			// Không cho thao tác trên các nút Button 
			btnThem.Enabled = btnInDSBD.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
			//thao tác trên các nút 
			txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = false;
			txtNoiDung.ReadOnly = false; txtMaMH.Enabled = true;
			txtMaMH.Enabled = false;
			txtCauHoi.Enabled = false;
			txtDapAn.Enabled = txtTrinhDo.Enabled = true;
			txtMaGV.ReadOnly = true;
			txtCauHoi.Enabled = true;
		}

		private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bdsBoDe.CancelEdit();
			bdsBoDe.Position = 1;
			bODEGridControl.Enabled = true;
			grbBoDe.Enabled = true;

			//	grbKhoa.Enabled = true;
			txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = true;
			txtMaGV.ReadOnly = txtNoiDung.ReadOnly = true;
			txtDapAn.Enabled = txtTrinhDo.Enabled = false;
			txtMaMH.Enabled = false;
			txtCauHoi.Enabled = true;
			btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
			btnGhi.Enabled = btnUndo.Enabled = false;
			this.bODETableAdapter.Fill(this.dS.BODE);

		}



		private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			luachon = 3;
			// cho thao tác trên các nút lệnh 
			bODEGridControl.Enabled = btnGhi.Enabled = btnUndo.Enabled = true;
			grbBoDe.Enabled = false;
			// Không cho thao tác trên các nút lệnh 
			btnReload.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnInDSBD.Enabled = false;
			MessageBox.Show("Bạn có muốn xóa KHOA này không ?\n Nhấn Ghi Để Hoàn tất Xóa ! ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		}

		private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (txtA.Text.Trim() == "")
				{
					MessageBox.Show("Đáp Án A không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtB.Text.Trim() == "")
				{
					MessageBox.Show("Đáp Án B không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtC.Text.Trim() == "")
				{
					MessageBox.Show("Đáp Án C không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtD.Text.Trim() == "")
				{
					MessageBox.Show("Đáp Án D không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				//if (txtMaGV.Text.Trim() == "")
				//	{
				//	MessageBox.Show("Mã Giáo Viên không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	return;
				//}
				if (txtNoiDung.Text.Trim() == "")
				{
					MessageBox.Show(" Nội Dung câu hỏi không được  Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtDapAn.Text.Trim() == "")
				{
					MessageBox.Show("Đáp Án  không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtMaMH.Text.Trim() == "")
				{
					MessageBox.Show("Mã môn học không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtTrinhDo.Text.Trim() == "")
				{
					MessageBox.Show("Trinh Độ không được Rỗng  ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (luachon == 1)
				{
					try
					{
						String doiID = "";
						int IDCauHoi1 = soCH + 1;
						doiID = IDCauHoi1.ToString();
						maMonHoc = txtMaMH.Text.Trim();
						trinhDo = txtTrinhDo.Text.Trim();
						noiDung = txtNoiDung.Text.Trim();
						a = txtA.Text.Trim();
						b = txtB.Text.Trim();
						c = txtC.Text.Trim();
						d = txtD.Text.Trim();
						dapAn = txtDapAn.Text.Trim();
						txtMaGV.Text = Program.username;
						String str_Lenh = "EXEC SP_THEMCAUHOI " + IDCauHoi1 + ",'" + maMonHoc + "','" + trinhDo + "', '" + noiDung + "','" + a + "', '" + b + "', '" + c + "', '" + d + "', '" + dapAn + "', '" + txtMaGV.Text.Trim() + "'";
						myreader = Program.ExecSqlDataReader(str_Lenh);

						if (myreader == null) return;
						myreader.Read();
						ret = myreader.RecordsAffected;
						myreader.Close();
						if (ret == -1)
						{
							MessageBox.Show("Mã Giáo Viên không tồn tại ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -2)
						{
							MessageBox.Show("Mã môn học không tồn tại ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -3)
						{
							MessageBox.Show("Câu hỏi bị trùng ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == 1)
						{
							MessageBox.Show("Thêm Câu hỏi thành công", "Thông báo", MessageBoxButtons.OK);
							this.bODETableAdapter.Fill(this.dS.BODE);
							//kHOAGridControl.Enabled = true;
							bODEGridControl.Enabled = true;
							btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
							btnGhi.Enabled = btnUndo.Enabled = false;
							grbBoDe.Enabled = false;
						}


					}
					catch (Exception e1)
					{
						MessageBox.Show("Không Thêm được dữ liệu ! " + e1.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}




					// Thêm câu hỏi vào bộ đề 
				}
				if (luachon == 2)
				{
					if (Program.username != txtMaGV.Text.Trim())
					{
						MessageBox.Show("Giáo Viên không được quyền sữa câu hỏi \n của Giáo Viên khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						String maMonHoc1 = txtMaMH.Text.Trim();
						String trinhDo1 = txtTrinhDo.Text.Trim();
						String noiDung1 = txtNoiDung.Text.Trim();
						String a1 = txtA.Text.Trim();
						String b1 = txtB.Text.Trim();
						String c1 = txtC.Text.Trim();
						String d1 = txtD.Text.Trim();
						String dapAn1 = txtDapAn.Text.Trim();
						String userGV = Program.username;
						int soTT = Convert.ToInt32(txtCauHoi.Text);
						String str_Lenh = "EXEC SP_SUACAUHOI '" + maMonHoc1 + "'," + soTT + ", '" + userGV + "', '" + trinhDo1 + "','" + noiDung1 + "', '" + a1 + "', '" + b1 + "', '" + c1 + "', '" + d1 + "', '" + dapAn1 + "'";
						myreader = Program.ExecSqlDataReader(str_Lenh);

						if (myreader == null) return;
						myreader.Read();
						ret = myreader.RecordsAffected;
						myreader.Close();
						if (ret == -1)
						{
							MessageBox.Show("Mã Giáo Viên không tồn tại ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -2)
						{
							MessageBox.Show("Mã môn học không tồn tại ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -3)
						{
							MessageBox.Show("Câu hỏi bị trùng ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == 1)
						{
							MessageBox.Show("Sữa  Câu hỏi thành công", "Thông báo", MessageBoxButtons.OK);
							this.bODETableAdapter.Fill(this.dS.BODE);
							//kHOAGridControl.Enabled = true;
							bODEGridControl.Enabled = true;
							btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
							btnGhi.Enabled = btnUndo.Enabled = false;
							grbBoDe.Enabled = false;
						}
					}
					//Sữa câu hỏi trong bộ đề 
				}
				if (luachon == 3)
				{
					if (Program.username != txtMaGV.Text.Trim())
					{
						MessageBox.Show("Giáo Viên không được quyền xóa Câu Hỏi  \n của Giáo Viên khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						// Xóa 1 câu hỏi trong bộ đề .
						int maCauHoi = Convert.ToInt32(txtCauHoi.Text);
						String maMH_Xoa = txtMaMH.Text.Trim();
						String maGV_Xoa = txtMaGV.Text.Trim();
						String trinhDo_Xoa = txtTrinhDo.Text.Trim();


						String str_Lenh = "EXEC SP_XOACAUHOI_BODE '" + maCauHoi + "'," + maMH_Xoa + ", '" + trinhDo_Xoa + "', '" + maGV_Xoa + "'";
						myreader = Program.ExecSqlDataReader(str_Lenh);

						if (myreader == null) return;
						myreader.Read();
						ret = myreader.RecordsAffected;
						myreader.Close();
						if (ret == -1)
						{
							MessageBox.Show("Mã Môn Học không tồn tại trong BỘ ĐỀ  ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -2)
						{
							MessageBox.Show("Mã Giáo Viên Không Tồn tại trong BỘ ĐỀ ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -3)
						{
							MessageBox.Show("Câu Hỏi không tồn  tại trong BỘ ĐỀ  ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == -4)
						{
							MessageBox.Show("Trình ĐỘ  không tồn  tại trong BỘ ĐỀ  ! ", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						else if (ret == 1)
						{
							MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
							this.bODETableAdapter.Fill(this.dS.BODE);
							//kHOAGridControl.Enabled = true;
							bODEGridControl.Enabled = true;
							btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTroVe.Enabled = true;
							btnGhi.Enabled = btnUndo.Enabled = false;
							grbBoDe.Enabled = false;
						}
					}
				}




			}
			catch (Exception ex)
			{
				MessageBox.Show("Không Thể Lưu Dữ Liệu ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
