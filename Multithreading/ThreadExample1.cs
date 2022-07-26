using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class ThreadExample1
    {
        public static void callThreadExample1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
