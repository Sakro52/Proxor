using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    abstract class Goods
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Productiondate{ get; set; }
        public DateTime Bestbeforedate { get; set; }
        public Goods(string name, decimal price, DateTime productiondate, DateTime bestbeforedate)
        {
           Name = name;
            Price = price;
            Productiondate = productiondate;
            Bestbeforedate = bestbeforedate;
            
        }
        public abstract void PrintInfo();
        public bool Expired()
        {
            return Bestbeforedate < DateTime.Now;
        }
    }
}

