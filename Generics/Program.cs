using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Generic_demo<T>
    {
       
        public void generic_method(T Value)
        {
            Console.WriteLine("Value is "+Value+" and type of value is "+typeof(T));
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of generic class");
            
            Generic_demo<string> gd1 = new Generic_demo<string>();
            gd1.generic_method("Malay Modi");

            Generic_demo<int> gd2 = new Generic_demo<int>();
            gd2.generic_method(100);

            Generic_demo<float> gd3 = new Generic_demo<float>();
            gd3.generic_method(50.55f);

            Console.ReadLine();

        }
    }
}
