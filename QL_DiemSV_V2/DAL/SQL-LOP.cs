using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class SQL_LOP
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_LOP() { }
        public SQL_LOP(DataProvider data)
        {
            dt = data;
        }

        // THÊM DỮ LIỆU
        public void LOP_Insert(LOP ex)
        {
            String sql = "LOP_Insert @maLop , @tenLop , @ngayKhaiGiang , @maCN";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maLop, ex.tenLop, ex.ngayKhaiGiang,ex.maCN });

        }
        //  SỬA DỮ LIỆU
        public void LOP_Update(LOP ex)
        {
            String sql = "LOP_Update @maLop , @tenLop , @ngayKhaiGiang , @maCN";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maLop, ex.tenLop, ex.ngayKhaiGiang, ex.maCN });
        }
        //  XÓA DỮ LIỆU
        public void LOP_Delete(String maLop)//Xoa o maGV x maHP=> Xoa 1 mon
        {
            String sql = "LOP_Delete @maLop ";
            dt.ExcuteNoneQuery(sql, new object[] {maLop});
        }
        //  LẤY DỮ LIỆU
        public DataTable LOP_SelectAll()
        {
            String sql = "LOP_SelectAll ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }
        public DataTable LOP_SelectmaLop(String maLop)
        {
            String sql = "LOP_SelectBymaLop @maLop ";
            DataTable result = dt.ExcuteQuery(sql, new object[] {maLop });
            return result;

        }

    }
}
