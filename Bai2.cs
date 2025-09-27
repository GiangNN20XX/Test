using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bai2
    {
        public static void Run()
        {
            Console.Write("Nhap diem n: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] diem = new int[n];
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap diem thu " + (i + 1) + ": ");
                diem[i] = int.Parse(Console.ReadLine()!);
                tong += diem[i];
            }

            double DTB = (1.0 * tong / n);

            int max = diem[0];
            int min = diem[0];
            for (int i = 1; i < n; i++)
            {
                if (diem[i] > max)
                    max = diem[i];
                if (diem[i] < min)
                    min = diem[i];
            }
            Console.WriteLine("Diem trung binh: " + DTB);
            Console.WriteLine("Diem cao nhat: " + max);
            Console.WriteLine("Diem thap nhat: " + min);
        }
    }
}
