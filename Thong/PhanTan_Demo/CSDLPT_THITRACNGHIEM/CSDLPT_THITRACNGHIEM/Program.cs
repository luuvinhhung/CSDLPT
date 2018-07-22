using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace CSDLPT_THITRACNGHIEM
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BonusSkins.Register();
			SkinManager.EnableFormSkins();
			Application.Run(new frmDangNhap());
		}
		public static String tenServer;
		public static SqlConnection conn = new SqlConnection();
		public static String connStr = "";
		public static SqlDataAdapter da;
		public static SqlDataReader myReader;


		public static String TempServerName = "";
		public static String LoginTemp = "";
		public static String PasswordTemp = "";

		public static String ServerName = ""; // Chứa Server ta đang làm việc. Trả về tên Server  /
		public static String LoginName = ""; // phải biết ai trong trường đang sài 
		public static String Password = "";
		public static String servername1 = "DESKTOP-GBEAE83\\SERVER1";
		public static String servername2 = "DESKTOP-GBEAE83\\SERVER2";


		public static String Database = "TRACNGHIEM";
		public static String Description = "";
		public static String Username = "";
		public static String RoleName = "";
		public static String TenLop = "";
		public static String ID = "";
		public static String FullName = "";
		public static String LoginSupport = "SUPPORT_CONNECT"; //  Hỗ trợ kết nối từ xa  . Link server .
		public static String PasswordSupport = "pt";
		public static String TempLogin = "";
		public static String TempPassword = "";
		public static String mlogin;
		public static String mGroup;
		public static String mHoten;



		public static bool flagChangeDB = false;

		internal static SqlDataReader ExecSqlDataReader(string strLengh)
		{
			throw new NotImplementedException();
		}

		internal static string password;
		internal static string username;
		internal static string role;
		internal static string hoTen;
		public static BindingSource bds_dspm = new BindingSource();
		internal static int mChinhanh = 0;
		public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
		{
			SqlDataReader myreader;
			//Program.conn = new SqlConnection(connectionstring);

			SqlCommand sqlcmd = new SqlCommand();
			sqlcmd.Connection = Program.conn;
			sqlcmd.CommandText = cmd;
			sqlcmd.CommandType = CommandType.Text;

			if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
			try
			{
				myreader = sqlcmd.ExecuteReader(); return myreader;
			}
			catch (SqlException ex)
			{
				Program.conn.Close();
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static DataTable ExecSqlQuery(String cmd, String connectionstring)
		{
			DataTable dt1 = new DataTable();
			conn = new SqlConnection(connectionstring);
			da = new SqlDataAdapter(cmd, conn);
			da.Fill(dt1);
			return dt1;

		}



		public static void NgatKetNoi()
		{
			if (Program.conn != null && Program.conn.State == ConnectionState.Open)
				Program.conn.Close();
		}
		internal static DataTable ExecSqlDataAdapter(string sql)
		{
			throw new NotImplementedException();
		}
		public static int KetNoi()
		{
			if (Program.conn != null && Program.conn.State == ConnectionState.Open)
				Program.conn.Close();
			try
			{
				Program.connStr = "Data Source=" + Program.tenServer + ";Initial Catalog=" + // chứa chuỗi kết nối  khác đối tượng kết nối.
					  Program.Database + ";User ID=" +
					  Program.username + ";password=" + Program.password;
				Program.conn.ConnectionString = Program.connStr;
				Program.conn.Open();
				return 1;
			}

			catch (Exception e)
			{
				MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
				return 0;
			}
		}
		public static void SetEnableOfButton(Form frm, Boolean Active)
		{

			foreach (Control ctl in frm.Controls)
				if ((ctl) is Button)
					ctl.Enabled = Active;
		}
		

	}
}
