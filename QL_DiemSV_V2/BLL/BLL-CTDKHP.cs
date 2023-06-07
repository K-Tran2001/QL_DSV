using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    class BLL_CTDKHP
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_CTDKHP() { }
        public BLL_CTDKHP(string iD)
        {
            this.iD = iD;
        }
        public BLL_CTDKHP(DataProvider data)
        {
            dt = data;
        }
        SQL_CTDKHP sql = new SQL_CTDKHP();
        Writelog wl = new Writelog();
        public void CTDKHP_Insert(CTDKHP ex)
        {
            sql.CTDKHP_Insert(ex);
            //wl = new Writelog(iD, "CTDKHP", "Them", "dtgDKHP");
        }
        //  SỬA DỮ LIỆU
        public void CTDKHP_Update(CTDKHP ex)
        {
            sql.CTDKHP_Update(ex);
            //wl = new Writelog(iD, "CTDKHP", "Sua", "dtgDKHP");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(string maSV,string maHP)
        {
            sql.CTDKHP_Delete(maSV,maHP);
            //wl = new Writelog(iD, "CTDKHP", "Xoa", "dtgDKHP");
        }
        //  LẤY DỮ LIỆU
        public DataTable CTDKHP_SelectAll()
        {
            //wl = new Writelog(iD, "CTDKHP", "Xem", "dtgDKHP");
            return sql.CTDKHP_SelectAll();
        }

        public DataTable CTDKHP_SelectBymaSV(string maLop)
        {
            //wl = new Writelog(iD, "CTDKHP", "Xem", "dtgDKHP");
            return sql.CTDKHP_SelectBymaSV(maLop);
        }
        public DataTable CTDKHP_SelectBymaSV_maHK(string maSV,string maHK)
        {
           // wl = new Writelog(iD, "CTDKHP", "Xem", "dtgDKHP");
            return sql.CTDKHP_SelectBymaSV_maHK(maSV,maHK);
        }
    }
}
