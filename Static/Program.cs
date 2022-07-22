using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{

    static class student
    {
        public static string name = "Ram";
        public static int age = 24;
        public static string collegename;

        static student()

        {
            collegename = "GLS University";
        }

    }
    class Program
    {

        public enum weekDays { Monday, Tuesday, Wednesday, Thurdsay, Friday, Saturday, Sunday};
        static void Main(string[] args)
        {
            Console.WriteLine("Name of student is {0}", student.name);
            Console.WriteLine("Age of student is {0}", student.age);
            Console.WriteLine("College of student is {0}", student.collegename);

            //demo of enum
            int a = (int)weekDays.Monday;
            int b = (int)weekDays.Tuesday;
            int c = (int)weekDays.Wednesday;
            int d = (int)weekDays.Thurdsay;
            int e = (int)weekDays.Friday;
            int f = (int)weekDays.Saturday;
            int g = (int)weekDays.Sunday;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            Console.ReadLine();

        }
    }
}
