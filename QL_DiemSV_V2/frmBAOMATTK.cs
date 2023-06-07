using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QL_DiemSV_V2
{
    public partial class frmBAOMATTK : Form
    {
        public frmBAOMATTK()
        {
            InitializeComponent();
        }
        public frmBAOMATTK(string iD)
        {
            this.iD = iD;
            InitializeComponent();

        }

        string iD="DTH195287";
        Writelog wl;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        TAIKHOAN tk = new TAIKHOAN();
        BLL_TAIKHOAN blltk = new BLL_TAIKHOAN();
        Xuly xl = new Xuly();
        MD5 md5 = MD5.Create();
        private void frmBAOMATTK_Load(object sender, EventArgs e)
        {
            //DataTable dt = blltk.TK_SelectBytaiKhoan(iD);
            this.KeyPreview = true;
            txtmKMoi.UseSystemPasswordChar = true;
            txtmKMoi_NhapLai.UseSystemPasswordChar = true;
            labtK.Text = iD;
            
        }
        public Boolean kiemTraHopLe()
        {
            if (txtmKMoi_NhapLai.Text.Equals("") || txtmKMoi.Text.Equals(""))
            {
                MessageBox.Show("Dữ liệu chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if (!txtmKMoi_NhapLai.Text.Equals(txtmKMoi.Text))
            {
                MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        } 
        private void ibtndoiMK_Click(object sender, EventArgs e)
        {
            if (kiemTraHopLe())
            {
                tk.taiKhoan = labtK.Text;
                tk.matKhau = xl.GetMd5Hash(md5, txtmKMoi.Text);
                blltk.TK_UpdatemK(tk);
                
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wl = new Writelog(iD, "", "Doi MK", "");
            }
            

        }

        private void ibtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Ban co thưc sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lenh == DialogResult.Yes)
                this.Close();
        }

        private void chk_hienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienMK.Checked)
            {
                ibtn_hienMK1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                ibtn_hienMK2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtmKMoi.UseSystemPasswordChar = false;
                txtmKMoi_NhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                ibtn_hienMK1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                ibtn_hienMK2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtmKMoi.UseSystemPasswordChar = true;
                txtmKMoi_NhapLai.UseSystemPasswordChar = true;
            }
        }
    }
}
