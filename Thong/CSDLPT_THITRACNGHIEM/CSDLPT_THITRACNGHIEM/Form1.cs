using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSDLPT_THITRACNGHIEM
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btXemGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            frmGiangVien f = new frmGiangVien();
            f.MdiParent = this;
            f.Show();
           
                btXemGiangVien.Enabled = false;
                btXemSinhVien.Enabled = true;
                btBoDe.Enabled = true;
                btThemTaiKhoan.Enabled = true;
            if (Program.role == "COSO")
            {
                btDangKyThi.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
            }
            if (Program.role == "TRUONG")
            {
               
                btXemSinhVien.Enabled = true;
                btBoDe.Enabled = true;
                btThemTaiKhoan.Enabled = true;
                btDoiMK.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Program.hoTen.ToString();
            toolStripStatusLabel2.Text = Program.role.ToString();


            if(Program.role == "SINHVIEN")
            {
                rbGiangVien.Visible = false;
                rbbBangDiemTheoLop.Visible = false;
            }
            if (Program.role == "GIANGVIEN")
            {
                rbInAn.Visible = false;
                ribbonPageGroupXemGV.Visible = false;
                ribbonPageGroupXemSV.Visible = false;
                ribbonPageGroupThemTK.Visible = false;
                ribbonPageGroupDangKy.Visible = false;
            }
            if (Program.role == "TRUONG")
            {
                ribbonPageGroupDangKy.Visible = false;
                rbThiCu.Visible = false;
                ribbonPageGroupCauTLSV.Visible = false;
            }
            if (Program.role == "COSO")
            {
                btInBangDiemTheoLop.Enabled = true;
                rbThiCu.Visible = false;
                ribbonPageGroupCauTLSV.Visible = false;
            }
        }

        private void btXemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            groupBox1.Visible = false;
            frmXemSinhVien f = new frmXemSinhVien();
            f.MdiParent = this;
            f.Show();
            btXemGiangVien.Enabled = true;
            btXemSinhVien.Enabled = false;
            btBoDe.Enabled = true;
            btThemTaiKhoan.Enabled = true;
            if (Program.role == "COSO")
            {
                btDangKyThi.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
                btDoiMK.Enabled = true;
            }
            if (Program.role == "TRUONG")
            {
                btXemGiangVien.Enabled = true;
                btXemSinhVien.Enabled = false;
                btBoDe.Enabled = true;
                btThemTaiKhoan.Enabled = true;
                btDoiMK.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
            }
        }

        private void btDangKyThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            groupBox1.Visible = false;
            frmDangKyThi fr = new frmDangKyThi(this);
                fr.MdiParent = this;
                fr.Show();
            btXemGiangVien.Enabled = true;
            btXemSinhVien.Enabled = true;
            btBoDe.Enabled = true;
            btThemTaiKhoan.Enabled = true;
            if (Program.role == "COSO")
            {
                btDangKyThi.Enabled = false;
                btInBangDiemTheoLop.Enabled = true;
            }
        }

        private void btThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            btThi.Enabled = false;
            frmSinhVienThi f = new frmSinhVienThi();
            f.MdiParent = this;
            f.Show();
            if (Program.role == "GIANGVIEN")
            {
                btBoDe.Enabled = true;
            }
            if (Program.role == "SINHVIEN")
            {
                btInCauTraLoi.Enabled = true;
            }
        }

        private void btInCauTraLoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            frmRPCauTraLoi f = new frmRPCauTraLoi();
            f.MdiParent = this;
            f.Show();
            btInCauTraLoi.Enabled = false;
            if (Program.role == "SINHVIEN")
            {
                btThi.Enabled = true;
            }


        }
        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }
        private void btDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            groupBox1.Visible = false;
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                Program.conn.Close();
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.Show();
                this.Close();
                this.Dispose();
            }
            else
            {
                this.Refresh();
            }
        }

        private void btBoDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            if(Program.role == "GIANGVIEN")
            {
                frmBoDe_GV f = new frmBoDe_GV();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
            btXemGiangVien.Enabled = true;
            btXemSinhVien.Enabled = true;
            btBoDe.Enabled = false;
            btThemTaiKhoan.Enabled = true;
            if (Program.role == "GIANGVIEN")
            {
                btThi.Enabled = true;
                btDoiMK.Enabled = true;
            }
            if (Program.role == "COSO")
            {
                btDangKyThi.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
                btDoiMK.Enabled = true;
            }
        }

        private void btInBangDiemTheoLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            btInBangDiemTheoLop.Enabled = false;
            if(Program.role == "TRUONG")
            {
                btXemGiangVien.Enabled = true;
                btXemSinhVien.Enabled = true;
                btBoDe.Enabled = true;
                btThemTaiKhoan.Enabled = true;
                btDoiMK.Enabled = true;
                
            }
            if (Program.role == "COSO")
            {
                btXemGiangVien.Enabled = true;
                btXemSinhVien.Enabled = true;
                btBoDe.Enabled = true;
                btThemTaiKhoan.Enabled = true;
                btDangKyThi.Enabled = true;
                btDoiMK.Enabled = true;
            }
            frmRpDiemSinhVien f = new frmRpDiemSinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void btThemTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.MdiParent = this;
            f.Show();
            btXemGiangVien.Enabled = true;
            btXemSinhVien.Enabled = true;
            btBoDe.Enabled = true;
            btThemTaiKhoan.Enabled = false;
            btDoiMK.Enabled = true;
            if (Program.role == "COSO")
            {
                btDangKyThi.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
            }

        }

        private void btDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = false;
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.MdiParent = this;
            f.Show();
            btDoiMK.Enabled = false;
            btXemGiangVien.Enabled = true;
            btXemSinhVien.Enabled = true;
            btBoDe.Enabled = true;
            btThemTaiKhoan.Enabled = true;
            if (Program.role == "COSO")
            {
                btDangKyThi.Enabled = true;
                btInBangDiemTheoLop.Enabled = true;
            }
            if (Program.role == "TRUONG")
            {
                btXemGiangVien.Enabled = true;
                btXemSinhVien.Enabled = true;
                btBoDe.Enabled = true;
                btThemTaiKhoan.Enabled = true;
                

            }
        }
    }
}
