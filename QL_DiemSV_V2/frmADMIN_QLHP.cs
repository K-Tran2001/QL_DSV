using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//Microsoft.ACE.OLEDB.12.0
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using System.Text.RegularExpressions;

namespace QL_DiemSV_V2
{
    public partial class frmADMIN_QLHP : Form
    {
        public frmADMIN_QLHP()
        {
            InitializeComponent();
        }
        private static string filePath = @"C:\Users\Admin\source\repos\QL_DiemSV_V2\QL_DiemSV_V2\bin\Debug\monhoc.xlsx";//@"D:\QL_DiemSV_V2\QL_DiemSV_V2\bin\Debug\hocphan.xlsx";
        //string kn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filePath + "';Extended Properties=\"Exel 12.0;HDR=YES;\"";
        string kn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = '" + filePath + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
        DataProvider dt = new DataProvider();
        BLL_HOCPHAN bllhp = new BLL_HOCPHAN();
        BLL_HOCKY bllhk = new BLL_HOCKY();
        HOCPHAN hp = new HOCPHAN();
        Writelog wl;
        string[] undoList = new string[100];int pos = -1,current=-1;
        string[] redoList = new string[100];
        string sqlthucthi;
        string sqlphuchoi;
        private void frmADMIN_QLHP_Load(object sender, EventArgs e)
        {
            radSQL.Checked = true;
            KeyPreview = true;
            ibtnBack.Enabled = false; ibtnNext.Enabled = false;
            modeDefault();
            LoadData();   
        }
        public void HeaderName()
        {
            dtgHP.Columns[0].HeaderText = "Mã Học Phận";
            dtgHP.Columns[1].HeaderText = "Tên Học Phận";
            dtgHP.Columns[2].HeaderText = "Số Tín Chỉ";
            dtgHP.Columns[3].HeaderText = "Mã Học Kì";


        }
        public void LoadData()
        {
            
            
            cbohocKi.DataSource = bllhk.HK_SelectAll();
            cbohocKi.DisplayMember = "tenHK";
            cbohocKi.ValueMember = "maHK";



            dtgHP.DataSource = bllhp.HP_SelectAll();
            HeaderName();
            txtmaHP.DataBindings.Clear();
            txtmaHP.DataBindings.Add("Text", dtgHP.DataSource, "maHP");
            txttenHP.DataBindings.Clear();
            txttenHP.DataBindings.Add("Text", dtgHP.DataSource, "tenHP");
            txtsoTC.DataBindings.Clear();
            txtsoTC.DataBindings.Add("Text", dtgHP.DataSource, "soTC");
            cboHK.DataBindings.Clear();
            cboHK.DataBindings.Add("Text", dtgHP.DataSource, "maHK");
            wl = new Writelog("AD", "HOCPHAN", "Xem", "dtgHP");
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            if (txtmaHP.Text.Equals("") || txttenHP.Text.Equals("") || txtsoTC.Text.Equals("") || cboHK.Text.Equals("") )
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txtmaHP.Text[0].ToString()))
            {
                MessageBox.Show("Mã học phần không bắt đầu bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txttenHP.Text[0].ToString()))
            {
                MessageBox.Show("Mã học phần không bắt đầu bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsNumber(txtsoTC.Text))
            {
                MessageBox.Show("Số tín chỉ không tồn tại chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        bool themHP=false;
        public void modeThem()
        {

            
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmaHP.Enabled = true; txttenHP.Focus();
            txttenHP.Enabled = true;
            txtsoTC.Enabled = true;
            cboHK.Enabled = true;
            
        }
        public void modeSua()
        {
            
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;


            txtmaHP.Enabled = false;
            txttenHP.Enabled = true; txttenHP.Focus();
            cboHK.Enabled = true;
            txtsoTC.Enabled = true;
            
        }
        public void modeDefault()
        {
            
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnXoa.Enabled = true;
            ibtnLuu.Enabled = false;

            txtmaHP.Enabled = false;
            txttenHP.Enabled = false; txttenHP.Focus();
            cboHK.Enabled = false;
            txtsoTC.Enabled = false;
        }
        private void ibtnThem_Click(object sender, EventArgs e)
        {
            modeThem();
            txtmaHP.ResetText();txtmaHP.Focus();
           txttenHP.ResetText();
            txtsoTC.ResetText();
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";
            themHP = true;
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            
            sqlphuchoi = "update  HOCPHAN set tenHP='" + txttenHP.Text + "',soTC=" + Convert.ToInt32(txtsoTC.Text) + ",maHK='" + cboHK.Text + "' where maHP='" + txtmaHP.Text + "' ";
            modeSua(); txttenHP.Focus();
            cboHK.DataSource = bllhk.HK_SelectAll();
            cboHK.DisplayMember = "tenHK";
            cboHK.ValueMember = "maHK";
            //code phuc hoi
            
            //
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if (radSQL.Checked == true)
            {
                if (pos < current)
                    current = pos++;
                else
                    pos++; current++;
                try
                {
                    DialogResult lenh = MessageBox.Show("Bạn có thực sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (lenh == DialogResult.Yes)
                    {
                        ibtnBack.Enabled = true; ibtnNext.Enabled = false;
                        //code phuc hoi
                        hp.maHP = txtmaHP.Text;
                        hp.tenHP = txttenHP.Text;
                        hp.soTC = Convert.ToInt32(txtsoTC.Text);
                        hp.maHK = cboHK.Text;
                        sqlphuchoi = "insert into HOCPHAN values ('" + hp.maHP + "','" + hp.tenHP + "'," + hp.soTC + ",'" + hp.maHK + "')";
                        sqlthucthi = "delete from HOCPHAN where maHP ='" + hp.maHP + "'";
                        undoList[current] = sqlphuchoi;
                        redoList[current] = sqlthucthi;
                        //
                        String maHP = txtmaHP.Text;
                        bllhp.HP_Delete(maHP);
                        MessageBox.Show("Xóa học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog("AD", "HOCPHAN", "Xoa", "dtgHP");
                        LoadData();
                        modeDefault();
                    }
                }
                catch
                {
                    pos--; current--;
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chức nang còn trong giai đoạn thử nghiệm", "Thông báo");
                //Xoa_Excel();
            }
            
            
        }

        private void cboHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraHopLe())
            {
                ibtnBack.Enabled = true; ibtnNext.Enabled = false;
                if (pos < current)
                    current = pos++;
                else
                    pos++; current++;
                if (themHP)
                {
                    if (radSQL.Checked == true)
                    {
                        try
                        {
                            hp.maHP = txtmaHP.Text;
                            hp.tenHP = txttenHP.Text;
                            hp.soTC = Convert.ToInt32(txtsoTC.Text);
                            hp.maHK = cboHK.SelectedValue.ToString();
                            
                            //code phuc hoi
                            sqlthucthi = "insert into HOCPHAN values ('" + hp.maHP + "','" + hp.tenHP + "'," + hp.soTC + ",'" + hp.maHK + "')";
                            sqlphuchoi = "delete from HOCPHAN where maHP ='" + hp.maHP + "'";
                            undoList[current] = sqlphuchoi;
                            redoList[current] = sqlthucthi;
                            //
                            bllhp.HP_Insert(hp);
                            MessageBox.Show("Thêm học phần thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            wl = new Writelog("AD", "HOCPHAN", "Them", "dtgHP");
                            themHP = false;
                        }
                        catch
                        {
                            pos--; current--;
                        }
                    }
                    else
                    {
                        
                        Them_Excel();
                    }
                }
                else
                {
                    if (radSQL.Checked == true)
                    {
                        try
                        {
                            hp.maHP = txtmaHP.Text;
                            hp.tenHP = txttenHP.Text;
                            hp.soTC = Convert.ToInt32(txtsoTC.Text);
                            hp.maHK = cboHK.SelectedValue.ToString();
                            //insert code thuc thi
                            sqlthucthi = "update  HOCPHAN set tenHP='" + hp.tenHP + "',soTC=" + hp.soTC + ",maHK='" + hp.maHK + "' where maHP='" + hp.maHP + "' ";
                            undoList[current] = sqlphuchoi;
                            redoList[current] = sqlthucthi;
                            bllhp.HP_Update(hp);
                            MessageBox.Show("Sửa học phần thành công", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            wl = new Writelog("AD", "HOCPHAN", "Sua", "dtgHP");

                        }
                        catch
                        {
                            pos--; current--;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chức nang còn trong giai đoạn thử nghiệm","Thông báo");
                        //Sua_Excel();
                    }
                }
            }
            modeDefault();
            LoadData();


        }

        private void cbohocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHP.DataSource= bllhp.HP_SelectBymaHK(cbohocKi.SelectedValue.ToString());
            cboHP.DisplayMember = "tenHP";
            cboHP.ValueMember = "maHP";
        }
        public void OnOffUNDOREDO()
        {
            if (pos == -1)
            {
                ibtnBack.Enabled = false;
            }
            else
            {
                ibtnBack.Enabled = true;
            }
            if (pos == current)
            {
                ibtnNext.Enabled = false;
            }
            else
            {
                ibtnNext.Enabled = true;
            }
        }
        private void ibtnBack_Click(object sender, EventArgs e)
        {
            
            DAL.DataProvider dt = new DAL.DataProvider();
            dt.ExcuteNoneQuery(undoList[pos]);
            LoadData();
            ///////////
            pos--;
            OnOffUNDOREDO();
        }

        private void ibtnNext_Click(object sender, EventArgs e)
        {
            pos++;
            OnOffUNDOREDO();
            
            DAL.DataProvider dt = new DAL.DataProvider();
            dt.ExcuteNoneQuery(redoList[pos]);
            LoadData();
        }

        private void ibtnTim_Click(object sender, EventArgs e)
        {
            dtgHP.DataSource = dt.ExcuteQuery("select * from HOCPHAN where tenHP like '%" + txtTim.Text + "%'");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void docDL(string sheet)
        {
            using (OleDbConnection conn = new OleDbConnection(kn))
            {
                conn.Open();
                OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter
                ("select * from[" +sheet + "$]", conn);
                DataSet excelDataSet = new DataSet();
                objDA.Fill(excelDataSet);
                dtgHP.DataSource = excelDataSet.Tables[0];
            }
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void ibtndocExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
            }
            //chon file va gan duong dan filePath
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filePath + "';Extended Properties=\"Excel 12.0;HDR=YES;\"");
            conn.Open();
            OleDbDataAdapter a = new OleDbDataAdapter("select * from[Sheet1$]", conn);
            DataTable data = new DataTable();
            a.Fill(data);

            dtgHP.DataSource = data;
            radExcel.Checked = true;
            txtmaHP.DataBindings.Clear();
            txtmaHP.DataBindings.Add("Text", dtgHP.DataSource, "maHP");
            txttenHP.DataBindings.Clear();
            txttenHP.DataBindings.Add("Text", dtgHP.DataSource, "tenHP");
            txtsoTC.DataBindings.Clear();
            txtsoTC.DataBindings.Add("Text", dtgHP.DataSource, "soTC");
            cboHK.DataBindings.Clear();
            cboHK.DataBindings.Add("Text", dtgHP.DataSource, "maHK");
            MessageBox.Show("Cập nhật danh sách học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }
        public void Them_Excel()
        {
            using (OleDbConnection conn = new OleDbConnection(kn))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"Insert into[Sheet1$] (maHP, tenHP, soTC,maHK) VALUES('"+txtmaHP.Text+"','"+txttenHP.Text+"',"+Convert.ToInt32(txtsoTC.Text)+",'"+cboHK.SelectedValue.ToString()+"');";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            docDL("Sheet1");
        }
        public void Sua_Excel()
        {
            using (OleDbConnection conn = new OleDbConnection(kn))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    string cl = "UPDATE[Sheet1$] SET tenHP = '" +
                   txttenHP.Text + "', soTC = " + txtsoTC.Text + ",maHK='" + cboHK.SelectedValue.ToString() + "' where maHP = t" + txtmaHP.Text;
                    cmd.CommandText = cl;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //finally
                //{
                //    txtmaHP.Text = "";
                //    txttenHP.Text = "";
                //    txtsoTC.Text = "";
                //    conn.Close();
                //    conn.Dispose();
                //}
                docDL("Sheet1");
            }
        }
        public void Xoa_Excel()
        {
            using (OleDbConnection conn = new OleDbConnection(kn))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    string cl = "DELETE[Sheet1$]" +
                    " where maHP =" + txtmaHP.Text;
                    cmd.CommandText = cl;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtmaHP.Text = "";
                    txttenHP.Text = "";
                    txtsoTC.Text = "";
                    conn.Close();
                    conn.Dispose();
                }
                docDL("Sheet1");
            }
        }
        private void ibtnchenExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnxoaExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnExport_Click(object sender, EventArgs e)
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
            
            //Phần mở đầu
            #endregion
            #region(TẠO KHUNG TABLE BẢNG HỌC PHẦN)
            worksheet.Cells[1, 1] = "maHP";
            worksheet.Cells[1, 2] = "tenHP";
            worksheet.Cells[1, 3] = "soTC";
            worksheet.Cells[1, 4] = "maHK";
            
            //Khung table
            #endregion
            #region(ĐỔ DỮ LIỆU VAO BẢNG)
            DataTable data = bllhp.HP_SelectAll();
            for (int i = 0; i < dtgHP.RowCount - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //worksheet.Cells[i + 11, 1] = i + 1;//cot STT
                    worksheet.Cells[i + 2, j + 1] = dtgHP.Rows[i].Cells[j].Value;
                }
            }
            int Mon =dtgHP.RowCount - 1;
            //Đổ DL vào table
            #endregion
            
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
            worksheet.Range["A1"].ColumnWidth = 16;
            worksheet.Range["B1"].ColumnWidth = 28;
            worksheet.Range["C1"].ColumnWidth = 28;
            worksheet.Range["D1"].ColumnWidth = 28;
            
            #endregion
            #region(FONT)
            //Định dạng font
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "K100"].Font.Size = 14;
            //worksheet.Range["A1", "K1"].MergeCells = true;
            worksheet.Range["A1", "K1"].Font.Bold = true;
            //worksheet.Range["A10", "K10"].Font.Bold = true;
            worksheet.Range["I11", "I100"].Font.Color = Color.Red;
            worksheet.Range["I11", "I100"].Font.Bold = true;
            worksheet.Range["K11", "K100"].Font.Color = Color.Red;
            #endregion
            #region(KẺ BẢNG_dỊNH DẠNG CHỮ)
            //Kẻ bảng
            worksheet.Range["A1", "D" + (Mon+1)].Borders.LineStyle = 1;//9 vì bắt đầu kẻ dòng thứ 10 và kẽ số dong = Mon 
            //Dinh dang text
            worksheet.Range["A1", "K1"].HorizontalAlignment = 3;
            //worksheet.Range["A10", "K10"].HorizontalAlignment = 3;
            //worksheet.Range["B10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["C10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["D10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["E10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["F10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["G10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["H10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["I10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["J10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["K10", "A" + (Mon + 9)].HorizontalAlignment = 3;
            //worksheet.Range["A10", "G" + (Mon + 6)].HorizontalAlignment = 3;
            //Kẻ bảng
            #endregion
        }

        private void ibtnUpload_Click(object sender, EventArgs e)
        {
            if (radExcel.Checked == true)
            {
                

                for (int i=0;i<dtgHP.Rows.Count-1;i++)
                {
                    //if (bllhp.HP_SelectBymaHP(dtgHP.Rows[i].Cells[0].ToString()) == null)//kt trung khoa
                    //{
                        hp.maHP = dtgHP.Rows[i].Cells[0].Value.ToString();
                        hp.tenHP = dtgHP.Rows[i].Cells[1].Value.ToString();
                        hp.soTC = Convert.ToInt32(dtgHP.Rows[i].Cells[2].Value.ToString());
                        hp.maHK = dtgHP.Rows[i].Cells[3].Value.ToString();
                        bllhp.HP_Insert(hp);
                        MessageBox.Show("Thanhcong");
                    //}

                }
            }
            radSQL.Checked = true;
        }

        private void frmADMIN_QLHP_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                ibtnBack.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                ibtnNext.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                ibtndocExcel.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                ibtnUpload.PerformClick();

            }
        }

        private void ibtnUpload_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void radSQL_CheckedChanged(object sender, EventArgs e)
        {
            ibtndocExcel.Enabled = false;
            ibtnUpload.Enabled = false;
            ibtnExport.Enabled = true;
        }

        private void radExcel_CheckedChanged(object sender, EventArgs e)
        {
            ibtndocExcel.Enabled = true;
            ibtnUpload.Enabled = true;
            ibtnExport.Enabled = false;
        }

        private void ibtnsuaExcel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
