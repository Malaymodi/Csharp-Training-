using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class SortedDictionary
    {
        public void showSortedDictionary()
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("Rajkot", "Gujarat");
            names.Add("Pune", "Maharashtra");
            names.Add("Chennai", "Tamil Nadu");
            names.Add("Kolkata", "West Bengal");
            names.Add("Ahmedabad", "Gujarat");
            //key should be unique and not values
            //also the sorting is done oon the basis of key not on basis of value

            foreach (var kvp in names)
            {
                Console.WriteLine("Key is {0} and Value is {1} ", kvp.Key, kvp.Value);
            }

            //use of contains key method
            Console.WriteLine();
            Console.WriteLine("after contains key method");

            if(names.ContainsKey("Ahmedabad"))
            {
                Console.WriteLine("key found");
                
            }

            //use of contains value method
            Console.WriteLine();
            Console.WriteLine("after contains value method");

            if (names.ContainsValue("Maharashtra"))
            {
                Console.WriteLine("value found");

            }
        }
    }
}
