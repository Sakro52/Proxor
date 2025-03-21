using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_1_
{
    public class Russian : Person
    {
        public Russian(string name) { Name = name; }

        public override void SayHello()
        {
            Console.WriteLine($"Привет, {Name}! Как дела?");
        }
    }
}