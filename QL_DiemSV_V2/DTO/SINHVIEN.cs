using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;

namespace DTO
{
    public class SINHVIEN
    {
        public SINHVIEN()
        {

        }
        public SINHVIEN(DataRow row)
        {
            
            this.maSV = row["maSV"].ToString();
            this.tenSV = row["tenSV"].ToString();
            this.gioiTinh = row["gioiTinh"].ToString();
            this.ngaySinh = (DateTime)row["ngaySinh"];
            this.diaChi = row["diaChi"].ToString();
            this.dienThoai = row["dienThoai"].ToString();
            this.dienThoai = row["dienThoai"].ToString();
            this.maLop = row["dienThoai"].ToString();
        }
        //public List<SINHVIEN> loadSINHVIENLIST(String Condition)
        //{
        //    BLL_SINHVIEN bllsv = new BLL_SINHVIEN();
        //    List<SINHVIEN> svList = new List<SINHVIEN>();
        //    try
        //    {
                
        //        DataTable data = bllsv.GetData(Condition);
        //        foreach (DataRow item in data.Rows)
        //        {
        //            SINHVIEN sv = new SINHVIEN(item);
        //            svList.Add(sv);
        //        }
                
        //    }
        //    catch
        //    {

        //    }
        //    return svList;

        //}
        public String maSV { get; set; }
       
        public String tenSV { get; set; }
        public String gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public String diaChi { get; set; }
        public String dienThoai { get; set; }
        public String maLop { get; set; }

    }
}
