using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    class SQL_KQHT_HK
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_KQHT_HK() { }
        public SQL_KQHT_HK(DataProvider data)
        {
            dt = data;
        }

        // THÊM DỮ LIỆU
        public void KQHT_HK_Insert(KQHT_HK ex)
        {
            String sql = "KQHT_HK_Insert @maSV , @maHP , @lanThi , @diemThi , @diemQT , @diemTB , @xepLoai , @trangThai";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP, ex.lanThi, ex.diemThi,ex.diemQT,ex.diemTB, ex.xepLoai, ex.trangThai });

        }
        //  SỬA DỮ LIỆU
        public void KQHT_HK_Update(KQHT_HK ex)
        {
            String sql = "KQHT_HK_Update @maSV , @maHP , @lanThi , @diemThi , @diemQT , @diemTB , @xepLoai , @trangThai";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.maHP, ex.lanThi, ex.diemThi,ex.diemQT,ex.diemTB, ex.xepLoai, ex.trangThai });
        }
        //  XÓA DỮ LIỆU
        public void KQHT_HK_Delete(string maSV, string maHP)
        {
            String sql = "KQHT_HK_Delete @maSV , @maHP";
            dt.ExcuteNoneQuery(sql, new object[] { maSV, maHP });
        }
        public void KQHT_HK_DeleteBymaSV(string maSV)
        {
            String sql = "KQHT_HK_DeleteBymaSV @maSV";
            dt.ExcuteNoneQuery(sql, new object[] { maSV });
        }
        //  LẤY DỮ LIỆU
        public DataTable KQHT_HK_SelectAll()
        {
            String sql = "KQHT_HK_SelectAll ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;

        }
        public DataTable KQHT_HK_SelectBymaSV(String maSV)
        {
            String sql = "KQHT_HK_SelectBymaSV @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV });
            return result;
        }
        public DataTable KQHT_HK_SelectBymaSV_maHK(String maSV, string maHK)
        {
            String sql = "KQHT_HK_SelectBymaSV_maHK @1 , @2";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV, maHK });
            return result;
        }
        //KQHT_HK_SelectBymaLop

        public DataTable KQHT_HK_SelectBymaLop(String maSV)
        {
            String sql = "KQHT_HK_SelectBymaLop @1";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV });
            return result;
        }
        public DataTable KQHT_HK_SelectBymaLop_maHK(String maLop,string maHK)
        {
            String sql = "KQHT_HK_SelectBymaLop_maHK @1 , @2";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maLop,maHK });
            return result;
        }
    }
}
