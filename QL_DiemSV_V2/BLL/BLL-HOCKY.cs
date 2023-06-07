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
    public class BLL_HOCKY
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_HOCKY() { }
        public BLL_HOCKY(string iD)
        {
            this.iD = iD;
        }
        public BLL_HOCKY(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_HOCKY sql = new SQL_HOCKY();
        public void HK_Insert(HOCKY ex)
        {
            sql.HK_Insert(ex);
            //wl = new Writelog(iD, "HOCKY", "Them", "dtgHK");
        }
        //  SỬA DỮ LIỆU
        public void HK_Update(HOCKY ex)
        {
            sql.HK_Update(ex);
            //wl = new Writelog(iD, "HOCKY", "Sua", "dtgHK");
        }
        //  XÓA DỮ LIỆU
        public void HK_Delete(string maHK)
        {
            sql.HK_Delete(maHK);
            //wl = new Writelog(iD, "HOCKY", "Xoa", "dtgHK");
        }
        //  LẤY DỮ LIỆU
        public DataTable HK_SelectAll()
        {
            //wl = new Writelog(iD, "HOCKY", "Xem", "dtgHK");
            return sql.HK_SelectAll();
        }
        
        
    }
}
