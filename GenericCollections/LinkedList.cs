using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class LinkedList
    {
        public void showLinkedList()
        {
            LinkedList<string> country = new LinkedList<string>();
            //adding elements to linked list with addlast method
            country.AddLast("USA");
            country.AddLast("UK");
            country.AddLast("India");
            country.AddLast("Africa");

            foreach (string c in country)
            {
                Console.WriteLine("value is {0}", c);
            }

            //use of addfirst method
            country.AddFirst("Australia");
            Console.WriteLine();
            Console.WriteLine("after add first method");
            foreach (string c in country)
            {
                Console.WriteLine("value is {0}", c);
            }

            //use of find method
            Console.WriteLine(country.Find("India"));
            Console.WriteLine();
            Console.WriteLine("after find method");
            foreach (string c in country)
            {
                Console.WriteLine("value is {0}", c);
            }


        }
    }
}
