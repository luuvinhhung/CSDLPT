using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTITTracNghiem
{
    public class KetQuaThi
    {
        public int cauHoi { get; set; }
        public string daChon { get; set; }
        public string dapAn { get; set; }
        public int maCauHoi { get; set; }

        public KetQuaThi(){}

        public KetQuaThi(int cauHoi, string daChon, string dapAn, int maCauHoi)
        {
            this.cauHoi = cauHoi;
            this.daChon = daChon;
            this.dapAn = dapAn;
            this.maCauHoi = maCauHoi;
        }

        public KetQuaThi(int cauHoi, string daChon, string dapAn)
        {
            this.cauHoi = cauHoi;
            this.daChon = daChon;
            this.dapAn = dapAn;
        }
    }

    public class DeThi
    {
        public int cauHoi { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string maMH { get; set; }
        public string noiDung { get; set; }
        public string dapAn { get; set; }

        public DeThi() { }

        public DeThi(int cauHoi, string A, string B, string C, string D, string maMH, string noiDung, string dapAn)
        {
            this.cauHoi = cauHoi;
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.maMH = maMH;
            this.noiDung = noiDung;
            this.dapAn = dapAn;
        }
    }

    public class BaiThi
    {
        public int cau { get; set; }
        public string traLoi { get; set; }
        public int maCauHoi { get; set; }

        public BaiThi(int p1, string p2, int p3)
        {
            this.cau = p1;
            this.traLoi = p2;
            this.maCauHoi = p3;
        }
    }

    public class DapAn
    {
        public int maCau;
        public string dapAn;
    }
}
