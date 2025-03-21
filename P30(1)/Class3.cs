using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_1_
{
    public class American : Person
    {
        public American(string name) { Name = name; }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, {Name}! How are you?");
        }
    }
}
