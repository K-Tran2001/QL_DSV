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
    public class BLL_LOP
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_LOP() { }
        public BLL_LOP(string iD)
        {
            this.iD = iD;
        }
        public BLL_LOP(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_LOP sql = new SQL_LOP();
        public void LOP_Insert(LOP ex)
        {
            sql.LOP_Insert(ex);
            //wl = new Writelog(iD, "LOP", "Them", "dtgLop");
        }
        //  SỬA DỮ LIỆU
        public void LOP_Update(LOP ex)
        {
            sql.LOP_Update(ex);
           // wl = new Writelog(iD, "LOP", "Sua", "dtgLop");
        }
        //  XÓA DỮ LIỆU
        public void LOP_Delete(string maLop)
        {
            sql.LOP_Delete(maLop);
            //wl = new Writelog(iD, "LOP", "Xoa", "dtgLop");
        }
        //  LẤY DỮ LIỆU
        public DataTable LOP_SelectAll()
        {
            //wl = new Writelog(iD, "LOP", "Xem", "dtgLop");
            return sql.LOP_SelectAll();
        }

        public DataTable LOP_SelectmaLop(string maLop)
        {
            //wl = new Writelog(iD, "LOP", "Xem", "dtgLop");
            return sql.LOP_SelectmaLop(maLop);
        }
    }
}
