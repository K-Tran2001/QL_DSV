using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;


namespace QL_DiemSV_V2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            string filePath = "DataConfig.xml";
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath);
            DataTable dt = new DataTable();
            dt = dataSet.Tables["DataProvider"];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (dt == null)
            {
                Application.Run(new frmKetNoi(1));
            }
            else
            {
                Application.Run(new frmDANGNHAP());
            }
            

        }
    }
}
