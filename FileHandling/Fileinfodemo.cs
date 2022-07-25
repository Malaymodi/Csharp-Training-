using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Fileinfodemo
    {
        public void showFileinfodemo()
        {
            string loc = "d:\\Malay C#\\gitrepo\\Csharp-Training-\\file.txt";

            FileInfo fi = new FileInfo(loc);
            //creating file 
           // fi.Create();

            //writing to the file
            StreamWriter sw = fi.CreateText();
            sw.WriteLine("demo of fileinfo class");
            sw.Close();

            //reading from the file
            StreamReader sr = fi.OpenText();
            string data = "";
            while((data = sr.ReadLine()) != null)
            {
                Console.WriteLine(data);
            }
            sr.Close();


        }
    }
}
