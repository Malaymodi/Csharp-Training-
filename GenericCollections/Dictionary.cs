using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Dictionary
    {

        public void showDictionary()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("Gujarat", "Rajkot");
            names.Add("Maharashtra", "Pune");
            names.Add("Tamil Nadu", "Chennai");
            names.Add("West Bengal", "Kolkata");
            
            foreach(var kvp in names)
            {
                Console.WriteLine("Key is {0} and Value is {1} ", kvp.Key, kvp.Value);
            }

            //Removing value with key
            names.Remove("Tamil Nadu");
            Console.WriteLine();
            Console.WriteLine("after removing value of key tamil nadu");
            foreach (var kvp in names)
            {
                Console.WriteLine("Key is {0} and Value is {1} ", kvp.Key, kvp.Value);
            }

        }
    }
}
