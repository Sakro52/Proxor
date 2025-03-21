using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
public abstract class PrintedPraducst
    {
        private string name;

        public PrintedPraducst() { }
        public PrintedPraducst(string name) { Name = name; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract void Print();

        public abstract double Cost();
        
    }
}

