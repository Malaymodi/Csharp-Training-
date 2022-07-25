using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class List
    {
        public void showList()
        {
            var list = new List<string>();
            list.Add("Java");
            list.Add("C#");
            list.Add("Python");
            list.Add("PHP");
            list.Add("C++");
            list.Add("Ruby");
            list.Add("C");
            list.Add("Go");
            list.Add("Angular");
            list.Add("Vue");
            list.Add("React");

            //Displaying list values
            foreach(var item in list)
            {
                Console.WriteLine("Value is {0}",item);
            }

            //Total number of values in list is 

            Console.WriteLine("Total elements in list is "+list.Count);

            //sorting our list
            list.Sort();
            Console.WriteLine();
            Console.WriteLine("Sort Method");
            //Displaying list values
            foreach (var item in list)
            {
                Console.WriteLine("Value is {0}", item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Reverse Method");
            //reversing our list
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine("Value is {0}", item);
            }

            Console.WriteLine();
            Console.WriteLine("Insert Method");

            //inserting value at specified index
            list.Insert(3, "Mysql");
            foreach (var item in list)
            {
                Console.WriteLine("Value is {0}", item);
            }
            //list.Remove();

            //removing value from specified index
            list.RemoveAt(4);
            Console.WriteLine();
            Console.WriteLine("RemoveAt Method for 4th index element");

            //removing value 
            list.Remove("PHP");
            Console.WriteLine();
            Console.WriteLine("After removing php from list");


            //use of add range method
            // adds specified collection at end of list

            string[] arr = { "ASP.NET", "ADO.NET" };
            list.AddRange(arr);
            Console.WriteLine();
            Console.WriteLine("After addrange method");
            foreach (var item in list)
            {
                Console.WriteLine("Value is {0}", item);
            }

            //indexof method
            Console.WriteLine();
            Console.WriteLine("The index of java in list is " + list.IndexOf("Java"));

            

            //remove range method
            list.RemoveRange(3, 2);
            Console.WriteLine();
            Console.WriteLine("After removerange method");
            foreach (var item in list)
            {
                Console.WriteLine("Value is {0}", item);
             
            }

            

            //getting the type of list
            Console.WriteLine();
            Console.WriteLine("The type of list is" +list.GetType());

          


            //Remobing all elements
             list.Clear();
             foreach (var item in list)
             {
                 Console.WriteLine("Value is {0}", item);
             }



        }
    }
}
