using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class HashSet
    {
        public void showHashSet()
        {
            HashSet<string> city = new HashSet<string>();
            city.Add("Rajkot");
            city.Add("Surat");
            city.Add("Baroda");
            city.Add("Ahmedabad");
            city.Add("Banglore");
            city.Add("Hyderabad");
            city.Add("Chennai");
            city.Add("Pune");

            foreach(var val in city)
            {
                Console.WriteLine("Value is {0}", val);
            }

            Console.WriteLine();
          

            //adding value in hashset
            city.Add("Delhi");
            Console.WriteLine("After add method");
           
            foreach (var val in city)
            {
                Console.WriteLine("Value is {0}", val);
            }

            //copyto method
            Console.WriteLine();
            Console.WriteLine("copyto method");
            string[] hs = new string[10];
            city.CopyTo(hs);
            foreach (var val in hs)
            {
                Console.WriteLine("Value is {0}", val);
            }

            //subset method
            HashSet<string> subhash = new HashSet<string>() { "Rajkot","Pune"};
            if(subhash.IsSubsetOf(city))
            {
                Console.WriteLine();
                Console.WriteLine("is subset");
            }

            if (subhash.IsProperSubsetOf(city))
            {
                Console.WriteLine();
                Console.WriteLine("is proper subset");
            }

            if (city.IsSupersetOf(subhash))
            {
                Console.WriteLine();
                Console.WriteLine("is superset");
            }

            if (city.IsProperSupersetOf(subhash))
            {
                Console.WriteLine();
                Console.WriteLine("is proper superset");
            }

           


            Console.WriteLine();
            Console.WriteLine("Total number of elements in HashSet is " + city.Count());
        }
    }
}
