using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QL_DiemSV_V2
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        BLL_LOP blllop = new BLL_LOP();
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Ds_SV_Lop.SV_SelectBymaLop' table. You can move, or remove it, as needed.
            
            cboLop.DataSource = blllop.LOP_SelectAll();
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";
            
            
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Ds_SV_Lop.SV_SelectBymaLop' table. You can move, or remove it, as needed.
            //this.SV_SelectBymaLopTableAdapter.Fill(this.Ds_SV_Lop., cboLop.SelectedValue.ToString());

            //this.reportViewer1.RefreshReport();
            this.SV_SelectBymaLopTableAdapter.Fill(this.Ds_SV_Lop.SV_SelectBymaLop, cboLop.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void SV_SelectBymaLopBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
