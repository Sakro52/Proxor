using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    internal class Set:Goods
    {
        public List<Products> Products { get; set; }
        public Set(string name, decimal price, DateTime productiondate, DateTime bestbeforedate, List<Products> products)
        : base(name, price, productiondate, bestbeforedate)
        {
            Products = products;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Комплект: {Name}\nЦена: {Price} руб.\nДата производства: {Productiondate:dd.MM.yyyy}\nСрок годности: {Bestbeforedate:dd.MM.yyyy}");
            Console.WriteLine("Состав комплекта:");
            foreach (var продукт in Products)
            {
                продукт.PrintInfo();
            }
            Console.WriteLine(Expired() ? "Комплект просрочен." : "Комплект не просрочен.");
        }
    }
}

