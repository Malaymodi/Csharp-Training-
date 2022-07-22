using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Csharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //copy contructor file
            //Copy_constructor cc = new Copy_constructor(25);
            //cc.display_copy_constructor();

            //Copy_constructor c1 = new Copy_constructor(cc);
            //cc.display_copy_constructor();

            //destructor file
            //Destructor d = new Destructor();
            //d.fname = "deep ";
            //d.getname();

            //this keyword file
            //thiskeyword tk = new thiskeyword("Malay Modi", 23, "Microsoft Dot Net", "Ahmedabad");
            //tk.getDetails();

            //static keyword file
            //object 1
             statickeyword sk1 = new statickeyword();
             sk1.studentname = "Jaydeep";
             Console.WriteLine("Name of student is {0} and name of school is {1}", sk1.studentname, statickeyword.schoolname);
             

            //object 2
             statickeyword sk2 = new statickeyword();
             sk2.studentname = "Yash";
             Console.WriteLine("Name of student is {0} and name of school is {1}", sk2.studentname, statickeyword.schoolname);
            


           /* public int a;
            Callbyvalue cv = new Callbyvalue();

                cv.a = 25;
            cv.display(a);*/



            Console.ReadLine();
        }
    }
}
