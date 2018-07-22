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
    public partial class frmSinhVienThi : DevExpress.XtraEditors.XtraForm
    {
        public frmSinhVienThi()
        {
            InitializeComponent();
        }

        public string maMonHoc;
        public int lanThi;
        public string trinhDo;
        public DateTime ngayThi = DateTime.Today;
        public int giaTri = 0;
        public char ds;
        public int lan;
        public double diem = 0;
        public int time;
        public string tenMonHoc;
        public int soLuongCauHoi;
        public int a;
        private List<CauHoi> deThi = new List<CauHoi>();
        private void frmSinhVienThi_Load(object sender, EventArgs e)
        {
           

            DanhSachMonDangKyThi();
            LayMonHoc();
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIANGVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIANGVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN_DANGKY);
         
           


            if (comboBoxMonHoc.SelectedValue != null)
            {
                comboBoxLanThi.SelectedIndex = 0;
                comboBoxTrinhDo.SelectedIndex = 0;
                comboBoxMonHoc.SelectedIndex = 0;
                maMonHoc = comboBoxMonHoc.SelectedValue.ToString();
            }
            
            dateTimePicker1.Checked = true;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox6.Visible = false;
            groupBox4.Visible = false;
            btNopBai.Visible = false;
            dataGridViewLoadCauTraLoi.Visible = false;
            lbHoTen.Text = "HỌ VÀ TÊN: " + Program.hoTen.ToString();
           
            if (comboBoxMonHoc.SelectedValue == null)
            {
                
                this.Dispose();
                buttonBatDau.Enabled = false;
            }

            
        }
        private void LayMonHoc()
        {
            try
            {
                if(Program.role == "SINHVIEN")
                {
                    string sql = " EXEC SP_LAYTENMONHOCDK '" + Program.username + "'";
                    SqlCommand com = new SqlCommand(sql, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxMonHoc.DataSource = dt;
                    comboBoxMonHoc.DisplayMember = dt.Columns["TENMONHOC"].ToString();
                    comboBoxMonHoc.ValueMember = dt.Columns["MAMONHOC"].ToString();
                    if(comboBoxMonHoc.SelectedValue == null)
                    {
                        MessageBox.Show("Lớp của sinh viên chưa có môn nào được đăng kí");
                        
                        
                    }
                }

              else if(Program.role == "GIANGVIEN")
                {
                    string sql = " EXEC SP_LAYTENMONHOCGV ";
                    SqlCommand com = new SqlCommand(sql, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxMonHoc.DataSource = dt;
                    comboBoxMonHoc.DisplayMember = dt.Columns["TENMONHOC"].ToString();
                    comboBoxMonHoc.ValueMember = dt.Columns["MAMONHOC"].ToString();
                    if (comboBoxMonHoc.SelectedValue == null)
                    {
                        MessageBox.Show("Chưa có lớp nào được đăng kí");
                        
                    }
                }
              //  maMonHoc = comboBoxMonHoc.SelectedValue.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi " + ex);
            }

        }

        private void DanhSachMonDangKyThi()
        {
            try
            {
                if (Program.role == "SINHVIEN")
                {
                    string sql = " EXEC SP_LAYDANHSACHDANGKY_THEOLOP '" + Program.username + "'";
                    SqlCommand com = new SqlCommand(sql, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                  
                }
                else if (Program.role == "GIANGVIEN")
                {
                    string sql = " EXEC SP_LAYDANHSACHDANGKY '" + Program.username.ToString() + "'";
                    SqlCommand com = new SqlCommand(sql, Program.conn);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridControl1.DataSource = dt;
                    a = dt.Rows.Count;
                    if (a == 0)
                    {
                        MessageBox.Show("KHOA KHÔNG CÓ MÔN NÀO ĐƯỢC ĐĂNG KÍ.!.");
                        buttonBatDau.Enabled = false;

                    }
                }

               

             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
            }

        }
        public void LayTenMonHoc()
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_LAYTENMONHOC";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);

                IDbDataParameter inParam1 = cmd.CreateParameter();
                inParam1.ParameterName = "@TENMONHOC";
                inParam1.Direction = System.Data.ParameterDirection.Output;
                inParam1.DbType = System.Data.DbType.String;
                inParam1.Size = 50;
                cmd.Parameters.Add(inParam1);
                cmd.ExecuteNonQuery();
                tenMonHoc = inParam1.Value.ToString();
                lbMonHoc.Text = "MÔN THI: " + tenMonHoc;
            }
            catch (Exception ex) { }
        }
        private void comboBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMonHoc = comboBoxMonHoc.SelectedValue.ToString();
           
        }

        private void comboBoxLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lanThi = (int)Int32.Parse(comboBoxLanThi.SelectedItem.ToString());
        }

        private void comboBoxTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            trinhDo = comboBoxTrinhDo.SelectedItem.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ngayThi = Convert.ToDateTime(dateTimePicker1.Text);
        }

        private void buttonBatDau_Click(object sender, EventArgs e)
        {
            try
            {
               
                KiemTrLanThi();
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_LAYTHOIGIANTHI";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);

                SqlParameter inParam3 = new SqlParameter();
                inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                String x3 = "@" + "TRINHDO";
                inParam3.ParameterName = x3;
                inParam3.Direction = System.Data.ParameterDirection.Input;
                inParam3.Value = trinhDo;
                cmd.Parameters.Add(inParam3);

                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "LANTHI";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = lanThi;
                cmd.Parameters.Add(inParam1);

                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                time = i * 60;

                LayTenMonHoc();
                lbSoLuongCauHoi.Text = "SỐ LƯỢNG CÂU HỎI: " + soLuongCauHoi.ToString();
                lbLanThi.Text = "LẦN THI: " + comboBoxLanThi.SelectedItem.ToString();
                lbTrinhDo.Text = "TRÌNH ĐỘ: " + comboBoxTrinhDo.SelectedItem.ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " +ex);
            }
           
        }
        private void KiemTrLanThi()
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRA_LANTHI_DKY";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);

                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "LANTHI";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = lanThi;
                cmd.Parameters.Add(inParam1);


                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if (i == 1)
                {
                    KiemTraTrinhDo();
                }
                else if (i == 0)
                {
                    MessageBox.Show("Môn không được đăng kí lần này.!.");
                    this.Update();

                }
            }
            catch (Exception ex) { }
        }

        private void KiemTraTrinhDo()
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRA_TRINHDO_DKY";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);

                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "LANTHI";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = lanThi;
                cmd.Parameters.Add(inParam1);

                SqlParameter inParam3 = new SqlParameter();
                inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                String x3 = "@" + "TRINHDO";
                inParam3.ParameterName = x3;
                inParam3.Direction = System.Data.ParameterDirection.Input;
                inParam3.Value = trinhDo;
                cmd.Parameters.Add(inParam3);

                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if (i == 1)
                {
                    KiemTraNgayThi();

                }
                else if (i == 0)
                {
                    MessageBox.Show("Môn học không được đăng kí cho trình độ này.!.");
                    this.Update();

                }
            }
            catch (Exception ex) { }
        }

        private void KiemTraNgayThi()
        {
            try
            {

                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRA_NGAYTHI_DKY";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);

                SqlParameter inParam2 = new SqlParameter();
                inParam2.SqlDbType = System.Data.SqlDbType.VarChar;
                String x2 = "@" + "LANTHI";
                inParam2.ParameterName = x2;
                inParam2.Direction = System.Data.ParameterDirection.Input;
                inParam2.Value = lanThi;
                cmd.Parameters.Add(inParam2);

                SqlParameter inParam4 = new SqlParameter();
                inParam4.SqlDbType = System.Data.SqlDbType.VarChar;
                String x4 = "@" + "TRINHDO";
                inParam4.ParameterName = x4;
                inParam4.Direction = System.Data.ParameterDirection.Input;
                inParam4.Value = trinhDo;
                cmd.Parameters.Add(inParam4);

                SqlParameter inParam3 = new SqlParameter();
                inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                String x3 = "@" + "NGAYTHI";
                inParam3.ParameterName = x3;
                inParam3.Direction = System.Data.ParameterDirection.Input;
                inParam3.Value = ngayThi;
                cmd.Parameters.Add(inParam3);

                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if (i == 1)
                {
                    if (Program.role == "SINHVIEN")
                    {
                        KiemTraSinhVien();
                    }
                    else
                    {
                        btNopBai.Visible = true;
                        groupBox3.Visible = true;
                        groupBox1.Visible = false;
                        groupBox2.Visible = true;
                        groupBox4.Visible = true;
                        groupBox6.Visible = true;
                        dataGridViewLoadCauTraLoi.Visible = true;
                        LoadDe();
                        groupBox5.Visible = false;
                        chayThoiGian.Start();
                    }

                }
                else if (i == 0)
                {
                    MessageBox.Show("Môn học không được đăng kí ngày bạn chọn.!.");
                    this.Update();



                }
            }
            catch (Exception ex) { }
        }


        private void KiemTraSinhVien()
        {
            try
            {

                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRA_DKTHI_BDIEM_DKY";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);


                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "MASINHVIEN";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = Program.username;
                cmd.Parameters.Add(inParam1);


                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@" + "RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if ((int)retParam.Value == 1)
                {
                    if (lanThi == 1)
                    {
                        MessageBox.Show("Bạn đã thi lần 1 rồi.!. Không được thi lại");
                        this.Dispose();
                        this.Hide();
                    }
                    if (lanThi == 2)
                    {
                        MessageBox.Show("thi nào");
                        btNopBai.Visible = true;
                        groupBox3.Visible = true;
                        groupBox1.Visible = false;
                        groupBox2.Visible = true;
                        groupBox4.Visible = true;
                        groupBox6.Visible = true;
                        dataGridViewLoadCauTraLoi.Visible = true;
                        LoadDe();
                        groupBox5.Visible = false;
                        chayThoiGian.Start();
                    }


                }
                else if ((int)retParam.Value == 2)
                {
                    if (lanThi == 1)
                    {
                        MessageBox.Show("Bạn đã thi lần 2 rồi.!. Không được thi lại lần 1 nữa");

                        // this.Hide();
                        this.Update();

                        //Form1 f = new Form1();
                        //f.Show();
                        //this.Close();
                    }
                    if (lanThi == 2)
                    {
                        MessageBox.Show("Bạn đã thi lần 2 rồi.!. Không được thi lại lần 2 nữa");
                        this.Update();

                    }
                }

                else if ((int)retParam.Value == 0)
                {
                    if (lanThi == 1)
                    {
                        MessageBox.Show("Bạn được thi");
                        btNopBai.Visible = true;
                        groupBox3.Visible = true;
                        groupBox1.Visible = false;
                        groupBox2.Visible = true;
                        groupBox4.Visible = true;
                        groupBox6.Visible = true;
                        dataGridViewLoadCauTraLoi.Visible = true;
                        LoadDe();
                        groupBox5.Visible = false;
                        chayThoiGian.Start();
                    }
                    if (lanThi == 2)
                    {
                        MessageBox.Show("Bạn chưa thi lần 1.!. Không được thi lần 2");
                        this.Update();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.ToString());
            }
        }

        private void LoadDe()
        {
            try
            {
                String sqlS = "EXEC SP_LAYDE'" + trinhDo + "','" + maMonHoc + "'," + lanThi + "";
                SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                int i = 1;


                foreach (DataRow dtr in dt1.Rows)
                {
                    ds = dtr[8].ToString()[0];
                    CauHoi ch = new CauHoi(
                        (int)dtr[0],
                        (String)dtr[3].ToString(),
                        (String)dtr[4].ToString(),
                        (String)dtr[5].ToString(),
                        (String)dtr[6].ToString(),
                        (String)dtr[7].ToString(),
                        ds
                    );
                    deThi.Add(ch);
                    soLuongCauHoi = deThi.Count;
                    String[] temp = new String[] { (i++).ToString(), "" };
                    dataGridViewLoadCauTraLoi.Rows.Add(temp);

                }

                loadCauHoi(giaTri);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi. \nKhông thể load đề thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadCauHoi(int vt)
        {
            groupBox1.Enabled = true;
            try
            {
                if (vt < 1)
                {
                    btCauTruoc.Enabled = false;
                }
                txtCauHoi.Text = deThi[vt].NoiDung;
                txtCauA.Text = deThi[vt].CauA;
                txtCauB.Text = deThi[vt].CauB;
                txtCauC.Text = deThi[vt].CauC;
                txtCauD.Text = deThi[vt].CauD;
                labelCau.Text = "Câu " + (vt + 1).ToString() + ":";

                if (deThi[vt].CauTL == '*')
                {
                    cbA.Checked = cbB.Checked = cbC.Checked = cbD.Checked = false;

                }



            }
            catch (Exception ex) { }
        }
        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbA.Checked == true)
            {
                deThi[giaTri].CauTL = 'A';
                dataGridViewLoadCauTraLoi.Rows[giaTri].Cells[1].Value = "A";
            }
        }

        private void cbB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbB.Checked == true)
            {
                deThi[giaTri].CauTL = 'B';
                dataGridViewLoadCauTraLoi.Rows[giaTri].Cells[1].Value = "B";
            }
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbC.Checked == true)
            {
                deThi[giaTri].CauTL = 'C';
                dataGridViewLoadCauTraLoi.Rows[giaTri].Cells[1].Value = "C";
            }
        }

        private void cbD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbD.Checked == true)
            {
                deThi[giaTri].CauTL = 'D';
                dataGridViewLoadCauTraLoi.Rows[giaTri].Cells[1].Value = "D";
            }
        }

        private void chayThoiGian_Tick(object sender, EventArgs e)
        {
            try
            {


                if (time > 0)
                {
                    time--;
                    int minute = time / 60;
                    int seconds = time % 60;
                    String min1 = "", sec1 = "";
                    if (seconds < 10)
                        sec1 = "0";
                    if (minute < 10)
                        min1 = "0";
                    label5.Text = min1 + minute.ToString() + " : " + sec1 + seconds.ToString();
                }
                else
                {

                    chayThoiGian.Stop();
                    chamDiem();
                   
                    if (Program.role == "SINHVIEN")
                    {
                        NhapDiem();
                        LuuCauTraLoi();
                    }
                    reLoad(); 

                }
            }
            catch (Exception ex) { }
        }

        private void btNopBai_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn nộp bài? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                chayThoiGian.Stop();
                chamDiem();
               
                if (Program.role == "SINHVIEN")
                {
                    NhapDiem();
                    LuuCauTraLoi();
                }
                reLoad();

            }
        }
        public void reLoad()
        {
            groupBox5.Visible = true;
            dateTimePicker1.Checked = true;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox6.Visible = false;
            groupBox4.Visible = false;
            btNopBai.Visible = false;
            dataGridViewLoadCauTraLoi.Visible = false;
            lbHoTen.Text = "HỌ VÀ TÊN: " + Program.hoTen.ToString();
        }
        private void NhapDiem()
        {

            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_NHAPDIEM";
                cmd.CommandType = CommandType.StoredProcedure;



                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "MASINHVIEN";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = Program.username.ToString().ToUpper();
                cmd.Parameters.Add(inParam1);

                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = maMonHoc;
                cmd.Parameters.Add(inParam);

                SqlParameter inParam2 = new SqlParameter();
                inParam2.SqlDbType = System.Data.SqlDbType.VarChar;
                String x2 = "@" + "LAN";
                inParam2.ParameterName = x2;
                inParam2.Direction = System.Data.ParameterDirection.Input;
                inParam2.Value = lanThi;
                cmd.Parameters.Add(inParam2);

                SqlParameter inParam3 = new SqlParameter();
                inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                String x3 = "@" + "NGAYTHI";
                inParam3.ParameterName = x3;
                inParam3.Direction = System.Data.ParameterDirection.Input;
                inParam3.Value = ngayThi;
                cmd.Parameters.Add(inParam3);

                SqlParameter inParam4 = new SqlParameter();
                inParam4.SqlDbType = System.Data.SqlDbType.VarChar;
                String x4 = "@" + "DIEM";
                inParam4.ParameterName = x4;
                inParam4.Direction = System.Data.ParameterDirection.Input;
                inParam4.Value = diem;
                cmd.Parameters.Add(inParam4);
                string i = "1";
                SqlParameter inParam5 = new SqlParameter();
                inParam5.SqlDbType = System.Data.SqlDbType.VarChar;
                String x5 = "@" + "BAITHI";
                inParam5.ParameterName = x5;
                inParam5.Direction = System.Data.ParameterDirection.Input;
                inParam5.Value = i;
                cmd.Parameters.Add(inParam5);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập điểm thành công.!.");
            }
            catch (Exception Ex)
            {

            }
        }
        private void LuuCauTraLoi()
        {
            try
            {

                for (int i = 0; i < deThi.Count; i++)
                {
                    string msv = Program.username.ToString().ToUpper();
                    String sqlS = "EXEC SP_THEMCAUTRALOI '" + msv + "','" + maMonHoc + "',"
                   + lanThi + ",'" + trinhDo + "'," + (i + 1) + "," + deThi[i].MaCH + ",'" + deThi[i].CauTL + "','" + deThi[i].DapAn + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();

                }
                MessageBox.Show("Đã lưu đáp án thành công.!.");
            }
            catch (Exception ex) { }
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            cbA.Checked = cbB.Checked = cbC.Checked = cbD.Checked = false;
            dataGridViewLoadCauTraLoi.Rows[giaTri].Selected = true;

            if (giaTri > -1)
            {
                btCauTruoc.Enabled = true;
            }
            if (giaTri < deThi.Count - 1)
            {
                cbA.Enabled = true;
                cbB.Enabled = true;
                cbC.Enabled = true;
                cbD.Enabled = true;
                giaTri++;
                loadCauHoi(giaTri);
            }
            if (giaTri > deThi.Count - 2)
            {
                btNext.Enabled = false;

            }
        }

        private void btCauTruoc_Click(object sender, EventArgs e)
        {
            btNext.Enabled = true;
            if (giaTri > 0)
            {
                giaTri--;
                loadCauHoi(giaTri);
                cbA.Checked = cbB.Checked = cbC.Checked = cbD.Checked = false;


            }
        }

        private void dataGridViewLoadCauTraLoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;// get the Row Index
            if (id < 0 || id >= deThi.Count)
                return;
         

           
            loadCauHoi(id);
        }
        void chamDiem()
        {

            try
            {

                double tinhdiem = 0;
                int caudung = 0;
                int size = deThi.Count;
                for (int i = 0; i < size; i++)
                {
                    if (deThi[i].CauTL == deThi[i].DapAn)
                        caudung++;
                }
                tinhdiem = (double)caudung * 10 / (double)size;
                diem = Math.Round(tinhdiem, 1);


                MessageBox.Show("Bạn được " + diem + " điểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { }


        }

        private void gIANGVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLoadCauTraLoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(dataGridViewLoadCauTraLoi.Rows[e.RowIndex].Cells[0].Value.ToString());
            for(int j = 0; j< index-1; j++)
            {
                dataGridViewLoadCauTraLoi.Rows[j].Selected = true;
            }
            
            loadCauHoi(index-1);
            giaTri = index - 1;
            if (index -1 >1 )
            {
                btCauTruoc.Enabled = true;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}