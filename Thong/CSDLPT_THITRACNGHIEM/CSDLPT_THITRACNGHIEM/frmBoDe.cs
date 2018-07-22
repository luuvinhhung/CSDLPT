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
    public partial class frmBoDe : DevExpress.XtraEditors.XtraForm
    {
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_DS_BODE' table. You can move, or remove it, as needed.
            this.sP_DS_BODETableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSet.MONHOC);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.tRACNGHIEMDataSet.BODE);
            if (Program.role == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
                groupBox1.Visible = false;


            }
            else
            {
                comboBoxCoSo.Enabled = false;
            }
            LayThongTinPhanManh();
            comboBoxCoSo.SelectedIndex = Program.mChinhanh;

            mAMONHOCTextEdit.Visible = true;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
           
            btThucThi.Visible = false;
            btHuy.Visible = false;
            cAUHOISpinEdit.Visible = false;
            comboBox3.SelectedIndex = 0;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

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
                this.bODETableAdapter.Connection.ConnectionString = Program.connStr;
                // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_DS_GIANGVIEN' table. You can move, or remove it, as needed.
                this.bODETableAdapter.Fill(this.tRACNGHIEMDataSet.BODE);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                mAMONHOCTextEdit.Text = "";
                mAGIANGVIENTextEdit.Text = "";
                tRINHDOTextEdit.Text = "";
                nOIDUNGTextEdit.Text = "";
                aTextEdit.Text = "";
                bTextEdit.Text = "";
                cTextEdit.Text = "";
                dTextEdit.Text = "";
                dAPANTextEdit.Text = "";
                cAUHOISpinEdit.Text = "";

                btSua.Visible = false;
                btThem.Visible = false;
                btXoa.Visible = false;
                btThucThi.Visible = true;
                btHuy.Visible = true;

                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
              //  mAMONHOCTextEdit.Visible = false;
                this.sP_DS_BODEBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại roi.!.");
            }

        }

        private void btThucThi_Click(object sender, EventArgs e)
        {
            try
            {
                mAMONHOCTextEdit.Text = comboBox2.SelectedValue.ToString();
                tRINHDOTextEdit.Text = comboBox3.SelectedItem.ToString();
                mAGIANGVIENTextEdit.Text = comboBox1.SelectedValue.ToString();
                dAPANTextEdit.Text = comboBox4.SelectedItem.ToString();
                string mmh = mAMONHOCTextEdit.Text.Trim();
                string mgv = mAGIANGVIENTextEdit.Text.Trim();
                string trinhdo = tRINHDOTextEdit.Text.Trim();
                string noidung = nOIDUNGTextEdit.Text.Trim();
                string dapan = dAPANTextEdit.Text.Trim();
                string a = aTextEdit.Text.Trim();
                string b = bTextEdit.Text.Trim();
                string c = cTextEdit.Text.Trim();
                string d = dTextEdit.Text.Trim();

                if (mmh.Equals(""))
                {
                    MessageBox.Show("Mã môn học không được rỗng");
                    mAMONHOCTextEdit.Text = "";
                }
                if (mgv.Equals(""))
                {
                    MessageBox.Show("Mã giảng viên không được rỗng");
                    mAGIANGVIENTextEdit.Text = "";
                }
                if (trinhdo.Equals(""))
                {
                    MessageBox.Show("tRÌNH ĐỘ không được rỗng");
                    tRINHDOTextEdit.Text = "";
                }
                if (noidung.Equals(""))
                {
                    MessageBox.Show("Nội dung câu hỏi không được rỗng");
                    nOIDUNGTextEdit.Text = "";
                }
                if (a.Equals(""))
                {
                    MessageBox.Show("Đáp án A không được rỗng");
                    aTextEdit.Text = "";
                }
                if (b.Equals(""))
                {
                    MessageBox.Show("Đáp án B không được rỗng");
                    bTextEdit.Text = "";
                }
                if (c.Equals(""))
                {
                    MessageBox.Show("Đáp án C không được rỗng");
                    cTextEdit.Text = "";
                }
                if (d.Equals(""))
                {
                    MessageBox.Show("Đáp án D không được rỗng");
                    dTextEdit.Text = "";
                }
                if (dapan.Equals(""))
                {
                    MessageBox.Show("Đáp án trả lời không được rỗng");
                    dAPANTextEdit.Text = "";
                }
                if (!(noidung.Equals(""))
                    && (!(a.Equals("")) && (!(b.Equals("")) && (!(c.Equals(""))
                    && (!(d.Equals("")) && !(dapan.Equals("")))))))
                {


                    //String sqlS = "INSERT INTO  BODE(MAMONHOC, MAGIANGVIEN, TRINHDO, NOIDUNG, A, B, C, D, DAPAN) VALUES( '" + mmh + "','" + mgv + "','"
                    //        + trinhdo + "','" + noidung + "','" + a + "','" + b + "','" + c + "','" + d + "','" + dapan + "')";
                    String sqlS = "EXEC SP_CAUHOIMOI '" + mmh + "','" + mgv + "','"
                           + trinhdo + "','" + noidung + "','" + a + "','" + b + "','" + c + "','" + d + "','" + dapan + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm câu hỏi thành công.!.");
                    btHuy.Visible = false;
                    btThem.Visible = true;
                    btThucThi.Visible = false;
                    btSua.Visible = true;
                    btXoa.Visible = true;
                }

            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại.!." +ex); }
            btHuy.Visible = false;
            btThem.Visible = true;
            btThucThi.Visible = false;
            btSua.Visible = true;
            btXoa.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            mAMONHOCTextEdit.Visible = true;
            this.sP_DS_BODETableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRAMAMONHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAMONHOC";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mAMONHOCTextEdit.Text;
                cmd.Parameters.Add(inParam);

                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if (i == 0)
                {
                    MessageBox.Show("Mã môn học không tồn tại.!.");


                }
                else
                {

                    KiemTraMaGiangVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa");
            }
        }

        private void KiemTraMaGiangVien()
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRAMAGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAGIANGVIEN";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mAMONHOCTextEdit.Text;
                cmd.Parameters.Add(inParam);

                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if (i == 0)
                {
                    MessageBox.Show("Mã Giảng Viên không tồn tại.!.");


                }
                else
                {

                    String sqlS = "EXEC SP_UPDATECAUHOI '" + mAMONHOCTextEdit.Text + "','" + mAGIANGVIENTextEdit.Text + "','"
                            + tRINHDOTextEdit.Text + "'," + cAUHOISpinEdit.Text + ",'" + nOIDUNGTextEdit.Text + "','" + aTextEdit.Text + "','"
                            + bTextEdit.Text + "','" + cTextEdit.Text + "','" + dTextEdit.Text + "','"
                            + dAPANTextEdit.Text + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa câu hỏi thành công.!.");

                    this.sP_DS_BODETableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            bODEBindingSource.CancelEdit();
            this.sP_DS_BODETableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE);
            btHuy.Visible = false;
            btThem.Visible = true;
            btThucThi.Visible = false;
            btSua.Visible = true;
            btXoa.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    String sqlS = "EXEC SP_XOACAUHOI '" + mAMONHOCTextEdit.Text + "','" + mAGIANGVIENTextEdit.Text + "','"
                            + tRINHDOTextEdit.Text + "'," + cAUHOISpinEdit.Text + "";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa câu hỏi thành công.!.");
                    this.sP_DS_BODETableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE);

                    // this.bODEBindingSource.RemoveCurrent();
                }
                else
                {
                    this.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lỗi.!.");
            }
        }

      
      
        
        
     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mAGIANGVIENTextEdit.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mAMONHOCTextEdit.Text = comboBox2.SelectedValue.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tRINHDOTextEdit.Text = comboBox3.SelectedItem.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dAPANTextEdit.Text = comboBox4.SelectedItem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}