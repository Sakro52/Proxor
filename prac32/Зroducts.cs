using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    internal class Products:Goods
    {
        public Products(string name, decimal price, DateTime prodproductiondate, DateTime bestbeforedate)
        : base(name, price, prodproductiondate, bestbeforedate)
        { }
        public override void PrintInfo()
        {
            Console.WriteLine($"Продукт: {Name}\nЦена: {Price} руб.\nДата производства: {Productiondate:dd.MM.yyyy}\nСрок годности: {Bestbeforedate:dd.MM.yyyy}");
            Console.WriteLine(Expired() ? "Продукт просрочен." : "Продукт не просрочен.");
        }
    }

}

