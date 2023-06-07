using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SQL_TAIKHOAN
    {
        DataProvider dt = new DataProvider();//= new DataProvider();
        public SQL_TAIKHOAN() { }
        public SQL_TAIKHOAN(DataProvider dt)
        {
            this.dt = dt;
        }
        // THÊM DỮ LIỆU
        public void TK_Insert(TAIKHOAN ex)
        {
            String sql = "TK_Insert @1 , @2 , @3 , @4";
            dt.ExcuteNoneQuery(sql, new object[] { ex.taiKhoan, ex.matKhau ,ex.tenTaiKhoan,ex.loaiTaiKhoan});

        }
        //  SỬA DỮ LIỆU
        public void TK_Update(TAIKHOAN ex)
        {
            String sql = "TK_Update @1 , @2 , @3 , @4";
            dt.ExcuteNoneQuery(sql, new object[] { ex.taiKhoan, ex.matKhau,ex.tenTaiKhoan,ex.loaiTaiKhoan });
        }
        public void TK_UpdatemK(TAIKHOAN ex)
        {
            String sql = "TK_UpdatemK @1 , @2 ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.taiKhoan, ex.matKhau });
        }
        //  XÓA DỮ LIỆU
        public void TK_Delete(String taiKhoan)//phan biet
        {
            String sql = "TK_Delete @maHK ";
            dt.ExcuteNoneQuery(sql, new object[] {taiKhoan });
        }
        //  LẤY DỮ LIỆU
        public DataTable TK_SelectAll()// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "TK_SelectAll";
            DataTable result = dt.ExcuteQuery(sql, new object[] {""});
            return result;

        }
        public DataTable TK_SelectBytaiKhoan(String taiKhoan)// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "TK_SelectBytaiKhoan @taiKhoan";
            DataTable result = dt.ExcuteQuery(sql, new object[] {taiKhoan});
            return result;

        }
    }
}
