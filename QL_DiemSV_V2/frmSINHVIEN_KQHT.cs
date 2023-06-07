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
    public partial class frmSINHVIEN_KQHT : Form
    {
        public frmSINHVIEN_KQHT()
        {
            InitializeComponent();
        }
        public frmSINHVIEN_KQHT(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        string iD;
        BLL_HOCKY bllhk = new BLL_HOCKY();
        BLL_KQHT bllkqht = new BLL_KQHT();
        BLL_KQHT_HK bllkqhthk = new BLL_KQHT_HK();
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        Writelog wl;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public void HeaderName()
        {
            if (dtgKQHT.Rows.Count > 0)
            {
                dtgKQHT.Columns[0].HeaderText = "Mã SV";
                dtgKQHT.Columns[1].HeaderText = "Mã học phần";
                dtgKQHT.Columns[2].HeaderText = "Tên học phần";
                dtgKQHT.Columns[3].HeaderText = "Lần thi";
                dtgKQHT.Columns[4].HeaderText = "Điểm thi";
                dtgKQHT.Columns[5].HeaderText = "Điểm QT";
                dtgKQHT.Columns[6].HeaderText = "Điểm TB";
                dtgKQHT.Columns[7].HeaderText = "Xếp loại";
                dtgKQHT.Columns[8].HeaderText = "Trạng thái";
            }


        }
        private void frmSINHVIEN_KQHT_Load(object sender, EventArgs e)
        {
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";
            //dtgKQHT.DataSource = bllkqht.KQHT_SelectAll();//Hamf chay chua duowc
            //dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(iD);
            DataTable dtgsinhVien = bllsv.SV_SelectBymaSV(iD);
            HeaderName();

            labmSSV.DataBindings.Clear();
            labmSSV.DataBindings.Add("Text", dtgsinhVien, "maSV");
            labtenSV.DataBindings.Clear();
            labtenSV.DataBindings.Add("Text", dtgsinhVien, "tenSV");
            labgioiTinh.DataBindings.Clear();
            labgioiTinh.DataBindings.Add("Text", dtgsinhVien, "gioiTinh");
            labdiaChi.DataBindings.Clear();
            labdiaChi.DataBindings.Add("Text", dtgsinhVien, "diaChi");
            labdienThoai.DataBindings.Clear();
            labdienThoai.DataBindings.Add("Text", dtgsinhVien, "dienThoai");
            labmaLop.DataBindings.Clear();
            labmaLop.DataBindings.Add("Text", dtgsinhVien, "maLop");
            labngaySinh.DataBindings.Clear();
            labngaySinh.DataBindings.Add("Text", dtgsinhVien, "ngaySinh");

            wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT_HK");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radKQHT_CheckedChanged(object sender, EventArgs e)
        {
            //dtgKQHT.DataSource= bllkqht.KQHT_SelectBymaSV(iD);
            cboHK.Visible = false;
            ibtnxuatExcels.Visible = false;
            dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(iD);

        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV_maHK(iD, cboHK.SelectedValue.ToString());
            Xuly xl = new Xuly();
            double tongdiem = 0;
            int tongTC = 0;

            foreach(DataRow item in bllkqhthk.KQHT_HK_SelectBymaSV_maHK(iD, cboHK.SelectedValue.ToString()).Rows)
            {
                tongdiem += xl.diemSo(Convert.ToDouble(item["diemTB"].ToString()))*Convert.ToDouble(item["soTC"].ToString());
                tongTC += Convert.ToInt32(item["soTC"].ToString());
            }

            if (tongTC == 0)
            {
                labdiemTB.Text = 0.ToString();
                labxepLoai.Text = "Yếu";
            }
            else
            {
                double tb = Math.Round((double)tongdiem / tongTC, 2);
                labdiemTB.Text = tb.ToString();
                labxepLoai.Text = xl.xepLoaiHe4(tb);
            }
            
        }

        private void radKQHTByHK_CheckedChanged(object sender, EventArgs e)
        {
            //cboHK_SelectedIndexChanged(sender, e);
            cboHK.Visible = true;
            ibtnxuatExcels.Visible = true;
        }

        private void dtgKQHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ibtnxuatExcels_Click(object sender, EventArgs e)
        {
            #region(KHỞI TẠO EXCEL)
            //khoi tao Excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khoi tao workBook
            Microsoft.Office.Interop.Excel._Workbook wordbook = app.Workbooks.Add(Type.Missing);
            //Khoi tao wordSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = wordbook.Sheets["Sheet1"];
            app.Visible = true;
            #endregion
            #region(THÔNG TIN SINH VIEN)
            //Dua DL vao worksheet
            worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT HỌC VIÊN";
            worksheet.Cells[3, 5] = "Mã học viên: " + labmSSV.Text;
            worksheet.Cells[4, 5] = "Họ tên: " + labtenSV.Text;
            worksheet.Cells[5, 5] = "Ngày sinh: " + labngaySinh.Text;
            String gt = "";
            
            worksheet.Cells[6, 5] = "Giới tinh: " + labgioiTinh.Text;
            //worksheet.Cells[7, 2] = "Dân tộc: " + txtDanToc.Text;
            worksheet.Cells[7, 5] = "Quê quán: " + labdiaChi.Text;
            //Phần mở đầu
            #endregion
            #region(TẠO KHUNG TABLE BẢNG ĐIỂM)
            worksheet.Cells[10, 1] = "STT: ";
            worksheet.Cells[10, 2] = "Mã số SV: ";
            worksheet.Cells[10, 3] = "Mã môn: ";
            worksheet.Cells[10, 4] = "Tên môn: ";
            worksheet.Cells[10, 5] = "Số TC: ";
            worksheet.Cells[10, 6] = "Lần thi: ";
            worksheet.Cells[10, 7] = "Điểm thi: ";
            worksheet.Cells[10, 8] = "Điểm QT: ";
            worksheet.Cells[10, 9] = "Điểm TB: ";
            worksheet.Cells[10, 10] = "Xếp loại: ";
            worksheet.Cells[10, 11] = "Trạng thái: ";
            //Khung table
            #endregion
            #region(ĐỔ DỮ LIỆU VAO BẢNG)
            DataTable data= bllkqhthk.KQHT_HK_SelectBymaSV_maHK(labmSSV.Text,cboHK.SelectedValue.ToString());                   
            for (int i = 0; i < dtgKQHT.RowCount - 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    worksheet.Cells[i + 11, 1] = i + 1;//cot STT
                    worksheet.Cells[i + 11, j + 2] = dtgKQHT.Rows[i].Cells[j].Value;
                }
            }
            //Đổ DL vào table
            #endregion
            int Mon = dtgKQHT.RowCount;
            worksheet.Cells[Mon + 11, 4] = "Trung bình toàn khóa: " + labdiemTB.Text;
            worksheet.Cells[Mon + 12, 4] = "Xếp loại toàn khóa: " + labxepLoai.Text;
            #region(ĐỊNH DẠNG TRANG)
            //Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            #endregion
            #region(ĐỊNH DẠNG CỘT)
            //Định dạng cột
            worksheet.Range["A1"].ColumnWidth = 8.25;
            worksheet.Range["B1"].ColumnWidth = 28;
            worksheet.Range["C1"].ColumnWidth = 28;
            worksheet.Range["D1"].ColumnWidth = 28;
            worksheet.Range["E1"].ColumnWidth = 15;
            worksheet.Range["F1"].ColumnWidth = 15;
            worksheet.Range["G1"].ColumnWidth = 15;
            worksheet.Range["H1"].ColumnWidth = 15;
            worksheet.Range["I1"].ColumnWidth = 15;
            worksheet.Range["J1"].ColumnWidth = 15;
            worksheet.Range["K1"].ColumnWidth = 30;
            #endregion
            #region(FONT)
            //Định dạng font
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "K100"].Font.Size = 14;
            worksheet.Range["A1", "K1"].MergeCells = true;
            worksheet.Range["A1", "K1"].Font.Bold = true;
            worksheet.Range["A10", "K10"].Font.Bold = true;
            worksheet.Range["I11", "I100"].Font.Color = Color.Red;
            worksheet.Range["I11", "I100"].Font.Bold = true;
            worksheet.Range["K11", "K100"].Font.Color = Color.Red;
            #endregion
            #region(KẺ BẢNG_dỊNH DẠNG CHỮ)
            //Kẻ bảng
            worksheet.Range["A10", "K" + (Mon + 9)].Borders.LineStyle = 1;//9 vì bắt đầu kẻ dòng thứ 10 và kẽ số dong = Mon 
            //Dinh dang text
            worksheet.Range["A1", "K1"].HorizontalAlignment = 3;
            worksheet.Range["A10", "K10"].HorizontalAlignment = 3;
            worksheet.Range["B10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["C10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["D10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["E10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["F10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["G10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["H10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["I10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["J10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            worksheet.Range["K10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["A10", "G" + (Mon + 6)].HorizontalAlignment = 3;
            //Kẻ bảng
            #endregion
            wl = new Writelog(iD, "", "Xuất bảng điểm ra Excel", "");
        }
    }
}
