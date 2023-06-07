using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SQL_HOCPHAN
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_HOCPHAN() { }
        public SQL_HOCPHAN(DataProvider data)
        {
            dt = data;
        }

        // THÊM DỮ LIỆU
        public void HP_Insert(HOCPHAN ex)
        {
            String sql = "HP_Insert @maHP , @tenHP , @soTC , @maHK";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maHP, ex.tenHP, ex.soTC,ex.maHK });


        }
        //  SỬA DỮ LIỆU
        public void HP_Update(HOCPHAN ex)
        {
            String sql = "HP_Update @maHP , @tenHP , @soTC , @maHK";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maHP, ex.tenHP, ex.soTC, ex.maHK });
        }
        //  XÓA DỮ LIỆU
        public void HP_Delete(string maHP)//Xoa o maGV x maHP=> Xoa 1 mon
        {
            String sql = "HP_Delete @maHP ";
            dt.ExcuteNoneQuery(sql, new object[] {maHP});
        }
        //  LẤY DỮ LIỆU
        public DataTable HP_SelectAll()
        {
            String sql = "HP_SelectAll ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }

        public DataTable HP_SelectBymaHP(string maHP)
        {
            String sql = "HP_SelectBymaHP @maHP ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maHP});
            return result;

        }
        public DataTable HP_SelectBymaHK(string maHK)
        {
            String sql = "HP_SelectBymaHK @maHP ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maHK });
            return result;

        }
        //HP_SelectmaHK
        public DataTable HP_SelectmaHK(string maHP)
        {
            String sql = "HP_SelectmaHK @maHP ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maHP });
            return result;

        }

    }
}
