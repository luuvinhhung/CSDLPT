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

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmNhapDeThi : Form
    {
        TRACNGHIEMEntities db= new TRACNGHIEMEntities();
        public frmNhapDeThi()
        {
            InitializeComponent();
        }
        void loadBoDe()
        {
            var query = db.BODEs.ToList();
            grvBoDe.DataSource = query;
        }
        void loadThongTin()
        {
            cboMaMH.DisplayMember = "MAMH";
            cboMaMH.ValueMember = "MAMH";
            cboMaMH.DataSource = db.MONHOCs.ToList();

            cboDapAn.Items.Add("A");
            cboDapAn.Items.Add("B");
            cboDapAn.Items.Add("C");
            cboDapAn.Items.Add("D");
        }

        private void frmNhapDeThi_Load(object sender, EventArgs e)
        {
            loadBoDe();
            loadThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Trim() == ""|| txtMaCauHoi.Text.Trim() ==""||txtA.Text.Trim() ==""
                ||txtB.Text.Trim() =="" ||txtC.Text.Trim() ==""||txtD.Text.Trim() ==""
                ||cboDapAn.Text ==""||cboMaMH.Text==""||cboTrinhDo.Text=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "KHÔNG THÊM ĐƯỢC!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var bodeThem = new BODE
            {
                TRINHDO = cboTrinhDo.SelectedItem.ToString(),
                MAMH = cboMaMH.SelectedValue.ToString(),
                MAGV = Software.username,
                NOIDUNG = txtNoiDung.Text,
                A = txtA.Text,
                B = txtB.Text,
                C = txtC.Text,
                D = txtD.Text,
                DAP_AN = cboDapAn.SelectedItem.ToString()
            };
            //db.BODEs.Add(bodeThem);
            db.SaveChanges();
            MessageBox.Show("Thêm câu hỏi thành công!","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            loadBoDe();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCauHoi.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để sửa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaGV.Text.Trim() != Software.username)
            {
                MessageBox.Show("Câu hỏi này Thuộc quyền của Giáo viên khác", "KHÔNG SỬA ĐƯỢC DỮ LIỆU!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (txtNoiDung.Text.Trim() == "" || txtMaCauHoi.Text.Trim() == "" || txtA.Text.Trim() == ""
                || txtB.Text.Trim() == "" || txtC.Text.Trim() == "" || txtD.Text.Trim() == ""
                 || cboDapAn.Text == "" || cboMaMH.Text == "" || cboTrinhDo.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "LƯU Ý!!!");
                return;
            }
            int macauHoi = int.Parse(txtMaCauHoi.Text);
            var query = db.BODEs.FirstOrDefault(p => p.CAUHOI == macauHoi);
            query.A = txtA.Text.Trim();
            query.B = txtB.Text.Trim();
            query.C = txtC.Text.Trim();
            query.D = txtD.Text.Trim();
            query.NOIDUNG = txtNoiDung.Text.Trim();
            query.TRINHDO = cboTrinhDo.Text;
            query.MAMH = cboMaMH.Text;
            query.DAP_AN = cboDapAn.Text;
            db.SaveChanges();
            loadBoDe();
            MessageBox.Show("Sửa Thành Công", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCauHoi.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để xóa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaGV.Text.Trim() != Software.username)
            {
                MessageBox.Show("Câu hỏi này Thuộc quyền của Giáo viên khác", "KHÔNG XÓA ĐƯỢC DỮ LIỆU!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa Câu hỏi số: " + txtMaCauHoi.Text + "? ", "LƯU Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int mCauHoi = int.Parse(txtMaCauHoi.Text);
                var query = db.BODEs.FirstOrDefault(p => p.CAUHOI == mCauHoi);
                db.BODEs.Remove(query);
                db.SaveChanges();
                loadBoDe();
                Clear();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtMaCauHoi.Clear();
            txtA.Clear();
            txtC.Clear();
            cboDapAn.Text = "";
            txtD.Clear();
            txtB.Clear();
            cboMaMH.Text = "";
            cboTrinhDo.Text = "";
            txtNoiDung.Clear();
            txtMaGV.Text = Software.username;
        }
         void loadBoDeMonHoc(string monhoc)
        {
            var dsbode = (from a in db.BODEs
                          where a.MAMH.Contains(monhoc)
                          select a).ToList();
            grvBoDe.DataSource = dsbode;
        }
        void loadBoDeMaGV(string maGV)
        {
            var dsbode = (from a in db.BODEs
                          where a.MAGV.Contains(maGV)
                          select a).ToList();
            grvBoDe.DataSource = dsbode;
        }
        void loadBoDeTrinhDo(string trinhdo)
        {
            var dsbode = (from a in db.BODEs
                          where a.TRINHDO.Contains(trinhdo)
                          select a).ToList();
            grvBoDe.DataSource = dsbode;
        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaCauHoi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CAUHOI").ToString();
            txtMaGV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAGV").ToString();
            cboTrinhDo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TRINHDO").ToString();
            cboMaMH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
            cboDapAn.SelectedItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DAP_AN").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOIDUNG").ToString();
            txtA.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "A").ToString();
            txtB.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "B").ToString();
            txtC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "C").ToString();
            txtD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "D").ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoMaGV_CheckedChanged_1(object sender, EventArgs e)
        {
            loadBoDeMaGV(txtTimKiem.Text);
        }

        private void rdoTrinhDo_CheckedChanged_1(object sender, EventArgs e)
        {
            loadBoDeTrinhDo(txtTimKiem.Text);
        }

        private void rdoMonHoc_CheckedChanged_1(object sender, EventArgs e)
        {
            loadBoDeMonHoc(txtTimKiem.Text);
        }

        private void txtTimKiem_KeyDown_1(object sender, KeyEventArgs e)
        {
            loadBoDe();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text == null)
                {
                    loadBoDe();
                }
                else
                {
                    if (rdoMonHoc.Checked == true)
                    {
                        loadBoDeMonHoc(txtTimKiem.Text);
                    }
                    else if (rdoTrinhDo.Checked == true)
                    {
                        loadBoDeTrinhDo(txtTimKiem.Text);
                    }
                    else if (rdoMaGV.Checked == true)
                    {
                        loadBoDeMaGV(txtTimKiem.Text);
                    }
                }
            }
        }
    }
}
