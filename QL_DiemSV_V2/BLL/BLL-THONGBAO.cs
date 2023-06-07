using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class BLL_THONGBAO
    {
        DataProvider dt;
        public BLL_THONGBAO() { }
        public BLL_THONGBAO(DataProvider data)
        {
            dt = data;
        }
       SQL_THONGBAO  sql = new SQL_THONGBAO();
        public void DKHP_Insert(THONGBAO ex)
        {
            sql.DKHP_Insert(ex);
        }
       
        
        //  XÓA DỮ LIỆU
        public void TB_DeleteByTG()
        {
            sql.TB_DeleteByTG();
        }
        public void TB_DeleteByTG(string maSV)
        {
            sql.TB_DeleteBymaSV_TG(maSV);
        }
        //  LẤY DỮ LIỆU
        public DataTable TB_SelectBymaSV(string maSV)
        {
            return sql.TB_SelectBymaSV(maSV);
        }
        
    }
}
