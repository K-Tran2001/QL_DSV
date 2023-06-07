using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace DAL
{
    class SQL_HOCKY
    {
        DataProvider cn = new DataProvider();
        // THÊM DỮ LIỆU
        public void AddData(CTHDB ex)
        {
            cn.ExcuteReaderData(@"INSERT INTO CHITIETHDBAN (MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan) VALUES (N'" + ex.MaHD + "',N'" + ex.MaSP + "',N'" + ex.SLBan + "',N'" + ex.DonGiaBan + "',N'" + ex.ThanhTienBan + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(CTHDB ex)
        {
            cn.ExcuteReaderData(@"UPDATE CHITIETHDBAN SET SLBan =N'" + ex.SLBan + "', DonGiaBan =N'" + ex.DonGiaBan + "', ThanhTienBan =N'" + ex.ThanhTienBan + "' Where MaSP=N'" + ex.MaSP + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(CTHDB ex)
        {
            cn.ExcuteReaderData(@"DELETE FROM CHITIETHDBAN Where MaSP=N'" + ex.MaSP + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetData("Select * from CHITIETHDBAN " + Condition);
        }
        public DataTable CheckValue(string Condition)
        {
            return cn.GetData("Select * from CHITIETHDBAN " + Condition);
        }
        public void DeleteAllData(CTHDB ex)
        {
            cn.ExcuteReaderData(@"Delete from CHITIETHDBAN where mahd = '" + ex.MaHD + "'");
        }
    }
}
