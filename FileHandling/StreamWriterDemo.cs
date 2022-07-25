using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class StreamWriterDemo
    {
        public void showStreamDemo()
        {
            FileStream f1 = new FileStream("d:\\Malay C#\\gitrepo\\Csharp-Training-\\streamdemo.txt", FileMode.OpenOrCreate);//creating file
            StreamWriter stw = new StreamWriter(f1);
            stw.WriteLine("file handling in c# with stream writer and stream reader");
            stw.Close();
            f1.Close();

            FileStream f2 = new FileStream("d:\\Malay C#\\gitrepo\\Csharp-Training-\\streamdemo.txt", FileMode.OpenOrCreate);//creating file
            StreamReader str = new StreamReader(f2);
            string filedata = str.ReadLine();
            Console.WriteLine("data inside file is ");
            Console.WriteLine(filedata);
            str.Close();
            f2.Close();

        }
    }
}
