using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace DAL
{
    class SQL_DKHP
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_DKHP() { }
        public SQL_DKHP(DataProvider data)
        {
            dt = data;
        }
        // THÊM DỮ LIỆU
        public void DKHP_Insert(DKHP ex)
        {
            String sql = "DKHP_Insert @1 , @2 , @3";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHK,ex.tongTC });

        }
        //  SỬA DỮ LIỆU
        public void DKHP_Update(DKHP ex)
        {
            String sql = "DKHP_Update @1 , @2 , @3";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHK, ex.tongTC });
        }
        //DKHP_UpdatetongTC
        public void DKHP_UpdatetongTC(DKHP ex)
        {
            String sql = "DKHP_UpdatetongTC @1 , @2 , @3";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHK, ex.tongTC });
        }
        //  XÓA DỮ LIỆU
        public void DKHP_Delete(String maSV)//phan biet
        {
            String sql = "DKHP_Delete @1";
            dt.ExcuteNoneQuery(sql, new object[] { maSV});
        }
        //  LẤY DỮ LIỆU
        public DataTable DKHP_SelectAll()// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "DKHP_SelectAll";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }
        public DataTable DKHP_SelectBymaSV(string maSV)// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "DKHP_SelectBymaSV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV});
            return result;

        }
        //DKHP_SelectBymaSV_maHK
        public DataTable DKHP_SelectBymaSV_maHK(string maSV,string maHK)// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "DKHP_SelectBymaSV_maHK @1 , @2";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV,maHK });
            return result;

        }
        
    }
}
