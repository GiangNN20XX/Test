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

            bool tonTai = sinhVien.TryGetValue(timMa, out string tenSv);

            if (tonTai)
            {
                Console.WriteLine("Ten sinh vien: " + tenSv);
            }
            else
                Console.WriteLine("Khong tim thay");
        }
    }
}
