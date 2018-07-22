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
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSet.KHOA);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
            if (Program.role == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
                groupBox1.Visible = false;


            }
            else
            {
                comboBoxCoSo.Enabled = false;
            }

            btThem.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btThucThi.Visible = false;
            btHuy.Visible = false;
            mAGIANGVIENTextEdit.Enabled = false;
            tRANGTHAISpinEdit.Visible = false;
            comboBoxKhoa.Visible = false;
            LayThongTinPhanManh();
            comboBoxCoSo.SelectedIndex = Program.mChinhanh;

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
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                mAGIANGVIENTextEdit.Enabled = true;
                btSua.Visible = false;
                btXoa.Visible = false;
                btThem.Visible = false;
                btHuy.Visible = true;
                btThucThi.Visible = true;
                mAGIANGVIENTextEdit.Text = "";
                hOTextEdit.Text = "";
                tENTextEdit.Text = "";
                dIACHITextEdit.Text = "";
                this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
                this.gIANGVIENBindingSource.AddNew();
                mAKHOATextEdit.Visible = false;
                comboBoxKhoa.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thêm lỗi.!.");
            }
        }

        private void btThucThi_Click(object sender, EventArgs e)
        {
            try
            {
                mAGIANGVIENTextEdit.Enabled = true;
                int n = 0;
                string magv = mAGIANGVIENTextEdit.Text.Trim();
                string hogv = hOTextEdit.Text.Trim();
                string tengv = tENTextEdit.Text.Trim();
                string diachi = dIACHITextEdit.Text.Trim();


                if (magv.Equals(""))
                {

                    MessageBox.Show("Mã giảng viên không được rỗng");
                    mAGIANGVIENTextEdit.Text = "";
                }
                if (hogv.Equals("") || (int.TryParse(this.hOTextEdit.Text, out n)))
                {

                    MessageBox.Show("Họ giảng viên không được rỗng hoặc nhập số.!.");
                    hOTextEdit.Text = "";
                }


                if (tengv.Equals("") || (int.TryParse(this.tENTextEdit.Text, out n)))
                {
                    //msg = "Tên giảng viên không được rỗng";
                    MessageBox.Show("Tên giảng viên không được rỗng hoặc nhập số.!.");
                    tENTextEdit.Text = "";
                }

                if (diachi.Equals(""))
                {
                    // msg = "Địa chỉ giảng viên không được rỗng";
                    MessageBox.Show("Địa chỉ không được rỗng");
                    dIACHITextEdit.Text = "";
                }



                else if ((!(magv.Equals(""))) && (!(diachi.Equals("")))
                    && (!(hogv.Equals("")))
                   && (!(int.TryParse(hogv, out n)))
                   && (!(int.TryParse(tengv, out n)))
                   && (!(tengv.Equals(""))))
                {
                    SqlCommand cmd = Program.conn.CreateCommand();
                    cmd.CommandText = "SP_KIEMTRAMAGIANGVIEN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter inParam = new SqlParameter();
                    inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x = "@" + "MAGIANGVIEN";
                    inParam.ParameterName = x;
                    inParam.Direction = System.Data.ParameterDirection.Input;
                    inParam.Value = mAGIANGVIENTextEdit.Text;
                    cmd.Parameters.Add(inParam);
                    SqlParameter retParam = new SqlParameter();
                    retParam.SqlDbType = System.Data.SqlDbType.Int;
                    retParam.ParameterName = "@RET";
                    retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(retParam);
                    cmd.ExecuteNonQuery();
                    int i = (int)retParam.Value;
                    if (i == 1)
                    {
                        //  msg = "Mã giảng viên đã tồn tại";
                        MessageBox.Show("Mã giảng viên đã tồn tại");
                        mAGIANGVIENTextEdit.Text = "";
                        mAGIANGVIENTextEdit.Focus();
                        btThem.Visible = false;
                        btSua.Visible = false;
                        btXoa.Visible = false;
                        btThucThi.Visible = true;
                        btHuy.Visible = true;
                        mAKHOATextEdit.Visible = true;
                        comboBoxKhoa.Visible = false;
                        this.gIANGVIENBindingSource.CancelEdit();
                        this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);

                    }
                    else
                    {
                        KiemTraDaXoa();
                        // this.gIANGVIENBindingSource.EndEdit();


                        this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
                        btSua.Visible = true;
                        btXoa.Visible = true;
                        btThem.Visible = true;
                        btHuy.Visible = false;
                        btThucThi.Visible = false;
                        mAKHOATextEdit.Visible = true;
                        mAGIANGVIENTextEdit.Enabled = false;
                        comboBoxKhoa.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRA_MAKHOA";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAKHOA";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mAKHOATextEdit.Text;
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
                    MessageBox.Show("Mã khoa không tồn tại.!.");


                }
                else
                {
                    mAGIANGVIENTextEdit.Enabled = false;
                    String sqlS = "EXEC SP_UPDATEGIANGVIENDAXOA '" + mAGIANGVIENTextEdit.Text + "','"
                           + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + dIACHITextEdit.Text + "','" + mAKHOATextEdit.Text + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();

                    MessageBox.Show("Đã sửa thành công.!.");

                }

            }
            catch (Exception ex) { MessageBox.Show("a" + ex); }
            this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            mAGIANGVIENTextEdit.Enabled = false;
            //  gIANGVIENBindingSource.EndEdit();
            btSua.Visible = true;
            btXoa.Visible = true;
            btThem.Visible = true;
            btHuy.Visible = false;
            btThucThi.Visible = false;
            mAKHOATextEdit.Visible = true;
            mAGIANGVIENTextEdit.Enabled = false;
            comboBoxKhoa.Visible = false;
            this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                mAGIANGVIENTextEdit.Enabled = false;
                DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa Giảng Viên?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    string ma = Program.username.ToString();

                    if (mAGIANGVIENTextEdit.Text == ma.ToUpper())
                    {
                        MessageBox.Show(" Bạn không được xóa tài khoản đang đăng nhập.!.");
                    }

                    else
                    {
                        String sql = "EXEC SP_XOAGIANGVIEN '" + mAGIANGVIENTextEdit.Text + "'";
                        SqlCommand com1 = new SqlCommand(sql, Program.conn);
                        com1.ExecuteNonQuery();
                        XoaLogin();

                        String sql1 = "EXEC SP_XOAGV_DANGKY '" + mAGIANGVIENTextEdit.Text + "'";
                        SqlCommand com = new SqlCommand(sql1, Program.conn);
                        com.ExecuteNonQuery();

                        MessageBox.Show("Xóa tài khoản thành công.!.");
                    }
                }
                else
                {
                    this.Refresh();
                }

                this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
                btHuy.Visible = false;
                btThem.Visible = true;
                btSua.Visible = true;
                btThucThi.Visible = false;
                btXoa.Visible = true;

            }
            catch (Exception ex) { }
        }
        private void XoaLogin()
        {
            using (IDbCommand spCommand = Program.conn.CreateCommand())
            {

                string role = "GIANGVIEN";

                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_XOALOGIN";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "LGNAME";// dang nh?p vô toàn b? DB
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mAGIANGVIENTextEdit.Text;
                cmd.Parameters.Add(inParam);



                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "USERNAME";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = mAGIANGVIENTextEdit.Text;
                cmd.Parameters.Add(inParam1);

                SqlParameter inParam3 = new SqlParameter();
                inParam3.SqlDbType = System.Data.SqlDbType.VarChar;
                String x2 = "@" + "ROLE";
                inParam3.ParameterName = x2;
                inParam3.Direction = System.Data.ParameterDirection.Input;
                inParam3.Value = role;
                cmd.Parameters.Add(inParam3);
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
            }
        }
                 public void KiemTraDaXoa()
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRAMAGIANGVIENDAXOA";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MAGIANGVIEN";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mAGIANGVIENTextEdit.Text;
                cmd.Parameters.Add(inParam);

                SqlParameter retParam = new SqlParameter();
                retParam.SqlDbType = System.Data.SqlDbType.Int;
                retParam.ParameterName = "@" + "RET";
                retParam.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retParam);
                cmd.ExecuteNonQuery();
                int i = (int)retParam.Value;
                if ((int)retParam.Value == 1)
                {
                    DialogResult dlr = MessageBox.Show("Giảng viên đã nghỉ việc.!. Bạn có muốn Update/Phục hồi/Cancel", "Thông báo", MessageBoxButtons.AbortRetryIgnore);
                    if (dlr == DialogResult.Abort)
                    {
                        String sqlS = "EXEC SP_UPDATEGIANGVIENDAXOA '" + mAGIANGVIENTextEdit.Text + "','"
                        + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + dIACHITextEdit.Text + "','" + comboBoxKhoa.SelectedValue.ToString().Trim() + "'";
                        SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                        com1.ExecuteNonQuery();

                        String sql = "EXEC SP_XOADANGKY '" + mAGIANGVIENTextEdit.Text + "'";
                        SqlCommand com = new SqlCommand(sql, Program.conn);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Da them");
                        //sINHVIENGridControl.Enabled = true;

                        btHuy.Visible = false;
                        btThem.Visible = true;
                        btSua.Visible = true;
                        btThucThi.Visible = false;
                        btXoa.Visible = true;
                    }
                    if (dlr == DialogResult.Retry)
                    {
                        String sqlS = "EXEC SP_PHUCHOIGIANGVIEN '" + mAGIANGVIENTextEdit.Text + "'";
                        SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                        com1.ExecuteNonQuery();


                        MessageBox.Show("Đã phục hồi thành công.!.");

                        btHuy.Visible = false;
                        btThem.Visible = true;
                        btSua.Visible = true;
                        btThucThi.Visible = false;
                        btXoa.Visible = true;
                    }
                    else
                    {

                        btHuy.Visible = false;
                        btThem.Visible = true;
                        btSua.Visible = true;
                        btThucThi.Visible = false;
                        btXoa.Visible = true;
                    }
                }

                else
                {
                    String sqlS = "EXEC SP_UPDATEGIANGVIENMOI '" + mAGIANGVIENTextEdit.Text + "','"
                       + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + dIACHITextEdit.Text + "','" + comboBoxKhoa.SelectedValue.ToString().Trim() + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Da them thanh cong");


                    this.gIANGVIENBindingSource.EndEdit();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm");

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
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_DS_GIANGVIEN' table. You can move, or remove it, as needed.
                this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.GIANGVIEN);
            }
        }
    }
}