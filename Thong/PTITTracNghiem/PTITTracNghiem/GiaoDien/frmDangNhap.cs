using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PTITTracNghiem.DuLieu;

namespace PTITTracNghiem.GiaoDien
{

    public partial class frmDangNhap : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        TRACNGHIEMEntities1 db1 = new TRACNGHIEMEntities1();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            xuatServer();
        }
        void xuatServer()
        {
            this.cbxCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCoSo.Items.Add("Cơ sở Hà Nội");
            cbxCoSo.Items.Add("Cơ sở Tp.Hồ Chí Minh");
        }
        string username;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Software.mlogin = txtLogin.Text.Trim();
            Software.password = txtPass.Text.Trim();
            
            if (Software.KetNoi() == 0)
            {
                MessageBox.Show("Kết Nối Thất Bại", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtLogin.Text.Trim() == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Tài Khoản Đăng Nhập !!!", "LƯU Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var dslogin = db.SP_DSLOGIN().ToList();
                    if (Software.server == "NGHIAPC\\SERVER1")
                    {                  
                        var itemlogin = dslogin.Where(p => p.Loginname == Software.mlogin);
                        Software.username = itemlogin.Select(p => p.MANV).ToString();
                        Software.mGroup = itemlogin.Select(p => p.rolename).ToString();
                        if (Software.mGroup == "SINHVIEN")
                        {
                            Software.mHoten = db.SINHVIENs.Where(p => p.MASV == Software.username).Select(p => p.HO + " " + p.TEN).ToString();
                        }
                        else Software.mHoten = db.GIAOVIENs.Where(p => p.MAGV == Software.username).Select(p => p.HO + " " + p.TEN).ToString();
                    }
                    else
                    {
                        var dslogin1 = db1.SP_DSLOGIN().ToList();
                        var itemlogin = dslogin.Where(p => p.Loginname == Software.mlogin);
                        Software.username = itemlogin.Select(p => p.MANV).ToString();
                        Software.mGroup = itemlogin.Select(p => p.rolename).ToString();
                        if (Software.mGroup == "SINHVIEN")
                        {
                            Software.mHoten = db1.SINHVIENs.Where(p => p.MASV == Software.username).Select(p => p.HO + " " + p.TEN).ToString();
                        }
                        else Software.mHoten = db1.GIAOVIENs.Where(p => p.MAGV == Software.username).Select(p => p.HO + " " + p.TEN).ToString();
                    }
                    this.Close();
                    //MessageBox.Show("Đăng nhập thành công !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
   

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            //    var rk = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server");
            //    var instances = (String[])rk.GetValue("InstalledInstances");
            //    if (instances.Length > 0)
            //    {
            //        foreach (var element in instances)
            //        {
            //            if (element == "MSSQLSERVER" || element == "SQLEXPRESS")
            //            {
            //                continue;
            //            }
            //            else
            //                //    if ((System.Environment.MachineName + @"\" + element).Trim() == "HAINGUYEN-PC" + @"\" + "DHTH000")
            //                //    {
            //                //        cboCoso.Items.Add("Hà Nội");
            //                //    }
            //                //if ((System.Environment.MachineName + @"\" + element).Trim() == "HAINGUYEN-PC" + @"\" + "DHTH001")
            //                //{
            //                //    cboCoso.Items.Add("Thành Phố Hồ Chí Minh");
            //                //}
            //                cboCoso.Items.Add(System.Environment.MachineName + @"\" + element);
            //        }

            //    }
            //    cboCoso.SelectedIndex = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Không load được server." + ex.Message, "Thông báo!", MessageBoxButtons.OK);
            //}
        }

        private void cbxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxCoSo.Text == "Cơ sở Hà Nội")
            { Software.server = "NGHIAPC\\SERVER1"; }
            else Software.server = "NGHIAPC\\SERVER2";
        }
    }
}
