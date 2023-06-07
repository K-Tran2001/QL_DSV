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
    public class BLL_KQHT
    {

        SQL_KQHT sql = new SQL_KQHT();
        public void KQHT_Insert(KQHT ex)
        {
            sql.KQHT_Insert(ex);
        }
        //  SỬA DỮ LIỆU
        public void KQHT_Update(KQHT ex)
        {
            sql.KQHT_Update(ex);
        }
        //  XÓA DỮ LIỆU
        public void KQHT_Delete(String maSV, string maHP)
        {
            sql.KQHT_Delete(maSV,maHP);
        }
        public void KQHT_DeleteBymaSV(String maSV)
        {
            sql.KQHT_DeleteBymaSV(maSV);
        }
        //  LẤY DỮ LIỆU
        public DataTable KQHT_SelectAll()
        {
            return sql.KQHT_SelectAll();
        }
        public DataTable KQHT_SelectBymaSV(string maSV)
        {
            return sql.KQHT_SelectBymaSV(maSV);
        }
        public DataTable KQHT_SelectBymaSV_maHK(string maSV,string maHK)
        {
            return sql.KQHT_SelectBymaSV_maHK(maSV,maHK);
        }

    }
}
