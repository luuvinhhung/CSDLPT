using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTITTracNghiem.GiaoDien;
using PTITTracNghiem.DuLieu;

namespace PTITTracNghiem.Reports
{
    public partial class frmReportBangDiem : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        List<BANGDIEM/*SP_REPORTBANGDIEM_Result*/> list;
        public frmReportBangDiem(List<BANGDIEM/*SP_REPORTBANGDIEM_Result*/> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void frmReportBangDiem_Load(object sender, EventArgs e)
        {
            CrystalReportBangDiem1.SetDataSource(list);
            crystalReportViewer1.RefreshReport();
        }
    }
}
