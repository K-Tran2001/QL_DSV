using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QL_DiemSV_V2
{
    public partial class frmADMIN_QLTAIKHOAN : Form
    {
        public frmADMIN_QLTAIKHOAN()
        {
            InitializeComponent();
        }
        BLL_TAIKHOAN blltk = new BLL_TAIKHOAN();
        TAIKHOAN tk = new TAIKHOAN();
        Xuly xl = new Xuly();
        MD5 md5 = MD5.Create();
        Writelog wl;
        
        private void frmADMIN_QLTAIKHOAN_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            ibtnBack.Enabled = false; ibtnNext.Enabled = false;
            modeDefault();
            LoadData();
        }
        public void HeaderName()
        {
            dtgtaiKhoan.Columns[0].HeaderText = "Tài Khoản";
            dtgtaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            dtgtaiKhoan.Columns[2].HeaderText = "Tên tài khoản";
            dtgtaiKhoan.Columns[3].HeaderText = "Loại tài khoản";

        }
        public void LoadData()
        {
            
            dtgtaiKhoan.DataSource = blltk.TK_SelectAll();
            HeaderName();
            txttaiKhoan.DataBindings.Clear();
            txttaiKhoan.DataBindings.Add("Text", dtgtaiKhoan.DataSource, "taiKhoan");
            txtmatKhau.DataBindings.Clear();
            txtmatKhau.DataBindings.Add("Text", dtgtaiKhoan.DataSource, "matKhau");
            txttenTaiKhoan.DataBindings.Clear();
            txttenTaiKhoan.DataBindings.Add("Text", dtgtaiKhoan.DataSource, "tenTaiKhoan");
            txtloaiTaiKhoan.DataBindings.Clear();
            txtloaiTaiKhoan.DataBindings.Add("Text", dtgtaiKhoan.DataSource, "loaiTaiKhoan");
            wl = new Writelog("AD", "TAIKHOAN", "Xem", "dtgTK");
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            if (txttaiKhoan.Text.Equals("") || txtmatKhau.Text.Equals("") || txttenTaiKhoan.Text.Equals("")|| txtloaiTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txttaiKhoan.Text[0].ToString()))
            {
                MessageBox.Show("Tài khoản không bắt đầu bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txtloaiTaiKhoan.Text))
            {
                MessageBox.Show("Loại tài khoản không thể là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        bool themTK = false;
        public void modeThem()
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;


            txtloaiTaiKhoan.Enabled = true; txttaiKhoan.Focus();
            txttaiKhoan.Enabled = true;
            txttenTaiKhoan.Enabled = true;
            txtmatKhau.Enabled = true;

        }
        public void modeSua()
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;


            txtloaiTaiKhoan.Enabled = true; txttenTaiKhoan.Focus();
            txttaiKhoan.Enabled = false;
            txttenTaiKhoan.Enabled = true;
            txtmatKhau.Enabled = true;

        }
        public void modeDefault()
        {
            
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnXoa.Enabled = true;
            ibtnLuu.Enabled = false;


            txtloaiTaiKhoan.Enabled = false; txttaiKhoan.Focus();
            txttaiKhoan.Enabled = false;
            txttenTaiKhoan.Enabled = false;
            txtmatKhau.Enabled = false;

        }
        private void ibtnThem_Click(object sender, EventArgs e)
        {
            modeThem();
            txttaiKhoan.ResetText();txttaiKhoan.Focus();
            txtmatKhau.ResetText();
            txttenTaiKhoan.ResetText();
            txtloaiTaiKhoan.ResetText();
            themTK = true;
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            modeSua();
            txtmatKhau.Focus();
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            String taiKhoan = txttaiKhoan.Text;
            blltk.TK_Delete(taiKhoan);
            MessageBox.Show("Xóa tài khoản thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wl = new Writelog("AD", "TAIKHOAN", "Xoa", "dtgTK");
            LoadData();
            modeDefault();
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            //if (kiemTraHopLe())
            //{
                if (themTK)
                {
                    try
                    {
                        tk.taiKhoan = txttaiKhoan.Text;
                        //tk.matKhau = txtmatKhau.Text;
                        tk.tenTaiKhoan = txttenTaiKhoan.Text;
                        tk.loaiTaiKhoan = txtloaiTaiKhoan.Text;
                        tk.matKhau = xl.GetMd5Hash(md5, txtmatKhau.Text);
                        blltk.TK_Insert(tk);
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog("AD", "TAIKHOAN", "Them", "dtgTK");
                        themTK = false;
                    }
                    catch
                    {
                        MessageBox.Show("Thêm tài khoản bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        tk.taiKhoan = txttaiKhoan.Text;
                        tk.matKhau = xl.GetMd5Hash(md5, txtmatKhau.Text);
                        tk.tenTaiKhoan = txttenTaiKhoan.Text;
                        tk.loaiTaiKhoan = txtloaiTaiKhoan.Text;
                        blltk.TK_Update(tk);
                        MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog("AD", "TAIKHOAN", "Sua", "dtgTK");
                }
                    catch
                    {
                        MessageBox.Show("Sửa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            //}

            LoadData();
            modeDefault();
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = false; ibtnNext.Enabled = true;
        }

        private void ibtnNext_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
        }

        private void frmADMIN_QLTAIKHOAN_KeyDown(object sender, KeyEventArgs e)
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
            
        }
    }
}
