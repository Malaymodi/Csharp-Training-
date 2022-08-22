using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class SortingOperator
    {
        public void showData()
        {
            //order by demo
            Console.WriteLine("Orderby demo");
            var datasource = new List<int>() { 4,9,3,71,53,21,92,46,1,10,2,63};
            var querysyntax = from num in datasource
                              orderby num
                              select num;

            foreach(var item in querysyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

            Console.WriteLine();

            var methodsyntax = datasource.OrderBy(x => x);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

        }

        public void showData2()
        {
            var stringdata = new List<string>()
            { "Malay","Deep","Smit","Parth","Anshuman"};

            var querysyntax = from names in stringdata
                              orderby names
                              select names;

            foreach (var item in querysyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

            Console.WriteLine();

            var methodsyntax = stringdata.OrderBy(x=>x);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }
        }

       public void showDataDescending()
       {
            //order by descending demo
            Console.WriteLine("Orderby demo");
            var datasource = new List<int>() { 4, 9, 3, 71, 53, 21, 92, 46, 1, 10, 2, 63 };
            var querysyntax = from num in datasource
                              orderby num descending
                              select num;

            foreach (var item in querysyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

            Console.WriteLine();

            var methodsyntax = datasource.OrderByDescending(x => x);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

        }

        public void showDataDescending2()
       {
            var stringdata = new List<string>()
            { "Malay","Deep","Smit","Parth","Anshuman"};

            var querysyntax = from names in stringdata
                              orderby names descending
                              select names;

            foreach (var item in querysyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

            Console.WriteLine();

            var methodsyntax = stringdata.OrderByDescending(x => x);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }
        }

        public void reverseData()
        {
             int[] datasource = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querysyntax = (from num in datasource
                               select num).Reverse();

            foreach(var item in querysyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }

            Console.WriteLine();
            var methodsyntax = datasource.Reverse();
            foreach(var item in methodsyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }    
        }
    }
}
