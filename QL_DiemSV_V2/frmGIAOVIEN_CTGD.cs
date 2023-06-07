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
    public partial class frmGIAOVIEN_CTGD : Form
    {
        public frmGIAOVIEN_CTGD()
        {
            InitializeComponent();
        }
        public frmGIAOVIEN_CTGD(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        String iD;
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        BLL_CTGIANGDAY blldcgd = new BLL_CTGIANGDAY();
        private void frmGIAOVIEN_CTGD_Load(object sender, EventArgs e)
        {
            DataTable dtgsinhVien = bllgv.GV_SelectBymaGV(iD);

            labmaGV.DataBindings.Clear();
            labmaGV.DataBindings.Add("Text", dtgsinhVien, "maGV");
            labtenGV.DataBindings.Clear();
            labtenGV.DataBindings.Add("Text", dtgsinhVien, "tenGV");
            labgioiTinh.DataBindings.Clear();
            labgioiTinh.DataBindings.Add("Text", dtgsinhVien, "gioiTinh");
            labdiaChi.DataBindings.Clear();
            labdiaChi.DataBindings.Add("Text", dtgsinhVien, "diaChi");
            labdienThoai.DataBindings.Clear();
            labdienThoai.DataBindings.Add("Text", dtgsinhVien, "dienThoai");
            labeMail.DataBindings.Clear();
            labeMail.DataBindings.Add("Text", dtgsinhVien, "eMail");
            labngaySinh.DataBindings.Clear();
            labngaySinh.DataBindings.Add("Text", dtgsinhVien, "ngaySinh");

            dtgCTGD.DataSource = blldcgd.CTGD_SelectmaGV(iD);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
