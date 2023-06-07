using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using QL_DiemSV_V2;
using System.Security.Cryptography;

namespace BLL
{
    public class BLL_SINHVIEN
    {
        public string iD ="AD";
        DataProvider dt;
        public BLL_SINHVIEN() { }
        
        public BLL_SINHVIEN(string iD)
        {
            this.iD = iD;
        }
        public BLL_SINHVIEN(DataProvider data)
        {
            dt = data;
        }
        Writelog wl = new Writelog();
        //wl = new Writelog(iD, "GIAOVIEN", "Them", "dtgGV");
        SQL_SINHVIEN sql = new SQL_SINHVIEN();
        TAIKHOAN tk = new TAIKHOAN();
        SQL_TAIKHOAN sqltk = new SQL_TAIKHOAN();
        DKHP dkhp = new DKHP();
        SQL_DKHP sqldkhp = new SQL_DKHP();
        SQL_KQHT_HK sqlkqhthk = new SQL_KQHT_HK();
        SQL_HOCKY sqlhk = new SQL_HOCKY();
        MD5 md5 = MD5.Create();
        Xuly xl = new Xuly();

        public void SV_Insert(SINHVIEN ex)
        {
            sql.SV_Insert(ex);


            //Insert tai khoan
            tk.taiKhoan = ex.maSV;
            tk.tenTaiKhoan = ex.tenSV;
            tk.matKhau = xl.GetMd5Hash(md5, "123"); tk.loaiTaiKhoan = "SV";
            sqltk.TK_Insert(tk);
            //Insert DKHP
            dkhp.maSV = ex.maSV;dkhp.tongTC = 0;
            foreach(DataRow r in sqlhk.HK_SelectAll().Rows)
            {
                dkhp.maHK = r["maHK"].ToString();
                sqldkhp.DKHP_Insert(dkhp);
            }
            //wl = new Writelog(iD, "SINHVIEN", "Them", "dtgSV");
        }
        //  SỬA DỮ LIỆU
        public void SV_Update(SINHVIEN ex)
        {
            sql.SV_Update(ex);
            //wl = new Writelog(iD, "SINHVIEN", "Sua", "dtgSV");
        }
        //  XÓA DỮ LIỆU
        public void SV_Delete(String maSV)
        {
            //////////
            sqltk.TK_Delete(maSV);
            sqlkqhthk.KQHT_HK_DeleteBymaSV(maSV);
            sqldkhp.DKHP_Delete(maSV);
            /////
            sql.SV_Delete(maSV);
            //wl = new Writelog(iD, "SINHVIEN", "Xoa", "dtgSV");
        }
        //  LẤY DỮ LIỆU
        public DataTable SV_SelectAll()
        {
            //wl = new Writelog(iD, "SINHVIEN", "Xem", "dtgSV");
            return sql.SV_SelectAll();
        }
        public DataTable SV_SelectBymaLop(string maLop)
        {
            //wl = new Writelog(iD, "SINHVIEN", "Xem", "dtgSV");
            return sql.SV_SelectBymaLop(maLop);
        }
        public DataTable SV_SelectBymaSV(string maLop)
        {
            //wl = new Writelog(iD, "SINHVIEN", "Xem", "dtgSV");
            return sql.SV_SelectBymaSV(maLop);
        }
        public DataTable SV_SelectmaLopBymaSV(string maLop)
        {
            //wl = new Writelog(iD, "SINHVIEN", "Xem", "dtgSV");
            return sql.SV_SelectmaLopBymaSV(maLop);
        }
    }
}
