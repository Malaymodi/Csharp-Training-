using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Csharp_Training
{
    class Copy_constructor
    {
        int x;
        public Copy_constructor(int a)
        {
            x = a;
        }

        public Copy_constructor(Copy_constructor cc)
        {
            x = cc.x;
        }

        public void display_copy_constructor()
        {
            Console.WriteLine("value of x is "+x);
        }
    }
}
