using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class outkeyword
    {
        public void show(out int v)
        {
            v = 25;
            Console.WriteLine("Inside function with out parameter{0}",v);
        }
    }
}
