using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Csharp_Training
{
    class Destructor
    {
        public string fname;

        public void getname()
        {
            Console.WriteLine("Your name is " + fname);
        }

        ~Destructor()
        {
            Console.WriteLine("We have called Destructor");
        }
    }
}
