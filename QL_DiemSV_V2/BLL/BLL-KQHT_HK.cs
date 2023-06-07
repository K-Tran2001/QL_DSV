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

    class BLL_KQHT_HK
    {
        string iD="AD";
        DataProvider dt;
        public BLL_KQHT_HK() { }
        public BLL_KQHT_HK(string iD)
        {
            this.iD = iD;
        }
        public BLL_KQHT_HK(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_KQHT_HK sql = new SQL_KQHT_HK();
        public void KQHT_HK_Insert(KQHT_HK ex)
        {
            sql.KQHT_HK_Insert(ex);
            //wl = new Writelog(iD, "KQHT_HK", "Them", "dtgKQHT");
        }
        //  SỬA DỮ LIỆU
        public void KQHT_HK_Update(KQHT_HK ex)
        {
            sql.KQHT_HK_Update(ex);
            //wl = new Writelog(iD, "KQHT_HK", "Sua", "dtgKQHT");
        }
        //  XÓA DỮ LIỆU
        public void KQHT_HK_Delete(String maSV, string maHP)
        {
            sql.KQHT_HK_Delete(maSV, maHP);
            //wl = new Writelog(iD, "KQHT_HK", "Xoa", "dtgKQHT");
        }
        public void KQHT_HK_DeleteBymaSV(String maSV)
        {
            //wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT");
            sql.KQHT_HK_DeleteBymaSV(maSV);
        }
        //  LẤY DỮ LIỆU
        public DataTable KQHT_HK_SelectAll()
        {
            //wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT");
            return sql.KQHT_HK_SelectAll();
        }
        public DataTable KQHT_HK_SelectBymaSV(string maSV)
        {
            //wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT");
            return sql.KQHT_HK_SelectBymaSV(maSV);
        }
        public DataTable KQHT_HK_SelectBymaLop(string maSV)
        {
            //wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT");
            return sql.KQHT_HK_SelectBymaLop(maSV);
        }
        //KQHT_HK_SelectBymaLop_maHK
        public DataTable KQHT_HK_SelectBymaLop_maHK(string maLop,string maHK)
        {
            //wl = new Writelog(iD, "KQHT_HK", "Xem", "dtgKQHT");
            return sql.KQHT_HK_SelectBymaLop_maHK(maLop,maHK);
        }
        public DataTable KQHT_HK_SelectBymaSV_maHK(string maSV, string maHK)
        {
            return sql.KQHT_HK_SelectBymaSV_maHK(maSV, maHK);
        }
    }
}
