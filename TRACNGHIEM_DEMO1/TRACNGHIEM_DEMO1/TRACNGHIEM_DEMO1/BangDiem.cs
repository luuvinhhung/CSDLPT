using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM_DEMO1
{
	public partial class BangDiem : Form
	{
		public BangDiem()
		{
			InitializeComponent();
		}

		private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsBangDiem.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS);
			
		}

		private void BangDiem_Load(object sender, EventArgs e)
		{
			dS.EnforceConstraints = false;
			this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
			this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

			// Xử lý cbx Tên Cơ sở
			cbxTenCoSo.DataSource = Program.bds_dspm;
			cbxTenCoSo.DisplayMember = "TENCN";
			cbxTenCoSo.ValueMember = "TENSERVER";
			cbxTenCoSo.SelectedIndex = Program.mChinhanh;

			if (Program.mGroup == "TRUONG") // Chỉ được xem /
			{
				//Cho thao tác trên các nút lệnh
				cbxTenCoSo.Enabled = true;
				//sINHVIENGridControl.Enabled = false;
				

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
				this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
				this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
				//	maChiNhanh = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
			}
		}
	}
}
