using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data;
using DTO;

namespace DAL
{
    public class SQL_HOCKY
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_HOCKY() { }
        public SQL_HOCKY(DataProvider data)
        {
            dt = data;
        }
        // THÊM DỮ LIỆU
        public void HK_Insert(HOCKY ex)
        {
            String sql = "HK_Insert @maHK , @tenHK ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maHK, ex.tenHK});

        }
        //  SỬA DỮ LIỆU
        public void HK_Update(HOCKY ex)
        {
            String sql = "HK_Update @maHK , @tenHK ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maHK, ex.tenHK });
        }
        //  XÓA DỮ LIỆU
        public void HK_Delete(String maHK)//phan biet
        {
            String sql = "HK_Delete @maHK ";
            dt.ExcuteNoneQuery(sql, new object[] { maHK});
        }
        //  LẤY DỮ LIỆU
        public DataTable HK_SelectAll ()// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "HK_SelectAll";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }

    }
}
