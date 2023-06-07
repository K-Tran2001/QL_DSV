using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    class BLL_NOHP
    {
        SQL_NOHP sql = new SQL_NOHP();
        public void NOHP_Insert(NOHP ex)
        {
            sql.NOHP_Insert(ex);
        }
        //  XOA DỮ LIỆU
        public void NOHP_Delete(NOHP ex)
        {
            sql.NOHP_Delete(ex);
        }
        
        
        //  LẤY DỮ LIỆU
        public DataTable NOHP_SelectBymaSV(string maSV)
        {
            return sql.NOHP_SelectBymaSV(maSV);
        }

       
    }
}
