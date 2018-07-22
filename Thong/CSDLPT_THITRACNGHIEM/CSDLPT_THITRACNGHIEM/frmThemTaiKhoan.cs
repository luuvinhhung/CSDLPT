using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace CSDLPT_THITRACNGHIEM
{
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private string role;
        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
           if(Program.role == "TRUONG")
            {
                radioButtonCoSo.Visible = false;
                radioButtonGiangVien.Visible = false;
                radioButtonSinhVien.Visible = false;
                radioButtonTruong.Visible = true;
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            using (IDbCommand spCommand = Program.conn.CreateCommand())
            {
              
                if (txtPass.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được trống");
                }
                else
                {
                    SqlCommand cmd = Program.conn.CreateCommand();
                    cmd.CommandText = "SP_TAOLOGIN";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter inParam = new SqlParameter();
                    inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x = "@" + "LGNAME";// dang nh?p vô toàn b? DB
                    inParam.ParameterName = x;
                    inParam.Direction = System.Data.ParameterDirection.Input;
                    inParam.Value = txtTenDangNhap.Text;
                    cmd.Parameters.Add(inParam);

                    SqlParameter inParam1 = new SqlParameter();
                    inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x1 = "@" + "PASS";
                    inParam1.ParameterName = x1;
                    inParam1.Direction = System.Data.ParameterDirection.Input;
                    inParam1.Value = txtPass.Text;
                    cmd.Parameters.Add(inParam1);


                    SqlParameter inParam2 = new SqlParameter();
                    inParam2.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x2 = "@" + "USERNAME";// dang nh?p vô database c?a co s? d? li?u mình
                    inParam2.ParameterName = x2;
                    inParam2.Direction = System.Data.ParameterDirection.Input;
                    inParam2.Value = txtTenTK.Text;
                    cmd.Parameters.Add(inParam2);


                    SqlParameter inParam3 = new SqlParameter();
                    inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x3 = "@" + "ROLE";
                    inParam3.ParameterName = x3;
                    inParam3.Direction = System.Data.ParameterDirection.Input;
                    inParam3.Value = role.ToString();
                    cmd.Parameters.Add(inParam3);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tạo tài khoản thành công.!.");
                        
                        txtPass.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tạo tài khoản Thất bại.!." + ex);
                        txtPass.Text = "";
                    }
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

      

        private void radioButtonTruong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((radioButtonTruong.Checked == true) || (radioButtonCoSo.Checked == true) || (radioButtonGiangVien.Checked == true))
                {
                    role = "TRUONG";
                    string dsgv = "exec SP_DANHSACHGIANGVIENCHUACOTAIKHOAN";
                    SqlCommand com = new SqlCommand(dsgv, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxDSChuaCoTaiKhoan.DataSource = dt;
                    comboBoxDSChuaCoTaiKhoan.DisplayMember = dt.Columns["HOTEN"].ToString();
                    comboBoxDSChuaCoTaiKhoan.ValueMember = dt.Columns["MAGIANGVIEN"].ToString();
                    txtTenTK.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                    txtTenDangNhap.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void radioButtonCoSo_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if ((radioButtonTruong.Checked == true) || (radioButtonCoSo.Checked == true) || (radioButtonGiangVien.Checked == true))
                {
                    role = "COSO";
                    string dsgv = "exec SP_DANHSACHGIANGVIENCHUACOTAIKHOAN";
                    SqlCommand com = new SqlCommand(dsgv, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxDSChuaCoTaiKhoan.DataSource = dt;
                    comboBoxDSChuaCoTaiKhoan.DisplayMember = dt.Columns["HOTEN"].ToString();
                    comboBoxDSChuaCoTaiKhoan.ValueMember = dt.Columns["MAGIANGVIEN"].ToString();
                    txtTenTK.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                    txtTenDangNhap.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void radioButtonGiangVien_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if ((radioButtonTruong.Checked == true) || (radioButtonCoSo.Checked == true) || (radioButtonGiangVien.Checked == true))
                {
                    role = "GIANGVIEN";
                    string dsgv = "exec SP_DANHSACHGIANGVIENCHUACOTAIKHOAN";
                    SqlCommand com = new SqlCommand(dsgv, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxDSChuaCoTaiKhoan.DataSource = dt;
                    comboBoxDSChuaCoTaiKhoan.DisplayMember = dt.Columns["HOTEN"].ToString();
                    comboBoxDSChuaCoTaiKhoan.ValueMember = dt.Columns["MAGIANGVIEN"].ToString();
                    txtTenTK.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                    txtTenDangNhap.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void radioButtonSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
               if (radioButtonSinhVien.Checked == true)
                {
                    role = "SINHVIEN";
                    string dssv = "exec SP_DANHSACHSINHVIENCHUACOTAIKHOAN";
                    SqlCommand com1 = new SqlCommand(dssv, Program.conn);
                    SqlDataAdapter da1 = new SqlDataAdapter(com1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    comboBoxDSChuaCoTaiKhoan.DataSource = dt1;
                    comboBoxDSChuaCoTaiKhoan.DisplayMember = dt1.Columns["HOTEN"].ToString();
                    comboBoxDSChuaCoTaiKhoan.ValueMember = dt1.Columns["MASINHVIEN"].ToString();
                    txtTenTK.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
                    txtTenDangNhap.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();

                }
            }
            catch (Exception ex) { }
        }

        private void comboBoxDSChuaCoTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
            txtTenTK.Text = comboBoxDSChuaCoTaiKhoan.SelectedValue.ToString();
        }
    }
}