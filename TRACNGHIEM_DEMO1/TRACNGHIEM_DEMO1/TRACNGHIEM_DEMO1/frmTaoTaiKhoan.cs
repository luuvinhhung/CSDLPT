using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM_DEMO1
{
	public partial class frmTaoTaiKhoan : Form
	{
		String tenDangNhap = "";
		String tenTaiKhoan = "";
		String passworDK = "";
		String nhapLaiPass = "";
		private int check;
		String quyenDN = "";
		public frmTaoTaiKhoan()
		{
			InitializeComponent();
		}

		private void btnReset_Load(object sender, EventArgs e)
		{
			dS.EnforceConstraints = false;
			this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
			this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
			this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
			// TODO: This line of code loads data into the 'dS.COSO' table. You can move, or remove it, as needed.
			this.cOSOTableAdapter.Fill(this.dS.COSO);


			if(Program.mGroup == "TRUONG")
			{
				cbxQuyen.Items.Add("TRUONG");
				cbxQuyen.SelectedIndex = 0;
			}else
			{
				cbxQuyen.Items.Add("COSO");
				cbxQuyen.Items.Add("GIAOVIEN");
				cbxQuyen.Items.Add("SINHVIEN");
				cbxQuyen.SelectedIndex = 0;
				cbxQuyen.SelectedIndex = 1;
				cbxQuyen.SelectedIndex = 2;
			}

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtMaSo.Text = txtNhapLaiMK.Text = txtTenDN.Text = txtPass.Text = "";
			txtTenDN.Focus();
		}

		private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsCoSo.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			try {
				check = -1;
				tenDangNhap = txtTenDN.Text.Trim();
				nhapLaiPass = txtNhapLaiMK.Text.Trim();
				tenTaiKhoan = txtMaSo.Text.Trim();
				quyenDN = cbxQuyen.SelectedItem.ToString();
				if (txtMaSo.Text.Trim() == "")
				{
					MessageBox.Show("Mã số không được để  Trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}
				if (txtNhapLaiMK.Text.Trim() == "")
				{
					MessageBox.Show("Mật Khẩu không được để trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}
				if (txtPass.Text.Trim() == "")
				{
					MessageBox.Show("Mật khẩu không được để trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}
				if (txtTenDN.Text.Trim() == "")
				{
					MessageBox.Show("Tên Đăng nhập không được để trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}
				if(txtPass.Text.Trim() != txtNhapLaiMK.Text.Trim())
				{
					MessageBox.Show("Mật Khẩu nhập không khớp với nhau ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Program.KetNoi();
				SqlCommand command = new SqlCommand("SP_CREATELOGIN", Program.conn);
				command.CommandType = CommandType.StoredProcedure;
				SqlParameter inParam1, inParam2, inParam3, inParam4, inParam5;

				inParam1 = new SqlParameter("@LGNAME", SqlDbType.VarChar);
				inParam1.Direction = System.Data.ParameterDirection.Input;
				inParam1.Value = tenDangNhap;
				command.Parameters.Add(inParam1);

				inParam2 = new SqlParameter("@PASS", SqlDbType.VarChar);
				inParam2.Direction = System.Data.ParameterDirection.Input;
				inParam2.Value = passworDK;
				command.Parameters.Add(inParam2);

				inParam3 = new SqlParameter("@USERNAME", SqlDbType.VarChar);
				inParam3.Direction = System.Data.ParameterDirection.Input;
				inParam3.Value = tenTaiKhoan;
				command.Parameters.Add(inParam3);

				inParam4 = new SqlParameter("@ROLE", SqlDbType.VarChar);
				inParam4.Direction = System.Data.ParameterDirection.Input;
				inParam4.Value = quyenDN;
				command.Parameters.Add(inParam4);

				try
				{
					command.ExecuteNonQuery();
					MessageBox.Show("Tạo tài khoản thành công.!.");

					txtPass.Text = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Tạo tài khoản Thất bại.!." + ex);
					txtPass.Text = "";
				}


			} catch(Exception ex)
			{
				MessageBox.Show("Lỗi tạo tài khoản !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
