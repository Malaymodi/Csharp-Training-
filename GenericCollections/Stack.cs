using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Stack
    {
        public void showStack()
        {
            Stack<string> fruits = new Stack<string> { };
            //adding to stack
            fruits.Push("Apple");
            fruits.Push("Banana");
            fruits.Push("Chickoo");
            fruits.Push("Mango");

            //displaying the stack elements
            foreach (string f in fruits)
            {
                Console.WriteLine("Value is {0}", f);
            }

            Console.WriteLine();
            //removing the last element with pop method
            fruits.Pop();
            //displaying the stack elements after last element is removed
            foreach (string f in fruits)
            {
                Console.WriteLine("Value is {0}", f);
            }

            //use of contains method
            Console.WriteLine();
            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("Element found");
            }

            //use of peek method
            Console.WriteLine();
            Console.WriteLine(fruits.Peek());

            //use of gethashcode method
            Console.WriteLine();
            Console.WriteLine("HashCode of stack is");
            Console.WriteLine(fruits.GetHashCode());

            //use of equals method
            Stack<string> fruit = new Stack<string> { };
            //adding to stack
            fruit.Push("Apple");
            fruit.Push("Banana");
            fruit.Push("Chickoo");
            
            if(fruits.Equals(fruit))
            {
                Console.WriteLine("Both stack are equal");
            }

            fruit = fruits;
            Console.WriteLine(fruits.Equals(fruit));

            //displaying the stack elements
            foreach (string f in fruits)
            {
                Console.WriteLine("Value is {0}", f);
            }

            //displaying the stack elements
            foreach (string f in fruit)
            {
                Console.WriteLine("Value is {0}", f);
            }

        }
    }
}
