using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.Methood1();  
            derived.Methood2();  
            derived.Methood3();
            derived.Methood4();
        }
    }
}
