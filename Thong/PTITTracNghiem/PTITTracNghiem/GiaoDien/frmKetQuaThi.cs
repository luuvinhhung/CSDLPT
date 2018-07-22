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
    public partial class frmKetQuaThi : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmKetQuaThi()
        {
            InitializeComponent();
        }
        public float diem { get; set; }
        int soCauDUng { get; set; }
        //public static List<BaiThi> baiDaThiTemp1 = new List<BaiThi>();
        public static List<KetQuaThi> ketQua1 = new List<KetQuaThi>();
        int socau = getInfo.tongSoCauHoi;
        static string baiThi = "";

        private void CapNhatLuoiKetQua()
        {
            int maCauHoi;

            for (int i = 0; i < socau; i++)
            {
                maCauHoi = getInfo.list[i].cauHoi;
                ketQua1.Add(new KetQuaThi(i + 1, "", "", maCauHoi));
            }
            for (int i = 0; i < socau; i++)
            {
                for (int j = 0; j < getInfo.baiDaThiTemp.Count; j++)
                {
                    if (ketQua1[i].cauHoi == getInfo.baiDaThiTemp[j].cau)
                    {
                        ketQua1[i].daChon = getInfo.baiDaThiTemp[j].traLoi;
                        break;
                    }
                }
                for (int j = 0; j < socau; j++)
                {
                    if (ketQua1[i].maCauHoi == getInfo.list[j].cauHoi)
                    {
                        ketQua1[i].dapAn = getInfo.list[j].dapAn;
                        break;
                    }
                }
            }
            for (int h = 0; h < ketQua1.Count; h++)
            {
                baiThi += " " + ketQua1[h].cauHoi.ToString() + "-" + ketQua1[h].daChon.ToString();
            }
        }

        private void CapNhatBangDiem()
        {
            if (Software.mGroup == "SINHVIEN")
            {
                var ngayThiCheck = (from a in db.GIAOVIEN_DANGKY
                                    where a.NGAYTHI < DateTime.Now
                                    select a
                               ).ToList();

                var query = new BANGDIEM();

                query.MAMH = frmThongTinThi.ChonMonHoc;
                query.MASV = txtMaSV.Text;
                query.LAN = (short)frmThongTinThi.LanThi;
                query.NGAYTHI = frmThongTinThi.NgayThi;

                query.DIEM = float.Parse(txtDiem.Text);
                //query.BAITHI = baiThi.ToString();
                //db.BANGDIEMs.Add(query);
                db.SaveChanges();
            }
            else
            { return; };
        }

        private void frmKetQuaThi_Load(object sender, EventArgs e)
        {
            CapNhatLuoiKetQua();
            if (Software.mGroup == "SINHVIEN")
            {

                getInfo info = new getInfo();
                List<float> temp = info.tinhDiem();
                diem = temp[0];
                soCauDUng = (int)temp[1];
                txtDiem.Text = diem + "";
                labketqua.Text = soCauDUng + "/" + socau;

                txtMaSV.Text = Software.username;
                txtHoTen.Text = Software.mHoten;
                txtLop.Text = Software.lop;

                for (int i = 0; i < socau; i++)
                {
                    dgvKetQua.Rows.Add(ketQua1[i].cauHoi, ketQua1[i].daChon, ketQua1[i].dapAn);
                }
                CapNhatBangDiem();
            }
            if (Software.mGroup == "GIAOVIEN")
            {
                getInfo info = new getInfo();
                List<float> temp = info.tinhDiem();
                diem = temp[0];
                soCauDUng = (int)temp[1];
                txtDiem.Text = diem + "";
                labketqua.Text = soCauDUng + "/" + socau;

                txtMaSV.Text = Software.username;
                txtHoTen.Text = Software.mHoten;
                txtLop.Text = Software.lop;

                for (int i = 0; i < socau; i++)
                {
                    dgvKetQua.Rows.Add(ketQua1[i].cauHoi, ketQua1[i].daChon, ketQua1[i].dapAn);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
