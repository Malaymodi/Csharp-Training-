using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array2
    {
        public void dynamicArray()
        {
            int rows, cols;
            Console.WriteLine("Enter Number of rows ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of cols ");
            cols = Convert.ToInt32(Console.ReadLine());

            int[,] values = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Enter array elements");
                    values[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }


            Console.WriteLine("Full Array is");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    Console.Write(values[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Your specified value is");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    if (i == j)
                    {
                        Console.Write(values[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
