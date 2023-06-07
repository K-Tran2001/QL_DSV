using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_CTGIANGDAY
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_CTGIANGDAY() { }
        public BLL_CTGIANGDAY(string iD)
        {
            this.iD = iD;
        }
        public BLL_CTGIANGDAY(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        SQL_CTGIANGDAY sql = new SQL_CTGIANGDAY();
        public void CTGD_Insert(CTGIANGDAY ex)
        {
            sql.CTGD_Insert(ex);
            //wl = new Writelog(iD, "CTGD", "Them", "dtgCTGIANGDAY");
        }
        //  SỬA DỮ LIỆU
        public void CTGD_Update(CTGIANGDAY ex)
        {
            sql.CTGD_Update(ex);
            //wl = new Writelog(iD, "CTGD", "Sua", "dtgCTGIANGDAY");
        }
        //  XÓA DỮ LIỆU
        public void CTGD_Delete(String maGV,String maHP)
        {
            sql.CTGD_Delete(maGV,maHP);
            //wl = new Writelog(iD, "CTGD", "Xoa", "dtgCTGIANGDAY");
        }
        //  LẤY DỮ LIỆU
        public DataTable CTGD_SelectAll()
        {
            //wl = new Writelog(iD, "CTGD", "Xem", "dtgCTGIANGDAY");
            return sql.CTGD_SelectAll();
            
        }
        public DataTable CTGD_SelectmaGV(string maGV)
        {
            //wl = new Writelog(iD, "CTGD", "Xem", "dtgCTGIANGDAY");
            return sql.CTGD_SelectbymaGV( maGV);
        }
        public void CTGD_DeleteBymaGV(string maGV)
        {
            //wl = new Writelog(iD, "CTGD", "Xem", "dtgCTGIANGDAY");
            sql.CTGD_DeleteBymaGV(maGV);
        }
    }
}
