using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array1
    {
        // public int[] arr = { 10, 20, 30, 40, 50 };

        public void showArray(int[] arr)
        {
            //traversing array using for loop
            Console.WriteLine("with for loop");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Value at index {0} is ==> {1}", i, arr[i]);
            }
            Console.WriteLine();

            //traversing using foreach loop
            Console.WriteLine("with foreach loop");
            foreach (int j in arr)
            {
                Console.WriteLine("Value is ==> " + j);
            }
        }

        public void minArray(int[] minarr)
        {
            int min = minarr[0];
            for(int i =0; i<minarr.Length; i++)
            {
                if (min > minarr[i])
                {
                    min = minarr[i];
                }

            }
            Console.WriteLine("Minimum element in array is {0}", min);
        }


            public void maxArray(int[] maxarr)
            {
                int max = maxarr[0];
            for (int i = 0; i < maxarr.Length; i++)
            {
                    if (max < maxarr[i])
                    {
                        max = maxarr[i];
                    }

                }
            Console.WriteLine("Maximum element in array is {0}",max);
            }
        
    }
}
