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

namespace PTITTracNghiem.GiaoDien
{
    public partial class frmDangKy : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmDangKy()
        {
            InitializeComponent();
        }
        void xuatLogin(string id)
        {
            txtPass.Enabled = true;
            txtConfirm.Enabled = true;
            txtLogin.ReadOnly = true;
            var query = db.SP_DSLOGIN().SingleOrDefault(x => x.MANV.Trim() == id.Trim());
            if (query == null)
            {
                txtLogin.ReadOnly = false;//chưa có tài khoản
                txtLogin.Focus();
                btnTao.Enabled = true;
                btnXoa.Enabled = false;
            }
            else
            {
                txtLogin.Text = query.Loginname;
                txtPass.Enabled = false;
                txtConfirm.Enabled = false;
                btnTao.Enabled = false;
                btnXoa.Enabled = true;
            }
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            var queryGV = db.GIAOVIENs;
            cmbHoTen.DisplayMember = "HOTEN";
            cmbHoTen.ValueMember = "ID";
            cmbHoTen.DataSource = queryGV;
            this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        string id;
        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cmbHoTen.SelectedValue.ToString();
            txtID.Text = "Mã Số: " + id;
            xuatLogin(id);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (Software.IsLogin(txtLogin.Text) == false)
            {
                MessageBox.Show("Loginname phải là ký tự từ a-z, viết liền, không dấu", "LƯU Ý!");
                txtLogin.Focus();
                return;
            }
            if (Software.IsLogin(txtPass.Text) == false)
            {
                MessageBox.Show("Password phải là ký tự từ a-z, viết liền, không dấu", "LƯU Ý!");
                txtPass.Focus();
                return;
            }
            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Xác nhận pass chưa đúng", "LƯU Ý");
                txtConfirm.Focus();
                return;
            }
            var query = db.SP_DSLOGIN().SingleOrDefault(p => p.Loginname.Trim() == txtLogin.Text);
            if (query != null)
            {
                MessageBox.Show("Login name bị trùng", "CẢNH BÁO!");
                return;
            }
            String sp_login = " SP_TAOTAIKHOAN N'" + txtLogin.Text.Trim() + "',N'" + txtConfirm.Text.Trim() + "',N'" + id + "',N'GIAOVIEN'";
            Software.SPchangeRow(sp_login);
            txtPass.Clear();
            txtConfirm.Clear();
            MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == Software.username)
            {
                MessageBox.Show("Tài khoản hiện đang được sử dụng", "KHÔNG ĐƯỢC XÓA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản: " + txtLogin.Text + ",Tên: " + cmbHoTen.Text + " ? ", "LƯU Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String xoa_login = "exec sp_xoa_login N'" + txtLogin.Text.Trim() + "',N'" + id + "'";
                Software.SPchangeRow(xoa_login);
                cmbHoTen.Text = "";
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
