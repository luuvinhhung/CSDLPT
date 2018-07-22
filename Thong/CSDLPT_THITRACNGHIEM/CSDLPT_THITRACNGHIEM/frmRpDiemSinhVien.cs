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
    public partial class frmRpDiemSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmRpDiemSinhVien()
        {
            InitializeComponent();
        }
        public string luuChonLop;
        public string luuChonMH;
        public string lanThi;
        private void cbChonLops()
        {
            string sql = " SELECT MALOP,TENLOP FROM LOP";
            SqlCommand com = new SqlCommand(sql, Program.conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxLop.DataSource = dt;
            comboBoxLop.DisplayMember = dt.Columns["TENLOP"].ToString();
            comboBoxLop.ValueMember = dt.Columns["MALOP"].ToString();
            luuChonLop = comboBoxLop.SelectedValue.ToString();
        }
        private void chonMH()
        {
            string sql1 = " SELECT MAMONHOC FROM MONHOC ";
            SqlCommand com1 = new SqlCommand(sql1, Program.conn);
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBoxMon.DataSource = dt1;
            comboBoxMon.DisplayMember = dt1.Columns["MAMONHOC"].ToString();
            comboBoxMon.ValueMember = dt1.Columns["MAMONHOC"].ToString();
            luuChonMH = comboBoxMon.SelectedValue.ToString();
        }
        private void frmRpDiemSinhVien_Load(object sender, EventArgs e)
        {
            if (Program.role == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
                
            }
            else
            {
                comboBoxCoSo.Enabled = false;
            }
            LayThongTinPhanManh();
            comboBoxCoSo.SelectedIndex = Program.mChinhanh;
            comboBoxLan.SelectedIndex = 0;
            cbChonLops();
            chonMH();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            luuChonLop = comboBoxLop.SelectedValue.ToString();
        }

        private void comboBoxMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            luuChonMH = comboBoxMon.SelectedValue.ToString();
        }

        private void comboBoxLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lanThi = comboBoxLan.SelectedItem.ToString();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            rpDiemSinhVien re = new rpDiemSinhVien();
            try
            {
                string sql = "exec SP_RPBANDIEM '" + luuChonLop + "','" + luuChonMH + "'," + lanThi + "";
                SqlCommand com1 = new SqlCommand(sql, Program.conn);
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                re.SetDataSource(dt1);
                crystalReportViewer1.ReportSource = re;
            }
            catch (Exception ex)
            {

            }
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
                comboBoxCoSo.DataSource = table;
                comboBoxCoSo.DisplayMember = table.Columns["description"].ToString();
                comboBoxCoSo.ValueMember = table.Columns["subscriber"].ToString();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("KẾT NỐI THẤT BẠI.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void comboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                Program.ServerName = comboBoxCoSo.SelectedValue.ToString();
            }

            else
            {
                Program.conn.Close();
                Program.ServerName = comboBoxCoSo.SelectedValue.ToString();
                Program.connStr = "Data Source=" + Program.ServerName + ";Initial Catalog=" + Program.Database + ";User ID=" + Program.LoginSupport + ";Password=" + Program.PasswordSupport;
                Program.conn = new SqlConnection(Program.connStr);
                chonMH();
                cbChonLops();
                
            }
        }
    }
}