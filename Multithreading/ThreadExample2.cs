using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class ThreadExample2
    {
        public void method1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("i of method 1 {0}",i);
                if(i==4)
                {
                    Thread.Sleep(300);
                }
            }


        }

        public void method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i of method 2 {0}", i);
               
            }
        }

        public void callThreadExample2()
        {
            Thread thr1 = new Thread(method1);
            Thread thr2 = new Thread(method2);
            thr1.Start();
            thr2.Start();
        }
    }
}
