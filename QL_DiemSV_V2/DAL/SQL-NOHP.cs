using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    class SQL_NOHP
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_NOHP() { }
        public SQL_NOHP(DataProvider data)
        {
            dt = data;
        }
        // THÊM DỮ LIỆU
        public void NOHP_Insert(NOHP ex)
        {
            String sql = "NOHP_Insert @1 , @2 ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP});

        }
        //  XOA DỮ LIỆU
        public void NOHP_Delete(NOHP ex)
        {
            String sql = "NOHP_Delete @1 , @2 ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP });
        }
        
        //  LẤY DỮ LIỆU
        public DataTable NOHP_SelectBymaSV(string maSV)// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "NOHP_SelectBymaSV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV });
            return result;

        }
       
    }
}
