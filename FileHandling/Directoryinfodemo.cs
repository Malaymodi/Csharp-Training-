using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Directoryinfodemo
    {
        public void showDirectorydemo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Malay C#\gitrepo\Csharp-Training-\DOTNET");
            dir.Create();//creating directory
            Console.WriteLine("directory created succesfully");
            dir.Delete();
            Console.WriteLine("directory deleted");

        }
    }
}
