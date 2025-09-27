using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bai6
    {
        class Student
        {
            private int id;
            private string name = "";
            private double score;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Score
            {
                get { return score; }
                set { score = value; }
            }

            public void Display()
            {
                Console.WriteLine("Ma: " + id + ", Ten: " + name + ", Diem: " + score);
            }
        }

        public static void Run()
        {
            List<Student> students = new List<Student>();

            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu " + (i + 1));
                Student stu = new Student();

                Console.Write("Ma: ");
                stu.Id = int.Parse(Console.ReadLine()!);

                Console.Write("Ten: ");
                stu.Name = Console.ReadLine()!;

                Console.Write("Diem: ");
                stu.Score = double.Parse(Console.ReadLine()!);

                students.Add(stu);
            }
            Console.WriteLine("\n--- Danh sach sinh vien ---");
            foreach (var s in students)
            {
                s.Display();
            }

            double timDiemCaoNhat = students[0].Score;
            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Score > timDiemCaoNhat)
                    timDiemCaoNhat = students[i].Score;
            }
            Console.WriteLine("\n--- Sinh vien co diem cao nhat ---");
            foreach (var s in students)
            {
                if (s.Score == timDiemCaoNhat)
                    s.Display();
            }

            Console.WriteLine("\n--- Sinh vien co diem >= 8 ---");
            foreach (var s in students)
            {
                if (s.Score >= 8)
                    s.Display();
            }

            Console.Write("\nNhap ten can tim: ");
            string keyword = Console.ReadLine()!.ToLower();

            Console.WriteLine("\n--- Ket qua tim kiem ---");
            for (int i = 0; i < students.Count; i++)
            {
                string ten = students[i].Name.ToLower();
                if (ten.Contains(keyword))
                {
                    students[i].Display();
                }
            }
        }
    }
}
