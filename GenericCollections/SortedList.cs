using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class SortedList
    {
        public void showSortedList()
        {
            SortedList<string, string> cars = new SortedList<string, string>();
            cars.Add("Maruti","Swift");
            cars.Add("Hyundai", "i10");
            cars.Add("Tata", "Nano");
            cars.Add("Mahindra", "Fortuner");

            foreach(var c in cars)
            {
                Console.WriteLine("key is {0} and value is {1}", c.Key, c.Value);
            }

            //use of trygetvalue method
            Console.WriteLine();
            string value = "";
            Console.WriteLine(cars.TryGetValue("Tata",out value));
            Console.WriteLine(value);

        }
    }
}
