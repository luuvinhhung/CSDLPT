using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYVATTU_PHANTAN
{
    public partial class frmLapPhieu : Form
    {
        public frmLapPhieu()
        {
            InitializeComponent();
        }

        private void pHATSINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.VATTU' table. You can move, or remove it, as needed.
            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.DS.VATTU);
            // TODO: This line of code loads data into the 'DS.CT_PHATSINH' table. You can move, or remove it, as needed.
            this.CT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_PHATSINHTableAdapter.Fill(this.DS.CT_PHATSINH);
            // TODO: This line of code loads data into the 'DS.HOTENNV' table. You can move, or remove it, as needed.
            this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            // TODO: This line of code loads data into the 'DS.CHONKHO' table. You can move, or remove it, as needed.
             this.CHONKHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CHONKHOTableAdapter.Fill(this.DS.CHONKHO);
            // TODO: This line of code loads data into the 'dS.PHATSINH' table. You can move, or remove it, as needed.
            this.PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHATSINHTableAdapter.Fill(this.DS.PHATSINH);

        }

        private void cmbTenkho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMakho.Text = cmbTenkho.SelectedValue.ToString();
            } catch (Exception ) {txtMakho.Text = "";}
        }

        private void cmbHotenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               // int i = cmbHotenNV.SelectedIndex;
               // txtMANV.Text = ((DataRowView)bdsNV[i])["MANV"].ToString();
                txtMANV.Text = cmbHotenNV.SelectedValue.ToString();
            }
            catch (Exception) { txtMANV.Text = ""; }
        }

        private void cmbTENVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAVT.Text = cmbTENVT.SelectedValue.ToString();
            }
            catch (Exception) { txtMAVT.Text = ""; }

        }

        private void txtMANV_EditValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < bdsNV.Count; i++)
                if (((DataRowView)bdsNV[i])["MANV"].ToString() == txtMANV.EditValue.ToString())
                { bdsNV.Position = i; return; }
        }

        private void btnThemPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPS.AddNew();
            NGAYDateEdit.DateTime = DateTime.Now ;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            bdsCTPS.AddNew();
            txtPhieuCTPS.Text = txtPhieuPS.Text;
        }
    }
}
