using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
 
    //single dimensional array
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] arr = { 77,3,64,18,38,21,43,9,52,1,74 };
             Array1 a1 = new Array1();
             a1.showArray(arr);
             a1.minArray(arr);
             a1.maxArray(arr);
            */

            /*  Array2 a2 = new Array2();
              a2.dynamicArray();
            */

          /* Array3 a3 = new Array3();
            a3.jaggedArray();
          */

            /*Array4 a4 = new Array4();
            a4.Param();
            */
            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();

        }
    }
}
