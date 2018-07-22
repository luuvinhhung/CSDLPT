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
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Views.Grid;
using PTITTracNghiem.GiaoDien.SubForm;

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmGiaoVien : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        void loadGiaoVien()
        {
            var dsGV = db.SP_DSLOGIN/*SP_DSGIAOVIEN*/();
            grvGiaoVien.DataSource = dsGV;
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            loadGiaoVien();
            txtMa.Focus();
        }
        string mMaGV="";

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ThemGiaoVien();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadGiaoVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtHo.Text.Trim() == "" || txtMa.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "LƯU Ý!!!");
                return;
            }
            if (Software.IsNumber(txtSDT.Text) == false || txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại phải là chữ số có 10 hoặc 11 số.", "LƯU Ý");
                return;
            }

            var gvSua = db.GIAOVIENs.SingleOrDefault(p => p.MAGV == txtMa.Text.Trim());
            if (gvSua != null)
            {
                gvSua.HO = txtHo.Text.Trim();
                gvSua.TEN = txtTen.Text.Trim();
                gvSua.DIACHI = txtDiaChi.Text.Trim();
                //gvSua.SODTLL = txtSDT.Text.Trim();
            }
            db.SaveChanges();
            loadGiaoVien();  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == Software.username)
            {
                MessageBox.Show("không thể xóa chính bạn", "KHÔNG XÓA ĐƯỢC!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var gvXoa = (from a in db.GIAOVIENs
                         where a.MAGV == txtMa.Text
                         select a).FirstOrDefault();
            var query = db.BODEs.FirstOrDefault(p => p.MAGV == txtMa.Text.Trim());
            var query1 = db.GIAOVIEN_DANGKY.FirstOrDefault(p => p.MAGV == txtMa.Text.Trim());
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để xóa","THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (query != null)
            {
                MessageBox.Show("Giáo Viên này đã Tạo đề thi", "KHÔNG XÓA ĐƯỢC!");
                return;
            }
            if (query1 != null)
            {
                MessageBox.Show("Giáo viên này đã Đăng ký bộ đề", "KHÔNG XÓA ĐƯỢC!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa GV MÃ SỐ: " + txtMa.Text + ",Tên: " + txtTen.Text + " ? ", "LƯU Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.GIAOVIENs.Remove(gvXoa);
                db.SaveChanges();

                loadGiaoVien();
                txtMa.Clear();
                txtHo.Clear();
                txtTen.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                loadGiaoVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            string filter = view.ActiveFilterString;
            view.ActiveFilterString = filter.Replace("[SODTLL] = 'Chua co'", "IsNullOrEmpty([SODTLL])");
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            txtMa.ReadOnly = true;
            mMaGV = txtMa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAGV").ToString();
            txtHo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SODTLL").ToString();
        }

        private void rdoMaSV_CheckedChanged(object sender, EventArgs e)
        {
            loadGVMaGV(txtTimKiem.Text);
        }
        void loadGVMaGV(string maGV)
        {
            grvGiaoVien.DataSource = db.SP_DSLOGIN/*SP_TIMGIAOVIEN_MAGV*/(/*maGV*/);
        }
        void loadGVTenGV(string tenGV)
        {
            grvGiaoVien.DataSource = db.SP_DSLOGIN/*SP_TIMGIAOVIEN_TEN*/(/*tenGV*/);
        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            loadGiaoVien();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text == null)
                {
                    loadGiaoVien();
                }
                else
                {
                    if (rdoMaGV.Checked == true)
                    {
                        loadGVMaGV(txtTimKiem.Text);
                    }
                    else if (rdoTenGV.Checked == true)
                    {
                        loadGVTenGV(txtTimKiem.Text);
                    }
                }
            }
        }

        private void rdoTenGV_CheckedChanged(object sender, EventArgs e)
        {
            loadGVTenGV(txtTimKiem.Text);
        }
    }
}
