using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bai3
    {
        public static void Run()
        {
            List<string> danhSach = new List<string>();
            string ten = string.Empty;
            Console.WriteLine("Nhap ten sinh vien (go end de ket thuc): ");

            ten = Console.ReadLine();
            while (ten != "end")
            {
                //if (ten != string.Empty)
                {
                    danhSach.Add(ten);
                }
                
                ten = Console.ReadLine();
            }
            
            Console.WriteLine("\nDanh sach sinh vien: ");
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.WriteLine(danhSach[i]);
            }

            string tenDaiNhat = danhSach[0];
            int doDaiTenDaiNhat = tenDaiNhat.Length;
            for (int i = 1; i < danhSach.Count; i++)
            {
                int doDaiTenHienTai = danhSach[i].Length; // nguyen van minh // length = 15
                Console.WriteLine("ten " + danhSach[i] + " do dai " + doDaiTenHienTai);

                if (doDaiTenHienTai > doDaiTenDaiNhat)
                {
                    tenDaiNhat = danhSach[i];
                    doDaiTenDaiNhat = tenDaiNhat.Length;
                }
            }
            Console.WriteLine("\nTen sinh vien dai nhat: " + tenDaiNhat);
        }
    }
}
