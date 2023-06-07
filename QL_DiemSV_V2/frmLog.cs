using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemSV_V2
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void ibtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn tập tin cần mã hóa";
            dialog.Filter = "Text files|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = dialog.FileName;
                file_path = new FileInfo(file_path).FullName;
                txtPath.Text = file_path;
            }
            txtLog.Text = File.ReadAllText(txtPath.Text);
        }
    }
}
