using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QL_DiemSV_V2
{
    public partial class frmCAPNHATTT : Form
    {
        public frmCAPNHATTT()
        {
            InitializeComponent();
        }
        public frmCAPNHATTT(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        string iD="DTH195287";
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        BLL_LOP blllop = new BLL_LOP();
        SINHVIEN sv = new SINHVIEN();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        GIAOVIEN gv = new GIAOVIEN();
        Writelog wl;
        private void frmCAPNHATTT_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            if (iD.Contains("GV")){
                //modeSuaGV();
                modeDefaultGV();
                LoadGV();
            }
            else
            {
                //modeSuaSV();

                modeDefaultSV();
                LoadSV();
            }
            
        }
        public void LoadSV()
        {
            //cboLop.Visible = true; txteMail.Visible = false;txteMail.Hide();
            DataTable dt = new DataTable();
            //dt = bllsv.SV_SelectBymaLop("DH20TH1");
            dt = bllsv.SV_SelectBymaSV(iD);
            txtmSSV.DataBindings.Clear();
            txtmSSV.DataBindings.Add("Text", dt, "maSV");
            txttenSV.DataBindings.Clear();
            txttenSV.DataBindings.Add("Text", dt, "tenSV");
            cbogioiTinh.DataBindings.Clear();
            cbogioiTinh.DataBindings.Add("Text", dt, "gioiTinh");
            txtdiaChi.DataBindings.Clear();
            txtdiaChi.DataBindings.Add("Text", dt, "diaChi");
            txtdienThoai.DataBindings.Clear();
            txtdienThoai.DataBindings.Add("Text", dt, "dienThoai");
            txtmaLop.DataBindings.Clear();
            txtmaLop.DataBindings.Add("Text", dt, "maLop");
            datengaySinh.DataBindings.Clear();
            datengaySinh.DataBindings.Add("Text", dt, "ngaySinh");
        }
        public void LoadGV()
        {
            //cboLop.Visible = false; txteMail.Visible = true; txtmSSV.Enabled = false;
            labmSV.Text = "Mã GV"; labtenSV.Text = "Tên GV";labmaLop.Text = "Email";
            DataTable dt = new DataTable();
           
            dt = bllgv.GV_SelectBymaGV(iD);
            txtmSSV.DataBindings.Clear();
            txtmSSV.DataBindings.Add("Text", dt, "maGV");
            txttenSV.DataBindings.Clear();
            txttenSV.DataBindings.Add("Text", dt, "tenGV");
            cbogioiTinh.DataBindings.Clear();
            cbogioiTinh.DataBindings.Add("Text", dt, "gioiTinh");
            txtdiaChi.DataBindings.Clear();
            txtdiaChi.DataBindings.Add("Text", dt, "diaChi");
            txtdienThoai.DataBindings.Clear();
            txtdienThoai.DataBindings.Add("Text", dt, "dienThoai");
            txtmaLop.DataBindings.Clear();
            txtmaLop.DataBindings.Add("Text", dt, "eMail");
            datengaySinh.DataBindings.Clear();
            datengaySinh.DataBindings.Add("Text", dt, "ngaySinh");
            
        }
        public void modeSuaSV()
        {
            txtmSSV.Enabled = false;
            txttenSV.Enabled = false; 
            cbogioiTinh.Enabled = false;
            datengaySinh.Enabled = false;
            txtdiaChi.Enabled = true;
            txtdienThoai.Enabled = true;
            
        }
        public void modeDefaultSV()
        {
            txtmSSV.Enabled = false;
            txttenSV.Enabled = false;
            cbogioiTinh.Enabled = false;
            datengaySinh.Enabled = false;
            txtdiaChi.Enabled = false;
            txtdienThoai.Enabled = false;
            txtmaLop.Enabled = false;
            
        }
        public void modeSuaGV()
        {
            txtmSSV.Enabled = false;
            txtmSSV.Enabled = false; 
            cbogioiTinh.Enabled = false;
            datengaySinh.Enabled = false;
            txtdiaChi.Enabled = true;
            txtdienThoai.Enabled = true;
            txtmaLop.Enabled = false;
        }
        public void modeDefaultGV()
        {
            txtmSSV.Enabled = false;
            txttenSV.Enabled = false;
            cbogioiTinh.Enabled = false;
            datengaySinh.Enabled = false;
            txtdiaChi.Enabled = false;
            txtdienThoai.Enabled = false;
            txtmaLop.Enabled = false;
        }
        private void ibtnSua_Click(object sender, EventArgs e)
        {
            txtdiaChi.Focus();
            if(iD.Contains("GV"))
            {
                modeSuaGV();
            }
            else
            {
                modeSuaSV();
            }
            
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            if (txttenSV.Text.Equals("") || cbogioiTinh.Text.Equals("") || txtdienThoai.Text.Equals("") || txtdiaChi.Text.Equals("") || txtmaLop.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txttenSV.Text))
            {
                MessageBox.Show("Tên sinh viên không được tồn tại kí tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsNumber(txtdienThoai.Text))
            {
                MessageBox.Show("Số điện thoại phải toàn là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraHopLe())
            {
                if (iD.Contains("GV"))
                {
                    gv.maGV = txtmSSV.Text;
                    gv.tenGV = txttenSV.Text;
                    gv.ngaySinh = datengaySinh.Value;
                    gv.gioiTinh = cbogioiTinh.SelectedItem.ToString();
                    gv.diaChi = txtdiaChi.Text;
                    gv.dienThoai = txtdienThoai.Text;
                    gv.eMail = txtmaLop.Text;
                    bllgv.GV_Update(gv);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wl = new Writelog(iD, "", "Capnhat", "");
                    ibtnHuy_Click(sender, e);
                    LoadGV();
                    
                }
                else
                {
                    sv = new SINHVIEN();
                    sv.maSV = txtmSSV.Text;
                    sv.tenSV = txttenSV.Text;
                    sv.ngaySinh = datengaySinh.Value;
                    sv.gioiTinh = cbogioiTinh.SelectedItem.ToString();
                    sv.diaChi = txtdiaChi.Text;
                    sv.dienThoai = txtdienThoai.Text;
                    sv.maLop = txtmaLop.Text;
                    bllsv.SV_Update(sv);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wl = new Writelog(iD, "", "Capnhat", "");
                    ibtnHuy_Click(sender, e);
                    LoadSV();

                }
            }
                
        }

        private void ibtnHuy_Click(object sender, EventArgs e)
        {
            if (iD.Contains("GV"))
            {
                modeDefaultGV();
            }
            else
            {
                modeDefaultSV();
            }
            frmCAPNHATTT_Load(sender, e);
        }

        private void ibtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Ban co thưc sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lenh == DialogResult.Yes)
                this.Close();
        }

        private void frmCAPNHATTT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtnLuu.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ibtnLuu.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ibtnSua.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                ibtnHuy.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Escape)
            {
                ibtnThoat.PerformClick();

            }
            
        }
    }
}
