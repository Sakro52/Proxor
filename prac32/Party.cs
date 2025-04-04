using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    internal class Party:Goods
    {
        public int Quantity { get; set; }

        public Party(string name, decimal price, DateTime productiondate, DateTime bestbeforedate, int quantity)
            : base(name, price, productiondate, bestbeforedate)
        {
            Quantity =  quantity;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Партия: {Name}\nЦена: {Price} руб.\nКоличество: {Quantity}\nДата производства: {Productiondate:dd.MM.yyyy}\nСрок годности: {Bestbeforedate:dd.MM.yyyy}");
            Console.WriteLine(Expired() ? "Партия просрочена." : "Партия не просрочена.");
        }
    }
}

