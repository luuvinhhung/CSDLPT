using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PTITTracNghiem.GiaoDien;
using PTITTracNghiem.Reports;

namespace PTITTracNghiem
{

    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
       
        public void dangxuatForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() != typeof(frmDangNhap))
                {
                    f.Close();
                }
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
            
        }
        public void disableControlMain(bool b)
        {
            //navBarControlLeft.Visible = b;
            //ribbonKhaoThi.Visible = b;
            //ribbonReport.Visible = b;
            //btnDoiPass.Enabled = b;
        }

        public void GiaoVien(bool b)
        {
            //navBarControlLeft.Visible = b;
            //btnDoiPass.Enabled = b;
            //btnTaoTaiKhoan.Enabled = b;
            //btnDangXuat.Enabled = b;
            //btnDoiPass.Enabled = b;
        }
        private void SinhVien(bool b)
        {
            //navBarControlLeft.Visible = b;
            //ribbonReport.Visible = b;
            //btnDangXuat.Enabled = b;
        }


        public void PhanQuyen()
        {
            if (Software.password == null)
            {
                //disableControlMain(false);
                //btnTaoTaiKhoan.Enabled = false;
                //Software.State = " Chờ đăng nhập";
                //Software.username = " Chưa đăng nhập";
                //barStaticChaoSV.Caption = "";
                //btnDangXuat.Enabled = false;
                //btnDoiPass.Enabled = false;
            }
            else
            {
                if (Software.mGroup == "SINHVIEN")
                {
                    SinhVien(true);
                }
                else if (Software.mGroup == "GIAOVIEN")
                {
                    GiaoVien(true);
                }
            } 
            barStaticChaoSV.Caption = "Chào " + Software.mHoten;
            barStaticTrangThai.Caption = "Trạng thái: (" + Software.State + ")";
            barStaticTaiKhoanSD.Caption = "Tài khoản hiện đang sử dụng: " + Software.username;
        }
        public void vaoPhongThi(bool b)
        {
            ribbonPageCauHinhDangNhap.Enabled = b;
            ribbonPageThoat.Enabled = b;
            ribbonPageSinhVien.Enabled = b;
            ribbonPageMonHoc.Enabled = b;
            ribbonPageGiaoVien.Enabled = b;
            ribbonPageReport.Enabled = b;
            navBarControlLeft.Visible = b;
            
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() != typeof(frmTRACNGHIEM))
                {
                    f.Close();
                }
            }
        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDangNhap();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            disableControlMain(false);
            var frm = new frmDangNhap();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            //PhanQuyen();
        }
        private void btnThoatCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình? ", "LƯU Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btnTaoTaiKhoan_ItemClick_Main(object sender,EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhSachSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "XML file(*.xml)|*.xml|Excel File(*.xlsx)|*.xlsx|All file(*.*)|*.*";
            fileOpen.Title = "Chọn danh sách sinh viên";
            fileOpen.ShowDialog();
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                string path = fileOpen.FileName;
            }
        }

        private void btnDanhSachPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnCapNhatSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void navItemDangKy_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGVDangKyDeThi));
            if (frm != null) frm.Activate();
            else
            {
                frmGVDangKyDeThi f = new frmGVDangKyDeThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhSachThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void navBarItemTaoDe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDeThi));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDeThi f = new frmNhapDeThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void navItemLamBaiThi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThongTinThi));
            if (frm != null) frm.Activate();
            else
            {
                frmThongTinThi f = new frmThongTinThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItemDoiPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.ShowDialog();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmBangDiem f = new frmBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //flag = 1;
            btnDangNhap.PerformClick();
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBackupRestore));
            if (frm != null) frm.Activate();
            else
            {
                frmBackupRestore f = new frmBackupRestore();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDanhSachCauHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rbnStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void barStaticTracNghiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticTrangThai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticTaiKhoanSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticChaoSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barTextDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barTextStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barTextCurrentAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barTextWelcome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barTextCurrentDate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void navBarControlLeft_Click(object sender, EventArgs e)
        {

        }

        //private void StatusBar()
        //{
        //    string cs = "";
        //    if (Software.server == "NGHIAPC\\SERVER1")
        //    {
        //        cs = "Cở Sở Hà Nội";
        //    }
        //    else
        //    {
        //        cs = "Cơ Sở Tp Hồ Chí Minh";
        //    }
        //    barStaticTracNghiem.Caption = cs;
        //}
    }
}
