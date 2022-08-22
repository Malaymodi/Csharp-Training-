using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class FilteringOperator
    {
        public void showData()
        {

            //integer example
            var numlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var querysyntax = from number in numlist
                              where number > 5
                              select number;

            foreach (var item in querysyntax)
            {
                Console.WriteLine("Number is {0}", item);
            }
            Console.WriteLine();
            var methodsyntax = numlist.Where(x => x > 2 && x < 7);
            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Number is {0}", item);
            }

            Console.WriteLine();
            //string example
            var tutorial = new List<string>()
            { "C# Tutorial","Sql","Java Tutorial","linq",};

            var queryresult = from skill in tutorial
                              where skill == "Sql"
                              select skill;

            foreach(var item in queryresult)
            {
                Console.WriteLine("Value is {0}", item);
            }

            var methodresult = tutorial.Where(x => x.Contains("Tutorial"));

            foreach (var item in methodresult)
            {
                Console.WriteLine("Value is {0}", item);
            }

        }

        public void showData2()
        {
            //oftype demo
            Console.WriteLine();
            Console.WriteLine("OfType demo");
            var objlist = new List<Object>()
            { "Malay","Deep",1,2,3,4,5};


            var methodsyntax = objlist.OfType<int>();
            foreach(var item in methodsyntax)
            {
                Console.WriteLine("Element is {0}", item);
            }
        }
    }
}
