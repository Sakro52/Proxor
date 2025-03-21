using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_1_
{
    public class Ukraine : Person
    {
        public Ukraine(string name) { Name = name; }

        public override void SayHello()
        {
            Console.WriteLine($"Привіт {Name} Пане міс! як справи");
        }
    }


}