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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

       
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            label1.Text = Program.username.ToString().ToUpper();
            password.Text = Program.password.ToString();
            password.Visible = false;
        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            try
            {

                if (newpass.Text.Equals(""))
                {

                    MessageBox.Show("Pass không được rỗng.!.");
                    newpass.Text = "";
                }
                else
                {
                    SqlCommand cmd = Program.conn.CreateCommand();
                    cmd.CommandText = "SP_SUAPASS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter inParam = new SqlParameter();
                    inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x = "@" + "LGNAME";
                    inParam.ParameterName = x;
                    inParam.Direction = System.Data.ParameterDirection.Input;
                    inParam.Value = Program.username;
                    cmd.Parameters.Add(inParam);

                    SqlParameter inParam1 = new SqlParameter();
                    inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x1 = "@" + "OLDPASS";
                    inParam1.ParameterName = x1;
                    inParam1.Direction = System.Data.ParameterDirection.Input;
                    inParam1.Value = Program.password;
                    cmd.Parameters.Add(inParam1);


                    SqlParameter inParam2 = new SqlParameter();
                    inParam2.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x2 = "@" + "NEWPASS";
                    inParam2.ParameterName = x2;
                    inParam2.Direction = System.Data.ParameterDirection.Input;
                    inParam2.Value = newpass.Text;
                    cmd.Parameters.Add(inParam2);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dổi mật khẩu thành công.!.");
                        newpass.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đổi mật khẩu thất bạn rồi.!.");
                    }

                }
            }
            catch (Exception ex) { }

        }

        private void btHuyThayDoi_Click(object sender, EventArgs e)
        {
            password.Text = "";
            newpass.Text = "";
        }
    }
}