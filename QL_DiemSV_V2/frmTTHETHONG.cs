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
    public partial class frmTTHETHONG : Form
    {
        public frmTTHETHONG()
        {
            InitializeComponent();
        }
        TTHETHONG ttht = new TTHETHONG();
        BLL_TTHETHONG bllttht = new BLL_TTHETHONG();
        private void frmTTHETHONG_Load(object sender, EventArgs e)
        {
            DataTable dt = bllttht.TTHT_SelectAll();
            txtTinh.DataBindings.Clear();
            txtTinh.DataBindings.Add("Text", dt, "tinh");
            txttenTruong.DataBindings.Clear();
            txttenTruong.DataBindings.Add("Text", dt, "tenTruong");
            txtnganhHoc.DataBindings.Clear();
            txtnganhHoc.DataBindings.Add("Text", dt, "nganhHoc");
            txtdonViChuQuan.DataBindings.Clear();
            txtdonViChuQuan.DataBindings.Add("Text", dt, "donViChuQuan");
            txtkhoaHoc.DataBindings.Clear();
            txtkhoaHoc.DataBindings.Add("Text", dt, "khoaHoc");
            txtchuyenNganh.DataBindings.Clear();
            txtchuyenNganh.DataBindings.Add("Text", dt, "chuyenNganh");
            
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            txtchuyenNganh.Enabled = true;
            txtTinh.Focus();
            txtdonViChuQuan.Enabled = true;
            txtkhoaHoc.Enabled = true;
            txtnganhHoc.Enabled = true;
            txttenTruong.Enabled = true;
            txtTinh.Enabled = true;
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            ttht.tinh = txtTinh.Text;
            ttht.donViChuQuan = txtdonViChuQuan.Text;
            ttht.khoaHoc = txtkhoaHoc.Text;
            ttht.nganhHoc = txtnganhHoc.Text;
            ttht.chuyenNganh = txtchuyenNganh.Text;
            ttht.tenTruong = txttenTruong.Text;

            bllttht.TTHT_Update(ttht);
            MessageBox.Show("Đã cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmTTHETHONG_Load(sender, e);
            txtchuyenNganh.Enabled = true;
            txtdonViChuQuan.Enabled = true;
            txtkhoaHoc.Enabled = true;
            txtnganhHoc.Enabled = true;
            txttenTruong.Enabled = true;
            txtTinh.Enabled = true;
        }

        private void ibtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Ban co thực sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lenh == DialogResult.Yes)
                this.Close();
        }

        private void frmTTHETHONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtnLuu.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ibtnSua.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Escape)
            {
                ibtnThoat.PerformClick();

            }
        }
    }
}
