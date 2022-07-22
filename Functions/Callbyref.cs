using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Callbyref
    {
       public void show(ref int value, int v)
        {
            value += value;
            v += v;
            Console.WriteLine("Value of reference variable inside function is {0}", value);
            Console.WriteLine("Value of non-reference variable inside function is {0}", v);
            Console.WriteLine();
        }
    }
}
