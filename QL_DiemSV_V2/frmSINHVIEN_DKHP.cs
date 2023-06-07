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
    public partial class frmSINHVIEN_DKHP : Form
    {
        public frmSINHVIEN_DKHP()
        {
            InitializeComponent();
        }
        public frmSINHVIEN_DKHP(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        string iD;
        BLL_HOCPHAN bllhp = new BLL_HOCPHAN();
        BLL_DKHP blldkhp = new BLL_DKHP();
        DKHP dkhp = new DKHP();
        BLL_HOCKY bllhk = new BLL_HOCKY();
        Writelog wl;
        private void frmSINHVIEN_DKHP_Load(object sender, EventArgs e)
        {
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";

            dtgCTDKHP.DataSource = bllctdk.CTDKHP_SelectBymaSV(iD);
            wl = new Writelog(iD, "HOCPHAN", "Xem DSHP", "dtgHP");
        }
        public void HeaderName()
        {
            dtgHP.Columns[0].HeaderText = "Mã Học Phận";
            dtgHP.Columns[1].HeaderText = "Tên Học Phận";
            dtgHP.Columns[2].HeaderText = "Số Tín Chỉ";
            dtgHP.Columns[3].HeaderText = "Mã Học Kì";

            dtgCTDKHP.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgCTDKHP.Columns[1].HeaderText = "Mã Học Phận";
            dtgCTDKHP.Columns[2].HeaderText = "Tên Học Phận";
            dtgCTDKHP.Columns[3].HeaderText = "Thời Gian DK";

        }
        private void ibtnChon_Click(object sender, EventArgs e)
        {
            int i = dtgHP.CurrentCell.RowIndex;

            ListViewItem r = new ListViewItem(dtgHP.Rows[i].Cells["maHP"].Value.ToString());
            r.SubItems.Add(dtgHP.Rows[i].Cells["tenHP"].Value.ToString());
            r.SubItems.Add(dtgHP.Rows[i].Cells["soTC"].Value.ToString());
            r.SubItems.Add(dtgHP.Rows[i].Cells["maHK"].Value.ToString());
            lstHPDK.Items.Add(r);

            
        }

        private void ibtnboChon_Click(object sender, EventArgs e)
        {
            int i = lstHPDK.SelectedItems[0].Index;
            lstHPDK.Items.RemoveAt(i);
        }
        BLL_CTDKHP bllctdk = new BLL_CTDKHP();
        CTDKHP ctdkhp = new CTDKHP();
        private void ibtndangKi_Click(object sender, EventArgs e)
        {
            
                foreach (ListViewItem item in lstHPDK.Items)
                {
                    try
                    {
                        ctdkhp.maSV = iD;
                        ctdkhp.maHP = item.Text;
                        bllctdk.CTDKHP_Insert(ctdkhp);
                        MessageBox.Show("Hoàn tất đăng kí học phần", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog(iD, "", "DangKiHP", "");
                        dtgCTDKHP.DataSource = bllctdk.CTDKHP_SelectBymaSV(iD);
                }
                    catch
                    {
                    MessageBox.Show("Đăng kí trùng học phần !", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgHP.DataSource = bllhp.HP_SelectBymaHK(cboHK.SelectedValue.ToString());
            
        }
    }
}
