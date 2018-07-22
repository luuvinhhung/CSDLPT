using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PTITTracNghiem.DuLieu;

namespace PTITTracNghiem.GiaoDien.SubForm
{
    public partial class Frm_ThemSinhVien : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public Frm_ThemSinhVien()
        {
            InitializeComponent();
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year - dtmNgaySinh.Value.Year) < 17 || (DateTime.Now.Year - dtmNgaySinh.Value.Year) > 30)
            {
                MessageBox.Show("Tuổi của sinh viên chỉ nhận từ 17-30", "LƯU Ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtMaSV.Text.Trim().Equals(""))||(txtHo.Text.Equals("")) || (txtTen.Text.Equals("")) || (txtDiaChi.Text.Equals("")) || (dtmNgaySinh.Text.Equals("")))
            {
                MessageBox.Show("Phải nhập đủ thông tin!", "CẢNH BÁO!");
                return;
            }
            else
            {
                var query = db.SINHVIENs.SingleOrDefault(p => p.MASV == txtMaSV.Text);
                if (query != null)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại!");
                    return;
                }
                var mlop = (from a in db.LOPs
                            where a.TENLOP == cmbLop.SelectedItem.ToString()
                            select a.MALOP).SingleOrDefault();

                var svThem = new SINHVIEN
                {
                    MASV = txtMaSV.Text.Trim(),
                    HO = txtHo.Text.Trim(),
                    TEN = txtTen.Text.Trim(),
                    NGAYSINH = dtmNgaySinh.Value,
                    DIACHI = txtDiaChi.Text.Trim(),
                    MALOP = mlop
                };
                //db.SINHVIENs.Add(svThem);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành Công!");
                this.Close();
            }
        }
        private void Frm_ThemSinhVien_Load(object sender, EventArgs e)
        {
            var query = db.LOPs.Select(p => p.TENLOP).ToList();
            cmbLop.DataSource = query;
        }
    }
}
