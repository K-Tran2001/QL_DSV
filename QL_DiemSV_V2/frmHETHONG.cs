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
    public partial class frmHETHONG : Form
    {
        public frmHETHONG()
        {
            InitializeComponent();
        }
        string iD="";
        public frmHETHONG(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        private void OpenChildForm(Form frm)
        { 
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlformCon.Controls.Add(frm);
            pnlformCon.Tag = frm;
            frm.BringToFront();
            frm.Show();

        }
        private void frmHETHONG_Load(object sender, EventArgs e)
        {
            if (iD.Equals(""))
            {
                ibtncapNhat.Enabled = false;
                ibtndoiMK.Enabled = false;
                ibtndoiTK.Enabled = false;
                ibtnTTHT.Enabled = false;
                ibtnB_R.Enabled = false;
                
            }
            else if(iD.Equals("AD"))
            {
                ibtncapNhat.Enabled = false;
                ibtndoiMK.Enabled = true;
                ibtndoiTK.Enabled = true;
                ibtnTTHT.Enabled = true;
                ibtnB_R.Enabled = true;
                
            }
            else
            {
                ibtncapNhat.Enabled = true;
                ibtndoiMK.Enabled = true;
                ibtndoiTK.Enabled = true;
                ibtnTTHT.Enabled = false;
                ibtnB_R.Enabled = false;
                
            }
        }

        private void ibtncapNhat_Click(object sender, EventArgs e)
        {
            frmCAPNHATTT f = new frmCAPNHATTT(iD);
            OpenChildForm(f);
        }

        private void ibtndoiMK_Click(object sender, EventArgs e)
        {
            frmBAOMATTK f = new frmBAOMATTK(iD);
            OpenChildForm(f);
        }

        private void ibtndoiTK_Click(object sender, EventArgs e)
        {
            frmDANGNHAP f = new frmDANGNHAP();
            OpenChildForm(f);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void ibtndangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thức muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void ibtnTHHT_Click(object sender, EventArgs e)
        {
            frmTTHETHONG f = new frmTTHETHONG();
            OpenChildForm(f);
        }

        private void ibtnB_R_Click(object sender, EventArgs e)
        {
            frmBackupRestorecs f = new frmBackupRestorecs();
            OpenChildForm(f);
        }
    }
}
