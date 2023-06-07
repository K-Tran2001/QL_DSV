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
    public partial class frmSINHVIEN_CTDKHP : Form
    {
        public frmSINHVIEN_CTDKHP()
        {
            InitializeComponent();
        }
        public frmSINHVIEN_CTDKHP(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        int hocphi = 314000;
        string iD;
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();

        BLL_CTDKHP bllctdk = new BLL_CTDKHP();
        BLL_THONGBAO blltb = new BLL_THONGBAO();
        BLL_DKHP blldk = new BLL_DKHP();
        BLL_HOCKY bllhk = new BLL_HOCKY();
        Writelog wl;
        private void frmSINHVIEN_CTDKHP_Load(object sender, EventArgs e)
        {
            //load DL sinh
            //load Dl CTDK HP
            radtatCa_CheckedChanged(sender, e);
            DataTable dtgsinhVien = bllsv.SV_SelectBymaSV(iD);

            labmSSV.DataBindings.Clear();
            labmSSV.DataBindings.Add("Text", dtgsinhVien, "maSV");
            labtenSV.DataBindings.Clear();
            labtenSV.DataBindings.Add("Text", dtgsinhVien, "tenSV");
            labgioiTinh.DataBindings.Clear();
            labgioiTinh.DataBindings.Add("Text", dtgsinhVien, "gioiTinh");
            labdiaChi.DataBindings.Clear();
            labdiaChi.DataBindings.Add("Text", dtgsinhVien, "diaChi");
            labdienThoai.DataBindings.Clear();
            labdienThoai.DataBindings.Add("Text", dtgsinhVien, "dienThoai");
            labmaLop.DataBindings.Clear();
            labmaLop.DataBindings.Add("Text", dtgsinhVien, "maLop");
            labngaySinh.DataBindings.Clear();
            labngaySinh.DataBindings.Add("Text", dtgsinhVien, "ngaySinh");

            dtgthongBao.DataSource= blltb.TB_SelectBymaSV(iD);
            wl = new Writelog(iD, "CTDKHP", "Xem CTDKHP", "dtgCTDKHP");
        }
        public void HeaderName()
        {
            dtgCTDKHP.Columns[1].HeaderText = "Mã Sinh Viên";
            
            dtgthongBao.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgthongBao.Columns[1].HeaderText = "Nội Dung";
            dtgthongBao.Columns[2].HeaderText = "Thời Gian";

        }
        private void radtatCa_CheckedChanged(object sender, EventArgs e)
        {
            labtongTC.Text = "";
            labtongHocPhi.Text = "";
            labHK.Text = "";
            
            dtgCTDKHP.DataSource = bllctdk.CTDKHP_SelectBymaSV(iD);
            cboHK.Visible = false;
        }

        private void radhocKi_CheckedChanged(object sender, EventArgs e)
        {
            cboHK.Visible = true;
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgCTDKHP.DataSource = bllctdk.CTDKHP_SelectBymaSV_maHK(iD, cboHK.SelectedValue.ToString());
            int tongtc = 0;
            //Them truong soTC
            for(int i=0;i<dtgCTDKHP.Rows.Count-1;i++)
            {
                tongtc += Convert.ToInt32(dtgCTDKHP.Rows[i].Cells["soTC"].Value.ToString());
            }
            labHK.Text = cboHK.SelectedValue.ToString();
            labtongTC.Text = tongtc.ToString();
            labtongHocPhi.Text = (tongtc * hocphi).ToString();
            //Tinhs hocj phis theo hoc ki
        }
    }
}
