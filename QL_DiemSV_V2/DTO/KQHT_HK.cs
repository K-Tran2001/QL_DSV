using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    class KQHT_HK
    {
        public String maSV { get; set; }
        public String maHP { get; set; }
        public int lanThi { get; set; }
        public double diemThi { get; set; }
        public double diemQT { get; set; }
        public double diemTB { get; set; }

        public String xepLoai { get; set; }
        public String trangThai { get; set; }
    }
}
