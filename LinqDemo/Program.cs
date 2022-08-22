using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for demo class
            /*Demo d = new Demo();
            d.showDemo();
            */

            //for projection operator class
            /* ProjectionOperator po = new ProjectionOperator();
             po.showData();
            
            */

            //for filtering operator
            /* FilteringOperator fo = new FilteringOperator();
             fo.showData();
             fo.showData2();
             Console.ReadLine();
            */

            //for sorting operator
            /* SortingOperator so = new SortingOperator();
             so.showData();
             so.showData2();
             so.showDataDescending();
             so.showDataDescending2();
             so.reverseData();
            */

            //for innerjoin
            Innerjoin ij = new Innerjoin();
            ij.showData();

        }
    }
}
