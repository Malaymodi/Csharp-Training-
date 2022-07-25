using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class SortedSet
    {
        public void showSortedSet()
        {
            SortedSet<string> city = new SortedSet<string>();
            city.Add("Rajkot");
            city.Add("Surat");
            city.Add("Baroda");
            city.Add("Ahmedabad");
            city.Add("Banglore");
            city.Add("Hyderabad");
            city.Add("Chennai");
            city.Add("Pune");

            //this is shorted set 
            // here bydefault all elements are sorted even if we add in unsorted way
            foreach (var val in city)
            {
                Console.WriteLine("Value is {0}", val);
            }


            //for intersect with method
            SortedSet<string> city2 = new SortedSet<string>();
            city2.Add("Rajkot");
            city2.Add("Surat");
            city2.Add("Baroda");

            Console.WriteLine("The Intersection of both sortedset is");

            city.IntersectWith(city2);

            // To display the intersection of
            // mySortedSet1 and mySortedSet2
            foreach (string str in city)
            {
                Console.WriteLine(str);

            }
                // To display the intersection of
                // mySortedSet1 and mySortedSet2

             
            SortedSet<string> city3 = new SortedSet<string>();
             city3.Add("Bhavnagar");
             city3.Add("Dwarka");
             city3.Add("Palitana");

             Console.WriteLine("The Union of both sortedset is");

             city.UnionWith(city3);

             foreach (string str2 in city)
             {
                Console.WriteLine(str2);
             }


                Console.WriteLine();
        }
    }
}
