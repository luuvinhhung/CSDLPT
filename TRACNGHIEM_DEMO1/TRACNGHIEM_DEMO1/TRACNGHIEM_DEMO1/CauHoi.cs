using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRACNGHIEM_DEMO1
{
	class CauHoi
	{
		public CauHoi(int maCH)
		{
			this.maCH = maCH;
		}

		private int maCH;
		private Char cauTL;
		private int key;

		public int _Key
		{
			get { return key; }
			set { key = value; }
		}
		public Char CauTL
		{
			get { return cauTL; }
			set { cauTL = value; }
		}
		public int MaCH
		{
			get { return maCH; }
			set { maCH = value; }
		}
		private String noiDung;

		public String NoiDung
		{
			get { return noiDung; }
			set { noiDung = value; }
		}
		private String cauA, cauB, cauC, cauD;
		private String maMH, maGV;

		public String _MaGV
		{
			get { return maGV; }
			set { maGV = value; }
		}

		public String _MaMH
		{
			get { return maMH; }
			set { maMH = value; }
		}
		private Char trinhDo;

		public Char _TrinhDo
		{
			get { return trinhDo; }
			set { trinhDo = value; }
		}
		public String CauD
		{
			get { return cauD; }
			set { cauD = value; }
		}

		public String CauC
		{
			get { return cauC; }
			set { cauC = value; }
		}

		public String CauB
		{
			get { return cauB; }
			set { cauB = value; }
		}

		public String CauA
		{
			get { return cauA; }
			set { cauA = value; }
		}
		private Char dapAn;

		public Char DapAn
		{
			get { return dapAn; }
			set { dapAn = value; }
		}

		public CauHoi()
		{
			noiDung = cauA = cauB = cauC = cauD = "";
			dapAn = 'A';
			maCH = 0;
			maGV = maMH = "";
			trinhDo = ' ';
			key = 0;
		}
		public CauHoi(int maCH, String noiDung, String cauA, String cauB, String cauC, String cauD, Char da)
		{
			this.maCH = maCH;
			this.noiDung = noiDung;
			this.cauA = cauA;
			this.cauB = cauB;
			this.cauC = cauC;
			this.cauD = cauD;
			this.dapAn = da;
			this.cauTL = 'F';
		}
		public CauHoi(int maCH, String noiDung, String cauA, String cauB, String cauC, String cauD, Char da, Char trinhDo, String maGV, String maMH)
		{
			this.maCH = maCH;
			this.noiDung = noiDung;
			this.cauA = cauA;
			this.cauB = cauB;
			this.cauC = cauC;
			this.cauD = cauD;
			this.dapAn = da;
			this.cauTL = 'F';
			this.trinhDo = trinhDo;
			this.maGV = maGV;
			this.maMH = maMH;
		}
	}
}