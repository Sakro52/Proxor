using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34._2
{
    internal class Car : Vehicle
    {
        private int power;
        public int Power { get; set; }
        public Car(int price, int maxspeed, int year, int power)
         : base(price, maxspeed, year)
        {
            this.Power = power;
        }

    }
}
