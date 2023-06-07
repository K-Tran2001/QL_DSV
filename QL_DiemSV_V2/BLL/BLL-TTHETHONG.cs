using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_TTHETHONG
    {
        DataProvider dt;

        SQL_TTHETHONG sql = new SQL_TTHETHONG();
        public BLL_TTHETHONG() { }
        public BLL_TTHETHONG(DataProvider data)
        {
            dt = data;
        }
        //  SỬA DỮ LIỆU
        public void TTHT_Update(TTHETHONG ex)
        {
            sql.TTHT_Update(ex);
        }
        public DataTable TTHT_SelectAll()
        {
            return sql.TTHT_SelectAll();
        }

    }
}
