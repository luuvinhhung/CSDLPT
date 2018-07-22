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
    public partial class frmDangKyThi : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKyThi(Form1 f)
        {
            InitializeComponent();
        }
        public string format = "yyyy/MM/dd HH:mm:ss";
        public string luuChonLop;
        public string sql;
        public string luuChonMH;
        public int luuKiemTraSo;
        public string luuChonGV;
        public string luuTrinhdo;
        public int lan;
        public DateTime ngaydk;
        private void gIANGVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmDangKyThi_Load(object sender, EventArgs e)
        {
            if (Program.role == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
                groupBox1.Visible = false;
            }
            else
            {
                comboBoxCoSo.Enabled = false;
            }
            cbChonLops();
            this.gIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSet.MONHOC);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIANGVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIANGVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN_DANGKY);
            LayThongTinPhanManh();
            cbChonMH.SelectedIndex = 0;
            luuChonMH = cbChonMH.SelectedValue.ToString();
            cbChonLop.SelectedIndex = 0;
            luuChonLop = cbChonLop.SelectedValue.ToString();
            cbGiangvien.SelectedIndex = 0;
            luuChonGV = cbGiangvien.SelectedValue.ToString();
            cbLanThi.SelectedIndex = 0;
            lan = Int32.Parse(cbLanThi.SelectedItem.ToString());
            cbTrinhDo.SelectedIndex = 0;
            luuTrinhdo = cbTrinhDo.SelectedItem.ToString();
            dateTimePicker.MinDate = DateTime.Now;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                if ((textBoxSoCauThi.Equals("")) || (!(int.TryParse(textBoxSoCauThi.Text, out n))))
                {
                    MessageBox.Show("Số câu thi không được rỗng hoặc nhập chữ.!. Vui lòng nhập lại");
                    textBoxSoCauThi.Text = "";

                }
                if ((textBoxThoiGianThi.Equals("")) || (!(int.TryParse(textBoxThoiGianThi.Text, out n))))
                {
                    MessageBox.Show("Số câu thi không được rỗng hoặc nhập chữ.!. Vui lòng nhập lại");
                    textBoxThoiGianThi.Text = "";

                }
                if ((!(textBoxSoCauThi.Equals(""))) && (int.TryParse(textBoxSoCauThi.Text, out n))
                    && (!(textBoxThoiGianThi.Equals(""))) && (int.TryParse(textBoxThoiGianThi.Text, out n)))
                {
                    KiemTraSoCau();
                    int socau = Int32.Parse(textBoxSoCauThi.Text);
                    if (socau > luuKiemTraSo)
                    {
                        MessageBox.Show("Khong du so cau hoi");
                    }
                    else
                    {
                        SqlCommand cmd = Program.conn.CreateCommand();
                        cmd.CommandText = "SP_KIEMTRA_SOLANDANGKI";
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter inParam = new SqlParameter();
                        inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                        String x = "@" + "MAMONHOC";
                        inParam.ParameterName = x;
                        inParam.Direction = System.Data.ParameterDirection.Input;
                        inParam.Value = luuChonMH;
                        cmd.Parameters.Add(inParam);


                        SqlParameter inParam1 = new SqlParameter();
                        inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                        String x1 = "@" + "MAGIANGVIEN";
                        inParam1.ParameterName = x1;
                        inParam1.Direction = System.Data.ParameterDirection.Input;
                        inParam1.Value = luuChonGV;
                        cmd.Parameters.Add(inParam1);

                        SqlParameter inParam2 = new SqlParameter();
                        inParam2.SqlDbType = System.Data.SqlDbType.VarChar;
                        String x2 = "@" + "MALOP";
                        inParam2.ParameterName = x2;
                        inParam2.Direction = System.Data.ParameterDirection.Input;
                        inParam2.Value = luuChonLop;
                        cmd.Parameters.Add(inParam2);



                        SqlParameter inParam3 = new SqlParameter();
                        inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                        String x3 = "@" + "TRINHDO";
                        inParam3.ParameterName = x3;
                        inParam3.Direction = System.Data.ParameterDirection.Input;
                        inParam3.Value = luuTrinhdo;
                        cmd.Parameters.Add(inParam3);

                        SqlParameter retParam = new SqlParameter();
                        retParam.SqlDbType = System.Data.SqlDbType.Int;
                        retParam.ParameterName = "@" + "RET";
                        retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(retParam);
                        cmd.ExecuteNonQuery();
                        int i = (int)retParam.Value;
                        if ((int)retParam.Value == 1)
                        {
                            if (lan == 1)
                            {
                                MessageBox.Show("Môn học này đã được đăng kí lần 1.!.");
                            }
                            if (lan == 2)
                            {
                                KiemTraNgay(); 
                            }
                        }
                        if ((int)retParam.Value == 2)
                        {
                            if (lan == 1)
                            {
                                MessageBox.Show("Môn học đã được đăng kí lần 2.!. Không được đăng kí lần 1");
                            }
                            if (lan == 2)
                            {
                                MessageBox.Show("Môn học đã được đăng kí lần 2.!.");
                            }
                        }
                        if (!((int)retParam.Value == 2) && !((int)retParam.Value == 1))
                        {
                            if (lan == 1)
                            {
                                DateTime ngay = Convert.ToDateTime(dateTimePicker.Text);
                                string sql2 = "exec SP_DANGKYTHI '" + luuChonMH + "','" + luuChonGV + "','" + luuChonLop + "','" + luuTrinhdo + "','" + ngay + "'," + lan + "," + textBoxSoCauThi.Text + "," + textBoxThoiGianThi.Text;
                                SqlCommand com2 = new SqlCommand(sql2, Program.conn);
                                com2.ExecuteNonQuery();
                                MessageBox.Show("Đăng kí lần 1.!.");
                               
                            }
                            if (lan == 2)
                            {
                                MessageBox.Show("Môn học chưa đăng kí lần 1.!.");
                            }
                        }

                    }
                }

                dateTimePicker.Value = DateTime.Now;
                textBoxSoCauThi.Text = "";
                textBoxThoiGianThi.Text = "";
                this.gIANGVIEN_DANGKYBindingSource.EndEdit();
                this.gIANGVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng kí thi.!."+ex);
            }
        }

        private void KiemTraSoCau()
        {
            SqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "SP_SOLUONGCAUHOI";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter inParam = new SqlParameter();
            inParam.SqlDbType = System.Data.SqlDbType.VarChar;
            String x = "@" + "MAMONHOC";
            inParam.ParameterName = x;
            inParam.Direction = System.Data.ParameterDirection.Input;
            inParam.Value = luuChonMH;
            cmd.Parameters.Add(inParam);

            SqlParameter inParam3 = new SqlParameter();
            inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
            String x3 = "@" + "TRINHDO";
            inParam3.ParameterName = x3;
            inParam3.Direction = System.Data.ParameterDirection.Input;
            inParam3.Value = luuTrinhdo;
            cmd.Parameters.Add(inParam3);
            cmd.ExecuteNonQuery();

            SqlParameter retParam = new SqlParameter();
            retParam.SqlDbType = System.Data.SqlDbType.Int;
            retParam.ParameterName = "@" + "RET";
            retParam.Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retParam);
            cmd.ExecuteNonQuery();
            int so = (int)retParam.Value;


            luuKiemTraSo = so;
            //  MessageBox.Show("SO LUONG" + so);
        }
        private void KiemTraNgay()
        {
            SqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "SP_LAYNGAYTHI ";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter inParam = new SqlParameter();
            inParam.SqlDbType = System.Data.SqlDbType.VarChar;
            String x = "@" + "MAMONHOC";
            inParam.ParameterName = x;
            inParam.Direction = System.Data.ParameterDirection.Input;
            inParam.Value = luuChonMH;
            cmd.Parameters.Add(inParam);


            SqlParameter inParam1 = new SqlParameter();
            inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
            String x1 = "@" + "MAGIANGVIEN";
            inParam1.ParameterName = x1;
            inParam1.Direction = System.Data.ParameterDirection.Input;
            inParam1.Value = luuChonGV;
            cmd.Parameters.Add(inParam1);

            SqlParameter inParam2 = new SqlParameter();
            inParam2.SqlDbType = System.Data.SqlDbType.VarChar;
            String x2 = "@" + "MALOP";
            inParam2.ParameterName = x2;
            inParam2.Direction = System.Data.ParameterDirection.Input;
            inParam2.Value = luuChonLop;
            cmd.Parameters.Add(inParam2);



            SqlParameter inParam3 = new SqlParameter();
            inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
            String x3 = "@" + "TRINHDO";
            inParam3.ParameterName = x3;
            inParam3.Direction = System.Data.ParameterDirection.Input;
            inParam3.Value = luuTrinhdo;
            cmd.Parameters.Add(inParam3);

            SqlParameter retParam = new SqlParameter();
            retParam.SqlDbType = System.Data.SqlDbType.DateTime;
            retParam.ParameterName = "@" + "NGAYTHI";
            retParam.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(retParam);
            cmd.ExecuteNonQuery();
            DateTime i = (DateTime)retParam.Value;
            
            if (i < ngaydk)
            {
                
                string sql2 = "exec SP_DANGKYTHI '" + luuChonMH + "','" + luuChonGV + "','" + luuChonLop + "','" + luuTrinhdo + "','" + ngaydk + "'," + lan + "," + textBoxSoCauThi.Text + "," + textBoxThoiGianThi.Text;
                SqlCommand com2 = new SqlCommand(sql2, Program.conn);
                com2.ExecuteNonQuery();
                MessageBox.Show("Đăng kí lần 2.!.");
            }
            else
            {
                MessageBox.Show("Ngày đăng kí lần 2 không được nhỏ hơn lần 1.!.");
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
                this.gIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_DS_GIANGVIEN' table. You can move, or remove it, as needed.
                this.gIANGVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN_DANGKY);
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
        private void cbChonLops()
        {
            string sql = "EXEC SP_DS_LOP ";
            SqlCommand com = new SqlCommand(sql, Program.conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbChonLop.DataSource = dt;
            cbChonLop.DisplayMember = dt.Columns["TENLOP"].ToString();
            cbChonLop.ValueMember = dt.Columns["MALOP"].ToString();
            luuChonLop = cbChonLop.SelectedValue.ToString();
        }

        private void cbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lan = Int32.Parse(cbLanThi.SelectedItem.ToString());
        }

        private void cbTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            luuTrinhdo = cbTrinhDo.SelectedItem.ToString();
        }

        private void cbGiangvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            luuChonGV = cbGiangvien.SelectedValue.ToString();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
             ngaydk = Convert.ToDateTime(dateTimePicker.Text);
        }

        private void cbChonMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            luuChonMH = cbChonMH.SelectedValue.ToString();
        }

        private void cbChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            luuChonLop = cbChonLop.SelectedValue.ToString();
        }

        private void textBoxSoCauThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void gIANGVIEN_DANGKYGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}