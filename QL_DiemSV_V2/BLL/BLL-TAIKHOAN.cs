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
    public class BLL_TAIKHOAN
    {
        DataProvider dt= new DataProvider();
        string iD = "AD";
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_TAIKHOAN sql= new SQL_TAIKHOAN();
        public BLL_TAIKHOAN() { }
        public BLL_TAIKHOAN(string iD)
        {
            this.iD = iD;
        }
        public BLL_TAIKHOAN(DataProvider data)
        {
            dt = data;
            sql = new SQL_TAIKHOAN(dt);
        }
        
        public void TK_Insert(TAIKHOAN ex)
        {
            sql.TK_Insert(ex);
            //wl = new Writelog(iD, "TAIKHOAN", "Them", "dtgTK");
        }
        //  SỬA DỮ LIỆU
        public void TK_Update(TAIKHOAN ex)
        {
            sql.TK_Update(ex);
            //wl = new Writelog(iD, "TAIKHOAN", "Sua", "dtgTK");
        }
        public void TK_UpdatemK(TAIKHOAN ex)
        {
            sql.TK_UpdatemK(ex);
            //wl = new Writelog(iD, "TAIKHOAN", "DoiMK", "dtgTK");
        }
        //  XÓA DỮ LIỆU
        public void TK_Delete(String taiKhoan)
        {
            sql.TK_Delete(taiKhoan);
            //wl = new Writelog(iD, "TAIKHOAN", "Xoa", "dtgTK");
        }
        //  LẤY DỮ LIỆU
        public DataTable TK_SelectAll()
        {
            //wl = new Writelog(iD, "TAIKHOAN", "Xem", "dtgTK");
            return sql.TK_SelectAll();
        }
        public DataTable TK_SelectBytaiKhoan(string taiKhoan)
        {
            //wl = new Writelog(iD, "TAIKHOAN", "Xem", "dtgTK");
            return sql.TK_SelectBytaiKhoan(taiKhoan);
        }

    }
}
