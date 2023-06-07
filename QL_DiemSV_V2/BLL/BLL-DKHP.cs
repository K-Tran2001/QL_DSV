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
    class BLL_DKHP
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_DKHP() { }
        public BLL_DKHP(string iD)
        {
            this.iD = iD;
        }
        public BLL_DKHP(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        SQL_DKHP sql = new SQL_DKHP();
        
        public void DKHP_Insert(DKHP ex)
        {
            
            sql.DKHP_Insert(ex);
            //wl = new Writelog(iD, "DKHP", "Them", "dtgDKHP");
        }
        //  SỬA DỮ LIỆU
        public void DKHP_Update(DKHP ex)
        {
            sql.DKHP_Update(ex);
            //wl = new Writelog(iD, "DKHP", "Sua", "dtgDKHP");
        }
        public void DKHP_UpdatetongTC(DKHP ex)
        {
            sql.DKHP_UpdatetongTC(ex);
            //wl = new Writelog(iD, "DKHP", "Sua", "dtgDKHP");
        }
        //  XÓA DỮ LIỆU
        public void DKHP_Delete(string maSV)
        {
            sql.DKHP_Delete(maSV);
            //wl = new Writelog(iD, "DKHP", "Xoa", "dtgDKHP");
        }
        //  LẤY DỮ LIỆU
        public DataTable DKHP_SelectAll()
        {
            //wl = new Writelog(iD, "DKHP", "Xem", "dtgDKHP");
            return sql.DKHP_SelectAll();
        }
        public DataTable DKHP_SelectBymaSV(string maSV)
        {
            //wl = new Writelog(iD, "DKHP", "Xem", "dtgDKHP");
            return sql.DKHP_SelectBymaSV(maSV);
        }
        public DataTable DKHP_SelectBymaSV_maHK(string maSV,string maHK)
        {
            //wl = new Writelog(iD, "DKHP", "Xem", "dtgDKHP");
            return sql.DKHP_SelectBymaSV_maHK(maSV,maHK);
        }


    }
}
