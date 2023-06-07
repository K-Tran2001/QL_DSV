using FontAwesome.Sharp;
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

namespace QL_DiemSV_V2
{
    public partial class frmMain : Form
    {
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        BLL_TAIKHOAN blltk = new BLL_TAIKHOAN();
        Writelog wl;
        public frmMain()
        {
            InitializeComponent();
        }
        private IconButton currentBtn;
        private Color colorDefault = Color.FromArgb(37, 36, 81);
        public Panel leftBorderBtn=null;
        Form formSelect=new Form();
        
        private Form currentchildForm;
        string iD = "";
        string quyenHan = "";
        public frmMain(string iD)
        {
            this.iD = iD;
            
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(4,52);//Điểm nhấn tô màu đầu thẻ
            pnlformCon.Controls.Add(leftBorderBtn);
        }
        public String doiThu(String thu)
        {
            if (thu == "Monday") return "Thứ hai ";
            else if (thu == "Tuesday") return "Thứ ba";
            else if (thu == "Wednesday") return "Thứ tư";
            else if (thu == "Thursday") return "Thứ năm";
            else if (thu == "Friday") return "Thứ sáu";
            else if (thu == "Saturday") return "Thứ bảy";
            else return "Chủ nhật";
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            //if (senderBtn != null)
            //{
            DisibleButton();
            currentBtn = (IconButton)senderBtn;

            currentBtn.BackColor = colorDefault;//Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            ///border


            leftBorderBtn.BackColor = Color.Red;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

            ///Title formChild
            iconformCon.IconChar = currentBtn.IconChar;
            iconformCon.IconColor = currentBtn.IconColor;
            //}
        }

        private void DisibleButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = colorDefault;//Color.FromArgb(31, 30, 68);//PaleTurquoise;
                currentBtn.ForeColor = Color.PaleTurquoise;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.MistyRose;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form frm)
        {
            pnlformCon.Controls.Clear();
            currentchildForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlformCon.Controls.Add(frm);
            pnlformCon.Tag = frm;
            frm.BringToFront();
            frm.Show();

        }
        private struct RGBClors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(240,230,140);
            public static Color color8 = Color.FromArgb(60, 179, 113);
            public static Color color9 = Color.FromArgb(219, 112, 147);

        }
        public bool QuyenQL()
        {
            if (iD.Equals("AD") || iD.Contains("GV"))
                return true;
            return false;
        }
        
        private void bảoMậtTkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            frmBAOMATTK f = new frmBAOMATTK();
            OpenChildForm(f);
        }

        private void thôngTinHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            if (iD.Equals("AD"))
            {
                frmTTHETHONG f = new frmTTHETHONG();
                OpenChildForm(f);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //frmBAOMATTK f = new frmBAOMATTK();
            //f.ShowDialog();
        }

        private void qLSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmADMIN_QLSV f = new frmADMIN_QLSV(iD);
            formSelect = f;
            timer.Start();
            
           
        }

        private void qLĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmADMIN_QLDIEMSV f = new frmADMIN_QLDIEMSV(iD);
            formSelect = f;
            timer.Start();
            
        }

        private void qLLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmADMIN_QLLOP f = new frmADMIN_QLLOP();
            formSelect = f;
            timer.Start();
            //if (iD.Equals("AD"))
            //{
            //    frmADMIN_QLLOP f = new frmADMIN_QLLOP();
            //    f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void qLGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //timer.Start();
            //timer_Tick(sender, e);
            //if (iD.Equals("AD"))
            //{
            //    frmADMIN_QLGV f = new frmADMIN_QLGV();
            //    f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            frmADMIN_QLGV f = new frmADMIN_QLGV();
            formSelect = f;
            timer.Start();

        }

        private void qLTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //timer.Start();
            //timer_Tick(sender, e);
            //if (iD.Equals("AD"))
            //{
            //    frmADMIN_QLTAIKHOAN f = new frmADMIN_QLTAIKHOAN();
            //    f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            frmADMIN_QLTAIKHOAN f = new frmADMIN_QLTAIKHOAN();
            formSelect = f;
            timer.Start();

        }

        private void đăngKíHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //timer.Start();
            //timer_Tick(sender, e);
            frmSINHVIEN_DKHP f = new frmSINHVIEN_DKHP(iD);
            
            formSelect = f;
            timer.Start();
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //timer.Start();
            //timer_Tick(sender, e);
            if (iD.Contains("DTH"))
            {
                frmSINHVIEN_KQHT f = new frmSINHVIEN_KQHT(iD);
                
                formSelect = f;
                timer.Start();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //timer.Start();
            //timer_Tick(sender, e);
            if (iD.Contains("DTH")|| iD.Contains("GV"))
            {
                frmCAPNHATTT f = new frmCAPNHATTT(iD);
                
                formSelect = f;
                timer.Start();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer_Tick(sender, e);
            ibtntim_Click(sender, e);
        }

        private void qLHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //timer.Start();
            //timer_Tick(sender, e);
            //ibtnmon_Click(sender, e);
            frmADMIN_QLHP f = new frmADMIN_QLHP();
            formSelect = f;
            timer.Start();
        }

        private void chiTiếtCácMônĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSINHVIEN_CTDKHP f = new frmSINHVIEN_CTDKHP(iD);
            
            formSelect = f;
            timer.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            currentBtn = ibtnBDK;
            ibtnBDK_Click(ibtnBDK, e);
            if (iD.Equals(""))
            {
                ibtndangXuat.IconChar = IconChar.SignInAlt;
            }
            else
            {
                ibtndangXuat.IconChar = IconChar.SignOutAlt;
            }
            if (iD.Contains("AD"))//Mau saac de phan biet
            {
                labuserName.Text = "ADMIN";
                labuserName.ForeColor = Color.Red;
                QuyenAD_btn();
            }
            else if(iD.Contains("DTH"))
            {
                DataTable dt =  bllsv.SV_SelectBymaSV(iD);
                labuserName.DataBindings.Clear();
                labuserName.DataBindings.Add("Text", dt, "tenSV");
                labuserName.ForeColor = Color.Green;
                QuyenSV_btn();
            }
            else if(iD.Contains("GV"))
            {
                DataTable dt = bllgv.GV_SelectBymaGV(iD);
                foreach (DataRow r in dt.Rows)
                    labuserName.Text = r[1].ToString();
                labuserName.ForeColor = Color.Blue;
                QuyenGV_btn();
            }
            
            timer1.Start();
            String thu = doiThu(DateTime.Now.DayOfWeek.ToString());
            lab_date.Text = thu + " / " + DateTime.Now.Day + " / " + DateTime.Now.Month + " / " + DateTime.Now.Year;
            //timer1_Tick(sender, e);

        }
        public void QuyenAD_btn()
        {
            ibtnBDK.Enabled = true;
            ibtnbaoCao.Enabled = true;
            ibtnsinhVien.Enabled = true;
            ibtndiem.Enabled = true;
            ibtnmon.Enabled = true;
            ibtndkhp.Visible = false;
            ibtntim.Enabled = true;
            ibtntroGiup.Enabled = true;
            ibtnheThong.Enabled = true;
            
            hệThôngToolStripMenuItem.Visible = true;
            tácVụToolStripMenuItem.Visible = true;
            tìmKiêmToolStripMenuItem.Visible = true;
            sinhvientoolStrip.Visible = false;
            báoCáoToolStripMenuItem.Visible = true;
            trợGiúpToolStripMenuItem.Visible = true;
            giáoViênToolStripMenuItem.Visible = false;
            //bảoMậtTkToolStripMenuItem.Visible = true;
            //đăngXuấtToolStripMenuItem.Visible = true;
            //chủĐềGiaoDiệnToolStripMenuItem.Visible = true;
            //thôngTinHệThốngToolStripMenuItem.Visible = true;
            //backupToolStripMenuItem.Visible = true;
            //restoreToolStripMenuItem.Visible = true;
            //thayĐổiCấuHìnhToolStripMenuItem.Visible = true;
            //qLSinhViênToolStripMenuItem.Visible = true;
            //qLĐiểmToolStripMenuItem.Visible = true;
            //qLLớpToolStripMenuItem.Visible = true;
            //qLGiáoViênToolStripMenuItem.Visible = true;
            //qLTàiKhoảnToolStripMenuItem.Visible = true;
            //qLHọcPhầnToolStripMenuItem.Visible = true;
            //qLGiangrDạyToolStripMenuItem.Visible = true;
            //đăngKíHọcPhầnToolStripMenuItem.Visible = false;
            //xemThôngTinToolStripMenuItem.Visible = false;
            //cậpNhậtThôngTinToolStripMenuItem.Visible = false;
            //chiTiếtCácMônĐăngKíToolStripMenuItem.Visible = false;
            //dSHọcPhầnToolStripMenuItem.Visible = true;
            //dSSinhViênTheoLớpToolStripMenuItem.Visible = true;
            //bảngĐiểmTheoLớpToolStripMenuItem.Enabled = true;
            //bảngĐiểmCủaTừngLớpToolStripMenuItem.Visible = true;


        }
        public void QuyenSV_btn()
        {
            ibtnBDK.Enabled = true;
            ibtnbaoCao.Enabled = false;
            ibtnsinhVien.Enabled = false;
            ibtndiem.Enabled = false;
            ibtnmon.Enabled = false;
            ibtndkhp.Enabled = true;
            ibtntim.Enabled = true;
            ibtntroGiup.Enabled = true;
            ibtnheThong.Enabled = true;

            hệThôngToolStripMenuItem.Visible = true;
            tácVụToolStripMenuItem.Visible = false;
            tìmKiêmToolStripMenuItem.Visible = true;
            sinhvientoolStrip.Visible = true;
            báoCáoToolStripMenuItem.Visible = false;
            trợGiúpToolStripMenuItem.Visible = true;
            giáoViênToolStripMenuItem.Visible = false;

            bảoMậtTkToolStripMenuItem.Visible = true;
            đăngXuấtToolStripMenuItem.Visible = true;
            chủĐềGiaoDiệnToolStripMenuItem.Visible = true;
            thôngTinHệThốngToolStripMenuItem.Visible = false;
            backupToolStripMenuItem.Visible = false;
            restoreToolStripMenuItem.Visible = false;
            thayĐổiCấuHìnhToolStripMenuItem.Visible = false;
            
            //đăngKíHọcPhầnToolStripMenuItem.Visible = true;
            //xemThôngTinToolStripMenuItem.Visible = true;
            //cậpNhậtThôngTinToolStripMenuItem.Visible = true;
            //chiTiếtCácMônĐăngKíToolStripMenuItem.Visible = true;
            //dSHọcPhầnToolStripMenuItem.Visible = false;
            //dSSinhViênTheoLớpToolStripMenuItem.Visible = false;
            //bảngĐiểmTheoLớpToolStripMenuItem.Visible = false;
            //bảngĐiểmCủaTừngLớpToolStripMenuItem.Visible = false;

        }
        public void QuyenGV_btn()
        {
            ibtnBDK.Enabled = true;
            ibtnbaoCao.Enabled = false;
            ibtnsinhVien.Enabled = true;
            ibtndiem.Enabled = true;
            ibtnmon.Enabled = false;
            ibtndkhp.Visible = false;
            ibtntim.Enabled = true;
            ibtntroGiup.Enabled = true;
            ibtnheThong.Enabled = true;

            hệThôngToolStripMenuItem.Visible = true;
            tácVụToolStripMenuItem.Visible = true;
            tìmKiêmToolStripMenuItem.Visible = true;
            sinhvientoolStrip.Visible = false;
            giáoViênToolStripMenuItem.Visible = true;
            báoCáoToolStripMenuItem.Visible = false;
            trợGiúpToolStripMenuItem.Visible = true;
            bảoMậtTkToolStripMenuItem.Visible = true;
            đăngXuấtToolStripMenuItem.Visible = true;
            chủĐềGiaoDiệnToolStripMenuItem.Visible = true;
            thôngTinHệThốngToolStripMenuItem.Visible = false;
            backupToolStripMenuItem.Visible = false;
            restoreToolStripMenuItem.Visible = false;
            thayĐổiCấuHìnhToolStripMenuItem.Visible = false;

            qLSinhViênToolStripMenuItem.Visible = true;
            qLĐiểmToolStripMenuItem.Visible = true;
            qLLớpToolStripMenuItem.Visible = false;
            qLGiáoViênToolStripMenuItem.Visible = false;
            qLTàiKhoảnToolStripMenuItem.Visible = false;
            qLHọcPhầnToolStripMenuItem.Visible = false;
            qLGiangrDạyToolStripMenuItem.Visible = false;

            //qLSinhViênToolStripMenuItem.Visible = true;
            //qLĐiểmToolStripMenuItem.Visible = true;
            //qLLớpToolStripMenuItem.Visible = false;
            //qLGiáoViênToolStripMenuItem.Visible = false;
            //qLTàiKhoảnToolStripMenuItem.Visible = false;
            //qLHọcPhầnToolStripMenuItem.Visible = false;
            //qLGiangrDạyToolStripMenuItem.Visible = false;
            //đăngKíHọcPhầnToolStripMenuItem.Visible = false;
            //xemThôngTinToolStripMenuItem.Visible = true;
            //cậpNhậtThôngTinToolStripMenuItem.Visible = true;
            //chiTiếtCácMônĐăngKíToolStripMenuItem.Visible = false;
            //dSHọcPhầnToolStripMenuItem.Visible = false;
            //dSSinhViênTheoLớpToolStripMenuItem.Visible = true;
            //bảngĐiểmTheoLớpToolStripMenuItem.Visible = true;
            //bảngĐiểmCủaTừngLớpToolStripMenuItem.Visible = false;

        }
        public void Guest_btn()
        {
            ibtnBDK.Enabled = true;
            ibtnbaoCao.Enabled = false;
            ibtnsinhVien.Enabled = false;
            ibtndiem.Enabled = false;
            ibtnmon.Enabled = false;
            ibtndkhp.Enabled = false;
            ibtntim.Enabled = false;
            ibtntroGiup.Enabled = false;
            ibtnheThong.Enabled = false;

            hệThôngToolStripMenuItem.Visible = false;
            tácVụToolStripMenuItem.Visible = false;
            tìmKiêmToolStripMenuItem.Visible = false;
            sinhvientoolStrip.Visible = false;
            báoCáoToolStripMenuItem.Visible = false;
            trợGiúpToolStripMenuItem.Visible = false;
            giáoViênToolStripMenuItem.Visible = false;
            //bảoMậtTkToolStripMenuItem.Visible = false;
            //đăngXuấtToolStripMenuItem.Visible = false;
            //chủĐềGiaoDiệnToolStripMenuItem.Visible = false;
            //thôngTinHệThốngToolStripMenuItem.Visible = false;
            //tìmKiêmToolStripMenuItem.Visible = false;
            //backupToolStripMenuItem.Visible = false;
            //restoreToolStripMenuItem.Visible = false;
            //thayĐổiCấuHìnhToolStripMenuItem.Visible = false;
            //qLSinhViênToolStripMenuItem.Visible = false;
            //qLĐiểmToolStripMenuItem.Visible = false;
            //qLLớpToolStripMenuItem.Visible = false;
            //qLGiáoViênToolStripMenuItem.Visible = false;
            //qLTàiKhoảnToolStripMenuItem.Visible = false;
            //qLHọcPhầnToolStripMenuItem.Visible = false;
            //qLGiangrDạyToolStripMenuItem.Visible = false;
            //đăngKíHọcPhầnToolStripMenuItem.Visible = false;
            //xemThôngTinToolStripMenuItem.Visible = false;
            //cậpNhậtThôngTinToolStripMenuItem.Visible = false;
            //chiTiếtCácMônĐăngKíToolStripMenuItem.Visible = false;
            //dSHọcPhầnToolStripMenuItem.Visible = false;
            //dSSinhViênTheoLớpToolStripMenuItem.Visible = false;
            //bảngĐiểmTheoLớpToolStripMenuItem.Visible = false;
            //bảngĐiểmCủaTừngLớpToolStripMenuItem.Visible = false;
        }
        public bool QuyenQL_frm()
        {
            if (iD.Equals("AD") || iD.Contains("GV"))
                return true;
            return false;
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void qLGiangrDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //if (iD.Equals("AD"))
            //{
            //    frmADMIN_QLGIANGDAY f = new frmADMIN_QLGIANGDAY();
            //    OpenChildForm(f);
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            frmADMIN_QLGIANGDAY f = new frmADMIN_QLGIANGDAY();
            formSelect = f;
            timer.Start();

        }

        
        private void timer_Tick_1(object sender, EventArgs e,Form frm)
        {
            timer.Start();
            //pgQT.PerformStep();
            if (pgQT.Value >= 100)
            {
                timer.Stop();
                pgQT.Value = 0;  
                frm.ShowDialog();
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            pgQT.PerformStep();
            if (pgQT.Value >= 100)
            {
                timer.Stop();
                pgQT.Value = 0;

                OpenChildForm(formSelect);
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain_Load(sender, e);
            //frmDANGNHAP f = new frmDANGNHAP();
            ////this.Hide();
            //OpenChildForm(f);
            ibtndangXuat_Click(sender, e);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            if (iD.Equals("AD"))
            {
                frmBackupRestorecs f = new frmBackupRestorecs();
                //this.Hide();
                OpenChildForm(f);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            if (iD.Equals("AD"))
            {
                frmBackupRestorecs f = new frmBackupRestorecs();
                //this.Hide();
                OpenChildForm(f);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void tìmKiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            frmTIMKIEM f = new frmTIMKIEM(iD);
            OpenChildForm(f);
        }

        private void toggle_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlmenu_Resize(object sender, EventArgs e)
        {
            
        }

        private void ibtnBDK_Click(object sender, EventArgs e)
        {
            pnlformCon.Controls.Clear();
            ActivateButton(sender, RGBClors.color9);
            labtieuDe.Text = ibtnBDK.Text;

            frmBangDieuKhien f = new frmBangDieuKhien();
            OpenChildForm(f);
        }

        private void ibtnsinhVien_Click(object sender, EventArgs e)
        {
            //timer.Start();
            pnlformCon.Controls.Clear();
            ActivateButton(sender, RGBClors.color1);
            labtieuDe.Text = ibtnsinhVien.Text;

            frmADMIN_QLSV f = new frmADMIN_QLSV(iD);
            OpenChildForm(f);


        }

        private void ibtnmon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color2);
            pnlformCon.Controls.Clear();
            labtieuDe.Text = ibtnmon.Text;

            frmADMIN_QLHP f = new frmADMIN_QLHP();
            OpenChildForm(f);
        }

        private void ibtndiem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color3);
            pnlformCon.Controls.Clear();
            labtieuDe.Text = ibtndiem.Text;

            frmADMIN_QLDIEMSV f = new frmADMIN_QLDIEMSV(iD);
            OpenChildForm(f);
        }

        private void ibtndkhp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color4);
            pnlformCon.Controls.Clear();
            labtieuDe.Text = ibtndkhp.Text;

            frmSINHVIEN_DKHP f = new frmSINHVIEN_DKHP(iD);
            OpenChildForm(f);
        }

        private void ibtntim_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color5);
            pnlformCon.Controls.Clear();
            labtieuDe.Text = ibtntim.Text;

            frmTIMKIEM f = new frmTIMKIEM(iD);
            OpenChildForm(f);
        }

        private void ibtnbaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color6);
            pnlformCon.Controls.Clear();
            labtieuDe.Text = ibtnbaoCao.Text;

            frmBaoCao f = new frmBaoCao();
            OpenChildForm(f);
        }

        private void ibtntroGiup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color7);
            
            Help.ShowHelp(pnlformCon, @"PowerCHM.chm");
            

        }

        private void ibtnheThong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClors.color8);
            pnlformCon.Controls.Clear();
            labtieuDe.Text = ibtnbaoCao.Text;

            frmHETHONG f = new frmHETHONG(iD);
            OpenChildForm(f);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_time.Text = "Giờ hiện tại: " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void dSHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            if (iD.Equals("AD"))
            {
                frmBaoCaoList f = new frmBaoCaoList();
                OpenChildForm(f);
            }
            
        }

        private void dSSinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            if (QuyenQL())
            {
                frmBaoCao f = new frmBaoCao();
                OpenChildForm(f);
            }
        }

        private void bảngĐiểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            frmBaoCaoGroup f = new frmBaoCaoGroup();
            OpenChildForm(f);   
        }

        private void bảngĐiểmCủaTừngLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            frmBaoCaoMaster f = new frmBaoCaoMaster();
            OpenChildForm(f);
        }

        private void thayĐổiCấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            frmKetNoi f = new frmKetNoi(2);
            OpenChildForm(f);
            //sau khi câu hình xong .. xuat thông bao yeu cau khoi dộng lại
            //sau khi khoi dong lai=> =dang nhap bt
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(pnlformCon, @"C:\Users\Admin\source\repos\QL_DiemSV_V2\PowerCHM\PowerCHM.chm");
        }

        private void ibtndangXuat_Click(object sender, EventArgs e)
        {
            if (ibtndangXuat.IconChar == IconChar.SignInAlt)
            {
                frmDANGNHAP f = new frmDANGNHAP();
                f.Show();
                this.Hide();
                
            }
            else
            {
                DialogResult lenh = MessageBox.Show("Ban co thưc sự muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (lenh == DialogResult.Yes)
                {
                    iD = "";
                    labuserName.Text = "Guest";
                    ibtndangXuat.IconChar = IconChar.SignInAlt;
                    wl = new Writelog(iD, "", "Đăng xuất", "");
                    //tắt hết các btn
                    Guest_btn();
                    pnlformCon.Controls.Clear();
                    ibtnBDK_Click(sender, e);
                }
            }
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGIAOVIEN_CTGD f = new frmGIAOVIEN_CTGD(iD);
            formSelect = f;
            timer.Start();
        }

        private void chủĐềGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color =new ColorDialog();
            color.ShowDialog();
            colorDefault = color.Color;
            ibtnBDK.BackColor = colorDefault;
            ibtnsinhVien.BackColor = colorDefault;
            ibtndiem.BackColor = colorDefault;
            ibtnmon.BackColor = colorDefault;
            ibtntim.BackColor = colorDefault;
            ibtndkhp.BackColor = colorDefault;
            ibtntroGiup.BackColor = colorDefault;
            ibtnbaoCao.BackColor = colorDefault;
            ibtnheThong.BackColor = colorDefault;
            pnltitle.BackColor = colorDefault;
            pnlmenu.BackColor = colorDefault;

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                colorDefault = Color.FromArgb(37, 36, 81);
                ibtnBDK.BackColor = colorDefault;
                ibtnsinhVien.BackColor = colorDefault;
                ibtndiem.BackColor = colorDefault;
                ibtnmon.BackColor = colorDefault;
                ibtntim.BackColor = colorDefault;
                ibtndkhp.BackColor = colorDefault;
                ibtntroGiup.BackColor = colorDefault;
                ibtnbaoCao.BackColor = colorDefault;
                ibtnheThong.BackColor = colorDefault;
                pnltitle.BackColor = colorDefault;
                pnlmenu.BackColor = colorDefault;
                frmMain_Load(sender, e);
            }
                
        }

        private void tácVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchSửThaoTácToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
