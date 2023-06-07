using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class SQL_KQHT
    {
        DataProvider dt = new DataProvider();

        // THÊM DỮ LIỆU
        public void KQHT_Insert(KQHT ex)
        {
            String sql = "KQHT_Insert @maSV , @maHP , @lanThi , @diem , @xepLoai , @trangThai";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP, ex.lanThi,ex.diem,ex.xepLoai,ex.trangThai}) ;

        }
        //  SỬA DỮ LIỆU
        public void KQHT_Update(KQHT ex)
        {
            String sql = "KQHT_Update @maSV , @maHP , @lanThi , @diem , @xepLoai , @trangThai";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP, ex.lanThi, ex.diem, ex.xepLoai, ex.trangThai });
        }
        //  XÓA DỮ LIỆU
        public void KQHT_Delete(string maSV,string maHP)
        {
            String sql = "KQHT_Delete @maSV , @maHP";
            dt.ExcuteNoneQuery(sql, new object[] {maSV, maHP});
        }
        public void KQHT_DeleteBymaSV(string maSV)
        {
            String sql = "KQHT_DeleteBymaSV @maSV";
            dt.ExcuteNoneQuery(sql, new object[] {maSV});
        }
        //  LẤY DỮ LIỆU
        public DataTable KQHT_SelectAll()
        {
            String sql = "KQHT_SelectAll ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }
        public DataTable KQHT_SelectBymaSV(String maSV)
        {
            String sql = "KQHT_SelectBymaSV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] {maSV});
            return result;
        }
        public DataTable KQHT_SelectBymaSV_maHK(String maSV,string maHK)
        {
            String sql = "KQHT_SelectBymaSV_maHK @1 , @2";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV,maHK });
            return result;
        }

    }
}
