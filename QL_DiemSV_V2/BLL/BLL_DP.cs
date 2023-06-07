using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class BLL_DP
    {
        DataProvider dt;
        string iD = "AD";
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_DP sql;
        public BLL_DP() { }
        public BLL_DP(string iD)
        {
            this.iD = iD;
        }
        public BLL_DP(DataProvider data)
        {
            dt = data;
            sql = new SQL_DP(data);
        }
        public DataTable DataProvider_SelectAll()
        {
            return sql.DataProvider_SelectAll();
        }
        public void DataProvider_Insert(DP ex)
        {
            sql.DataProvider_Insert(ex);
        }
        public void DataProvider_Update(DP ex)
        {
            sql.DataProvider_Update(ex);
        }
    }
}
