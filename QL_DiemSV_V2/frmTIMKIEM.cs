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
using DAL;
namespace QL_DiemSV_V2
{
    public partial class frmTIMKIEM : Form
    {
        public frmTIMKIEM()
        {
            InitializeComponent();
        }
        public frmTIMKIEM(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        string iD="";
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        BLL_HOCPHAN bllhp = new BLL_HOCPHAN();
        BLL_LOP blllop = new BLL_LOP();
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        BLL_HOCKY bllhk = new BLL_HOCKY();
        BLL_KQHT_HK bllkqhthk = new BLL_KQHT_HK();

        BLL_DKHP blldkhp = new BLL_DKHP();
        DataProvider dt = new DataProvider();
        Writelog wl;
        private void frmTIMKIEM_Load(object sender, EventArgs e)
        {

            PhanQuyen();
            KeyPreview = true;
            ibtnAnd.Enabled = false;
            ibtnNot.Enabled = false;
            ibtnOr.Enabled = false;
            ibtnXor.Enabled = false;
        }
        public void PhanQuyen()
        {
            if (iD.Equals("AD"))
            {
                ((Control)tabPage6).Enabled = true;
                

                labmaSV.Text = "";
                labtenSV.Text = "";
                labLop.Text = "";

                dtgSV.DataSource = bllsv.SV_SelectAll();
                dtgGV.DataSource = bllgv.GV_SelectAll();
                dtgLop.DataSource = blllop.LOP_SelectAll();
                dtgHP.DataSource = bllhp.HP_SelectAll();

                dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectAll();
                cboHK.DataSource = bllhk.HK_SelectAll();
                cboHK.DisplayMember = "tenHK";
                cboHK.ValueMember = "maHK";

                cboLop.DataSource = blllop.LOP_SelectAll();
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            else if(iD.Contains("GV"))
            {
                ((Control)tabPage6).Enabled = false;
                DataTable data = bllgv.GV_SelectmaLopBymaGV(iD);//data chua ma lop

                labmaSV.Text = "#";
                labtenSV.Text = "#";
                labLop.DataBindings.Add("Text", data, "maLop");

                dtgSV.DataSource = bllsv.SV_SelectBymaLop(data.Rows[0]["maLop"].ToString());
                dtgGV.DataSource = bllgv.GV_SelectAll();
                dtgLop.DataSource = blllop.LOP_SelectAll();
                dtgHP.DataSource = bllhp.HP_SelectAll();
                dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaLop(data.Rows[0]["maLop"].ToString());
                cboHK.DataSource = bllhk.HK_SelectAll();
                cboHK.DisplayMember = "tenHK";
                cboHK.ValueMember = "maHK";

                cboLop.DataSource = blllop.LOP_SelectAll();
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            else
            {
                ((Control)tabPage6).Enabled = false;
                DataTable data = bllsv.SV_SelectBymaSV(iD);//data chua ma lop

                labmaSV.DataBindings.Add("Text", data, "maSV");
                labtenSV.DataBindings.Add("Text", data, "tenSV"); 
                labLop.DataBindings.Add("Text", data, "maLop");

                dtgSV.DataSource = bllsv.SV_SelectBymaLop(data.Rows[0]["maLop"].ToString());
                dtgGV.DataSource = bllgv.GV_SelectAll();
                dtgLop.DataSource = blllop.LOP_SelectAll();
                dtgHP.DataSource = bllhp.HP_SelectAll();
                dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(iD);
                cboHK.DataSource = bllhk.HK_SelectAll();
                cboHK.DisplayMember = "tenHK";
                cboHK.ValueMember = "maHK";

                cboLop.DataSource = blllop.LOP_SelectAll();
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            wl = new Writelog(iD, "", "Tra cứu", "");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttimSV_TextChanged(object sender, EventArgs e)
        {


            if (radmaSV.Checked == true)//vhon hoten
                dtgSV.DataSource = dt.ExcuteQuery("select * from SINHVIEN where maSV like '%" + txttimSV.Text + "%'");
            else
                dtgSV.DataSource = dt.ExcuteQuery("select * from SINHVIEN where tenSV like '%" + txttimSV.Text + "%'");
            wl = new Writelog(iD, "SINHVIEN", "Tim", "dtgSV");
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iD.Contains("DTH"))
            {
                dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV_maHK(iD, cboHK.SelectedValue.ToString());
                Xuly xl = new Xuly();

                int tongTC = 0, tongTCNo = 0;

                foreach (DataRow item in bllkqhthk.KQHT_HK_SelectBymaSV_maHK(iD, cboHK.SelectedValue.ToString()).Rows)
                {
                    if (item["trangThai"].ToString().Equals("Rớt môn")) tongTCNo += Convert.ToInt32(item["soTC"].ToString());
                    tongTC += Convert.ToInt32(item["soTC"].ToString());
                }

                if (tongTC == 0)
                {
                    labtongTC_HK.Text = "0";
                    labnoTC.Text = "0";
                }
                else
                {
                    labtongTC_HK.Text = tongTC.ToString();
                    labnoTC.Text = tongTCNo.ToString();
                }
                wl = new Writelog(iD, "KQHT_HK", "Tim", "dtgKQHT");
            }
            
        }

        private void txttimLop_TextChanged(object sender, EventArgs e)
        {
            if (radtenLop.Checked == true)//vhon hoten
                dtgLop.DataSource = dt.ExcuteQuery("select * from LOP where maLop like '%" + txttimLop.Text + "%'");
            else
                dtgLop.DataSource = dt.ExcuteQuery("select * from LOP where tenLop like '%" + txttimLop.Text + "%'");
            wl = new Writelog(iD, "LOP", "Tim", "dtgLop");
        }

        private void txttimGV_TextChanged(object sender, EventArgs e)
        {
            if (radmaGV.Checked == true)//vhon hoten
                dtgGV.DataSource = dt.ExcuteQuery("select * from GIAOVIEN where maGV like '%" + txttimGV.Text + "%'");
            else
                dtgGV.DataSource = dt.ExcuteQuery("select * from GIAOVIEN where tenGV like '%" + txttimGV.Text + "%'");
            wl = new Writelog(iD, "GIAOVIEN", "Tim", "dtgGV");
        }

        private void txttimHP_TextChanged(object sender, EventArgs e)
        {
            if (radmaHP.Checked == true)
                dtgHP.DataSource = dt.ExcuteQuery("select * from HOCPHAN where maHP like '%" + txttimHP.Text + "%'");
            else
                dtgHP.DataSource = dt.ExcuteQuery("select * from HOCPHAN where tenHP like '%" + txttimHP.Text + "%'");
            wl = new Writelog(iD, "HOCPHAN", "Tim", "dtgHP");
        }

        private void radtenSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radtenGV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radmaGV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ibtnTim_Click(object sender, EventArgs e)
        {
            if (txttimKiemNangCao.Text.Contains("TAIKHOAN"))
            {
                MessageBox.Show("Thao tác vi phạm chính sách bảo mật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(radtruyVanChuoi.Checked==true )//truy van chuoi danh cho AD
            {
                if (iD.Equals("AD"))
                {
                    dtgtimNangcao.DataSource = dt.ExcuteQuery(txttimKiemNangCao.Text);
                    MessageBox.Show("Có " + (dtgtimNangcao.RowCount-1).ToString() + "kết qua được tìm thấy","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    wl = new Writelog("AD", "SINHVIEN", "TimNangCao", "dtgTimNangCao");
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttimKiemNangCao.Text = "";
                    txttimKiemNangCao.Enabled = false;
                    radtuyChon.Checked = true;
                }

            }
            else//Truy van kieu tuy chon dễ su dụng 
            {
                dtgtimNangcao.DataSource = dt.ExcuteQuery(txttimKiemNangCao.Text);
                MessageBox.Show("Có " + (dtgtimNangcao.RowCount-1).ToString() + "kết qua được tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wl = new Writelog(iD, "SINHVIEN", "TimNangCao", "dtgTimNangCao");
            }
            
        }

        private void radtruyVanChuoi_CheckedChanged(object sender, EventArgs e)
        {
            //kt quyen
            grTim.Enabled = false;
            txttimKiemNangCao.Enabled = true;
            txttimKiemNangCao.Text = "";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ibtnAnd.Enabled = true;
            ibtnNot.Enabled = true;
            ibtnOr.Enabled = true;
            ibtnXor.Enabled = true;

            txttimKiemNangCao.Text += " where sv.maLop= '" + cboLop.SelectedValue.ToString()+"'";

        }

        private void radtuyChon_CheckedChanged(object sender, EventArgs e)
        {
            txttimKiemNangCao.Enabled = false;
            grTim.Enabled = true;
            txttimKiemNangCao.Text = "select sv.maSV,sv.tenSV,sv.gioiTinh, sv.ngaySinh,sv.diaChi,sv.dienThoai,sv.maLop from SINHVIEN sv inner join KQHT_HK kqht on sv.maSV=kqht.maSV  ";
        }

        private void ibtnAnd_Click(object sender, EventArgs e)
        {
            txttimKiemNangCao.Text += " AND ";
        }

        private void ibtnOr_Click(object sender, EventArgs e)
        {
            txttimKiemNangCao.Text += " OR ";
        }

        private void ibtnXor_Click(object sender, EventArgs e)
        {
            txttimKiemNangCao.Text += " XOR ";
        }

        private void ibtnNot_Click(object sender, EventArgs e)
        {
            txttimKiemNangCao.Text += " NOT ";
        }

        private void txtd1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtdiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            txttimKiemNangCao.Text += " sv.diaChi like '%" + txtdiaChi.Text + "%'";
        }

        private void txtd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtd2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            txttimKiemNangCao.Text += " kqht.diemTB between " + txtd1.Text + " and "+txtd2.Text;
        }

        private void txtdiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ibtnlamLai_Click(object sender, EventArgs e)
        {
            txttimKiemNangCao.Text = "";
            radtuyChon.Checked = true;
        }
    }
}
