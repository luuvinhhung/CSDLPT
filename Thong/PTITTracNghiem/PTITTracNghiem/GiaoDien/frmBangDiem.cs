using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTITTracNghiem.DuLieu;
using PTITTracNghiem.Reports;

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmBangDiem : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public static string tenLop;
        public static string tenMH;
        public static short lanThi;
        //public static List<SP_REPORTBANGDIEM_Result> list;
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var getBangDiem = (from a in db.BANGDIEMs
                               from b in db.LOPs
                               from c in db.MONHOCs
                               from d in db.SINHVIENs
                               where a.MAMH == c.MAMH && b.MALOP == d.MALOP && d.MASV == a.MASV
                               select new { b.TENLOP, c.TENMH }).Distinct().ToList();
            if (Software.mGroup == "GIAOVIEN")
            {
                cboTenLop.DisplayMember = "TENLOP";
                cboTenLop.DataSource = getBangDiem.Select(p => p.TENLOP).Distinct().ToList();
            }
            else cboTenLop.Text = Software.lop;

            cboTenMH.DisplayMember = "TENMH";
            cboTenMH.DataSource = getBangDiem.Select(p=>p.TENMH).Distinct().ToList();
            var lanthi = (from a in db.BANGDIEMs
                          select a.LAN).Distinct().ToList();
            cboLanThi.DisplayMember = "LAN";
            cboLanThi.DataSource = lanthi;

            if (Software.mGroup == "GIAOVIEN")
                grvBangDiem.Visible = false;
            else grvBangDiem.Visible = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            tenLop = cboTenLop.Text.Trim();
            tenMH = cboTenMH.Text.Trim();
            lanThi = Int16.Parse(cboLanThi.Text);
            //sPREPORTBANGDIEMResultBindingSource.DataSource = db.SP_REPORTBANGDIEM(tenLop,tenMH,lanThi).ToList();
            if (Software.mGroup == "SINHVIEN")
            {
                var bangDiem = (from a in db.BANGDIEMs/*(tenLop, tenMH, lanThi)*/
                                where a.MASV == Software.username
                                select a).ToList();
                grvBangDiem.DataSource = bangDiem;
                grvBangDiem.Visible = true;
                return;
            }
            //List<SP_REPORTBANGDIEM_Result> list = sPREPORTBANGDIEMResultBindingSource.DataSource as List<SP_REPORTBANGDIEM_Result>;
            var list = db.BANGDIEMs;
            if (list != null)
            {
                //using (Reports.frmReportBangDiem f = new frmReportBangDiem(list))
                //{
                //    f.ShowDialog();
                //}
            }
            else
            {
                MessageBox.Show("Không tồn tại dữ liệu", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
