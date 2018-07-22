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
    public partial class frmThongTinThi : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmThongTinThi()
        {
            InitializeComponent();
        }

        public static string Lop, ChonMonHoc,MaSV, MaGV,LuuY = "LƯU Ý!\nBạn là GIÁO VIÊN nên khi làm bài thi\n, kết quả thi sẽ KHÔNG được lưu lại.\n\n";
        public static int LanThi;

        public static DateTime NgayThi;

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThi_Click_1(object sender, EventArgs e)
        {
            if (cbChonMonThi.Text == "" || cbLanThi.Text == "")
            {
                MessageBox.Show("Cần Nhập đủ Thông Tin trước khi Vào Thi!!!", "CẢNH BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (Software.mGroup == "GIAOVIEN")
                {
                    Lop = cboLop.Text;
                    Software.lop = cboLop.Text;
                }
                else Lop = txtLop.Text;

                LanThi = Int32.Parse(cbLanThi.Text);
                ChonMonHoc = cbChonMonThi.SelectedValue.ToString();
                var query = db.BANGDIEMs.SingleOrDefault(p => p.MASV == txtMaSV.Text && p.MAMH == ChonMonHoc && p.LAN == LanThi);
                var query2 = db.GIAOVIEN_DANGKY.SingleOrDefault(p => p.MALOP == Lop && p.MAMH == cbChonMonThi.SelectedValue.ToString() && p.LAN == (short)LanThi);          

                if (query != null)
                {
                    MessageBox.Show("Bạn ĐÃ HOÀN THÀNH bài thi môn:\n - " + cbChonMonThi.Text + "\n - Lần Thi:'" + LanThi.ToString() + "'", "CẢNH BÁO,KHÔNG ĐƯỢC THI LẠI!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                var query1 = (from p in db.BANGDIEMs
                              where p.MASV == txtMaSV.Text && p.MAMH == ChonMonHoc
                              select p).ToList();
                //if (query1.Count() ==0 && cbLanThi.Text == "2" && Software.mGroup != "GIAOVIEN" )
                //{
                //    MessageBox.Show("Môn : "+cbChonMonThi.Text +" bạn chưa thi lần 1,\n Phải chọn thi lần 1 trước","CẢNH BÁO!");
                //    return;
                //}
                

                if (query2 == null)
                {
                    MessageBox.Show("Không Tìm Thấy Đề Thi...Vui Lòng Kiểm Tra Lại Thông Tin!!!", "Cảnh Báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                NgayThi = (DateTime)query2.NGAYTHI;
                DateTime getNgayThi = query2.NGAYTHI.Value.Date;
                MessageBox.Show(getNgayThi.ToString() + Software.getDayNow.ToString());
                if (getNgayThi < Software.getDayNow)
                {

                    MessageBox.Show("Môn này ĐÃ ĐƯỢC THI lần " + cbLanThi.Text + " vào ngày: " + query2.NGAYTHI.ToString(), "THÔNG BÁO, MÔN HỌC ĐÃ ĐƯỢC THI!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                else if (getNgayThi > Software.getDayNow)
                {
                    MessageBox.Show("Lịch thi môn này lần " + cbLanThi.Text + " vào ngày: " + query2.NGAYTHI.ToString(), "THÔNG BÁO, CHƯA ĐẾN NGÀY THI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                
                } else
                {
                    MaSV = txtMaSV.Text;
                    Software.fmain.vaoPhongThi(false);
                    frmTRACNGHIEM frm = new frmTRACNGHIEM();
                    frm.Show();
                }
            }
        }
        private void frmThongTinThi_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = Software.mHoten;
            txtMaSV.Text = Software.username;
            if (Software.mGroup == "SINHVIEN")
            {
                txtLop.Visible = true;
                txtLop.Text = Software.lop;
            }else if (Software.mGroup == "GIAOVIEN")
            {
                lblLuuY.Text = LuuY;
                cboLop.Visible = true;

                cboLop.DisplayMember = "MALOP";
                cboLop.ValueMember = "MALOP";
                var l = (from a in db.LOPs
                                    select a.MALOP).ToList();
                cboLop.DataSource = l;
            }
            //Load thông tin dự thi
            var dsMonThi = (from p in db.GIAOVIEN_DANGKY from q in db.MONHOCs
                           where p.MAMH == q.MAMH
                           select new {p.MAMH,q.TENMH}).Distinct();
            if (dsMonThi != null)
            {
                cbChonMonThi.ValueMember = "MAMH";
                cbChonMonThi.DisplayMember = "TENMH";
                cbChonMonThi.DataSource = dsMonThi.ToList();
            }
            

            var lanThi = (from p in db.GIAOVIEN_DANGKY
                          select p.LAN).Distinct().ToList();
            cbLanThi.DisplayMember = "LAN";
            cbLanThi.ValueMember = "LAN";
            cbLanThi.DataSource = lanThi;
        }
    }
}
