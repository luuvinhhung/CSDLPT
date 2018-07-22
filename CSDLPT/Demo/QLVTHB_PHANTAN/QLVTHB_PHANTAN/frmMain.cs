using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVTHB_PHANTAN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangnhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangnhap f = new frmDangnhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDangnhap.PerformClick();
        }

        private void btnNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanvien f = new frmNhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }

    }
}
