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
    public partial class frmRPCauTraLoi : DevExpress.XtraEditors.XtraForm
    {
        public string monHoc;
        public string trinhDo;
        public string lanThi;
        public frmRPCauTraLoi()
        {
            InitializeComponent();
        }
        private void frmRPCauTraLoi_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
          
            chonMH();
            monHoc = comboBox1.SelectedValue.ToString();
        }
        private void chonMH()
        {
            string sql1 = " EXEC SP_LAYMMHDATHI '" + Program.username + "'";
            SqlCommand com1 = new SqlCommand(sql1, Program.conn);
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = dt1.Columns["MAMONHOC"].ToString();
            comboBox1.ValueMember = dt1.Columns["MAMONHOC"].ToString();
            //monHoc = comboBox1.SelectedValue.ToString();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            rpCauTraLoi re = new rpCauTraLoi();
            try
            {
                string sql = "exec SP_RP_CAUTRALOI '" + Program.username + "','" + monHoc + "','" + trinhDo + "'," + lanThi + "";
                SqlCommand com1 = new SqlCommand(sql, Program.conn);
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                re.SetDataSource(dt1);
                crystalReportViewer1.ReportSource = re;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chạy SP_Report");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            monHoc = comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            trinhDo = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lanThi = comboBox3.SelectedItem.ToString();
        }
    }
}