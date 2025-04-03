using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    using System;

    abstract class Figure
    {
        string name;

        public string Name { get => name; set => name = value; }

        public Figure(string name)
        {
            this.Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Print();
    }
}