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
    public partial class Frm_ThemGiaoVien : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public Frm_ThemGiaoVien()
        {
            InitializeComponent();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtHo.Text.Trim() == "" || txtMa.Text.Trim() == "" || txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "LƯU Ý!!!");
                return;
            }
            if (Software.IsNumber(txtSDT.Text) == false || txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại phải là chữ số có 10 hoặc 11 số.", "LƯU Ý");
                return;
            }
            var query = db.GIAOVIENs.SingleOrDefault(p => p.MAGV == txtMa.Text.Trim());

            if (query != null)
            {
                MessageBox.Show("Mã Giáo Viên đã tồn tại!", "LƯU Ý");
                return;
            }
            var gvThem = new GIAOVIEN
            {
                MAGV = txtMa.Text.Trim(),
                HO  = txtHo.Text.Trim(),
                TEN = txtTen.Text.Trim(),
                DIACHI = txtDiaChi.Text.Trim(),
                //SODTLL = txtSDT.Text
            };
            //db.GIAOVIENs.Add(gvThem);
            db.SaveChanges();
            MessageBox.Show("Thêm Thành Công!");
            this.Close();
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
