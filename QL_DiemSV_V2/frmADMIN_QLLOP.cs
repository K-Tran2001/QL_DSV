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
    public partial class frmADMIN_QLLOP : Form
    {
        public frmADMIN_QLLOP()
        {
            InitializeComponent();
        }
        BLL_LOP blllop = new BLL_LOP();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        LOP lop = new LOP();
        Writelog wl;
        private void frmADMIN_QLLOP_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            ibtnNext.Enabled = false;ibtnBack.Enabled = false;
            modeDefault();
            LoadData();
        }
        public void HeaderName()
        {
            dtgLop.Columns[0].HeaderText = "Mã Lớp";
            dtgLop.Columns[1].HeaderText = "Tên Lớp";
            dtgLop.Columns[2].HeaderText = "Ngày Khai Giảng";
            dtgLop.Columns[3].HeaderText = "Mã CN";

        }
        public void LoadData()
        {
            modeDefault();
            dtgLop.DataSource = blllop.LOP_SelectAll();
            HeaderName();
            txtmaLop.DataBindings.Clear();
            txtmaLop.DataBindings.Add("Text", dtgLop.DataSource, "maLop");
            txttenLop.DataBindings.Clear();
            txttenLop.DataBindings.Add("Text", dtgLop.DataSource, "tenLop");
            datengayKhaiGiang.DataBindings.Clear();
            datengayKhaiGiang.DataBindings.Add("Text", dtgLop.DataSource, "ngayKhaiGiang");
            cbomaGV.DataBindings.Clear();
            cbomaGV.DataBindings.Add("Text", dtgLop.DataSource, "maCN");
            wl = new Writelog("AD", "LOP", "Xem", "dtgLop");
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            if (txtmaLop.Text.Equals("") || txttenLop.Text.Equals("") || cbomaGV.Text.Equals("") )
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txtmaLop.Text[0].ToString()))
            {
                MessageBox.Show("Mã lớp không bắt đầu bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txttenLop.Text[0].ToString()))
            {
                MessageBox.Show("Tên lớp không bắt đầu bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        bool themLop = false;
        public void modeThem()
        {
            ibtnRefesh.Enabled = true;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmaLop.Enabled = true; txtmaLop.Focus();
            txttenLop.Enabled = true;
            datengayKhaiGiang.Enabled = true;
            cbomaGV.Enabled = true;

        }
        public void modeSua()
        {
            ibtnRefesh.Enabled = true;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmaLop.Enabled = false; txtmaLop.Focus();
            txttenLop.Enabled = true;
            datengayKhaiGiang.Enabled = true;
            cbomaGV.Enabled = true;

        }
        public void modeDefault()
        {
            ibtnRefesh.Enabled = true;
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnXoa.Enabled = true;
            ibtnLuu.Enabled = false;

            txtmaLop.Enabled = false; 
            txttenLop.Enabled = false;
            datengayKhaiGiang.Enabled = false;
            cbomaGV.Enabled = false;
        }
        private void ibtnThem_Click(object sender, EventArgs e)
        {
            modeThem();
            txtmaLop.ResetText();txtmaLop.Focus();
            txttenLop.ResetText();
            datengayKhaiGiang.ResetText();
            cbomaGV.DataSource = bllgv.GV_SelectAll();
            cbomaGV.DisplayMember = "tenGV";
            cbomaGV.ValueMember = "maGV";
            themLop = true;
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            modeSua();
            txttenLop.Focus();
            cbomaGV.DataSource = bllgv.GV_SelectAll();
            cbomaGV.DisplayMember = "tenGV";
            cbomaGV.ValueMember = "maGV";

        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            ibtnNext.Enabled = false; ibtnBack.Enabled = true;
            string maLop = txtmaLop.Text;
            blllop.LOP_Delete(maLop);
            MessageBox.Show("Xóa lớp thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wl = new Writelog("AD", "LOP", "Xoa", "dtgLop");
            LoadData();
            modeDefault();
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraHopLe())
            {
                if (themLop)
                {
                    try
                    {
                        lop.maLop = txtmaLop.Text;
                        lop.tenLop = txttenLop.Text;
                        lop.ngayKhaiGiang = datengayKhaiGiang.Value;
                        lop.maCN = cbomaGV.SelectedValue.ToString();
                        blllop.LOP_Insert(lop);
                        MessageBox.Show("Thêm lớp thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //thong bao
                        wl = new Writelog("AD", "LOP", "Them", "dtgLop");
                        ibtnNext.Enabled = false; ibtnBack.Enabled = true;
                        themLop = false;
                    }
                    catch
                    {
                        MessageBox.Show("Thêm lớp thất bại", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        lop.maLop = txtmaLop.Text;
                        lop.tenLop = txttenLop.Text;
                        lop.ngayKhaiGiang = datengayKhaiGiang.Value;
                        lop.maCN = cbomaGV.SelectedValue.ToString();
                        blllop.LOP_Update(lop);
                        MessageBox.Show("Sửa lớp thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //thong bao
                        wl = new Writelog("AD", "LOP", "Sua", "dtgLop");
                        ibtnNext.Enabled = false; ibtnBack.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Sửa lớp thất bại", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadData();
            modeDefault();
            
        }

        private void ibtnThemlop_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnThemLop_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            ibtnNext.Enabled = true; ibtnBack.Enabled = false;
        }

        private void ibtnNext_Click(object sender, EventArgs e)
        {
            ibtnNext.Enabled = false; ibtnBack.Enabled = true;
        }

        private void frmADMIN_QLLOP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtnLuu.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                ibtnThem.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ibtnSua.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                ibtnXoa.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                ibtnRefesh.PerformClick();

            }
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
