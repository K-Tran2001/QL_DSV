using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SQL_TTHETHONG
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_TTHETHONG() { }
        public SQL_TTHETHONG(DataProvider data)
        {
            dt = data;
        }



        //  SỬA DỮ LIỆU
        public void TTHT_Update(TTHETHONG ex)
        {
            String sql = "TTHT_Update @tinh , @donViChuQuan , @tenTruong , @khoaHoc , @nganhHoc , @chuyenNganh";
            dt.ExcuteNoneQuery(sql, new object[] { ex.tinh,ex.donViChuQuan,ex.tenTruong,ex.khoaHoc,ex.nganhHoc,ex.chuyenNganh});

        }
        public DataTable TTHT_SelectAll()
        {
            String sql = "TTHT_SelectAll";
            return dt.ExcuteQuery(sql, new object[] { });
        }

    }
}
