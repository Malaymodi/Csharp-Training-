using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Queue
    {
        public void showQueue()
        {
            Queue<string> vegetables = new Queue<string> { };
            //adding to queue
            vegetables.Enqueue("Tomato");
            vegetables.Enqueue("Potato");
            vegetables.Enqueue("Brinjal");
            vegetables.Enqueue("Cabbage");

            //displaying the elements of queue
            foreach(string v in vegetables)
            {
                Console.WriteLine("value is {0}",v);
                
            }

            //removing the firts element with dequeue method
            vegetables.Dequeue();
            Console.WriteLine();
            Console.WriteLine("after removing the first element");
            foreach (string v in vegetables)
            {
                Console.WriteLine("value is {0}", v);

            }


        }
    }

}
