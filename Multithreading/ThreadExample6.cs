using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class ThreadExample6
    {
        public void callThreadExample6()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
}
