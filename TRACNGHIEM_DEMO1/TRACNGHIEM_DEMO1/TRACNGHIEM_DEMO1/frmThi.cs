using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace TRACNGHIEM_DEMO1
{
	public partial class frmThi : Form
	{
		System.Timers.Timer t;
		int m = 5, s = 59;
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
		public frmThi()
		{
			InitializeComponent();
		}

		private void frmThi_Load(object sender, EventArgs e)
		{
			//dS.EnforceConstraints = false;
			// TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
			this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
			// TODO: This line of code loads data into the 'dS1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
			//this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS1.GIAOVIEN_DANGKY);
			XuLy_CbxMonHoc();
			TuyBien(true);

			t = new System.Timers.Timer();
			t.Interval = 1; //1000 = 1s
			t.Elapsed += OntimeEvert;

			if (cbxMonHoc.Text.Trim() != "")
			{
				cbxLanThi.SelectedIndex = 0;
				cbxTrinhDo.SelectedIndex = 0;
				cbxMonHoc.SelectedIndex = 0;
				maMonHoc = cbxMonHoc.Text.Trim();
			}

			cbxNgay.Checked = true;
			groupBox2.Visible = false;
			grbThongTin.Visible = false;
			groupBox1.Visible = true;
			grbTungCau.Visible = false;
			dataGridView1.Visible = true;
			grbNopBai.Visible = false;
			txtTen.Text = Program.mHoten;
			Program.KetNoi();

			if (cbxMonHoc.Text.Trim() == "")
			{

				this.Dispose();
				btnBatDau.Enabled = false;
			}

		}
		private void XuLy_CbxMonHoc()
		{
			try
			{
				if (Program.mGroup == "SINHVIEN")
				{
					string sql = " EXEC SP_SINHVIEN_LAYDANGKY '" + Program.username + "'";
					SqlCommand com = new SqlCommand(sql, Program.conn);
					SqlDataAdapter da = new SqlDataAdapter(com);
					DataTable dt = new DataTable();
					da.Fill(dt);
					cbxMonHoc.DataSource = dt;
					cbxMonHoc.DisplayMember = dt.Columns["TENMH"].ToString();
					cbxMonHoc.ValueMember = dt.Columns["MAMH"].ToString();
					if (cbxMonHoc.SelectedValue == null)
					{
						MessageBox.Show("Lớp của sinh viên chưa có môn nào được đăng kí");


					}
				}
				else if (Program.mGroup == "GIAOVIEN")
				{
					/*string sql = " EXEC SP_GIAOVIEN_DANGKY '" + Program.username + "'";
					SqlCommand com = new SqlCommand(sql, Program.conn);
					SqlDataAdapter da = new SqlDataAdapter(com);
					DataTable dt = new DataTable();
					da.Fill(dt);
					cbxMonHoc.DataSource = dt;
					cbxMonHoc.DisplayMember = dt.Columns["TENMH"].ToString();
					cbxMonHoc.ValueMember = dt.Columns["MAMH"].ToString();
					if (cbxMonHoc.SelectedValue == null)
					{
						MessageBox.Show("Lớp của GIÁO VIÊN chưa có môn nào được đăng kí");
					}*/
					cbxMonHoc.Items.Add("AVCB");
					cbxMonHoc.Items.Add("CTDL");
					cbxMonHoc.SelectedIndex = 0;
					cbxMonHoc.SelectedIndex = 1;

				}



			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi Load Môn Học" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void load_TenMH()
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
				txtMonHoc.Text = " " + tenMonHoc;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi load môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void TuyBien(Boolean co)
		{
			txtTen.ReadOnly = txtTrinhDo.ReadOnly = txtSoCau.ReadOnly = txtMonHoc.ReadOnly = txtLanThi.ReadOnly = co;
		}

		private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bdsGV_DK.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dS1);

		}

		private void cbxLanThi_SelectedIndexChanged(object sender, EventArgs e)
		{
			lanThi = (int)Int32.Parse(cbxLanThi.SelectedItem.ToString());
		}

		private void cbxTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
		{
			trinhDo = cbxTrinhDo.SelectedItem.ToString();
		}

		private void cbxNgay_ValueChanged(object sender, EventArgs e)
		{
			ngayThi = Convert.ToDateTime(cbxNgay.Text);
		}
		private void load_KTLanThi()
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
				inParam1.SqlDbType = System.Data.SqlDbType.Int;
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
				cmd.CommandText = "SP_KIEMTRA_TRINHDO";
				cmd.CommandType = CommandType.StoredProcedure;

				SqlParameter inParam = new SqlParameter();
				inParam.SqlDbType = System.Data.SqlDbType.VarChar;
				String x = "@" + "MAMONHOC";
				inParam.ParameterName = x;
				inParam.Direction = System.Data.ParameterDirection.Input;
				inParam.Value = maMonHoc;
				cmd.Parameters.Add(inParam);

				SqlParameter inParam1 = new SqlParameter();
				inParam1.SqlDbType = System.Data.SqlDbType.Int;
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
			catch (Exception ex)
			{

				MessageBox.Show("Lỗi  load Trình độ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void KiemTraNgayThi()
		{

			SqlCommand cmd = Program.conn.CreateCommand();
			cmd.CommandText = "SP_KIEMTRA_NGAYTHI";
			cmd.CommandType = CommandType.StoredProcedure;

			SqlParameter inParam = new SqlParameter();
			inParam.SqlDbType = System.Data.SqlDbType.VarChar;
			String x = "@" + "MAMONHOC";
			inParam.ParameterName = x;
			inParam.Direction = System.Data.ParameterDirection.Input;
			inParam.Value = maMonHoc;
			cmd.Parameters.Add(inParam);

			SqlParameter inParam2 = new SqlParameter();
			inParam2.SqlDbType = System.Data.SqlDbType.Int;
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
			inParam3.SqlDbType = System.Data.SqlDbType.DateTime;
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

			try
			{

				cmd.ExecuteNonQuery();
				int i = (int)retParam.Value;
				if (i == 1)
				{
					if (Program.mGroup == "SINHVIEN")
					{
						KiemTraSinhVien();
					}
					else
					{
						btnNopBai.Visible = true;
						grbThongTin.Visible = true;
						groupBox1.Visible = false;
						groupBox2.Visible = true;
						grbTungCau.Visible = true;
						grbNopBai.Visible = true;


						dataGridView1.Visible = true;
						LoadDe();
						//chayThoiGian.Start();
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


			SqlCommand cmd = Program.conn.CreateCommand();
			cmd.CommandText = "SP_DEMSOLANTHI_SINHVIEN";
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
			try
			{
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
						MessageBox.Show("Bắt Đầu Thi ");
						btnNopBai.Visible = true;
						grbThongTin.Visible = true;
						groupBox1.Visible = false;
						grbNopBai.Visible = true;

						dataGridView1.Visible = true;
						grbTungCau.Visible = true;
						LoadDe();
						//chayThoiGian.Start();
					}


				}
				else if ((int)retParam.Value == 2)
				{
					if (lanThi == 1)
					{
						MessageBox.Show("Bạn đã thi lần 2 rồi.!. Không được thi lại lần 1 nữa");

						this.Update();


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
						MessageBox.Show("Bắt Đầu Thi");
						btnNopBai.Visible = true;
						grbThongTin.Visible = true;
						groupBox1.Visible = false;
						grbNopBai.Visible = true;

						dataGridView1.Visible = true;
						grbTungCau.Visible = true;
						LoadDe();
						//chayThoiGian.Start();
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

		private void btnBatDau_Click(object sender, EventArgs e)
		{
			t.Start();
			Program.KetNoi();
			load_KTLanThi();
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
			inParam1.SqlDbType = System.Data.SqlDbType.Int;
			String x1 = "@" + "LANTHI";
			inParam1.ParameterName = x1;
			inParam1.Direction = System.Data.ParameterDirection.Input;
			inParam1.Value = lanThi;
			cmd.Parameters.Add(inParam1);

			SqlParameter retParam = new SqlParameter();
			retParam.SqlDbType = System.Data.SqlDbType.Int;
			retParam.ParameterName = "@RET";
			retParam.Direction = System.Data.ParameterDirection.ReturnValue;
			//retParam.Direction = System.Data.ParameterDirection.Input;
			cmd.Parameters.Add(retParam);


			try
			{
				cmd.ExecuteNonQuery();
				int i = (int)retParam.Value;
				time = i * 60;

				load_TenMH();
				txtSoCau.Text = soLuongCauHoi.ToString();
				txtLanThi.Text = cbxLanThi.SelectedItem.ToString();
				txtTrinhDo.Text = cbxTrinhDo.SelectedItem.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi" + ex);
				return;
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
				//MessageBox.Show("" + dt1, "Thông Báo", MessageBoxButtons.OK);
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
					dataGridView1.Rows.Add(temp);

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
					btnCauTruoc.Enabled = false;
				}
				txtCauHoi.Text = deThi[vt].NoiDung;
				txtCauA.Text = deThi[vt].CauA;
				txtCauB.Text = deThi[vt].CauB;
				txtCauC.Text = deThi[vt].CauC;
				txtCauD.Text = deThi[vt].CauD;
				labelCau.Text = "Câu " + (vt + 1).ToString() + ":";

				if (deThi[vt].CauTL == '*')
				{
					btnA.Checked = btnB.Checked = btnC.Checked = btnD.Checked = false;

				}



			}
			catch (Exception ex) { }
		}

		private void btnA_CheckedChanged(object sender, EventArgs e)
		{
			if (btnA.Checked == true)
			{
				deThi[giaTri].CauTL = 'A';
				dataGridView1.Rows[giaTri].Cells[1].Value = "A";
			}
		}

		private void btnB_CheckedChanged(object sender, EventArgs e)
		{
			if (btnB.Checked == true)
			{
				deThi[giaTri].CauTL = 'B';
				dataGridView1.Rows[giaTri].Cells[1].Value = "B";
			}
		}

		private void btnC_CheckedChanged(object sender, EventArgs e)
		{
			if (btnC.Checked == true)
			{
				deThi[giaTri].CauTL = 'C';
				dataGridView1.Rows[giaTri].Cells[1].Value = "C";
			}
		}

		private void btnD_CheckedChanged(object sender, EventArgs e)
		{
			if (btnD.Checked == true)
			{
				deThi[giaTri].CauTL = 'D';
				dataGridView1.Rows[giaTri].Cells[1].Value = "D";
			}

		}

		private void OntimeEvert(object sender, ElapsedEventArgs e)
		{
			Invoke(new Action(() => {
				s -= 1;
				if (s == 0)
				{
					s = 59;
					m -= 1;

				}
				if (m == 0 && s == 1)
				{
					t.Stop();
					chamDiem();
					//MessageBox.Show("Nộp Bài !Hết Giờ  " );
					

				}
				if(Program.mGroup == "SINHVIEN")
				{
					NhapDiem();
					// LuuCauTraLoi();
				}


				lbThoiGian1.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));



			}));
		}
	/*	private void chayThoiGian_Tick(object sender, EventArgs e) { 

				
			/* (time > 0)
				{
					time--;
					int minute = time / 60;
					int seconds = time % 60;
					String min1 = "", sec1 = "";
					if (seconds < 10)
						sec1 = "0";
					if (minute < 10)
						min1 = "0";
					lbThoiGian1.Text = min1 + minute.ToString() + " : " + sec1 + seconds.ToString();
				}
				else
				{

				//	chayThoiGian.Stop();
					chamDiem();

				if (Program.mGroup == "SINHVIEN")
				{
					//NhapDiem();
					//LuuCauTraLoi();
				}
				//reLoad();



			}
		}*/

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
				int id = e.RowIndex;// get the Row Index
				if (id < 0 || id >= deThi.Count)
					return;
				loadCauHoi(id);
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			for (int j = 0; j < index - 1; j++)
			{
				dataGridView1.Rows[j].Selected = true;
			}

			loadCauHoi(index - 1);
			giaTri = index - 1;
			if (index - 1 > 1)
			{
				btnCauTruoc.Enabled = true;
			}
		}

		private void btnCauTruoc_Click(object sender, EventArgs e)
		{
			btnKeTiep.Enabled = true;
			if (giaTri > 0)
			{
				giaTri--;
				loadCauHoi(giaTri);
				btnA.Checked = btnB.Checked = btnC.Checked = btnD.Checked = false;


			}
		}

		private void btnKeTiep_Click(object sender, EventArgs e)
		{
			btnA.Checked = btnB.Checked = btnC.Checked = btnD.Checked = false;
			dataGridView1.Rows[giaTri].Selected = true;

			if (giaTri > -1)
			{
				btnCauTruoc.Enabled = true;
			}
			if (giaTri < deThi.Count - 1)
			{
				btnA.Enabled = true;
				btnB.Enabled = true;
				btnC.Enabled = true;
				btnD.Enabled = true;
				giaTri++;
				loadCauHoi(giaTri);
			}
			if (giaTri > deThi.Count - 2)
			{
				btnKeTiep.Enabled = false;

			}
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

		private void btnNopBai_Click(object sender, EventArgs e)
		{
			DialogResult dlr = MessageBox.Show("Bạn có muốn nộp bài? ", "Thông báo", MessageBoxButtons.YesNo);
			if (dlr == DialogResult.Yes)
			{

				t.Stop();
				chamDiem();

				if (Program.mGroup == "SINHVIEN")
				{
					NhapDiem();
					//LuuCauTraLoi();
				}
				//reLoad();

			}
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
				MessageBox.Show("Lỗi khi nhập điểm " + Ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}
