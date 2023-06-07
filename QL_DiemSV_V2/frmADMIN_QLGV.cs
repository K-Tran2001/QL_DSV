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
using DAL;
using DTO;
namespace QL_DiemSV_V2
{
    public partial class frmADMIN_QLGV : Form
    {
        public frmADMIN_QLGV()
        {
            InitializeComponent();
        }
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        GIAOVIEN gv = new GIAOVIEN();
        DataProvider dt = new DataProvider();
        Writelog wl;
        private void frmADMIN_QLGV_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            ibtnBack.Enabled = false; ibtnNext.Enabled = false;
            modeDefault();
            LoadData();
        }
        public void HeaderName()
        {
            dtggiaoVien.Columns[0].HeaderText = "Mã Giáo Viên";
            dtggiaoVien.Columns[1].HeaderText = "Tên Giáo Viên";
            dtggiaoVien.Columns[2].HeaderText = "Giới Tính";
            dtggiaoVien.Columns[3].HeaderText = "Ngày Sinh";
            dtggiaoVien.Columns[5].HeaderText = "Điện Thoại";
            dtggiaoVien.Columns[4].HeaderText = "Địa Chỉ";
            dtggiaoVien.Columns[6].HeaderText = "Email";

        }
        public string phatSinhMSGV()
        {
            string ms = ""; DataTable data = bllgv.GV_SelectAll();
            foreach (DataRow r in data.Rows)
            {
                ms = r["maGV"].ToString();
            }
            ms = ms.Substring(3);
            ms = (Convert.ToInt32(ms) + 1).ToString();
            ms = "GV0" + ms;
            
            return ms;
        }
        public void LoadData()
        {
            
            dtggiaoVien.DataSource = bllgv.GV_SelectAll();
            HeaderName();
            txtmaGV.DataBindings.Clear();
            txtmaGV.DataBindings.Add("Text", dtggiaoVien.DataSource, "maGV");
            txttenGV.DataBindings.Clear();
            txttenGV.DataBindings.Add("Text", dtggiaoVien.DataSource, "tenGV");
            datengaySinh.DataBindings.Clear();
            datengaySinh.DataBindings.Add("Text", dtggiaoVien.DataSource, "ngaySinh");
            cbogioiTinh.DataBindings.Clear();
            cbogioiTinh.DataBindings.Add("Text", dtggiaoVien.DataSource, "gioiTinh");
            txtdiaChi.DataBindings.Clear();
            txtdiaChi.DataBindings.Add("Text", dtggiaoVien.DataSource, "diaChi");
            txtdienThoai.DataBindings.Clear();
            txtdienThoai.DataBindings.Add("Text", dtggiaoVien.DataSource, "dienThoai");
            txteMail.DataBindings.Clear();
            txteMail.DataBindings.Add("Text", dtggiaoVien.DataSource, "eMail");
            wl = new Writelog("AD", "GIAOVIEN", "Xem", "dtgGV");
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            int currentYear = DateTime.Now.Year;
            if (txttenGV.Text.Equals("")||cbogioiTinh.Text.Equals("")|| txtdienThoai.Text.Equals("")|| txtdiaChi.Text.Equals("")|| txteMail.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txttenGV.Text))
            {
                MessageBox.Show("Tên sinh viên không được tồn tại kí tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (currentYear - datengaySinh.Value.Year < 25 || currentYear - datengaySinh.Value.Year > 60)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsNumber(txtdienThoai.Text))
            {
                MessageBox.Show("Số điện thoại phải toàn là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!txteMail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ (phải có dạng abc@example.com)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        bool themGV = false;
        public void modeThem()
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmaGV.Enabled = false;txttenGV.Focus();
            txttenGV.Enabled = true;
            cbogioiTinh.Enabled = true;
            datengaySinh.Enabled = true;
            txtdiaChi.Enabled = true;
            txtdienThoai.Enabled = true;
            txteMail.Enabled = true;
        }
        public void modeSua()
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmaGV.Enabled = false;
            txttenGV.Enabled = true; txttenGV.Focus();
            cbogioiTinh.Enabled = true;
            datengaySinh.Enabled = true;
            txtdiaChi.Enabled = true;
            txtdienThoai.Enabled = true;
            txteMail.Enabled = true;
        }
        public void modeDefault()
        {
            
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnXoa.Enabled = true;
            ibtnLuu.Enabled = false;

            txtmaGV.Enabled = false;
            txttenGV.Enabled = false;
            cbogioiTinh.Enabled = false;
            datengaySinh.Enabled = false;
            txtdiaChi.Enabled = false;
            txtdienThoai.Enabled = false;
            txteMail.Enabled = false;
        }
        private void ibtnThem_Click(object sender, EventArgs e)
        {
            modeThem();
            txtmaGV.Text=phatSinhMSGV();
            txttenGV.ResetText(); txttenGV.Focus();
            cbogioiTinh.ResetText();//cbogioiTinh.Items.Add("Nam"); cbogioiTinh.Items.Add("Nữ");
            datengaySinh.ResetText();
            txtdiaChi.ResetText();
            txtdienThoai.ResetText();
            txteMail.ResetText();
            themGV = true;
        }

        private void ibtLuu_Click(object sender, EventArgs e)
        {
           

            if (kiemTraHopLe())
            {
                if (themGV)
                {
                    try
                    {
                        gv.maGV = txtmaGV.Text;
                        gv.tenGV = txttenGV.Text;
                        gv.gioiTinh = cbogioiTinh.SelectedItem.ToString();
                        gv.ngaySinh = datengaySinh.Value;
                        gv.diaChi = txtdiaChi.Text;
                        gv.dienThoai = txtdienThoai.Text;
                        gv.eMail = txteMail.Text;
                        bllgv.GV_Insert(gv);
                        MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog("AD", "GIAOVIEN", "Them", "dtgGV");
                        themGV = false;
                    }
                    catch
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        gv.maGV = txtmaGV.Text;
                        gv.tenGV = txttenGV.Text;
                        gv.gioiTinh = cbogioiTinh.SelectedItem.ToString();
                        gv.ngaySinh = datengaySinh.Value;
                        gv.diaChi = txtdiaChi.Text;
                        gv.dienThoai = txtdienThoai.Text;
                        gv.eMail = txteMail.Text;                       
                        bllgv.GV_Update(gv);
                        MessageBox.Show("Sửa giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog("AD", "GIAOVIEN", "Sua", "dtgGV");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                modeDefault();
                LoadData();
            }
            

        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            modeSua();
            txttenGV.Focus();
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult lenh = MessageBox.Show("Bạn có thực sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (lenh == DialogResult.Yes)
                {
                    ibtnBack.Enabled = true; ibtnNext.Enabled = false;
                    string maGV = txtmaGV.Text;
                    bllgv.GV_Delete(maGV);
                    MessageBox.Show("Giáo viên đã được xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    wl = new Writelog("AD", "GIAOVIEN", "Xoa", "dtgGV");
                    LoadData();
                    modeDefault();
                }

            }
            catch
            {
                MessageBox.Show("Xóa giáo viên không thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = false; ibtnNext.Enabled = true;
        }

        private void ibtnNext_Click(object sender, EventArgs e)
        {
            ibtnBack.Enabled = true; ibtnNext.Enabled = false;
        }

        private void ibtnTim_Click(object sender, EventArgs e)
        {
            dtggiaoVien.DataSource = dt.ExcuteQuery("select * from GIAOVIEN where tenGV like '%" + txtTim.Text + "%'");
        }

        private void frmADMIN_QLGV_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                ibtnTim.PerformClick();

            }
        }

        private void txtdienThoai_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtdienThoai.Text) && txtdienThoai.Text.Length > 10)
            {
                txtdienThoai.Text = txtdienThoai.Text.Substring(0, 10);
                MessageBox.Show("Số điện thoại tối đa có 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
