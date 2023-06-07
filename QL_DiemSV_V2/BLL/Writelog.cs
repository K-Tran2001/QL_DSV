using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Writelog
    {
        public Writelog()
        {

        }
        public Writelog(string user="",string table="",string action="",string nameObjAction = "")
        {
            //
            //AppDomain.CurrentDomain.BaseDirectory + "logfile.txt"
            string path = (@"C:\Users\Admin\source\repos\QL_DiemSV_V2\QL_DiemSV_V2\bin\Debug\logfile.txt");
            if (System.IO.File.Exists(path))
            {
                System.IO.File.AppendAllText(path, "\r\n"+DateTime.Now.ToShortDateString() + "\t\t" 
                    + user + "\t" + table + "\t" + action + "\t" + nameObjAction);
            }
        }
    }
}
