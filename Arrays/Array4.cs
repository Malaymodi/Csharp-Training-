using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array4
    {
        public void Param()
        {
            void totalMarks(params int[] marks)
            {
                int total=0;
                for(int i=0; i<marks.Length; i++)
                {
                    total += marks[i];
                }
                Console.WriteLine("Total marks is {0} ", total);
            }

          


            totalMarks(10, 20, 30);
            totalMarks(45, 39);

           

        }
    }
}
