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
    public partial class frmBaoCaoGroup : Form
    {
        public frmBaoCaoGroup()
        {
            InitializeComponent();
        }
        BLL_LOP blllop = new BLL_LOP();
        BLL_KQHT_HK bllkqhthk = new BLL_KQHT_HK();
        /*  cboLop.DataSource = blllop.LOP_SelectAll();
            cboLop.DisplayMember = "maLop";
            cboLop.ValueMember = "tenLop";

        this.KQHT_HK_SelectAllTableAdapter.Fill(this.DS_Diem_Lop_GroupRpt.KQHT_HK_SelectAll);
            this.reportViewer1.RefreshReport();
            
        */
        private void frmBaoCaoGroup_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = blllop.LOP_SelectAll();
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.KQHT_HK_SelectBymaLopTableAdapter.Fill(this.DS_Diem_Lop_GroupRpt.KQHT_HK_SelectBymaLop, cboLop.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
