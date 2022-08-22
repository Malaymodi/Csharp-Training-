using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Demo
    {
        public void showDemo()
        {
            List<int> numlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Demo with Query Syntax
            Console.WriteLine("Demo with Query Syntax");
            var querysyntax = from num in numlist
                              where num > 3
                              select num;

            foreach (var item in querysyntax)
            {
                Console.WriteLine("Element is " + item);
            }
            Console.WriteLine();

            //Demo with method syntax
            Console.WriteLine("Demo with method syntax");
            var methodsyntax = numlist.Where(num => num > 3);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Element is " + item);
            }
            Console.WriteLine();
            //Demo with mixed syntax
            Console.WriteLine("Demo with mixed syntax");

            var mixedsyntax = (from num in numlist
                               select num).Max();

            Console.WriteLine(mixedsyntax);

        }
    }
}
