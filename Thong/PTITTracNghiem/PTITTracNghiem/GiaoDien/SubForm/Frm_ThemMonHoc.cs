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

namespace PTITTracNghiem.GiaoDien.SubForm
{
    public partial class Frm_ThemMonHoc : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public Frm_ThemMonHoc()
        {
            InitializeComponent();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() ==""|| txtTen.Text.Trim()=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "LƯU Ý!!!");
                return;
            }
            var queryMa = db.MONHOCs.SingleOrDefault(p => p.MAMH == txtMa.Text.Trim());
            var queryTen = db.MONHOCs.SingleOrDefault(p => p.TENMH == txtTen.Text.Trim());

            if (queryMa != null)
            {
                MessageBox.Show("Mã môn học đã tồn tại.", "LƯU Ý!");
                return;
            }
            if (queryTen != null)
            {
                MessageBox.Show("Tên môn học bị trùng.", "LƯU Ý!");
                return;
            }
            var mhThem = new MONHOC
            {
                MAMH = txtMa.Text.Trim(),
                TENMH = txtTen.Text.Trim()
            };
            //db.MONHOCs.Add(mhThem);
            db.SaveChanges();
            MessageBox.Show("Thêm Thành Công!");
            this.Close();
        }
    }
}
