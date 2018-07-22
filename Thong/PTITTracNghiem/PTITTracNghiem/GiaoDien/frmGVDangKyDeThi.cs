using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PTITTracNghiem.DuLieu;

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmGVDangKyDeThi : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmGVDangKyDeThi()
        {
            InitializeComponent();
        }
        //string mh, lop;
        private void loadGVDangKy()
        {
            //var queryDK = db.SP_XUATGVDANGKY();
            //grvGVDangKy.DataSource = queryDK;


            comboMonHoc.DisplayMember = "TENMH";
            comboMonHoc.ValueMember = "MAMH";
            comboMonHoc.DataSource = db.MONHOCs.ToList();

            comboTenLop.DisplayMember = "TENLOP";
            comboTenLop.ValueMember = "MALOP";
            comboTenLop.DataSource = db.LOPs.ToList();
        }
        private void Frm_GiaoVienDangKiDeThi_Load(object sender, EventArgs e)
        {
            loadGVDangKy();
            this.comboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtLan.Text == "" || txtSoCau.Text == "" || txtThoiGian.Text == "" || comboTrinhDo.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để sửa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lanthi = Int16.Parse(txtLan.Text);
            socauthi = Int16.Parse(txtSoCau.Text);
            thoigian = Int16.Parse(txtThoiGian.Text);
            DuyetThongTin();
            var query = db.GIAOVIEN_DANGKY.SingleOrDefault(p => p.LAN == lanthi && p.MAMH == comboMonHoc.SelectedValue.ToString() && p.MALOP == comboTenLop.SelectedValue.ToString());
            if (query == null)
            {
                MessageBox.Show("Đăng ký này không tồn tại để sửa", "LƯU Ý!");
                return;
            }
            
            else if (query.MAGV.Trim() != Software.username)
            {
                MessageBox.Show("Đăng ký này Thuộc quyền của Giáo viên khác", "LƯU Ý!");
                return;
            }
            query.MAGV = Software.username;
            query.MAMH = comboMonHoc.SelectedValue.ToString();
            query.MALOP = comboTenLop.SelectedValue.ToString();
            query.LAN = (short)lanthi;
            query.NGAYTHI = dtmNgayThi.Value;
            query.SOCAUTHI = (short)socauthi;
            query.THOIGIAN = (short)thoigian;
            query.TRINHDO = comboTrinhDo.SelectedItem.ToString();

            db.SaveChanges();
            MessageBox.Show("Sửa thành công!");
            loadGVDangKy();
        }
        void Clear()
        {
            comboMonHoc.Text = "";
            comboTenLop.Text = "";
            comboTrinhDo.Text = "";
            txtLan.Clear();
            txtSoCau.Clear();
            txtThoiGian.Clear();
            dtmNgayThi.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        short lanthi, socauthi, thoigian;

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
                comboTenLop.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOP").ToString();
                comboMonHoc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENMH").ToString();
                comboTrinhDo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TRINHDO").ToString();
                txtLan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LAN").ToString();
                txtSoCau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOCAUTHI").ToString();
                txtThoiGian.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "THOIGIAN").ToString();
                dtmNgayThi.Value = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYTHI");
            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtLan.Text == "" || txtSoCau.Text == "" || txtThoiGian.Text == "" || comboTrinhDo.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu để xóa", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lanthi = Int16.Parse(txtLan.Text);
            socauthi = Int16.Parse(txtSoCau.Text);
            thoigian = Int16.Parse(txtThoiGian.Text);

            var query = db.GIAOVIEN_DANGKY.FirstOrDefault(p => p.LAN == lanthi && p.MAMH == comboMonHoc.SelectedValue.ToString() && p.MALOP == comboTenLop.SelectedValue.ToString());
            if (query == null)
            {
                MessageBox.Show("Đăng ký này không tồn tại để Xóa", "LƯU Ý!");
                return;
            } else if (query.MAGV.Trim() != Software.username)
            {
                MessageBox.Show("Đăng ký này Thuộc quyền của Giáo viên khác", "LƯU Ý!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa Đăng ký này: " + comboMonHoc.SelectedValue.ToString()+", " + comboTenLop.SelectedValue.ToString()+", " +txtLan.Text+ " ? ", "LƯU Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.GIAOVIEN_DANGKY.Remove(query);
                db.SaveChanges();
                loadGVDangKy();
                Clear();
            }
        }

        public bool DuyetThongTin()
        {

            
            
            if (lanthi < 1 || lanthi > 2)
            {
                MessageBox.Show("Lần thi chỉ nhận lần 1 hoặc lần 2!", "LƯU Ý!");
                return false;
            }
           
            else if (socauthi < 10 || socauthi > 100)
            {
                MessageBox.Show("Số câu hỏi chỉ nhận từ 10 đến 100 câu", "LƯU Ý!");
                return false;
            }
            //if (dtmNgayThi.Value < DateTime.Now)
            //{
            //    MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại!", "LƯU Ý!");
            //    return false;
            //}
            else if (thoigian < 15 || thoigian > 60)
            {
                MessageBox.Show("Thời gian chỉ nhận từ 15' đến 60'", "LƯU Ý!");
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtLan.Text =="" || txtSoCau.Text ==""||txtThoiGian.Text==""||comboTrinhDo.Text=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "LƯU Ý!!!");
                return;
            }
            lanthi = Int16.Parse(txtLan.Text);
            socauthi = Int16.Parse(txtSoCau.Text);
            thoigian = Int16.Parse(txtThoiGian.Text);
            if (DuyetThongTin() == false)
            {
                return;
            }
            var query = db.GIAOVIEN_DANGKY.SingleOrDefault(p=> p.LAN == lanthi && p.MAMH == comboMonHoc.SelectedValue.ToString() && p.MALOP == comboTenLop.SelectedValue.ToString());
            if (query != null)
            {
                MessageBox.Show("Đăng ký này đã tồn tại", "LƯU Ý!");
                return;
            }
            var query2 = (from a in db.GIAOVIEN_DANGKY
                          where a.MALOP == comboTenLop.SelectedValue.ToString()
                          && a.MAMH == comboMonHoc.SelectedValue.ToString()
                          select a).ToList();
            if (query2.Count() == 0 && txtLan.Text == "2")
            {
                MessageBox.Show("Phải đăng ký bộ đề "+comboMonHoc.Text+" cho Lần 1 trước", "KHÔNG THÊM ĐƯỢC!");
                return;
            }
            var gvDangKy = new GIAOVIEN_DANGKY();

            
            gvDangKy.MAGV = Software.username;
            gvDangKy.MALOP = comboTenLop.SelectedValue.ToString().Trim();
            gvDangKy.MAMH = comboMonHoc.SelectedValue.ToString().Trim();
            gvDangKy.TRINHDO = comboTrinhDo.SelectedItem.ToString().Trim();
            gvDangKy.LAN = lanthi;
            gvDangKy.THOIGIAN = thoigian;
            gvDangKy.SOCAUTHI = socauthi;
            gvDangKy.NGAYTHI = dtmNgayThi.Value;

            //db.GIAOVIEN_DANGKY.Add(gvDangKy);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công");
            loadGVDangKy();
        }
    }
}
