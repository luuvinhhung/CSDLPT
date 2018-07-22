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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public static string connstr = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            LayThongTinPhanManh();
        }
        private void LayThongTinPhanManh()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MRLTC\LTCSV;Initial Catalog=TRACNGHIEM;User ID=sa;Password=123");
               
                conn.Open();
                string sql = "EXEC DBO.SP_THONGTINPHANMANH";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                da.Fill(table);
                cbbCoSo.DataSource = table;
                cbbCoSo.DisplayMember = table.Columns["description"].ToString();
                cbbCoSo.ValueMember = table.Columns["subscriber"].ToString();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("KẾT NỐI THẤT BẠI.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }



        private void btDangNhap_Click(object sender, EventArgs e)
        {
            Program.ServerName = cbbCoSo.SelectedValue.ToString();
           // Program.Description = cbbCoSo.SelectedItem.ToString();
            Program.username = txtUserName.Text;
            Program.password = txtPassword.Text;
            Program.connStr = "Data Source=" + Program.ServerName + ";Initial Catalog=" + Program.Database + ";User ID=" + Program.username + ";Password=" + Program.password;
            Program.conn = new SqlConnection(Program.connStr);
            Program.mChinhanh = cbbCoSo.SelectedIndex;
            try
            {
                Program.conn.Open();
                using (IDbCommand spCommand = Program.conn.CreateCommand())
                {
                    spCommand.CommandText = "SP_DANGNHAP";
                    spCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    IDbDataParameter carIdParameter = spCommand.CreateParameter();
                    carIdParameter.ParameterName = "@TENLOGIN";
                    carIdParameter.Value = Program.username;
                    spCommand.Parameters.Add(carIdParameter);

                    IDbDataParameter role = spCommand.CreateParameter();
                    role.ParameterName = "@ROLE";
                    role.Direction = System.Data.ParameterDirection.Output;
                    role.DbType = System.Data.DbType.String;
                    role.Size = 250;
                    spCommand.Parameters.Add(role);
                    spCommand.ExecuteNonQuery();
                    Program.role = role.Value.ToString();

                    LayTen_DangNhap();
                    Form1 f = new Form1();
                    f.Show();
                    this.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu" + ex);
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }
    private void LayTen_DangNhap()

        {
            try
            {
                using (IDbCommand spCommand = Program.conn.CreateCommand())
                {
                    spCommand.CommandText = "SP_LAYTEN_DANGNHAP";
                    spCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    IDbDataParameter carIdParameter = spCommand.CreateParameter();
                    carIdParameter.ParameterName = "@ROLE";
                    carIdParameter.Value = Program.role;
                    spCommand.Parameters.Add(carIdParameter);

                    IDbDataParameter carIdParameter1 = spCommand.CreateParameter();
                    carIdParameter1.ParameterName = "@LGNAME";
                    carIdParameter1.Value = Program.username;
                    spCommand.Parameters.Add(carIdParameter1);

                    IDbDataParameter hoTen = spCommand.CreateParameter();
                    hoTen.ParameterName = "@HOTEN";
                    hoTen.Direction = System.Data.ParameterDirection.Output;
                    hoTen.DbType = System.Data.DbType.String;
                    hoTen.Size = 300;
                    spCommand.Parameters.Add(hoTen);
                    spCommand.ExecuteNonQuery();
                    Program.hoTen = hoTen.Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}