using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace QL_DiemSV_V2
{
    public class Xuly
    {
        public int diemSo(double diem)
        {
            int d;
            if (diem >= 8.5) d = 4;
            else if (diem >= 7) d = 3;
            else if (diem >= 5.5) d = 2;
            else if (diem >= 4) d = 1;
            else d = 0;
            return d;
        }
        public String diemChu(double diem)
        {
            String d;
            if (diem >= 8.5) d = "A";
            else if (diem >= 7) d = "B";
            else if (diem >= 5.5) d = "C";
            else if (diem >= 4) d = "D";
            else d = "F";
            return d;
        }
        public String xepLoaiHe10(double diem)
        {
            String d;
            if (diem >= 8.5) d = "Giỏi";
            else if (diem >= 7) d = "Khá";
            else if (diem >= 5.5) d = "Trung bình";
            else if (diem >= 4) d = "Yếu";
            else d = "Kém";
            return d;
        }
        public String xepLoaiHe4(double diem)
        {
            String d;
            if (diem >= 3.6) d = "Xuất sắc";
            else if (diem >= 2.5) d = "Giỏi";
            else if (diem >= 2) d = "Trung bình";
            else d = "Yếu";
            return d;
        }
        public String trangThai(double diem)
        {
            String d = "";
            if (diem > 5.5) d = "Qua môn";
            else if (diem >= 3 && diem <= 5.5) d = "Thi cải thiện";
            else d = "Nợ học phần";
            return d;
        }

        // Hàm mã hóa        
        // Tham khảo tại https://msdn.microsoft.com/enus/library/system.security.cryptography.md5.aspx
        public  string GetMd5Hash(MD5 md5Hash, string input)
        {

            //Convert the input string to a byte array and compute the hash.            
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            //Create a new Stringbuilder to collect the bytes             
            //and create a string.            
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data              // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));

            }
            return sBuilder.ToString();
        }
    }
}
