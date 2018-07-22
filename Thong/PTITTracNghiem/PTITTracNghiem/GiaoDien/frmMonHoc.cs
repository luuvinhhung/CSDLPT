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
using PTITTracNghiem.GiaoDien.SubForm;

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmMonHoc : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmMonHoc()
        {
            InitializeComponent();
        }

        void loadMonHoc()
        {
            grvMonHoc.DataSource = db.MONHOCs.ToList();
            
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            loadMonHoc();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMa.ReadOnly = true;

            txtMa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENMH").ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ThemMonHoc();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadMonHoc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var query = db.MONHOCs.SingleOrDefault(p => p.TENMH == txtTen.Text.Trim());
            if (query != null)
            {
                MessageBox.Show("Tên môn học bị trùng.", "LƯU Ý!");
                return;
            }
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để sửa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mhThem = db.MONHOCs.SingleOrDefault(p => p.MAMH == txtMa.Text);
            mhThem.TENMH = txtTen.Text;
            
            db.SaveChanges();
            loadMonHoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var query = db.GIAOVIEN_DANGKY.FirstOrDefault(p => p.MAMH == txtMa.Text);
            var query1 = db.BODEs.FirstOrDefault(p => p.MAMH == txtMa.Text);
            var query2 = db.BANGDIEMs.FirstOrDefault(p => p.MAMH == txtMa.Text);
            if (query != null)
            {
                MessageBox.Show("Môn học đã có Giáo Viên đăng ký đề thi.", "KHÔNG ĐƯỢC XÓA!");
                return;
            }
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để sửa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (query1 != null)
            {
                MessageBox.Show("Môn học đã có bộ đề thi.", "KHÔNG ĐƯỢC XÓA!");
                return;
            }
            if (query2 != null)
            {
                MessageBox.Show("Môn học đã có bảng điểm.", "KHÔNG ĐƯỢC XÓA!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa môn học: " + txtMa.Text + ",Tên: " + txtTen.Text + " ? ", "LƯU Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var mhXoa = db.MONHOCs.SingleOrDefault(p => p.MAMH == txtMa.Text);
                if (mhXoa != null)
                {
                    db.MONHOCs.Remove(mhXoa);
                    db.SaveChanges();
                    txtMa.Clear();
                    txtTen.Clear();
                }
                loadMonHoc();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
