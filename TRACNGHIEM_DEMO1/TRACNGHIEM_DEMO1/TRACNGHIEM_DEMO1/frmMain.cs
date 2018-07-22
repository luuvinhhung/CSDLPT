using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRACNGHIEM_DEMO1
{
	public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public frmMain()
		{


			InitializeComponent();
			btnDangNhap.PerformClick();
			if (!mvvmContext1.IsDesignMode)
				InitializeBindings();


		}
		private Form CheckExists(Type ftype)
		{
			foreach (Form f in this.MdiChildren)
				if (f.GetType() == ftype)
					return f;
			return null;
		}

		public void HienThiMenu()
		{
			maSo.Text = "Mã NV: " + Program.username + " -";
			hoTen.Text = "Họ tên nhân viên: " + Program.mHoten + " -";
			nhom.Text = "Nhóm: " + Program.mGroup;
			// Phân quyền
		}
		void InitializeBindings()
		{
			var fluent = mvvmContext1.OfType<MainViewModel>();

		}

		private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try {
				frmDangNhap f = new frmDangNhap();
				f.StartPosition = FormStartPosition.CenterScreen;
				f.ShowDialog();
			} catch(Exception ex)
			{
				MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}


		private void frmMain_Load_1(object sender, EventArgs e)
		{
			HienThiMenu();
		}

		private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnKhoa.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(frmKhoa));
				if (frm != null) frm.Activate();
				else
				{
					frmKhoa f = new frmKhoa();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnLop.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(frmLop));
				if (frm != null) frm.Activate();
				else
				{
					frmLop f = new frmLop();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnThongTinGV.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(frmGiaoVien));
				if (frm != null) frm.Activate();
				else
				{
					frmGiaoVien f = new frmGiaoVien();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnSinhVien.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(frmSinhVien));
				if (frm != null) frm.Activate();
				else
				{
					frmSinhVien f = new frmSinhVien();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void barButtonItem2_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnMonHoc.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(frmMonHoc));
				if (frm != null) frm.Activate();
				else
				{
					frmMonHoc f = new frmMonHoc();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void barButtonItem2_ItemClick_4(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnBoDe.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(frmBoDe));
				if (frm != null) frm.Activate();
				else
				{
					frmBoDe f = new frmBoDe();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			btnDangXuat.Enabled = false;
			//btnDangNhap.Enabled = false;
			ribbonPage2.Visible = false;
			DialogResult dlr = MessageBox.Show("Bạn thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
			if (dlr == DialogResult.Yes)
			{
				Program.conn.Close();
				this.Hide();
				frmDangNhap f = new frmDangNhap();
				f.ShowDialog();
				this.Close();
				this.Dispose();
			}

			else
			{
				this.Refresh();
			}

		}

		private void btnGiaoVienDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnGiaoVienDangKy.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(txtTrinhDo));
				if (frm != null) frm.Activate();
				else
				{
					txtTrinhDo f = new txtTrinhDo();
					f.MdiParent = this;
					f.Show();
				}
			}
		}

		private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
			frm.StartPosition = FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//groupBox1.Visible = false;
			btnThi.Enabled = false;
			frmThi f = new frmThi();
			f.MdiParent = this;
			f.Show();
			if (Program.mGroup == "GIAOVIEN")
			{
				btnBoDe.Enabled = true;
			}
			if (Program.mGroup == "SINHVIEN")
			{
			//	btInCauTraLoi.Enabled = true;
			}
		}

		private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (Program.KetNoi() == 0)
			{
				btnBangDiem.Enabled = false;
			}
			else
			{
				Form frm = this.CheckExists(typeof(BangDiem));
				if (frm != null) frm.Activate();
				else
				{
					BangDiem f = new BangDiem();
					f.MdiParent = this;
					f.Show();
				}
			}
		}
	}
}
