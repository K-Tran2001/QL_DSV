using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    class SQL_CTDKHP
    {
        DataProvider dt=new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_CTDKHP() { }
        public SQL_CTDKHP(DataProvider data)
        {
            dt = data;
        }
        public void CTDKHP_Insert(CTDKHP ex)
        {
            
            String sql = "CTDKHP_Insert @1 , @2";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP });
            //
            sql = "KQHT_HK_Insert @maSV , @maHP , @lanThi , @diemThi , @diemQT , @diemTB , @xepLoai , @trangThai";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP, 0, 0,0,0, "F", "Chưa thi" });
            sql = "NOHP_Insert @1 , @2 ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP });
            //

        }
        //  SỬA DỮ LIỆU
        public void CTDKHP_Update(CTDKHP ex)
        {
            String sql = "CTDKHP_Update @1 , @2 ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP });
        }
        //  XÓA DỮ LIỆU
        public void CTDKHP_Delete(String maSV,String maHP)//phan biet
        {
            String sql = "CTDKHP_Delete @1 , @2 ";
            dt.ExcuteNoneQuery(sql, new object[] {maSV, maHP});
        }
        //  LẤY DỮ LIỆU
        public DataTable CTDKHP_SelectAll()// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "CTDKHP_SelectAll";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }
        public DataTable CTDKHP_SelectBymaSV(String maSV)// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "CTDKHP_SelectBymaSV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV });
            return result;

        }
        public DataTable CTDKHP_SelectBymaSV_maHK(String maSV,string maHK)// mặc định ""=> đặc biệt dùng điều kiện
        {
            String sql = "CTDKHP_SelectBymaSV_maHK @1 , @2";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV,maHK });
            return result;

        }
    }
}
