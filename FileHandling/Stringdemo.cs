using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Stringdemo
    {
        public void showStringdemo()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("i am learning file handling in csharp");
            sw.WriteLine("this is demo of string writer and string reader class");
            sw.Close();
            StringReader sr = new StringReader(sw.ToString());
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

        }
    }
}
