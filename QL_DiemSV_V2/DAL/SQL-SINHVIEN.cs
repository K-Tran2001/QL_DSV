using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SQL_SINHVIEN
    {
        DataProvider dt=new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_SINHVIEN() { }
        public SQL_SINHVIEN(DataProvider data)
        {
            dt = data;
        }



        // THÊM DỮ LIỆU
        public void SV_Insert(SINHVIEN ex)
        {
            String sql = "SV_Insert @maSV , @tenSV , @gioiTinh , @ngaySinh , @diaChi , @dienThoai , @maLop";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV,ex.tenSV,ex.gioiTinh,ex.ngaySinh,ex.diaChi,ex.dienThoai,ex.maLop });
            
        }
        //  SỬA DỮ LIỆU
        public void SV_Update(SINHVIEN ex)
        {
            String sql = "SV_Update @maSV , @tenSV , @gioiTinh , @ngaySinh , @diaChi , @dienThoai , @maLop";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maSV, ex.tenSV, ex.gioiTinh, ex.ngaySinh, ex.diaChi, ex.dienThoai, ex.maLop });
        }
        //  XÓA DỮ LIỆU
        public void SV_Delete(string maSV)//Xoa o maGV x maHP
        {
            String sql = "SV_Delete @maSV";
             dt.ExcuteNoneQuery(sql, new object[] {maSV});
        }
        //  LẤY DỮ LIỆU
        public DataTable SV_SelectAll()
        {
            String sql = "SV_SelectAll";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;
        }
        
        public DataTable SV_SelectBymaLop( String maLop)
        {
            String sql = "SV_SelectBymaLop @maLop";
            DataTable result = dt.ExcuteQuery(sql, new object[] {maLop });
            return result;
        }
        public DataTable SV_SelectBymaSV(String maSV)
        {
            String sql = "SV_SelectBymaSV @maLop";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV });
            return result;
        }
        public DataTable SV_SelectmaLopBymaSV(String maSV)
        {
            String sql = "SV_SelectmaLopBymaSV @maLop";
            DataTable result = dt.ExcuteQuery(sql, new object[] { maSV });
            return result;
        }
        //.....
    }
}
