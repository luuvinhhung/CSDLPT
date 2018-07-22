using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using PTITTracNghiem.GiaoDien;

namespace PTITTracNghiem
{
    public class Software
    {
        #region Khai bao
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader myReader;

        public static frmMain fmain;
        public static frmDangNhap fdn;
        public static String server;
        public static String username ;
        public static String password;
        public static String database = "TRACNGHIEM";
        public static String mlogin;
        public static String mGroup;
        public static String mHoten;
        public static String lop;
        public static String State;
        public static String Theo = "";
        //public static int flag = fmain.flag;
        public static String Error = "";

        public static string connString = "metadata=res://*/DuLieu.TracNghiem.csdl|res://*/DuLieu.TracNghiem.ssdl|res://*/DuLieu.TracNghiem.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source="+Software.server+" initial catalog="+ Software.database+ ";user id="
            + mlogin + ";password=" + password + ";MultipleActiveResultSets=True;App=EntityFramework&quot;" + " providerName='System.Data.EntityClient'";
        public static DateTime Date { get; }
        public static DateTime getDayNow = DateTime.Now.Date;
        #endregion

        public static int KetNoi()
        {
            if (Software.conn != null && Software.conn.State == ConnectionState.Open) Software.conn.Close();
            try
            {
                Software.connstr = "Data Source="+Software.server + ";Initial Catalog=" + Software.database.Trim() + ";User ID=" +
                      Software.mlogin + ";password=" + Software.password;
                Software.conn.ConnectionString = Software.connstr;
                Software.conn.Open();
                return 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + ex.Message, "", MessageBoxButtons.OK);
                //MessageBox.Show("Username và Password không đúng!!! ", "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Software.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Software.conn.State == ConnectionState.Closed) Software.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu trên Database \n" + e.Message);
                Software.conn.Close();
                return null;
            }
        }
        public static bool IsNumber(string pValue)
        {
            foreach (char c in pValue)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }
        public static bool IsLogin(string pValue)
        {
            foreach (char c in pValue)
            {
                if (!Char.IsNumber(c) || c != ' ')
                    return true;
            }
            return false;
        }
        public static int SPchangeRow(string sql)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstr);
                //MessageBox.Show(conStr);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.Connection.Open();
                int rows = command.ExecuteNonQuery();
                connection.Close();
                return rows;
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thêm được" + e);
                //  connection.Close();
                return 0;

            }
        }
    }
}
