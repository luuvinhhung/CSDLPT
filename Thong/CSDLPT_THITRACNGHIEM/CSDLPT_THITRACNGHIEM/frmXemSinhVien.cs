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
    public partial class frmXemSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmXemSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmXemSinhVien_Load(object sender, EventArgs e)
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
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.SINHVIEN);
            LayThongTinPhanManh();
            comboBoxCoSo.SelectedIndex = Program.mChinhanh;
            tRANGTHAISpinEdit.Visible = false;
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btThucThi.Visible = false;
            btHuy.Visible = false;
            comboBoxMaLop.Visible = false;
            mASINHVIENTextEdit.Enabled = false;
            
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_DS_GIANGVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.SINHVIEN);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                mASINHVIENTextEdit.Enabled = true;
                btSua.Visible = false;
                btXoa.Visible = false;
                btThem.Visible = false;
                btHuy.Visible = true;
                btThucThi.Visible = true;
                mASINHVIENTextEdit.Text = "";
                hOTextEdit.Text = "";
                tENTextEdit.Text = "";
                dIACHITextEdit.Text = "";
                nGAYSINHDateTimePicker.Text ="";
                this.sINHVIENBindingSource.AddNew();
                mALOPTextEdit.Visible = false;
                comboBoxMaLop.Visible = true;
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
                mASINHVIENTextEdit.Enabled = true;
                string msv = mASINHVIENTextEdit.Text.Trim();
                string hosv = hOTextEdit.Text.Trim();
                string malop = mALOPTextEdit.Text.Trim();
                string tensv = tENTextEdit.Text.Trim();
                string diachi = dIACHITextEdit.Text.Trim();
                //   string ngaysinh = nGAYSINHDateEdit.Text.Trim();


                int n = 0;

                // sINHVIENBindingSource.AddNew();
                tRANGTHAISpinEdit.Text = "1";

                if (msv.Equals(""))
                {
                    MessageBox.Show("Mã sinh viên không được rỗng");
                    mASINHVIENTextEdit.Text = "";
                }
                if (hosv.Equals("") || (int.TryParse(hosv, out n)))
                {
                    MessageBox.Show("Họ sinh viên không được rỗng, không được nhập số.!.");
                    hOTextEdit.Text = "";
                }


                if (tensv.Equals("") || (int.TryParse(this.tENTextEdit.Text, out n)))
                {
                    MessageBox.Show("Tên sinh viên không được rỗng hoặc nhập số.!. Vui lòng nhập lại");
                    tENTextEdit.Text = "";

                }


                if (diachi.Equals(""))
                {
                    MessageBox.Show("Địa chỉ không được rỗng");
                    dIACHITextEdit.Text = "";
                }

                if (nGAYSINHDateTimePicker.Text.Equals(""))
                {
                    MessageBox.Show("Ngày sinh không được rỗng");

                }
                if ((!(msv.Equals("")) && (!(nGAYSINHDateTimePicker.Text.Equals("")) && (!(diachi.Equals("")) && !(hosv.Equals("")) && (!(int.TryParse(hosv, out n)) && (!(int.TryParse(tensv, out n)) && !(tensv.Equals(""))))))))
                {
                    SqlCommand cmd = Program.conn.CreateCommand();
                    cmd.CommandText = "SP_KIEMTRAMASINHVIEN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter inParam = new SqlParameter();
                    inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                    String x = "@" + "MASINHVIEN";
                    inParam.ParameterName = x;
                    inParam.Direction = System.Data.ParameterDirection.Input;
                    inParam.Value = mASINHVIENTextEdit.Text;
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
                        MessageBox.Show("Mã sinh viên đã tồn tại");
                        mASINHVIENTextEdit.Text = "";
                        mASINHVIENTextEdit.Focus();
                        sINHVIENGridControl.Enabled = true;
                        btSua.Visible = false;
                        btXoa.Visible = false;
                        btThem.Visible = false;
                        btHuy.Visible = true;
                        btThucThi.Visible = true;

                    }

        

                else
                {
                    KiemTraDaXoa();
                    this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.SINHVIEN);
                    btSua.Visible = true;
                    btXoa.Visible = true;
                    btThem.Visible = true;
                    btHuy.Visible = false;
                    btThucThi.Visible = false;
                    mASINHVIENTextEdit.Visible = true;
                    mASINHVIENTextEdit.Enabled = false;
                    comboBoxMaLop.Visible = false;
                    mALOPTextEdit.Visible = true;
                }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("co loi");
            }
        }
        public void KiemTraDaXoa()
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRAMASINHVIENDAXOA";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MASINHVIEN";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mASINHVIENTextEdit.Text;
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
                    DialogResult dlr = MessageBox.Show("Sinh viên đã bỏ học.!. Bạn có muốn Update/Phục hồi/Cancel", "Thông báo", MessageBoxButtons.AbortRetryIgnore);
                    if (dlr == DialogResult.Abort)
                    {
                        DateTime ngaydk = Convert.ToDateTime(nGAYSINHDateTimePicker.Text);
                        String sqlS = "EXEC SP_UPDATESINHVIENDAXOA '" + mASINHVIENTextEdit.Text + "','" + comboBoxMaLop.SelectedValue.ToString() + "','"
                            + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + dIACHITextEdit.Text + "','" + ngaydk + "'";
                        SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                        com1.ExecuteNonQuery();
                        MessageBox.Show("Da them");
                        String sql = "EXEC SP_DELETEBANGDIEMSINHVIEN '" + mASINHVIENTextEdit.Text + "'";
                        SqlCommand com2 = new SqlCommand(sql, Program.conn);
                        com2.ExecuteNonQuery();
                        //sINHVIENGridControl.Enabled = true;
                       
                    }

                    if (dlr == DialogResult.Retry)
                    {
                        String sqlS = "EXEC SP_PHUCHOISINHVIEN '" + mASINHVIENTextEdit.Text + "'";
                        SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                        com1.ExecuteNonQuery();
                        MessageBox.Show("Đã phục hồi thành công.!.");
                        String sql = "EXEC SP_UPDATEDIEMSINHVIENDAXOA '" + mASINHVIENTextEdit.Text + "'";
                        SqlCommand com2 = new SqlCommand(sql, Program.conn);
                        com2.ExecuteNonQuery();
                        
                    }
                }

                else
                {
                    DateTime ngaydk = Convert.ToDateTime(nGAYSINHDateTimePicker.Text);
                    String sqlS = "EXEC SP_UPDATESINHVIENMOI '" + mASINHVIENTextEdit.Text + "','" + comboBoxMaLop.SelectedValue.ToString() + "','"
                        + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + dIACHITextEdit.Text + "','" + ngaydk + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Da them thành công");
                    sINHVIENGridControl.Enabled = true;
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi" + ex);
            }


        }
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_KIEMTRA_MALOP";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "MALOP";
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mALOPTextEdit.Text;
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
                    MessageBox.Show("Mã LỚP không tồn tại.!.");
                    this.sINHVIENBindingSource.CancelEdit();
                    this.sINHVIENBindingSource.ResetCurrentItem();

                }
                else
                {
                    mASINHVIENTextEdit.Enabled = false;
                    DateTime ngaydk = Convert.ToDateTime(nGAYSINHDateTimePicker.Text);
                    String sqlS = "EXEC SP_UPDATESINHVIENDAXOA '" + mASINHVIENTextEdit.Text + "','" + mALOPTextEdit.Text + "','"
                        + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + dIACHITextEdit.Text + "','" + ngaydk + "'";
                    SqlCommand com1 = new SqlCommand(sqlS, Program.conn);
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa thành công.!.");

                    MessageBox.Show("Đã sửa thành công.!.");

                }

            }
            catch (Exception ex) { MessageBox.Show("a" + ex); }
            this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.SINHVIEN);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            mASINHVIENTextEdit.Enabled = false;
            //sINHVIENBindingSource.EndEdit();
            btSua.Visible = true;
            btXoa.Visible = true;
            btThem.Visible = true;
            btHuy.Visible = false;
            btThucThi.Visible = false;
            mASINHVIENTextEdit.Visible = true;
            mASINHVIENTextEdit.Enabled = false;
            comboBoxMaLop.Visible = false;
            this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.SINHVIEN);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                mASINHVIENTextEdit.Enabled = false;
                DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa Sinh Viên?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    string ma = Program.username.ToString();

                    if (mASINHVIENTextEdit.Text == ma.ToUpper())
                    {
                        MessageBox.Show(" Bạn không được xóa tài khoản đang đăng nhập.!.");
                    }

                    else
                    {
                        String sql = "EXEC SP_XOASINHVIEN '" + mASINHVIENTextEdit.Text + "'";
                        SqlCommand com1 = new SqlCommand(sql, Program.conn);
                        com1.ExecuteNonQuery();
                        XoaLogin();

                        MessageBox.Show("Xóa tài khoản thành công.!.");
                    }
                }
                else
                {
                    this.Refresh();
                }

                this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet.SINHVIEN);
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

                string role = "SINHVIEN";

                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = "SP_XOALOGIN";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter inParam = new SqlParameter();
                inParam.SqlDbType = System.Data.SqlDbType.VarChar;
                String x = "@" + "LGNAME";// dang nh?p vô toàn b? DB
                inParam.ParameterName = x;
                inParam.Direction = System.Data.ParameterDirection.Input;
                inParam.Value = mASINHVIENTextEdit.Text;
                cmd.Parameters.Add(inParam);



                SqlParameter inParam1 = new SqlParameter();
                inParam1.SqlDbType = System.Data.SqlDbType.VarChar;
                String x1 = "@" + "USERNAME";
                inParam1.ParameterName = x1;
                inParam1.Direction = System.Data.ParameterDirection.Input;
                inParam1.Value = mASINHVIENTextEdit.Text;
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

        private void mASINHVIENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e)
        {

        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}