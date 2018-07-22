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
    public partial class frmBoDe_GV : DevExpress.XtraEditors.XtraForm
    {
        public frmBoDe_GV()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DS_BODE_GVTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE_GV, Program.username.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public string maMH;
        public string trinhDo;
        public string dapAn;
        private void mAGIANGVIENToolStripTextBox_Click(object sender, EventArgs e)
        {
           mAGIANGVIENToolStripTextBox.Text = Program.username.ToString();
        }

        private void frmBoDe_GV_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_DS_MONHOC' table. You can move, or remove it, as needed.
            this.sP_DS_MONHOCTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_MONHOC);
            mAGIANGVIENToolStripTextBox.Text = Program.username.ToString();
            fillToolStrip.Visible = false;
            this.sP_DS_BODE_GVTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE_GV, Program.username.ToString());
            cbChomMH();
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
          

            btThucThi.Visible = false;
            btHuy.Visible = false;
            cAUHOISpinEdit.Visible = false;
            comboBox3.SelectedIndex = 0;
            
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            maMH = comboBox2.SelectedValue.ToString();
            trinhDo = comboBox3.SelectedItem.ToString();
            dapAn = comboBox4.SelectedItem.ToString();
        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cAUHOISpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void cbChomMH()
        {
            string sql = "EXEC SP_DS_MONHOC";
            SqlCommand com = new SqlCommand(sql, Program.conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = dt.Columns["TENMONHOC"].ToString();
            comboBox2.ValueMember = dt.Columns["MAMONHOC"].ToString();
           // mAMONHOCTextEdit.Text = comboBox2.SelectedValue.ToString();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                mAMONHOCTextEdit.Text = "";
               
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

               
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                this.sP_DS_BODE_GVBindingSource.AddNew();
                mAGIANGVIENTextEdit.Text = Program.username.ToString().ToUpper();
                dAPANTextEdit.Text = dapAn;
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
                mAMONHOCTextEdit.Text = maMH;
                tRINHDOTextEdit.Text = trinhDo;
                mAGIANGVIENTextEdit.Text = Program.username.ToString().ToUpper();
                //dAPANTextEdit.Text = dapAn;
                string mmh = mAMONHOCTextEdit.Text.Trim();
                string mgv = mAGIANGVIENTextEdit.Text.Trim().ToUpper();
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
            catch (Exception ex) { MessageBox.Show("Thêm thất bại.!." + ex); }
            btHuy.Visible = false;
            btThem.Visible = true;
            btThucThi.Visible = false;
            btSua.Visible = true;
            btXoa.Visible = true;
           
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            mAMONHOCTextEdit.Visible = true;
            this.sP_DS_BODE_GVTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE_GV, Program.username.ToString());
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

                    String sqlS = "EXEC SP_UPDATECAUHOI '" + mAMONHOCTextEdit.Text + "','" + mAGIANGVIENTextEdit.Text + "','"
                               + tRINHDOTextEdit.Text + "'," + cAUHOISpinEdit.Text + ",'" + nOIDUNGTextEdit.Text + "','" + aTextEdit.Text + "','"
                               + bTextEdit.Text + "','" + cTextEdit.Text + "','" + dTextEdit.Text + "','"
                               + dAPANTextEdit.Text + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa câu hỏi thành công.!.");

                    this.sP_DS_BODE_GVTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE_GV, Program.username.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            sP_DS_BODE_GVBindingSource.CancelEdit();
            this.sP_DS_BODE_GVTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE_GV, Program.username.ToString());
            btHuy.Visible = false;
            btThem.Visible = true;
            btThucThi.Visible = false;
            btSua.Visible = true;
            btXoa.Visible = true;
           
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
                    this.sP_DS_BODE_GVTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_DS_BODE_GV, Program.username.ToString());

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMH = comboBox2.SelectedValue.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            trinhDo = comboBox3.SelectedItem.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           dapAn = comboBox4.SelectedItem.ToString();
            dAPANTextEdit.Text = dapAn;
        }

        private void dTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}