using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate int ShowNumber(int n);
namespace Delegates
{
    
       
    class Program
    {
        static int num = 200;

        public static int Addnum(int a)
        {
            num = num + a;
            return num;
        }

        public static int Mulnum(int m)
        {
            num = num * m;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {

            ShowNumber sn1 = new ShowNumber(Addnum);
            
            ShowNumber sn2 = new ShowNumber(Mulnum);
            sn1(45);
            sn2(35);
            Console.WriteLine("Value with first delegate having add method "+getNum());
           

            Console.WriteLine("Value with second delegate having mul method "+getNum());
            Console.ReadLine();
            
        }
    }
}
