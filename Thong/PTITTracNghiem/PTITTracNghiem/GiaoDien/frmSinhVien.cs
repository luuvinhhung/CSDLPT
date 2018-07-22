using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using PTITTracNghiem.DuLieu;
using PTITTracNghiem.GiaoDien.SubForm;

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmSinhVien : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        TRACNGHIEMEntities1 db1 = new TRACNGHIEMEntities1();
        public frmSinhVien()
        {
            InitializeComponent();

        }
        string mMaSV, mHo, mTen, mNgaySinh, mDiaChi, mLop ;

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ThemSinhVien();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadSinhVien();
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if ((txtHo.Text.Equals("")) || (txtTen.Text.Equals("")) || (txtDiaChi.Text.Equals("")) || (dtmNgaySinh.Text.Equals("")))
            {
                MessageBox.Show("Phải nhập đủ thông tin!", "CẢNH BÁO!");
                return;
            }
            var svSua = (from p in db.SINHVIENs
                         where p.MASV == txtMaSV.Text
                         select p).FirstOrDefault();

            if (svSua != null)
            {
                svSua.HO = txtHo.Text.Trim();
                svSua.TEN = txtTen.Text.Trim();
                svSua.NGAYSINH = dtmNgaySinh.Value;
                svSua.DIACHI = txtDiaChi.Text.Trim();
                svSua.MALOP = mLop.Trim();
                db.SaveChanges();
                loadSinhVien();
            }
        }
        
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text =="")
            {
                MessageBox.Show("Chọn dữ liệu để xóa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var svXoa = (from a in db.SINHVIENs
                         where a.MASV == txtMaSV.Text
                         select a).FirstOrDefault();

            var query = (from b in db.SINHVIENs
                         where b.MASV == txtMaSV.Text
                         select b).FirstOrDefault();

            if (query != null)
            {
                MessageBox.Show("Sinh Viên đã có bảng điểm", "KHÔNG THỂ XÓA");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa SV MÃ SỐ: "+txtMaSV.Text+",Tên: "+txtTen.Text+" ? ","LƯU Ý",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.SINHVIENs.Remove(svXoa);
                db.SaveChanges();

                loadSinhVien();
                txtMaSV.Clear();
                txtHo.Clear();
                txtLop.Clear();
                txtTen.Clear();
                txtDiaChi.Clear();
                dtmNgaySinh.Value = DateTime.Now;
                loadSinhVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            loadSinhVien();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text == null)
                {
                    loadSinhVien();
                }
                else
                {
                    if (rdoMaSV.Checked == true)
                    {
                        loadSVMaSV(txtTimKiem.Text);
                    }
                    else if (rdoMaLop.Checked == true)
                    {
                        loadSVMaLop(txtTimKiem.Text);
                    }
                }
            }
        }

        private void rdoMaSV_CheckedChanged(object sender, EventArgs e)
        {
            loadSVMaSV(txtTimKiem.Text);
        }

        private void rdoMaLop_CheckedChanged(object sender, EventArgs e)
        {
            loadSVMaLop(txtTimKiem.Text);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        public void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtLop.ReadOnly = true;
            txtMaSV.ReadOnly = true;
            mMaSV = txtMaSV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MASV").ToString();
            mHo = txtHo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString();
            mTen = txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString();
            mNgaySinh = dtmNgaySinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString();
            mDiaChi = txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            var SV = db.SINHVIENs.SingleOrDefault(P => P.MASV == mMaSV);
            var lop = db.LOPs.SingleOrDefault(p => p.MALOP == SV.MALOP);
            mLop = SV.MALOP; 
            txtLop.Text = lop.TENLOP;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            txtTimKiem.Text = db.SINHVIENs.Where(p => p.MASV == "001").Select(p=>p.MASV).ToString();
            MessageBox.Show(txtTimKiem.Text);
            loadSinhVien();
            txtMaSV.Focus();
        }
        void loadSinhVien()
        {
            grvSinhVien.DataSource = db.SINHVIENs.ToList();            
        }
        void loadSVMaSV(string maSV)
        {
            grvSinhVien.DataSource = (from a in db.SINHVIENs
                                      where a.MASV.Contains(txtTimKiem.Text)
                                      select a).ToList();
        }
        void loadSVMaLop(string maLop)
        {
            grvSinhVien.DataSource = (from a in db.SINHVIENs
                                      where a.MALOP.Contains(txtTimKiem.Text)
                                      select a).ToList();
        }
    }
}
