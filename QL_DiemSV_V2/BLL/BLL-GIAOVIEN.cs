using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Security.Cryptography;
using QL_DiemSV_V2;

namespace BLL
{
    public class BLL_GIAOVIEN
    {
        string iD = "AD";
        DataProvider dt;
        public BLL_GIAOVIEN() { }
        public BLL_GIAOVIEN(string iD)
        {
            this.iD = iD;
        }
        public BLL_GIAOVIEN(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        SQL_GIAOVIEN sql = new SQL_GIAOVIEN();
        SQL_CTGIANGDAY sqlctgd = new SQL_CTGIANGDAY();
        SQL_TAIKHOAN sqltk = new SQL_TAIKHOAN();
        TAIKHOAN tk = new TAIKHOAN();
        MD5 md5 = MD5.Create();
        Xuly xl = new Xuly();


        public void GV_Insert(GIAOVIEN ex)
        {
            sql.GV_Insert(ex);

            tk.taiKhoan = ex.maGV;
            tk.tenTaiKhoan = ex.tenGV;
            tk.matKhau = xl.GetMd5Hash(md5,"123"); tk.loaiTaiKhoan = "GV";
            sqltk.TK_Insert(tk);
            //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        }
        //  SỬA DỮ LIỆU
        public void GV_Update(GIAOVIEN ex)
        {
            sql.GV_Update(ex);
            //wl = new Writelog(iD, "GIAOVIEN", "Sua", "dtgGV");
        }
        //  XÓA DỮ LIỆU
        public void GV_Delete(String maGV)
        {
            sqlctgd.CTGD_DeleteBymaGV(maGV);
            sql.GV_Delete(maGV);
            //wl = new Writelog(iD, "GIAOVIEN", "Xoa", "dtgGV");
        }
        //  LẤY DỮ LIỆU
        public DataTable GV_SelectAll()
        {
            //wl = new Writelog(iD, "GIAOVIEN", "Xem", "dtgGV");
            return sql.GV_SelectAll();
        }
        public DataTable GV_SelectBymaGV(string maGV)
        {
            //wl = new Writelog(iD, "GIAOVIEN", "Xem", "dtgGV");
            return sql.GV_SelectBymaGV(maGV);
        }
        public DataTable GV_SelectmaLopBymaGV(string maGV)
        {
            //wl = new Writelog(iD, "GIAOVIEN", "Xem", "dtgGV");
            return sql.GV_SelectmaLopBymaGV(maGV);
        }


    }
}
