using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PTITTracNghiem.DuLieu;

namespace PTITTracNghiem
{
    public class getInfo
    {
        static TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public static List<BaiThi> baiDaThiTemp;
        public static List<KetQuaThi> ketQua;
        public static int tongSoCauHoi;
        public static List<DeThi> list;
        static float tongDiem = 0f;


        public getInfo() { }

        public List<DeThi> getBoDe(int soCau, string trinhDo, string maMonHoc)
        {
            var listtemp = db.SP_DSLOGIN()/*SP_LAYCAUHOI(soCau, trinhDo, maMonHoc)*/;
            
            list = new List<DeThi>();
            var boDe = db.BODEs.ToList();
            foreach (var item in listtemp)
            { 
                //var t = boDe.Select(p => new DeThi
                //{
                //    noiDung = p.NOIDUNG,
                //    cauHoi = p.CAUHOI,
                //    A = p.A,
                //    B = p.B,
                //    C = p.C,
                //    D = p.D,
                //    maMH = p.MAMH,
                //    dapAn = p.DAP_AN.ToString().Trim()
                //})./*Where(p => p.cauHoi == item.CAUHOI).ToList();*/
                //list.Add(new DeThi(t[0].cauHoi, t[0].A, t[0].B, t[0].C, t[0].D, t[0].maMH, t[0].noiDung, t[0].dapAn));
            }
            tongSoCauHoi = soCau;
            return list;
        }


        public List<float> tinhDiem()
        {
            float dung = 0;
            float diemMoiCau = 10 / (float)tongSoCauHoi;

            for (int i = 0; i < baiDaThiTemp.Count; i++)
            {
                
                for (int j = 0; j < tongSoCauHoi; j++)
                {
                    if (baiDaThiTemp[i].maCauHoi == list[j].cauHoi)
                    {
                        if (baiDaThiTemp[i].traLoi.Equals(list[j].dapAn.ToString().Trim()))
                        {
                            tongDiem += diemMoiCau;
                            dung++;
                        }
                        break;
                    }
                }
            }
            List<float> listFloat = new List<float>();
            listFloat.Add(tongDiem);
            listFloat.Add(dung);
            //XuatBaiThi();
            return listFloat;
            //chuanHoaBaiThi();
        }

        public List<float> TinhCauDungGiaoVien()
        {
            float dung = 0; 
            for (int i = 0; i < baiDaThiTemp.Count; i++)
            {
                for (int j = 0; j < tongSoCauHoi; j++)
                {
                    
                    if (baiDaThiTemp[i].maCauHoi == list[j].cauHoi)
                    {
                        if (baiDaThiTemp[i].traLoi.Equals(list[j].dapAn.ToString().Trim()))
                        {
                            dung++;
                        }
                        break;
                    }
                }
            }

            List<float> listFloat = new List<float>();
            //listFloat.Add(tongDiem);
            listFloat.Add(dung);
            //XuatBaiThi();
            return listFloat;
        }

    }
}
