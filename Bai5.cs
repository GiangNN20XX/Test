using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bai5
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

            public Student(int id, string name, double score)
            {
                Id = id;
                Name = name;
                Score = score;
            }

            public void Display() 
            { 
                Console.WriteLine(Id + " - " + Name + " - " + Score); 
            }
        }

        public static void Run()
        {
            List<Student> students = new List<Student>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Nhap sinh vien " + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Score: ");
                double score = double.Parse(Console.ReadLine()!);
                Student student = new Student(id, name, score);
                students.Add(student);
            }
            Console.WriteLine("\nDanh sach sinh vien: ");

            //for (int i = 0; i < students.Count; i++) {
            //    Student student = students[i];
            //    student.Display();
            //}

            foreach (Student student in students)
            {
                student.Display();
            }
        }
    }
}
