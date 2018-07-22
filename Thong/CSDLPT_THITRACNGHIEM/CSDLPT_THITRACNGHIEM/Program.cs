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


        public static SqlConnection conn = new SqlConnection();
        public static String connStr = "";

        public static String TempServerName = "";
        public static String LoginTemp = "";
        public static String PasswordTemp = "";

        public static String ServerName = "";
        public static String LoginName = "";
        public static String Password = "";

        public static String Database = "TRACNGHIEM";
        public static String Description = "";
        public static String Username = "";
        public static String RoleName = "";
        public static String TenLop = "";
        public static String ID = "";
        public static String FullName = "";
        public static String LoginSupport = "HOTROKETNOI";
        public static String PasswordSupport = "123";

        public static String TempLogin = "";
        public static String TempPassword = "";


        public static bool flagChangeDB = false;
        internal static string password;
        internal static string username;
        internal static string role;
        internal static string hoTen;
        public static BindingSource bds_dspm = new BindingSource();
        internal static int mChinhanh =0;

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
                Program.connStr = "Data Source=" + Program.ServerName + ";Initial Catalog=" +
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
    }
}
