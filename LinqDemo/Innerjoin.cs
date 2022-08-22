using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Innerjoin
    {
        public void showData()
        {
            var Employee = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Malay", Email = "Malay@gmail.com",AddressId = 1},
                new Employee(){Id = 2, Name = "Deep", Email = "Deep@gmail.com",AddressId = 0},
                new Employee(){Id = 3, Name = "Anshuman", Email = "Anshuman@gmail.com",AddressId = 2},
                new Employee(){Id = 4, Name = "Smit", Email = "Smit@gmail.com",AddressId = 0},
                new Employee(){Id = 5, Name = "Parth", Email = "Parth@gmail.com",AddressId = 3},
            };

            var address = new List<Address>()
            {
                new Address(){Id = 1, Addresscity ="Rajkot"},
                new Address(){Id = 2, Addresscity ="Baroda"},
                new Address(){Id = 3, Addresscity ="Ahmedabad"},
                new Address(){Id = 4, Addresscity ="Surat"},
                new Address(){Id = 5, Addresscity ="Bhavnagar"},
            };

            var mark = new List<Marks>()
            {
                new Marks(){Id = 1, EmpId = 1 , TotalMarks=70},
                new Marks(){Id = 2, EmpId = 2 , TotalMarks=80},
                new Marks(){Id = 3, EmpId = 3 , TotalMarks=90},
            };

            var querysyntax = from emp in Employee
                              join addr in address
                              on emp.AddressId equals addr.Id
                              join m in mark
                              on emp.Id equals m.EmpId
                              select new
                              {
                                  Ename = emp.Name,
                                  City = addr.Addresscity,
                                  Totalmark = m.TotalMarks
                              };

            foreach(var item in querysyntax)
            {
                Console.WriteLine("Name is {0} and City is {1} and total marks is {2}",item.Ename,item.City,item.Totalmark);
            }

            var methodsyntax = Employee.Join(address,
                                  emp => emp.AddressId,
                                  addr => addr.Id,
                                  (emp,addr)=>new
                                  {
                                        Ename = emp.Name,
                                        City = addr.Addresscity

                                   });

            foreach (var item in methodsyntax)
            {
                Console.WriteLine("Name is {0} and City is {1}", item.Ename, item.City);
            }

        }
    }
}
