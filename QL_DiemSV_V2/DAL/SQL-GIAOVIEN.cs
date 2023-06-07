using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SQL_GIAOVIEN
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_GIAOVIEN() { }
        public SQL_GIAOVIEN(DataProvider data)
        {
            dt = data;
        }
        // THÊM DỮ LIỆU
        public void GV_Insert(GIAOVIEN ex)
        {
            String sql = "GV_Insert @maGV , @tenGV  , @ngaySinh , @gioiTinh , @diaChi , @dienThoai , @maLop";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maGV, ex.tenGV,  ex.ngaySinh,ex.gioiTinh, ex.diaChi, ex.dienThoai, ex.eMail });

        }
        //  SỬA DỮ LIỆU
        public void GV_Update(GIAOVIEN ex)
        {
            String sql = "GV_Update @maGV , @tenGV  , @ngaySinh , @gioiTinh , @diaChi , @dienThoai , @maLop";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maGV, ex.tenGV, ex.ngaySinh, ex.gioiTinh, ex.diaChi, ex.dienThoai, ex.eMail });
        }
        //  XÓA DỮ LIỆU
        public void GV_Delete(String maGV)//Xoa o maGV x maHP
        {
            String sql = "GV_Delete @maGV";
            dt.ExcuteNoneQuery(sql, new object[] { maGV });
        }
        //  LẤY DỮ LIỆU
        public DataTable GV_SelectAll()
        {
            String sql = "GV_SelectAll";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;
        }
        public DataTable GV_SelectBymaGV(string maGV)
        {
            String sql = "GV_SelectBymaGV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maGV });
            return result;
        }
        public DataTable GV_SelectmaLopBymaGV(string maGV)
        {
            String sql = "GV_SelectmaLopBymaGV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maGV });
            return result;
        }


        //.....
    }
}
