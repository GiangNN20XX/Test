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
            string ten;
            Console.WriteLine("Nhap ten sinh vien (go end de ket thuc): ");

            ten = Console.ReadLine()!;
            while (ten != "end")
            {
                danhSach.Add(ten);
                ten = Console.ReadLine()!;
            }

            Console.WriteLine("\nDanh sach sinh vien: ");
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.WriteLine(danhSach[i]);
            }

            string tenDaiNhat = danhSach[0];
            for (int i = 1; i < danhSach.Count; i++)
            {
                if(danhSach[i].Length > tenDaiNhat.Length)
                {
                    tenDaiNhat = danhSach[i];
                }
            }
            Console.WriteLine("\nTen sinh vien dai nhat: " + tenDaiNhat);
        }
    }
}
