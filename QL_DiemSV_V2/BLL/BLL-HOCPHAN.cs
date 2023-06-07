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
    public class BLL_HOCPHAN
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_HOCPHAN() { }
        public BLL_HOCPHAN(string iD)
        {
            this.iD = iD;
        }
        public BLL_HOCPHAN(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_HOCPHAN sql = new SQL_HOCPHAN();
        public void HP_Insert(HOCPHAN ex)
        {
            sql.HP_Insert(ex);
            //wl = new Writelog(iD, "HOCPHAN", "Them", "dtgHP");
        }
        //  SỬA DỮ LIỆU
        public void HP_Update(HOCPHAN ex)
        {
            sql.HP_Update(ex);
            //wl = new Writelog(iD, "HOCPHAN", "Sua", "dtgHP");
        }
        //  XÓA DỮ LIỆU
        public void HP_Delete(string maHP)
        {
            sql.HP_Delete(maHP);
            //wl = new Writelog(iD, "HOCPHAN", "Xoa", "dtgHP");
        }
        //  LẤY DỮ LIỆU
        public DataTable HP_SelectAll()
        {
            //wl = new Writelog(iD, "HOCPHAN", "Xem", "dtgHP");
            return sql.HP_SelectAll();
        }
        public DataTable HP_SelectBymaHP(string maHP)
        {
            //wl = new Writelog(iD, "HOCPHAN", "Xem", "dtgHP");
            return sql.HP_SelectBymaHP(maHP);
        }
        public DataTable HP_SelectBymaHK(string maHP)
        {
            //wl = new Writelog(iD, "HOCPHAN", "Xem", "dtgHP");
            return sql.HP_SelectBymaHK(maHP);
        }
        public DataTable HP_SelectmaHK(string maHP)
        {
            //wl = new Writelog(iD, "HOCPHAN", "Xem", "dtgHP");
            return sql.HP_SelectmaHK(maHP);
        }
    }
}
