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

namespace CSDLPT_THITRACNGHIEM
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
			this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
			TENCN.SelectedIndex = 1;
			TENCN.SelectedIndex = 0;

		}

		private void bds_DSPM_SelectedIndexChanged(object sender, EventArgs e)
		{
			Program.tenServer = TENCN.SelectedValue.ToString();

		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			txt_Pass.Text = "";
			txt_User.Text = "";
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			DialogResult traloi;
			traloi = MessageBox.Show("Bạn có muốn thoát chương trình!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if(traloi == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			if (txt_User.Text.Trim() == "" || txt_Pass.Text.Trim() == "")
			{
				MessageBox.Show("Tài Khoảng Đăng Nhập không hợp lệ! ", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_Pass.Focus();
				txt_User.Focus();
				return;

			}
			Program.username = txt_User.Text;
			Program.password = txt_Pass.Text;
			if (Program.KetNoi() == 0) return;
			MessageBox.Show("Đăng nhập thành công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
			SqlDataReader myReader;
			String strLengh = "Exec SP_DANGNHAP" + Program.mlogin + "'";
			myReader = Program.ExecSqlDataReader(strLengh);
			if(myReader == null)
			{
				return;
			}
			myReader.Read(); //  trả về true là đọc thành công / hết !  trả về false là chưa đọc hết
			Program.username = myReader.GetString(0);
			if (Convert.IsDBNull(Program.username))
			{
				MessageBox.Show("Login Đăng nhập không có quyền truy cập CSDL!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Program.mHoten = myReader.GetString(1);
			Program.mGroup = myReader.GetString(2);
			myReader.Close();
			Program.conn.Close();
			this.Close();

			

		}

		
		private void txt_User_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
