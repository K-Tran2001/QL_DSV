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
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }
        public frmLoad(string  iD)
        {
            InitializeComponent();
        }
        String iD = "";
        private void frmLoad_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pgQT.PerformStep();
            labQT.Text = pgQT.Value.ToString()+" %";
            if (pgQT.Value == 100)
            {
                timer.Stop();
                //frmMain f = new frmMain("AD");
                //f.Show();
                //this.Hide();
                MessageBox.Show("100%", "Thong bao");
                pgQT.Value = 0;
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
