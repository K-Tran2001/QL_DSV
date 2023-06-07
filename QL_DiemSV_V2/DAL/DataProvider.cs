using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    
    public class DataProvider
    {
        private static string filePath = @"DataConfig.xml";
        //string strConn = @"Data Source=DESKTOP-KMNS09Q;
        //Initial Catalog=QLSV_DIEMSV; User = sa; password=sql2014; Integrated Security=True";
        string strConn = "";//1
        public DataProvider(String sv,string db,string user,string pass)
        {
            this.strConn= @"Data Source="+sv+";Initial Catalog="+db+"; User ="+user+"; password="+pass+"; Integrated Security=True";
        }
        public DataProvider() {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath);
            DataTable dt = new DataTable();
            dt = dataSet.Tables["DataProvider"];
            foreach(DataRow r in dt.Rows)
            {
                this.strConn = @"Data Source=" + r[0] + ";Initial Catalog=" + r[1] + "; User =" + r[2] + "; password=" + r[3] + "; Integrated Security=True";
                break;
            }
        }
        //Nghien cuu them
        public DataTable ExcuteQuery(String query, object[] parmeter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {

                conn.Open();
                SqlCommand commad = new SqlCommand(query, conn);

                if (parmeter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            commad.Parameters.AddWithValue(item, parmeter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(commad);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExcuteNoneQuery(String query, object[] parmeter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {

                conn.Open();
                SqlCommand commad = new SqlCommand(query, conn);

                if (parmeter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            commad.Parameters.AddWithValue(item, parmeter[i]);
                            i++;
                        }
                    }
                }
                data = commad.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        public object ExcuteScalar(String query, object[] parmeter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand commad = new SqlCommand(query, conn);
                if (parmeter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            commad.Parameters.AddWithValue(item, parmeter[i]);
                            i++;
                        }
                    }
                }
                data = commad.ExecuteScalar();
                conn.Close();
            }
            return data;
        }


    }
}
