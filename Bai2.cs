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
            float tong = 0;
            int max = 0;
            int min = 15;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Nhap diem thu " + (i + 1) + ": ");
                diem[i] = int.Parse(Console.ReadLine()!);
                tong += diem[i];

                if (diem[i] > max || i == 0)
                {
                    max = diem[i];
                }
                  
                if (diem[i] < min || i == 0)
                {
                    min = diem[i];
                }
                
            }

            double DTB = (tong / n); //float 

            Console.WriteLine("Diem trung binh: " + DTB);
            Console.WriteLine("Diem cao nhat: " + max);
            Console.WriteLine("Diem thap nhat: " + min);
        }
    }
}
