using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bai1
    {
        public static void Run()
        {
            double diem;
            string tiep;

            do
            {
                Console.Write("Nhap diem (0-10): ");
                diem = Convert.ToDouble(Console.ReadLine());

                if (diem < 0 || diem > 10)
                {
                    Console.WriteLine("Diem khong hop le! Vui long nhap lai");
                }
                else if (diem < 5)
                {
                    Console.WriteLine("Truot");
                }
                else if (diem < 7)
                {
                    Console.WriteLine("Trung binh");
                }
                else if (diem < 8.5)
                {
                    Console.WriteLine("Kha");
                }
                else
                {
                    Console.WriteLine("Gioi");
                }

                Console.Write("Ban co muon nhap tiep? (Y/N): ");
                tiep = Console.ReadLine()!;

            } while (tiep == "Y" || tiep == "y");

            Console.WriteLine("Ket thuc chuong trinh!");
        }
    }
}
