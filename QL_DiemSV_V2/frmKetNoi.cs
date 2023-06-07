using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace QL_DiemSV_V2
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }
        public frmKetNoi(int mode) 
        {
            this.mode = mode;
            InitializeComponent();
        }
        int mode = 0;
        private static string filePath = @"C:\Users\Admin\source\repos\QL_DiemSV_V2\QL_DiemSV_V2\bin\Debug\DataConfig.xml";
        DP dataprovider = new DP();
        public void CauHinh()
        {
            try
            {
                XDocument testXML = XDocument.Load(filePath);
                XElement newStudent = new XElement("DataProvider",
                new XElement("Server",txtservername.Text),
                new XElement("Database",txtdatabase.Text),
                new XElement("User", txtusername.Text),
                new XElement("Pass", txtpassword.Text)
                );

                //var lastStudent = testXML.Descendants("DataProvider").Last();
                //string newID = lastStudent.Attribute("ID").Value;
                newStudent.SetAttributeValue("ID", "Public");

                testXML.Element("DataProviders").Add(newStudent);
                testXML.Save(filePath);
                //test connect()=>Thong baos
                //if(true) Thnah cong
            }
            catch (Exception err)
            {
                MessageBox.Show("Cấu hình thất bại"+ err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
        public void SuaCauHinh()
        {
            try
            {
                XDocument testXML = XDocument.Load(filePath);
                XElement cStudent = testXML.Descendants("DataProvider").Where(c => c.Attribute("ID").Value.Equals("Public")).FirstOrDefault();
                cStudent.Element("Server").Value = txtservername.Text;
                cStudent.Element("Database").Value = txtdatabase.Text;
                cStudent.Element("User").Value = txtusername.Text;
                cStudent.Element("Pass").Value = txtpassword.Text;
                testXML.Save(filePath);
            }
            catch(Exception err)
            {
                MessageBox.Show("Cấu hình thất bại" + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool TestketNoi()
        {
            try
            {
                string strConn = @"Data Source=" + txtservername.Text + ";Initial Catalog=" + txtdatabase.Text + "; User =" + txtusername.Text + "; password=" + txtpassword.Text + "; Integrated Security=false";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void ibtnketNoi_Click(object sender, EventArgs e)
        {

            if (mode == 1)
            {
                if (TestketNoi())
                {
                    CauHinh();
                    MessageBox.Show("Cấu hình hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDANGNHAP f = new frmDANGNHAP();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cấu hình thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                if(TestketNoi()){
                    SuaCauHinh();
                    MessageBox.Show("Sửa cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDANGNHAP f = new frmDANGNHAP();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cấu hình thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            //Thong bao
            //Khoi doongj lai
            //tiep tuc kiem tra
            
            //frmDANGNHAP f = new frmDANGNHAP();
            //this.Hide();
            //f.Show();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {

        }

        private void ibtnTest_Click(object sender, EventArgs e)
        {
            if (TestketNoi())
            {
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
