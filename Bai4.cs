using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bai4
    {
        public static void Run()
        {
            Dictionary<string, string> sinhVien = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Nhap ma sinh vien (go end de ket thuc): ");
                string ma = Console.ReadLine()!;

                if (ma == "end")
                    break;

                Console.WriteLine("Nhap ten sinh vien: ");
                string ten = Console.ReadLine()!;
                sinhVien[ma] = ten;
            }
            Console.WriteLine("\nNhap ma sinh vien can tim: ");
            string timMa = Console.ReadLine()!;

            bool tonTai = sinhVien.ContainsKey(timMa);
            if (tonTai)
            {
                string ten = sinhVien[timMa];
                Console.WriteLine("Ten sinh vien: " + ten);
            }
            else
                Console.WriteLine("Khong tim thay");
        }
    }
}
