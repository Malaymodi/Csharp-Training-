using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class ProjectionOperator
    {
        public void showData()
        {
            //demo of select
            Console.WriteLine("Demo of select");
            List<Employee> emplist = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Malay", Email = "Malay@gmail.com"},
                new Employee(){Id = 2, Name = "Deep", Email = "Deep@gmail.com"},
                new Employee(){Id = 3, Name = "Anshuman", Email = "Anshuman@gmail.com"},
                new Employee(){Id = 4, Name = "Smit", Email = "Smit@gmail.com"},
                new Employee(){Id = 5, Name = "Parth", Email = "Parth@gmail.com"},
            };

            var querysyntax = (from emp in emplist
                              select emp).ToList();

            var methodsyntax = emplist.ToList();

            foreach(var item in methodsyntax)
            {
                Console.WriteLine("id is {0} Name is {1}  Email is {2}"
                                   ,item.Id,item.Name, item.Email);
            }

            //demo of select many
            Console.WriteLine();
            Console.WriteLine("Demo of select many");

            List<string> mylist = new List<string>() { "Malay", "Modi" };
            var methodoutput = mylist.SelectMany(x => x).ToList() ;
            foreach(var item in methodoutput)
            {
                Console.WriteLine(item);
            }
        }
    }
}
