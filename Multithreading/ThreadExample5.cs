using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class ThreadExample5
    {
        public void callThreadExample5()
        {
            Thread t = Thread.CurrentThread;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(t.Name + " is Running");
            }
        }

    }
}
