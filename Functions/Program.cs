using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{

    public class Callbyvalue
    {
        public void display(int a)
        {
            a += a;
            Console.WriteLine("Value of a inside function is {0}", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 25;
            Console.WriteLine("Value before function call is {0}", a);
            Callbyvalue cv = new Callbyvalue();
            cv.display(a);
            Console.WriteLine("Value after function call is {0}",a);
            */

            /* int value = 100;
             int v = 10;
             Console.WriteLine("Value of reference variable before function call is {0}", value);
             Console.WriteLine("Value of non-reference variable before function call is {0}", v);
             Console.WriteLine();

             Callbyref cv = new Callbyref();
             cv.show(ref value, v);

             Console.WriteLine("Value of reference variable after function call is {0}", value);
             Console.WriteLine("Value of non-reference variable after function call is {0}", v);
            */

            int v = 20;
            Console.WriteLine("Value before function call {0}", v);
            outkeyword ok = new outkeyword();
            ok.show(out v);
            Console.WriteLine("Value after function call {0}", v);


            Console.ReadLine();
        }
    }
}
