using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;





namespace DAL
{
    
   public  class SQL_CTGIANGDAY 
    {
        DataProvider dt = new DataProvider();
        // THÊM DỮ LIỆU
        public SQL_CTGIANGDAY() { }
        public SQL_CTGIANGDAY(DataProvider data)
        {
            dt = data;
        }

        // THÊM DỮ LIỆU
        public void CTGD_Insert(CTGIANGDAY ex)
        {
            String sql = "CTGD_Insert @maGV , @maHP , @tgHoc";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maGV, ex.maHP, ex.tgHoc});
        }
        //  SỬA DỮ LIỆU
        public void CTGD_Update(CTGIANGDAY ex)
        {
            String sql = "CTGD_Update @maGV , @maHP , @tgHoc ";
            dt.ExcuteNoneQuery(sql, new object[] { ex.maGV, ex.maHP, ex.tgHoc });
        }
        //  XÓA DỮ LIỆU
        public void CTGD_Delete(string maGV,string maHP )//Xoa o maGV x maHP=> Xoa 1 mon
        {
            String sql = "CTGD_Delete @maGV , @maHP ";
            dt.ExcuteNoneQuery(sql, new object[] { maGV,maHP});
        }
        public void CTGD_DeleteBymaGV(String maGV)//Xoa o maGV x maHP=> Xoa 1 mon
        {
            String sql = "CTGD_DeleteBymaGV @maGV ";
            dt.ExcuteNoneQuery(sql, new object[] {maGV});
        }
        //  LẤY DỮ LIỆU
        public DataTable CTGD_SelectAll()
        {
            String sql = "CTGD_SelectAll ";
            DataTable result = dt.ExcuteQuery(sql, new object[] { "" });
            return result;
        }
        public DataTable CTGD_SelectbymaGV(String maGV)
        {
            String sql = "CTGD_SelectbymaGV @maGV";
            DataTable result = dt.ExcuteQuery(sql, new object[] {maGV });
            return result;
        }
        
        
        
    }
}
