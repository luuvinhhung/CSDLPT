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
    public partial class frmDoiMatKhau : Form
    {
        TRACNGHIEMEntities db = new TRACNGHIEMEntities();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuuMatKhau_Click(object sender, EventArgs e)
        {

            if (txtHienTai.Text.Trim() != Software.password)
            {
                MessageBox.Show("Nhập sai password hiện tại.", "LƯU Ý!");
                txtHienTai.Focus();
                return;
            }
            if (Software.IsLogin(txtMoi.Text) == false)
            {
                MessageBox.Show("Password phải là ký tự từ a-z, viết liền, không dấu.", "LƯU Ý");
                txtMoi.Focus();
                return;
            }

            String sp_sua = " SP_DOIMATKHAU N'" + Software.mlogin + "',N'" + txtHienTai.Text.Trim() + "',N'" + txtMoi.Text.Trim() + "'";

            Software.SPchangeRow(sp_sua);
            MessageBox.Show("Sửa Thành Công","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
