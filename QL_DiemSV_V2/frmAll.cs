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
using DAL;
namespace QL_DiemSV_V2
{
    public partial class frmAll : Form
    {
        public frmAll()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmSINHVIEN_CTDKHP f = new frmSINHVIEN_CTDKHP("DTH195287");
            f.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frmSINHVIEN_KQHT f = new frmSINHVIEN_KQHT("DTH195287");
            f.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            frmSINHVIEN_DKHP f = new frmSINHVIEN_DKHP("DTH195287");
            f.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            frmGIAOVIEN_CTGD f = new frmGIAOVIEN_CTGD("GV002");
            f.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmADMIN_QLSV f = new frmADMIN_QLSV();
            f.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmADMIN_QLHP f = new frmADMIN_QLHP();
            f.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            frmADMIN_QLGV f = new frmADMIN_QLGV();
            f.Show();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            frmADMIN_QLGIANGDAY f = new frmADMIN_QLGIANGDAY();
            f.Show();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            frmADMIN_QLTAIKHOAN f = new frmADMIN_QLTAIKHOAN();
            f.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            frmADMIN_QLDIEMSV f = new frmADMIN_QLDIEMSV();
            f.Show();
        }
        BLL_HOCPHAN bllhp = new BLL_HOCPHAN();
        HOCPHAN hp = new HOCPHAN();
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        BLL_TAIKHOAN blltk = new BLL_TAIKHOAN();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        TAIKHOAN tk = new TAIKHOAN();
        SQL_TAIKHOAN sqltk = new SQL_TAIKHOAN();
        BLL_CTDKHP bllctdk = new BLL_CTDKHP();
        CTDKHP ctdk = new CTDKHP();
        BLL_HOCKY bllhk = new BLL_HOCKY();
        BLL_DKHP blldkhp = new BLL_DKHP();
        DKHP dkhp = new DKHP();
        private void iconButton9_Click(object sender, EventArgs e)
        {
            //hp.maHP = "COSxxx";
            //hp.tenHP = "Test";
            //hp.soTC = 3;
            //hp.maHK = "HK3";
            //bllhp.HP_Insert(hp);
            //DataTable dt = bllgv.GV_SelectAll();

            //foreach (DataRow item in dt.Rows )
            //{
            //    tk = new TAIKHOAN();
            //    tk.matKhau = "123"; tk.loaiTaiKhoan = "GV";
            //    tk.taiKhoan = item["maGV"].ToString();
            //    tk.tenTaiKhoan = item["tenGV"].ToString();
            //    blltk.TK_Insert(tk);
            //}
            //tk.taiKhoan = "DTH195287";
            //tk.matKhau = "123";
            //tk.tenTaiKhoan = "Khoa trần";
            //tk.loaiTaiKhoan = "VIP";
            //blltk.TK_Update(tk);

            //ctdk.maSV = "DTH195287";ctdk.maHP = "COS107";
            //bllctdk.CTDKHP_Insert(ctdk);
            //ctdk.maSV = "DTH195287"; ctdk.maHP = "COS104";
            //bllctdk.CTDKHP_Insert(ctdk);
            //ctdk.maSV = "DTH195287"; ctdk.maHP = "COS302";
            //bllctdk.CTDKHP_Insert(ctdk);

            //foreach(DataRow r_sv in bllsv.SV_SelectAll().Rows)
            //{
            //    //insert data
            //    foreach(DataRow r_hk in bllhk.HK_SelectAll().Rows)
            //    {
            //        dkhp.maSV = r_sv["maSV"].ToString();
            //        dkhp.maHK = r_hk["maHK"].ToString();
            //        dkhp.tongTC = 0;
            //        blldkhp.DKHP_Insert(dkhp);
            //    }
            //}

            //DataProvider dt = new DataProvider();
            ////dt.ExcuteNoneQuery("insert into HOCPHAN values('COS888','Test888',3,'HK1')", new object[] { "" });
            //dt.ExcuteNoneQuery("insert into SINHVIEN values ('DTH7777777','Trannnnnnnnn','Nam','2/2/2001','123','AG','DH20TH1')");//1 bien ỏ 2 bien deu duoc
            frmCAPNHATTT f = new frmCAPNHATTT();
            f.Show();
        }

        private void frmAll_Load(object sender, EventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            frmTIMKIEM f = new frmTIMKIEM();
            f.Show();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            frmADMIN_QLLOP f = new frmADMIN_QLLOP();
            f.Show();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            frmBAOMATTK f = new frmBAOMATTK();
            f.Show();
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            frmCAPNHATTT f = new frmCAPNHATTT();
            f.Show();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            //Code phuc hoi
            //string maSV = "kkkkk";
            //string sqlthucthi = "delete from SINHVIEN where maSV='" + maSV + "'";
            //DataProvider dt = new DataProvider();
            //dt.ExcuteNoneQuery(sqlthucthi, new object[] { "" });
            //string sqlthucthi = "insert into HOCPHAN values ('COSkkk','Test',4,'HK2')";

            //string sqlphuchoi = "update  HOCPHAN set tenHP='Khoa',soTC=10,maHK='HK3' where maHP='COSkkk' ";
            //DataProvider dt = new DataProvider();
            //dt.ExcuteNoneQuery(sqlphuchoi, new object[] { "" });
            DataProvider dt = new DataProvider();
            DataTable data = blltk.TK_SelectAll();
            foreach(DataRow r in data.Rows)
            {
                    dt.ExcuteNoneQuery("update TAIKHOAN set  matKhau='202cb962ac59075b964b07152d234b70' where taiKhoan='"+r[0].ToString()+"'", new object[] { "" });
            }
            
            
        }
    }
}
