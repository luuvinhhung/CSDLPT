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
	public partial class frmDangNhap : Form
	{
		private String phanQuyen = "";
		public frmDangNhap()
		{
			InitializeComponent();
		}
		

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
			this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
			cbxTenCN.SelectedIndex = 1;
			cbxTenCN.SelectedIndex = 0;


		}

		private void cbxTenCN_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTenCN.SelectedValue != null)
				Program.servername = cbxTenCN.SelectedValue.ToString();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			this.txtUser.ResetText();
			this.txtPass.ResetText();
			txtUser.Focus();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (txtUser.Text.Trim() == "")
			{
				MessageBox.Show(" Bạn chưa nhập tên đăng nhập ", " Báo lỗi đăng nhập", MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtUser.Focus();
				return;
			}
			else if (txtPass.Text.Trim() == "")
			{
				MessageBox.Show(" Bạn chưa nhập mật khẩu ", " Báo lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUser.Focus();
				return;
			}
			else if(cbxPhanQuyen.Text == "")
			{

				MessageBox.Show(" Bạn chưa chọn quyền truy cập ", " Báo lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUser.Focus();
				return;
			}
			if(cbxPhanQuyen.Text == "GIAOVIEN")
			{

				Program.username = txtUser.Text;
				Program.password = txtPass.Text;
				Program.mlogin = txtUser.Text;
				Program.password = txtPass.Text;

				if (Program.KetNoi() == 0) return;

				Program.mChinhanh = cbxTenCN.SelectedIndex;
				Program.bds_dspm = bdsDSPM;

				Program.mloginDN = Program.mlogin;
				Program.passwordDN = Program.password;

				SqlDataReader myReader; // 

				String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

				myReader = Program.ExecSqlDataReader(strLenh);
				if (myReader == null) return;


				myReader.Read(); //  trả về true là đọc thành công / hết !  trả về false là chưa đọc hết
				Program.username = myReader.GetString(0);
				if (Convert.IsDBNull(Program.username))
				{
					MessageBox.Show("Login Đăng nhập không có quyền truy cập CSDL!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Program.mHoten = myReader.GetString(1);

				Program.mGroup = myReader.GetString(2);

				//HienThiMenu();
				//MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
				btnOK.Enabled = false;
				myReader.Close();
				Program.conn.Close();
				this.Close();

			}
			else if (cbxPhanQuyen.Text == "SINHVIEN")
			{

				Program.username = txtUser.Text;
				Program.password = txtPass.Text;
				Program.mlogin = txtUser.Text;
				Program.password = txtPass.Text;

				if (Program.KetNoi() == 0) return;

				Program.mChinhanh = cbxTenCN.SelectedIndex;
				Program.bds_dspm = bdsDSPM;

				Program.mloginDN = Program.mlogin;
				Program.passwordDN = Program.password;

				SqlDataReader myReader; // 

				String strLenh = "EXEC SP_DANGNHAP_SV '" + Program.mlogin + "'";

				myReader = Program.ExecSqlDataReader(strLenh);
				if (myReader == null) return;


				myReader.Read(); //  trả về true là đọc thành công / hết !  trả về false là chưa đọc hết
				Program.username = myReader.GetString(0);
				if (Convert.IsDBNull(Program.username))
				{
					MessageBox.Show("Login Đăng nhập không có quyền truy cập CSDL!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Program.mHoten = myReader.GetString(1);

				Program.mGroup = myReader.GetString(2);
				Program.malop = myReader.GetString(3);
				//HienThiMenu();
				//MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
				btnOK.Enabled = false;
				myReader.Close();
				Program.conn.Close();
				this.Close();
			}



		}

		private void cbxPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
		{
			phanQuyen = cbxPhanQuyen.SelectedItem.ToString();
		}
	}
}
