using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class ThreadExample4
    {
        public void callThreadExample4()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
}
