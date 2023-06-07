using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using BLL;
using DTO;
using DAL;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace QL_DiemSV_V2
{
    public partial class frmADMIN_QLSV : Form
    {
        public frmADMIN_QLSV()
        {
            InitializeComponent();
        }
        public frmADMIN_QLSV(string iD)
        {
            this.iD = iD;
            InitializeComponent();
        }
        string iD = "AD";
        private static string filePath = @"C:\Users\Admin\source\repos\QL_DiemSV_V2\QL_DiemSV_V2\bin\Debug\sinhvien.xml";
        
        //string kn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filePath + "';Extended Properties=\"Exel 12.0;HDR=YES;\"";

        Writelog wl;
        BLL_LOP blllop = new BLL_LOP();
        BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        BLL_GIAOVIEN bllgv = new BLL_GIAOVIEN();
        SINHVIEN sv = new SINHVIEN();
        DataProvider dt = new DataProvider();
       
        
        string sqlthucthi, sqlphuchoi;
        //int max = 9;

        string[] undoList = new string[100];
        string[] redoList = new string[100];
        int pos=-1;
        int current=-1 ;
        
        private void frmADMIN_QLSV_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            rad_SQL_CheckedChanged(sender, e);
            ibtnBack.Enabled = false;ibtnNext.Enabled = false;
            modeDefault();
            LoadData();
            
        }
        public void HeaderName()
        {
            dtgsinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgsinhVien.Columns[1].HeaderText = "Tên Sinh Viên";
            dtgsinhVien.Columns[2].HeaderText = "Giới Tính";
            dtgsinhVien.Columns[3].HeaderText = "Ngày Sinh";
            dtgsinhVien.Columns[4].HeaderText = "Địa Chỉ";
            dtgsinhVien.Columns[5].HeaderText = "Điện Thoại";
            dtgsinhVien.Columns[6].HeaderText = "Mã Lớp";
        }
        public void LoadData()
        {
            if(iD.Contains("AD"))
            dtgsinhVien.DataSource = bllsv.SV_SelectAll();
            else
            {
                DataTable dt = bllgv.GV_SelectmaLopBymaGV(iD);
                dtgsinhVien.DataSource = bllsv.SV_SelectBymaLop(dt.Rows[0]["maLop"].ToString());
            }
            if (dtgsinhVien.Rows.Count <= 0) return;

            HeaderName();
            txtmSSV.DataBindings.Clear();
            txtmSSV.DataBindings.Add("Text", dtgsinhVien.DataSource, "maSV");
            txttenSV.DataBindings.Clear();
            txttenSV.DataBindings.Add("Text", dtgsinhVien.DataSource, "tenSV");
            cbogioiTinh.DataBindings.Clear();
            cbogioiTinh.DataBindings.Add("Text", dtgsinhVien.DataSource, "gioiTinh");
            txtdiaChi.DataBindings.Clear();
            txtdiaChi.DataBindings.Add("Text", dtgsinhVien.DataSource, "diaChi");
            txtdienThoai.DataBindings.Clear();
            txtdienThoai.DataBindings.Add("Text", dtgsinhVien.DataSource, "dienThoai");
            cboLop.DataBindings.Clear();
            cboLop.DataBindings.Add("Text", dtgsinhVien.DataSource, "maLop");
            datengaySinh.DataBindings.Clear();
            datengaySinh.DataBindings.Add("Text", dtgsinhVien.DataSource, "ngaySinh");
            wl = new Writelog(iD, "SINHVIEN", "Xem", "dtgSV");
            
        }

        private void loaddata()
        {
            try
            {
                //listView1.Items.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                DataTable dt = new DataTable();
                dt = dataSet.Tables["Student"];
                dtgsinhVien.DataSource = dt;
                
                txtmSSV.DataBindings.Clear();
                txtmSSV.DataBindings.Add("Text", dtgsinhVien.DataSource, "maSV");
                txttenSV.DataBindings.Clear();
                txttenSV.DataBindings.Add("Text", dtgsinhVien.DataSource, "tenSV");
                cbogioiTinh.DataBindings.Clear();
                cbogioiTinh.DataBindings.Add("Text", dtgsinhVien.DataSource, "gioiTinh");
                txtdiaChi.DataBindings.Clear();
                txtdiaChi.DataBindings.Add("Text", dtgsinhVien.DataSource, "diaChi");
                txtdienThoai.DataBindings.Clear();
                txtdienThoai.DataBindings.Add("Text", dtgsinhVien.DataSource, "dienThoai");
                cboLop.DataBindings.Clear();
                cboLop.DataBindings.Add("Text", dtgsinhVien.DataSource, "maLop");
                datengaySinh.DataBindings.Clear();
                datengaySinh.DataBindings.Add("Text", dtgsinhVien.DataSource, "ngaySinh");
                wl = new Writelog(iD, "SINHVIEN", "Xem XML", "dtgSV");
                //HeaderName();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public Boolean kiemTraHopLe()
        {
            int currentYear = DateTime.Now.Year;
            if (txttenSV.Text.Equals("") || cbogioiTinh.Text.Equals("") || txtdienThoai.Text.Equals("") || txtdiaChi.Text.Equals("") || cboLop.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(txttenSV.Text))
            {
                MessageBox.Show("Tên sinh viên không được tồn tại kí tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(currentYear - datengaySinh.Value.Year<18|| currentYear - datengaySinh.Value.Year > 30)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsNumber(txtdienThoai.Text))
            {
                MessageBox.Show("Số điện thoại phải toàn là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void LoadListView()
        {
            
            
        }
        bool Them = false;
        public void modeThem()
        {
            
            //ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmSSV.Enabled = false; txttenSV.Focus();
            txttenSV.Enabled = true;
            cbogioiTinh.Enabled = true;
            datengaySinh.Enabled = true;
            txtdiaChi.Enabled = true;
            txtdienThoai.Enabled = true;
            cboLop.Enabled = true;
        }
        public void modeSua()
        {
            //ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;

            txtmSSV.Enabled = false;
            txttenSV.Enabled = true; txttenSV.Focus();
            cbogioiTinh.Enabled = true;
            datengaySinh.Enabled = true;
            txtdiaChi.Enabled = true;
            txtdienThoai.Enabled = true;
            cboLop.Enabled = true;
        }
        public void modeDefault()
        {
            //ibtnBack.Enabled = false;ibtnNext.Enabled = false;
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnXoa.Enabled = true;
            ibtnLuu.Enabled = false;

            txtmSSV.Enabled = false;
            txttenSV.Enabled = false;
            cbogioiTinh.Enabled = false;
            datengaySinh.Enabled = false;
            txtdiaChi.Enabled = false;
            txtdienThoai.Enabled = false;
            cboLop.Enabled = false;
        }
        public string phatSinhMSSV()
        {
            //kt xem đang ở mode nào nếu SQL=>
            string ms = "";
            if (rad_SQL.Checked==true)
            {
                // DataTable data = bllsv.SV_SelectAll();
                //foreach (DataRow r in data.Rows)
                //{
                //    ms = r["maSV"].ToString();
                //}
                ms = dtgsinhVien.Rows[dtgsinhVien.Rows.Count - 2].Cells["maSV"].Value.ToString();
                ms = ms.Substring(5);
                ms = (Convert.ToInt32(ms) + 1).ToString();
                ms = "DTH19" + ms;

            }
            else
            {
                ms = dtgsinhVien.Rows[dtgsinhVien.Rows.Count - 2].Cells["maSV"].Value.ToString();

                ms = ms.Substring(2);
                ms = (Convert.ToInt32(ms) + 1).ToString();
                ms = "00" + ms;

            }

            return ms;
        }
        private void ibtnThem_Click(object sender, EventArgs e)
        {
            
            modeThem();//dong mo button
            txtmSSV.Text = phatSinhMSSV();
            txttenSV.ResetText();txttenSV.Focus();
            cbogioiTinh.ResetText(); 
            datengaySinh.ResetText();
            
            txtdiaChi.ResetText();
            txtdienThoai.ResetText();
            if (iD.Equals("AD"))
            {
                cboLop.DataSource = blllop.LOP_SelectAll();
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            else
            {
                cboLop.DataSource = bllgv.GV_SelectmaLopBymaGV(iD);
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            Them = true;
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            string ngaySinh = datengaySinh.Value.ToString();
            sqlphuchoi = "update SINHVIEN set tenSV=N'" + txttenSV.Text + "',gioiTinh='" + cbogioiTinh.Text 
                + "',ngaySinh='" + ngaySinh + "',diaChi=N'" + txtdiaChi.Text 
                + "',dienThoai='" + txtdienThoai.Text + "',maLop='" + cboLop.Text 
                + "' where maSV='" + txtmSSV.Text + "'";
            //unDO_REDOsList[current].codePhucHoi = sqlphuchoi;
            //
            modeSua();
            txttenSV.Focus();
            datengaySinh.ResetText();


            if (iD.Equals("AD"))
            {
                cboLop.DataSource = blllop.LOP_SelectAll();
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
            else
            {
                cboLop.DataSource = bllgv.GV_SelectmaLopBymaGV(iD);
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
            }
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            
            
            if(rad_SQL.Checked == true)
            {
                ibtnBack.Enabled = true; ibtnNext.Enabled = false;
                if (pos < current)
                    current = pos++;
                else
                    pos++; current++;
                //delete SQL
                try
                {
                    DialogResult lenh = MessageBox.Show("Bạn có thực sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (lenh == DialogResult.Yes)
                    {
                        //ibtnBack.Enabled = true; ibtnNext.Enabled = false;
                        sv.maSV = txtmSSV.Text;
                        sv.tenSV = txttenSV.Text;
                        sv.gioiTinh = cbogioiTinh.Text;
                        sv.ngaySinh = datengaySinh.Value;
                        string ngaySinh = datengaySinh.Value.ToString();
                        sv.diaChi = txtdiaChi.Text;
                        sv.dienThoai = txtdienThoai.Text;
                        sv.maLop = cboLop.Text;

                        sqlphuchoi = "insert into SINHVIEN values('" + sv.maSV + "',N'" + sv.tenSV + "','" + sv.gioiTinh + "','"
                            + sv.ngaySinh + "',N'" + sv.diaChi + "','" + sv.dienThoai + "','" + sv.maLop + "')";
                        sqlthucthi = "delete from SINHVIEN where maSV='" + sv.maSV + "'";
                        undoList[pos] = sqlphuchoi;
                        redoList[pos] = sqlthucthi;

                        bllsv.SV_Delete(sv.maSV);

                        //add mảng
                        //wl = new Writelog("AD", "SINHVIEN", "Delete", sqlthucthi);
                        MessageBox.Show("Sinh viên đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wl = new Writelog(iD, "SINHVIEN", "Xóa sinh viên", "dtgSV");
                        LoadData();

                    }
                }
                catch
                {
                    pos--; current--;
                    MessageBox.Show("Xóa sinh viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //delete XML
                Xoa_XML();
            }

        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraHopLe())
            {
            if (rad_SQL.Checked == true)
            {
                ibtnBack.Enabled = true; ibtnNext.Enabled = false;
                if (pos < current)
                    current = pos++;
                else
                    pos++; current++;
            }
                if (Them)
                {
                    if (rad_SQL.Checked == true)
                    {
                        //insert SQL
                        try
                        {
                            sv.maSV =txtmSSV.Text;
                            sv.tenSV = txttenSV.Text;
                            sv.gioiTinh = cbogioiTinh.SelectedItem.ToString();
                            sv.ngaySinh = datengaySinh.Value;
                            string ngaySinh = datengaySinh.Value.ToString();
                            sv.diaChi = txtdiaChi.Text;
                            sv.dienThoai = txtdienThoai.Text;
                            sv.maLop = cboLop.SelectedValue.ToString();
                            //code phuc hoi
                            sqlthucthi = "insert into SINHVIEN values('" + sv.maSV + "',N'" + sv.tenSV + "','" + sv.gioiTinh + "','"
                                + sv.ngaySinh + "',N'" + sv.diaChi + "','" + sv.dienThoai + "','" + sv.maLop + "')";
                            sqlphuchoi = "delete from SINHVIEN where maSV = '" + sv.maSV + "'";
                            ///////////
                            undoList[pos] = sqlphuchoi;
                            redoList[pos] = sqlthucthi;

                            //uNDO_REDOsList.Add(uNDO_REDO);
                            //Code phuc hoi
                            bllsv.SV_Insert(sv);
                            //add vào mảng


                            //wl = new Writelog("AD", "SINHVIEN", "Insert", sqlthucthi);
                            MessageBox.Show("Thêm thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            wl = new Writelog("AD", "SINHVIEN", "Thêm sinh viên", "dtgSV");
                            //LoadData();
                            Them = false;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Thêm sinh viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LoadData();
                    }
                    else
                    {
                    Them_XML();
                    }
    
                }
                else
                {
                    if(rad_SQL.Checked == true)
                    {
                    //update
                        try
                        {
                            sv.maSV = txtmSSV.Text;
                            sv.tenSV = txttenSV.Text;
                            sv.gioiTinh = cbogioiTinh.SelectedItem.ToString();
                            sv.ngaySinh = datengaySinh.Value;
                            sv.diaChi = txtdiaChi.Text;
                            sv.dienThoai = txtdienThoai.Text;
                            sv.maLop = cboLop.SelectedValue.ToString();
                            //Code phuc hoi


                            sqlthucthi = "update SINHVIEN set tenSV=N'" + sv.tenSV + "',gioiTinh='" + sv.gioiTinh
                                + "',ngaySinh='" + sv.ngaySinh + "',diaChi=N'" + sv.diaChi + "',dienThoai='" + sv.dienThoai
                                + "',maLop='" + sv.maLop + "' where maSV='" + sv.maSV + "'";

                            undoList[pos] = sqlphuchoi;
                            redoList[pos] = sqlthucthi;

                            //uNDO_REDO.maThaoTac = current;

                            //uNDO_REDOsList.Add(uNDO_REDO);

                            //
                            bllsv.SV_Update(sv);



                            //wl = new Writelog("AD", "SINHVIEN", "Update", sqlthucthi);
                            MessageBox.Show("Sửa thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            wl = new Writelog("AD", "SINHVIEN", "Sửa sinh viên", "dtgSV");
                            //LoadData();
                            LoadListView();
                        }
                        catch (Exception)
                        {
                            pos--; current--;
                            MessageBox.Show("Sửa thông tin sinh viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LoadData();
                    }
                    else
                    {
                    //update XML
                    Sua_XML();
                    }
                    
                    
                }

                //LoadData();
                modeDefault();
            }
            
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
        public void Them_XML()
        {
            try
            {
                XDocument testXML = XDocument.Load(filePath);
                XElement newStudent = new XElement("student",
                new XElement("tenSV", txttenSV.Text),
                new XElement("gioiTinh", cbogioiTinh.SelectedItem.ToString()),
                new XElement("ngaySinh",datengaySinh.Value.ToString()),
                new XElement("dienThoai", txtdienThoai.Text),
                new XElement("diaChi", txtdiaChi.Text),
                new XElement("maLop", cboLop.SelectedValue.ToString())
                );

                var lastStudent = testXML.Descendants("student").Last();
                long newID = Convert.ToInt64(lastStudent.Attribute("maSV").Value);
                newStudent.SetAttributeValue("maSV", txtmSSV.Text);

                testXML.Element("students").Add(newStudent);
                testXML.Save(filePath);
                wl = new Writelog(iD, "SINHVIEN", "Thêm sinh viên XML", "dtgSV");
                loaddata();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void Sua_XML()
        {
            try
            {
                XDocument testXML = XDocument.Load(filePath);
                XElement cStudent = testXML.Descendants("student").Where(c => c.Attribute("maSV").Value.Equals(txtmSSV.Text)).FirstOrDefault();
                cStudent.Element("tenSV").Value = txttenSV.Text;
                cStudent.Element("gioiTinh").Value = cbogioiTinh.SelectedItem.ToString();
                cStudent.Element("ngaySinh").Value = datengaySinh.Value.ToString();
                cStudent.Element("diaChi").Value = txtdiaChi.Text;
                cStudent.Element("dienThoai").Value = txtdienThoai.Text;
                cStudent.Element("maLop").Value = cboLop.SelectedValue.ToString();
                testXML.Save(filePath);
                wl = new Writelog(iD, "SINHVIEN", "Sửa sinh viên XML", "dtgSV");
                loaddata();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void Xoa_XML()
        {
            try
            {
                if (txtmSSV.Text != "1112201518597")
                {
                    XDocument testXML = XDocument.Load(filePath);
                    XElement cStudent = testXML.Descendants("student").Where(c => c.Attribute("maSV").Value.Equals(txtmSSV.Text)).FirstOrDefault();
                    cStudent.Remove();
                    testXML.Save(filePath);
                    wl = new Writelog(iD, "SINHVIEN", "Xóa sinh viên XML", "dtgSV");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("vui lòng không xóa trường này !");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void ibtnBack_Click(object sender, EventArgs e)
        {
            //ibtnBack.Enabled = false; ibtnNext.Enabled = true;
            
            dt.ExcuteNoneQuery(undoList[pos]);
            LoadData();
            pos--;
            OnOffUNDOREDO();
            
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            modeDefault();
            LoadData();
        }

        private void ibtnTim_Click(object sender, EventArgs e)
        {
            dtgsinhVien.DataSource = dt.ExcuteQuery("select * from SINHVIEN where tenSV like '%" + txtTim.Text + "%'");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ibtnUpload_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnImport_Click(object sender, EventArgs e)
        {
            if (rad_XML.Checked==true)//mode sql
            {
            for (int i = 0; i < dtgsinhVien.Rows.Count - 1; i++)
                {
                    //sv.maSV = dtgsinhVien.Rows[i].Cells["maSV"].Value.ToString();
                    //if (bllsv.SV_SelectBymaSV(sv.maSV)==null)//kt trung khoa
                    try
                    {
                        sv.maSV = dtgsinhVien.Rows[i].Cells["maSV"].Value.ToString();
                        sv.tenSV = dtgsinhVien.Rows[i].Cells["tenSV"].Value.ToString();
                        sv.gioiTinh = dtgsinhVien.Rows[i].Cells["gioiTinh"].Value.ToString();
                        DateTime date = DateTime.Parse(dtgsinhVien.Rows[i].Cells["ngaySinh"].Value.ToString());
                        sv.ngaySinh = date;
                        sv.diaChi = dtgsinhVien.Rows[i].Cells["diaChi"].Value.ToString();
                        sv.dienThoai = dtgsinhVien.Rows[i].Cells["dienThoai"].Value.ToString();
                        sv.maLop = dtgsinhVien.Rows[i].Cells["maLop"].Value.ToString();
                        bllsv.SV_Insert(sv);
                    }
                    catch
                    {
                        MessageBox.Show("Mã sinh vien chèn vào đã bị trùng, lỗi khóa chính!!!", "Thông báo");
                        throw;
                    }
                }
                wl = new Writelog(iD, "SINHVIEN", "Import XML", "dtgSV");
            }  
            else
                MessageBox.Show("Chức năng này chỉ được thực hiện khi được chọn dữ liệu thao tác là XML\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labcurr_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ibtnSQL_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnXML_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
            }
            loaddata();
        }

        private void ibtnExport_Click(object sender, EventArgs e)
        {
            if(rad_SQL.Checked == true)//mode sql 
            {
               for(int i = 1; i < dtgsinhVien.RowCount - 1; i++)
                {
                    try
                    {
                        XDocument testXML = XDocument.Load(filePath);
                        XElement newStudent = new XElement("student",
                        new XElement("tenSV", dtgsinhVien.Rows[i].Cells[1].Value.ToString()),
                        new XElement("gioiTinh", dtgsinhVien.Rows[i].Cells[2].Value.ToString()),
                        new XElement("ngaySinh", dtgsinhVien.Rows[i].Cells[3].Value.ToString()),
                        new XElement("dienThoai", dtgsinhVien.Rows[i].Cells[4].Value.ToString()),
                        new XElement("diaChi", dtgsinhVien.Rows[i].Cells[5].Value.ToString()),
                        new XElement("maLop", dtgsinhVien.Rows[i].Cells[6].Value.ToString())
                        );

                        var lastStudent = testXML.Descendants("student").Last();
                        long newID = Convert.ToInt64(lastStudent.Attribute("maSV").Value);
                        newStudent.SetAttributeValue("maSV", dtgsinhVien.Rows[i].Cells[0].Value.ToString());

                        testXML.Element("students").Add(newStudent);
                        testXML.Save(filePath);
                    }
                    catch
                    {
                    }
                }
                wl = new Writelog(iD, "", "Export XML", "");
                MessageBox.Show("Export dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
                MessageBox.Show("Chức năng này chỉ được thực hiện khi được chọn dữ liệu thao tác là SQL\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void rad_SQL_CheckedChanged(object sender, EventArgs e)
        {
            ibtnImport.Enabled = false;
            ibtnDoc.Enabled = false;
            ibtnExport.Enabled = true;
            ibtnRefresh.Visible = true;
            ibtnBack.Visible = true;
            ibtnNext.Visible = true;
        }

        private void rad_XML_CheckedChanged(object sender, EventArgs e)
        {
            ibtnImport.Enabled = true;
            ibtnDoc.Enabled = true;
            ibtnExport.Enabled = false;
            ibtnRefresh.Visible = false;
            ibtnBack.Visible = false;
            ibtnNext.Visible = false;
        }

        private void frmADMIN_QLSV_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.Modifiers == Keys.Control &&  e.KeyCode == Keys.X)
            {
                ibtnNext.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                ibtnDoc.PerformClick();

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                ibtnImport.PerformClick();

            }
            

        }

        private void txtdienThoai_TextChanged(object sender, EventArgs e)
        {
            
            if (IsNumber(txtdienThoai.Text)&&txtdienThoai.Text.Length > 10)
            {
                txtdienThoai.Text = txtdienThoai.Text.Substring(0, 10);
                MessageBox.Show("Số điện thoại tối đa có 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void ibtnNext_Click(object sender, EventArgs e)
        {
            //ibtnBack.Enabled = true; ibtnNext.Enabled = false;
            
            pos++;
            OnOffUNDOREDO();
            
            dt.ExcuteNoneQuery(redoList[pos]);  
            LoadData();
        }
    }
}
