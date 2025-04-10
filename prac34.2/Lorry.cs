using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34._2
{
    internal class Lorry:Vehicle
    {
        private int maxCapacity;
        public int MaxCapacity { get; set; }
        public Lorry(int prise, int maxspeed, int year, int maxCapacity)
            : base(prise, maxspeed, year)
        {
            this.MaxCapacity = maxCapacity;
        }
    }
}
