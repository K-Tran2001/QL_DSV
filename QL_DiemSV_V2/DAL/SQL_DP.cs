using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    class SQL_DP
    {
        DataProvider dt = new DataProvider();
       
        public SQL_DP() { }
        public SQL_DP(DataProvider data)
        {
            dt = data;
        }

        public void DataProvider_Insert(DP ex)
        {
            string sql = "DataProvider_Insert @1 , @2 , @3 , @4";
            dt.ExcuteNoneQuery(sql,new object[] {ex.SV,ex.DB,ex.User,ex.Pass });
        }

        public void DataProvider_Update(DP ex)
        {
            string sql = "DataProvider_Update @1 , @2 , @3 , @4";
            dt.ExcuteNoneQuery(sql, new object[] { ex.SV, ex.DB, ex.User, ex.Pass });
        }

        public DataTable DataProvider_SelectAll()
        {
            string sql = "DataProvider_SelectAll";
            return dt.ExcuteQuery(sql, new object[] {""});
        }
    }
}
