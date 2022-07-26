using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class ThreadExample7
    {
        public void callThreadexample7()
        {
            lock(this){
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
