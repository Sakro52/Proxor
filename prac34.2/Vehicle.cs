using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34._2
{
    abstract class Vehicle
    {
        protected int year;
        protected int price;
        protected int maxspeed;

        public int Price { get => price; set => price = value; }
        public int Maxspeed { get => maxspeed; set => maxspeed = value; }
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }
        public Vehicle() { }
        public Vehicle(int price, int maxspeed, int year)
        {
            this.Price = price;
            this.Maxspeed = maxspeed;
            this.Year = year;
        }
    }
}
