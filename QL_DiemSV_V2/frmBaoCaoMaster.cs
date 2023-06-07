using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemSV_V2
{
    public partial class frmBaoCaoMaster : Form
    {
        public frmBaoCaoMaster()
        {
            InitializeComponent();
        }

        private void frmBaoCaoMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Lop_Diem.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DS_Lop_Diem.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
