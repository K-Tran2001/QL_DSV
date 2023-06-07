using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    class SQL_THONGBAO
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_THONGBAO() { }
        public SQL_THONGBAO(DataProvider data)
        {
            dt = data;
        }
        // THÊM DỮ LIỆU
        public void DKHP_Insert(THONGBAO ex)
        {
            String sql = "TB_Insert @1 , @2 , @3";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.ndThongBao, ex.tgThongBao });

        }
       
        
        //  XÓA DỮ LIỆU
        public void TB_DeleteByTG()//phan biet
        {
            String sql = "TB_DeleteByTG ";
            dt.ExcuteNoneQuery(sql, new object[] { "" });
        }
        public void TB_DeleteBymaSV_TG(string maSV)//phan biet
        {
            String sql = "TB_DeleteBymaSV_TG @1";
            dt.ExcuteNoneQuery(sql, new object[] {maSV });
        }
        //  LẤY DỮ LIỆU
        public DataTable TB_SelectBymaSV(string maSV)//phan biet
        {
            String sql = "TB_SelectBymaSV_TG  @1";
            return dt.ExcuteQuery(sql, new object[] { maSV });
        }

    }
}
