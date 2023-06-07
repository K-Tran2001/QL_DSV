using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace QL_DiemSV_V2
{
    public partial class frmDANGNHAP : Form
    {
        public frmDANGNHAP()
        {
            InitializeComponent();
        }
        DataProvider dt;
        string quyenHan="";
        public frmDANGNHAP(DataProvider data)
        {
            dt = data;
            blltk = new BLL_TAIKHOAN(data);
            InitializeComponent();
        }
        BLL_TAIKHOAN blltk = new BLL_TAIKHOAN();
        Xuly xl = new Xuly();
        MD5 md5 =MD5.Create();
        Writelog wl;
        public Boolean kiemTraTK()
        {
            foreach (DataRow r in blltk.TK_SelectAll().Rows)
            {
                if (r[0].Equals(txttK.Text) && r[1].Equals(xl.GetMd5Hash(md5, txtmK.Text)))
                {
                    return true;
                } 

            }
            return false;
        }
        private void ibtndangNhap_Click(object sender, EventArgs e)
        {
            if (kiemTraHopLe())
            {
                if (kiemTraTK())
                {
                    MessageBox.Show("Đăng nhập thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wl = new Writelog(txttK.Text, "", "Đăng nhập", "");
                    frmMain f = new frmMain(txttK.Text);
                    this.Hide();
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //txtmK.Text= xl.GetMd5Hash(md5, txtmK.Text);
        }

        private void ibtncheMK_Click(object sender, EventArgs e)
        {
            
                
        }

        private void frmDANGNHAP_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void frmDANGNHAP_Load(object sender, EventArgs e)
        {
            
            this.KeyPreview = true;
            txtmK.UseSystemPasswordChar = true;
            txttK.Focus();
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            if (txttK.Text.Equals("") || txtmK.Text.Equals("") )
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            return true;
        }
        private void ibtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Ban co thưc sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(lenh==DialogResult.OK)
                this.Close();
        }

        private void frmDANGNHAP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtndangNhap.PerformClick();
                
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ibtnThoat.PerformClick();
                
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkhienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienMK.Checked)
            {
                ibtncheMK.IconChar = IconChar.Eye;
                txtmK.UseSystemPasswordChar = false;
            }
            else
            {
                ibtncheMK.IconChar = IconChar.EyeSlash;
                txtmK.UseSystemPasswordChar = true;
            }
        }
    }
}
