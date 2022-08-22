using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Thread t = Thread.CurrentThread;
            t.Name = "This is my main thread";
            Console.WriteLine(t.Name);
            */


            //for thread example 1 class
            /*Thread t1 = new Thread(new ThreadStart(ThreadExample1.callThreadExample1));
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(ThreadExample1.callThreadExample1));
            t2.Start();
            */

            //for threadexample 2
            ThreadExample2 te2 = new ThreadExample2();
            te2.callThreadExample2();
            

            //for threadexample3
            /*ThreadExample3 te3 = new ThreadExample3();
            Thread t31 = new Thread(new ThreadStart(te3.callThreadExample3));
            t31.Start();
            Thread t32 = new Thread(new ThreadStart(te3.callThreadExample3));
            t32.Start();

            t31.Abort();
            */

            //for threadexample 4
            /* ThreadExample4 te4 = new ThreadExample4();
             Thread t41 = new Thread(new ThreadStart(te4.callThreadExample4));
             Thread t42 = new Thread(new ThreadStart(te4.callThreadExample4));
             Thread t43 = new Thread(new ThreadStart(te4.callThreadExample4));
             t41.Start();
             t41.Join();
             t42.Start();
             t43.Start();
            */

            //for threadexample 5
            /*ThreadExample5 te5 = new ThreadExample5();
            Thread t51 = new Thread(new ThreadStart(te5.callThreadExample5));
            Thread t52 = new Thread(new ThreadStart(te5.callThreadExample5));
            Thread t53 = new Thread(new ThreadStart(te5.callThreadExample5));

            t51.Name = "Thread 1";
            t52.Name = "Thread 2";
            t53.Name = "Thread 3";

            t51.Start();
            t52.Start();
            t53.Start();
            */

            //for threadexample 6
            /* ThreadExample6 te6 = new ThreadExample6();
             Thread t61 = new Thread(new ThreadStart(te6.callThreadExample6));
             Thread t62 = new Thread(new ThreadStart(te6.callThreadExample6));
             Thread t63 = new Thread(new ThreadStart(te6.callThreadExample6));

             t61.Name = "Thread 1";
             t62.Name = "Thread 2";
             t63.Name = "Thread 3";

             t61.Priority = ThreadPriority.Lowest;
             t62.Priority = ThreadPriority.Normal;
             t63.Priority = ThreadPriority.Highest;

             t61.Start();
             t62.Start();
             t63.Start();
            */

            //for thread example 7
            ThreadExample7 te7 = new ThreadExample7();
            Thread t71 = new Thread(new ThreadStart(te7.callThreadexample7));
            Thread t72 = new Thread(new ThreadStart(te7.callThreadexample7));

            t71.Start();
            t72.Start();



            Console.ReadLine();
        }
    }
}
