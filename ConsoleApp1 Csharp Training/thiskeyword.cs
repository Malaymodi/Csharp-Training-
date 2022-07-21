using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Csharp_Training
{
    class thiskeyword
    {
        public string name;
        public int age;
        public string dept;
        public string city;

        public thiskeyword(string name, int age, string dept, string city )
        {
            this.name = name;       
            this.age = age; 
            this.dept = dept;           
            this.city = city;   
        }

        public void getDetails()
        {
            Console.WriteLine("Name is {0}", name);
            Console.WriteLine("Age is {0}", age);
            Console.WriteLine("Department is {0}", dept);
            Console.WriteLine("City is {0}", city);

        }
    }
}
