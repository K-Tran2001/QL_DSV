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
    public partial class frmADMIN_QLDIEMSV : Form
    {
        
        string iD;
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN() ;
        BLL_LOP blllop = new BLL_LOP();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        BLL_HOCKY bllhk= new BLL_HOCKY ();
        BLL_KQHT_HK bllkqhthk = new BLL_KQHT_HK();
        KQHT_HK kq =new KQHT_HK();
        Writelog wl;
        
        public frmADMIN_QLDIEMSV()
        {
            InitializeComponent();
        }
        public frmADMIN_QLDIEMSV(string iD)
        {
            
            this.iD = iD;
            InitializeComponent();
        }
        int i = 0, j = 0;
        
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeSV_Lop.Nodes.Clear();
            labmaLop.Text = cboLop.Text;
            foreach (DataRow r in bllsv.SV_SelectBymaLop(cboLop.SelectedValue.ToString()).Rows)
            {
                TreeNode node = new TreeNode();
                node.Name = r["maSV"].ToString();
                node.Text = r["tenSV"].ToString();

                treeSV_Lop.Nodes.Add(node);
            }
            treeSV_Lop.ExpandAll();

        }
       
        private void frmADMIN_QLDIEMSV_Load(object sender, EventArgs e)
        {
            
            this.KeyPreview = true;
            LoadData();
        }
        public void HeaderName()
        {
            if (_dtgKQHT.Rows.Count > 0)
            {
                _dtgKQHT.Columns[0].HeaderText = "Mã SV";
                _dtgKQHT.Columns[1].HeaderText = "Mã học phần";
                _dtgKQHT.Columns[2].HeaderText = "Tên học phần";
                _dtgKQHT.Columns[3].HeaderText = "Lần thi";
                _dtgKQHT.Columns[4].HeaderText = "Điểm thi";
                _dtgKQHT.Columns[5].HeaderText = "Điểm QT";
                _dtgKQHT.Columns[6].HeaderText = "Điểm TB";
                _dtgKQHT.Columns[7].HeaderText = "Xếp loại";
                _dtgKQHT.Columns[8].HeaderText = "Trạng thái";
            }
           

        }
        public void LoadData()
        {
            
            DataTable   dtgsinhVien = bllsv.SV_SelectBymaSV(labmSSV.Text);
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

            if (iD.Contains("AD"))
            {
                cboLop.DataSource = blllop.LOP_SelectAll();
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            else if(iD.Contains("GV"))
            {
                cboLop.DataSource = bllgv.GV_SelectmaLopBymaGV(iD);
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";

            //If(iD contains "GV..."")
            //cboLop.DataSource = bllgv.GVSelectmaLopBymaGV();
            //cboLop.DisplayMember = "tenLop";
            //cboLop.ValueMember = "maLop";
            wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT");
        }

        private void treeSV_Lop_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (DataRow s in bllsv.SV_SelectBymaSV(e.Node.Name).Rows)//nhay tt
            {
                labmSSV.Text = e.Node.Name;
                labtenSV.Text = e.Node.Text;
                labgioiTinh.Text = s["gioiTinh"].ToString();
                labdiaChi.Text = s["diaChi"].ToString();
                labngaySinh.Text = s["ngaySinh"].ToString();
                labdienThoai.Text = s["dienThoai"].ToString();
                labmaLop.Text = cboLop.Text;

            }
            _dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(e.Node.Name);
            HeaderName();

        }
        
        private void ibtnallDiem_Click(object sender, EventArgs e)
        {
            //dtgKQHT.DataSource = bllkq.KQHT_SelectBymaSV(labmSSV.Text);
            
            ibtnxuatExcel.Visible = false;
            labdiemTB.Text = "...";labxepLoai.Text = "...";
            DataTable table = bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);

            _dtgKQHT.DataSource = table;//bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ibtnxuatExcel.Visible = true;
            Xuly xl = new Xuly();
            _dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV_maHK(labmSSV.Text, cboHK.SelectedValue.ToString());
            int tongTC = 0;Double diemTong = 0;
            foreach(DataRow r in bllkqhthk.KQHT_HK_SelectBymaSV_maHK(labmSSV.Text, cboHK.SelectedValue.ToString()).Rows)
            {
                diemTong += xl.diemSo(Convert.ToDouble(r["diemTB"].ToString()))*Convert.ToInt32(r["soTC"].ToString());
                tongTC+= Convert.ToInt32(r["soTC"].ToString());               
            }
            if (diemTong !=0)
            {
                
                labdiemTB.Text = Math.Round((diemTong / tongTC), 2).ToString();
                labxepLoai.Text = xl.xepLoaiHe4(Math.Round((diemTong / tongTC), 2));
            }
            else
            {
                labdiemTB.Text = "0";
                labxepLoai.Text= "Yếu";
            }
        }
        public void nhapdiemThi(int lanthi)
        {
            Xuly xldiem = new Xuly();
            try
            {
                int i = _dtgKQHT.CurrentCell.RowIndex;
                double d1 = Convert.ToDouble(_dtgKQHT.Rows[i].Cells["diemThi"].Value);
                if (d1 >= 0 && d1 <= 100)
                {
                    if (d1 > 10)
                    {
                        d1 = d1 / 10;
                        _dtgKQHT.Rows[i].Cells["diemThi"].Value = d1;
                    }
                    kq.maSV = _dtgKQHT.Rows[i].Cells["maSV"].Value.ToString();
                    kq.maHP = _dtgKQHT.Rows[i].Cells["maHP"].Value.ToString();
                    kq.lanThi = lanthi;
                    kq.diemThi = (double)d1;
                    kq.diemQT = Convert.ToDouble(_dtgKQHT.Rows[i].Cells["diemQT"].Value.ToString());
                    kq.diemTB = Math.Round((kq.diemThi + kq.diemQT) / 2,1);
                    kq.xepLoai = xldiem.diemChu(kq.diemTB);
                    kq.trangThai = xldiem.trangThai(kq.diemTB);
                    bllkqhthk.KQHT_HK_Update(kq);
                    if(lanthi==1)
                        wl = new Writelog(iD, "KQHT_HK", "Nhập điểm thi", "dtgKQHT");
                    else
                        wl = new Writelog(iD, "KQHT_HK", "Sửa điểm thi", "dtgKQHT");
                    MessageBox.Show("Lưu điểm thành công", "Thông báo");
                    _dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);
                }
                else
                {
                    MessageBox.Show("Bạn chỉ nhập điểm từ 0-> 100,Vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _dtgKQHT.Rows[i].Cells["diemThi"].Value = "";
                }
            }
            catch
            {
                MessageBox.Show("Thao tác lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void nhapdiemQT()
        {
            Xuly xldiem = new Xuly();
            try
            {
                int i = _dtgKQHT.CurrentCell.RowIndex;
                double d1 = Convert.ToDouble(_dtgKQHT.Rows[i].Cells["diemQT"].Value);
                if (d1 >= 0 && d1 <= 100)
                {
                    if (d1 > 10)
                    {
                        d1 = d1 / 10;
                        _dtgKQHT.Rows[i].Cells["diemQT"].Value = d1;
                    }
                    kq.maSV = _dtgKQHT.Rows[i].Cells["maSV"].Value.ToString();
                    kq.maHP = _dtgKQHT.Rows[i].Cells["maHP"].Value.ToString();
                    kq.lanThi = Convert.ToInt32(_dtgKQHT.Rows[i].Cells["lanThi"].Value.ToString());
                    kq.diemThi = Convert.ToDouble(_dtgKQHT.Rows[i].Cells["diemThi"].Value.ToString());
                    kq.diemQT = (double)d1;
                    kq.diemTB = Math.Round((kq.diemThi + kq.diemQT)/2, 1);
                    kq.xepLoai = xldiem.diemChu(kq.diemTB);
                    kq.trangThai = xldiem.trangThai(kq.diemTB);
                    bllkqhthk.KQHT_HK_Update(kq);
                    wl = new Writelog(iD, "KQHT_HK", "Nhập điểm quá trình ", "dtgKQHT");
                    MessageBox.Show("Lưu điểm thành công", "Thông báo");
                    _dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);
                }
                else
                {
                    MessageBox.Show("Bạn chỉ nhập điểm từ 0-> 100,Vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _dtgKQHT.Rows[i].Cells["diem"].Value = "";
                }
            }
            catch
            {
                MessageBox.Show("Thao tác lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (j == 5)//=>diem thi
            {
                if (Convert.ToInt32(_dtgKQHT.Rows[i].Cells[j - 1].Value) == 0)//sua diem & thi lan 1
                {
                    nhapdiemThi(1);
                }
                else if(Convert.ToInt32(_dtgKQHT.Rows[i].Cells[j - 1].Value) == 1)//sua diem & thi lan 2
                {
                    nhapdiemThi(2);
                }
                else
                {
                    MessageBox.Show("Điểm thi dược sửa tối đa 1 lần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//diemQT+diemTB
            {
                nhapdiemQT();
            }
            
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {

            int i = _dtgKQHT.CurrentCell.RowIndex;
            kq.maSV = _dtgKQHT.Rows[i].Cells["maSV"].Value.ToString();
            kq.maHP = _dtgKQHT.Rows[i].Cells["maHP"].Value.ToString();
            kq.lanThi = 0;
            kq.diemThi = 0;
            kq.diemQT = 0;
            kq.diemTB = 0;
            kq.xepLoai = "F";
            kq.trangThai = "Rớt môn";
            
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa điểm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bllkqhthk.KQHT_HK_Update(kq);
                MessageBox.Show("Xóa điểm thành công", "");
                _dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);
                wl = new Writelog(iD, "KQHT_HK", "Xóa điểm", "dtgKQHT");
            }

        }

        private void ibtnXoaThanhTich_Click(object sender, EventArgs e)
        {
            int i = _dtgKQHT.CurrentCell.RowIndex;


            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa điểm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable dt = bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);
                foreach (DataRow item in dt.Rows)
                {
                    kq.maSV = item["maSV"].ToString();
                    kq.maHP = item["maHP"].ToString();
                    kq.lanThi = 0;
                    kq.diemThi = 0;
                    kq.diemQT = 0;
                    kq.diemTB = 0;
                    kq.xepLoai = "F";
                    kq.trangThai = "Rớt môn";
                    bllkqhthk.KQHT_HK_Update(kq);
                }
                MessageBox.Show("Xóa thành tich thành công", "");
                _dtgKQHT.DataSource = bllkqhthk.KQHT_HK_SelectBymaSV(labmSSV.Text);
                wl = new Writelog("AD", "KQHT_HK", "Xóa thành tích", "dtgKQHT");
            }
        }

        private void dtgKQHT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmADMIN_QLDIEMSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtnLuu.PerformClick();

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)//e.Modifiers == Keys.Control&&e.KeyCode==Keys.Space
            {
                ibtnallDiem.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ibtnxuatExcel.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                ibtnXoa.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                ibtnXoaThanhTich.PerformClick();

            }


        }

        private void frmADMIN_QLDIEMSV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ibtnXoa_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                ibtnLuu_Click(sender, e);
            }
        }

        private void _dtgKQHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = _dtgKQHT.CurrentCell.RowIndex;//
            j = _dtgKQHT.CurrentCell.ColumnIndex;//=> biến toàn cục
            
            
        }

        private void ibtnxuatExcel_Click(object sender, EventArgs e)
        {
            //Fix logic
            if (cboLop.SelectedItem.ToString() != "")
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
                DataTable datalop = blllop.LOP_SelectmaLop(cboLop.SelectedValue.ToString());
                //Dua DL vao worksheet
                worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT HỌC VIÊN LỚP " + cboLop.Text;
                worksheet.Cells[3, 2] = "Mã lớp: " + cboLop.SelectedValue.ToString();
                //worksheet.Cells[4, 2] = "Khóa học " + txtkhoaHoc.Text;
                worksheet.Cells[5, 2] = "Chủ nhiệm: " + datalop.Rows[0]["maCN"].ToString();//Xư li thanh ten chu nhiem
                worksheet.Cells[6, 2] = "Ngày khai giảng: " + datalop.Rows[0]["ngayKhaiGiang"].ToString();

                //Phần mở đầu
                #endregion
                #region(TẠO KHUNG TABLE BẢNG ĐIỂM)
                worksheet.Cells[10, 1] = "STT: ";
                worksheet.Cells[10, 2] = "Mã học viên: ";
                worksheet.Cells[10, 3] = "Mã học phần: ";
                worksheet.Cells[10, 4] = "Tên học phần: ";
                worksheet.Cells[10, 5] = "Số tín chỉ: ";
                worksheet.Cells[10, 6] = "Lần thi: ";
                worksheet.Cells[10, 7] = "Điểm thi: ";
                worksheet.Cells[10, 8] = "Điểm QT: ";
                worksheet.Cells[10, 9] = "Điểm TB: ";
                worksheet.Cells[10, 10] = "Xếp loại: ";
                worksheet.Cells[10, 11] = "Trạng thái: ";
                worksheet.Cells[10, 12] = "Đậu / Rớt: ";


                //Khung table
                #endregion

                #region(ĐỔ DỮ LIỆU VAO BẢNG)
                //Đổ Dl
                DataTable datasv_lop = bllsv.SV_SelectBymaLop(cboLop.SelectedValue.ToString());
                DataTable datakq_sv;
                /*
                 for (int i = 0; i < dtgKQHT.RowCount - 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    worksheet.Cells[i + 11, 1] = i + 1;//cot STT
                    worksheet.Cells[i + 11, j + 2] = dtgKQHT.Rows[i].Cells[j].Value;
                }
            }
                 */
                DataTable data = bllkqhthk.KQHT_HK_SelectBymaLop_maHK(cboLop.SelectedValue.ToString(), cboHK.SelectedValue.ToString());
                for (int i = 0; i < data.Rows.Count; i++)
                {

                    for (int j = 0; j < 10; j++)
                    {
                        worksheet.Cells[i + 11, 1] = i + 1;//cot STT
                        worksheet.Cells[i + 11, j + 2] = data.Rows[i][j].ToString();
                    }
                }

                //for (int i = 0; i < data.Rows.Count - 1; i++)
                //{
                //    for (int j = 0; j < 10; j++)
                //    {
                //        worksheet.Cells[i + 11, 1] = i + 1;//cot STT
                //        worksheet.Cells[i + 11, j + 2] = data.Rows[i][j].ToString();
                //    }
                //}
                //Đổ DL vào table
                #endregion
                //Tính đậu rớt
                int dau = 0; int r_trangThai = 10;
                int tongSoDong = 3;
                datasv_lop = bllsv.SV_SelectBymaLop(cboLop.SelectedValue.ToString());
                for (int i = 0; i < datasv_lop.Rows.Count; i++)//Ds hoc vien
                {
                    Double tb = 0;
                    double tong = 0; int soTinChi = 0;
                    Xuly xuly = new Xuly();
                    int mon = 0;
                    //X? ly nâng cao
                    datakq_sv = bllkqhthk.KQHT_HK_SelectBymaSV_maHK(datasv_lop.Rows[i]["maSV"].ToString(), cboHK.SelectedValue.ToString());//Tinh TB và dau rot theo HK
                    for (int j = 0; j < datakq_sv.Rows.Count; j++)//Tìm 1 di?m cho m?i môn/Sinh viên duyet (n môn)
                    {
                        try
                        {
                            tong += xuly.diemSo(Convert.ToDouble(datakq_sv.Rows[j]["diemTB"].ToString())) * Convert.ToDouble(datakq_sv.Rows[j]["soTC"].ToString());//X? ly nâng cao    
                            soTinChi += Convert.ToInt32(datakq_sv.Rows[j]["soTC"].ToString());
                            mon++;
                            tongSoDong++;
                        }
                        catch
                        {

                        }
                    }
                    tb = Math.Round(tong / soTinChi, 2);//làm tròn L?y 2 s? th?p phân

                    r_trangThai += mon;

                    try
                    {
                        if (tb == 0)
                        {
                            r_trangThai++;
                            worksheet.Cells[r_trangThai, 12] = tb + "_Rớt";
                        }
                        else if (tb > 1)//setup nguong TBTC de dau
                        {
                            dau++;
                            worksheet.Cells[r_trangThai, 12] = tb + "_Đậu";
                        }
                        else if (tb <= 1)
                        {
                            worksheet.Cells[r_trangThai, 12] = tb + "_Rớt";
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                /////////////

                int tongHV = bllsv.SV_SelectBymaLop(cboLop.SelectedValue.ToString()).Rows.Count;
                //dtgKQHT.RowCount;
                double tiLeDau = (((double)dau / (tongHV)) * 100); tiLeDau = Math.Round(tiLeDau, 2);
                double tiLeRot = 100 - tiLeDau;
                worksheet.Cells[tongSoDong + 11, 1] = "Số lượng đậu : " + dau.ToString() + " \tchiếm tỉ lệ " + tiLeDau.ToString() + " %";
                worksheet.Cells[tongSoDong + 12, 1] = "Số lượng rớt: " + (tongHV - dau).ToString() + " \tchiếm tỉ lệ " + tiLeRot.ToString() + " %";

                //#region(ĐỊNH DẠNG TRANG)
                ////Định dạng trang
                //worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                //worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                //worksheet.PageSetup.LeftMargin = 0;
                //worksheet.PageSetup.RightMargin = 0;
                //worksheet.PageSetup.TopMargin = 0;
                //worksheet.PageSetup.BottomMargin = 0;
                //#endregion

                //#region(ĐỊNH DẠNG CỘT)
                ////Định dạng cột
                //worksheet.Range["A1"].ColumnWidth = 8.25;
                //worksheet.Range["B1"].ColumnWidth = 25;
                //worksheet.Range["C1"].ColumnWidth = 28;
                //worksheet.Range["D1"].ColumnWidth = 24;
                //worksheet.Range["E1"].ColumnWidth = 10;
                //worksheet.Range["F1"].ColumnWidth = 15;
                //worksheet.Range["G1"].ColumnWidth = 15;
                //worksheet.Range["H1"].ColumnWidth = 15;
                //worksheet.Range["I1"].ColumnWidth = 15;
                //worksheet.Range["J1"].ColumnWidth = 15;
                //worksheet.Range["K1"].ColumnWidth = 15;
                //worksheet.Range["L1"].ColumnWidth = 15;
                //#endregion
                //#region(FONT)
                ////Định dạng font
                //worksheet.Range["A1", "L100"].Font.Name = "Times New Roman";
                //worksheet.Range["A1", "L100"].Font.Size = 14;
                //worksheet.Range["A1", "L1"].MergeCells = true;
                //worksheet.Range["A1", "L1"].Font.Bold = true;
                //worksheet.Range["A10", "L10"].Font.Bold = true;
                //worksheet.Range["G11", "L100"].Font.Color = Color.Red;
                //#endregion
                //#region(KẺ BẢNG_dỊNH DẠNG CHỮ)
                ////Kẻ bảng
                //worksheet.Range["A10", "G" + (tongSoDong + 9)].Borders.LineStyle = 1;//9 vì bắt đầu kẻ dòng thứ 10 và kẽ số dong = Mon 
                //                                                                     //Dinh dang text
                //worksheet.Range["A1", "L1"].HorizontalAlignment = 3;
                //worksheet.Range["A10", "L10"].HorizontalAlignment = 3;
                //worksheet.Range["B10", "A" + (tongSoDong + 9)].HorizontalAlignment = 3;
                //worksheet.Range["C10", "L" + (tongSoDong + 9)].HorizontalAlignment = 3;
                //worksheet.Range["D10", "A" + (tongSoDong + 9)].HorizontalAlignment = 3;
                //worksheet.Range["E10", "A" + (tongSoDong + 9)].HorizontalAlignment = 3;
                //worksheet.Range["F10", "A" + (tongSoDong + 9)].HorizontalAlignment = 3;
                ////worksheet.Range["G10", "A" + (tongSoDong + 9)].HorizontalAlignment = 3;
                ////worksheet.Range["A10", "G" + (Mon + 6)].HorizontalAlignment = 3;
                ////Kẻ bảng
                //#endregion
                wl = new Writelog(iD, "", "Xuất bảng điểm ra Excel", "");

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất sang Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgKQHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
         i = dtgKQHT.CurrentCell.RowIndex;//
             j = dtgKQHT.CurrentCell.ColumnIndex;//=> biến toàn cục
            labi.Text = i.ToString(); labj.Text = j.ToString();
            labdiem.Text = dtgKQHT.Rows[i].Cells[j].Value.ToString();//xacs ddinhj trang thais
            //kiểm tra cell có ==0 ko? nếu ==0=> themDiem=1=> insert diểm 
            //else update diểm

            //kt column click là thuộc trường nào  nếu là trường điemThi =>thao tác diemThi
            //else thao tác điểm quá trình và sau khi đủ 2 điểm => tính điểm trung bình và xếp loại
            //2 cau truy van update set diemThi + xeploai  update set diemQT đồng thời
            //cap nhật điểm tb
            //dừng các điểm tb để tống kết thành trung binmhf học phan
         */
        
    }
}
