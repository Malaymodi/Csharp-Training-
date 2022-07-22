using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array3
    {
        public void jaggedArray()
        {
            int[][] jarr = { new int[] { 1,2,3 },
                        new int[] { 4,5,6 },
                        new int[] { 7,8,9 },
                        new int[] { 10,11,12 },
                        new int[] { 13,14,15 } };

            Console.WriteLine("Total Elements inside jagged array is "+jarr.Length);
            for(int i=0; i<jarr.Length; i++)
            {
                Console.WriteLine("Array at index {0} of jagged array",i);
                
                for(int j=0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j]+ " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            
        }
    }
}
