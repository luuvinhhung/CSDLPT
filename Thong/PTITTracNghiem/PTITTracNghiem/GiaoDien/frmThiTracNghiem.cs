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
    public partial class frmTRACNGHIEM : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        private List<DeThi> listDeThi;
        private List<BaiThi> listBaiThi;
        static int thoiGian;
        static int thoiGianThi;
        public static int lanThi;
        public static DateTime ngayThi;
        //int flag = 0;
        public frmTRACNGHIEM()
        {
            InitializeComponent();
            
        }
        public void hienThiCauHoi(int thuTuTrongList, int soCau)
        {
            labNoiDung.MaximumSize = panCauHoi.Size;
            labNoiDung.Text = listDeThi[thuTuTrongList].noiDung;
            radA.Text = listDeThi[thuTuTrongList].A;
            radB.Text = listDeThi[thuTuTrongList].B;
            radC.Text = listDeThi[thuTuTrongList].C;
            radD.Text = listDeThi[thuTuTrongList].D;
            labSoCauHoi.Text = "Câu " + soCau + " :";
        }
        public void resetRadioButton()
        {
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
        }
        public void radioCheck(string cauTraLoi)
        {
            if (cauTraLoi.Equals(""))
            {
                radA.Checked = false;
                radB.Checked = false;
                radC.Checked = false;
                radD.Checked = false;
            }

            if (cauTraLoi.Equals("A"))
            {
                radA.Checked = true;
            }

            if (cauTraLoi.Equals("B"))
            {
                radB.Checked = true;
            }

            if (cauTraLoi.Equals("C"))
            {
                radC.Checked = true;
            }

            if (cauTraLoi.Equals("D"))
            {
                radD.Checked = true;
            }
        }
        public void CheckList(int soCauHienTai)
        {
            for (int i = 0; i < listBaiThi.Count; i++)
            {
                if (listBaiThi[i].cau == soCauHienTai)
                {
                    listBaiThi[i].traLoi = dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value.ToString();
                    return;
                }
            }
            listBaiThi.Add(new BaiThi(
                           soCauHienTai,
                           dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value.ToString(),
                           listDeThi[soCauHienTai - 1].cauHoi
                             ));
        }
        private void radA_CheckedChanged(object sender, EventArgs e)
        {
            string sub = labSoCauHoi.Text.Substring(3, 3).Trim();
            int soCauHienTai = Int32.Parse(sub);
            dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value = "A";
            CheckList(soCauHienTai);
        }

        private void radB_CheckedChanged(object sender, EventArgs e)
        {

            string sub = labSoCauHoi.Text.Substring(3, 3).Trim();
            int soCauHienTai = Int32.Parse(sub);
            dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value = "B";
            CheckList(soCauHienTai);
        }
        private void radC_CheckedChanged(object sender, EventArgs e)
        {
            string sub = labSoCauHoi.Text.Substring(3, 3).Trim();
            int soCauHienTai = Int32.Parse(sub);
            dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value = "C";
            CheckList(soCauHienTai);
        }

        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            string sub = labSoCauHoi.Text.Substring(3, 3).Trim();
            int soCauHienTai = Int32.Parse(sub);
            dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value = "D";
            CheckList(soCauHienTai);
        }

        private void dgvHoiTraLoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string filepath = (string)dgvHoiTraLoi.Rows[e.RowIndex].Cells[0].Value;
            int soCauHienTai = Int32.Parse(filepath);
            int t = soCauHienTai;
            resetRadioButton();
            hienThiCauHoi(soCauHienTai - 1, t);
            for (int i = 0; i < listBaiThi.Count; i++)
            {
                if (listBaiThi[i].cau == t)
                {
                    listBaiThi[i].traLoi = dgvHoiTraLoi.Rows[i].Cells[1].Value.ToString();
                    radioCheck(dgvHoiTraLoi.Rows[soCauHienTai - 1].Cells[1].Value.ToString().Trim());
                    break;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát mà chưa nộp bài thi?", "LƯU Ý, BẠN ĐANG THI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                timeCountDown.Stop();
                getInfo.baiDaThiTemp = listBaiThi;
                this.Close();
                Software.fmain.vaoPhongThi(true);
                frmKetQuaThi frm = new frmKetQuaThi();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void frmTRACNGHIEM_Load(object sender, EventArgs e)
        {
            listBaiThi = new List<BaiThi>();
            txtMaSV.Text = frmThongTinThi.MaSV;
            txtLop.Text = frmThongTinThi.Lop;
            txtTen.Text = Software.mHoten;
            txtMonHoc.Text = frmThongTinThi.ChonMonHoc;
            txtLan.Text = frmThongTinThi.LanThi.ToString();

            if (Software.mGroup == "GIAOVIEN") lblLuuY.Text = frmThongTinThi.LuuY;
            else lblLuuY.Text = "QUY ĐỊNH CHUNG TRONG PHÒNG THI:\n\n"
                    + "  1. Không được gây ồn ào, thảo luận.\n"
                    + "  2. Không được tự ý sử dụng, di chuyển thiết bị\n"
                    + "  3. Thông báo cho cán bộ coi thi nếu gặp sự cố\n"
                    + "  4. Nếu bấm nút THOÁT, bài thi sẽ không được lưu lại và điểm bài thi là 0"
                    + "              Chúc các bạn thi tốt!";
            int soCau;
            string trinhDo;

            var dk = db.GIAOVIEN_DANGKY.ToList();
            var query = dk.Select(p => new { p.THOIGIAN, p.TRINHDO, p.SOCAUTHI, p.MALOP, p.MAMH, p.LAN, p.NGAYTHI })
                          .Where(p => p.LAN == Convert.ToInt16(frmThongTinThi.LanThi)
                                     & p.MALOP.Equals(frmThongTinThi.Lop)
                                     & p.MAMH.Equals(frmThongTinThi.ChonMonHoc)).ToList();

            soCau = Convert.ToInt16(query[0].SOCAUTHI);
            trinhDo = Convert.ToString(query[0].TRINHDO);
            thoiGianThi = thoiGian = Convert.ToInt16(query[0].THOIGIAN);
            lanThi = Convert.ToInt16(query[0].LAN);
            ngayThi = Convert.ToDateTime(query[0].NGAYTHI);

            getInfo dethi = new getInfo();
            listDeThi = dethi.getBoDe(soCau, trinhDo, query[0].MAMH);
            hienThiCauHoi(0, 1);
            for (int i = 0; i < listDeThi.Count; i++)
            {
                int t = i + 1;
                dgvHoiTraLoi.Rows.Add(t + "", "");
            }

            labThoiGianThi.Text = thoiGianThi.ToString() + " (Phút)";
            thoiGian = thoiGian - 1;
            labPhut.Text = thoiGian.ToString();
            timeCountDown.Start();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string sub = labSoCauHoi.Text.Substring(3, 3).Trim();
            int soCauHienTai = Int32.Parse(sub);
            int t = soCauHienTai - 1;
            if (soCauHienTai - 2 < 0)
                return;
            resetRadioButton();
            hienThiCauHoi(soCauHienTai - 2, t);
            for (int i = 0; i < listBaiThi.Count; i++)
            {
                if (listBaiThi[i].cau == t)
                {
                    listBaiThi[i].traLoi = dgvHoiTraLoi.Rows[i].Cells[1].Value.ToString();
                    radioCheck(dgvHoiTraLoi.Rows[soCauHienTai - 2].Cells[1].Value.ToString().Trim());
                    break;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string sub = labSoCauHoi.Text.Substring(3, 3).Trim();
            int soCauHienTai = Int32.Parse(sub);
            if (soCauHienTai == listDeThi.Count)
                return;
            resetRadioButton();
            int t = soCauHienTai + 1;
            hienThiCauHoi(soCauHienTai, t);
            for (int i = 0; i < listBaiThi.Count; i++)
            {
                if (listBaiThi[i].cau == t)
                {
                    listBaiThi[i].traLoi = dgvHoiTraLoi.Rows[i].Cells[1].Value.ToString();
                    radioCheck(dgvHoiTraLoi.Rows[soCauHienTai].Cells[1].Value.ToString().Trim());
                    break;
                }
            }
        }

        private void timeCountDown_Tick_1(object sender, EventArgs e)
        {
            int m = Int32.Parse(labPhut.Text);
            int s = Int32.Parse(labGiay.Text);
            if (s <= 10)
            {
                s--;
                labGiay.Text = "0" + s;
            }
            if (s == 0 && m <= 10)
            {
                if (s == 0 && m == 0)
                {
                    if (MessageBox.Show("Hết giờ làm bài thi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        btnSubmit.PerformClick();
                    }
                }
                else
                {
                    s = 60;
                    m--;
                    labPhut.Text = "0" + m;
                }
            }

            if (s == 0 && m > 10)
            {
                s = 60;
                m--;
                labPhut.Text = m + "";
            }
            if (s > 10)
            {
                s--;
                labGiay.Text = s + "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timeCountDown.Stop();
            getInfo.baiDaThiTemp = listBaiThi;
            this.Close();
            Software.fmain.vaoPhongThi(true);
            frmKetQuaThi frm = new frmKetQuaThi();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
