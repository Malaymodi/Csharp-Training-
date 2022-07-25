using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);//creating file stream  
             f.WriteByte(65);//writing byte into stream  
             for (int j = 65; j <= 90; j++)
             {
                 f.WriteByte((byte)j);
             }
             f.Close();
             FileStream f1 = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);//creating file stream  
             //reading from the file
             int i = 0;
             while (( i = f1.ReadByte()) != -1)
             {
                 Console.Write((char)i);
             }
             f1.Close();//closing stream
            */

            /*StreamWriterDemo sw = new StreamWriterDemo();
            sw.showStreamDemo();
            */

            /* Stringdemo sd = new Stringdemo();
             sd.showStringdemo();
            */

           /* Fileinfodemo fid = new Fileinfodemo();
            fid.showFileinfodemo();
           */

            Directoryinfodemo did = new Directoryinfodemo();
            did.showDirectorydemo();

            Console.ReadLine();
        }
    }
}
