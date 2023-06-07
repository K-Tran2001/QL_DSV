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
using DTO;
namespace QL_DiemSV_V2
{
    public partial class frmADMIN_QLGIANGDAY : Form
    {
        public frmADMIN_QLGIANGDAY()
        {
            InitializeComponent();
        }
        GIAOVIEN gv = new GIAOVIEN();
        HOCPHAN hp = new HOCPHAN();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        BLL_HOCKY bllhk = new BLL_HOCKY();
        BLL_HOCPHAN bllhp = new BLL_HOCPHAN();
        BLL_CTGIANGDAY bllctgd = new BLL_CTGIANGDAY();
        CTGIANGDAY ctgd = new CTGIANGDAY();
        Writelog wl;
        private void frmADMIN_QLGIANGDAY_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            ibtnBack.Enabled = false;ibtnNext.Enabled = false;
            LoadData();

        }
        public void HeaderName()
        {
            dtgCTGD.Columns[0].HeaderText = "Mã Giáo Viên";
            dtgCTGD.Columns[1].HeaderText = "Mã Học Phần";
            dtgCTGD.Columns[2].HeaderText = "TG Đăng Kí";

        }
        public void LoadData()
        {
            
            dtgCTGD.DataSource = bllctgd.CTGD_SelectAll();
            HeaderName();
            labmaGV.DataBindings.Clear();
            labmaGV.DataBindings.Add("Text", dtgCTGD.DataSource, "maGV");
            labmaHP.DataBindings.Clear();
            labmaHP.DataBindings.Add("Text", dtgCTGD.DataSource, "maHP");

            labtgHoc.Visible = false;cboThu.Visible = false;cboTG.Visible = false;
            cboGV.Enabled = false; cboHK.Enabled = false; cboHP.Enabled = false;
            cboThu.Enabled = false;cboTG.Enabled = false;
            ibtnThem.Enabled = true;ibtnXoa.Enabled = true;ibtnLuu.Enabled = false;

            wl = new Writelog("AD", "CTGIANGDAY", "Xem", "dtgCTGD");
        }
        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cboHP.DataSource = bllhp.HP_SelectBymaHK(cboHK.SelectedValue.ToString());
            cboHP.DisplayMember = "tenHP";
            cboHP.ValueMember = "maHP";
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            ibtnThem.Enabled = false; ibtnXoa.Enabled = false; ibtnLuu.Enabled = true;
            cboGV.Enabled = true;
            cboGV.DataSource = bllgv.GV_SelectAll();
            cboGV.DisplayMember = "tenGV";
            cboGV.ValueMember = "maGV";

            cboHK.Enabled = true;cboHP.Enabled = true;
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";

            labtgHoc.Visible = true; cboThu.Visible = true; cboTG.Visible = true;
            //cboThu.Enabled = true; cboTG.Enabled = true;
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            ibtnThem.Enabled = false; ibtnXoa.Enabled = false; ibtnLuu.Enabled = true;
            labtgHoc.Visible = true; cboThu.Visible = true; cboTG.Visible = true;
            ctgd.maGV = cboGV.SelectedValue.ToString();
            ctgd.maHP = cboHP.SelectedValue.ToString();
            ctgd.tgHoc = cboThu.SelectedItem.ToString() + "-" + cboTG.SelectedItem.ToString();
            bllctgd.CTGD_Update(ctgd);
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            int i = dtgCTGD.CurrentCell.RowIndex;
            string maHP = dtgCTGD.Rows[i].Cells["maHP"].Value.ToString();
            string maGV = dtgCTGD.Rows[i].Cells["maGV"].Value.ToString();
            bllctgd.CTGD_Delete(maGV, maHP);
            MessageBox.Show("Xóa phân công thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wl = new Writelog("AD", "CTGIANGDAY", "Xoa", "dtgCTGD");
            LoadData();
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ctgd.maGV = cboGV.SelectedValue.ToString();
            ctgd.maHP = cboHP.SelectedValue.ToString();
            ctgd.tgHoc = cboThu.SelectedItem + "-" + cboTG.SelectedItem;
            bllctgd.CTGD_Insert(ctgd);
            MessageBox.Show("Lưu phân công thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wl = new Writelog("AD", "CTGIANGDAY", "Them", "dtgCTGD");
            LoadData();
            
        }

        private void cboGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = bllgv.GV_SelectBymaGV(cboGV.SelectedValue.ToString());
            labmaGV.DataBindings.Clear();
            labmaGV.DataBindings.Add("Text", dt, "maGV");
            labtenGV.DataBindings.Clear();
            labtenGV.DataBindings.Add("Text", dt, "tenGV");
            labdienThoai.DataBindings.Clear();
            labdienThoai.DataBindings.Add("Text", dt, "dienThoai");
            labeMail.DataBindings.Clear();
            labeMail.DataBindings.Add("Text", dt, "eMail");
        }

        private void cboHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bllhp.HP_SelectBymaHP(cboHP.SelectedValue.ToString());
            labmaHP.DataBindings.Clear();
            labmaHP.DataBindings.Add("Text", dt, "maHP");
            labtenHP.DataBindings.Clear();
            labtenHP.DataBindings.Add("Text", dt, "tenHP");
            labsoTC.DataBindings.Clear();
            labsoTC.DataBindings.Add("Text", dt, "soTC");
            labmaHK.DataBindings.Clear();
            labmaHK.DataBindings.Add("Text", dt, "maHK");

        }
        
        private void dtgCTGD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void dtgCTGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgCTGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgCTGD.CurrentCell.RowIndex;
            DataTable dt = bllgv.GV_SelectBymaGV(dtgCTGD.Rows[i].Cells[0].Value.ToString());

            labtenGV.DataBindings.Clear();
            labtenGV.DataBindings.Add("Text", dt, "tenGV");
            labdienThoai.DataBindings.Clear();
            labdienThoai.DataBindings.Add("Text", dt, "dienThoai");
            labeMail.DataBindings.Clear();
            labeMail.DataBindings.Add("Text", dt, "eMail");

            dt = new DataTable();
            dt = bllhp.HP_SelectBymaHP(dtgCTGD.Rows[i].Cells[1].Value.ToString());

            labtenHP.DataBindings.Clear();
            labtenHP.DataBindings.Add("Text", dt, "tenHP");
            labsoTC.DataBindings.Clear();
            labsoTC.DataBindings.Add("Text", dt, "soTC");
            labmaHK.DataBindings.Clear();
            labmaHK.DataBindings.Add("Text", dt, "maHK");



        }

        private void labmaGV_Click(object sender, EventArgs e)
        {

        }

        private void labmaGV_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void labmaGV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labmaGV_BindingContextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void labmaGV_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void labmaHP_Click(object sender, EventArgs e)
        {

        }

        private void ibtnreFresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = false; ibtnNext.Enabled = true;
        }

        private void ibtnNext_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
        }

        private void frmADMIN_QLGIANGDAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtnLuu.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                ibtnThem.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                ibtnXoa.PerformClick();

            }
           
        }
    }
}
