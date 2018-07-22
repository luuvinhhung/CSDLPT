using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTITTracNghiem.DuLieu;
using System.Data.SqlClient;

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmBackupRestore : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmBackupRestore()
        {
            InitializeComponent();
        }
        private String maBV = "12345";
        private void gcBaR_Click(object sender, EventArgs e)
        {
            tbPosition.Text = gvBaR.GetRowCellValue(gvBaR.FocusedRowHandle, gvBaR.Columns[0]).ToString();
            tbNgay.Text = gvBaR.GetRowCellValue(gvBaR.FocusedRowHandle, gvBaR.Columns[1]).ToString();
        }
        public void Showbackup()
        {
            var backup = db.SP_DSLOGIN().ToList();
            
            gcBaR.DataSource = backup;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            tbNgay.Text = "";
            tbPosition.Text = "";
            tbNgay.Enabled = false;
            tbPosition.Enabled = false;
            cbPhienBan.Items.Add("Ghi mới");
            cbPhienBan.Items.Add("Ghi đè");
            Showbackup();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            if (cbPhienBan.Text.Trim() == "Ghi đè" && tbMa.Text.Trim() == maBV)
            {
                String sp_bk = "SP_BACKUPBD " + 1;
                Software.SPchangeRow(sp_bk);
                Showbackup();
            }
            else if(tbMa.Text.Trim() == maBV)
            {
                String sp_bk = "SP_BACKUPBD " + 2;
                Software.SPchangeRow(sp_bk);
                Showbackup();
            }
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            cbPhienBan.Enabled = false;
            tbMa.Enabled = true;

            if (tbMa.Text.Trim() == maBV)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=" + Software.server + ";"
                                + " Initial Catalog=" + Software.database + ";"
                                + " User ID=" + Software.username + ";"
                                + "password=" + Software.password;
                    conn.Open();//keet noi
                    SqlCommand command = new SqlCommand(); //thujw thi T-QSL - cac cau lenh sql
                    command.CommandText = "Use tempdb";//doi toi db tempdb
                    command.Connection = conn;
                    command.ExecuteNonQuery();


                    SqlCommand command2 = new SqlCommand(); //thujw thi T-QSL - cac cau lenh sql
                    command2.CommandText = "alter database TRACNGHIEM set single_user with rollback immediate ";//chuyen 1 nguoi dung
                    command2.Connection = conn;
                    command2.ExecuteNonQuery();

                    SqlCommand command3 = new SqlCommand(); //thujw thi T-QSL - cac cau lenh sql
                    command3.CommandText = "restore database TRACNGHIEM from TRACNGHIEM_DEVICE with file =" + Convert.ToInt16(tbPosition.Text.Trim()) + ", replace, recovery";//restore
                    command3.Connection = conn;
                    command3.ExecuteNonQuery();

                    SqlCommand command4 = new SqlCommand(); //thujw thi T-QSL - cac cau lenh sql
                    command4.CommandText = "alter database TRACNGHIEM set multi_user";//chuyen n` nguoi dung
                    command4.Connection = conn;
                    command4.ExecuteNonQuery();

                    SqlCommand command5 = new SqlCommand(); //thujw thi T-QSL - cac cau lenh sql
                    command5.CommandText = "use TRACNGHIEM";//chuyen n` nguoi dung
                    command5.Connection = conn;
                    command5.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Restore Database TRACNGHIEM thành công","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmBackupRestore_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.ToString(),"XẢY RA LỖI",MessageBoxButtons.OK,MessageBoxIcon.Error); ;
                }
            }
        }
    }
}
